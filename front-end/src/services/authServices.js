import api from "./api";
import {notification} from "antd"
export const login = async (username, password) => {
    try {
        const response = await api.post('/api/User/Authenticate', { username, password });
        const { token } = response.data;
        localStorage.setItem('token', token);
       
        return response.data;
    } catch (error) {
        if (error.response.data.message === 'User have been disabled') {
        notification.error({
            message: `Đăng nhập thất bại`,
            description: "Tài khoản bạn đã bị cấm",
            placement: "topLeft",
          })
          
        
    }else{
        notification.error({
            message: `Đăng nhập thất bại`,
            description: "Tài khoản hoặc mật khẩu không chính xác",
            placement: "topLeft",
          })
          
    }
    console.log(error.response.data.message);
    return null;}
};
