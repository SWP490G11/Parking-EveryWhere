import { UploadOutlined } from '@ant-design/icons';
import config from '../../config';
import axios from 'axios';
import {
    Form,
    Upload,Button
} from 'antd';
import { Message } from '../../utils/helpers';
import { TypeMessage } from '../../utils/constants';
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
    return e?.fileList;
};


const UploadImage = ({ images, setImages,count }) => {

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
                    console.log(images)
                    options.onSuccess(res.data.data, options.file)
                    setImages([...images, res.data.data.media])
                } else {
                    Message(TypeMessage.ERROR, 'Tải ảnh lên gặp lỗi. Vui lòng thử lại')
                }
            }).catch((err) => {
                Message(TypeMessage.ERROR, 'Tải ảnh lên gặp lỗi. Vui lòng thử lại')
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
                    <Upload name="files" maxCount={count} customRequest={dummyRequest} action={config.UPLOAD_URL}  style={{ width: 120 }}  >
                    <Button icon={<UploadOutlined />}>Upload</Button>
                    </Upload>
                </Form.Item>
            </Form.Item>
        </Form>
    )
};

export default UploadImage;
