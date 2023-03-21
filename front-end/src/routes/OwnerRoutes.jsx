import PakingDetail from "../pages/CarPage/CarType";
import OwnerPage from "../pages/homepage/OwnerPage";
import UserProfile from "../pages/user/UserProfile";
import EditUserProfile from "../pages/user/EditUser";
<<<<<<< HEAD
import EditParking from "../pages/ParkingPage/EditParking";
import ParkingDetail from "../pages/CarPage/CarType";
import CarType from "../pages/CarPage/CarType";
import React from "react";

=======
import ManageParkingManager from "../pages/user/ParkingManager/ManageParkingManager";
import React from "react";
import ManageCar from "../pages/carpage/ManageCar";
>>>>>>> 95d5c93b020b04db38947714b638eac205c9aa85
export const OwnerRoutes = [
<<<<<<< HEAD
  {
    path: "/parking/detail/:idParking",
    element: <PakingDetail />,
    title: "Parking Detail",
  },
  {
    path: "/",
    element: <OwnerPage />,
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
      path: "/mycar",
      element: <ManageCar />,
      title: "My Car",
    }
    
   
  ];
>>>>>>> cb1e5f3417a834876729ff8c4ee4cfcbfc096d8c
