import React from "react";
import {
    Input
} from 'antd'

export const Search = ({setSearch}) => {
    return (
       
            <Input 
                onChange={e => {
                    setSearch(e.target.value)
                }}
                style={{
                    marginBottom: 20
                }}
                placeholder="Search parking car"
            />
       
    )
}