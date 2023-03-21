import PakingDetail from "../pages/CarPage/CarType";
import HomePage from "../pages/homepage/HomePage";
import UserProfile from "../pages/user/UserProfile";
import EditUserProfile from "../pages/user/EditUser";
import ManageUser from "../pages/user/ManageUser";
import ManageCarModel from "../pages/carpage/carmodelpage/ManageCarModel";
import ManageCar from "../pages/carpage/ManageCar";
import React from "react";
import EditParking from "../pages/ParkingPage/EditParking";

import ParkingDetail from "../pages/CarPage/CarType";
import CarType from "../pages/CarPage/CarType";
export const AppRoutes = [
<<<<<<< HEAD
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
=======
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
      path: "/managerUser",
      element: <ManageUser />,
      title: "Edit User Profile",
    },
    {
      path: "/managerCarModel",
      element: <ManageCarModel />,
      title: "Manage Car",
    },
    {
      path: "/mycar",
      element: <ManageCar />,
      title: "My Car",
    }
   
   
  ];
>>>>>>> cb1e5f3417a834876729ff8c4ee4cfcbfc096d8c
