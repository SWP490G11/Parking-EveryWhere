import React, { useEffect, useState } from 'react';
import GoogleMapComponent, { AutocompleteMap } from '../../components/GoogleMapComponent';
import { Button, Card, Col, Row, Spin } from 'antd';
import { ListParking, Filter, Search, CreateParking } from '../../containers/pages/HomePage';
import {
    PlusOutlined,
} from '@ant-design/icons';
import { ParkingService } from '../../services/parkingServices';
import { useAuthState } from '../../hooks/authState';
import { Role } from '../../utils/constants';

function HomePage() {
    const [loading, setLoading] = useState(true);
    const [authState] = useAuthState()
    const [search, setSearch] = useState('')
    const [filter, setFilter] = useState({})
    const [open, setOpen] = useState(false)
    const [location, setLocation] = useState(null)
    const [parkings, setParking] = useState([]);

    useEffect(() => {
        if (authState?.data?.role === Role.ParkingOwner) {
            ParkingService.getAllParkingOwner(setParking,setLoading)
        } else {
            ParkingService.getAllParking(setParking, setLoading)
        }
    }, [authState])
    return (
    
       
          <Spin spinning={loading} size="large" tip="Vui lòng đợi..."> 
            <div>
                <Row>
                    <Col span={16}>
                        <Search setSearch={setSearch} />
                        <Filter setFilter={setFilter} filter={filter} />
                    </Col>
                    <Col span={8} style={{ textAlign: 'right' }}>
                        {
                            authState?.data?.role === Role.ParkingOwner && 
                            <Button onClick={e => setOpen(true)} type="primary">
                                <PlusOutlined /> Create Parking
                            </Button>
                        }
                    </Col>
                </Row>
            </div>
            <Row gutter={10}>
                <Col span={14}>
                    <Card title="Danh sách bãi đỗ xe" bordered={true}>
                        <ListParking search={search} filter={filter} parkings={parkings.filter((u)=>u.status ==="Available")} setLocation={setLocation} setParking={setParking} />
                    </Card>
                </Col>
                {
                    !open ?
                        <Col span={10} >
                            <AutocompleteMap setLocation={setLocation} />
                            <GoogleMapComponent location={location} parkings={parkings} />
                        </Col>
                        :
                        <CreateParking open={open} setOpen={setOpen} setParking={setParking} parkings={parkings} />
                }
            </Row>
            
        </Spin>
        
       
    );
}

export default HomePage;
