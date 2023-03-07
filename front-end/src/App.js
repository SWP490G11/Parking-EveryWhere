
import './App.css';
import LoginPage from './pages/loginpage/LoginPage';
import RegisterPage from './pages/loginpage/Register';
import HomePage from './pages/homepage/HomePage'
import axios from "axios";
import { Routes, Route } from "react-router-dom";
import React, { createContext, useState, useEffect } from "react";
import PrivateRoute from "./pages/routes/PrivateRoutes";
import ParkingDetail from './pages/parkingDetail/parkingDetail';
import ParkingHistory from './pages/parkingDetail/parkingHistory';
import UserProfile from './pages/user/UserProfile';
export const Context = createContext();
function App() {
  const [loginState, setLoginState] = useState({
    token: localStorage.token,
    role: localStorage.role,
    username: localStorage.username,
    id: localStorage.id,

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
     
     
       <Routes>
              {/* <Route element={<PrivateRoute />}>
                <Route path="/" element={<HomePage />} />
              </Route>
              <Route path="/login" element={<LoginPage />} />
              <Route path="/register" element={<RegisterPage />} /> */}
              <Route path="/" element={<UserProfile />} />
              
            </Routes>
  </Context.Provider>
   
   
  );
}

export default App;
