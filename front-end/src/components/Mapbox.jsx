import "@goongmaps/goong-js/dist/goong-js.css";
import "@goongmaps/goong-geocoder/dist/goong-geocoder.css";
import React, { useRef, useState } from "react";
import MapGL, {
  NavigationControl,
  FullscreenControl,
  ScaleControl,
  GeolocateControl
} from "@goongmaps/goong-map-react";
import Geocoder from "@goongmaps/goong-geocoder-react";
import CITIES from "../data/cities.json";
import Pins from "./Pins";
const geolocateStyle = {
  top: 0,
  left: 0,
  padding: "10px"
};

const fullscreenControlStyle = {
  top: 36,
  left: 0,
  padding: "10px"
};

const navStyle = {
  top: 72,
  left: 0,
  padding: "10px"
};

const scaleControlStyle = {
  bottom: 36,
  left: 0,
  padding: "10px"
};
const Mapbox=( {result, setResult })=> {
  const [viewport, setViewport] = useState({
    latitude: 21.013470323298243,
    longitude: 105.52708575547926,
    zoom: 12
  });

  const mapRef = useRef();
  const [popupInfo, setPopupInfo] = useState(null);
  const handleViewportChange = (newViewport) => {
    setViewport({ ...viewport, ...newViewport });
  };

  // if you are happy with Geocoder default settings, you can just use handleViewportChange directly
  const handleGeocoderViewportChange = (viewport) => {
    const geocoderDefaultOverrides = { transitionDuration: 1000 };

    return handleViewportChange({
      ...viewport,
      ...geocoderDefaultOverrides
    });
  };

  return (
    
    <MapGL
      ref={mapRef}
      {...viewport}
      width="800px"
      height="800px"
      onViewportChange={handleViewportChange}
      goongApiAccessToken="4dAgWahZ3jW5LsZCiYikMTvVUOYpd2jcmxz3kyLA"
    >
      <Geocoder
      style={scaleControlStyle}
        mapRef={mapRef}
        onViewportChange={handleGeocoderViewportChange}
        goongApiAccessToken="oC8CNdh20xrH8Dpm0SIkZYQqBijW847QWVmBE0DB"
      />
      <Pins data={CITIES} onClick={setPopupInfo} />
      {/* <Marker
        latitude={21.026975}
        longitude={105.85}        
      /> */}
     
     <GeolocateControl style={geolocateStyle} />
        <FullscreenControl style={fullscreenControlStyle} />
        <NavigationControl style={navStyle} />
        {/* <ScaleControl style={scaleControlStyle} /> */}
      
    </MapGL>
  );
    }

export default Mapbox;