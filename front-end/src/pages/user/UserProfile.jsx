import "../../style/profile.css";
<<<<<<< HEAD
import { Form, Input, DatePicker, Radio, Space, Button, Image } from "antd";
=======
import { 
  Form,
  Input,
  DatePicker,
  notification,
  Radio, Space, Button, Image, } from "antd";
>>>>>>> cb1e5f3417a834876729ff8c4ee4cfcbfc096d8c
import React, { useEffect, useState } from "react";
import dayjs from "dayjs";
<<<<<<< HEAD
import { useNavigate, useParams } from "react-router-dom";
=======
import { useNavigate } from "react-router-dom";
>>>>>>> 95d5c93b020b04db38947714b638eac205c9aa85
import axios from "axios";

export function UserProfile() {
  const [form] = Form.useForm();
  const navigate = useNavigate();
<<<<<<< HEAD
  const id = useParams().iduser;
  const [fullname, setFullName] = useState("");
=======
  const [fullname,setFullName]=useState("");
>>>>>>> cb1e5f3417a834876729ff8c4ee4cfcbfc096d8c
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
<<<<<<< HEAD
=======
  
  useEffect(()=>{
    axios.get(`${process.env.REACT_APP_Backend_URI}api/User/GetProfile`)
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
>>>>>>> cb1e5f3417a834876729ff8c4ee4cfcbfc096d8c

  useEffect(() => {
    axios
      .get(`${process.env.REACT_APP_Backend_URI}api/User/GetProfile`)
      .then(function (response) {
        console.log(response.data);
        const dt = response.data;
        setFullName(dt.lastName + " " + dt.firstName);
        form.setFieldsValue({
          firstName: dt.firstName,
          lastName: dt.lastName,
          userName: dt.userName,
          email: dt.email,
          phoneNumber: dt.phoneNumber,
          dateOfBirth: dayjs(dt.dateOfBirth, "YYYY-MM-DD"),
          gender: dt.gender,
          role: dt.role,

          
        });
        console.log(response.data);
      })
      .catch((error) => {
        // if (typeof Notification !== "undefined") {
        //   notification.warning({
        //     message: `Load profile fail`,
        //     description: "Please check input again",
        //     placement: "topLeft",
        //   });
        // }
      });
  }, []);
  return (
    <div id="profile">
      <div className="avatar">
        <div className="user-avatar">
          <Space wrap size={80}>
            <Image
              className="imgz"
              width={160}
              src="https://zos.alipayobjects.com/rmsportal/jkjgkEfvpUPVyRjUImniVslZfWPnJuuZ.png"
            />
          </Space>
        </div>
        <div className="user-name">{fullname}</div>
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
          <Form.Item name="firstName" label="FirstName">
            <Input readOnly />
          </Form.Item>
          <Form.Item name="lastName" label="LastName">
            <Input readOnly />
          </Form.Item>

          <Form.Item name="userName" label="UserName">
            <Input readOnly />
          </Form.Item>

          <Form.Item name="email" label="E-mail">
            <Input readOnly />
          </Form.Item>
          <Form.Item name="phoneNumber" label="Phone Number">
            <Input readOnly />
          </Form.Item>
          <Form.Item name="dateOfBirth" label="Date of birth">
            <DatePicker readOnly style={{ width: 332 }} />
          </Form.Item>
          <Form.Item name="gender" label="Gender">
            <Radio.Group readOnly>
              <Radio value={"Male"}>Male</Radio>
              <Radio value={"FeMale"}>FeMale</Radio>
              <Radio value={"Other"}>Other</Radio>
            </Radio.Group>
          </Form.Item>
          <Form.Item name="role" label="Role">
            <Input readOnly />
          </Form.Item>

          <Form.Item {...tailFormItemLayout}>
<<<<<<< HEAD
            <Button
              type="primary"
              onClick={() => navigate(`/user-profile/edit/${id}`)}
=======
            <Button type="primary"  onClick={() => navigate(`/user-profile/edit`)}
>>>>>>> cb1e5f3417a834876729ff8c4ee4cfcbfc096d8c
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
