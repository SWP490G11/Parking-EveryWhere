
import React, { useEffect, useState } from 'react';
import { Card, Col, Row, Spin } from 'antd';
import ParkingInfo from '../../components/pages/ParkingDetail/ParkingInfo';
import ContactInfo from '../../components/pages/ParkingDetail/ContactInfo';
import MapInfo from '../../components/pages/ParkingDetail/MapInfo';
import { useParams } from 'react-router-dom';

import { Feedback } from '../../components/pages/ParkingDetail/Feedback';
import "../../style/parkingDetail.css";
import axios from 'axios';

const ParkingDetail = () => {
  const idParking = useParams().idParking;
  const [parkingDetail, setParkingDetail] = useState();
  const [loading, setLoading] = useState(true);
  useEffect(()=>{
    axios.get(`${process.env.REACT_APP_Backend_URI}parking/${idParking}`)
    .then(function(response) {
      setParkingDetail(response.data);
      console.log(response.data);
    })
  },[idParking]);
  return (
    
    <Spin spinning={loading} size="large" tip="Loading...">
    <Row gutter={10}>
        <Col span={14}>
            <Card title="Thông tin bãi đỗ xe" style={{ minHeight: '50vh' }} bordered={true}>
                <ParkingInfo parking={parkingDetail} setLoading={setLoading} />
            </Card>
        </Col>
        <Col span={10} style={{ margin: 'auto' }}>
            <Card title="Thông tin liên hệ" bordered={true}>
                <ContactInfo parking={parkingDetail} />
            </Card>
            <Card title="Feedback" bordered={true}>
                <Feedback />
            </Card>
        </Col>
        <Col span={24} style={{ marginTop: '1rem' }}>
            <Card title="Thông tin bản đồ" style={{ minHeight: '50vh' }} bordered={true}>
                <MapInfo parking={parkingDetail} />
            </Card>
        </Col>
    </Row>
</Spin>
     
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
