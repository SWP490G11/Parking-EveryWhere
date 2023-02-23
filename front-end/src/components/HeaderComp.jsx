import {
  
  Layout,
  Menu,
  theme,
  Button,
  Modal,
  Input,
  Select,
} from "antd";
import {
  LogoutOutlined,
  AppstoreOutlined,
  MailOutlined,
  SettingOutlined,
} from "@ant-design/icons";
import React from "react";

import "../style/home.css";


const { Header, Content, Sider } = Layout;
const handleChange = (value) => {
  console.log(`selected ${value}`);
};

const items = [
  {
    label: "Navigation One",
    key: "mail",
    icon: <MailOutlined />,
  },
  {
    label: "Navigation Two",
    key: "app",
    icon: <AppstoreOutlined />,
    disabled: true,
  },
  {
    label: "Navigation Three - Submenu",
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
const menuitems = [
  {
    label: "Navigation One",
    key: "mail",
    icon: <MailOutlined />,
  },
  {
    label: "Navigation Two",
    key: "app",
    icon: <AppstoreOutlined />,
    disabled: true,
  },
  {
    label: "Navigation Three - Submenu",
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
function HeaderComp() {
  const {
    token: { colorBgContainer },
  } = theme.useToken();
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
  return (
    <>
      {/* Header */}
      <div className="header">
        <div id="left-side">
          <a href="#">LOGO</a>
        </div>
        <div id="right-side">
          <ul>
            <li>
              <Button onClick={handleConfirmLogout}>Logout</Button>
            </li>
          </ul>
        </div>
      </div>
      <Menu mode="horizontal" items={menuitems} />;{/* Content */}
      {/* Filter */}
      <Input placeholder="Basic usage" />
      <Select
        defaultValue="lucy"
        style={{
          width: 200,
        }}
        onChange={handleChange}
        options={[
          {
            label: "Manager",
            options: [
              {
                label: "Jack",
                value: "jack",
              },
              {
                label: "Lucy",
                value: "lucy",
              },
            ],
          },
          {
            label: "Engineer",
            options: [
              {
                label: "yiminghe",
                value: "Yiminghe",
              },
            ],
          },
        ]}
      />
      <Select
        defaultValue="lucy"
        style={{
          width: 200,
        }}
        onChange={handleChange}
        options={[
          {
            label: "Manager",
            options: [
              {
                label: "Jack",
                value: "jack",
              },
              {
                label: "Lucy",
                value: "lucy",
              },
            ],
          },
          {
            label: "Engineer",
            options: [
              {
                label: "yiminghe",
                value: "Yiminghe",
              },
            ],
          },
        ]}
      />
      <Select
        defaultValue="lucy"
        style={{
          width: 200,
        }}
        onChange={handleChange}
        options={[
          {
            label: "Manager",
            options: [
              {
                label: "Jack",
                value: "jack",
              },
              {
                label: "Lucy",
                value: "lucy",
              },
            ],
          },
          {
            label: "Engineer",
            options: [
              {
                label: "yiminghe",
                value: "Yiminghe",
              },
            ],
          },
        ]}
      />
    </>
  );
}
export default HeaderComp;
