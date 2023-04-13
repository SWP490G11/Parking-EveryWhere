import { message } from 'antd';
import { TypeMessage } from './constants';

export const calDistance = (lat1, lng1, lat2, lng2) => {
    const google = window.google
    const location_1 = new google.maps.LatLng(lat1, lng1)
    const location_2 = new google.maps.LatLng(lat2, lng2)
    const distance = google.maps.geometry.spherical.computeDistanceBetween(location_1, location_2)
    return distance / 1000
}

export const Message = (type, content) => {
    switch(type) {
        case TypeMessage.ERROR:
            return message.error(content); 
        case TypeMessage.LOADING:
            return message.loading(content); 
        case TypeMessage.SUCCESS:
            return message.success(content); 
        case TypeMessage.WARNING:
            return message.warning(content); 
        case TypeMessage.INFO:
            return message.info(content); 
        default:
            return message.info(content); 
    }
}

export const toRoute = (baseRoute, params) => {
    let route = baseRoute;
    if (params) {
        Object.keys(params).forEach((k) => {
            const value = params[k];
            route = route.replace(':' + k, value);
        });
    }
    return route;
};