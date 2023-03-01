import {  Button, Input, Select } from "antd";
import {
 
  AppstoreOutlined,
  MailOutlined,
  SettingOutlined,
  SearchOutlined,
} from "@ant-design/icons";
const handleChange = (value) => {
  console.log(`selected ${value}`);
};

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
