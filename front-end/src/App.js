
import './App.css';
import HomePage from './pages/homepage/HomePage'
import axios from "axios";
import React, { createContext, useState, useEffect } from "react";
import AuthRoutes from './routes/AuthRoutes';
import RouteComponent from './components/RouteComp';
import HeaderComp from './components/HeaderComp';
import { AppRoutes } from './routes/AppRoutes';
import FooterComp from './components/FooterComp';
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
  return (
    
    <Context.Provider value={[loginState, setLoginState]}>
       
      {loginState.isLogin === false ? (
           <RouteComponent routes={AuthRoutes} />
          // <LoginPage/>
        ) : (localStorage.getItem("role") === "Admin"  ? (
          <>
            <HeaderComp
              username={loginState.username}
            />
            {/* <GridComponent
              leftComp={
                <div>
                  <ChangePasswordUser
                    isOpen={loginState.isfirstlogin === "True"}
                    userName={loginState.username}
                  />
                  <MenuComponent routes={NavRoutes} />
                  
                </div>
              }
              
              rightComp={<RouteComponent routes={AppRoutes} />}
            /> */}
            <RouteComponent routes={AppRoutes} />
            <FooterComp/>
          </>
        ):(<></>))}
       {/* <Routes>
              <Route element={<PrivateRoute />}>
                <Route path="/" element={<HomePage />} />
                <Route path="/parking/detail" element={<ParkingDetail />} />
              </Route>
              <Route path="/login" element={<LoginPage />} />
              <Route path="/register" element={<RegisterPage />} />
              <Route path="/map" element={<Map />} />
              
            </Routes> */}
    
  </Context.Provider>
   
   
  );
}

export default App;
