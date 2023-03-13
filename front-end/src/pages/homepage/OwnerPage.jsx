import { PlusOutlined } from '@ant-design/icons';
import { Button, Col, Drawer, Form, Input, Row, Select, Space,Layout,Dropdown,Menu } from 'antd';
import { useState } from 'react';
import React from "react";
import "../../style/home.css";
import Mapbox from "../../components/Mapbox";
import ManageMyParking from "../ParkingPage/ManageParking";

import {
    FilterOutlined
  } from "@ant-design/icons";
// Menu
const { Option } = Select;
const OwnerPage = () => {
    const [open, setOpen] = useState(false);
    const [searchText, setSearchText] = useState("");
    const [page, setPage] = useState(1);
    const [type, setType] = useState("All");
  const showDrawer = () => {
    setOpen(true);
  };
  const onClose = () => {
    setOpen(false);
  };
  
  return (
    
    <Layout>
      {/* Header */}
      {/* <HeaderComp /> */}
      {/* <FilterComp /> */}
      {/* Body */}
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
        width={720}
        onClose={onClose}
        open={open}
        bodyStyle={{
          paddingBottom: 80,
        }}
        extra={
          <Space>
            <Button onClick={onClose}>Cancel</Button>
            <Button onClick={onClose} type="primary">
              Submit
            </Button>
          </Space>
        }
      >
        <Form layout="vertical" hideRequiredMark>
          <Row gutter={16}>
            <Col span={12}>
              <Form.Item
                name="parkingName"
                label="Parking Name"
                rules={[
                  {
                    required: true,
                    message: 'Please enter Parking Name',
                  },
                ]}
              >
                <Input placeholder="Please enter Parking Name" />
              </Form.Item>
            </Col>
            <Col span={12}>
              <Form.Item
                name="Address Detail"
                label="addressDetail"
                rules={[
                  {
                    required: true,
                    message: 'Please enter address detail',
                  },
                ]}
              >
                <Input
                  style={{
                    width: '100%',
                  }}
                  
                  placeholder="Please enter address detail"
                />
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
                    message: 'Please enter Longitude ',
                  },
                ]}
              >
                <Input
                  style={{
                    width: '100%',
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
                    message: 'Please enter Latitude',
                  },
                ]}
              >
                <Input
                  style={{
                    width: '100%',
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
                    message: 'please enter url description',
                  },
                ]}
              >
                <Input.TextArea rows={4} placeholder="please enter url description" />
              </Form.Item>
            </Col>
          </Row>
        </Form>
      </Drawer>
      <Row>
        {/*ParkingList*/}
        <Col span={10}>
        <ManageMyParking/>
      </Col>
        {/* Map */}
      <Col span={14}>
      <Mapbox />
      </Col>
    </Row>
    
   
      </div>
    
      
    </Layout>
  );
};
export default OwnerPage;
