import { Menu, Modal, Dropdown, Avatar } from "antd";
import {
  LogoutOutlined,
  AppstoreOutlined,
  MailOutlined,
  SettingOutlined,
  DownOutlined,
   UserOutlined,
   
} from "@ant-design/icons";
import React from "react";

import "../style/home.css";

const menuitems = [
  {
    label: "Home",
    key: "mail",
    icon: <MailOutlined />,
  },
  {
    label: "Parking Of Me ",
    key: "app",
    icon: <AppstoreOutlined />,
  },
  {
    label: "Payment",
    key: "SubMenu",
    icon: <SettingOutlined />,
    children: [
      {
        type: "group",
        label: "Item 1",
        children: [
          {
            label: "Option 1",
            key: "setting:1",
          },
          {
            label: "Option 2",
            key: "setting:2",
          },
        ],
      },
      {
        type: "group",
        label: "Item 2",
        children: [
          {
            label: "Option 3",
            key: "setting:3",
          },
          {
            label: "Option 4",
            key: "setting:4",
          },
        ],
      },
    ],
  },
  {
    label: (
      <a href="https://ant.design" target="_blank" rel="noopener noreferrer">
        Navigation Four - Link
      </a>
    ),
    key: "alipay",
  },
];
export default function HeaderComp({username}) {
  const [isModal, setModal] = React.useState({
    isOpen: false,
    isLoading: false,
  });
  // const {
  //   token: { colorBgContainer },
  // } = theme.useToken();
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
          localStorage.removeItem("isLogin");
          window.location.href = `/`;
        });
      },
      onCancel() {},
    });
  };
 
  const items = [
    {
      label: 'My Profile',
      key: '1',
      onClick: "",
      icon: <UserOutlined style={{ color: "red", fontWeight: "bold" }} />,
    },
    {
      
    label: 'Logout',
    key: '2',
    onClick: () => handleConfirmLogout(),
    icon: <LogoutOutlined style={{ color: "red", fontWeight: "bold" }} />,
  }];
  const menuProps = {
    items,
  };

  return (
    <>
      {/* Header */}
      <div className="header">
        <div id="left-side">
          <a href='/'>LOGO</a>
        </div>
       
        <div id="right-side">
        
        <Dropdown menu={menuProps} trigger={["click"]}>
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
            {username} <DownOutlined />
          </a>
        </Dropdown>
          {/* <ul>
            <li>
              <Button onClick={handleConfirmLogout}>Logout</Button>
            </li>
          </ul> */}
        </div>
      </div>
      <Menu mode="horizontal" items={menuitems} />;{/* Content */}
      {/* Filter */}
      
    </>
  );
}

