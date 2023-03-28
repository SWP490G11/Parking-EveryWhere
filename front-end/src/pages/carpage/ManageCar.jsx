import React, { useState, useEffect } from "react";
import { Table, Input, Button, Menu, Dropdown,Space,Form, Row, Col, Modal,notification,Drawer } from "antd";
import {
  FilterOutlined,
  EditFilled,
  CloseCircleOutlined,
  LoadingOutlined,
} from "@ant-design/icons";

import axios from "axios";



export default function ManageCarModel() {
  const [data, setData] = useState([]);
  const [searchText, setSearchText] = useState("");
  const [page, setPage] = useState(1);
  const [pageSize, setPageSize] = useState(10);
  const [type, setType] = useState("Model");
  const [form] = Form.useForm();
  const [form1] = Form.useForm();
  const [open, setOpen] = useState(false);
  const [open1, setOpen1] = useState(false);
  const [modal, setModal] = useState({
    isOpen: false,
    data: {},
  });

  const columns = [
    {   
        title: "ID",
        dataIndex: "id",
        key: "id",
        width: "25%",
       
      },
      {
        title: "Car Number",
        dataIndex: "carNumber",
        key: "carNumber",
        sorter: (a, b) => {
          if (a.carNumber > b.carNumber) {
            return -1;
          }else
          if (b.carNumber > a.carNumber) {
            return 1;
          }
          return 0;
        },
        width: "7%",
      },
   
    {
      title: "Car Model",
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
      title: "Action",
      dataIndex: "action",
      key: "action",
      
    },
  ];
 
  const showDrawer1 = () => {
    setOpen1(true);
  };
  const onClose1 = () => {
    setOpen1(false);
  };
  const [idcar,setIdCar]=useState("");
  //const[carmode,setCarmode]=useState([])
  useEffect(() => {
    axios
      .get(
        `${process.env.REACT_APP_Backend_URI}cars-of-owner`,
        {}
      )
      .then(function (response) {
        let respData = response.data;
        console.log(respData);
       // setCarmode(response.data.carModel);
        respData.forEach((element) => {
          element.carmodel = element.carModel.model;
          element.action = [
            
              <EditFilled style={{  fontSize: "25px" }}
              onClick={()=>{
                showDrawer1();
                form1.setFieldsValue({
                  id : element.id,
                  carmodel: element.carmodel,
                  carNumber: element.carNumber,
                  carModel: element.carModel,
                });
                setIdCar(element.id);
              }}
              />,
          
            <CloseCircleOutlined
              onClick={() => {
                Modal.confirm({
                    title: "Are you sure?",
                    icon: <CloseCircleOutlined style={{ color: "red" }} />,
                    content: "Do you want to delete this car model?",
                    okText: "Delete",
                    cancelText: "Cancel",
                    okButtonProps: { style: { background: "#e30c18", color: "white" } },
              
                    onOk() {
                      return new Promise((resolve, reject) => {
                        setTimeout(Math.random() > 0.5 ? resolve : reject, 1000);
                        axios
                            .delete(
                              `${process.env.REACT_APP_Backend_URI}carmodel/${element.id}`
                            )
                            .then(() => {
                              
                              notification.success({
                                message: `Delete successfully`,
                                description: 'Delete a new car model successfully',
                                placement: 'topLeft',
                              });
                            })
                            .catch(() => {
                                notification.error({
                                    message: `Delete fail`,
                                    description: 'Delete a user fail',
                                    placement: 'topLeft',
                                  });
                            });
                      });
                    },
                    onCancel() {},
                  });
              
              }}
              style={{ color: "red", fontSize: "25px", marginLeft: "10px" }}
            />,
          ];
        });
        setData(
          respData.sort((a, b) => {
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
          })
        );
      }, [])
      .catch(() => {});
  }, [data]);
 
 
  const dataBytype =
    type === "Model" ? data : data.filter((u) => u.model === type);
   // const dataRole= role === "Role" ? dataBytype : dataBytype.filter((u) => u.role === role);
  const finalData =
    searchText === ""
      ? dataBytype
      : (dataBytype.filter(
          (u) =>
            u.model
              .toLowerCase()
              .replace(/\s+/g, "")
              .includes(searchText.toLowerCase().replace(/\s+/g, "")) 
        ) 
        );

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
  const showDrawer = () => {
    setOpen(true);
  };
  const onClose = () => {
    setOpen(false);
  };
  
  const onFinish = (values) => {
    
    axios
      .post(`${process.env.REACT_APP_Backend_URI}carmodel`, {
        carmodel: values.carmodel,
        carNumber: values.carNumber,
       
      })
      .then(() => {
        // sessionStorage.setItem("changeStatus", true);
        notification.success({
          message: `Successfully`,
          description: "Create new parking successfully",
          placement: "topLeft",
        });
        form.setFieldsValue({
            model: "",
            discript:"",
            price: "",
            
          })
        setOpen(false);
       // window.location.reload();
      })
      .catch((error) => {
        notification.warning({
          message: `Fail`,
          description: "Please check input again",
          placement: "topLeft",
        });
        form.setFieldsValue({
            model: "",
            discript:"",
            price: "",
            
          })
      });
  };
  const onFinishEdit = (values) => {
    
    axios
      .put(`${process.env.REACT_APP_Backend_URI}car/${idcar}`, {
        
        carmodel: values.carmodel,
        carNumber: values.carNumber,
       
      })
      .then(() => {
        // sessionStorage.setItem("changeStatus", true);
        notification.success({
          message: `Successfully`,
          description: "Edit this parking successfully",
          placement: "topLeft",
        });
        form.setFieldsValue({
          carmodel: "",
          carNumber: "",
         
            
          })
        setOpen(false);
       // window.location.reload();
      })
      .catch((error) => {
        notification.warning({
          message: `Fail`,
          description: "Please check input again",
          placement: "topLeft",
        });
        form.setFieldsValue({
          carmodel: "",
          carNumber: "",
            
          })
      });
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
        Car Model List
      </p>
      <Row gutter={45} style={{ marginBottom: "30px" }}>
        <Col xs={8} sm={8} md={7} lg={7} xl={6} xxl={5}>
         
      
           {/*Filter Role */}
          <Dropdown.Button
            placement="bottom"
            icon={<FilterOutlined />}
            overlay={
                <Menu>
                <Menu.Item
               onClick={() => {
                 setType("ParkingManager");
               }}
             >
               {" "}
               ParkingManager
             </Menu.Item>
             <Menu.Item
               onClick={() => {
                setType("ParkingOwner");
               }}
             >
               {" "}
               ParkingOwner
             </Menu.Item>
             <Menu.Item
               onClick={() => {
                setType("Customer");
               }}
             >
               {" "}
               Customer
             </Menu.Item>
             <Menu.Item
               onClick={() => {
                setType("Admin");
               }}
             >
               {" "}
               Admin
             </Menu.Item>
             <Menu.Item
               onClick={() => {
                setType("Model");
               }}
             >
               {" "}
               All
             </Menu.Item>
              </Menu>
            }
          >
            {type}
          </Dropdown.Button>
      
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
        <Col xs={8} sm={8} md={7} lg={7} xl={9} xxl={9}>
          <Button style={{ background: "#33CCFF", color: "white"  } } 
          onClick={()=>{
            showDrawer();
            form.setFieldsValue({
            model: "",
            discript:"",
            price: "",
            
          });}}>
             Add new car model
          </Button>
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
        title="Detail Car model"
        onOk={() => {
          setModal({ ...modal, isOpen: false });
        }}
        style={{width:400}}
        footer={[
          <Button
            style={{ background: "#e30c18", color: "white" }}
            key="back"
            onClick={() => {
              setModal({ ...modal, isOpen: false });
            }}
          >
            Close
          </Button>,
        ]}
        closable={false}
      >
        <table>
          <tr>
            <td style={{width:"50px", fontSize: "18px", color: "#838688" }}>ID</td>
            <td
              style={{
                fontSize: "18px",
                color: "#838688",
                textAlign: "justify",
                paddingLeft: "35px",
              }}
            >
              {modal.data.id}
            </td>
          </tr>
          <tr>
            <td style={{ width:"50px",fontSize: "18px", color: "#838688" }}>Car Number</td>
            <td
              style={{
                fontSize: "18px",
                color: "#838688",
                textAlign: "justify",
                paddingLeft: "35px",
              }}
            >
              {modal.data.carNumber}
            </td>
          </tr>
          <tr>
            <td style={{width:"50px", fontSize: "18px", color: "#838688" }}>Car Model</td>
            <td
              style={{
                fontSize: "18px",
                color: "#838688",
                textAlign: "justify",
                paddingLeft: "35px",
              }}
            >
              {modal.data.carmodel}
            </td>
          </tr>
        
          {/* <tr>
            <td style={{width:"50px", fontSize: "18px", color: "#838688" }}>Car Model Detal </td>
            <td
              style={{
                fontSize: "18px",
                color: "#838688",
                textAlign: "justify",
                paddingLeft: "35px",
              }}
            >
              {modal.data.carModel}
            </td>
          </tr> */}
          
       
        </table>
      </Modal>

      {data.length === 0 ? (
        <Table
          loading={{
            indicator: (
              <LoadingOutlined style={{ fontSize: "60px", color: "red" }} />
            ),
            spinning: true,
          }}
        />
      ) : (
        <Table
          key="id"
          rowKey={(data) => data.id}
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
                      id: record.id,
                        carNumber: record.carNumber,
                        carmodel: record.carmodel,
                        carModel: record.carModel,

                    },
                  });
                  console.log(modal.data);
                } else if (
                  e.target.className ===
                  "ant-table-cell ant-table-column-sort ant-table-cell-row-hover"
                ) {
                  setModal({
                    ...modal,
                    isOpen: true,
                    data: {
                        id: record.id,
                        carNumber: record.carNumber,
                        carmodel: record.carmodel,
                        carModel: record.carModel,
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
      {/*Add new car model */}
       <Drawer
          title="Create a new car model"
          width={550}
          onClose={onClose}
          open={open}
          bodyStyle={{
            paddingBottom: 80,
          }}
        >
          <Form form={form} onFinish={onFinish} layout="vertical" hideRequiredMark>
            <Row gutter={16}>
              <Col span={24}>
                <Form.Item
                  name="carNumber"
                  label="Car Number"
                  rules={[
                    {
                      required: true,
                      message: "Please enter Model Name",
                    },
                  ]}
                >
                  <Input placeholder="Please enter Model Name" />
                </Form.Item>
              </Col>
            </Row>
            
            <Row gutter={16}>
              <Col span={24}>
                <Form.Item
                  name="discript"
                  label="Discript"
                  rules={[
                    {
                      required: true,
                      message: "please enter Discript",
                    },
                  ]}
                >
                  <Input.TextArea
                    rows={4}
                    placeholder="please enter Description"
                  />
                </Form.Item>
              </Col>
            </Row>
            
            <Row gutter={16}>
            <Col span={24}>
            <Space>
              <Button onClick={()=>{
                onClose();
                form.setFieldsValue({
                    model: "",
                    discript:"",
                    price: "",
                    })
                } }>Cancel</Button>
              <Button htmlType="submit" type="primary">
                Submit
              </Button>
              </Space>
           
              </Col>
           
            </Row>
           
          </Form>
        </Drawer>
         {/*Edit car model */}
       <Drawer
          title="Edit  car model"
          width={550}
          onClose={onClose1}
          open={open1}
          bodyStyle={{
            paddingBottom: 80,
          }}
        >
          <Form form={form1} onFinish={onFinishEdit} layout="vertical" hideRequiredMark>
          <Row gutter={16}>
              <Col span={24}>
                <Form.Item
                  name="id"
                  label="ID "
                  rules={[
                    {
                      required: true,
                      message: "Please enter Model Name",
                    },
                  ]}
                >
                  <Input disabled placeholder="Please enter Model Name" />
                </Form.Item>
              </Col>
            </Row>
            <Row gutter={16}>
              <Col span={24}>
                <Form.Item
                  name="carNumber"
                  label="Car Number"
                  rules={[
                    {
                      required: true,
                      message: "Please enter Car Number ",
                    },
                  ]}
                >
                  <Input placeholder="Please enter Car Number" />
                </Form.Item>
              </Col>
            </Row>
            <Row gutter={16}>
              <Col span={24}>
                <Form.Item
                  name="price"
                  label="Price"
                  rules={[
                    {
                      required: true,
                      message: "Please enter Price ",
                    },
                  ]}
                >
                  <Input
                    style={{
                      width: "100%",
                    }}
                    placeholder="Please enter Price "
                  />
                 
                </Form.Item>
              </Col>
            </Row>
          
            <Row gutter={16}>
              <Col span={24}>
                <Form.Item
                  name="carModel"
                  label="Car Model Detail"
                  rules={[
                    {
                      required: true,
                      message: "please enter Discript",
                    },
                  ]}
                >
                  <Input.TextArea 
                  disabled
                    rows={4}
                   
                  />
                </Form.Item>
              </Col>
            </Row>
            
            <Row gutter={16}>
            <Col span={24}>
            <Space>
              <Button onClick={()=>{
                onClose1();
                
                } }>Cancel</Button>
              <Button onClick={onClose1} htmlType="submit" type="primary">
                Submit
              </Button>
              </Space>
           
              </Col>
           
            </Row>
           
          </Form>
        </Drawer>
    </>
  );
}