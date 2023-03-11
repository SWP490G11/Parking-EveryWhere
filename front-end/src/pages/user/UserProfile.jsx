import "../../style/profile.css";
<<<<<<< HEAD
import HeaderComp from "../../components/HeaderComp";
import FilterComp from "../../components/FilterComp";
import { UserOutlined } from "@ant-design/icons";
import { PlusOutlined } from "@ant-design/icons";

import {
  Avatar,
  Space,
  AutoComplete,
  DatePicker,
  Button,
  Radio,
  Cascader,
  Checkbox,
  Form,
  Input,
  InputNumber,
  Select,
  Switch,
  TreeSelect,
  Upload,
} from "antd";
import { useState } from "react";
=======
import { 
  Form,
  Input,
  DatePicker,
  Radio, Space, Button, Image, } from "antd";
import React, { useEffect, useState } from "react";
>>>>>>> 9f6ee2a2b2daceb28a44739647bff5f57aba0e4d
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
<<<<<<< HEAD
  const [value, setValue] = useState(1);
  const onChange = (e) => {
    console.log("radio checked", e.target.value);
    setValue(e.target.value);
  };
  const { RangePicker } = DatePicker;
  const { TextArea } = Input;
  const [componentDisabled, setComponentDisabled] = useState(true);
=======
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
>>>>>>> 9f6ee2a2b2daceb28a44739647bff5f57aba0e4d
  return (
    
      <div id="profile">
        <div className="avatar">
          <div className="user-avatar">
<<<<<<< HEAD
            <Avatar
              size={150}
              icon={
                <Form.Item
                  style={{ marginLeft: "23px", marginTop: "30px" }}
                  valuePropName="fileList"
                >
                  <Upload action="/upload.do" listType="picture-card">
                    <PlusOutlined />
                  </Upload>
                </Form.Item>
              }
              action="/upload.do"
            />{" "}
          </div>
          <div className="user-name" style={{ marginTop: "120px" }}>
            Phung Nam Duy
=======
            <Space wrap size={80} >
              <Image className="imgz"
                width={160}
                src="https://zos.alipayobjects.com/rmsportal/jkjgkEfvpUPVyRjUImniVslZfWPnJuuZ.png"
              />
              
            </Space>
          </div>
          <div className="user-name">
            {fullname}
>>>>>>> 9f6ee2a2b2daceb28a44739647bff5f57aba0e4d
          </div>
        </div>
        <div className="form">

        <Form
<<<<<<< HEAD
          labelCol={{
            span: 4,
          }}
          wrapperCol={{
            span: 14,
          }}
          layout="horizontal"
          style={{
            maxWidth: 600,
          }}
        >
          <Form.Item label="Checkbox" name="disabled" valuePropName="checked">
            <Checkbox>Gender</Checkbox>
          </Form.Item>
          <Form.Item label="Radio">
            <Radio.Group name="radiogroup" defaultValue={1}>
              <Radio value={1}>Male</Radio>
              <Radio value={2}>Female</Radio>
            </Radio.Group>
          </Form.Item>
          <Form.Item label="Full name:">
            <Input />
          </Form.Item>
          <Form.Item label="Email:">
            <Input />
          </Form.Item>
          <Form.Item label="Phone number:">
            <InputNumber style={{marginLeft:"16px"}}/>
          </Form.Item>
          <Form.Item label="Select">
            <Select>
              <Select.Option value="demo">Demo</Select.Option>
            </Select>
          </Form.Item>
          <Form.Item label="TreeSelect">
            <TreeSelect
              treeData={[
                {
                  title: "Light",
                  value: "light",
                  children: [
                    {
                      title: "Bamboo",
                      value: "bamboo",
                    },
                  ],
                },
              ]}
            />
          </Form.Item>
          <Form.Item label="Cascader">
            <Cascader
              options={[
                {
                  value: "zhejiang",
                  label: "Zhejiang",
                  children: [
                    {
                      value: "hangzhou",
                      label: "Hangzhou",
                    },
                  ],
                },
              ]}
            />
          </Form.Item>
          <Form.Item label="Date of birth :">
            <DatePicker />
          </Form.Item>
          <Form.Item label="RangePicker">
            <RangePicker />
          </Form.Item>

          <Form.Item label="TextArea">
            <TextArea rows={4} />
          </Form.Item>
          <Form.Item label="Switch" valuePropName="checked">
            <Switch />
          </Form.Item>
          <Form.Item label="Upload" valuePropName="fileList">
            <Upload action="/upload.do" listType="picture-card">
              <div>
                <PlusOutlined />
                <div
                  style={{
                    marginTop: 8,
                  }}
                >
                  Upload
                </div>
              </div>
            </Upload>
          </Form.Item>
          <Form.Item label="Button">
            <Button>Button</Button>
          </Form.Item>
        </Form>
=======
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
>>>>>>> 9f6ee2a2b2daceb28a44739647bff5f57aba0e4d
      </div>
    
  );
}

export default UserProfile;
