import api from "./api";

export const getProfile = async () => {
    try {
        const response = await api.get('/api/User/GetProfile');
        return response;
    } catch (error) {
        console.error(error);
        sessionStorage.removeItem("token");
        return null;
    }
};
