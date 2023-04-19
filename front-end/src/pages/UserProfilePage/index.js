import { 
  Form,
  notification,Spin,Row,Col,Card,Divider,
   Space, Button,Avatar } from "antd";
import React, { useEffect, useState } from "react";

import { useNavigate,useLocation } from "react-router-dom";
import {getProfile} from "../../services/userProfileServices";
import {toRoute} from '../../utils/helpers'
import { EditProfile } from "../../containers/pages/EditUserProfile";
import { routes } from '../../utils/routes';
import moment from "moment";
const UserProfile=()=> {
  const [form] = Form.useForm();
  const navigate = useNavigate();
  const [loading, setLoading] = useState(true);
  const [fullname,setFullName]=useState("");
  
  const location = useLocation();
  const [image,setImage]=useState([]);
  const [profile,setProfile] = useState("");
  const [isUpdate, setUpdate] = useState(false)
  const [infor,setInfor]= useState({
    firstName: "",
        lastName: "",
        userName: "",
        email: "",
        phoneNumber: "",
         dateOfBirth:"",
        gender: "",
        role: "",
  });
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
    .then(function(response){
     
      setProfile(response.data.id);
      
      
      setLoading(false);
      const resData = response.data;
        setInfor({ ...resData, dateOfBirth:moment(new Date(resData.dateOfBirth).toLocaleDateString('en-CA')).format('DD-MM-YYYY') });
      setFullName(response.data.lastName+" "+response.data.firstName);
     
      setImage(response.data.image.url);
      console.log(image);
    }).catch((error) => {
      // notification.warning({
      //   message: `Load profile fail`,
      //   description: 'Please check input again',
      //   placement: 'topLeft',
      // });
    });
  },[image]);
  useEffect(()=>{
    const _isUpdate = location.pathname.includes('/update');
    setUpdate(_isUpdate);
  })
  return (
    <Spin spinning={loading} size="large" tip="Vui lòng đợi..."> 
    {isUpdate ? 
      <>
                        <EditProfile profile={profile} image={image}  />
                    </>
    :
    <Row gutter={70}>
    <Col span={8}>
      <Card >
      <div className="avatar">
          <div className="user-avatar">
           <Space>
              {image.length >0 ? 
              <Avatar className="avatar-avatar"
              src={image}
            /> 
              :
              <Avatar className="avatar-avatar" 
            
            src={"https://thumbsnap.com/i/nJ5ET935.jpg"}/>
              }
              
              
              </Space>
          </div>
          
        </div>
        <Divider />
        <div className="user-name">
            {fullname}
          </div>
      </Card>
    </Col>
    <Col span={16}>
      <Card title="Thông tin người dùng" bordered={true}>
      <Form
          {...formItemLayout}
          form={form}
          initialValues={{
            prefix: "86",
          }}
          style={{
         
            maxWidth: 400,
          }}
          scrollToFirstError
        >
          <Form.Item
            name="lastName"
            label="Họ"
           
          >{infor.lastName}
            {/* <Input disabled /> */}
          </Form.Item>
          <Form.Item
            name="firstName"
            label="Tên"
             
          >
            {infor.firstName}
          </Form.Item>
          

          <Form.Item
            name="userName"
            label="Tài khoản"
          >
            {infor.userName}
          </Form.Item>
         
          <Form.Item
            name="email"
            label="E-mail"
            
          >        
              {infor.email}
          </Form.Item>
          <Form.Item
            name="phoneNumber"
            label="Phone Number"
           
          >
            {infor.phoneNumber}
          </Form.Item>
          <Form.Item
            name="dateOfBirth"
            label="Ngày sinh"
           
          >
            {infor.dateOfBirth}
          </Form.Item>
          <Form.Item
            name="gender"
            label="Giới tính"
          >
            {infor.gender}
          </Form.Item>
          <Form.Item
            name="role"
            label="Chức vụ"
          >
            {infor.role}
          </Form.Item>
          <Form.Item {...tailFormItemLayout}>
            <Button type="primary"  onClick={e => navigate(toRoute(routes.USER_PROFILE_UPDATE, { id: profile }))}
            >
            Chỉnh sửa thông tin
            </Button>
            <Button type="second" onClick={() => navigate(-1)}>
              Quay lại
            </Button>
          </Form.Item>
        </Form>
      </Card>
    </Col>
    
  </Row>
    
  }
      </Spin>
    
  );
}


export default UserProfile;
