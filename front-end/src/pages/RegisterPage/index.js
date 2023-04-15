import {AutoComplete,Button,Checkbox,Form,Input,Spin,DatePicker,notification,Radio} from "antd";
import axios from "axios";
import { useNavigate } from "react-router-dom";
import React,{ useEffect, useState } from "react";
import api from '../../services/api'


const formItemLayout = {
  labelCol: {
    xs: {
      span: 24,
    },
    sm: {
      span: 8,
    },
  },
  wrapperCol: {
    xs: {
      span: 24,
    },
    sm: {
      span: 16,
    },
  },
};
const tailFormItemLayout = {
  wrapperCol: {
    xs: {
      span: 24,
      offset: 0,
    },
    sm: {
      span: 16,
      offset: 8,
    },
  },
};

const Register = () => {
  const [form] = Form.useForm();
  const navigate = useNavigate();
  const [loading, setLoading] = useState(false);
 

  


  const onFinish = (fieldsValue) => {
    setLoading(true);
    const values = {
      ...fieldsValue,
      dateOfBirth: fieldsValue["dateOfBirth"].format("YYYY-MM-DD"),
    };
    api
      .post(`api/User/Register`, {
        firstName: values.firstName,
        lastName: values.lastName,
        dateOfBirth: values.dateOfBirth,
        gender: values.gender,
        email: values.email,
        userName: values.userName,
        password: values.cfpassword,
        phoneNumber: values.phoneNumber,
        role:values.role,
        lastModifyAt: new Date(),
        imageURL: "",
      })
      .then(() => {
       
        notification.success({
          message: `Register success`,
          description: 'You can login now',
          placement: 'topLeft',
        });
        navigate("/");
      })
      .catch((error) => {
        notification.warning({
          message: `Register fail`,
          description: 'Please check input again',
          placement: 'topLeft',
        });
      });
    
  };
  

  const [autoCompleteResult, setAutoCompleteResult] = useState([]);
  const onEmailChange = (value) => {
    if (!value) {
      setAutoCompleteResult([]);
    } else {
      setAutoCompleteResult(
        ["@gmail.com", "@yahoo.com"].map((domain) => `${value}${domain}`)
      );
    }
  };
  const emailOptions = autoCompleteResult.map((email) => ({
    label: email,
    value: email,
  }));

  
  
  return (
    <div id="login">
    <Spin spinning={loading} tip="Đang đăng ký...">
  <section>

<div className="img-bg">
<img
src="https://images.unsplash.com/photo-1470224114660-3f6686c562eb?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=735&q=80"
alt="Hình Ảnh Minh Họa"
/>
</div>

      <div className="noi-dung">
        <div >
     
        <h2>Đăng ký tài khoản mới</h2>

        <Form
          
          form={form}
          name="normal_login"
          className="login-form"
          onFinish={onFinish}
          initialValues={{
            prefix: "86",
          }}
          style={{
            minWidth: 400,
        }}
        labelCol={{
            span: 8,
          }}
          wrapperCol={{
            span: 16,
          }}
        >
           <Form.Item name="role"
            >
        <Radio.Group  optionType="button"
       >
          <Radio value={1} >Vehicle Owner</Radio>
          <Radio value={2}>Parking Owner</Radio>
        </Radio.Group>
      </Form.Item>
          <Form.Item
            name="firstName"
            label="FirstName"
            rules={[
              {
                required: true,
                message: "Please input your FirstName!",
                whitespace: true,
              },
            ]}
          >
            <Input />
          </Form.Item>
          <Form.Item
            name="lastName"
            label="LastName"
            rules={[
              {
                required: true,
                message: "Please input your LastName!",
                whitespace: true,
              },
            ]}
          >
            <Input />
          </Form.Item>

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
                pattern: new RegExp("^[a-zA-Z0-9]+$"),
                message: "Please input your password!",
              },
            ]}
            hasFeedback
          >
            <Input.Password />
          </Form.Item>

          <Form.Item
            name="cfpassword"
            label="Confirm Password"
            tooltip="Cần ít nhất 1 chữ in hoa và 1 số "
            dependencies={["password"]}
            hasFeedback
            rules={[
              {
                required: true,
                pattern: new RegExp("^[a-zA-Z0-9]+$"),
                message: "Please confirm your password!",
              },
              ({ getFieldValue }) => ({
                validator(_, value) {
                  if (!value || getFieldValue("password") === value) {
                    return Promise.resolve();
                  }
                  return Promise.reject(
                    new Error(
                      "The two passwords that you entered do not match!"
                    )
                  );
                },
              }),
            ]}
          >
            <Input.Password />
          </Form.Item>
          <Form.Item
            name="email"
            label="E-mail"
            rules={[
              {
                type: "email",
                message: "The input is not valid E-mail!",
              },
              {
                required: true,
                message: "Please input your E-mail!",
              },
            ]}
            hasFeedback
          >
            <AutoComplete
              options={emailOptions}
              onChange={onEmailChange}
              placeholder="Email"
            >
              <Input />
            </AutoComplete>
          </Form.Item>
          <Form.Item
            name="phoneNumber"
            label="Phone Number"
            rules={[
              {
                required: true,
                pattern: new RegExp("^(0?)(3[2-9]|5[6|8|9]|7[0|6-9]|8[0-6|8|9]|9[0-4|6-9])[0-9]{7}$"),
                message: "Vio lòng nhập số điện thoại",
              },
            ]}
          >
            <Input
             
              style={{
                width: "100%",
              }}
            />
          </Form.Item>
          <Form.Item
            name="dateOfBirth"
            label="Date of birth"
            rules={[
              {
                type: "object",
                required: true,
                message: "Please select time!",
              },
            ]}
          >
            <DatePicker style={{width: 200}} />
          </Form.Item>
          <Form.Item
            name="gender"
            label="Gender"
            rules={[
              {
                required: true,
                message: "Please select gender!",
              },
            ]}
          >
            <Radio.Group>
              <Radio value={0}>Male</Radio>
              <Radio value={1}>FeMale</Radio>
              <Radio value={2}>Other</Radio>
            </Radio.Group>
          </Form.Item>

          <Form.Item
            name="agreement"
            valuePropName="checked"
            rules={[
              {
                validator: (_, value) =>
                  value
                    ? Promise.resolve()
                    : Promise.reject(new Error("Should accept agreement")),
              },
            ]}
            {...tailFormItemLayout}
          >
            <Checkbox>
              I have read the agreement
            </Checkbox>
          </Form.Item>
          <Form.Item {...tailFormItemLayout}>
            <Button type="primary"  htmlType="submit">
           
                  Register
                
            </Button>
            <Button type="second" onClick={() => navigate(-1)}>
              Back
            </Button>
          </Form.Item>
        </Form>
       
     
      </div>
     </div>
  
   </section>
                
            </Spin>
        </div>
  );
};
export default Register;
