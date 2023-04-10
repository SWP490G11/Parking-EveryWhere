import React, { useEffect, useState } from "react";
import { Marker, InfoWindow } from "@react-google-maps/api";
import YourLocation from '../assets/image/yourlocation.png'
import ParkingCar from '../assets/image/parkingcar.png'
import { useLocationState } from "../hooks/locationState";

const PlaceInfo = ({ parkings = [] }) => {
    const [locationState] = useLocationState()
    const [places, setPlace] = useState([])
    const [selected, setSelected] = useState(null);

    useEffect(() => {
        if (locationState.hasYourLocation) {
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
            {places.length > 0 && places.map((marker) => {
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
                            url: marker.yourLocation ? <img src={YourLocation}/> : <img src={ParkingCar}/>,
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
        </>
    );
}

export default PlaceInfo;
