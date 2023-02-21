import React from 'react'
import { Outlet, Navigate } from 'react-router-dom'



export default function PrivateRoutes() {
    const isLogin = localStorage.getItem('isLogin');
   
    return (
        <>
        {!isLogin ? (
         <Navigate to="/login" />
           
        ) : (
            <Outlet  />
        )}
           
        </>

    )

}