import React from "react";
import { Divider } from 'antd';

const ContactInfo = (props) => {

    const parkingOwner = props.parking.owner;
    const parkingManagers = props.parking.parkingManagers

    return (
        <>
            <div style={{ marginBottom: '1rem' }}>
                <div style={{ fontWeight: '700', fontSize: '1.3rem' }}>Onwer of parking</div>
                <div style={{ marginLeft: '1rem', fontSize: '1.1rem' }}>{`${parkingOwner.firstName} ${parkingOwner.lastName}`}</div>
                <div style={{ marginLeft: '1rem' }}><span style={{ fontWeight: 'bolder' }}>Phone:</span> {parkingOwner.phoneNumber}</div>
                <div style={{ marginLeft: '1rem' }}><span style={{ fontWeight: 'bolder' }}>Email:</span> {parkingOwner.email}</div>
            </div>
            <div>
                {parkingManagers > 0 &&
                    <div style={{ fontWeight: '700', fontSize: '1.3rem' }}>Parking manager</div>
                }
                {parkingManagers.map((data, key) => (
                    <div key={key}>
                        <div style={{ marginLeft: '1rem', fontSize: '1.1rem' }}>{`${data.firstName} ${data.lastName}`}</div>
                        <div style={{ marginLeft: '1rem' }}><span style={{ fontWeight: 'bolder' }}>Phone:</span> {data.phoneNumber}</div>
                        <div style={{ marginLeft: '1rem' }}><span style={{ fontWeight: 'bolder' }}>Email:</span> {data.email}</div>
                        <Divider dashed />
                    </div>
                ))}
            </div>

        </>
    )
}

export default ContactInfo;