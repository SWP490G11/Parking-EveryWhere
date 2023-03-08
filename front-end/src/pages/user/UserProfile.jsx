import "../../style/profile.css";
import HeaderComp from "../../components/HeaderComp";
import FilterComp from "../../components/FilterComp";
import { UserOutlined } from "@ant-design/icons";
import { Avatar, Space, AutoComplete, DatePicker, Button,Radio } from "antd";
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
  return (
    <>
      {" "}
      <HeaderComp />
      <div id="profile">
        <div className="avatar">
          {" "}
          <div className="user-avatar">
            <img
              src="https://img.lovepik.com/element/40143/1122.png_1200.png"
              alt=""
            />
          </div>
          <div className="user-name">Phung Nam Duy</div>
        </div>

        <ul className="user-information">
          <li id="full-name">
            Full name:
            <AutoComplete
              style={{
                marginLeft: "20px",
                width: 200,
              }}
              onSearch={handleSearch}
              options={options}
            />
          </li>
          <li id="dob">
            Date of birth:
            <DatePicker
              style={{
                marginLeft: "20px",
                width: 200,
              }}
              defaultValue={dayjs("2015-06-06", dateFormat)}
              enable
            />
          </li>

          <li id="gender">
            Gender
            <Radio.Group onChange={onChange} value={value}>
              <Radio value={1}>Male</Radio>
              <Radio value={2}>Female</Radio>
            </Radio.Group>
          </li>
          <li id="address">
            Address
            <AutoComplete
              style={{
                marginLeft: "20px",
                width: 200,
              }}
              onSearch={handleSearch}
              options={options}
            />
          </li>
          <li id="CMND">
            CMND
            <AutoComplete
              style={{
                marginLeft: "20px",
                width: 200,
              }}
              onSearch={handleSearch}
              options={options}
            />
          </li>
          <li id="phone-number">
            Phone number
            <AutoComplete
              style={{
                marginLeft: "20px",
                width: 200,
              }}
              onSearch={handleSearch}
              options={options}
            />
          </li>

          <li id="membership">
            Membership
            <AutoComplete
              style={{
                marginLeft: "20px",
                width: 200,
              }}
              onSearch={handleSearch}
              options={options}
            />
          </li>
          <li id="role">
            Role
            <AutoComplete
              style={{
                marginLeft: "20px",
                width: 200,
              }}
              onSearch={handleSearch}
              options={options}
            />
          </li>
        </ul>
      </div>
      <FooterComp />
    </>
  );
}

export default UserProfile;
