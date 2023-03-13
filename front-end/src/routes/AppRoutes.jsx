import PakingDetail from "../pages/CarPage/CarType";
import HomePage from "../pages/homepage/HomePage";
import UserProfile from "../pages/user/UserProfile";
import EditUserProfile from "../pages/user/EditUser";
import React from "react";
import EditParking from "../pages/ParkingPage/EditParking";

import ParkingDetail from "../pages/CarPage/CarType";
import CarType from "../pages/CarPage/CarType";
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
  {
    path: "/parking-infor/:iduser",
    element: <ParkingDetail />,
    title: "Parking",
  },
  {
    path: "/parking-infor/edit/:iduser",
    element: <EditParking />,
    title: "Parking",
  },
  {
    path: "/car-type",
    element: <CarType />,
    title: "Car Detail",
  },
];
