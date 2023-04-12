

import PakingDetail from "../pages/parkingPage/parkingDetail";
import HomePage from "../pages/homepage/HomePage";
import UserProfile from "../pages/user/UserProfile";
import EditUserProfile from "../pages/user/EditUser";
import MyRequest from "../pages/requestpage/MyRequest";
import ManageCar from "../pages/carpage/ManageCar";
import MyCar from "../pages/carpage/MyCar";
import React from "react";
export const CustomerRoutes = [
    {
      path: "/parking/detail/:idParking",
      element: <PakingDetail />,
      title: "Parking Detail",
    },
    {
      path: "/home",
      element: <HomePage />,
      title: "Home Page",
    },
    {
      path: "/user-profile",
      element: <UserProfile />,
      title: "User Profile",
    },
    {
      path: "/user-profile/edit",
      element: <EditUserProfile />,
      title: "Edit User Profile",
    },
    {
      path: "/manageCar",
      element: <MyCar />,
      title: "My Car",
    },
    {
      path: "/my-request",
      element: <MyRequest />,
      title: "Request of me",
    },
   
   
  ];