import React, { useState, useEffect } from "react";
import GoogleMapComponent from '../../../../components/GoogleMapComponent';
import { ParkingService } from '../../../../services/parkingServices';
import { Spin } from 'antd';

const ContactInfo = (props) => {
    const parking = props.parking?.owner;
    const [location, setLocation] = useState()
    const [parkings, setParking] = useState([]);
    const [loading, setLoading] = useState(true);

    useEffect(() => {
        if (parking) {
            setLocation({ location: { lat: props.parking?.lat, lng: props.parking?.lon } })
        }
        ParkingService.getAllParking(setParking, setLoading)
    }, [parking, props.parking?.lat, props.parking?.lon])

    return (
        
            <GoogleMapComponent location={location} parkings={parkings} destination={{ lat: props.parking?.lat, lng: props.parking?.lon }} />
    )
}

export default ContactInfo;