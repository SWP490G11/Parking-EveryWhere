import React, { useEffect, useState } from 'react';
import GoogleMapComponent, { AutocompleteMap } from '../../components/GoogleMapComponent';
import { Button, Card, Col, Row, Spin,List,Tag,Input,Drawer,notification,Form } from 'antd';
import { Filter, Search } from '../../components/pages/HomePage';
import {PlusOutlined} from '@ant-design/icons';
//import { useLocationState } from '../../hooks/locationState';
import axios from "axios";
import config from '../../config/config';
import UploadImage from '../../components/UploadImage';
import { useNavigate } from "react-router-dom";
import { ConfirmDelete } from '../../components/pages/HomePage/ConfirmDelete';
// import { useAuthState } from '../../hooks/authState';
const { TextArea } = Input;
function HomePage({role}) {
    const [loading, setLoading] = useState(true);
    const [newParking, setNewParking] = useState({})
    const [images, setImages] = useState([])
    const navigate = useNavigate();
    const [page, setPage] = useState(1);
    const [pageSize, setPageSize] = useState(5);
    //const [locationState] = useLocationState()
    const [search, setSearch] = useState('')
    const [filter, setFilter] = useState({})
    const [open, setOpen] = useState(false)
    const [location, setLocation] = useState(null)
    const [parkings, setParking] = useState([]);
    const loadData = async()=>{
        switch (role) {
            case 'Admin':
              return (await axios.get(`${process.env.REACT_APP_Backend_URI}parkings`));
            case 'ParkingOwner':
              return  (await axios.get(`${process.env.REACT_APP_Backend_URI}parkings-of-owner`));
            case 'Customer':
              return (await axios.get(`${process.env.REACT_APP_Backend_URI}parkings`));
            case 'ParkingManager':
              return (await axios.get(`${process.env.REACT_APP_Backend_URI}parkings`));
            default:
              return (await axios.get(`${process.env.REACT_APP_Backend_URI}parkings`));
          }
    }
    
    useEffect( () => {
        loadData()
          .then(function(response) {
            setParking(response.data);
            setLoading(false);
             }).catch((error) => {
     
            })
    }, [])
    const showDrawer = () => {
        setOpen(true);
      };
      const onClose = () => {
        setOpen(false);
      };
      const finalData =
    search === ""
      ? parkings
      : (parkings.filter(
          (u) =>
            u.parkingName
              .toLowerCase()
              .replace(/\s+/g, "")
              .includes(search.toLowerCase().replace(/\s+/g, "")) ||
            u.addressDetail.toLowerCase().includes(search.toLowerCase())
        ) );
        const onFinish = (values) => {
            axios
              .post(`${process.env.REACT_APP_Backend_URI}parking`, {
                parkingName: values.parkingName,
                addressDetail: values.addressDetail,
                lon: location.location.lng,
                lat: location.location.lat,
                discription: values.discription,
                status: "Available",
                isLegal: true,
                lastModifyAt: new Date(),
              })
              .then(() => {
                // sessionStorage.setItem("changeStatus", true);
                notification.success({
                  message: `Successfully`,
                  description: "Create new parking successfully",
                  placement: "topLeft",
                });
                setOpen(false);
                // window.location.reload(false);
              })
              .catch((error) => {
                notification.warning({
                  message: `Fail`,
                  description: "Please check input again",
                  placement: "topLeft",
                });
              });
          };
      const pagination = {
        current: page,
        PageSize: pageSize,
        total: finalData.length,
        pageSizeOptions: [5, 10, 15, 20],
        className: "ant-btn-dangerous",
        dangerous: true,
        onChange: (page, pageSize) => {
          setPage(page);
          setPageSize(pageSize);
        },
       showSizeChanger:true, 
          showTotal: total => `Total ${total} Student`
      };
   
    return (
        <>
         <Spin spinning={loading} size="large" tip="Loading...">
        
            <div>
                <Row>
                    <Col span={16}>
                    <Input.Search
              placeholder="Tìm bãi đỗ"
              maxLength={255}
              allowClear
              onChange={e => {
                setSearch(e.target.value)
            }}
            //   onSearch={(e) => {
            //     setPage(1);
            //     setSearch(e.replace(/ /g, ""));
            //   }}
            />
                       
                        <Filter setFilter={setFilter} filter={filter} />
                    </Col>
                    <Col span={8} style={{ textAlign: 'right' }}>
                        {
                            role === 'ParkingOwner' && 
                            
                            <Button onClick={()=>{showDrawer()}} type="primary">
                                <PlusOutlined /> Create Parking
                            </Button>
                        }
                    </Col>
            
                </Row>
            </div>
            <Row gutter={10}>
                <Col span={14}>
                    <Card title="Danh sách bãi đỗ xe" bordered={true}>
                    <List
            className="parking-list"
            itemLayout="horizontal"
            pagination={pagination}

            dataSource={finalData}
            renderItem={(item) => (
                <List.Item
                    className='parking-list-item'
                    onClick={e => {
                        const _loation = {
                            address: item.addressDetail,
                            location: {
                                lat: item.lat,
                                lng: item.lon
                            }
                        }
                        setLocation(_loation)
                    }}
                    style={{ cursor: 'pointer' }}
                >
                    <List.Item.Meta
                        avatar={<img style={{ width: 100, height: 100, border: 'solid #1e81d2', borderRadius: '4px' }} src={item.imageUrls[0] ? item.imageUrls[0] : config.DEFAULT_IMG_URL} alt='' />}
                        title={<div>{item.parkingName}</div>}
                        description={<div>
                            <div style={{ marginBottom: '0.25rem' }}>
                                {item.addressDetail}
                            </div>
                            <div>
                                {item.discription}
                            </div>
                        </div>}
                    />
                    <div className='parking-content'>
                        <div className='parking-status'>
                            <div>STATUS</div>
                            <Tag color={item.status === 'Available' ? 'green' : 'volcano'} key={'tag'}>
                                {
                                    item.status === 'Available'
                                        ?
                                        'Available'
                                        :
                                        "Not Available"
                                }
                            </Tag>
                            <div>
                                20/20
                            </div>
                        </div>
                        <div className='parking-button-wapper'>
                            {
                                role === 'ParkingOwner' ?
                                    <>
                                        <Button
                                            type='primary'
                                            style={{ marginBottom: '0.25rem' }}
                                            //onClick={e => navigateTo(toRoute(routes.PARKING_DETAIL_UPDATE, { parkingID: item.parkingID }))}
                                        >
                                            Update
                                        </Button>
                                        <ConfirmDelete setParking={setParking} parkingID={item.parkingID}>
                                            <Button type='primary' danger>
                                                Delete
                                            </Button>
                                        </ConfirmDelete>
                                    </> :
                                    <Button
                                        type='primary'
                                        style={{ marginBottom: '0.25rem' }}
                                        onClick={e => navigate(`/parking/detail/${item.parkingID}`)}
                                    >
                                        Detail
                                    </Button>
                            }
                        </div>
                    </div>
                </List.Item>
            )}
        />
                        {/* <ListParking search={search} filter={filter} parkings={parkings} setLocation={setLocation} setParking={setParking} /> */}
                    </Card>
                </Col>
                 
                     {!open ?  
                        <Col span={10} style={{ margin: 'auto' }}>
                            <AutocompleteMap setLocation={setLocation} />
                            <GoogleMapComponent location={location} parkings={parkings} />
                        </Col>
                         :
                         <Drawer
                         title="Đăng kí bãi đỗ xe"
                        
                         placement='right'
                         onClose={onClose}
                         open={open}
                         width={"30vw"}
                       >
                      <Form onFinish={onFinish} >
                      <Row>
             
                      <Col span={24}>
                                  <div style={{padding: 15}}>
                                  <Form.Item
                            name="parkingName"
                            label="Tên bãi đỗ"
                            rules={[
                              {
                                required: true,
                                message: "Vui lòng nhập tên bãi đỗ",
                              },
                            ]}
                          >
                            <Input placeholder="Vui lòng nhập tên bãi đỗ" />
                          </Form.Item>
                          <Form.Item
                            name="addressDetail"
                            label="Địa chỉ"
                            rules={[
                              {
                                required: true,
                                message: "Vui lòng nhập địa chỉ",
                              },
                            ]}
                          >
                            <AutocompleteMap setLocation={setLocation} />
                           
                          </Form.Item>
                                     
                                      {/* <Row>
                                          <Col span={10} >
                                              Kinh độ
                                              <Input placeholder='Longitude' style={{margin: "20px 0"}} disabled={true} value={newParking.lon ? newParking.lon : ''}/>
                                          </Col>
                                          <Col span={4}></Col>
                                          <Col span={10}>
                                              Vĩ độ
                                              <Input placeholder='Latitude' style={{margin: "20px 0"}} disabled={true} value={newParking.lat ? newParking.lat : ''}/>
                                          </Col>
                                      </Row> */}
                                      <Form.Item
                            name="discription"
                            label="Miêu tả"
                            rules={[
                              {
                                required: true,
                                message: "Vui lòng thông tin miêu tả",
                              },
                            ]}
                          >
                            <Input.TextArea
                              rows={4}
                              placeholder="Vui lòng thông tin miêu tả"
                            />
                          </Form.Item>
                                      
                                  </div>
                              </Col>
                              <Col span={24}>
                                  <div style={{padding: 15}}>
                                      <Row>
                                          {
                                              images.length > 0 &&
                                              images.map(item =>{
                                                  return (
                                                      <Col span={8} style={{padding: 5}}>
                                                          <img src={item} style={{height: 120}} />
                                                      </Col>
                                                  )
                                              } )
                                          }
                                      </Row>
                                      <UploadImage setImages={setImages} images={images}/>
                                  </div>
                              </Col>
                              
                         </Row>
                         <Button onClick={onClose}>Cancel</Button>
                                      <Button htmlType="submit" type='primary'
                                          style={{margin: "20px 0"}}
                                      >
                                          Submit
                                      </Button>
                          <GoogleMapComponent 
                              location={location} 
                              parkings={parkings}
                          />
                           
                           </Form>
                       </Drawer>
                        
                     }
                        
                
            </Row>
            {/* <Drawer title="Đăng ký bãi đỗ" placement="right" onClose={onClose} setOpen={setOpen} open={open} width={"60vw"}>
                         <Form onFinish={onFinish} layout="vertical" hideRequiredMark>
                         <Row>
                              <Col span={12}>
                                  <div style={{padding: 15}}>
                                  <Form.Item
                            name="parkingName"
                            label="Tên bãi đỗ"
                            rules={[
                              {
                                required: true,
                                message: "Vui lòng nhập tên bãi đỗ",
                              },
                            ]}
                          >
                            <Input placeholder="Vui lòng nhập tên bãi đỗ" />
                          </Form.Item>
                          <Form.Item
                            name="addressDetail"
                            label="Địa chỉ"
                            rules={[
                              {
                                required: true,
                                message: "Vui lòng nhập địa chỉ",
                              },
                            ]}
                          >
                            <AutocompleteMap setLocation={setLocation} />
                           
                          </Form.Item>
                                     
                                      <Row>
                                          <Col span={10} >
                                              Kinh độ
                                              <Input placeholder='Longitude' style={{margin: "20px 0"}} disabled={true} value={newParking.lon ? newParking.lon : ''}/>
                                          </Col>
                                          <Col span={4}></Col>
                                          <Col span={10}>
                                              Vĩ độ
                                              <Input placeholder='Latitude' style={{margin: "20px 0"}} disabled={true} value={newParking.lat ? newParking.lat : ''}/>
                                          </Col>
                                      </Row>
                                      <Form.Item
                            name="discription"
                            label="Miêu tả"
                            rules={[
                              {
                                required: true,
                                message: "Vui lòng thông tin miêu tả",
                              },
                            ]}
                          >
                            <Input.TextArea
                              rows={4}
                              placeholder="Vui lòng thông tin miêu tả"
                            />
                          </Form.Item>
                                       <Button onClick={onClose}>Cancel</Button>
                                      <Button htmlType="submit" type='primary'
                                          style={{margin: "20px 0"}}
                                      >
                                          Submit
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
                                                          <img src={item} style={{height: 120}} />
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
                          />
                           </Form>
                      </Drawer> */}
               
         </Spin>
        </>
    );
}

export default HomePage;
