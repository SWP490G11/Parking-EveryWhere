import PakingDetail from "../pages/parkingPage/parkingDetail";

import UserProfile from "../pages/user/UserProfile";
import EditUserProfile from "../pages/user/EditUser";
import ManageUser from "../pages/user/ManageUser";
import ManageCarModel from "../pages/carpage/carmodelpage/ManageCarModel";
import ManageCar from "../pages/carpage/ManageCar";
import ManageAprroveParking from "../pages/requestpage/ManageApproveParking";
import React from "react";
export const AppRoutes = [
    {
      path: "/parking/detail/:idParking",
      element: <PakingDetail />,
      title: "Parking Detail",
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
      element: <ManageAprroveParking />,
      title: "Manage Request",
    }
   
   
  ];