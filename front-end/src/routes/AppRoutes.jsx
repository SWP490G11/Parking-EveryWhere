import PakingDetail from "../pages/parkingPage/parkingDetail";
import HomePage from "../pages/homepage/HomePage"
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
   
   
  ];