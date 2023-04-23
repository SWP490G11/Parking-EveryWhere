import React, { useEffect } from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';

import Home from './pages/HomePage';
import Login from './pages/LoginPage';
import PackingDetail from './pages/PackingDetail';
import NotFound from './pages/NotFoundPage';
import UserProfile from './pages/UserProfilePage';
import ManageCarModel from './pages/CarModelPage';
import Register from './pages/RegisterPage';
import HeaderContainer from './containers/common/Header';
import ManageParking from './pages/ManageParkingPage';
import MyCar from './pages/MyCarPage';
import ManageParkingDetail from './pages/ManagerParkingDetail';
import ManageParkingDetailPM from './pages/ManageParkingDetailPM';
import ApproveParking from './pages/ApproveParkingPage';
import ManageParkingManager from './pages/ManagerPMPage';
import ManageUser from './pages/ManageUserPage';
import MyRequest from './pages/MyRequestPage';
import FooterContainer from './containers/common/Footer';
import MenuContainer from './containers/common/Menu';
import ManageSlot from './pages/ManageSlot';
import ManageRequest from './pages/ManageRequest';
import ManageRequestPM from './pages/ManageRequestPM';
import { useLocationState } from './hooks/locationState';
import { Layout } from 'antd';
import { routes } from './utils/routes';

const { Content } = Layout;

function App() {
  const [locationState, setLocationState] = useLocationState()

  useEffect(() => {
    position();
  }, [])

  const position = async () => {
    await navigator.geolocation.getCurrentPosition(
      position => {
        setLocationState({
          ...locationState,
          hasYourLocation: true,
          lng: position.coords.longitude,
          lat: position.coords.latitude
        })
      },
      err => {
        setLocationState({
          ...locationState,
          hasYourLocation: false
        })
        console.log(err)
      }
    );
  }
  
  const token = localStorage.getItem('token');
  return (
    <Router>
      <Layout className="layout">
      <HeaderContainer />
       
        <Content
          style={{
            padding: '0 50px',
            
          }}
        >
          {token ? (<MenuContainer  />):(<></>)}
          

          <div
            className="site-layout-content"
            style={{
              background: '#FFF',
              position: 'relative',
            minHeight: '100vh',
            }}
          >
            <Routes>
              <Route exact path={routes.HOME} element={<Home />} />
              <Route path={routes.LOGIN} element={<Login />} />
              <Route path={routes.REGISTER} element={<Register />} />
              <Route path={routes.MANAGERPARKING} element={<ManageParking />} />
              <Route path={routes.APPROVEPARKING} element={<ApproveParking />} />
              <Route path={routes.MANAGECARMODEL} element={<ManageCarModel />} />
              <Route path={routes.MY_CAR} element={<MyCar />} />
              <Route path={routes.MANAGE_SLOT} element={<ManageSlot />} />
              <Route path={routes.MANAGE_PARKINGDETAIL} element={<ManageParkingDetail />} />
              <Route path={routes.MANAGE_PARKINGDETAIL_PM} element={<ManageParkingDetailPM />} />
              <Route path={routes.MY_REQUEST} element={<MyRequest />} />
              <Route path={routes.MANAGE_REQUEST} element={<ManageRequest />} />
              <Route path={routes.MANAGE_REQUEST_PM} element={<ManageRequestPM />} />
              <Route path={routes.MANAGEPARKINGMANAGER} element={<ManageParkingManager />} />
              <Route path={routes.MANAGE_USER} element={<ManageUser />} />
              <Route path={routes.USERPROFILE} element={<UserProfile />} />
              <Route path={routes.USER_PROFILE_UPDATE} element={<UserProfile />} />
              <Route path={routes.PARKING_DETAIL} element={<PackingDetail />} />
              <Route path={routes.PARKING_DETAIL_UPDATE} element={<PackingDetail />} />
              <Route path='*' element={<NotFound />} />
            </Routes>
          </div>
        </Content>
        
        {token ? (<FooterContainer  style={{
             paddingBottom:0,
              
            }} />):(<></>)}
        
      </Layout>
    </Router >
  );
}

export default App;
