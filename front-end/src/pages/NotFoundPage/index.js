import React from 'react';
import { Button, Result } from 'antd';
import { Link } from 'react-router-dom';

const NotFoundPage = () => (
    <Result
        status="404"
        title="404"
        subTitle="Trang bạn đang truy cập không tồn tại!"
        extra={<Link to={'/'} ><Button type="primary">Trang chủ</Button></Link>}
    />
);

export default NotFoundPage;
