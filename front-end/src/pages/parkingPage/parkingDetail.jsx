
import React, { useEffect,useState } from "react";
import Mapbox from "../../components/Mapbox";

import "../../style/parkingDetail.css";
import axios from 'axios';
import { useParams } from "react-router-dom";
import { Layout, Col, Row, Button  } from "antd";
const ParkingDetail = () => {
  const idParking = useParams().idParking;
  const [data,setData]=useState({});
  useEffect(()=>{
    axios.get(`${process.env.REACT_APP_Backend_URI}parking/${idParking}`)
    .then(function(response) {
      setData(response.data);
     
    })
  },[idParking]);
  return (
    <Layout>
        <Row>
        {/*ParkingList*/}
      <Col span={18}>
      <div id="pk-title">
            <h1>{data.parkingName}</h1>
          </div>
          <div id="image">
            <img src="#" />
          </div>
          <div id="pk-detail">
            <ul>
              <li>
                <div id="pk-info">
                  <h3>Thông tin mô tả</h3>
                  <p>
                    {data.addressDetail}
                  </p>
                </div>
              </li>
              <li>
                {/* <h3>Owner Name: {data.owner.lastName +" "+ data.owner.firstName }</h3> */}
                {/* <p>Hotline: {data.owner.phoneNumber}</p>
                <p>Email: {data.owner.email}</p> */}
              </li>
              <li>
                <h3>Địa điểm</h3>
                {/* <Mapbox /> */}
              </li>
            </ul>
          </div>
      </Col>
        {/* Map */}
      <Col span={6}>
      <h3>Trạng thái : </h3> <h3 style={{ color: "green" }}>{data.status}</h3>
          <p>
            {" "}
            - Trống 3/20 slot có mái che <br />- Trống 15/20 slot không có mái
            che
          </p>
          <Button onClick>Đăng ký slot</Button>
      
      </Col>
    </Row>
      {/* Body */}
      <div className="body">
        <div id="left-side">
        {data.parkingName}
          
        </div>
        <div id="right-side">
          
        </div>
        {/* Map */}

        <div></div>
      </div>
      {/* About */}
      {/* Footer */}

      
    </Layout>
  );
};
export default ParkingDetail;
