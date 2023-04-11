import { InboxOutlined } from '@ant-design/icons';
import config from '../config/config';
import React from 'react';
import axios from 'axios';
import {
    Form,
    Upload,
} from 'antd';
import { Message } from '../utils/helpers';
import { TypeMessage } from '../utils/constants';
const formItemLayout = {
    labelCol: {
        span: 6,
    },
    wrapperCol: {
        span: 14,
    },
};

const normFile = (e) => {
    console.log('Upload event:', e);
    if (Array.isArray(e)) {
        return e;
    }
    return e.fileList;
};


const UploadImage = ({ images, setImages }) => {

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
                    options.onSuccess(res.data.data, options.file)
                    setImages([...images, res.data.data.media])
                } else {
                    Message(TypeMessage.ERROR, 'Upload failed. Invalid image')
                }
            }).catch((err) => {
                Message(TypeMessage.ERROR, 'Upload failed. Invalid image')
                console.log(err)
            })
    }

    return (
        <Form
            name="validate_other"
            {...formItemLayout}
            style={{
                width: 600,
            }}
        >
            <Form.Item>
                <Form.Item name="dragger" valuePropName="fileList" getValueFromEvent={normFile} noStyle>
                    <Upload.Dragger name="files" customRequest={dummyRequest} action={config.UPLOAD_URL} style={{ width: 120 }}>
                        <p className="ant-upload-drag-icon">
                            <InboxOutlined />
                        </p>
                        <p className="ant-upload-text">Upload</p>
                    </Upload.Dragger>
                </Form.Item>
            </Form.Item>
        </Form>
    )
};
export default UploadImage;
