import React from "react";
import ReactMapboxGl, { Layer, Feature } from "react-mapbox-gl";
const Map = ReactMapboxGl({
  accessToken:
    "pk.eyJ1IjoicGh1Y252MSIsImEiOiJjbGVoNmxxZjUwZGp3M3JteGFheHI1YWN2In0.l2DZdcNdU53TNxILTmrhVg",
});

function Mapbox() {
  return (
    <Map
    
      style="mapbox://styles/mapbox/streets-v8"
      containerStyle={{ width: "100%", height: "300px" }}
      center={[106.6297, 10.8231]}
      zoom={[12]}
    ></Map>
  );
}
export default Mapbox;
