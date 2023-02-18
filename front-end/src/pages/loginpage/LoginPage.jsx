import React, { useState, useContext } from "react";
import "./LoginPage.css" ;
import {Form,Checkbox,Button,Input,Spin} from 'antd';
import { useFormik } from "formik";
import * as Yup from "yup";
import axios from "axios";
import { LoadingOutlined,GithubOutlined } from "@ant-design/icons";
import { useNavigate } from "react-router-dom";
import { Context } from "../../App";
function LoginPage() {
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
  const formik = useFormik({
    initialValues: {
      username: "",
      password: "",
    },
    validationSchema: Yup.object({
      username: Yup.string().required("Required !"),
      password: Yup.string()
        .min(2, "Must be at least 8 characters !")
        
    }),
    
    onSubmit: () => {
      setLoging(LOGING.LOADING);
      axios
        .post(`${process.env.REACT_APP_Backend_URI}api/User/Authenticate`, {
          userName: formik.values.username,
          password: formik.values.password,
        })
        .then((response) => {
          setLoginState({
            ...loginState,
            role: response.data.role,
            username: formik.values.username,
            id: response.data.userId,
          });
          localStorage.setItem(
            "loginState",
            JSON.stringify({
              isLogin: true,
              role: response.data.role,
              username: formik.values.username,
              id: response.data.userId, 
            })
          );
          console.log(response.data);
          localStorage.setItem("role",response.data.role );
          axios.defaults.headers.common["Authorization"] = "Bearer " + response.data.token;
          navigate('/home');
        })

        .catch((error) => {
          setLoging(LOGING.FAIL);
          axios.defaults.headers.common["Authorization"] = "";
          // setError(error.response.data.message);
        });
    },
  });

   
  return (
    
    <div className="login-page">
      
    <div className="illustration-wrapper">
        <img src="https://mixkit.imgix.net/art/preview/mixkit-left-handed-man-sitting-at-a-table-writing-in-a-notebook-27-original-large.png?q=80&auto=format%2Ccompress&h=700" alt="Login"/>
      </div>
      
    <Form
        name="login-form"
        initialValues={{ remember: true }}
        onSubmit={formik.handleSubmit}
      >
        <p className="form-title">Welcome back</p>
        <p>Login to the Dashboard</p>
        <Form.Item
          name="username"
          rules={[{ required: true, message: 'Please input your username!' }]}
        >
          <Input
            type="username"
            placeholder="Username"
            name="username"
            onChange={formik.handleChange}
            onBlur={formik.handleBlur}
            value={formik.values.username}
          />
        </Form.Item>

        <Form.Item
          name="password"
          rules={[{ required: true, message: 'Please input your password!' }]}
        >
          <Input.Password 
             placeholder="Password" 
             name="password"
             onChange={formik.handleChange}
             onBlur={formik.handleBlur}
             value={formik.values.password}
          />
        </Form.Item>
        {/* <div className="validContainer">
            {formik.touched.password && formik.errors.password ? (
              <p className="validationText">{formik.errors.password}</p>
            ) : null}
          </div> */}
        <Form.Item name="remember" valuePropName="checked">
          <Checkbox>Remember me</Checkbox>
        </Form.Item>

        <Form.Item>
          <Button type="primary" htmlType="submit" className="login-form-button" onClick={formik.handleSubmit}
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
      
    </div>
   
 
  );
}

export default LoginPage;