import {  Modal, Dropdown, Avatar, Button,Input, Form, Badge } from "antd";
import {LogoutOutlined,DownOutlined, UserOutlined,CarOutlined,RedoOutlined, BellFilled} from "@ant-design/icons";
import React from "react";
import "../../style/home.css";
import axios from "axios";
import { useNavigate } from "react-router-dom";
// import '../style/Style.css'


export default function HeaderComp({username,id,role}) {
  const [isModal, setModal] = React.useState({
    isOpen: false,
    isLoading: false,
  });
  const [password, setPassword] = React.useState({
    
    oldPassword: "",
    newPassword: "",
    confirmNewPassword: "",
  });
  const [error, setError] = React.useState("");
  const [changeSuccess, setChangeSuccess] = React.useState(false);
  const [Footer, setFooter] = React.useState({});
  const formItemLayout = {
    labelCol: {
      span: 6,
    },
    wrapperCol: {
      span: 13,
      offset: 1,
    },
  };
  //Log-Out
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
          localStorage.removeItem("loginState");
          localStorage.removeItem("role");
          localStorage.removeItem("token");
          localStorage.setItem("isLogin",false);
          window.location.href = `/login`;
        });
      },
      onCancel() {},
    });
  };
  const navigate = useNavigate();
  const items = [
    {
      label: 'My Profile',
      key: '1',
      onClick: ()=>navigate(`/user-profile`),
      icon: <UserOutlined style={{ color: "red", fontWeight: "bold" }} />,
    },
    {
      label: 'My Car',
      key: '2',
      onClick: ()=>navigate(`/mycar`),
      icon: <CarOutlined  style={{ color: "red", fontWeight: "bold" }} />,
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
    <>
      {/* Header */}
      <div className="header">
        <div id="left-side">
          <a href='/home'>LOGO</a>
        </div>
       
        <div id="right-side">
        <ul>
          <li> <Badge count={100} >
             <BellFilled style={{fontSize:"30px"}} />
             </Badge>
          </li>
          <li>      <Dropdown menu={{items}} trigger={["click"]}>
          <a
            style={{
              float: "right",
              margin: "auto",
              fontSize: "20px",
              color: "white",
              marginRight: "30px",
            }}
            onClick={(e) => e.preventDefault()} 
            href="/#"
          >
             <Avatar  icon={<UserOutlined />} style={{marginRight:"10px"}}/>
            {username} <DownOutlined size='small'/>
          </a>
        </Dropdown>
        </li>
        </ul>
          
           
          
       
        
        {/*Menu*/}
      
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
              axios
                .put(`${process.env.REACT_APP_Backend_URI}api/User/ChangePassword?id=${id}` , password)
                .then(() => {
                  setChangeSuccess(true);

                  setFooter({
                    footer: (
                      <Button
                        className="buttonSave"
                        onClick={() => {
                          setFooter({});
                          setChangeSuccess(false);
                          setModal({ ...isModal, isOpen: false });
                        }}
                      >
                        Close
                      </Button>
                    ),
                  });
                })
                .catch((error) => {
                  if (!error.response.data.title) {
                    setModal({ ...isModal, isOpen: true });
                    setError(error.response.data.message);
                  } else {
                    setModal({ ...isModal, isOpen: true });
                    setError(error.response.data.title);
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
        onOk={() => {
          setChangeSuccess(true);
          setFooter({
            footer: (
              <Button
                className="buttonCancel"
                onClick={() => {
                  setFooter({});
                  setChangeSuccess(false);
                  setModal(false);
                }}
              >
                Close
              </Button>
            ),
          });
        }}
        onCancel={() => {
          setModal(false);
          setError("");
        }}
        destroyOnClose={true}
        title="Change Password"
        {...Footer}
      >
        {changeSuccess === false ? (
          <Form {...formItemLayout}>
            <Form.Item
              name="oldPassword"
              style={{ marginTop: "20px" }}
              label="Old Password"
              rules={[
                { required: true, max: 50 },
                {
                
                  message: `Password can't have white space or special characters`,
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
              label="New Password"
              rules={[
                { required: true, max: 50,  message: `New password must have riquired`},
                {
                  pattern: new RegExp("^[a-zA-Z0-9]+$"),
                  message: `New password can't have white space or special characters`,
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
              label="Confirm Password"
              rules={[
                { required: true, max: 50, whitespace: true },
                {
                  pattern: new RegExp("^[a-zA-Z0-9]+$"),
                  message: `Confirm new password must match with new password`,
                },
                ({ getFieldValue }) => ({
                  validator(_, value) {
                    if (!value || getFieldValue('newPassword') === value) {
                      return Promise.resolve();
                    }
                    return Promise.reject(new Error('The two passwords that you entered do not match!'));
                  },
                }),
              ]}
              hasFeedback
            >
              <Input.Password
                disabled={isModal.isLoading === true}
                className="inputForm"
                onChange={(pass) => {
                  setPassword({ ...password, confirmNewPassword: pass.target.value });
                }}
              />
            </Form.Item>
            <p style={{ color: "red" }}>{error}</p>
          </Form>
        ) : (
          <p>Your password has been changed successfully!</p>
        )}
      </Modal>
        </div>
      </div>
    
      
    </>
  );
}
