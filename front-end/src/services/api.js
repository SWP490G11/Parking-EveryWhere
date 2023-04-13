import axios from 'axios';
import config from '../config';

const token = localStorage.getItem('token') ? localStorage.getItem('token') : '';

if (token !== '') {
    axios.defaults.headers.common['Authorization'] = `Bearer ${token}`;
} else {
    delete axios.defaults.headers.common['Authorization'];
}

const api = axios.create({
    baseURL: config.API_URL,
});

export default api;