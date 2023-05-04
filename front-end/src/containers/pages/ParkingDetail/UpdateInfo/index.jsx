import React, { useEffect, useState } from 'react'
import { Button, Col, Input, Row,Image } from 'antd';
import { AutocompleteMap } from '../../../../components/GoogleMapComponent';
import { Status } from '../../../../utils/constants';
import UploadImage from '../../../../components/UploadImage'
import { CloseCircleFilled } from '@ant-design/icons';
import { updateParkingByID } from '../../../../services/parkingDetailServices';
const { TextArea } = Input;
const contentStyle = {
    height: '100px',
    width: '150px',
    objectfit: 'contain',
   borderRadius: '15px',
   border: '1px solid #ddd',
   lineHeight: '160px',
   textAlign: 'center',
   background: '#1e81d2',
};

export const UpdateParkingInfo = ({ parking, parkingImages,setLoading,}) => {
    const [updateParking, setupdateParking] = useState({})
    const [location, setLocation] = useState(null)
    const [images, setImages] = useState([])

    useEffect(()=> {
        if(location) {
            setupdateParking({
                ...updateParking,
                lon: location.location.lng,
                lat: location.location.lat,
                addressDetail: location.address
            })
        }
    }, [location])
    useEffect(() => {
        if(parking) {
            const imagesURLs =  parkingImages.length > 0 && parkingImages.map(e => {
                return e
            })
            
            setImages(imagesURLs)
            setupdateParking({
                ...updateParking,
                lon: parking.lon,
                lat: parking.lat,
                addressDetail: parking.addressDetail,
                parkingName: parking.parkingName,
                discription: parking.discription
            })
        }
    }, [parking])
    useEffect(e=>{
        console.log("images, ", images)
    },[images])
    return(
        <div>
            <Row>
                <Col span={12}>
                    <Row>
                        {
                            images.length > 0 &&
                            images.map((item, index) =>{
                                return (
                                    <Col xs={8} sm={8} xl={8} style={{padding: 5, position: 'relative'}}>
                                        <Image src={item} style={contentStyle} className="ant-col ant-col-xs-12 ant-col-sm-12 ant-col-xl-24" />
                                        <CloseCircleFilled 
                                            style={{
                                                position: 'absolute',
                                                top: '-2px',
                                                left: '-2px',
                                                zIndex: 2,
                                                cursor: 'pointer'
                                            }}
                                            onClick={e => {
                                                const _listImages = images
                                                _listImages.splice(index, 1)
                                                setImages([..._listImages])
                                            }}
                                        />
                                    </Col>
                                )
                            } )
                        }
                    </Row>
                    <UploadImage images={images} setImages={setImages} />
                </Col>
                <Col span={12}>
                    <div style={{padding: 15}}>
                        Parking name
                        <Input placeholder='Parking name' style={{margin: "20px 0"}}
                            value={updateParking?.parkingName}
                            onChange={e => {
                                setupdateParking({
                                    ...updateParking,
                                    parkingName: e.target.value
                                })
                            }}
                        />
                        Address Detail
                        <AutocompleteMap setLocation={setLocation} defaultValue={parking?.addressDetail} disabled={true}/>
                        <Row>
                            <Col span={10} >
                                Longitude
                                <Input placeholder='Longitude' style={{margin: "20px 0"}} disabled={true} value={updateParking?.lon ? updateParking.lon : parking?.lon}/>
                            </Col>
                            <Col span={4}></Col>
                            <Col span={10}>
                                Latitude
                                <Input placeholder='Latitude' style={{margin: "20px 0"}} disabled={true} value={updateParking?.lat ? updateParking.lat : parking?.lat}/>
                            </Col>
                        </Row>
                        Description
                        <TextArea placeholder='Description' style={{margin: "20px 0"}}
                            value={updateParking?.discription}
                            onChange={e => {
                                setupdateParking({
                                    ...updateParking,
                                    discription: e.target.value
                                })
                            }}
                        />
                        <Button type='primary'
                            onClick={e => {
                                const _updateParking = updateParking
                                _updateParking.isLegal = true
                                _updateParking.status = Status.Available
                                _updateParking.lastModifyAt = new Date()
                                _updateParking.imagesURLs = images.length>0 ? images : ['https://thumbsnap.com/i/nJ5ET935.jpg']
                                console.log(_updateParking)
                                updateParkingByID(parking.parkingID, _updateParking, setLoading)
                            }}
                            style={{margin: "20px 0"}}
                        >
                            Lưu
                        </Button>
                    </div>
                </Col>
            </Row>
        </div>
    )
}