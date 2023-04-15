import React from 'react'
import { LoadScript } from '@react-google-maps/api';
import config from '../../config';
const libraries = ["places", "geometry"];

export const ScriptLoaded = (props) => {
    return (
        <LoadScript
            googleMapsApiKey={config.GOOGLE_API}
            libraries={libraries}
        >
            {
                props.children
            }
      </LoadScript>
    )
}