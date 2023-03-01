import React from "react";
import ReactMapboxGl, { Marker } from 'react-mapbox-gl';
import 'mapbox-gl/dist/mapbox-gl.css';

function Mapbox() {
 
  const Map = ReactMapboxGl({
    accessToken:
      "pk.eyJ1IjoicGh1Y252MSIsImEiOiJjbGVoNmxxZjUwZGp3M3JteGFheHI1YWN2In0.l2DZdcNdU53TNxILTmrhVg",
  });
  const markers = [
    { id: 1, coordinates: [-122.4194, 37.7749], title: 'San Francisco' },
    { id: 2, coordinates: [112.73019934884749,16.665290289550644], title: 'New York City' },
  ];
  return (
    <Map
      
    style="mapbox://styles/mapbox/streets-v12"
   
      center={[105.52707502664386,21.013460307970956]}
      zoom={[15]}
      containerStyle={{
        height: '100%',
        width: '100%',
      }}
    >
      {markers.map((marker) => (
        <Marker key={marker.id} coordinates={marker.coordinates}>
          <div>{marker.title}</div>
        </Marker>
      ))}
    </Map>
  );
}
export default Mapbox;
