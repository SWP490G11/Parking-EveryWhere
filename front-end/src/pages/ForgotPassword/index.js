import React, { useState } from 'react';
import {
    FacebookOutlined,
    GoogleOutlined,
    UserOutlined,
    TwitterOutlined,LockOutlined
  } from "@ant-design/icons";

import { Form, Input, Spin,notification } from 'antd';
import api from '../../services/api'
const ForgotPassword = () => {
   
    const [loading, setLoading] = useState(false);
    const [username, setUsername] = useState('');
  
    const onFinish = async (values) => {
          setLoading(true)
          api.patch(`/api/User/ResetPassword?username=${values.username}`).then(()=>{
            setLoading(false);
            notification.success({
              message: `Thành công`,
              description: "Vui lòng kiểm tra e-mail của bạn",
              placement: "topLeft",
            })
            window.open('https://mail.google.com/mail/u/3/#inbox');
            window.location.href ='/login'

          }).catch(()=>{
            setLoading(false);
            notification.warning({
              message: `Thất bại`,
              description: "Không tìm tháy tài khoản của bạn. Vui lòng kiểm tra lại",
              placement: "topLeft",
            })
          })
          
          
    };

   

    return (
        <div id="login">
              <Spin spinning={loading} tip="Đang tìm kiếm...">
            <section>
      
      <div className="img-bg" >
        <img
          src="https://images.unsplash.com/photo-1470224114660-3f6686c562eb?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=735&q=80"
          alt="Hình Ảnh Minh Họa"
        />
      </div>

      <div className="noi-dung">
        <div className="form">
          <h2>Quên mật khẩu</h2>
          <Form
                    // style={{
                    //     minWidth: 600,
                       
                    // }}
                    // labelCol={{
                    //     span: 8,
                    //   }}
                    //   wrapperCol={{
                    //     span: 16,
                    //   }}
                    name="normal_login"
                    className="login-form"
                    initialValues={{
                        remember: true,
                    }}
                    onFinish={onFinish}
                >
                    <Form.Item
                        className="ant-col ant-col-xs-24 ant-col-xl-24"
                        name="username"
                        rules={[
                            {
                                required: true,
                                message: 'Vui lòng nhập tài khoản của bạn',
                            },
                        ]}
                    >
                        <Input prefix={<UserOutlined className="site-form-item-icon" />} value={username} onChange={event => setUsername(event.target.value)} placeholder="Tài khoản" />
                    </Form.Item>
                   
                    <div className="input-form">
                    <Form.Item className="ant-col ant-col-xs-24 ant-col-xl-24">
                        <input type="submit" className="login-form-button" value="Tìm" style={{textAlign:"center"}} />
                           
                        
                    </Form.Item>
                    </div>
               
                </Form>
                <div className="input-form ant-col ant-col-xs-24 ant-col-xl-24">
              <p style={{textAlign:"center"}}>
                Bạn đã có tài khoản? <a href="/login">Đăng nhập</a>
              </p>
            </div>
          
        </div>
      </div>
      
    </section>
                
            </Spin>
        </div>
          
       

    )
};
export default ForgotPassword;