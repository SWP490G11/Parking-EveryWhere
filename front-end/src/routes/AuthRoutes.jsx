import LoginPage from "../pages/loginpage/LoginPage";
import Register from "../pages/loginpage/Register";

 const AuthRoutes = [
  {
    path: "/login",
    element: <LoginPage />,
    title: "Login",
  },
  {
    path: "/register",
    element: <Register />,
    title: "Register ",
  },
];
export default AuthRoutes;