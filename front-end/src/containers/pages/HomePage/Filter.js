import React from 'react'
import {  Form, Slider } from 'antd'
import { Sort } from '../../../utils/constants'
import { useLocationState } from '../../../hooks/locationState'
export const Filter = ({filter, setFilter }) => {
    const [locationState] = useLocationState()
    
    return (
        <div>
            <div
                style={{
                    display: 'flex',
                    justifyContent: 'space-between',
                    justifyItems: 'center',
                    marginBottom: 20
                }}
            >
                <div style={{width: '80%'}}>
                    
                    <Form.Item label={"Khoảng cách"}>

                    <Slider 
                        tooltip={{
                            open: true,
                            placement:"bottom"
                          }}
                        
                        min={0} 
                        max={100} 
                        step={1} 
                        disabled={!locationState.hasYourLocation}
                        onChange={e => {
                            setFilter({
                                ...filter,
                                distance: e
                            })
                        }}
                    />
                    </Form.Item>
                    
                </div>
               
            </div>
        </div>
    )
}