import Map, {
  Marker,
  NavigationControl,
  Popup,
  FullscreenControl,
  GeolocateControl,
  ScaleControl,
} from "react-map-gl";
import 'mapbox-gl/dist/mapbox-gl.css'
// import 'react-map-gl-geocoder/dist/mapbox-gl-geocoder.css'
// import React, { useState, useRef, useCallback } from "react";
// import Geocoder from "react-map-gl-geocoder";
import "./mapbox.css"
import React, { useState, useRef, } from "react";
import axios from "axios";
import Geocoder from 'react-mapbox-gl-geocoder'
const Mapbox=( {result, setResult })=> {

  const[lat,setLat]=React.useState(21.013450292643007);
  const[lng,setLng]= React.useState(105.52707502664386);
  const [showPopup, setShowPopup] = React.useState(true);
  const [viewport, setViewport] = React.useState({
    latitude: 21.013450292643007,
    longitude: 105.52707502664386,
    zoom: 13
  });
  const [pickMarker, setPickMarker] = useState(false);
  const [pop,setPop]=useState(true);
  const [ready, setReady] = useState(false);

  const final = () => {
      axios.get(`https://api.mapbox.com/geocoding/v5/mapbox.places/${viewport.longitude},${viewport.latitude}.json?access_token=pk.eyJ1IjoiZGV2bGlucm9jaGEiLCJhIjoiY2t2bG82eTk4NXFrcDJvcXBsemZzdnJoYSJ9.aq3RAvhuRww7R_7q-giWpA`).then(res => {
          const { data } = res;
          setResult({ latitude: viewport.latitude, longitude: viewport.longitude, location: data.features[0].place_name });
          setReady(true)
      })
  }
  const lc = () => {
    console.log(result);
  };
  const mapRef = useRef();
  const handleViewportChange = (newViewport, item) => {
      if (ready) {
          setResult({ ...result, location: '' });
          setReady(false)
      }
      console.log(item);
      setViewport(newViewport);
      item.isPanning !== true && item.isZooming !== true && setResult({ latitude: newViewport.latitude, longitude: newViewport.longitude, location: item.place_name })
  }

  // const onSelected = (viewPort, item) => {
  //   navigate("/map");
  //   console.log(viewPort);
  //   setViewport({ ...viewPort, zoom: viewPort.zoom * 20 });
  //   console.log('Selected: ', item)
  // }

  const onDragStart = React.useCallback(() => {
      console.log("run")
  }, []);
  
  console.log(viewport);
  console.log(result);
 

  return (
    <div className="App">
     <div>
                <div className="autocomplete-input">
                    
                    <Geocoder
                       mapboxApiAccessToken="pk.eyJ1IjoicGh1Y252MSIsImEiOiJjbGVoNmxxZjUwZGp3M3JteGFheHI1YWN2In0.l2DZdcNdU53TNxILTmrhVg"
                         onSelected={(newViewport, item) => {handleViewportChange(newViewport, item); setReady(true)}} viewport={viewport} hideOnSelect={true} initialInputValue={result.location}
                    />
                </div>
                <div className="select-location-btn">
                    <button onClick={() => { setPickMarker(true) }}>Select Location </button>
                </div>
                {
                    (pickMarker || ready) && <div className="select-btn">
                        <button onClick={!ready ? () => final() : () => lc()} className={ready ? "ready" : "not-ready"}> {ready ? "Confirm Pickup" : "Select"} </button>
                    </div>
                }
            </div>
      <Map
        
        mapboxAccessToken="pk.eyJ1IjoicGh1Y252MSIsImEiOiJjbGVoNmxxZjUwZGp3M3JteGFheHI1YWN2In0.l2DZdcNdU53TNxILTmrhVg"
        // ref={mapRef}
       
        style={{
          width: "800px",
          height:"800px"
        }}
        ref={mapRef}
        {...viewport}
        onViewportChange={handleViewportChange}
        onTouchStart={onDragStart}
         initialViewState={{
          longitude: viewport.longitude,
          latitude: viewport.latitude,
          zoom:14
         }}
        mapStyle="mapbox://styles/mapbox/streets-v12"
      >
       {pop === true ? (
          <>
            <Marker longitude={viewport.longitude} latitude={viewport.latitude}/>
              
            <Popup
             
              longitude={viewport.longitude}
              latitude={viewport.latitude}
              closeButton={true}
              onClose={() => setShowPopup(false)}
            >
              <p>{result.location}</p>
            </Popup>
          </>
        ) : (
           <Marker longitude={result.longitude} latitude={result.latitude}/>
          
        )} 
        <NavigationControl position="bottom-right" />
        <FullscreenControl />
        
        <GeolocateControl />
      </Map>
    </div>
  );
}

export default Mapbox;