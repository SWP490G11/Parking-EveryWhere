import { Layout } from 'antd';
import {  Routes, Route } from 'react-router-dom';
import './App.css';
import axios from "axios";
import React, { createContext,useState, useEffect } from "react";
import AuthRoutes from './routes/AuthRoutes';
import RouteComponent from './components/RouteComp';
import HeaderComp from './components/Header/HeaderComp';
import  {AppRoutes } from './routes/AppRoutes';
import  {OwnerRoutes}  from './routes/OwnerRoutes';
import  {CustomerRoutes}  from './routes/CustomerRoutes';
import  {ManagerRoutes}  from './routes/ManagerRoutes';
import FooterComp from './components/Footer/FooterComp';
import MenuComp from './components/Menu/MenuComponent';
import HomePage from "./pages/homepage/HomePage";
import LoginPage from "./pages/loginpage/LoginPage";
import Register from "./pages/loginpage/Register";
import NotFound from "./pages/NotFoundPage/NotFoundPage";
export const Context = createContext();
function App() {
  const [loginState, setLoginState] = useState({
    token: localStorage.token,
    role: localStorage.role,
    username: localStorage.username,
    id: localStorage.id,
    isLogin:false,
  });
  
  axios.defaults.baseURL = `${process.env.REACT_APP_UNSPLASH_BASEURL}`;
  axios.defaults.headers.common["Authorization"] = loginState.token;
  axios.defaults.headers.post["Content-Type"] = "application/json";

  axios.interceptors.request.use(
    (request) => {
      // Edit request config
      return request;
    },
    (error) => {
      return Promise.reject(error);
    }
  );

  axios.interceptors.response.use(
    (response) => {
      // Edit response config
      return response;
    },
    (error) => {
      return Promise.reject(error);
    }
  );

  useEffect(() => {
    if (localStorage.getItem("loginState") !== null) {
      setLoginState(JSON.parse(localStorage.getItem("loginState")));
    }
  }, [loginState.token]);
  const role= loginState.role;
  const { Content } = Layout;
  const renderContent = () => {
    switch (role) {
      case 'Admin':
        return (<>
       
      <RouteComponent  routes={AppRoutes} />
     
      </>);
      case 'ParkingOwner':
        return (<>
       
      <RouteComponent routes={OwnerRoutes} />
      
      </>);
      case 'Customer':
        return (<>
         <RouteComponent routes={CustomerRoutes} />
        </>);
      case 'ParkingManager':
        return (<>
          <RouteComponent routes={ManagerRoutes} />
         </>);
      default:
        return null
    }
  };
  const token = localStorage.getItem('token');
//   useEffect(() => {
    
//     if (!token) {
//         window.location.replace('/login')
//     }
// }, []);
  return (
    
    <Context.Provider value={[loginState, setLoginState]}>
          
          {(!token) ? ( 
          //  <Login/>
           <RouteComponent routes={AuthRoutes} />
          // <LoginPage/>
        ) : (
         
          <>
          
           <HeaderComp
                username={loginState.username}
                id = {loginState.id}
                role= {loginState.role}
              />
               <Content
          style={{
            padding: '0 50px',
          }}
        >
          <MenuComp role= {loginState.role}/>
          <div
            className="site-layout-content"
            style={{
              background: '#FFF',
            }}
          >    <Routes>
               <Route exact path={'/'} element={<HomePage role={loginState.role} />} />
         
                </Routes>
              {renderContent()}
              </div>
             
              </Content>
             
          <FooterComp/>
       
       </>
          )}
      
   
  </Context.Provider>
   
   
  );
}

export default App;
