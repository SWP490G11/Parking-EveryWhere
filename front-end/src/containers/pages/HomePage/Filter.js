import React from 'react'
import {  Form, Slider } from 'antd'
import { Sort } from '../../../utils/constants'
import { useLocationState } from '../../../hooks/locationState'
export const Filter = ({filter, setFilter }) => {
    const [locationState] = useLocationState()
    const marks = {
        0: '0km',
        99: {
          style: {
            color: '#f50',
          },
          label: <strong>100km</strong>,
        },
      };
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
                <div style={{width: '70%'}}>
                    
                    <Form.Item label={"Khoảng cách"}>

                    <Slider 
                        tooltip={{
                            open: true,
                            placement:"bottom",
                           
                          }}
                          marks={marks}
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