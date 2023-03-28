import {  Button, Input, Select } from "antd";
import {
 
  AppstoreOutlined,
  MailOutlined,
  SettingOutlined,
  SearchOutlined,
} from "@ant-design/icons";
import React from 'react';
const handleChange = (value) => {
  console.log(`selected ${value}`);
};
// const items = [
//   {
//     label: "Navigation One",
//     key: "mail",
//     icon: <MailOutlined />,
//   },
//   {
//     label: "Navigation Two",
//     key: "app",
//     icon: <AppstoreOutlined />,
//     disabled: true,
//   },
//   {
//     label: "Navigation Three - Submenu",
//     key: "SubMenu",
//     icon: <SettingOutlined />,
//     children: [
//       {
//         type: "group",
//         label: "Item 1",
//         children: [
//           {
//             label: "Option 1",
//             key: "setting:1",
//           },
//           {
//             label: "Option 2",
//             key: "setting:2",
//           },
//         ],
//       },
//       {
//         type: "group",
//         label: "Item 2",
//         children: [
//           {
//             label: "Option 3",
//             key: "setting:3",
//           },
//           {
//             label: "Option 4",
//             key: "setting:4",
//           },
//         ],
//       },
//     ],
//   },
//   {
//     label: (
//       <a href="https://ant.design" target="_blank" rel="noopener noreferrer">
//         Navigation Four - Link
//       </a>
//     ),
//     key: "alipay",
//   },
// ];
function FilterComp() {
  return (
    <div className="filter">
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
      <Button type="primary" icon={<SearchOutlined />}>
        Search
      </Button>
    </div>
  );
}
export default FilterComp;
