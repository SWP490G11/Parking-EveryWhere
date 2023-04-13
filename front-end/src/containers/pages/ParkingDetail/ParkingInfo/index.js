import React, { useEffect, useState } from "react";
import ImageCarousel from "./ImageCarousel";
import { useLocation } from 'react-router-dom';
import { UpdateParkingInfo } from "../UpdateInfo";
import { useAuthState } from '../../../../hooks/authState';
import { Role } from "../../../../utils/constants";
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

    const parkingImages = props.parking?.images;

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
                        <UpdateParkingInfo parking={props.parking} setLoading={props.setLoading}/>
                    </>
                    :
                    <div className="info-right">
                        <div className="right-parking-name">
                            <div style={{ fontWeight: 'bold', marginRight: '1rem' }}>Parking name: </div>
                            <div>{props.parking?.parkingName}</div>
                        </div>
                        <div className="right-parking-desc">
                            <div style={{ fontWeight: 'bold', marginRight: '1rem' }}>Description: </div>
                            <div>{props.parking?.discription}</div>
                        </div>
                        <div className="right-parking-address">
                            <div style={{ fontWeight: 'bold', marginRight: '1rem' }}>Address: </div>
                            <div>{props.parking?.addressDetail}</div>
                        </div>
                        <div className="right-parking-price">
                            <div style={{ fontWeight: 'bold', marginRight: '1rem' }}>Price: </div>
                            <div>Chưa tính được giá</div>
                        </div>
                    </div>
                }
            </div>
        </div>
    )
}

export default ParkingInfo;