import React, { useState, useContext } from "react";
<<<<<<< HEAD
import "./LoginPage.css" ;
import {Form,Checkbox,Button,Input,Spin} from 'antd';

=======
import "./LoginPage.css";
import { Form, Checkbox, Input,notification } from "antd";
>>>>>>> 9f6ee2a2b2daceb28a44739647bff5f57aba0e4d
import axios from "axios";
import {
  FacebookOutlined,
  GoogleOutlined,
  TwitterOutlined,
} from "@ant-design/icons";
import { useNavigate } from "react-router-dom";
import { Context } from "../../App";
function LoginPage() {

  const LOGING = {
    LOADING: "loading",
    FAIL: "fail",
    SUCCESS: "success",
    NONE: "none",
  };
  const navigate = useNavigate();
  const [loginState, setLoginState] = useContext(Context);
  const [isLoging, setLoging] = useState(LOGING.NONE);
  const [error, setError] = useState("");
  const onSubmit = (values) => {
    setLoging(LOGING.LOADING);
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
        console.log(response.data);
        navigate("/");
        localStorage.setItem("role", response.data.role);
        loginState.setItem("isLogin", true);

<<<<<<< HEAD
    .catch((error) => {
      setLoging(LOGING.FAIL);
      axios.defaults.headers.common["Authorization"] = "";
      // setError(error.response.data.message);
    });
}
   
  return (
    
    <div className="login-page">
      
      <div className="illustration-wrapper">
        <img src="https://mixkit.imgix.net/art/preview/mixkit-left-handed-man-sitting-at-a-table-writing-in-a-notebook-27-original-large.png?q=80&auto=format%2Ccompress&h=700" alt="Login"/>
      </div>
      
    <Form
        name="login-form"
        initialValues={{ remember: true }}
        onFinish={onSubmit}
      >
        <p className="form-title">Welcome back</p>
        <p>Login to the Dashboard</p>
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
            <Input />
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
            <Input.Password />
          </Form.Item>
       
        <Form.Item name="remember" valuePropName="checked">
          <Checkbox>Remember me</Checkbox>
        </Form.Item>

        <Form.Item>
          <Button type="primary" htmlType="submit" className="login-form-button"
           disabled={isLoging === LOGING.LOADING}>
             <span>
                {isLoging === LOGING.LOADING ? (
                  <Spin indicator={antIcon} />
                )  : (
                  "Login"
                )}
              </span>
           
          </Button>
        </Form.Item>
        <Form.Item>
        <Button type="text" href={"/register"}>
   <GithubOutlined className="teamSocialIcon" /> Register
        </Button>
        </Form.Item>
      </Form>
      <h3>Login by social account</h3>
      <ul class="icon-dang-nhap">
        <li>
          <FacebookOutlined style={{scale:"200%"}}/>
        </li>
        <li>
          <GoogleOutlined style={{scale:"200%"}}/>
        </li>
        <li>
          <TwitterOutlined style={{scale:"200%"}}/>
        </li>
      </ul>
    </div>
  
=======
        axios.defaults.headers.common["Authorization"] =
          "Bearer " + response.data.token;
      })

      .catch((error) => {
        setLoging(LOGING.FAIL);
        axios.defaults.headers.common["Authorization"] = "";
        notification.warning({
          message: `Login fail`,
          description: 'Please check user or password again',
          placement: 'topLeft',
        });
         //setError(error.response.data.message);
      });
  };
>>>>>>> 9f6ee2a2b2daceb28a44739647bff5f57aba0e4d
 

  return (
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
              <Input
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

            <div className="nho-dang-nhap">
              <label>
                <Form.Item name="remember" valuePropName="checked">
                  <Checkbox>Remember me</Checkbox>
                </Form.Item>
              </label>
            </div>
            <div className="input-form">
              <Form.Item>
                <input
                 
                  disabled={isLoging === LOGING.LOADING}
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
  );
}

export default LoginPage;
