import React, { useState } from 'react';
import { 
    UserOutlined,
   LockOutlined
  } from "@ant-design/icons";
import "./LoginPage.css";
import { Form, Input, Spin,notification, Row,Col } from 'antd';
import { login } from '../../services/authServices';
import { Message } from '../../utils/helpers';
import { TypeMessage } from '../../utils/constants';
import { useAuthState } from '../../hooks/authState';
const LoginPage = () => {
    const [authState, setAuthState] = useAuthState()
    const [loading, setLoading] = useState(false);
    const [username, setUsername] = useState('');
    const [password, setPassword] = useState('');

    const onFinish = async (values) => {
        const { username, password } = values;
        setLoading(true);
        const data = await login(username, password);
        if (data) {
          
          notification.success({
            message: `Đăng nhập thành công`,
            description: "",
            placement: "topLeft",
          })
            setAuthState({
                ...authState,
                token: data.token
            })
            setLoading(false);
            window.location.replace('/')
        }
         else {
         
         
            setLoading(false);
        }
    };

    // useEffect(() => {
    //     const token = localStorage.getItem('token');
    //     if (token) {
    //         window.location.replace('/')
    //     }
    // }, []);

    return (
        <div id="login">
              <Spin spinning={loading} tip="Đang đăng nhập...">
            <section>
    
      <div className="img-bg">
        <img
          src="https://images.unsplash.com/photo-1470224114660-3f6686c562eb?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=735&q=80"
          alt="Hình Ảnh Minh Họa"
        />
      </div>

      <div className="noi-dung">
        <div className="form">
          <h2>PARKING EVERYWHERE</h2>
          <Form
                    // style={{
                    //     minWidth: 600,
                    // }}
                   
                    name="normal_login"
                    className="login-form"
                    initialValues={{
                        remember: true,
                    }}
                    onFinish={onFinish}
                >
                    <Form.Item className="ant-col ant-col-xs-24 ant-col-xl-24"
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
                    <Form.Item
                    className="ant-col ant-col-xs-24 ant-col-xl-24"
                        name="password"
                        rules={[
                            {
                                required: true,
                                message: 'Vui lòng nhập mật khẩu của bạn',
                            },
                        ]}
                    >
                        <Input.Password
                            prefix={<LockOutlined className="site-form-item-icon" />}
                            //type="password"
                            value={password} onChange={event => setPassword(event.target.value)}
                            placeholder="Mật khẩu"
                        />
                        
                        
                    </Form.Item>
                    <div><a href="/forgot-password" className="ant-col ant-col-xs-24 ant-col-xl-24">Quên mật khẩu ?</a> <br/></div>
                    <div className="input-form">
                      
                    <Form.Item className="ant-col ant-col-xs-24 ant-col-xl-24">
                   
                        <input type="submit" className="login-form-button" value=" Đăng nhập" style={{textAlign:"center"}} />
                           
                    </Form.Item>
                    </div>
               
                </Form>
                <div className="input-form ant-col ant-col-xs-24 ant-col-xl-24">
               
              <p >
                Bạn chưa có tài khoản? <a href="/register">Đăng ký</a>
              </p>
            </div>
         
        </div>
      </div>
      
    </section>
                
            </Spin>
        </div>
          
       

    )
};
export default LoginPage;