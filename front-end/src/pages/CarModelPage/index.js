import React, { useState, useEffect } from "react";
<<<<<<< HEAD:front-end/src/pages/carpage/carmodelpage/ManageCarModel.jsx
import {
  Table,
  Input,
  Button,
  Menu,
  Dropdown,
  Space,
  Form,
  Row,
  Col,
  Modal,
  notification,
  Drawer,
} from "antd";
import {
  FilterOutlined,
  EditFilled,
  CloseCircleOutlined,
  LoadingOutlined,
} from "@ant-design/icons";
import axios from "axios";

export default function ManageCarModel() {
=======
import { Table, Input, Button, Menu, Dropdown,Space,Form, Row, Col, Modal,notification,Drawer,Empty } from "antd";
import {
  FilterOutlined,
  EditFilled,
  CloseOutlined,
  LoadingOutlined,
} from "@ant-design/icons";
import api from "../../services/api";
 const ManageCarModel=()=> {
>>>>>>> 14bf5589c06f1d524eb8c1079b2ddd7883521e6b:front-end/src/pages/CarModelPage/index.js
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
      title: "Model",
      dataIndex: "model",
      key: "model",
      sorter: (a, b) => {
        if (a.model > b.model) {
          return -1;
        } else if (b.model > a.model) {
          return 1;
        }
        return 0;
      },
      width: "7%",
    },
    {
      title: "Discript",
      dataIndex: "discript",
      key: "discript",
<<<<<<< HEAD:front-end/src/pages/carpage/carmodelpage/ManageCarModel.jsx
    },
    {
      title: "Price",
      dataIndex: "price",
      key: "price",
      sorter: (a, b) => {
        if (a.price > b.price) {
          return -1;
        }
        if (b.price > a.price) {
          return 1;
        }
        return 0;
      },
=======
      width: "50%",
>>>>>>> 14bf5589c06f1d524eb8c1079b2ddd7883521e6b:front-end/src/pages/CarModelPage/index.js
    },
    {
      title: "Action",
      dataIndex: "action",
      key: "action",
<<<<<<< HEAD:front-end/src/pages/carpage/carmodelpage/ManageCarModel.jsx
=======
      width: "10%",
>>>>>>> 14bf5589c06f1d524eb8c1079b2ddd7883521e6b:front-end/src/pages/CarModelPage/index.js
    },
  ];
  // const [deleteModal, setDeleteModal] = useState({
  //   isOpen: false,
  //   title: "Notice",
  //   content: <p>Do you want to delete car model?</p>,
  //   // footer: (
  //   //   <div style={{ textAlign: "left" }}>
  //   //     <Button className="buttonSave">Delete</Button>

  //   //   </div>
  //   // ),
  // });
  const showDrawer1 = () => {
    setOpen1(true);
  };
  const onClose1 = () => {
    setOpen1(false);
  };
<<<<<<< HEAD:front-end/src/pages/carpage/carmodelpage/ManageCarModel.jsx
  const [idcar, setIdCar] = useState("");
  useEffect(() => {
    axios
      .get(`${process.env.REACT_APP_Backend_URI}carmodels`, {})
=======
 
  useEffect(() => {
    api
      .get(`carmodels`,{})
>>>>>>> 14bf5589c06f1d524eb8c1079b2ddd7883521e6b:front-end/src/pages/CarModelPage/index.js
      .then(function (response) {
        let respData = response.data;
        console.log(respData);

        respData.forEach((element) => {
          element.action = [
<<<<<<< HEAD:front-end/src/pages/carpage/carmodelpage/ManageCarModel.jsx
            <EditFilled
              style={{ fontSize: "25px" }}
              onClick={() => {
                showDrawer1();
                form1.setFieldsValue({
                  id: element.id,
                  model: element.model,
                  discript: element.discript,
                  price: element.price,
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
                  okButtonProps: {
                    style: { background: "#e30c18", color: "white" },
                  },

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
                            description: "Delete a new car model successfully",
                            placement: "topLeft",
                          });
                        })
                        .catch(() => {
                          notification.error({
                            message: `Delete fail`,
                            description: "Delete a user fail",
                            placement: "topLeft",
                          });
                        });
=======
            <Button className='buttonState'
                           
                            onClick={()=>{
                              showDrawer1();
                              form1.setFieldsValue({
                                  id: element.id,
                                  model: element.model,
                                  discript: element.discript,
                                  price: element.price,
                              });
                              
                            }}
                        >
                        <EditFilled/>
                </Button>
             ,
             <Button
             className="buttonState"
             // disabled={element.status === 'Pending' || element.isInProgress === false}
             onClick={() => {
              Modal.confirm({
                  title: "Bạn muốn xóa",
                  icon: <CloseOutlined style={{ color: "red" }} />,
                  content: "Bạn có muốn xóa "+element.model+" ?",
                  okText: "Xóa",
                  cancelText: "Hủy",
                  okButtonProps: { style: { background: "#e30c18", color: "white" } },
            
                  onOk() {
                    return new Promise((resolve, reject) => {
                      setTimeout(Math.random() > 0.5 ? resolve : reject, 1000);
                      api.delete(`carmodel/${element.id}`)
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
>>>>>>> 14bf5589c06f1d524eb8c1079b2ddd7883521e6b:front-end/src/pages/CarModelPage/index.js
                    });
                  },
                  onCancel() {},
                });
<<<<<<< HEAD:front-end/src/pages/carpage/carmodelpage/ManageCarModel.jsx
              }}
              style={{ color: "red", fontSize: "25px", marginLeft: "10px" }}
            />,
=======
            
            }}
         >
            <CloseOutlined  style={{color: 'red'}}/>
         </Button>,
           
>>>>>>> 14bf5589c06f1d524eb8c1079b2ddd7883521e6b:front-end/src/pages/CarModelPage/index.js
          ];
        });
        setData(
          respData.sort((a, b) => {
            if (a.model.trim().toLowerCase() > b.model.trim().toLowerCase()) {
              return 1;
            }
            if (b.model.trim().toLowerCase() > a.model.trim().toLowerCase()) {
              return -1;
            }
            return 0;
          })
        );
      }, [])
      .catch(() => {});
<<<<<<< HEAD:front-end/src/pages/carpage/carmodelpage/ManageCarModel.jsx
  }, [data]);

  const dataBytype =
    type === "Model" ? data : data.filter((u) => u.model === type);
  // const dataRole= role === "Role" ? dataBytype : dataBytype.filter((u) => u.role === role);
=======
  }, [form1,data]);
 
 
  const dataBytype =
    type === "Model" ? data : data.filter((u) => u.model === type);
>>>>>>> 14bf5589c06f1d524eb8c1079b2ddd7883521e6b:front-end/src/pages/CarModelPage/index.js
  const finalData =
    searchText === ""
      ? dataBytype
      : dataBytype.filter((u) =>
          u.model
            .toLowerCase()
            .replace(/\s+/g, "")
            .includes(searchText.toLowerCase().replace(/\s+/g, ""))
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
    showSizeChanger: true,
    showTotal: (total) => `Total ${total} Student`,
  };
  const showDrawer = () => {
    setOpen(true);
  };
  const onClose = () => {
    setOpen(false);
  };

  const onFinish = (values) => {
<<<<<<< HEAD:front-end/src/pages/carpage/carmodelpage/ManageCarModel.jsx
    axios
      .post(`${process.env.REACT_APP_Backend_URI}carmodel`, {
=======
    
    api
      .post(`carmodel`, {
        
>>>>>>> 14bf5589c06f1d524eb8c1079b2ddd7883521e6b:front-end/src/pages/CarModelPage/index.js
        model: values.model,
        discript: values.discript,
        lastModifyAt: new Date(),
      })
      .then(() => {
        // sessionStorage.setItem("changeStatus", true);
        notification.success({
          message: `Successfully`,
          description: "Create new car model successfully",
          placement: "topLeft",
        });
        form.setFieldsValue({
          model: "",
          discript: "",
          price: "",
        });
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
          discript: "",
          price: "",
        });
      });
  };
  const onFinishEdit = (values) => {
<<<<<<< HEAD:front-end/src/pages/carpage/carmodelpage/ManageCarModel.jsx
    axios
      .put(`${process.env.REACT_APP_Backend_URI}carmodel/${idcar}`, {
=======
    
    api
      .put(`carmodel/${values.id}`, {
        
>>>>>>> 14bf5589c06f1d524eb8c1079b2ddd7883521e6b:front-end/src/pages/CarModelPage/index.js
        model: values.model,
        discript: values.discript,
        lastModifyAt: new Date(),
      })
      .then(() => {
        // sessionStorage.setItem("changeStatus", true);
        notification.success({
          message: `Successfully`,
          description: "Edit this parking successfully",
          placement: "topLeft",
        });
        form.setFieldsValue({
          model: "",
          discript: "",
          price: "",
        });
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
          discript: "",
          price: "",
        });
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
        Danh sách loại xe
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
<<<<<<< HEAD:front-end/src/pages/carpage/carmodelpage/ManageCarModel.jsx
          <Button
            style={{ background: "#33CCFF", color: "white" }}
            onClick={() => {
              showDrawer();
              form.setFieldsValue({
                model: "",
                discript: "",
                price: "",
              });
            }}
          >
            Add new car model
=======
          <Button style={{ background: "#33CCFF", color: "white"  } } 
          onClick={()=>{
            showDrawer();
            form.setFieldsValue({
            model: "",
            discript:"",
            price: "",
            
          });}}>
            Thêm loại xe mới
>>>>>>> 14bf5589c06f1d524eb8c1079b2ddd7883521e6b:front-end/src/pages/CarModelPage/index.js
          </Button>
        </Col>
      </Row>
     
      <Modal
        open={modal.isOpen}
        title="Detail Car model"
        onOk={() => {
          setModal({ ...modal, isOpen: false });
        }}
        style={{ width: 400 }}
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
        {/* <table>
          <tr>
            <td style={{ width: "50px", fontSize: "18px", color: "#838688" }}>
              ID
            </td>
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
            <td style={{ width: "50px", fontSize: "18px", color: "#838688" }}>
              Model
            </td>
            <td
              style={{
                fontSize: "18px",
                color: "#838688",
                textAlign: "justify",
                paddingLeft: "35px",
              }}
            >
              {modal.data.model}
            </td>
          </tr>
          <tr>
            <td style={{ width: "50px", fontSize: "18px", color: "#838688" }}>
              Discript
            </td>
            <td
              style={{
                fontSize: "18px",
                color: "#838688",
                textAlign: "justify",
                paddingLeft: "35px",
              }}
            >
              {modal.data.discript}
            </td>
          </tr>

          <tr>
            <td style={{ width: "50px", fontSize: "18px", color: "#838688" }}>
              Price{" "}
            </td>
            <td
              style={{
                fontSize: "18px",
                color: "#838688",
                textAlign: "justify",
                paddingLeft: "35px",
              }}
            >
              {modal.data.price}
            </td>
          </tr>
<<<<<<< HEAD:front-end/src/pages/carpage/carmodelpage/ManageCarModel.jsx
        </table>
=======
          
       
        </table> */}
>>>>>>> 14bf5589c06f1d524eb8c1079b2ddd7883521e6b:front-end/src/pages/CarModelPage/index.js
      </Modal>

      {finalData.length === 0 ? (
        <Empty description={"Không có dữ liệu"}/>
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
<<<<<<< HEAD:front-end/src/pages/carpage/carmodelpage/ManageCarModel.jsx
                      id: record.id,
                      model: record.model,

                      discript: record.discript,
                      price: record.price,
=======
                        id: record.id,
                        model: record.model,
                      discript: record.discript,

>>>>>>> 14bf5589c06f1d524eb8c1079b2ddd7883521e6b:front-end/src/pages/CarModelPage/index.js
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
<<<<<<< HEAD:front-end/src/pages/carpage/carmodelpage/ManageCarModel.jsx
                      id: record.id,
                      model: record.model,

                      discript: record.discript,
                      price: record.price,
=======
                        id: record.id,
                        model: record.model,                     
                      discript: record.discript,

>>>>>>> 14bf5589c06f1d524eb8c1079b2ddd7883521e6b:front-end/src/pages/CarModelPage/index.js
                    },
                  });
                  
                } else {
                  setModal({ ...modal, isOpen: false });
                }
              },
            };
          }}
        />
      )}
      {/*Add new car model */}
<<<<<<< HEAD:front-end/src/pages/carpage/carmodelpage/ManageCarModel.jsx
      <Drawer
        title="Create a new car model"
        width={550}
        onClose={onClose}
        open={open}
        bodyStyle={{
          paddingBottom: 80,
        }}
      >
        <Form
          form={form}
          onFinish={onFinish}
          layout="vertical"
          hideRequiredMark
        >
          <Row gutter={16}>
            <Col span={24}>
              <Form.Item
                name="model"
                label="Model Name"
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
                <Button
                  onClick={() => {
                    onClose();
                    form.setFieldsValue({
                      model: "",
                      discript: "",
                      price: "",
                    });
                  }}
                >
                  Cancel
                </Button>
                <Button htmlType="submit" type="primary">
                  Submit
                </Button>
=======
       <Drawer
          title="Thêm loại xe mới"
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
                  name="model"
                  label="Tên loại xe"
                  rules={[
                    {
                      required: true,
                      message: "Vui lòng nhập tên loại xe",
                    },
                  ]}
                >
                  <Input placeholder="Vui lòng kiểm tra thông tin" />
                </Form.Item>
              </Col>
            </Row>
           
          
            <Row gutter={16}>
              <Col span={24}>
                <Form.Item
                  name="discript"
                  label="Miêu tả"
                  rules={[
                    {
                      required: true,
                      message: "Vui lòng kiểm tra lại thông tin mô tải",
                    },
                  ]}
                >
                  <Input.TextArea
                    rows={4}
                    placeholder="Vui lòng nhập thông tin mô tả"
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
                } }>Hủy</Button>
              <Button htmlType="submit" type="primary">
                Lưu
              </Button>
              </Space>
           
              </Col>
           
            </Row>
           
          </Form>
        </Drawer>
         {/*Edit car model */}
       <Drawer
          title="Chỉnh sửa loại xe"
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
                 
                >
                  <Input disabled/>
                </Form.Item>
              </Col>
            </Row>
            <Row gutter={16}>
              <Col span={24}>
                <Form.Item
                  name="model"
                  label="Tên loại xe"
                  rules={[
                    {
                      required: true,
                      message: "Vui lòng kiểm tra lại tên loại xe",
                    },
                  ]}
                >
                  <Input placeholder="Vui lòng nhập tên loại xe" />
                </Form.Item>
              </Col>
            </Row>
           
          
            <Row gutter={16}>
              <Col span={24}>
                <Form.Item
                  name="discript"
                  label="Giá"
                  rules={[
                    {
                      required: true,
                      message: "Vui lòng kiểm tra lại mô tả ",
                    },
                  ]}
                >
                  <Input.TextArea
                    rows={4}
                    placeholder="Vui lòng nhập thêm mô tả"
                  />
                </Form.Item>
              </Col>
            </Row>
            
            <Row gutter={16}>
            <Col span={24}>
            <Space>
              <Button onClick={()=>{
                onClose1();
                
                } }>Hủy</Button>
              <Button onClick={()=>{
                return new Promise((resolve, reject) => {
                  setTimeout(Math.random() > 0.5 ? resolve : reject, 5000);
                  onClose1()});
              }} htmlType="submit" type="primary" >
                Lưu
              </Button>
>>>>>>> 14bf5589c06f1d524eb8c1079b2ddd7883521e6b:front-end/src/pages/CarModelPage/index.js
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
        <Form
          form={form1}
          onFinish={onFinishEdit}
          layout="vertical"
          hideRequiredMark
        >
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
                name="model"
                label="Model Name"
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
                <Button
                  onClick={() => {
                    onClose1();
                  }}
                >
                  Cancel
                </Button>
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
<<<<<<< HEAD:front-end/src/pages/carpage/carmodelpage/ManageCarModel.jsx
=======
export default ManageCarModel;
>>>>>>> 14bf5589c06f1d524eb8c1079b2ddd7883521e6b:front-end/src/pages/CarModelPage/index.js
