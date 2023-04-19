import api from "./api";

export const login = async (username, password) => {
    try {
        const response = await api.post('/api/User/Authenticate', { username, password });
        const { token } = response.data;
        localStorage.setItem('token', token);
       
        return response.data;
    } catch (error) {
        console.error(error);
        return null;
    }
};
