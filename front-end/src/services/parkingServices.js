import api from "./api";
import { Message } from "../utils/helpers";
import { TypeMessage } from "../utils/constants";
const getAllParking = async (setParking, setLoading) => {
    try {
        api.get('/parkings')
            .then(res => {
                setParking(res.data)
                setLoading(false)
            })
            .catch(err => {
                Message(TypeMessage.ERROR, 'Không thể lấy dữ liệu')
                setLoading(false)
                console.error(err)
            })
    } catch (error) {
        Message(TypeMessage.ERROR, 'Không thể lấy dữ liệu')
        setLoading(false)
    }
}

const getAllParkingOwner = async (setParking,setLoading) => {
    try {
        api.get('/parkings-of-owner')
            .then(res => {
                setParking(res.data);
                setLoading(false);
            })
            .catch(err => {
                //Message(TypeMessage.ERROR, 'Không thể lấy dữ liệu');
                setLoading(false);
                console.error(err)
            })
    } catch (error) {
        Message(TypeMessage.ERROR, 'Không thể lấy dữ liệu')
    }
}
const getAllParkingManager = async (setParking,setLoading,parkingID) => {
    try {
        api.get(`/parking/${parkingID}`)
            .then(res => {
                setParking(res.data);
                setLoading(false);
            })
            .catch(err => {
                Message(TypeMessage.ERROR, 'Không thể lấy dữ liệu');
                setLoading(false);
                console.error(err)
            })
    } catch (error) {
        Message(TypeMessage.ERROR, 'Không thể lấy dữ liệu')
    }
}

const createParking = async (data, setParking, parkings) => {
    try {
        await api.post('/parking', data)
            .then(res => {
                if (res) {
                    Message(TypeMessage.SUCCESS, 'Tạo bãi đỗ thành công')
                    //getAllParkingOwner(setParking)
                }
            })
            .catch(err => {
                Message(TypeMessage.ERROR, 'Tạo bãi đỗ thất bại')
                console.error(err)
            });
    } catch (error) {
        console.error(error);
        return null;
    }
}
const deleteParking = async (id, setParking) => {
    try {
        await api.delete('/parking/' + id)
            .then(res => {
                if(res) {
                    Message(TypeMessage.SUCCESS, 'Xoá bãi đỗ thành công')
                    getAllParkingOwner(setParking)
                }
            })
            .catch(err => {
                Message(TypeMessage.ERROR, 'Xoá bãi đỗ thất bại')
                console.error(err)
            });
    } catch (error) {
        console.error(error);
        return null;
    }
}

export const ParkingService = {
    getAllParking,
    getAllParkingOwner,
    createParking,
    deleteParking,
    getAllParkingManager
}