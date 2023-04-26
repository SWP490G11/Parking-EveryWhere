import api from "./api";
import { Message } from "../utils/helpers";
import { TypeMessage } from "../utils/constants";

const getParkingByID = async (id, setParking, setLoading) => {
    try {
        api.get(`/parking/${id}`)
            .then(res => {
                setParking(res.data);
                // console.log(res.data);
                setLoading(false);
            })
            .catch(err => {
                Message(TypeMessage.ERROR, 'Không thể lấy dữ liệu')
                setLoading(false);
                console.error(err)
            })
    } catch (error) {
        setLoading(false);
        Message(TypeMessage.ERROR, 'Không thể lấy dữ liệu')
    }
}

const getFeedbackByParkingID = async (id, setFeedback) => {
    try {
        api.get(`/parking/${id}`)
            .then(res => {
                setFeedback(res.data);
                
            })
            .catch(err => {
                Message(TypeMessage.ERROR, 'Không thể lấy dữ liệu')
               
                console.error(err)
            })
    } catch (error) {
        
        Message(TypeMessage.ERROR, 'Không thể lấy dữ liệu')
    }
}
const updateParkingByID = (id, data, setLoading) => {
    try {
        api.put(`/parking/${id}`, data)
            .then(() => {
                setLoading(false);
                window.location.href = `/parking-detail/${id}`;
                Message(TypeMessage.SUCCESS, 'Cập nhật bãi đỗ thành công')
            })
            .catch(err => {
                Message(TypeMessage.ERROR, 'Cập nhật bãi đỗ thất bại')
                setLoading(false);
                console.error(err)
            })
    } catch (error) {
        setLoading(false);
        Message(TypeMessage.ERROR, 'Cập nhật bãi đỗ thất bại')
    }
}

export { getParkingByID, updateParkingByID,getFeedbackByParkingID }