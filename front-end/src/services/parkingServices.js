
import { Message } from "../utils/helpers";
import { TypeMessage } from "../utils/constants";
import axios from "axios";
const getAllParking = async (setParking, setLoading) => {
    try {
        axios.get(`${process.env.REACT_APP_Backend_URI}parkings`)
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

const getAllParkingOwner = async (setParking) => {
    try {
    axios.get(`${process.env.REACT_APP_Backend_URI}parkings-of-owner`)
            .then(res => {
                setParking(res.data)
            })
            .catch(err => {
                Message(TypeMessage.ERROR, 'Không thể lấy dữ liệu')
                console.error(err)
            })
    } catch (error) {
        Message(TypeMessage.ERROR, 'Không thể lấy dữ liệu')
    }
}
const createParking = async (data, setParking, parkings) => {
    try {
        await axios.post(`${process.env.REACT_APP_Backend_URI}parking`, data)
            .then(res => {
                if (res) {
                    Message(TypeMessage.SUCCESS, 'Tạo bãi đỗ thành công')
                    getAllParkingOwner(setParking)
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
        await axios.delete(`${process.env.REACT_APP_Backend_URI}parking/` + id)
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
    deleteParking
}