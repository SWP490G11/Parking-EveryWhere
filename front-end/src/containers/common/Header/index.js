/* eslint-disable react-hooks/exhaustive-deps */
import React, { useEffect } from 'react';
import { useAuthState } from '../../../hooks/authState';
import { useCountState } from '../../../hooks/countState';
import { useLocation } from 'react-router-dom';
import { getProfile } from '../../../services/userProfileServices';
import { useNavigate } from "react-router-dom";
import { Avatar, Dropdown, Layout,Modal,Button,Input,Form,notification } from 'antd';
import {LogoutOutlined, UserOutlined,RedoOutlined,} from "@ant-design/icons";
import api from "../../../services/api";
const { Header } = Layout;
const formItemLayout = {
  labelCol: {
    span: 6,
  },
  wrapperCol: {
    span: 13,
    offset: 1,
  },
};
function HeaderContainer() {
    const [profileState, setProfileState] = useAuthState();
    const [countState,setCountState] = useCountState();
    const [isModal, setModal] = React.useState({
        isOpen: false,
        isLoading: false,
      });
      const [password, setPassword] = React.useState({
        
        oldPassword: "",
        newPassword: "",
        confirmNewPassword: "",
      });
      //const [Footer, setFooter] = React.useState({});
      const [error, setError] = React.useState("");
      
    const location = useLocation();
    const parkingID = localStorage.getItem('parkingID') ? localStorage.getItem('parkingID') : '';
    const token = localStorage.getItem('token') ? localStorage.getItem('token') : '';
    const handleConfirmLogout = () => {
        Modal.confirm({
          title: "Are you sure?",
          icon: <LogoutOutlined style={{ color: "red" }} />,
          content: "Do you want to log out?",
          okText: "Logout",
          cancelText: "Cancel",
          okButtonProps: { style: { background: "#e30c18", color: "white" } },
    
          onOk() {
            return new Promise((resolve, reject) => {
              setTimeout(Math.random() > 0.5 ? resolve : reject, 5000);
              localStorage.removeItem('token');
              if(profileState?.data?.role==='ParkingManager'){
                localStorage.removeItem('parkingID')
              }   
                 setProfileState(null);
              window.location.href = `/login`;
            });
          },
          onCancel() {},
        });
      };
     
    useEffect(() => {
        if (token !== '') {
            getProfile().then((data) => {
                setProfileState({
                    ...profileState,
                    data: data.data,
                    token: token
                })
            if(profileState?.data?.role==='ParkingManager'){
              localStorage.setItem('parkingID',profileState?.data?.parking?.id)
            }   

            });
            
          
        } else if (location.pathname !== '/login' && location.pathname !=='/register') {
            window.location.replace('/login')
        }
    }, [location.pathname, token]);
    useEffect(() => {
      if (profileState?.data?.role === 'Admin') {
        api.get(`pending-parkings-number`).then((res)=>{setCountState({...countState,data:res.data})}) 
        
      }else if(profileState?.data?.role === 'ParkingOwner') {
        api.get(`pending-request-of-all-parkings-of-owner-number`).then((res)=>{setCountState({...countState,data:res.data})})
      }else  if(profileState?.data?.role === 'ParkingManager') {
        api.get(`pending-request-number/${parkingID}`).then((res)=>{setCountState(res.data)})
      }
  }, [profileState]);

    const navigate = useNavigate();
    const items = [
        {
          label: 'My Profile',
          key: '1',
          onClick: ()=>navigate(`/user-profile`),
          icon: <UserOutlined style={{ color: "red", fontWeight: "bold" }} />,
        },
       
        {
          
        label: 'Change Password',
        key: '3',
        onClick:() => setModal({ ...isModal, isOpen: true }),
        icon: <RedoOutlined  style={{ color: "red", fontWeight: "bold" }} />,
      },
        {
          
        label: 'Logout',
        key: '4',
        onClick: () => handleConfirmLogout(),
        icon: <LogoutOutlined style={{ color: "red", fontWeight: "bold" }} />,
      }];

    return (
        <Header style={{ background: '#1E81D2' }} className='header'>
            <div className='text-logo'>PARKING EVERY WHERE</div>
            <div className='header-user'>

                {profileState?.token ?
                    <><Avatar src={profileState?.data?.image?.url} style={{ marginRight: '0.5rem' }} />
                        
                        <Dropdown menu={{ items }} placement="bottomRight" trigger={["click"]}>
                            <div className='text-upper' style={{ color: '#FFF', cursor: 'pointer', fontWeight: 600 }}
                            onClick={(e) => e.preventDefault()} 
                            href="/#" >
                                {profileState?.data?.userName}
                                </div>
                        </Dropdown>
                    </>
                    :
                    <>
                        {/* <Link to={'/login'}><Button type='dashed'>Đăng nhập</Button></Link>
                        <Link to={'/register'}><Button type='dashed' style={{ marginLeft: '1rem' }}>Đăng ký</Button></Link> */}
                    </>
                }
            </div>
            <Modal
        afterClose={() => {
          setError("");
        }}
        closable={false}
        cancelText="Cancel"
        okText="Save"
        okButtonProps={{ style: { background: "#e30c18", color: "white" } }}
        open={isModal.isOpen}
       
        footer={[
          <Button
            className="buttonSave"
            loading={isModal.isLoading}
            key="save"
            onClick={() => {
              setModal({ ...isModal, isLoading: true });
              setTimeout(() => {
                setModal({ ...isModal, isLoading: false });
              }, 3000);
              api.put(`api/User/ChangePassword?id=${profileState?.data?.id}` , password)
                .then(() => {
                  notification.success({
                    message: `Thành công`,
                    description: 'Đã đổi mật khẩu thành công',
                    placement: 'topLeft',
                  });
                  setModal({isModal:false});
                })
                .catch((error) => {
                  if (!error.response.data.title) {
                    setModal({ ...isModal, isOpen: true });
                    setError("Vui lòng kiểm tra lại thông tin");
                  } else {
                    setModal({ ...isModal, isOpen: true });
                    setError("Vui lòng kiểm tra lại thông tin");
                  }
                });
            }}
          >
            Save
          </Button>,
          <Button
            className="buttonCancel"
            disabled={isModal.isLoading === true}
            key="cancel"
            onClick={() => {
              setModal({ ...isModal, isOpen: false });
              setError("");
            }}
          >
            Cancel
          </Button>,
        ]}
        // onOk={() => {
        //   setChangeSuccess(true);
        // }}
        // onCancel={() => {
        //   setModal(false);
        //   setError("");
        // }}
        destroyOnClose={true}
        title="Change Password"
        // {...Footer}
      >
       
          <Form {...formItemLayout}>
            <Form.Item
              name="oldPassword"
              style={{ marginTop: "20px" }}
              label="Mật khẩu cũ"
              rules={[
                {
                    required: true,
                    message: 'Vui lòng nhập mật khẩu cũ của bạn',
                },
            ]}
              hasFeedback
            >
              <Input.Password
                disabled={isModal.isLoading === true}
                className="inputForm"
                
                onChange={(pass) => {
                  setPassword({ ...password, oldPassword: pass.target.value });
                }}
              />
            </Form.Item>
            <Form.Item
              name="newPassword"
              label="Mật khẩu mới"
              rules={[
                { required: true, max: 50, min:7,  message: `Vui lòng nhập mật khẩu`},
                {
                  pattern: new RegExp("^[a-zA-Z0-9]+$"),
                  message: `Mật khẩu không được chứa khoảng trắng hoặc kí tự mật khẩu`,
                },
                
              ]}
              hasFeedback
            >
              <Input.Password
                disabled={isModal.isLoading === true}
                className="inputForm"
                onChange={(pass) => {
                  setPassword({ ...password, newPassword: pass.target.value });
                }}
              />
            </Form.Item>
            <Form.Item
              name="confirmNewPassword"
              label="Xác nhận mật khẩu mới"
              rules={[
                { required: true, max: 50,min:8,  message: `Vui lòng nhập xác thực mật khẩu `},
                {
                  pattern: new RegExp("^[a-zA-Z0-9]+$"),
                  message: `Xác nhận mật khâu không khớp với mật khẩu mới`,
                },
                ({ getFieldValue }) => ({
                  validator(_, value) {
                    if (!value || getFieldValue('newPassword') === value) {
                      return Promise.resolve();
                    }
                    // return Promise.reject(new Error('Mật khẩu chưa đồng bộ'));
                  },
                }),
              ]}
               hasFeedback
            >
              <Input.Password
                disabled={isModal.isLoading === true}
                required={true}
                className="inputForm"
                onChange={(pass) => {
                  setPassword({ ...password, confirmNewPassword: pass.target.value });
                }}
              />
            </Form.Item>
            <p style={{ color: "red" }}>{error}</p>
          </Form>
       
      </Modal>
        </Header>
        
    );
}

export default HeaderContainer;
