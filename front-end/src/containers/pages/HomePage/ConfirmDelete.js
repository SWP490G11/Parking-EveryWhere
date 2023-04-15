import React from 'react';
import { Popconfirm } from 'antd';
import { ParkingService } from '../../../services/parkingServices';
export const ConfirmDelete = ({children, parkingID, setParking}) => (
  <Popconfirm
    title="Delete the task"
    description="Are you sure to delete this task?"
    okText="Yes"
    cancelText="No"
    onConfirm={e => {
        ParkingService.deleteParking(parkingID, setParking)
    }}
  >
    {
        children
    }
  </Popconfirm>
);
