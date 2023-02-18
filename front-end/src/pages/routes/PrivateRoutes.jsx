import React from 'react'
import { Outlet, Navigate } from 'react-router-dom'



export default function PrivateRoutes() {
    const token = localStorage.getItem('loginState');
   
    return (
        <>
        {!token.isLogin ? (
         <Navigate to="/login" />
           
        ) : (
            <Outlet  />
        )}
           
        </>

    )

}