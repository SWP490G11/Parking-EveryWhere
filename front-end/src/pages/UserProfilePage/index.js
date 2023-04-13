import { 
  Form,
  Input,
  DatePicker,
  notification,Spin,
  Radio, Space, Button,Avatar } from "antd";
import React, { useEffect, useState } from "react";
import dayjs from "dayjs";
import { useNavigate,useLocation } from "react-router-dom";
import {getProfile} from "../../services/userProfileServices";
import {toRoute} from '../../utils/helpers'
import { EditProfile } from "../../containers/pages/EditUserProfile";
import { routes } from '../../utils/routes';

const UserProfile=()=> {
  const [form] = Form.useForm();
  const navigate = useNavigate();
  const [loading, setLoading] = useState(true);
  const [fullname,setFullName]=useState("");
 
  const location = useLocation();
  const [image,setImage]=useState([]);
  const [profile,setProfile] = useState("");
  const [isUpdate, setUpdate] = useState(false)
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
    .then((response) =>{
     
      setProfile(response.data.id);
      
      
      setLoading(false);
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
      setImage(response.data.image.url);
      console.log(image);
    }).catch((error) => {
      notification.warning({
        message: `Load profile fail`,
        description: 'Please check input again',
        placement: 'topLeft',
      });
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
    <div id="profile">
        <div className="avatar">
          <div className="user-avatar">
           <Space>
              {image === null ? 
              <Avatar className="avatar-avatar" 
            
            src={"https://thumbsnap.com/i/nJ5ET935.jpg"}/>
              :
              <Avatar className="avatar-avatar"
                src={image}
              /> }
              
              
              </Space>
          </div>
          <div className="user-name">
            {fullname}
          </div>
        </div>
        <div className="formz">

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
            <Button type="primary"  onClick={e => navigate(toRoute(routes.USER_PROFILE_UPDATE, { id: profile }))}
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
  }
      </Spin>
    
  );
}


export default UserProfile;
