import React, { useState, useEffect } from "react";
import { Table, Input, Button, Menu, Dropdown,Spin, Row, Col,Descriptions,List,Divider, Modal,Empty,Drawer,Form,Radio,Space,notification,Collapse,InputNumber,Tag } from "antd";
import {
  FilterOutlined,DeleteOutlined,
  EditFilled,
  CloseSquareOutlined,PlusOutlined,UnorderedListOutlined,SearchOutlined
} from "@ant-design/icons";
import { useNavigate } from "react-router-dom";
import { toRoute } from '../../utils/helpers';
import api from "../../services/api";
import { Role } from '../../utils/constants';
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
  const [page1, setPage1] = useState(1);
  const [pageSize1, setPageSize1] = useState(5);
  const [page2, setPage2] = useState(1);
  const [pageSize2, setPageSize2] = useState(5);
  const [status,setStatus]= useState("Tất cả");
  const [type,setType]= useState("Tất cả");
  const [type1,setType1]= useState("Tất cả");
  const [slotParking,setSlotParking] =useState([]);
  const [slotParking1,setSlotParking1] =useState([]);
const [carModal, setCarModal] = useState(false);
const [addSlot,setAddSlot]= useState(false)
  const [modal, setModal] = useState({
    isOpen: false,
    data: {},
  });
  const [loading, setLoading] = useState(true);
  const [loading1, setLoading1] = useState(false);
  const [loading2, setLoading2] = useState(false);
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
        // localStorage.setItem("changeStatus", true);
        notification.success({
          message: `Thành công`,
          description: "Thêm chỗ đỗ thành công",
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
          notification.success({
            message: `Thành công`,
            description: "Đã thêm xe vào chỗ đỗ",
            placement: "topLeft",
          });
            window.location.reload();
        })
        .catch((err) => {
          notification.warning({
            message: `Thất bại`,
            description: "Thêm xe vào chỗ đỗ không thành công",
            placement: "topLeft",
          });
        });
};
const showPromiseDelete = (id) => {
  Modal.confirm({
    title: 'Bạn muốn xóa bãi đỗ này?',
    content: 'Bãi đỗ này sẽ bị xóa ra khỏi danh sách',
    onOk() {
      return new Promise((resolve, reject) => {
        api.delete(`/parking/${id}`)
        setTimeout(Math.random() > 0.5 ? resolve : reject, 1000);
      }).catch(() => console.log('Oops errors!'));
    },
    onCancel() {},
  });
};
  // const [deleteModal, setDeleteModal] = useState({
  //   isOpen: false,
  //   title: "Notice",
  //   content: <p>Do you want to disable student?</p>,
  //   footer: (
  //     <div style={{ textAlign: "left" }}>
  //       <Button className="buttonSave">Disable</Button>
       
  //     </div>
  //   ),
  // });
  const [searchCar, setSearchCar] = useState("");
  const[open1,setOpen1]=useState(false)
 
  const onClosez = () => {
    setOpen1(false);
  };
  const onClose = () => {
        setOpen(false);
    };
  
 

  useEffect(() => {
  
  api.get(`parkings-of-owner`)
  .then(function (response) {
    let respData = response.data;
      
    respData.forEach((element) => {
     
      element.status = element.status ==='Available' ? "Đang hoạt động" : ( element.status === 'Pending' ? 'Chờ duyệt' : 'Từ chối' )
      element.action = [
         <Button className='buttonState' disabled={element.status ==='Đang hoạt động' ? false : true}
         onClick={e => navigateTo(toRoute(routes.PARKING_DETAIL_UPDATE, { parkingID: element.parkingID }))}
                    >
                    <EditFilled/>
            </Button>,
            <Button disabled={element.status ==='Đang hoạt động' ? false : true} 
            onClick={e => {setOpen(true);setParkingID(element.parkingID);setParkingName(element.parkingName);
            
            }}><PlusOutlined /></Button>,
            <Button disabled={element.status ==='Đang hoạt động' ? false : true} 
            onClick={() => {setOpen1(true);loadSlotParking(element.parkingID);setParkingName(element.parkingName);
              loadSlotParking1(element.parkingID);setLoading1(true); setLoading2(true);
            }}><UnorderedListOutlined /></Button>,
            
           
            
            <Button disabled={(element.status ==='Từ chối'|| element.status ==='Chờ duyệt') ? false : true} onClick={() => 
              showPromiseDelete(element.parkingID)
            }><DeleteOutlined /></Button>
         
            
      ];
      
    });
    setLoading(false);
    setData(
      respData.sort((a, b) => {
        if (
          a.status.trim().toLowerCase() >
          b.status.trim().toLowerCase()
        ) {
          return 1;
        }
        if (
          b.status.trim().toLowerCase() >
          a.status.trim().toLowerCase()
        ) {
          return -1;
        }
        return 0;
      })
    );
  },[])
  .catch(() => {
    setLoading(true);
  }
 
  
  )  

  }, [data]);
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
}, [car])


  const dataBystatus =
  status === "Tất cả" ? data : data.filter((u) => u.status === status);
  const finalData =
    searchText === ""? dataBystatus : (dataBystatus.filter((u) =>
    u.parkingName
    .toLowerCase()
    .replace(/\s+/g, "")
    .includes(searchText.toLowerCase().replace(/\s+/g, "")) 
              // || u.id.toLowerCase().includes(searchText.toLowerCase())
        ) 
        );
  
            // const [selectedRowKeys, setSelectedRowKeys] = useState([]);
 
 const loadSlotParking=(values)=>{
    console.log(values);
      api.get(`slots-Roof/${values}`)
      .then((response) =>{
        setLoading1(false);
        setSlotParking(response.data.sort((a, b) => {
          if (
            a.status.trim().toLowerCase() >
            b.status.trim().toLowerCase() 
          ) {
            return 1;
          }
          if (
            b.status.trim().toLowerCase() >
            a.status.trim().toLowerCase() 
          ) {
            return -1;
          }
          return 0;
        }))})
      .catch((e)=>{setLoading1(false);
        notification.warning({
        message: `Lỗi dữ liệu`,
      description: "Tải dữ liệu bị lỗi",
    placement: "topLeft",
     });});
            }
            const dataType =
        type === 'Tất cả' ? slotParking : slotParking.filter((u) => u.status === type);    
  const finalCar =
        searchCar === ""? car : (car.filter((u) =>
        u.carNumber
        .toLowerCase()
        .replace(/\s+/g, "")
        .includes(searchCar.toLowerCase().replace(/\s+/g, "")) 
                  // || u.id.toLowerCase().includes(searchText.toLowerCase())
            ) 
            );
  const loadSlotParking1=(values)=>{
              console.log(values);
                api.get(`slots-nonRoof/${values}`)
                .then((response) =>{
                  setLoading2(false);
                  setSlotParking1(response.data.sort((a, b) => {
                    if (
                      a.status.trim().toLowerCase() >
                      b.status.trim().toLowerCase() 
                    ) {
                      return 1;
                    }
                    if (
                      b.status.trim().toLowerCase() >
                      a.status.trim().toLowerCase() 
                    ) {
                      return -1;
                    }
                    return 0;
                  }))})
                .catch((e)=>{
                  setLoading2(false);
                  notification.warning({
                  message: `Lỗi dữ liệu`,
                description: "Tải dữ liệu bị lỗi",
              placement: "topLeft",
               });});
                      }
  const dataType1 =
        type1 === 'Tất cả' ? slotParking1 : slotParking1.filter((u) => u.status === type1);    
  const pagination = {
    current: page,
    pageSize: pageSize,
    total: finalData.length,
    pageSizeOptions: [5, 10, 15, 20],
    className: "ant-btn-dangerous",
    dangerous: true,
    onChange: (page, pageSize) => {
      setPage(page);
      setPageSize(pageSize);
    },
   showSizeChanger:true, 
      showTotal: total => `Tổng ${total} bãi dỗ`
  }; 
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
  const pagination1 = {
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
      showTotal: total => `Tổng ${total} xe`
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
  const renderContent = () => {
    switch(status) {
        case 'Status':
          return 'Tất cả'
        case 'Available':
          return 'Đang hoạt động'
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
     <Spin spinning={loading} size="large" tip="Vui lòng đợi..."> 
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
        Quản lí bãi đỗ
      </p>
      <Row gutter={45} style={{ marginBottom: "30px" }}>
      <Col span={8}>
            {/*Filter Gender */}
            <Form.Item label={'Trạng thái'}>
            <Dropdown.Button
            placement="bottom"
            icon={<FilterOutlined />}
            overlay={
              <Menu>
                <Menu.Item
                  
                  onClick={() => {
                    setStatus("Chờ duyệt");
                  }}
                >
                  {" "}
                  Chờ duyệt
                </Menu.Item>
                <Menu.Item
                
                  onClick={() => {
                    setStatus("Từ chối");
                  }}
                >
                  {" "}
                  Từ chối
                </Menu.Item>
                <Menu.Item
                
                  onClick={() => {
                    setStatus("Đang hoạt động");
                  }}
                >
                  {" "}
                  Đang hoạt động
                </Menu.Item>
               
                <Menu.Item
                  onClick={() => {
                    setStatus("Tất cả");
                  }}
                >
                  {" "}
                  Tất cả
                </Menu.Item>
              </Menu>
            }
          > 
          {status}
            
          </Dropdown.Button>
            </Form.Item>
        
          </Col>
        <Col span={8}>
          <Input.Search
            placeholder="Tìm kiếm"
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
      {/* <Modal
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
      </Modal> */}
      <Modal
        open={modal.isOpen}
        
        onOk={() => {
          setModal({ ...modal, isOpen: false });
        }}
        width={700}
        onCancel={() => {
          setModal({ ...modal, isOpen: false });
        }}
        footer={null}
        closable={true}
      >
        <Descriptions title="Thông tin bãi đỗ" bordered>
        <Descriptions.Item label="Tên Bãi Đỗ" span={3}>{modal.data.parkingName}</Descriptions.Item>
    <Descriptions.Item label="Trạng thái" >{modal.data.status}</Descriptions.Item>
    <Descriptions.Item label="Tọa độ" span={2}>{modal.data.latitude} - {modal.data.longitude}</Descriptions.Item>
    <Descriptions.Item label="Địa chỉ" span={3} >{modal.data.addressDetail}</Descriptions.Item>
    <Descriptions.Item label="Thông tin thêm" span={3}>{modal.data.description}</Descriptions.Item>
    <Descriptions.Item label="Nhân viên" span={3}>{modal.data.parkingManagers && modal?.data?.parkingManagers?.map((e,index)=>(<>Nhân viên {index+1}: {e.fullName} - {e.phoneNumber} - {e.email} <br/></>))}</Descriptions.Item>
    </Descriptions>
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
                      parkingManagers: record.parkingManagers
                    },
                  });
                  
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
            <Spin spinning={loading1} size="large" tip="Vui lòng đợi..."> 
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
          </Spin>
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
            <Spin spinning={loading2} size="large" tip="Vui lòng đợi..."> 
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
            </Spin>
   
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
           
            <Row>
              <Col span={16}></Col>
              <Col span={8}>
              <Button onClick={()=>{setAddSlot(false); form.setFieldsValue({
                    carID: "",
                 carNumber: "",
                note: "",})} }>Hủy</Button>
              <Button htmlType="submit" type="primary" style={{marginLeft:"10px"}}>
                Lưu
              </Button>
              </Col>
            
              
              </Row>
        
          
        </Form>
      </Modal>
      {/*Chọn xe */}
      <Modal
        title="Chọn xe"
        open={carModal}
        footer={null}
        onCancel={()=>setCarModal(false)}
      > <Input.Search
      placeholder="Tìm xe"
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
                    pagination={pagination1}
                    on
                />
      </Modal>
    
     </Spin>
    </>
  );
}