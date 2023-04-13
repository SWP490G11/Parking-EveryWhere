import { Form,Input,DatePicker,notification,Radio, Space, Button,Avatar,Upload
     } from "antd";
import UploadImage from "../../../components/UploadImage";
import dayjs from "dayjs";
import { useNavigate } from "react-router-dom";
import {getProfile} from "../../../services/userProfileServices";
import api from "../../../services/api";
import React, { useEffect, useState } from "react";
// import config from '../../../config';
// import { Message } from '../../../utils/helpers';
// import { TypeMessage } from '../../../utils/constants';
// import axios from 'axios';
// import { UploadOutlined } from '@ant-design/icons';
export const EditProfile=(profile)=> {
    const [newimage,setImage]=useState([]);
  const [form] = Form.useForm();
  const navigate = useNavigate();
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
    
    getProfile()
    .then((response)=> { 
      
      setFullName(response.data.lastName+" "+response.data.firstName);
      
      form.setFieldsValue({
        firstName: response.data.firstName,
        lastName: response.data.lastName,
        userName: response.data.userName,
        email: response.data.email,
        phoneNumber: response.data.phoneNumber,
         dateOfBirth:dayjs(response.data.dateOfBirth, 'YYYY-MM-DD'),
        gender: response.data.gender,
        role: response.data.role,
      });
      
      console.log(profile.image);
    }).catch((error) => {
      notification.warning({
        message: `Load profile fail`,
        description: 'Please check input again',
        placement: 'topLeft',
      });
    });
  },[]);
  const onFinish = (fieldsValue) => {
    const values = {
      ...fieldsValue,
      dateOfBirth: fieldsValue["dateOfBirth"].format("YYYY-MM-DD"),
    };
    api
      .put(`api/User/Update?id=${profile.profile}`, {
        firstName: values.firstName,
        lastName: values.lastName,
       
        dateOfBirth: values.dateOfBirth,
        email: values.email,
        phoneNumber: values.phoneNumber,
        gender: values.gender,
        
        lastModifyAt: new Date(),
        ImageURL: newimage.length >0 ?  newimage[0] : profile.image ,
      })
      .then(() => {
        notification.success({
          message: `Save successfully`,
          description: 'Updated user profile',
          placement: 'topLeft',
        });
        navigate(`/user-profile`);
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
          <Space>
              {newimage.length >0 ? 
            <Avatar className="avatar-avatar"
            src={newimage[0]}
          />
              :
              <Avatar className="avatar-avatar"
             src={profile.image}/>
              
               }
              
              
              </Space>
          </div>
         
          <div className="user-name">
            {fullname}
          </div>
          <div>
                <UploadImage setImages={setImage} images={newimage} count={1}/>
          </div>
          {/* <Form
            name="validate_other"
            {...formItemLayout2}
            style={{
                width: 600,
            }}
        >
            <Form.Item>
                <Form.Item name="dragger" valuePropName="fileList" getValueFromEvent={normFile} noStyle>
                    <Upload name="files" maxCount={1} customRequest={dummyRequest} action={config.UPLOAD_URL}  style={{ width: 120 }}>
                    <Button icon={<UploadOutlined />}>Upload</Button>
                    </Upload>
                </Form.Item>
            </Form.Item>
        </Form> */}
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
            <Input disabled />
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

