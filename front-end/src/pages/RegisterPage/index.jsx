import {Row,Col,Button,Form,Input,Spin,DatePicker,notification,Radio} from "antd";

import { useNavigate } from "react-router-dom";
import React,{  useState } from "react";
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
        setLoading(false);
        notification.success({
          message: 'Bạn đã đăng ký thành công',
          placement: 'topLeft',
        });
        navigate("/login");
        
      }, (error) => {
        if (error?.response.status === 400) {
          setLoading(false);
        notification.warning({
          message: `Tài khoản của bạn đã tồn tại`,
          placement: 'topLeft',
         
        })}
        if (error?.response.status === 500) {
          setLoading(false);
        notification.warning({
          message: `Vui lòng kiểm tra lại thông tin của bạn`,
          placement: 'topLeft',
        
        })}
      })
      .catch((error) => {
        
      
      });
    
  };
  

  
  
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
      <div className="form">
     
        <h2>Đăng ký tài khoản mới</h2>

        <Form
          
          form={form}
          layout="horizontal"
          //name="normal_login"
          //className="login-form"
          onFinish={onFinish}
          initialValues={{
            prefix: "86",
          }}
          style={{
            textAlignLast:"left",
            minWidth: 400,
        }}
        labelCol={{
            span: 8,
          }}
          // wrapperCol={{
          //   span: 16,
          // }}
        >
         {/* <Row>
          <Col span={12}>
          </Col>
          <Col span={12}>
          </Col>
         </Row> */}
          <Form.Item
            name="firstName"
            label="Tên"
            rules={[
              {
                required: true,
                message: "Vui lòng nhập tên của bạn!",
                whitespace: true,
              },
            ]}
          >
            <Input />
          </Form.Item>
          <Form.Item
            name="lastName"
            label="Họ"
            rules={[
              {
                required: true,
                message: "Vui lòng nhập họ của bạn!",
                whitespace: true,
              },
            ]}
          >
            <Input />
          </Form.Item>

          <Form.Item
            name="userName"
            label="Tài khoản"
            rules={[
              {
                required: true,
                message: "Vui lòng nhập tài khoản!",
                whitespace: true,
              },
            ]}
          >
            <Input  />
          </Form.Item>
          <Form.Item
            name="password"
            label="Mật khẩu"
            tooltip="Mật khẩu cần ít nhất 8 kí tự và có 1 chữ in hoa, 1 chữ thường, 1 sồ !"
            
            rules={[
              { required: true, message: "Vui lòng nhập mật khẩu của bạn!" },
              {
                
                pattern: new RegExp('^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.{8,})'),
                message: "Mật khẩu cần ít nhất 8 kí tự và có 1 chữ in hoa, 1 chữ thường, 1 sồ !",
              },
            ]}
           
          >
            <Input.Password />
          </Form.Item>

          <Form.Item
            
            name="cfpassword"
            label="Xác thực mật khẩu"
            
            dependencies={["password"]}
          
            rules={[
              {
                required: true,
                message: 'Vui lòng nhập mật khẩu xác thực!',
              },
              ({ getFieldValue }) => ({
                validator(_, value) {
                  if (!value || getFieldValue('password') === value) {
                    return Promise.resolve();
                    
                  }
                  return Promise.reject(new Error('Mật khẩu và xác thực phải giống nhau!'));
                },
              })
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
                message: "Vui lòng nhập E-mail của bạn",
              },
              {
                required: true,
                message: "Please input your E-mail!",
              },
            ]}
            hasFeedback
          >
            <Input
              // type="email"
               style={{
                width: "100%",
              }}
             
            />
              
          </Form.Item>
          <Form.Item
            name="phoneNumber"
            label="Số điện thoại"
            rules={[
              {
                required: true,
                pattern: new RegExp("^(0?)(3[2-9]|5[6|8|9]|7[0|6-9]|8[0-6|8|9]|9[0-4|6-9])[0-9]{7}$"),
                message: "Vui lòng nhập số điện thoại",
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
            <DatePicker format={'DD/MM/YYYY'}  style={{
                width: "100%",
              }}/>
          </Form.Item>
          <Form.Item
            name="gender"
            label="Giới tính"
            rules={[
              {
                required: true,
                message: "Vui lòng chọn giới tính",
              },
            ]}
          >
            <Radio.Group>
              <Radio value={0}>Male</Radio>
              <Radio value={1}>FeMale</Radio>
              <Radio value={2}>Other</Radio>
            </Radio.Group>
          </Form.Item>
          <Form.Item name="role"
           label="Vai trò"
           rules={[
            {
              required: true,
              message: "Vui lòng chọn giới tính",
            },
          ]}
            >
        <Radio.Group  
       >
          <Radio value={'Customer'} >Người dùng</Radio>
          <Radio value={'ParkingOwner'}>Chủ bãi đỗ</Radio>
        </Radio.Group>
      </Form.Item>
         
          <Form.Item {...tailFormItemLayout}>
            <Button type="primary"  htmlType="submit">
           
                  Đăng ký
                
            </Button>
            <Button type="second" onClick={() => navigate(-1)}>
              Quay lại
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
