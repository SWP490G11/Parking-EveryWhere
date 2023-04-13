import React, { useEffect, useState } from 'react'
import { Button, Col, Drawer, Input, Row,Image } from 'antd';
import GoogleMapComponent, { AutocompleteMap } from '../../../components/GoogleMapComponent';
import { Status } from '../../../utils/constants';
import UploadImage from '../../../components/UploadImage';
import { ParkingService } from '../../../services/parkingServices';

const { TextArea } = Input;
export const CreateParking = ({open, setOpen, setParking, parkings = []}) => {
    const [newParking, setNewParking] = useState({})
    const [location, setLocation] = useState(null)
    const [images, setImages] = useState([])
    useEffect(()=> {
        if(location) {
            setNewParking({
                ...newParking,
                lon: location.location.lng,
                lat: location.location.lat,
                addressDetail: location.address
            })
        }
    }, [location])
    const onClose = () => {
        setOpen(false);
    };
 
    return(
        <div>
            <Drawer title="Create Parking Car" placement="right" onClose={onClose} open={open} width={"70vw"}>
               <Row>
                    <Col span={12}>
                        <div style={{padding: 15}}>
                            Parking name
                            <Input placeholder='Parking name' style={{margin: "20px 0"}}
                                onChange={e => {
                                    setNewParking({
                                        ...newParking,
                                        parkingName: e.target.value
                                    })
                                }}
                            />
                            Address Detail
                            <AutocompleteMap setLocation={setLocation} />
                            <Row>
                                <Col span={10} >
                                    Longitude
                                    <Input placeholder='Longitude' style={{margin: "20px 0"}} disabled={true} value={newParking?.lon ? newParking.lon : ''}/>
                                </Col>
                                <Col span={4}></Col>
                                <Col span={10}>
                                    Latitude
                                    <Input placeholder='Latitude' style={{margin: "20px 0"}} disabled={true} value={newParking?.lat ? newParking.lat : ''}/>
                                </Col>
                            </Row>
                            Description
                            <TextArea placeholder='Description' style={{margin: "20px 0"}}
                                onChange={e => {
                                    setNewParking({
                                        ...newParking,
                                        discription: e.target.value
                                    })
                                }}
                            />
                            <Button type='primary'
                                onClick={e => {
                                    const _newParking = newParking
                                    _newParking.isLegal = true
                                    _newParking.status = Status.Available
                                    _newParking.lastModifyAt = new Date()
                                    _newParking.imagesURLs = images.length>0 ? images : ['https://thumbsnap.com/i/nJ5ET935.jpg']
                                    console.log(_newParking)
                                    ParkingService.createParking(_newParking, setParking);
                                    onClose();
                                }}
                                style={{margin: "20px 0"}}
                            >
                                Thêm bãi đỗ
                            </Button>
                        </div>
                    </Col>
                    <Col span={12}>
                        <div style={{padding: 15}}>
                            <Row>
                                {
                                    images.length > 0 &&
                                    images.map(item =>{
                                        return (
                                            <Col span={8} style={{padding: 5}}>
                                                <Image src={item} style={{height: 120}} />
                                            </Col>
                                        )
                                    } )
                                }
                            </Row>
                            <UploadImage setImages={setImages} images={images}/>
                        </div>
                    </Col>
               </Row>
                <GoogleMapComponent 
                    location={location} 
                    parkings={parkings}
                  
                >
                
                </GoogleMapComponent>
            </Drawer>
        </div>
    )
}