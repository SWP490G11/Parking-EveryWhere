import React, { useEffect, useState } from "react";
import ImageCarousel from "./ImageCarousel";
import { useLocation } from 'react-router-dom';
import { UpdateParkingInfo } from "../UpdateInfo";
import { useAuthState } from '../../../../hooks/authState';
import { Role } from "../../../../utils/constants";
import {Tag} from 'antd';
const ParkingInfo = (props) => {
    const location = useLocation();
    const [authState] = useAuthState()
    const [isUpdate, setUpdate] = useState(false)
    useEffect(() => {
        if(authState?.data?.role) { 
            const _isUpdate = location.pathname.includes('/update') && authState?.data?.role == Role.ParkingOwner
            setUpdate(_isUpdate)
        }
    }, [authState])

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
                       
                        <div className="right-parking-price">
                            <div style={{ fontWeight: 'bold', marginRight: '1rem' }}>Trạng thái: </div>
                            <Tag color={'green'} >
                                {props.parking?.status}
                             </Tag>
                           
                        </div>
                        
                        <div className="right-parking-desc">
                            <div style={{ fontWeight: 'bold', marginRight: '1rem' }}>Địa chỉ: </div>
                            
                        </div>
                        {props.parking?.addressDetail}
                        <div className="right-parking-desc">
                            <div style={{ fontWeight: 'bold', marginRight: '1rem' }}>Mô tả: </div>
                            
                        </div>
                        <div>{props.parking?.discription}</div>
                       <div className="right-parking-price">
                            <div style={{ fontWeight: 'bold', marginRight: '1rem' }}>Loại chỗ: </div>
                            
                           
                        </div>
                          Có mái che:  {props.parking?.numberOfRoofAvailableSlot}/{props.parking?.numberOfRoofSlot} <Tag color= {'green'} >{props.parking?.status}</Tag>
                          <br/>
                          Không có mái che :  {props.parking?.numberOfRoofAvailableSlot}/{props.parking?.numberOfRoofSlot} <Tag color= {'green'} >{props.parking?.status}</Tag>
                    </div>
                }
            </div>
        </div>
    )
}

export default ParkingInfo;