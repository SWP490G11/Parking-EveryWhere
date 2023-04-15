import React, { useEffect, useState } from "react";
import { Marker, InfoWindow } from "@react-google-maps/api";
import YourLocation from '../assets/images/icon/yourlocation.png'
import ParkingCar from '../assets/images/icon/parkingcar.png'
import { useLocationState } from "../hooks/locationState";
import Markeerr from '../assets/images/marker.png';

const PlaceInfo = ({ parkings = [] ,location}) => {
    const [locationState] = useLocationState()
    const [places, setPlace] = useState([])
    const [selected, setSelected] = useState(null);

    useEffect(() => {
        
        if (locationState?.hasYourLocation) {
            setPlace([
                ...parkings,
                {
                    parkingName: 'Vị trí của bạn',
                    lat: locationState.lat,
                    lon: locationState.lng,
                    yourLocation: true
                }
            ])
        }
    }, [locationState, parkings])
    
    return (
        <>
        
            {places?.length > 0 && places.map((marker) => {
                return (
                    <Marker
                        key={`${marker.lat * marker.lon}`}
                        position={{
                            lat: marker.lat,
                            lng: marker.lon
                        }}
                        onClick={() => {
                            setSelected(marker);
                        }}
                        icon={{
                            url: marker.yourLocation ? YourLocation : ParkingCar,
                            origin: new window.google.maps.Point(0, 0),
                            anchor: new window.google.maps.Point(15, 15),
                            scaledSize: new window.google.maps.Size(40, 40)
                        }}
                    />
                )
            })}

            {selected ? (
                <InfoWindow
                    position={{
                        lat: selected.lat,
                        lng: selected.lon
                    }}
                    onCloseClick={() => {
                        setSelected(null);
                    }}
                >
                    <div>{selected.parkingName}</div>
                </InfoWindow>
            ) : null}
             {location ?(
            
            <Marker 
            position={{
               lat: location.location.lat,
               lng: location.location.lng
           }}
           icon={{
               url: Markeerr,
               origin: new window.google.maps.Point(0, 0),
               anchor: new window.google.maps.Point(15, 15),
               scaledSize: new window.google.maps.Size(40, 40)
           }}
       />
       
        ):null}
        </>
       
    );
}


export default PlaceInfo;
