import PakingDetail from "../pages/parkingPage/parkingDetail";
import HomePage from "../pages/homepage/HomePage";
import UserProfile from "../pages/user/UserProfile";
import EditUserProfile from "../pages/user/EditUser";
import ManageUser from "../pages/user/ManageUser";
import ManageCarModel from "../pages/carpage/carmodelpage/ManageCarModel";
import ManageCar from "../pages/carpage/ManageCar";
import ManageRequest from "../pages/requestpage/ManageRequest";
import React from "react";
export const AppRoutes = [
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
      path: "/manageCar",
      element: <ManageCar />,
      title: "My Car",
    },
    {
      path: "/manage-request",
      element: <ManageRequest />,
      title: "Manage Request",
    }
   
   
  ];