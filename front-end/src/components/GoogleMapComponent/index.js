import React, { useCallback, useRef, useState } from "react";
import { GoogleMap, Autocomplete, DirectionsService, DirectionsRenderer } from "@react-google-maps/api";
import PlaceInfo from "../PlaceInfo";
import { useLocationState } from "../../hooks/locationState";
import { DEFAULT_LOCATION } from "../../utils/constants";
import { ScriptLoaded } from "./ScriptLoaded";

const mapContainerStyle = {
    height: "70vh",
    width: "100%"
};

const options = {
    disableDefaultUI: true,
    zoomControl: true,
    fullscreenControl: true
};

const GoogleMapComponent = ({ location, parkings = [], destination = null, children = null, }) => {
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
                zoom={16}
                center={
                    location ? location.location :
                        locationState?.hasYourLocation ?
                            {
                                lat: locationState.lat,
                                lng: locationState.lng
                            } : DEFAULT_LOCATION
                }
                options={options}
               
                onLoad={onMapLoad}
            >   
                <PlaceInfo parkings={parkings} location={location} />
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
                                travelMode: google?.maps.TravelMode.DRIVING,
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
export const AutocompleteMap = ({ setLocation,disabled, defaultValue = "" }) => {
    const [place, setPlace] = useState()
    return (
        <ScriptLoaded>
            <Autocomplete
                restrictions={{ country: "vn" }}
                onPlaceChanged={e => {
                    if (place.getPlace()?.geometry) {
                        console.log('place.getPlace()', place.getPlace())
                        const location = {
                                address: place.getPlace().formatted_address,
                                location: {
                                lat: place.getPlace().geometry.location.lat(),
                                lng: place.getPlace().geometry.location.lng()
                                 }
                        }
                        setLocation(location);
                        console.log(location);
                    } else {
                        setLocation(null);
                       
                    }
                }}
                onLoad={e => {
                    setPlace(e)
                }}
            >
                <input
                    //className="ant-input css-dev-only-do-not-override-1e3x2xa "
                    type="text"
                    placeholder={' Tìm vị trí'}
                    defaultValue={defaultValue}
                    disabled={disabled}
                    style={{
                        minHeight: 36,
                       
                        borderRadius: 7,
                        width: '100%',
                        border: '1px solid gainsboro',
                        
                    }}
                />
            </Autocomplete>
        </ScriptLoaded>
    )
}

export default GoogleMapComponent;
