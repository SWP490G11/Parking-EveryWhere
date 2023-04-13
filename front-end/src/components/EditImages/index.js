import React, { useEffect, useState } from 'react';
import { PlusOutlined } from '@ant-design/icons';
import { Modal, Upload } from 'antd';
import axios from 'axios';
import config from '../../config';
import { Message } from '../../utils/helpers';
import { TypeMessage } from '../../utils/constants';

const getBase64 = (file) =>
    new Promise((resolve, reject) => {
        const reader = new FileReader();
        reader.readAsDataURL(file);
        reader.onload = () => resolve(reader.result);
        reader.onerror = (error) => reject(error);
    });
const EditImages = (props) => {
    const [previewOpen, setPreviewOpen] = useState(false);
    const [previewImage, setPreviewImage] = useState('');
    const [previewTitle, setPreviewTitle] = useState('');
    const [fileList, setFileList] = useState([]);

    useEffect(() => {
        setFileList(props.images)
    }, [props.images])

    // useEffect(() => {
    //     props.setImages(fileList);
    // }, [fileList, props])

    const handleCancel = () => setPreviewOpen(false);

    const handlePreview = async (file) => {
        if (!file.url && !file.preview) {
            file.preview = await getBase64(file.originFileObj);
        }
        setPreviewImage(file.url || file.preview);
        setPreviewOpen(true);
        setPreviewTitle(file.name || file.url.substring(file.url.lastIndexOf('/') + 1));
    };
    const handleChange = ({ fileList: newFileList }) => {
        setFileList(newFileList);
        props.setImages(fileList);
    }

    const uploadButton = (
        <div>
            <PlusOutlined />
            <div
                style={{
                    marginTop: 8,
                }}
            >
                Upload
            </div>
        </div>
    );

    const dummyRequest = (options) => {

        const data = new FormData()
        data.append('media', options.file)
        data.append('key', config.UPLOAD_API);
        data.append('upload', 'Upload Image');

        const configCustom = {
            headers: {
                'content-type': 'multipart/form-data',
            },
        }

        delete axios.defaults.headers.common["Authorization"];

        axios.post(options.action, data, configCustom)
            .then((res) => {
                if (res.data.success) {
                    console.log(res.data)
                    const image = {
                        uid: res.data.data.id,
                        name: res.data.data.id,
                        status: 'done',
                        url: res.data.data.media,
                    }
                    options.onSuccess(res.data.data, options.file)
                    fileList.pop();
                    fileList.push(image);
                    setFileList(fileList);
                    props.setImages(fileList);
                    Message(TypeMessage.SUCCESS, 'Upload success')
                } else {
                    Message(TypeMessage.ERROR, 'Upload failed. Invalid image')
                }
            }).catch((err) => {
                Message(TypeMessage.ERROR, 'Upload failed. Invalid image')
                console.log(err)
            })
    }

    return (
        <>
            <Upload
                listType="picture-card"
                customRequest={dummyRequest}
                action={config.UPLOAD_URL}
                fileList={fileList}
                onPreview={handlePreview}
                onChange={handleChange}
            >
                {fileList.length >= 8 ? null : uploadButton}
            </Upload>
            <Modal open={previewOpen} title={previewTitle} footer={null} onCancel={handleCancel}>
                <img
                    alt="example"
                    style={{
                        width: '100%',
                    }}
                    src={previewImage}
                />
            </Modal>
        </>
    );
};
export default EditImages;