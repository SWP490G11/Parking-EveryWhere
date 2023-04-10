import React from 'react'
import { Select, Form, Slider } from 'antd'
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
                <div style={{width: '50%'}}>
                    Khoảng cách
                    <Slider 
                        range 
                        defaultValue={[0, 500]} 
                        min={0} 
                        max={500} 
                        step={1} 
                        disabled={!locationState.hasYourLocation}
                        onChange={e => {
                            setFilter({
                                ...filter,
                                distance: e
                            })
                        }}
                    />
                </div>
                <div>
                    <Select
                        options={[
                            { value: Sort.ASC, label: 'Tăng' },
                            { value: Sort.DESC, label: 'Giảm' },
                        ]}
                        placeholder="Khu Vực"
                        onChange={e=>{
                            console.log(e)
                        }}
                    />
                </div>
                <div>
                    <Select
                        options={[
                            { value: Sort.ASC, label: 'Tăng' },
                            { value: Sort.DESC, label: 'Giảm' },
                        ]}
                        placeholder="Thành Phố"
                        onChange={e=>{
                            console.log(e)
                        }}
                    />
                </div>
            </div>
        </div>
    )
}