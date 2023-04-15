import React, { useState, useEffect } from "react";
import { Table, Input, Button, Menu, Dropdown, Row, Col, Modal,Empty,Drawer,Form,Radio,Space,notification,Collapse,InputNumber,Tag } from "antd";
import {
  FilterOutlined,
  EditFilled,
  CloseSquareOutlined,PlusOutlined,UnorderedListOutlined,SearchOutlined
} from "@ant-design/icons";
import { useNavigate } from "react-router-dom";
import { toRoute } from '../../utils/helpers';
import api from "../../services/api";
import { routes } from '../../utils/routes';
import { useAuthState } from '../../hooks/authState';
const { Panel } = Collapse;
export default function ManageParking() {
  const [form] = Form.useForm();
  const [formz] = Form.useForm();
  const [data, setData] = useState([]);
  const navigateTo = useNavigate();
  const [searchText, setSearchText] = useState("");
  const [page, setPage] = useState(1);
  const [open, setOpen] = useState(false);
  const [pageSize, setPageSize] = useState(10);
  const [status,setStatus]= useState("Status");
  const [modal, setModal] = useState({
    isOpen: false,
    data: {},
  });
  
  const [authState] = useAuthState();
  const [slotID,setSlotID] =useState("")
  const [parkingID,setParkingID] = useState("");
  const [parkingName,setParkingName] = useState("");
  const [car,setCar]=useState([]);
  const [carID,setCarID]=useState("")
  const columns = [
    {
        title: "Tên bãi đỗ",
        dataIndex: "parkingName",
        key: "parkingName",
        sorter: (a, b) => {
            if (a.parkingName > b.parkingName) {
                return -1;
            }
            if (b.parkingName > a.parkingName) {
                return 1;
            }
            return 0;
        },
        width:"10%",
    },

    {
        title: "Địa chỉ",
        dataIndex: "addressDetail",
        key: "addressDetail",
        sorter: (a, b) => {
            if (a.addressDetail > b.addressDetail) {
                return -1;
            }
            if (b.addressDetail > a.addressDetail) {
                return 1;
            }
            return 0;
        },
        width:"20%",
    },
    
    {
        title: "Thông tin thêm",
        dataIndex: "discription",
        key: "discription",
        sorter: (a, b) => {
            if (a.discription > b.discription) {
                return -1;
            }
            if (b.discription > a.discription) {
                return 1;
            }
            return 0;
        },
          width:"40%",
    },
    {
        title: "Trạng thái",
        dataIndex: "status",
        key: "status",
        sorter: (a, b) => {
            if (a.status > b.status) {
                return -1;
            }
            if (b.status > a.status) {
                return 1;
            }
            return 0;
        },
        width:"10%",
    },
    {
        title: "Hành động",
        dataIndex: "action",
        key: "action",
        width:"15%",
    },
];
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
  const onFinish = (values) => {
    
    api
      .post(`slot?quantity=${values.quantity}`, {
        status: "Available",
        typeOfSlot: values.typeOfSlot,
          discription: values.discription,
          price: values.price,
          parkingID: parkingID,
        carModelID: values.carModelID,
          lastModifyByID: authState?.data?.id,
      })
      .then(() => {
        // sessionStorage.setItem("changeStatus", true);
        notification.success({
          message: `Thành công`,
          description: "Thêm nhân viên quản lý thành công",
          placement: "topLeft",
        });
        form.setFieldsValue({
          typeOfSlot: "",
          discription: "",
          price: "",
         
        carModelID: "",
          
            
          })
        setOpen(false);
       // window.location.reload();
      })
      .catch((error) => {
        notification.warning({
          message: `Thất bại`,
          description: "Vui lòng thử lại",
          placement: "topLeft",
        });
        form.setFieldsValue({
          typeOfSlot: "",
          discription: "",
          price: "",
         
        carModelID: "",
          })
      });
  };
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
  const [deleteModal, setDeleteModal] = useState({
    isOpen: false,
    title: "Notice",
    content: <p>Do you want to disable student?</p>,
    footer: (
      <div style={{ textAlign: "left" }}>
        <Button className="buttonSave">Disable</Button>
       
      </div>
    ),
  });
  const [searchCar, setSearchCar] = useState("");
  const[open1,setOpen1]=useState(false)

  const onClosez = () => {
    setOpen1(false);
  };
  const onClose = () => {
        setOpen(false);
    };
    const loadSlotParking=(values)=>{
      console.log(values);
      api.get(`slots/${values}`)
        .then((response) =>{
          setSlotParking(response.data)})
          .catch((e)=>{notification.warning({
          message: `Lỗi dữ liệu`,
          description: "Tải dữ liệu bị lỗi",
          placement: "topLeft",
        });});
    }
  useEffect(() => {
    api.get(`parkings-of-owner`)
      .then(function (response) {
        let respData = response.data;
      
        respData.forEach((element) => {
       
          element.status = element.status ==='Available' ? "Khả dụng" : ( element.status === 'Pending' ? 'Chờ duyệt' : 'Từ chối' )
          element.action = [
             <Button className='buttonState'
             onClick={e => navigateTo(toRoute(routes.PARKING_DETAIL_UPDATE, { parkingID: element.parkingID }))}
                        >
                        <EditFilled/>
                </Button>,
                <Button  onClick={e => {setOpen(true);setParkingID(element.parkingID);setParkingName(element.parkingName);
                
                }}><PlusOutlined /></Button>,
                <Button  onClick={e => {setOpen1(true);loadSlotParking(element.parkingID);setParkingName(element.parkingName);
                
                }}><UnorderedListOutlined /></Button>,
          ];
          
        });
        setData(
          respData.sort((a, b) => {
            if (
              a.parkingName.trim().toLowerCase() >
              b.parkingName.trim().toLowerCase()
            ) {
              return 1;
            }
            if (
              b.parkingName.trim().toLowerCase() >
              a.parkingName.trim().toLowerCase()
            ) {
              return -1;
            }
            return 0;
          })
        );
      }, [])
      .catch(() => {});
  }, [data]);
  useEffect(() => {
    api.get(`cars`)
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

const [slotParking,setSlotParking] =useState([]);
const [carModal, setCarModal] = useState(false);
const [addSlot,setAddSlot]= useState(false)
  const dataBystatus =
  status === "Status" ? data : data.filter((u) => u.status === status);
  const finalData =
    searchText === ""? dataBystatus : (dataBystatus.filter((u) =>
    u.parkingName
    .toLowerCase()
    .replace(/\s+/g, "")
    .includes(searchText.toLowerCase().replace(/\s+/g, "")) 
              // || u.id.toLowerCase().includes(searchText.toLowerCase())
        ) 
        );
      
  const finalCar =
        searchCar === ""? car : (car.filter((u) =>
        u.carNumber
        .toLowerCase()
        .replace(/\s+/g, "")
        .includes(searchCar.toLowerCase().replace(/\s+/g, "")) 
                  // || u.id.toLowerCase().includes(searchText.toLowerCase())
            ) 
            );
            // const [selectedRowKeys, setSelectedRowKeys] = useState([]);
 
  
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
  const renderContent = () => {
    switch(status) {
        case 'Status':
          return 'Tất cả'
        case 'Available':
          return 'Khả dụng'
        case 'Pending':
          return 'Chờ duyệt'
        case 'Cancel':
          return 'Từ chối'
        default:
          return 'Tất cả'
      }
  };
  return (
    <>
      <p
        style={{
          display: "block",
          fontSize: "20px",
          margin: "0 auto",
          textAlign: "left",
          color: " red",
          fontWeight: "bold",
          paddingBottom: "20px",
        }}
      >
        Manage Parking
      </p>
      <Row gutter={45} style={{ marginBottom: "30px" }}>
      <Col xs={8} sm={8} md={7} lg={7} xl={6} xxl={5}>
            {/*Filter Gender */}
            <Form.Item label={'Trạng thái'}>
            <Dropdown.Button
            placement="bottom"
            icon={<FilterOutlined />}
            overlay={
              <Menu>
                <Menu.Item
                  value="Male"
                  onClick={() => {
                    setStatus("Chờ duyệt");
                  }}
                >
                  {" "}
                  Chờ duyệt
                </Menu.Item>
                <Menu.Item
                  value="Female"
                  onClick={() => {
                    setStatus("Từ chối");
                  }}
                >
                  {" "}
                  Từ chối
                </Menu.Item>
                <Menu.Item
                  value="Female"
                  onClick={() => {
                    setStatus("Khả dụng");
                  }}
                >
                  {" "}
                  Khả dụng
                </Menu.Item>
               
                <Menu.Item
                  onClick={() => {
                    setStatus("Status");
                  }}
                >
                  {" "}
                  Tất cả
                </Menu.Item>
              </Menu>
            }
          > 
          {renderContent()}
            
          </Dropdown.Button>
            </Form.Item>
        
          </Col>
        <Col xs={8} sm={8} md={7} lg={7} xl={8} xxl={8}>
          <Input.Search
            placeholder="Search User"
            maxLength={255}
            allowClear
            onSearch={(e) => {
              setPage(1);
              setSearchText(e.replace(/ /g, ""));
            }}
          />
        </Col>
       
      </Row>
      {/* Delete Modal */}
      <Modal
        open={deleteModal.isOpen}
        title={deleteModal.title}
        footer={deleteModal.footer}
        onCancel={() => {
          setDeleteModal({ ...deleteModal, isOpen: false });
        }}
        destroyOnClose={true}
        closeIcon={
          <CloseSquareOutlined style={{ color: "red", fontSize: "20px" }} />
        }
      >
        {deleteModal.content}
      </Modal>
      <Modal
                visible={modal.isOpen}
                title='Thông tin bãi đỗ'
                onCancel={()=>{setModal({...modal,isOpen:false})}}
                // closeIcon={<CloseSquareOutlined style={{color: "red", fontSize: "20px"}}/>}
                footer={
                    null
                }
            >
                <table>
                    <tr>
                        <td style={{fontSize: '18px', color: '#838688'}}>Tên Bãi Đỗ</td>
                        <td style={{
                            fontSize: '18px',
                            color: '#838688',
                            textAlign: 'justify',
                            paddingLeft: '35px'
                        }}>{modal.data.parkingName}</td>
                    </tr>
                    
                    <tr>
                        <td style={{fontSize: '18px', color: '#838688'}}>Địa chỉ</td>
                        <td style={{
                            fontSize: '18px',
                            color: '#838688',
                            textAlign: 'justify',
                            paddingLeft: '35px'
                        }}>{modal.data.addressDetail}</td>
                    </tr>
                    <tr>
                        <td style={{fontSize: '18px', color: '#838688'}}>Thông tin thêm</td>
                        <td style={{
                            fontSize: '18px',
                            color: '#838688',
                            textAlign: 'justify',
                            paddingLeft: '35px'
                        }}>{modal.data.description}</td>
                    </tr>
                    <tr>
                        <td style={{fontSize: '18px', color: '#838688'}}> Tọa độ</td>
                        <td style={{
                            fontSize: '18px',
                            color: '#838688',
                            textAlign: 'justify',
                            paddingLeft: '35px'
                        }}>{modal.data.latitude} - {modal.data.longitude}</td>
                    </tr>

                    <tr>

                        <td style={{fontSize: '18px', color: '#838688'}}>Trạng thái</td>
                        <td style={{
                            fontSize: '18px',
                            color: '#838688',
                            textAlign: 'justify',
                            paddingLeft: '35px'
                        }}>{modal.data.status}</td>
                    </tr>
                    <tr>
                        <td style={{fontSize: '18px', color: '#838688'}}>Hợp pháp</td>
                        <td style={{
                            fontSize: '18px',
                            color: '#838688',
                            textAlign: 'justify',
                            paddingLeft: '35px'
                        }}>{
                        modal.data.isLegal ===true ? (<>Hợp pháp</>): (<>Không hợp pháp</>)
                        }</td>
                    </tr>
                </table>


      </Modal>

      {finalData.length === 0 ? (
        <Empty description={"Không có dữ liệu"}/>
      ) : (
        <Table
          // key="id"
          rowKey={(data) => data.parkingID}
          columns={columns}
          pagination={pagination}
          dataSource={finalData}
          onRow={(record) => {
            return {
              onClick: (e) => {
               
                if (
                  e.target.className ===
                  "ant-table-cell ant-table-cell-row-hover"
                ) {
                  setModal({
                    ...modal,
                    isOpen: true,
                    data: {
                      parkingName: record.parkingName,
                      addressDetail: record.addressDetail,
                      description: record.discription,
                      latitude: record.lat,
                      longitude: record.lon,
                      image: record.imageUrls,
                      status: record.status,
                      isLegal: record.isLegal,
                    },
                  });
                  
                } else if (
                  e.target.className ===
                  "ant-table-cell ant-table-column-sort ant-table-cell-row-hover"
                ) {
                  setModal({
                    ...modal,
                    isOpen: true,
                    data: {
                      parkingName: record.parkingName,
                      addressDetail: record.addressDetail,
                      description: record.discription,
                      latitude: record.lat,
                      longitude: record.lon,
                      image: record.imageUrls,
                      status: record.status,
                      isLegal: record.isLegal,
                    },
                  });
                  console.log(modal.data);
                } else {
                  setModal({ ...modal, isOpen: false });
                }
              },
            };
          }}
        />
      )}
      {/*Thêm slot*/}
       <Drawer
          title={`Thêm chỗ cho bãi đỗ ${parkingName}`}
          width={550}
          onClose={onClose}
          open={open}
          bodyStyle={{
            paddingBottom: 80,
          }}
        >
          <Form form={form} onFinish={onFinish} layout="vertical" hideRequiredMark>
          
          <Form.Item
            name="typeOfSlot"
            label="Loại chỗ"
            rules={[
              {
                required: true,
                message: "Vui lòng loại chỗ",
              },
            ]}
          >
            <Radio.Group>
              <Radio value={0}>Có mái che</Radio>
              <Radio value={1}>Không có mái che</Radio>
              
            </Radio.Group>
          </Form.Item>
          <Row>
            <Col span={10}>
            <Form.Item
            name="quantity"
            label="Số lượng chỗ"
            rules={[
              {
                required: true,
                pattern: new RegExp("^[0-9]+$"),
                message: "Vui lòng số lượng chỗ",
                
              },
            ]}
          
          >
           <InputNumber min={1} max={50} defaultValue={0}  />
          </Form.Item>
            </Col>
            <Col span={14}>
            <Form.Item
            name="price"
            label="Giá"
            rules={[
              {
                required: true,
               
                message: "Vui lòng giá chỗ đỗ!",
                
              },
            ]}
          
          >
            <InputNumber
      defaultValue={0}
      formatter={(value) => `${value}`.replace(/\B(?=(\d{3})+(?!\d))/g, ',')}
      parser={(value) => value.replace(/\$\s?|(,*)/g, '')}
      addonAfter="$"
    
    />
          </Form.Item>
            </Col>
          </Row>
         
         
         
         
         
          
          <Form.Item
            name="discription"
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
            <Input.TextArea />
          </Form.Item>
          <Space>
              <Button onClick={()=>{
                onClose();
                form.setFieldsValue({
                  typeOfSlot: "",
          discription: "",
          price: "",
         
            
                    })
                } }>Hủy</Button>
              <Button htmlType="submit" type="primary">
                Lưu
              </Button>
              </Space>
           
        
          
        </Form>
        </Drawer>
        {/* Danh sách slot*/}
        <Drawer
        title={`Danh sách chỗ đỗ của bãi ${parkingName}`}
        placement="right"
        size={"large"}
        onClose={onClosez}
        open={open1}
        closable={true}
      >
          <Collapse  >{
            slotParking.map((e,index)=>(
              <Panel icon={e.status}  
              header={ <>
              <Row>
                <Col span={8}>Loại: {e.typeOfSlot==='ROOFED' ? 'Có mái che': 'Không có mái che'} - Ví trí{index+1}  </Col>
               
                <Col span={8}>
              {e.status === 'Available' ? <Tag color={'green'} >Còn trống</Tag>: <Tag color={'red'} >Đã có xe</Tag>}
            </Col>
            <Col span={8}><Tag color={'geekblue'} >
              Giá {e.price}
            </Tag></Col>
              </Row>
             
              </>}>
        <p>{e.parkingDetail.length >0 ?  "detailSlot" :<Button onClick={u=>{setAddSlot(true);setSlotID(e.slotID);console.log(e.slotID)}}>Thêm xe</Button>}</p>
      </Panel>
          ))
          }
     
    </Collapse>   
      </Drawer>
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
                    dataSource={finalCar}
                    rowKey="id"
                    pagination={pagination}
                    on
                />
      </Modal>
    
     
    </>
  );
}