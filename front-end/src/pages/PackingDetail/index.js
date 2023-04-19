import React, { useEffect, useState } from 'react';
import { Card, Col, Row, Spin,Button,Modal,Input,notification } from 'antd';
import ParkingInfo from '../../containers/pages/ParkingDetail/ParkingInfo';
import ContactInfo from '../../containers/pages/ParkingDetail/ContactInfo';
import MapInfo from '../../containers/pages/ParkingDetail/MapInfo';
import { useParams } from 'react-router-dom';
import { getParkingByID } from '../../services/parkingDetailServices';
import { Feedback } from '../../containers/pages/ParkingDetail/Feedback';
import {FormOutlined} from '@ant-design/icons';
import config from '../../config';
import api from "../../services/api";
import { useAuthState } from '../../hooks/authState';
  const { TextArea } = Input;
function ParkingDetail() {
    const param = useParams();
    const id = param.parkingID;
    const [authState] =useAuthState();
    const [confirmLoading, setConfirmLoading] = useState(false);
    const [parkingDetail, setParkingDetail] = useState();
    const [loading, setLoading] = useState(true);
    const [destination, setDestination] = useState({})
    const [open, setOpen] = useState(false);
    const [note,setNote] = useState('');
  
    
   
    useEffect(() => {
        getParkingByID(id, setParkingDetail, setLoading);
    }, [id]);
    useEffect(()=> {
        if(parkingDetail) {
            setDestination(
                { lat: parkingDetail.lat, lng: parkingDetail.lon }
            )
        }
    }, [parkingDetail])
    const showModal = () => {
        setOpen(true);
      };
      const handleOk = async () => {
        setConfirmLoading(true);
        setTimeout(() => {
            setOpen(false);
  
            setConfirmLoading(false);
          }, 2000);
       await api.post('request', { note, parkingID:id }).then(()=>{
        notification.success({
            message: 'Bạn đã gửi yêu cầu thành công',
            placement: 'topLeft',
          });
       }).catch(()=>{
        notification.warning({
            message: 'Vui lòng thử lại',
            placement: 'topLeft',
       });
    })
        
      };
      const handleCancel = () => {
        setOpen(false);
      };
      console.log(note);
    return (
        <Spin spinning={loading} size="large" tip="Loading...">
            <Row gutter={10}>
                <Col span={14}>
                    <Card title="Thông tin bãi đỗ xe" style={{ minHeight: '30vh' }} bordered={true}>
                        <ParkingInfo parking={parkingDetail} setLoading={setLoading} setDestination={setDestination} />
                        <Row >
                       
                       <Col span={10} offset={14} style={{marginTop:'20px'}}>
                        {authState?.data?.role === 'Customer' ? <Button className="btn-booking" onClick={showModal} type="default"  icon={<FormOutlined />}>
                       Gửi yêu cầu</Button>: null}
                       
                           </Col>
                       </Row>
                    </Card>
                    
                </Col>
                
                <Col span={10} style={{ margin: 'auto' }}>
                    <Card title="Thông tin liên hệ" bordered={true} style={{ minHeight: '30vh' }}>
                        <ContactInfo parking={parkingDetail} />
                        
                    </Card>
                    
                </Col>
                <Col span={24} style={{ marginTop: '1rem' }}>
                    <Card title="Thông tin bản đồ" style={{ minHeight: '50vh' }} bordered={true}>
                        <MapInfo parking={parkingDetail} destination={destination} />
                    </Card>
                </Col>
            </Row>
            <div>
                <Card title="Phản hồi" bordered={true}>
                    <Feedback />
                </Card>
            </div>
            <Modal
        cancelText="Hủy"
        okText="Gửi"
        closable={true}
        open={open}
        confirmLoading={confirmLoading}
        onCancel={handleCancel}
        onOk={() => {
            return new Promise((resolve, reject) => {
                setTimeout(Math.random() > 0.5 ? resolve : reject, 1000);
                handleOk();
                setNote("");
              }).catch(() => console.log('Oops errors!'));
        }}
        
        title="Gửi yêu cầu"
        
      >
       <TextArea rows={4}  value={note} onChange={event => setNote(event.target.value)}
       placeholder="Gửi yêu cầu tới người quản lý bãi đỗ" />
       
      </Modal>
        </Spin>
        
    );
}

export default ParkingDetail;