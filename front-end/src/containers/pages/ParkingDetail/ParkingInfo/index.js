import React, { useEffect, useState } from "react";
import ImageCarousel from "./ImageCarousel";
import { useLocation } from 'react-router-dom';
import { UpdateParkingInfo } from "../UpdateInfo";
import { useAuthState } from '../../../../hooks/authState';
import { Role } from "../../../../utils/constants";
// import config from '../../config';
import {FormOutlined} from '@ant-design/icons';
import { useParams } from 'react-router-dom';
import api from "../../../../services/api";
import {Tag,Row,Col,notification,Button,Modal,Input} from 'antd';
const { TextArea } = Input;
const ParkingInfo = (props) => {
    const location = useLocation();
    const [authState] = useAuthState()
    const id = useParams().parkingID;
    const [confirmLoading, setConfirmLoading] = useState(false);
    
    const [open, setOpen] = useState(false);
    const [note,setNote] = useState('');
    const [isUpdate, setUpdate] = useState(false)
    useEffect(() => {
        if(authState?.data?.role) { 
            const _isUpdate = location.pathname.includes('/update') && authState?.data?.role === Role.ParkingOwner
            setUpdate(_isUpdate)
        }
    }, [authState, location.pathname])

    const parkingImages = props.parking?.imageUrls;
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
   // console.log(props.parking?.priceDetails)
    return (
        <div className="parking-detail-info">
           <Row>
            <Col xs={24} sm={12} xl={10}>
            {
                !isUpdate && 
                // <div className="info-left ant-col ant-col-xs-24 ant-col-xl-24">
                    <ImageCarousel listImage={parkingImages} />
                // </div>
            }
            </Col>
            <Col xs={24} sm={12} xl={14}>
            <div >
                {isUpdate ?
                    <>
                        <UpdateParkingInfo parkingImages={parkingImages} parking={props.parking} setLoading={props.setLoading}/>
                    </>
                    :
                    <div className="info-right ant-col ant-col-xs-24 ant-col-xl-24">
                        
                        <div className="right-parking-name">
                            
                            <div style={{ fontWeight: 'bold', marginRight: '1rem' }}>Tên bãi đỗ: </div>
                            {props.parking?.parkingName}
                        </div>
                        <Row>
                                <Col xs={24} xl={6}>
                                <div style={{ fontWeight: 'bold', marginRight: '1rem' }}>Trạng thái: </div>
                                </Col>
                                <Col xs={24} xl={18}>
                                <Tag color={'green'} >
                                {props.parking?.status}
                                  </Tag>
                           
                                </Col>
                            </Row>
                           
                       
                        {/* <div className="right-parking-price"> */}
                        <Row>
                                <Col xs={24} xl={6}>
                                <div style={{ fontWeight: 'bold', marginRight: '1rem' }}>Địa chỉ: </div>
                                </Col>
                                <Col xs={24} xl={18}>
                                {props.parking?.addressDetail}
                                </Col>
                            </Row>
                           
                           
                        {/* </div> */}
                        <Row>
                                <Col xs={24} xl={6}>
                                <div style={{ fontWeight: 'bold', marginRight: '1rem' }}>Mô tả: </div></Col>
                                <Col xs={24} xl={18}>
                                {props.parking?.discription}
                                </Col>
                            </Row>
                       
                            <Row>
                            <Col xs={24} xl={6}>  <div style={{ fontWeight: 'bold', marginRight: '1rem' }}>Giá:  </div> </Col>
                                <Col xs={24} xl={18}>
                            { props.parking?.priceDetails?.map((e,)=>(
                             <Row>
                               
                             <Col xs={24} xl={8}> {e.slotType==='ROOFED' ? 'Có mái che': 'Không  mái che'} </Col>
                             
                            
                         
                         <Col xs={24} xl={8}><Tag color={'geekblue'} >
                            {e.price} Đ
                         </Tag></Col>
                           </Row>
                            
                        )
                        )
                        }
                        </Col>
                            </Row>
                            <Row >
                       
                       <Col xl={10}  style={{marginTop:'20px'}}>
                        {authState?.data?.role === 'Customer' ? <><Button className="btn-booking" onClick={showModal} type="default"  icon={<FormOutlined />}>
                       Gửi yêu cầu</Button> </> : <></>}
                       
                           </Col>
                       </Row>
                        </div>
                }
            </div>
            </Col>
           </Row>
           

           
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
        </div>
        
    )
}

export default ParkingInfo;