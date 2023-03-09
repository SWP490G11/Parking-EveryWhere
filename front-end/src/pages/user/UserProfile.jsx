import "../../style/profile.css";
import { 
  Form,
  Input,
  DatePicker,
  Radio, Space, Button, Image, } from "antd";
import React, { useEffect, useState } from "react";
import dayjs from "dayjs";
import { useNavigate,useParams } from "react-router-dom";
import axios from "axios";


export function UserProfile() {
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
      notification.warning({
        message: `Load profile fail`,
        description: 'Please check input again',
        placement: 'topLeft',
      });
    });
  },[]);
  return (
    
      <div id="profile">
        <div className="avatar">
          <div className="user-avatar">
            <Space wrap size={80} >
              <Image className="imgz"
                width={160}
                src="https://zos.alipayobjects.com/rmsportal/jkjgkEfvpUPVyRjUImniVslZfWPnJuuZ.png"
              />
              
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
            <Input disabled/>
          </Form.Item>
          <Form.Item
            name="lastName"
            label="LastName"
           
          >
            <Input disabled />
          </Form.Item>

          <Form.Item
            name="userName"
            label="UserName"
          >
            <Input disabled/>
          </Form.Item>
         
          <Form.Item
            name="email"
            label="E-mail"
            
          >        
              <Input disabled/>
          </Form.Item>
          <Form.Item
            name="phoneNumber"
            label="Phone Number"
           
          >
            <Input            
             disabled
            />
          </Form.Item>
          <Form.Item
            name="dateOfBirth"
            label="Date of birth"
            
          >
            <DatePicker disabled style={{width: 332}} />
          </Form.Item>
          <Form.Item
            name="gender"
            label="Gender"
          >
            <Radio.Group disabled>
              <Radio value={"Male"}>Male</Radio>
              <Radio value={"FeMale"}>FeMale</Radio>
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
            <Button type="primary"  onClick={() => navigate(`/user-profile/edit/${id}`)}
            >
            Edit
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

export default UserProfile;
