import PakingDetail from "../pages/parkingPage/parkingDetail";
import OwnerPage from "../pages/homepage/OwnerPage";
import UserProfile from "../pages/user/UserProfile";
import EditUserProfile from "../pages/user/EditUser";
import ManageParkingManager from "../pages/user/ParkingManager/ManageParkingManager";
import React from "react";
import ManageRequest from "../pages/requestpage/ManageRequest";
import ManageParking from "../pages/parkingPage/ManageParking";
export const ManagerRoutes = [
    {
      path: "/parking/detail/:idParking",
      element: <PakingDetail />,
      title: "Parking Detail",
    },
    {
      path: "/home",
      element: <OwnerPage />,
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
      path: "/parking-manager-of-owner",
      element: <ManageParkingManager />,
      title: " ManageParkingManager Profile",
    },
    {
      path: "/manage-request",
      element: <ManageRequest />,
      title: "Manage Request",
    },
    {
      path: "/manage-parking",
      element: < ManageParking />,
      title: "Request of Owner",
    },

   
   
  ];