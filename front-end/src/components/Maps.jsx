import React from "react";
import ReactMapGL, { Marker, Popup } from "react-map-gl";
function Maps() {
  const [viewport, setViewport] = React.useState({
    width: "100vw",
    height: "100vh",
    latitude: 10.86195853994233,
    longitude: 106.74362380706191,
    zoom: 16,
  });
  const [showPopup, togglePopup] = React.useState(false);
  return (
    <ReactMapGL
    
      {...viewport}
      mapStyle="mapbox://styles/mapbox/streets-v12"
      onViewportChange={(viewport) => setViewport(viewport)}
      mapboxAccessToken="pk.eyJ1IjoicGh1Y252MSIsImEiOiJjbGVoNmxxZjUwZGp3M3JteGFheHI1YWN2In0.l2DZdcNdU53TNxILTmrhVg"
    >
      {showPopup && (
        <Popup
          latitude={10.86195853994233}
          longitude={106.74362380706191}
          closeButton={true}
          closeOnClick={true}
          onClose={() => togglePopup(false)}
          anchor="top-right"
        >
          <div>Pop up marker</div>
        </Popup>
      )}
      {/* 10.86195853994233, 106.74362380706191 */}
      <Marker
        latitude={10.86195853994233}
        longitude={106.74362380706191}
        offsetLeft={-20}
        offsetTop={-30}
      >
        <img
          onClick={() => togglePopup(true)}
          style={{ height: 50, width: 50 }}
          src="https://xuonginthanhpho.com/wp-content/uploads/2020/03/map-marker-icon.png"
        />
      </Marker>
      <Marker
        latitude={10.86185853994233}
        longitude={106.74872380706191}
        offsetLeft={-20}
        offsetTop={-30}
      >
        <img
          style={{ height: 50, width: 50 }}
          src="https://xuonginthanhpho.com/wp-content/uploads/2020/03/map-marker-icon.png"
        />
      </Marker>
    </ReactMapGL>
  );
}

export default Maps;