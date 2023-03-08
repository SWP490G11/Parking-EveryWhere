import React, { useState, useContext } from "react";
import "./LoginPage.css" ;
import {Form,Checkbox,Button,Input,Spin} from 'antd';

import axios from "axios";
import { EyeInvisibleOutlined, EyeTwoTone } from '@ant-design/icons';
import {
  LoadingOutlined,
  GithubOutlined,
  FacebookOutlined,
  GoogleOutlined,
  TwitterOutlined,
} from "@ant-design/icons";
import { useNavigate } from "react-router-dom";
import { Context } from "../../App";
const  LoginPage= () => {
  const antIcon = <LoadingOutlined style={{ fontSize: "24px" }} spin />;
  const LOGING = {
    LOADING: "loading",
    FAIL: "fail",
    SUCCESS: "success",
    NONE: "none",
  };
  const navigate = useNavigate();
  const [loginState, setLoginState] = useContext(Context);
  const [isLoging, setLoging] = useState(LOGING.NONE);
 
  const onSubmit=(values) => {
  setLoging(LOGING.LOADING);
  axios.post(`${process.env.REACT_APP_Backend_URI}api/User/Authenticate`, {
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
        token: response.data.token
      });
      localStorage.setItem(
        "loginState",
        JSON.stringify({
          isLogin: true,
          role: response.data.role,
          username: response.data.username,
          id: response.data.id, 
          token: response.data.token
        })
      );
      console.log(response.data);
      navigate("/");
      localStorage.setItem("role",response.data.role );
      loginState.setItem("isLogin",true);
    
      axios.defaults.headers.common["Authorization"] = "Bearer " + response.data.token;
     
    })

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
  
 
  );
}

export default LoginPage;