import React, { useState, useContext ,useEffect} from "react";
import "./LoginPage.css";
import { Form, Input,Spin} from "antd";
import axios from "axios";
import {
  FacebookOutlined,
  GoogleOutlined,
  UserOutlined,
  TwitterOutlined,LockOutlined
} from "@ant-design/icons";
import { useNavigate } from "react-router-dom";
import { Context } from "../../App";
import { Message } from '../../utils/helpers';
import { TypeMessage } from '../../utils/constants';
function LoginPage() {

  const navigate = useNavigate();
  const [loginState, setLoginState] = useContext(Context);
  const [loading, setLoading] = useState(false);
  const token = localStorage.getItem('token');
  useEffect(() => {
    
    if(token) {
        navigate('/');
    }
}, []);
  const onSubmit = (values) => {
    
    axios
      .post(`${process.env.REACT_APP_Backend_URI}api/User/Authenticate`, {
        userName: values.userName,
        password: values.password,
      })
      .then((response) => {
        setLoginState({
          ...loginState,
          role: response.data.role,
          username: response.data.username,
          id: response.data.id,
          isLogin: true,
          token: response.data.token,
        });
        localStorage.setItem(
          "loginState",
          JSON.stringify({
            isLogin: true,
            role: response.data.role,
            username: response.data.username,
            id: response.data.id,
            token: response.data.token,
          })
        );
        setLoading(false);
        navigate("/");
        localStorage.setItem("token", response.data.token);
        localStorage.setItem("role", response.data.role);
        axios.defaults.headers.common["Authorization"] ="Bearer " + response.data.token;
      })

      .catch((error) => {
       
        axios.defaults.headers.common["Authorization"] = "";
        
        Message(TypeMessage.ERROR, 'Đăng nhập thất bại')
        setLoading(false);
        
      });
  };
 

  return (
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
            name="form"
            initialValues={{ remember: true }}
            onFinish={onSubmit}
          >
            <Form.Item
              name="userName"
              label="UserName"
              rules={[
                {
                  required: true,
                  message: "Please input your UserName!",
                  whitespace: true,
                },
              ]}
            >
              <Input prefix={<UserOutlined className="site-form-item-icon" />}
                style={{
                  marginLeft:"10px",
                  width:"400px",
                  paddingLeft: "10px",
                  border: " 1px solid #607d8b",
                  fontSize: "16px",
                  letterSpacing: "1px",
                  color: "#607d8b",
                  borderRadius: "30px",
                }}
              />
            </Form.Item>

            <Form.Item
            
              name="password"
              label="Password"
              tooltip="Cần ít nhất 1 chữ in hoa và 1 số "
              rules={[
                {
                  required: true,
                  message: "Please input your password!",
                },
              ]}
              hasFeedback
            >
              <Input.Password
               prefix={<LockOutlined className="site-form-item-icon" />}
                style={{
                  width:"395px",
                  paddingLeft: "10px",
                  border: " 1px solid #607d8b",
                  fontSize: "16px",
                  letterSpacing: "1px",
                  color: "#607d8b",
                  borderRadius: "30px",
                }}
              />
            </Form.Item>

            {/* <div className="nho-dang-nhap">
              <label>
                <Form.Item name="remember" valuePropName="checked">
                  <Checkbox>Remember me</Checkbox>
                </Form.Item>
              </label>
            </div> */}
            <div className="input-form">
              <Form.Item>
              <input
                  type="submit"
                  value="LOGIN"
                />
              </Form.Item>
            </div>
            <div className="input-form">
              <p>
                Do not have account ? <a href="/register">Register</a>
              </p>
            </div>
          </Form>
          <h3>Login by social account</h3>
          <ul className="icon-dang-nhap">
            <li>
              <FacebookOutlined style={{ scale: "200%" }} />
            </li>
            <li>
              <GoogleOutlined style={{ scale: "200%" }} />
            </li>
            <li>
              <TwitterOutlined style={{ scale: "200%" }} />
            </li>
          </ul>
        </div>
      </div>
      
    </section>
    </Spin>
  );
}

export default LoginPage;
