import React, { useEffect, useState } from 'react'
import { Button, Col, Input, Row } from 'antd';
import { AutocompleteMap } from '../../../../components/GoogleMapComponent';
import { Status } from '../../../../utils/constants';
import UploadImage from '../../../../components/UploadImage'
import { CloseCircleFilled } from '@ant-design/icons';
import { updateParkingByID } from '../../../../services/parkingDetailServices';
const { TextArea } = Input;
export const UpdateParkingInfo = ({setParking, parking, setLoading}) => {
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
            const imagesURLs =  parking.images.length > 0 && parking.images.map(e => {
                return e.url
            })
            imagesURLs.push("https://thumbsnap.com/i/H4US1EmV.jpg")
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
                                    <Col span={8} style={{padding: 5, position: 'relative'}}>
                                        <img src={item} style={{width: 120}} />
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
                            value={updateParking.parkingName}
                            onChange={e => {
                                setupdateParking({
                                    ...updateParking,
                                    parkingName: e.target.value
                                })
                            }}
                        />
                        Address Detail
                        <AutocompleteMap setLocation={setLocation} defaultValue={parking.addressDetail}/>
                        <Row>
                            <Col span={10} >
                                Longitude
                                <Input placeholder='Longitude' style={{margin: "20px 0"}} disabled={true} value={updateParking.lon ? updateParking.lon : parking.lon}/>
                            </Col>
                            <Col span={4}></Col>
                            <Col span={10}>
                                Latitude
                                <Input placeholder='Latitude' style={{margin: "20px 0"}} disabled={true} value={updateParking.lat ? updateParking.lat : parking.lat}/>
                            </Col>
                        </Row>
                        Description
                        <TextArea placeholder='Description' style={{margin: "20px 0"}}
                            value={updateParking.discription}
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
                                _updateParking.imagesURLs = images
                                console.log(_updateParking)
                                updateParkingByID(parking.id, _updateParking, setLoading)
                            }}
                            style={{margin: "20px 0"}}
                        >
                            Submit
                        </Button>
                    </div>
                </Col>
            </Row>
        </div>
    )
}