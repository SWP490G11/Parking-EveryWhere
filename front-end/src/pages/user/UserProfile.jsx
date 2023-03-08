import "../../style/profile.css";
import HeaderComp from "../../components/HeaderComp";
import FilterComp from "../../components/FilterComp";
import { UserOutlined } from "@ant-design/icons";
import { PlusOutlined } from "@ant-design/icons";

import {
  Avatar,
  Space,
  AutoComplete,
  DatePicker,
  Button,
  Radio,
  Cascader,
  Checkbox,
  Form,
  Input,
  InputNumber,
  Select,
  Switch,
  TreeSelect,
  Upload,
} from "antd";
import { useState } from "react";
import dayjs from "dayjs";
import customParseFormat from "dayjs/plugin/customParseFormat";
import FooterComp from "../../components/FooterComp";
dayjs.extend(customParseFormat);
const dateFormat = "YYYY-MM-DD";
export function UserProfile() {
  const [options, setOptions] = useState([]);
  const handleSearch = (value) => {
    let res = [];
    if (!value || value.indexOf("@") >= 0) {
      res = [];
    } else {
      res = ["gmail.com", "163.com", "qq.com"].map((domain) => ({
        value,
        label: `${value}@${domain}`,
      }));
    }
    setOptions(res);
  };
  const [value, setValue] = useState(1);
  const onChange = (e) => {
    console.log("radio checked", e.target.value);
    setValue(e.target.value);
  };
  const { RangePicker } = DatePicker;
  const { TextArea } = Input;
  const [componentDisabled, setComponentDisabled] = useState(true);
  return (
    <>
      {" "}
      <HeaderComp />
      <div id="profile">
        <div className="avatar">
          {" "}
          <div className="user-avatar">
            <Avatar
              size={150}
              icon={
                <Form.Item
                  style={{ marginLeft: "23px", marginTop: "30px" }}
                  valuePropName="fileList"
                >
                  <Upload action="/upload.do" listType="picture-card">
                    <PlusOutlined />
                  </Upload>
                </Form.Item>
              }
              action="/upload.do"
            />{" "}
          </div>
          <div className="user-name" style={{ marginTop: "120px" }}>
            Phung Nam Duy
          </div>
        </div>

        <Form
          labelCol={{
            span: 4,
          }}
          wrapperCol={{
            span: 14,
          }}
          layout="horizontal"
          style={{
            maxWidth: 600,
          }}
        >
          <Form.Item label="Checkbox" name="disabled" valuePropName="checked">
            <Checkbox>Gender</Checkbox>
          </Form.Item>
          <Form.Item label="Radio">
            <Radio.Group name="radiogroup" defaultValue={1}>
              <Radio value={1}>Male</Radio>
              <Radio value={2}>Female</Radio>
            </Radio.Group>
          </Form.Item>
          <Form.Item label="Full name:">
            <Input />
          </Form.Item>
          <Form.Item label="Email:">
            <Input />
          </Form.Item>
          <Form.Item label="Phone number:">
            <InputNumber style={{marginLeft:"16px"}}/>
          </Form.Item>
          <Form.Item label="Select">
            <Select>
              <Select.Option value="demo">Demo</Select.Option>
            </Select>
          </Form.Item>
          <Form.Item label="TreeSelect">
            <TreeSelect
              treeData={[
                {
                  title: "Light",
                  value: "light",
                  children: [
                    {
                      title: "Bamboo",
                      value: "bamboo",
                    },
                  ],
                },
              ]}
            />
          </Form.Item>
          <Form.Item label="Cascader">
            <Cascader
              options={[
                {
                  value: "zhejiang",
                  label: "Zhejiang",
                  children: [
                    {
                      value: "hangzhou",
                      label: "Hangzhou",
                    },
                  ],
                },
              ]}
            />
          </Form.Item>
          <Form.Item label="Date of birth :">
            <DatePicker />
          </Form.Item>
          <Form.Item label="RangePicker">
            <RangePicker />
          </Form.Item>

          <Form.Item label="TextArea">
            <TextArea rows={4} />
          </Form.Item>
          <Form.Item label="Switch" valuePropName="checked">
            <Switch />
          </Form.Item>
          <Form.Item label="Upload" valuePropName="fileList">
            <Upload action="/upload.do" listType="picture-card">
              <div>
                <PlusOutlined />
                <div
                  style={{
                    marginTop: 8,
                  }}
                >
                  Upload
                </div>
              </div>
            </Upload>
          </Form.Item>
          <Form.Item label="Button">
            <Button>Button</Button>
          </Form.Item>
        </Form>
      </div>
      <FooterComp />
    </>
  );
}

export default UserProfile;
