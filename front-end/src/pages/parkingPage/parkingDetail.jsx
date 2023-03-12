
import React, { useEffect,useState } from "react";
import Mapbox from "../../components/Mapbox";

import "../../style/parkingDetail.css";
import axios from 'axios';
import { useParams } from "react-router-dom";
import { Layout, Col, Row, Button  } from "antd";
const ParkingDetail = () => {
  const idParking = useParams().idParking;
  const [dataz,setDataz]=useState({});
  const [owner,setOwner] =useState({});
  useEffect(()=>{
    axios.get(`${process.env.REACT_APP_Backend_URI}parking/${idParking}`)
    .then(function(response) {
      setDataz(response.data);
      setOwner(response.data.owner);
      console.log(response.data);
    })
  },[idParking]);
  return (
    
        <Row>
        {/*ParkingList*/}
      <Col span={18}>
      <div id="pk-title">
            <h1>{dataz.parkingName}</h1>
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
                    {dataz.addressDetail}
                  </p>
                </div>
              </li>
              <li>
                <h3>Owner Name:{owner.lastName +" "+ owner.firstName}</h3>
                <p>Hotline: {owner.phoneNumber} </p>
                <p>Email:{owner.email} </p>
              </li>
              <li>
                <h3>Địa điểm</h3>
                {/* <Mapbox />*/}
              </li>
            </ul>
          </div>
      </Col>
        {/* Map */}
      <Col span={6}>
      <h3>Trạng thái : </h3> <h3 style={{ color: "green" }}>{dataz.status}</h3>
          <p>
            {" "}
            - Trống 3/20 slot có mái che <br />- Trống 15/20 slot không có mái
            che
          </p>
          <Button >Đăng ký slot</Button>
      
      </Col>
    </Row>
     
      // <div className="body">
      //   <div id="left-side">
      //   {data.parkingName}
          
      //   </div>
      //   <div id="right-side">
          
      //   </div>
      //   {/* Map */}

      //   <div></div>
      // </div>
     

      
    
  );
};
export default ParkingDetail;
