
import './App.css';
import axios from "axios";
import React, { createContext, useState, useEffect } from "react";
import AuthRoutes from './routes/AuthRoutes';
import RouteComponent from './components/RouteComp';
import HeaderComp from './components/HeaderComp';
import  {AppRoutes } from './routes/AppRoutes';
import  {OwnerRoutes}  from './routes/OwnerRoutes';
import FooterComp from './components/FooterComp';
import Login from './pages/loginpage/LoginPage'
import UserProfile from './pages/user/UserProfile';
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
        
      {/* {(loginState.isLogin === false ) ? ( 
          //  <Login/>
           <RouteComponent routes={AuthRoutes} />
          // <LoginPage/>
        ) : (
          loginState.role === "Admin"  ? (
          <>
            <HeaderComp
              username={loginState.username}
              id = {loginState.id}
            />
            <RouteComponent routes={AppRoutes} />
            <FooterComp/>
          </>
        ):(<> <HeaderComp
          username={loginState.username}
          id = {loginState.id}
        />
        <RouteComponent routes={OwnerRoutes} />
        <FooterComp/></>))} */}
      
        <UserProfile/>
    
  </Context.Provider>
   
   
  );
}

export default App;
