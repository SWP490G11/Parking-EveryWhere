import {
  PlusOutlined,
  LikeOutlined,
  MessageOutlined,
  StarOutlined,
  FilterOutlined,
} from "@ant-design/icons";
import {
  Button,
  Col,
  Drawer,
  notification,
  Form,
  Input,
  Row,
  Select,
  Space,
  Layout,
  Dropdown,
  Menu,
  Avatar,
  List,
} from "antd";
import React, { useEffect, useState } from "react";
import "../../style/home.css";
import Mapbox from "../../components/Mapbox";

import axios from "axios";

import { AddressAutofill, SearchBox } from "@mapbox/search-js-react";
import ManageParking from "../parkingPage/ManageParking";
// Menu
const { Option } = Select;
const OwnerPage = () => {
  const IconText = ({ icon, text }) => (
    <Space>
      {React.createElement(icon)}
      {text}
    </Space>
  );
  const [open, setOpen] = useState(false);
  const [searchText, setSearchText] = useState("");
  const [page, setPage] = useState(1);
  const [type, setType] = useState("All");
  const [result, setResult] = useState({
    latitude: 24.8607,
    longitude: 67.0011,
    location: "Karachi"
  });
  const showDrawer = () => {
    setOpen(true);
  };
  const onClose = () => {
    setOpen(false);
  };
  const onFinish = (values) => {
    axios
      .post(`${process.env.REACT_APP_Backend_URI}parking`, {
        parkingName: values.parkingName,
        addressDetail: values.addressDetail,
        lon: values.lon,
        lat: values.lat,
        discription: values.discription,
        status: "Available",
        isLegal: true,
        lastModifyAt: new Date(),
      })
      .then(() => {
        // sessionStorage.setItem("changeStatus", true);
        notification.success({
          message: `Successfully`,
          description: "Create new parking successfully",
          placement: "topLeft",
        });
        setOpen(false);
        // window.location.reload(false);
      })
      .catch((error) => {
        notification.warning({
          message: `Fail`,
          description: "Please check input again",
          placement: "topLeft",
        });
      });
  };
  const [itemz, setItemz] = useState([]);
  useEffect(() => {
    axios
      .get(`${process.env.REACT_APP_Backend_URI}parkings-of-owner`)
      .then(function (response) {
        setItemz(response.data);
      });
  }, []);
  const findaddress=()=>{
    axios.get("https://rsapi.goong.io/geocode?address=91%20Trung%20K%C3%ADnh,%20Trung%20H%C3%B2a,%20C%E1%BA%A7u%20Gi%E1%BA%A5y,%20H%C3%A0%20N%E1%BB%99i&api_key={TMw3W9agfk2vQofcCzZFATxEwpM7HSYthHMgz7Dl}")
    .then((response) => {
      
      console.log(response.data);
    })
  }
  const data = itemz.map((it) => ({
    href: `/parking/detail/${it.id}`,
    title: it.parkingName,
    avatar: `https://joesch.moe/api/v1/random`,
    description: it.discription,
    content: it.addressDetail,
  }));
  const [value, setValue] = React.useState("");
  return (
    <Layout>
      <div className="body">
        {/*Search*/}
        <Row gutter={45} style={{ marginBottom: "30px" }}>
          <Col xs={8} sm={8} md={7} lg={7} xl={6} xxl={5}>
            <Dropdown.Button
              placement="bottom"
              icon={<FilterOutlined />}
              overlay={
                <Menu>
                  <Menu.Item
                    onClick={() => {
                      setType("10");
                    }}
                  >
                    {" "}
                    Grade 10
                  </Menu.Item>
                  <Menu.Item
                    onClick={() => {
                      setType("11");
                    }}
                  >
                    {" "}
                    Grade 11
                  </Menu.Item>
                  <Menu.Item
                    onClick={() => {
                      setType("12");
                    }}
                  >
                    {" "}
                    Grade 12
                  </Menu.Item>
                  <Menu.Item
                    onClick={() => {
                      setType("All");
                    }}
                  >
                    {" "}
                    All
                  </Menu.Item>
                </Menu>
              }
            >
              {type}
            </Dropdown.Button>
          </Col>
          <Col xs={8} sm={8} md={7} lg={7} xl={8} xxl={8}>
            <Input.Search
              placeholder="Search Classroom"
              maxLength={255}
              allowClear
              onSearch={(e) => {
                setPage(1);
                setSearchText(e.replace(/ /g, ""));
              }}
            />
          </Col>
          <Col xs={8} sm={8} md={7} lg={7} xl={9} xxl={9}>
            {/*Add new parking*/}
            <Button type="primary" onClick={showDrawer} icon={<PlusOutlined />}>
              New Parking
            </Button>
          </Col>
        </Row>

        <Drawer
          title="Create a new account"
          width={550}
          onClose={onClose}
          open={open}
          bodyStyle={{
            paddingBottom: 80,
          }}
        >
          <Form onFinish={onFinish} layout="vertical" hideRequiredMark>
            <Row gutter={16}>
              <Col span={24}>
                <Form.Item
                  name="parkingName"
                  label="Parking Name"
                  rules={[
                    {
                      required: true,
                      message: "Please enter Parking Name",
                    },
                  ]}
                >
                  <Input placeholder="Please enter Parking Name" />
                </Form.Item>
              </Col>
            </Row>
            <Row gutter={16}>
              <Col span={24}>
                <Form.Item
                  name="addressDetail"
                  label="Address Detail"
                  rules={[
                    {
                      required: true,
                      message: "Please enter address detail",
                    },
                  ]}
                >
                  <Input
                    style={{
                      width: "100%",
                    }}
                    placeholder="Please enter address detail"
                  />
                  <Button onClick={()=>findaddress()}>Search</Button>
                </Form.Item>
              </Col>
            </Row>
            <Row gutter={16}>
              <Col span={12}>
                <Form.Item
                  name="lon"
                  label="Longitude"
                  rules={[
                    {
                      required: true,
                      message: "Please enter Longitude ",
                    },
                  ]}
                >
                  <Input
                    style={{
                      width: "100%",
                    }}
                    placeholder="Please enter Longitude"
                  />
                </Form.Item>
              </Col>
              <Col span={12}>
                <Form.Item
                  name="lat"
                  label="Latitude"
                  rules={[
                    {
                      required: true,
                      message: "Please enter Latitude",
                    },
                  ]}
                >
                  <Input
                    style={{
                      width: "100%",
                    }}
                    placeholder="Please enter Latitude"
                  />
                </Form.Item>
              </Col>
            </Row>

            <Row gutter={16}>
              <Col span={24}>
                <Form.Item
                  name="discription"
                  label="Description"
                  rules={[
                    {
                      required: true,
                      message: "please enter url description",
                    },
                  ]}
                >
                  <Input.TextArea
                    rows={4}
                    placeholder="please enter url description"
                  />
                </Form.Item>
              </Col>
            </Row>
            
            <Row gutter={16}>
            <Col span={24}>
            <Space>
              <Button onClick={onClose}>Cancel</Button>
              <Button htmlType="submit" type="primary">
                Submit
              </Button>
              </Space>
           
              </Col>
           
            </Row>
            <Mapbox />
          </Form>
        </Drawer>
        <Row>
          {/*ParkingList*/}
          <Col span={10}>
            <ManageParking />
            {/* <List
    itemLayout="vertical"
    size="normal"
    pagination={{
      onChange: (page) => {
        console.log(page);
      },
      pageSize: 3,
    }}
    dataSource={data}
    renderItem={(item) => (
      <List.Item
        key={item.title}
        actions={[
          <IconText icon={StarOutlined} text="156" key="list-vertical-star-o" />,
          <IconText icon={LikeOutlined} text="156" key="list-vertical-like-o" />,
          <IconText icon={MessageOutlined} text="2" key="list-vertical-message" />,
        ]}
        extra={
          <img
            width={250}
            height={215}
            alt="logo"
            src="https://gw.alipayobjects.com/zos/rmsportal/mqaQswcyDLcXyDKnZfES.png"
          />
        }
      >
        
        <List.Item.Meta
          avatar={<Avatar src={item.avatar} />}
          title={<a href={item.href}>{item.title}</a>}
          description={item.description}
        />
        {item.content}
      </List.Item>
    )}
  /> */}
          </Col>
          {/* Map */}
          <Col span={14}>
            <Mapbox result={result} setResult={setResult} />
          </Col>
        </Row>
      </div>
    </Layout>
  );
};
export default OwnerPage;
