import React, { useEffect, useState } from 'react';
import GoogleMapComponent, { AutocompleteMap } from '../../components/GoogleMapComponent';
import { Button, Card, Col, Row, Spin,Input } from 'antd';
import { ListParking, Filter, CreateParking } from '../../containers/pages/HomePage';
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
            ParkingService.getAllParkingOwnerAvailable(setParking,setLoading)
        } else {
            ParkingService.getAllParkingAvailable(setParking, setLoading)
        }
    }, [authState])
    // const finalData =
    // search === ""? parkings : (parkings.filter((u) =>
    // u.parkingName
    // .toLowerCase()
    // .replace(/\s+/g, "")
    // .includes(search.toLowerCase().replace(/\s+/g, "")) 
    //           // || u.id.toLowerCase().includes(searchText.toLowerCase())
    //     ) 
    //     );
    return (
    
       
          <Spin spinning={loading} size="large" tip="Vui lòng đợi..."> 
            <div>
                <Row>
                <Col span={8}> <Filter setFilter={setFilter} filter={filter} /></Col>
                    <Col span={8}>
                    <Input.Search
            placeholder="Tìm kiếm bãi đỗ"
            maxLength={255}
            allowClear
            onSearch={(e) => {
             
                setSearch(e.replace(/ /g, ""));
            }}
          /> 
                       
                    </Col>
                    <Col span={8} style={{ textAlign: 'right' }}>
                        {
                            authState?.data?.role === Role.ParkingOwner && 
                            <Button onClick={e => setOpen(true)} type="primary">
                                <PlusOutlined /> Tạo bãi đỗ
                            </Button>
                        }
                    </Col>
                </Row>
            </div>
            <Row gutter={10}>
                <Col span={10}>
                    <Card title="Danh sách bãi đỗ xe" bordered={true}>
                        <ListParking search={search} filter={filter} parkings={parkings} setLocation={setLocation} setParking={setParking} />
                    </Card>
                </Col>
                {
                    !open ?
                    <Col span={14} >
                    <Card title={<AutocompleteMap setLocation={setLocation} />} bordered={true}>
                    
                            <GoogleMapComponent location={location} parkings={parkings} />
                </Card>
                        
                           
                        </Col>
                        :
                        <CreateParking open={open} setOpen={setOpen} setParking={setParking} parkings={parkings} />
                }
            </Row>
            
        </Spin>
        
       
    );
}

export default HomePage;
