import PakingDetail from "../pages/parkingPage/parkingDetail";
import OwnerPage from "../pages/homepage/OwnerPage"
export const OwnerRoutes = [
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
   
   
  ];