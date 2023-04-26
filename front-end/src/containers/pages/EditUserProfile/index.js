import { Form,Input,DatePicker,notification,Radio, Space, Button,Avatar,Row,Col,Card
    ,Divider } from "antd";
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
         dateOfBirth:dayjs(response.data.dateOfBirth, 'DD-MM-YYY'),
        gender: response.data.gender,
        role: response.data.role,
      });
      
      console.log(profile.image);
    }).catch((error) => {
      // notification.warning({
      //   message: `Load profile fail`,
      //   description: 'Please check input again',
      //   placement: 'topLeft',
      // });
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
          message: `Thành công`,
          description: 'Cập nhật thông tin người dung thành công',
          placement: 'topLeft',
        });
        navigate(`/`);
      }).catch((error)=>{
        notification.warning({
            message: `Thất bại`,
            description: 'Vui lòng thử lại',
            placement: 'topLeft',
          });
      });
  };


  return (
    
    <Row gutter={70}>
    <Col span={8}>
    <Card >
    <div className="avatar">
          <div className="user-avatar">
          <Space>
              {newimage.length >0 ? 
            <Avatar  className="avatar-avatar"
            src={newimage[0]}
          />
              :
              <Avatar className="avatar-avatar"
             src={profile.image}/>
              
               }
              
              
              </Space>
          </div>

        </div>
        <Divider />
        <div className="user-name">
            {fullname}
          </div>
        <Divider />
               
                <UploadImage  setImages={setImage} images={newimage} count={1}/>
        
        
    </Card>
    </Col>
    <Col span={16}>
      <Card>
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
            name="lastName"
            label="Họ"
           
          >
            <Input  />
          </Form.Item>
          
          <Form.Item
            name="firstName"
            label="Tên"
             
          >
            <Input />
          </Form.Item>
         

          <Form.Item
            name="userName"
            label="Tài khoản"
          >
            <Input readOnly />
          </Form.Item>
         
          <Form.Item
            name="email"
            label="E-mail"
            
          >        
              <Input />
          </Form.Item>
          <Form.Item
            name="phoneNumber"
            label="Số điện thoại"
           
          >
            <Input            
             
            />
          </Form.Item>
          <Form.Item
            name="dateOfBirth"
            label="Ngày sinh"
            rules={[
              {
                type: "object",
                required: true,
                message: "Vui lòng nhập ngày sinh của bạn!",
              },
              {
                validator(_, value) {
                    if ((new Date().getFullYear() - new Date(value).getFullYear()) < 15) {
                        return Promise.reject("Người dùng phải trên 15 tuổi ")
                    }
                    return Promise.resolve();
                }
            }
            ]}
          >
            <DatePicker  style={{width: 332}} format={'DD/MM/YYYY'} />
          </Form.Item>
          <Form.Item
            name="gender"
            label="Giới tính"
          >
            <Radio.Group >
              <Radio value={"Male"}>Nam</Radio>
              <Radio value={"Female"}>Nữ</Radio>
              <Radio value={'Other'}>Khác</Radio>
            </Radio.Group>
          </Form.Item>
          <Form.Item
            name="role"
            label="Vị trí"
          >
            <Input readOnly/>
          </Form.Item>
          
          <Form.Item {...tailFormItemLayout}>
            <Button type="primary"  htmlType="submit"
            >
            Lưu
            </Button>
            <Button type="second" onClick={() => navigate(-1)}>
              Quay lại
            </Button>
          </Form.Item>
        </Form>
      </Card>
    </Col>
    </Row>
     
    
  );
}

