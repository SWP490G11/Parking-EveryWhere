import React, { useEffect, useState } from 'react'
import { Button, Col, Drawer, Input, Row,Image ,Form} from 'antd';
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
        
            <Drawer title="Tạo bãi đỗ mới" placement="right" onClose={onClose} open={open} width={"70vw"}>
               <Row>
                    <Col span={12}>
                    <Form.Item
            name="typeOfSlot"
            
            rules={[
              {
                required: true,
                message: "Vui lòng loại chỗ",
              },
            ]}
          > <div style={{paddingBottom: 5}}> Tên bãi đỗ</div>
            <Input placeholder='Tên bãi đỗ' 
                                onChange={e => {
                                    setNewParking({
                                        ...newParking,
                                        parkingName: e.target.value
                                    })
                                }}
                            />
                            </Form.Item>
                            <Form.Item
            name="typeOfSlot"
            
            rules={[
              {
                required: true,
                message: "Vui lòng loại chỗ",
              },
            ]}
          ><div style={{paddingBottom: 5}}> Địa chỉ</div>
            <AutocompleteMap setLocation={setLocation} />
                            </Form.Item>
                       
                           
                           
                            <Row>
                                <Col span={10} >
                                <Form.Item
            name="typeOfSlot"
            
            rules={[
              {
                required: true,
                message: "Vui lòng loại chỗ",
              },
            ]}
          > <div style={{paddingBottom: 5}}> Kinh độ</div>
            <Input disabled={true} value={newParking?.lon ? newParking.lon : ''}/>
                            </Form.Item>
                            </Col>
                            <Col span={4}></Col>
                            <Col span={10} >
                                <Form.Item
            name="typeOfSlot"
            
            rules={[
              {
                required: true,
                message: "Vui lòng loại chỗ",
              },
            ]}
          > <div style={{paddingBottom: 5}}> Vĩ độ</div>
            <Input   disabled={true} value={newParking?.lat ? newParking.lat : ''}/>
                            </Form.Item>
                                   
                                    
                              
                                    
                                </Col>
                                
                               
                            </Row>
                            
                                <Form.Item
            name="typeOfSlot"
            
            rules={[
              {
                required: true,
                message: "Vui lòng loại chỗ",
              },
            ]}
          > <div style={{paddingBottom: 5}}> Thông tin</div>
           <TextArea placeholder='Thông tin bãi đỗ' style={{margin: "20px 0"}}
                                onChange={e => {
                                    setNewParking({
                                        ...newParking,
                                        discription: e.target.value
                                    })
                                }}
                            />
                            </Form.Item>
                            
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
                                
                            >
                                Thêm bãi đỗ
                            </Button>
                       
                    </Col>
                   
                    <Col span={12}>
                        <div style={{padding: 10}}>
                            <Row>
                                {
                                    images.length > 0 &&
                                    images.map(item =>{
                                        return (
                                            <Col span={8}>
                                                <Image src={item} />
                                            </Col>
                                        )
                                    } )
                                }
                            </Row>
                            <br/>
                            <UploadImage setImages={setImages} images={images}/>
                        </div>
                    </Col>
               </Row>
               <br/>
               <Row>
                <GoogleMapComponent 
                    location={location} 
                    parkings={parkings}
                  
                >
                
                </GoogleMapComponent>
                </Row>
            </Drawer>
       
    )
}