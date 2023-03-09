import PakingDetail from "../pages/parkingPage/parkingDetail";
import HomePage from "../pages/homepage/HomePage";
import UserProfile from "../pages/user/UserProfile";
import EditUserProfile from "../pages/user/EditUser";
import React from "react";
export const AppRoutes = [
    {
      path: "/parking/detail/:idParking",
      element: <PakingDetail />,
      title: "Parking Detail",
    },
    {
      path: "/",
      element: <HomePage />,
      title: "Home Page",
    },
    {
      path: "/user-profile/:iduser",
      element: <UserProfile />,
      title: "User Profile",
    },
    {
      path: "/user-profile/edit/:iduser",
      element: <EditUserProfile />,
      title: "Edit User Profile",
    },
   
  ];