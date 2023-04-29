import React, { useEffect, useState } from 'react';
import { Card, Col, Row, Spin,Button,Modal,Input,notification } from 'antd';
import ParkingInfo from '../../containers/pages/ParkingDetail/ParkingInfo';
import ContactInfo from '../../containers/pages/ParkingDetail/ContactInfo';
import MapInfo from '../../containers/pages/ParkingDetail/MapInfo';
import { useParams } from 'react-router-dom';
import { getParkingByID } from '../../services/parkingDetailServices';
import { Feedback } from '../../containers/pages/ParkingDetail/Feedback';

import config from '../../config';
import api from "../../services/api";
import { useAuthState } from '../../hooks/authState';
 
function ParkingDetail() {
    const param = useParams();
    const id = param.parkingID;
   
    const [loading, setLoading] = useState(true);
    const [destination, setDestination] = useState({})
    const [parkingDetail, setParkingDetail] = useState();
  
   
    useEffect(() => {
        getParkingByID(id, setParkingDetail, setLoading);
        if(parkingDetail) {
            setDestination(
                { lat: parkingDetail.lat, lng: parkingDetail.lon }
            )
        }
    //   console.log(parkingDetail)
    }, [id]);
    // useEffect(()=> {
       
    // }, [parkingDetail])
    
    
      
    return (
        <Spin spinning={loading} size="large" tip="Đang tải...">
            <Row gutter={48}>
                <Col xs={24} xl={14} sm ={14}>
                    <Card title="Thông tin bãi đỗ xe" style={{ minHeight: '30vh' }} bordered={true}>
                        <ParkingInfo parking={parkingDetail} setLoading={setLoading} setDestination={setDestination} />
                        
                    </Card>
                    
                </Col>
                
                <Col xs={24} sm={10} xl={10} style={{ margin: 'auto' }}>
                    <Card title="Thông tin liên hệ" bordered={true} style={{ minHeight: '30vh' }}>
                        <ContactInfo parking={parkingDetail} />
                        
                    </Card>
                    
                </Col>
                <Col xs={24} sm={10} xl={24} style={{ marginTop: '1rem' }}>
                    <Card title="Thông tin bản đồ" style={{ minHeight: '50vh' }} bordered={true}>
                        <MapInfo parking={parkingDetail} destination={destination} />
                    </Card>
                </Col>
            </Row>
            <div>
                <Card className="ant-col ant-col-xs-24 ant-col-xl-24" title="Phản hồi" bordered={true}>
                    <Feedback />
                </Card>
            </div>
       
        </Spin>
        
    );
}

export default ParkingDetail;