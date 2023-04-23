import React, { useEffect, useState } from "react";
import ImageCarousel from "./ImageCarousel";
import { useLocation } from 'react-router-dom';
import { UpdateParkingInfo } from "../UpdateInfo";
import { useAuthState } from '../../../../hooks/authState';
import { Role } from "../../../../utils/constants";
import {Tag,Row,Col} from 'antd';
const ParkingInfo = (props) => {
    const location = useLocation();
    const [authState] = useAuthState()
    const [isUpdate, setUpdate] = useState(false)
    useEffect(() => {
        if(authState?.data?.role) { 
            const _isUpdate = location.pathname.includes('/update') && authState?.data?.role === Role.ParkingOwner
            setUpdate(_isUpdate)
        }
    }, [authState, location.pathname])

    const parkingImages = props.parking?.imageUrls;

    return (
        <div className="parking-detail-info">
           
            {
                !isUpdate && 
                <div className="info-left">
                    <ImageCarousel listImage={parkingImages} />
                </div>
            }

            <div >
                {isUpdate ?
                    <>
                        <UpdateParkingInfo parkingImages={parkingImages} parking={props.parking} setLoading={props.setLoading}/>
                    </>
                    :
                    <div className="info-right">
                        
                        <div className="right-parking-name">
                            
                            <div style={{ fontWeight: 'bold', marginRight: '1rem' }}>Tên bãi đỗ: </div>
                            {props.parking?.parkingName}
                        </div>
                        <Row>
                                <Col span={5}>
                                <div style={{ fontWeight: 'bold', marginRight: '1rem' }}>Trạng thái: </div>
                                </Col>
                                <Col span={19}>
                                <Tag color={'green'} >
                                {props.parking?.status}
                                  </Tag>
                           
                                </Col>
                            </Row>
                           
                       
                        {/* <div className="right-parking-price"> */}
                        <Row>
                                <Col span={5}>
                                <div style={{ fontWeight: 'bold', marginRight: '1rem' }}>Địa chỉ: </div>
                                </Col>
                                <Col span={19}>
                                {props.parking?.addressDetail}
                                </Col>
                            </Row>
                           
                           
                        {/* </div> */}
                        <Row>
                                <Col span={5}>
                                <div style={{ fontWeight: 'bold', marginRight: '1rem' }}>Mô tả: </div></Col>
                                <Col span={19}>
                                {props.parking?.discription}
                                </Col>
                            </Row>
                       
                            <Row>
                            <Col span={5}>  <div style={{ fontWeight: 'bold', marginRight: '1rem' }}>Giá:  </div> </Col>
                                <Col span={19}>
                            { props.parking?.priceDetails?.map((e,)=>(
                             <Row>
                               
                             <Col span={8}> {e.slotType==='ROOFED' ? 'Có mái che': 'Không  mái che'} </Col>
                             
                             <Col span={8}>
                                {e.numberOfSlots >0 ?
                                     <><Tag color= {'green'} >{e.numberOfSlots+"/"+e.numberOfSlots}</Tag></> 
                                :
                                <> <Tag color= {'red'} >{e.numberOfSlots+"/"+e.numberOfSlots}</Tag></>
                                 }
                              
                         </Col>
                         
                         <Col span={8}><Tag color={'geekblue'} >
                            {e.price} Đ
                         </Tag></Col>
                           </Row>
                            
                        )
                        )
                        }
                        </Col>
                            </Row>
                        </div>
                }
            </div>
        </div>
    )
}

export default ParkingInfo;