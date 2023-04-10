import React, { useCallback, useRef, useState } from "react";
import { GoogleMap, Autocomplete, DirectionsService, DirectionsRenderer } from "@react-google-maps/api";
import PlaceInfo from "../PlaceInfo";
import { useLocationState } from "../../hooks/locationState";
import { DEFAULT_LOCATION } from "../../utils/constants";
import { ScriptLoaded } from "./ScriptLoaded";
import {Input} from "antd";
const mapContainerStyle = {
    height: "80vh",
    width: "100%"
};

const options = {
    disableDefaultUI: true,
    zoomControl: true,
    fullscreenControl: true
};

const GoogleMapComponent = ({ location, parkings = [], destination = null, children = null }) => {
    const [directions, setDirections] = useState();
    const [locationState] = useLocationState()
    const count = useRef(0);
    const mapRef = useRef();
    const onMapLoad = useCallback((map) => {
        mapRef.current = map;
    }, []);

    const google = window.google;

    const directionsCallback = (
        result,
        status
    ) => {
        if (status === "OK" && count.current === 0) {
            count.current++;
            console.count();
            setDirections(result);
        }
    };

    return (
        <ScriptLoaded>
            <GoogleMap
                id="map"
                mapContainerStyle={mapContainerStyle}
                zoom={14}
                center={location ? location.location :
                        locationState.hasYourLocation ?
                            {
                                lat: locationState.lat,
                                lng: locationState.lng
                            } : DEFAULT_LOCATION
                }
                options={options}
                onLoad={onMapLoad}
            >
                <PlaceInfo parkings={parkings} />
                {
                    children
                }
                {
                    destination &&
                    <>
                        <DirectionsService
                            options={{
                                origin: { location: { lat: locationState.lat, lng: locationState.lng } },
                                destination: { location: destination },
                                travelMode: google.maps.TravelMode.DRIVING,
                            }}
                            callback={directionsCallback}
                        />
                        {directions && <DirectionsRenderer directions={directions} draggable={true} />}
                    </>
                }
            </GoogleMap>
        </ScriptLoaded>
    );
}
export const AutocompleteMap = ({ setLocation, defaultValue = "" }) => {
    const [place, setPlace] = useState();
    const[address,setAddress] = useState();
    return (
        <ScriptLoaded>
            <Autocomplete
                restrictions={{ country: "vn" }}
                onPlaceChanged={e => {
                    if (place.getPlace().geometry) {
                        console.log('place.getPlace()', place.getPlace())
                        const location = {
                                address: place.getPlace().formatted_address,
                                location: {
                                lat: place.getPlace().geometry.location.lat(),
                                lng: place.getPlace().geometry.location.lng()
                                 }
                        }
                        setLocation(location)
                        
                    } else {
                        setLocation(null)
                    }
                }}
                onLoad={e => {
                    setPlace(e)
                }}
            >
                 <input 
                    type="text"
                    allowClear
                    placeholder="Search map"
                    defaultValue={defaultValue}
                    
                    style={{
                        minHeight: 36,
                        marginBottom: 20,
                        borderRadius: 7,
                        width: '100%',
                        border: '1px solid rgb(30, 129, 210)',
                        marginTop: 20
                    }}
                />
            </Autocomplete>
        </ScriptLoaded>
    )
}

export default GoogleMapComponent;
