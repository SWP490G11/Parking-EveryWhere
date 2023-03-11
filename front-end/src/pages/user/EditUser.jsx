import "../../style/profile.css";
import { 
  Form,
  Input,
  DatePicker,
  notification,
  Radio, Space, Button, } from "antd";
import React, { useEffect, useState } from "react";
import dayjs from "dayjs";
import { useNavigate,useParams } from "react-router-dom";
import axios from "axios";
import UploadImg from "../../components/UploadImage";

export function EditUser() {
  const [form] = Form.useForm();
  const navigate = useNavigate();
  const id = useParams().iduser;
  const [fullname,setFullName]=useState("");
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
  
  useEffect(()=>{
    axios.get(`${process.env.REACT_APP_Backend_URI}api/User/GetUser?id=${id}`)
    .then(function(response) {
      console.log(response.data);
      const dt = response.data;
      setFullName(dt.lastName+" "+dt.firstName);
      form.setFieldsValue({
        firstName: dt.firstName,
        lastName: dt.lastName,
        userName: dt.userName,
        email: dt.email,
        phoneNumber: dt.phoneNumber,
         dateOfBirth:dayjs(dt.dateOfBirth, 'YYYY-MM-DD'),
        gender: dt.gender,
        role: dt.role,
      });
      
    }).catch((error) => {
      
      //setError(error.response.data.message);
    });
  },[]);
  const onFinish = (fieldsValue) => {
    const values = {
      ...fieldsValue,
      dateOfBirth: fieldsValue["dateOfBirth"].format("YYYY-MM-DD"),
    };
    axios
      .put(`${process.env.REACT_APP_Backend_URI}api/User/Update?id=${id}`, {
        firstName: values.firstName,
        lastName: values.lastName,
        userName: values.userName,
        dateOfBirth: values.dateOfBirth,
        email: values.email,
        phoneNumber: values.phoneNumber,
        gender: values.gender,
        role: values.role,
      })
      .then(() => {
        sessionStorage.setItem("changeStatus", true);
        notification.success({
          message: `Save successfully`,
          description: 'Updated user profile',
          placement: 'topLeft',
        });
        navigate(`/user-profile/${id}`);
      }).catch((error)=>{
        notification.warning({
            message: `Save fail`,
            description: 'Please check input again',
            placement: 'topLeft',
          });
      });
  };
  return (
    
      <div id="profile">
        <div className="avatar">
          <div className="user-avatar">
            <Space wrap size={80} >
              {/* <Image className="imgz"
                width={160}
                src="https://zos.alipayobjects.com/rmsportal/jkjgkEfvpUPVyRjUImniVslZfWPnJuuZ.png"
              /> */}
              <UploadImg />
            </Space>
          </div>
          <div className="user-name">
            {fullname}
          </div>
        </div>
        <div className="form">

        <Form
          {...formItemLayout}
          form={form}
          onFinish={onFinish}
          initialValues={{
            prefix: "86",
          }}
          style={{
         
            maxWidth: 600,
          }}
          scrollToFirstError
        >
          
          <Form.Item
            name="firstName"
            label="FirstName"
             
          >
            <Input />
          </Form.Item>
          <Form.Item
            name="lastName"
            label="LastName"
           
          >
            <Input  />
          </Form.Item>

          <Form.Item
            name="userName"
            label="UserName"
          >
            <Input />
          </Form.Item>
         
          <Form.Item
            name="email"
            label="E-mail"
            
          >        
              <Input />
          </Form.Item>
          <Form.Item
            name="phoneNumber"
            label="Phone Number"
           
          >
            <Input            
             
            />
          </Form.Item>
          <Form.Item
            name="dateOfBirth"
            label="Date of birth"
            
          >
            <DatePicker  style={{width: 332}} />
          </Form.Item>
          <Form.Item
            name="gender"
            label="Gender"
          >
            <Radio.Group >
              <Radio value={"Male"}>Male</Radio>
              <Radio value={"Female"}>FeMale</Radio>
              <Radio value={'Other'}>Other</Radio>
            </Radio.Group>
          </Form.Item>
          <Form.Item
            name="role"
            label="Role"
          >
            <Input disabled/>
          </Form.Item>
          
          <Form.Item {...tailFormItemLayout}>
            <Button type="primary"  htmlType="submit"
            >
            Save
            </Button>
            <Button type="second" onClick={() => navigate(-1)}>
              Back
            </Button>
          </Form.Item>
        </Form>
        </div>
      </div>
    
  );
}

export default EditUser;
