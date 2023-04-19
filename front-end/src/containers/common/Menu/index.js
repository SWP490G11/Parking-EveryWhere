import React, {useEffect, useState} from 'react';
import { Menu,Badge } from 'antd';
import { HomeOutlined, CarOutlined } from '@ant-design/icons';
import { routes } from '../../../utils/routes';
import {useLocation, useNavigate} from 'react-router-dom';
import { useAuthState } from '../../../hooks/authState';
import { useCountState } from '../../../hooks/countState';
import api from '../../../services/api';
const getItem = (key, label, icon = null, children = null) => {
    return { key, label, icon, children };
};



const MenuContainer=()=> {
    const navigateTo = useNavigate();
    const location = useLocation();
    const [current, setCurrent] = useState(routes.HOME);
    const [authState] = useAuthState();
    const [countState] = useCountState();
    const menuOwner = [
        getItem(routes.HOME, 'Trang chủ', <HomeOutlined />),
        getItem(routes.MANAGERPARKING, 'Quản lý bãi xe', <CarOutlined />),
        getItem(routes.MANAGE_PARKINGDETAIL, 'Quản lý đỗ xe', <CarOutlined />),
        getItem(routes.MANAGEPARKINGMANAGER, 'Quản lý nhân viên', <CarOutlined />),
        getItem(routes.MANAGE_REQUEST, (<Badge count={countState?.data}>Quản lý yêu cầu khách hàng</Badge>), <CarOutlined />),
    ]
    const menuCustomer = [
        getItem(routes.HOME, 'Trang chủ', <HomeOutlined />),
        getItem(routes.MY_REQUEST, 'Yêu cầu của tôi', <HomeOutlined />),
        getItem(routes.MY_CAR, 'Xe của tôi', <HomeOutlined />),
    ]
    const menuAdmin = [
        getItem(routes.HOME, 'Trang chủ', <HomeOutlined />),
        getItem(routes.APPROVEPARKING, (<Badge count={countState?.data}>Phê duyệt bãi đỗ</Badge>), <CarOutlined />),
        getItem(routes.MANAGECARMODEL, 'Quản lý loại xe', <CarOutlined />),
    ]
    const menuPM = [
        getItem(routes.HOME, 'Trang chủ', <HomeOutlined />),
        getItem(routes.MANAGE_SLOT, 'Quán lý chỗ đỗ', <HomeOutlined />),
        getItem(routes.MANAGE_PARKINGDETAIL_PM, 'Quản lý đỗ xe', <CarOutlined />),
        getItem(routes.MANAGE_REQUEST_PM, (<Badge count={countState?.data}>Quản lý yêu cầu khách hàng</Badge>), <CarOutlined />)
    ]
    const onClickMenu = (e) => {
        const route = e.key;
        if(!route){
            setCurrent(location?.pathname);
            return true;
        }
        setCurrent(route);
        navigateTo(route);
    }
    useEffect(() => {
        setCurrent(location?.pathname);
    }, [location]);
    
    const renderContent = () => {
        switch (authState?.data?.role) {
          case 'Admin':
            return (<>
           <Menu style={{
                margin: '16px 0',
            }} mode="horizontal" 
            onClick={onClickMenu}
            selectedKeys={[current]}
            items={menuAdmin}/>
          </>);
          case 'ParkingOwner':
            return (<>
           <Menu style={{
                margin: '16px 0',
                
            }} 
            onClick={onClickMenu}
            selectedKeys={[current]}mode="horizontal" items={menuOwner}/>
          </>);
          case 'Customer':
            return (<>
             <Menu style={{
                margin: '16px 0',
            }} mode="horizontal" 
            onClick={onClickMenu}
            selectedKeys={[current]}items={menuCustomer}/>
            </>);
          case 'ParkingManager':
            return (<>
               <Menu style={{
                margin: '16px 0',
            }} mode="horizontal" 
            onClick={onClickMenu}
            selectedKeys={[current]}items={menuPM}/>
             </>);
          default:
            return null
        }
      };
    return (
        <>{renderContent()}</>
        
    );
}

export default MenuContainer;
