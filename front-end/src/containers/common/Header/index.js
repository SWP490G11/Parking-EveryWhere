/* eslint-disable react-hooks/exhaustive-deps */
import React, { useEffect } from 'react';
import { useAuthState } from '../../../hooks/authState';
import { useCountState } from '../../../hooks/countState';
import { useLocation } from 'react-router-dom';
import { getProfile } from '../../../services/userProfileServices';
import { useNavigate } from "react-router-dom";
import Logo from '../../../assets/images/logo.png'
import { Avatar, Dropdown, Layout,Modal,Button,Input,Form,notification } from 'antd';
import {LogoutOutlined, IdcardOutlined,RedoOutlined,} from "@ant-design/icons";
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
          title: "Đăng xuất?",
          icon: <LogoutOutlined style={{ color: "red" }} />,
          content: "Bạn muốn đăng xuất ra khỏi hệ thống?",
          okText: "Đăng xuất",
          cancelText: "Hủy",
          okButtonProps: { style: { background: "#e30c18", color: "white" } },
    
          onOk() {
            return new Promise((resolve, reject) => {
              setTimeout(Math.random() > 0.5 ? resolve : reject, 5000);
              localStorage.removeItem('token');
              if(profileState?.data?.role==='ParkingManager'){
                localStorage.removeItem('parkingID')
              }   
              localStorage.removeItem('userID')
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
                localStorage.setItem('userID',profileState.data.id)
            if(profileState?.data?.role==='ParkingManager'){
              localStorage.setItem('parkingID',profileState?.data?.parking?.id)
            }   
            
            });
            
          
        } else if (location.pathname !== '/login' && location.pathname !=='/register') {
            window.location.replace('/login')
        }
    }, [location.pathname, token,profileState]);
    useEffect(() => {
      if (profileState?.data?.role === 'Admin') {
        api.get(`pending-parkings-number`).then((res)=>{setCountState({...countState,data:res.data})}) 
        
      }else if(profileState?.data?.role === 'ParkingOwner') {
        api.get(`pending-request-of-all-parkings-of-owner-number`).then((res)=>{setCountState({...countState,data:res.data})})
      }else  if(profileState?.data?.role === 'ParkingManager') {
        api.get(`pending-request-number/${parkingID}`).then((res)=>{setCountState({...countState,data:res.data})})
      }
  }, [profileState]);

    const navigate = useNavigate();
    const items = [
        {
          label: 'Thông tin cá nhân',
          key: '1',
          onClick: ()=>navigate(`/user-profile`),
          icon: <IdcardOutlined   style={{  fontWeight: "bold" }} />,
        },
       
        {
          
        label: 'Đổi mật khẩu',
        key: '3',
        onClick:() => setModal({ ...isModal, isOpen: true }),
        icon: <RedoOutlined  style={{ fontWeight: "bold" }} />,
      },
        {
          
        label: 'Đăng xuất',
        key: '4',
        onClick: () => handleConfirmLogout(),
        icon: <LogoutOutlined style={{ fontWeight: "bold" }} />,
      }];

    return (
        <Header style={{ background: '#1E81D2' }} className='header'>
            <div className='text-logo'>
            <a href='/'><img style={{height: '70px'}} src={Logo}/></a>
            </div>
            
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
          type="primary"
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
            Lưu
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
            Hủy
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
        title="Đổi mật khẩu"
        // {...Footer}
      >
       
          <Form {...formItemLayout} style={{
            textAlignLast:"left",
            minWidth: 400,
        }}>
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
                { required: true, message: "Vui lòng nhập mật khẩu của bạn!" },
                {
                  
                  pattern: new RegExp('^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.{8,})'),
                  message: "Mật khẩu cần ít nhất 8 kí tự và có 1 chữ in hoa, 1 chữ thường, 1 sồ !",
                },
              ]}
              
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
              label="Xác nhận "
             
              rules={[
                {
                  required: true,
                  message: 'Vui lòng nhập mật khẩu xác thực!',
                },
                ({ getFieldValue }) => ({
                  validator(_, value) {
                    if (!value || getFieldValue('newPassword') === value) {
                      return Promise.resolve();
                      
                    }
                    return Promise.reject(new Error('Mật khẩu mới và xác thực phải giống nhau!'));
                  },
                })
              ]}
               
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
