import React, { useState, useEffect } from "react";
import { Table, Input, Button, Menu,List,Divider, Dropdown, Row, Col, Modal,Form,notification,Collapse,Tag,Space } from "antd";
import {
  FilterOutlined,SearchOutlined,
} from "@ant-design/icons";

import api from "../../services/api";

import { useAuthState } from '../../hooks/authState';
const { Panel } = Collapse;
 const ManageSlot=()=> {
    const [carModal, setCarModal] = useState(false);
const [addSlot,setAddSlot]= useState(false)
const [searchCar, setSearchCar] = useState("");
    const [slotParking,setSlotParking] =useState([]);
    const [slotParking1,setSlotParking1] =useState([]);
    const [form] = Form.useForm();
    const [formz] = Form.useForm();
    const [car,setCar]=useState([]);
    const [page1, setPage1] = useState(1);
    const [pageSize1, setPageSize1] = useState(5);
    const [page2, setPage2] = useState(1);
    const [pageSize2, setPageSize2] = useState(5);
    const [type,setType]= useState("Tất cả");
  const [type1,setType1]= useState("Tất cả");
    const [status,setStatus]= useState("All");
    const [slotID,setSlotID] =useState("");
    const [carID,setCarID]=useState("");
    const [page, setPage] = useState(1);
    const [authState] = useAuthState();
    const parkingID = localStorage.getItem('parkingID') ? localStorage.getItem('parkingID') : '';
    const [pageSize, setPageSize] = useState(10);
    const carColumns = [
        {
            title: "Biển số xe",
            dataIndex: "carNumber",
            key: "carNumber",
            sorter: (a, b) => {
                if (a.carNumber > b.carNumber) {
                    return -1;
                }
                if (b.carNumber > a.carNumber) {
                    return 1;
                }
                return 0;
            },
           
        },
      
        {
            title: "Loại xe",
            dataIndex: "carmodel",
            key: "carmodel",
            sorter: (a, b) => {
                if (a.carmodel > b.carmodel) {
                    return -1;
                }
                if (b.carmodel > a.carmodel) {
                    return 1;
                }
                return 0;
            },
           
        },
        {
          title: "Thông tin xe",
          dataIndex: "description",
          key: "description",
          sorter: (a, b) => {
              if (a.description > b.description) {
                  return -1;
              }
              if (b.description > a.description) {
                  return 1;
              }
              return 0;
          },
         
      },
      
      ];
      const handleAddCar = (fieldsValue) => {
        api.post(`parkingdetail`, {
          carID: carID,
          note: fieldsValue.note,
          slotID: slotID,
      parkingDate: new Date(),
     
      lastModifyAt: new Date(),
        })
            .then(() => {
                window.location.reload();
            })
            .catch((err) => {
    
            });
    };
    useEffect(() => {
        api.get(`cars-available`)
        .then(function(response){
          let respData = response.data;
          respData.forEach((element) => {element.carmodel =element.carModel.model; element.description = element.carModel.discript})
          setCar( respData.sort((a, b) => {
            if (
              a.carNumber.trim().toLowerCase() >
              b.carNumber.trim().toLowerCase()
            ) {
              return 1;
            }
            if (
              b.carNumber.trim().toLowerCase() >
              a.carNumber.trim().toLowerCase()
            ) {
              return -1;
            }
            return 0;
          }));},[]).catch((e)=>{notification.warning({
            message: `Lỗi dữ liệu`,
            description: "Tải dữ liệu bị lỗi",
            placement: "topLeft",
          });});
    }, [])
    useEffect(() => {
      api.get(`slots-Roof/${parkingID}`)
      .then((response) =>{
        setSlotParking(response.data.sort((a, b) => {
          if (
            a.status.trim().toLowerCase() >
            b.status.trim().toLowerCase() && a.price > b.price
          ) {
            return 1;
          }
          if (
            b.status.trim().toLowerCase() >
            a.status.trim().toLowerCase() && b.price > a.price
          ) {
            return -1;
          }
          return 0;
        }))})
      .catch((e)=>{notification.warning({
        message: `Lỗi dữ liệu`,
      description: "Tải dữ liệu bị lỗi",
    placement: "topLeft",
     });});
     api.get(`slots-nonRoof/${parkingID}`)
     .then((response) =>{
       setSlotParking1(response.data.sort((a, b) => {
         if (
           a.status.trim().toLowerCase() >
           b.status.trim().toLowerCase() && a.price > b.price
         ) {
           return 1;
         }
         if (
           b.status.trim().toLowerCase() >
           a.status.trim().toLowerCase() && b.price > a.price
         ) {
           return -1;
         }
         return 0;
       }))})
     .catch((e)=>{notification.warning({
       message: `Lỗi dữ liệu`,
     description: "Tải dữ liệu bị lỗi",
   placement: "topLeft",
    });});
    }, [parkingID])
    const dataType =
    type === 'Tất cả' ? slotParking : slotParking.filter((u) => u.status === type);     
    const finalSlot = status === 'All' ? slotParking : slotParking.filter((u)=>u.status === status);
        const finalCar =
        searchCar === ""? car : (car.filter((u) =>
        u.carNumber
        .toLowerCase()
        .replace(/\s+/g, "")
        .includes(searchCar.toLowerCase().replace(/\s+/g, "")) 
                  // || u.id.toLowerCase().includes(searchText.toLowerCase())
            ) 
            );
            const dataType1 =
            type1 === 'Tất cả' ? slotParking1 : slotParking1.filter((u) => u.status === type1);
            const paginationSlot = {
              current: page1,
              pageSize: pageSize1,
              total: dataType.length,
              pageSizeOptions: [5, 10, 15],
              className: "ant-btn-dangerous",
              dangerous: true,
              onChange: (page1, pageSize1) => {
                setPage1(page1);
                setPageSize1(pageSize1);
              },
             showSizeChanger:true, 
                showTotal: total => `Tổng ${total} chỗ dỗ`
            }; 
            const paginationSlot1 = {
              current: page2,
              pageSize: pageSize2,
              total: dataType1.length,
              pageSizeOptions: [5, 10, 15],
              className: "ant-btn-dangerous",
              dangerous: true,
              onChange: (page2, pageSize2) => {
                setPage2(page2);
                setPageSize2(pageSize2);
              },
             showSizeChanger:true, 
                showTotal: total => `Tổng ${total} chỗ dỗ`
            }; 
            const pagination = {
                current: page,
                PageSize: pageSize,
                total: finalCar.length,
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
              const renderType = () => {
                switch(type) {
                    case 'Available':
                      return 'Còn chỗ'
                    case 'NotAvailable':
                      return 'Đã có xe'
                    default:
                      return 'Tất cả'
                  }
              };
              const renderType1 = () => {
                switch(type1) {
                    case 'Available':
                      return 'Còn chỗ'
                    case 'NotAvailable':
                      return 'Đã có xe'
                    default:
                      return 'Tất cả'
                  }
              };
      
    return(
        <>
        
         
        <Divider orientation="left"><p style={{color:'red',fontWeight: "bold" }}>Có mái che</p></Divider>
        
        <Form.Item label={'Trạng thái'}>
          <Dropdown.Button
          placement="bottom"
          icon={<FilterOutlined />}
          overlay={
            <Menu>
              <Menu.Item
               
                onClick={() => {
                  setType('Available');
                }}
              >
                {" "}
                Còn trống
              </Menu.Item>
             
              <Menu.Item
                value="Female"
                onClick={() => {
                  setType('NotAvailable');
                }}
              >
                {" "}
                Đã có xe
              </Menu.Item>
             
              <Menu.Item
                onClick={() => {
                  setType("Tất cả");
                }}
              >
                {" "}
                Tất cả
              </Menu.Item>
            </Menu>
          }
        > 
        {renderType()}
          
        </Dropdown.Button>
          </Form.Item>
          <List dataSource={dataType} pagination={paginationSlot}
          renderItem={(e) => (
            <Collapse  >
                <Panel icon={e.status}  
                header={ <>
                <Row>
                  <Col span={8}>Loại: {e.typeOfSlot==='ROOFED' ? 'Có mái che': 'Không có mái che'}</Col>
                 
                  <Col span={8}>
                {e.status === 'Available' ? <Tag color={'green'} >Còn trống</Tag>: <Tag color={'red'} >Đã có xe</Tag>}
              </Col>
              <Col span={8}><Tag color={'geekblue'} >
                Giá {e.price}
              </Tag></Col>
                </Row>
               
                </>}>
          <p>
            {e.status !== 'Available' ?  
          // <Button onClick={u=>{setSlotID(e.parkingDetail[0].id);console.log(e.slotID)}}>Thanh Toán</Button> 
          <>Xe mang biển số: {e.parkingDetail[e?.parkingDetail?.length -1].car?.carNumber}</>
          :
          <Button onClick={u=>{setAddSlot(true);setSlotID(e.id);console.log(e.id)}}>Thêm xe</Button>}
          </p>
        </Panel>
           
       
      </Collapse> 
          )}/>
       
       <Divider orientation="left"><p style={{color:'red',fontWeight: "bold" }}>Không có mái che</p></Divider>
     
        <Form.Item label={'Trạng thái'}>
          <Dropdown.Button
          placement="bottom"
          icon={<FilterOutlined />}
          overlay={
            <Menu>
              <Menu.Item
               
                onClick={() => {
                  setType1('Available');
                }}
              >
                {" "}
                Còn trống
              </Menu.Item>
             
              <Menu.Item
                value="Female"
                onClick={() => {
                  setType1('NotAvailable');
                }}
              >
                {" "}
                Đã có xe
              </Menu.Item>
             
              <Menu.Item
                onClick={() => {
                  setType1("Tất cả");
                }}
              >
                {" "}
                Tất cả
              </Menu.Item>
            </Menu>
          }
        > 
        {renderType1()}
          
        </Dropdown.Button>
          </Form.Item>
          <List dataSource={dataType1} pagination={paginationSlot1}
          renderItem={(e) => (
            <Collapse  >
                <Panel icon={e.status}  
                header={ <>
                <Row>
                  <Col span={8}>Loại: {e.typeOfSlot==='ROOFED' ? 'Có mái che': 'Không có mái che'}</Col>
                 
                  <Col span={8}>
                {e.status === 'Available' ? <Tag color={'green'} >Còn trống</Tag>: <Tag color={'red'} >Đã có xe</Tag>}
              </Col>
              <Col span={8}><Tag color={'geekblue'} >
                Giá {e.price}
              </Tag></Col>
                </Row>
               
                </>}>
          <p>
            {e.status !== 'Available' ?  
          // <Button onClick={u=>{setSlotID(e.parkingDetail[0].id);console.log(e.slotID)}}>Thanh Toán</Button> 
          <>Xe mang biển số: {e.parkingDetail[e?.parkingDetail?.length -1].car?.carNumber}</>
          :
          <Button onClick={u=>{setAddSlot(true);setSlotID(e.id);console.log(e.id)}}>Thêm xe</Button>}
          </p>
        </Panel>
           
       
      </Collapse> 
          )}/>
     {/*Thêm xe*/}
     <Modal
        title="Thêm xe vào bãi đỗ"
        open={addSlot}
        onCancel={()=>{setAddSlot(false); form.setFieldsValue({
          carID: "",
  carNumber: "",
  note: "",
 })}}
       
        footer={null}
        width={550}
      >
          <Form
                            name="complex-form"
                            layout="horizontal"
                            onFinish={handleAddCar}
                            labelAlign="left"
                            form={formz}
                        >
                            <Form.Item label="Biển số xe" style={{marginBottom: 0}}>
                                <Form.Item
                                    name="carNumber"
                                  
                                    style={{display: "block"}}
                                    hasFeedback
                                >

                                    <Input
                                        readOnly
                                        
                                        className="inputForm"
                                        maxLength={51}
                                      
                                        suffix={<span onClick={() => {
                                          setCarModal(true)
                                        }
                                        }><SearchOutlined/></span>}
                                        onClick={() => {
                                          setCarModal(true)
                                        }}
                                    >

                                    </Input>

                                </Form.Item>
            
                                </Form.Item>
          
          <Form.Item
            name="note"
            label="Thông tin"
            rules={[
              {
                required: true,
                message: "Vui lòng nhập dữ liệu!",
                whitespace: true,
              },
            ]}
            hasFeedback
          >
            <Input.TextArea  />
          </Form.Item>
           
          <Space>
              <Button onClick={()=>{setAddSlot(false); form.setFieldsValue({
                    carID: "",
                 carNumber: "",
                note: "",})} }>Hủy</Button>
              <Button htmlType="submit" type="primary">
                Lưu
              </Button>
              </Space>
        
          
        </Form>
      </Modal>
      {/*Chọn xe */}
      <Modal
        title="Chọn xe"
        open={carModal}
        footer={null}
        onCancel={()=>setCarModal(false)}
      > <Input.Search
      placeholder="Search User"
      maxLength={255}
      allowClear
      onSearch={(e) => {
        setPage(1);
        setSearchCar(e.replace(/ /g, ""));
      }}
    />
        
        <Table
             rowSelection={{
              type:'radio',
              
              onChange:(selectedRowKeys, selectedRows) => {
                setCarID(selectedRows[0].id);
                formz.setFieldsValue({
                  carNumber: selectedRows[0].carNumber ,
                })
                
                
              }}}
                    columns={carColumns}
                    dataSource={finalCar.filter(u=>u.status==='Available')}
                    rowKey="id"
                    pagination={pagination}
                    on
                />
      </Modal>
    
        </>
    )
 }
 export default ManageSlot;