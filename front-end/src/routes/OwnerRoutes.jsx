import PakingDetail from "../pages/parkingPage/parkingDetail";
import UserProfile from "../pages/user/UserProfile";
import EditUserProfile from "../pages/user/EditUser";
import ManageParkingManager from "../pages/user/ParkingManager/ManageParkingManager";
import React from "react";
import ManageCar from "../pages/carpage/ManageCar";
import ManageRequest from "../pages/requestpage/ManageRequest";
import ManageParking from "../pages/parkingPage/ManageParking";
export const OwnerRoutes = [
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
      path: "/parking-manager-of-owner",
      element: <ManageParkingManager />,
      title: " ManageParkingManager Profile",
    },
    {
      path: "/mycar",
      element: <ManageCar />,
      title: "My Car",
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