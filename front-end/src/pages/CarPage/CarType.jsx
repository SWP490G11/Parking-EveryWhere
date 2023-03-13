import React, { useEffect, useState } from "react";
import Mapbox from "../../components/Mapbox";
import "../../style/profile.css";
import {
  Form,
  Input,
  DatePicker,
  Radio,
  Space,
  Button,
  Image,
  notification,
  Select,
  Dropdown,
  Avatar,
  Divider,
  List,
  Typography,
} from "antd";
import {
  DownOutlined,
  UserOutlined,
  LikeOutlined,
  MessageOutlined,
  StarOutlined,
} from "@ant-design/icons";
import dayjs from "dayjs";
import { useNavigate, useParams } from "react-router-dom";
import "../../style/parkingDetail.css";
import axios from "axios";

const CarType = () => {
  const [carmodel, setCarModel] = useState([]);;
  useEffect(() => {
    axios
      .get(`${process.env.REACT_APP_Backend_URI}carmodels`)
      .then(function (response) {
        
        setCarModel(response.data);
       console.log(response.data);
       
      });
      
  }, []);
  const carData = carmodel.map((it) => ({
    model: it.model,
    discript: it.discript,
    price: it.price,
  }));
  const navigate = useNavigate();
  const handleChange = (value) => {
    console.log(`selected ${value}`);
  };
  <Select
    defaultValue="lucy"
    style={{
      width: 120,
    }}
    onChange={handleChange}
    options={[
      {
        value: "jack",
        label: "Jack",
      },
      {
        value: "lucy",
        label: "Lucy",
      },
      {
        value: "Yiminghe",
        label: "yiminghe",
      },
      {
        value: "disabled",
        label: "Disabled",
        disabled: true,
      },
    ]}
  />;
  const [form] = Form.useForm();
  const id = useParams().iduser;

  const formItemLayout = {
    labelCol: {
      xs: {
        span: 24,
      },
      sm: {
        span: 8,
      },
    },
    wrapperCol: {
      xs: {
        span: 24,
      },
      sm: {
        span: 16,
      },
    },
  };
  const tailFormItemLayout = {
    wrapperCol: {
      xs: {
        span: 24,
        offset: 0,
      },
      sm: {
        span: 16,
        offset: 8,
      },
    },
  };
  
  const idParking = useParams().idParking;
  const [data, setData] = useState({});

  return (
    <div id="profile">
      <div className="form">
        <Form
          {...formItemLayout}
          form={form}
          initialValues={{
            prefix: "86",
          }}
          style={{
            maxWidth: 600,
          }}
          scrollToFirstError
        >
          <List
            itemLayout="vertical"
            size="normal"
            dataSource={carData}
            renderItem={(item) => (
              <List.Item
                key={item.Model}
                extra={
                  <img
                    width={250}
                    height={215}
                    alt="logo"
                    src="https://gw.alipayobjects.com/zos/rmsportal/mqaQswcyDLcXyDKnZfES.png"
                  />
                }
              > Model={<h1>{item.model}</h1>}
              Discipt={<h1>{item.discript}</h1>}
              Price={<h1>{item.price}</h1>}
                <List.Item.Meta
                 
                />

            
              </List.Item>
            )}
          />
          <Form.Item {...tailFormItemLayout}>
            <Button
              type="primary"
              onClick={() => navigate(`/parking-infor/edit/${id}`)}
            >
              Edit
            </Button>
            <Button type="second" onClick={() => navigate(-1)}>
              Back
            </Button>
          </Form.Item>
        </Form>
      </div>
    </div>
  );
};
export default CarType;
