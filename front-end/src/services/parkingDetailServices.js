import api from "./api";
import { Message } from "../utils/helpers";
import { TypeMessage } from "../utils/constants";

const getParkingByID = async (id, setParking, setLoading) => {
    try {
        api.get(`/parking/${id}`)
            .then(res => {
                setParking(res.data);
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

const updateParkingByID = (id, data, setLoading) => {
    try {
        api.put(`/parking/${id}`, data)
            .then(res => {
                setLoading(false);
                Message(TypeMessage.SUCCESS, 'Cập nhật thành công')
            })
            .catch(err => {
                Message(TypeMessage.ERROR, 'Cập nhật thất bại')
                setLoading(false);
                console.error(err)
            })
    } catch (error) {
        setLoading(false);
        Message(TypeMessage.ERROR, 'Cập nhật thất bại')
    }
}

export { getParkingByID, updateParkingByID }