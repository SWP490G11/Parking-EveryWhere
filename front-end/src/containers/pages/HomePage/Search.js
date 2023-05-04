import React from "react";
import {
    Input
} from 'antd'

export const Search = ({setSearch}) => {
    return (
        <div>
            <Input 
                onChange={e => {
                    setSearch(e.target.value)
                }}
                style={{
                    marginBottom: 20
                }}
                placeholder="Tìm kiếm"
            />
        </div>
    )
}