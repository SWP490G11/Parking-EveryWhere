import React, {useEffect, useState} from 'react';
import { Menu } from 'antd';
import { HomeOutlined,AppstoreOutlined,FileTextOutlined } from '@ant-design/icons';

import {useLocation, useNavigate} from 'react-router-dom';


const menuadmin = [
    {
      label: (
        <a href="/">
          Home
        </a>
      ),
      key: "home",
      icon: <HomeOutlined />,
    },
    {
      label: "Parking Of Me ",
      key: "app",
      icon: <AppstoreOutlined />,
    },
    {
    label: (
      <a href="/managerUser">Manage User</a>
    ),
    key: "managerUser",
    icon: <AppstoreOutlined />,
    },
    {
      label: (
        <a href="/managerCarModel">Manage Car Model</a>
      ),
      key: "managerCarModel",
      icon: <AppstoreOutlined />,
      },
      {
        label:  <a href="/manage-request">
        Manage Request
      </a>
       ,
        key: "request",
        icon: <FileTextOutlined />,
      },
   
  ];
  const menuonwer =[
    {
      label: (
        <a href="/">
          Home
        </a>
      ),
      key: "home",
      icon: <HomeOutlined />,
    },
    {
      label: (
        <a href="/manage-parking">
          Manage Parking
        </a>
      ), 
      key: "Manage",
      icon: <AppstoreOutlined />,
    },
    {
      label:  <a href="/manage-request">
      Manage Request
    </a>
     ,
      key: "app",
      icon: <FileTextOutlined />,
    },
    {
      label:  <a href="/my-request">
      My Request
    </a>
     ,
      key: "app",
      icon: <FileTextOutlined />,
    },
  
   
    {
      label: (
        <a href="/parking-manager-of-owner">Manage parking manager</a>
      ),
      key: "alipay",
    },
  ]
  const menucustomer =[
    {
      label: (
        <a href="/">
          Home
        </a>
      ),
      key: "home",
      icon: <HomeOutlined />,
    },
    
    {
      label:  <a href="/my-request">
      My Request
    </a>
     ,
      key: "app",
      icon: <FileTextOutlined />,
    },
  ]
  const menumanager =[
    {
      label: (
        <a href="/">
          Home
        </a>
      ),
      key: "home",
      icon: <HomeOutlined />,
    },
    
    {
      label:  <a href="/my-request">
      My Request
    </a>
     ,
      key: "app",
      icon: <FileTextOutlined />,
    },
  ]
function MenuComponent({role}) {
    
    const [current, setCurrent] = useState('home');

    const onClickMenu = (e) => {
        setCurrent(e.key);
    }
    // useEffect(() => {
    //     setCurrent(location?.pathname);
    // }, []);
    const renderContent = () => {
        switch (role) {
          case 'Admin':
            return (<>
           <Menu style={{
                margin: '16px 0',
            }} mode="horizontal" 
            onClick={onClickMenu}
            selectedKeys={[current]}
            items={menuadmin}/>
          </>);
          case 'ParkingOwner':
            return (<>
           <Menu style={{
                margin: '16px 0',
                
            }} 
            onClick={onClickMenu}
            selectedKeys={[current]}mode="horizontal" items={menuonwer}/>
          </>);
          case 'Customer':
            return (<>
             <Menu style={{
                margin: '16px 0',
            }} mode="horizontal" 
            onClick={onClickMenu}
            selectedKeys={[current]}items={menucustomer}/>
            </>);
          case 'ParkingManager':
            return (<>
               <Menu style={{
                margin: '16px 0',
            }} mode="horizontal" 
            onClick={onClickMenu}
            selectedKeys={[current]}items={menumanager}/>
             </>);
          default:
            return null
        }
      };
    
    return (
        <>
        {renderContent()}
       </>
    );
}

export default MenuComponent;
