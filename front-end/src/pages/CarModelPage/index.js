import React, { useState, useEffect } from "react";
import { Table, Input, Button, Menu, Dropdown,Space,Form, Row, Col, Modal,notification,Drawer,Empty } from "antd";
import {
  FilterOutlined,
  EditFilled,
  CloseOutlined,
  LoadingOutlined,
} from "@ant-design/icons";
import api from "../../services/api";
 const ManageCarModel=()=> {
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
          }else
          if (b.model > a.model) {
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
      width: "50%",
    },
    {
      title: "Action",
      dataIndex: "action",
      key: "action",
      width: "10%",
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
 
  useEffect(() => {
    api
      .get(`carmodels`,{})
      .then(function (response) {
        let respData = response.data;
        console.log(respData);

        respData.forEach((element) => {
           
          element.action = [
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
                    });
                  },
                  onCancel() {},
                });
            
            }}
         >
            <CloseOutlined  style={{color: 'red'}}/>
         </Button>,
           
          ];
        });
        setData(
          respData.sort((a, b) => {
            if (
              a.model.trim().toLowerCase() >
              b.model.trim().toLowerCase()
            ) {
              return 1;
            }
            if (
              b.model.trim().toLowerCase() >
              a.model.trim().toLowerCase()
            ) {
              return -1;
            }
            return 0;
          })
        );
      }, [])
      .catch(() => {});
  }, [form1,data]);
 
 
  const dataBytype =
    type === "Model" ? data : data.filter((u) => u.model === type);
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
    
    api
      .post(`carmodel`, {
        
        model: values.model,
        discript: values.discript,
        lastModifyAt: new Date(),
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
    
    api
      .put(`carmodel/${values.id}`, {
        
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
          <Button style={{ background: "#33CCFF", color: "white"  } } 
          onClick={()=>{
            showDrawer();
            form.setFieldsValue({
            model: "",
            discript:"",
            price: "",
            
          });}}>
            Thêm loại xe mới
          </Button>
        </Col>
      </Row>
     
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
        {/* <table>
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
            <td style={{ width:"50px",fontSize: "18px", color: "#838688" }}>Model</td>
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
            <td style={{width:"50px", fontSize: "18px", color: "#838688" }}>Discript</td>
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
            <td style={{width:"50px", fontSize: "18px", color: "#838688" }}>Price </td>
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
          
       
        </table> */}
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
                        id: record.id,
                        model: record.model,
                      discript: record.discript,

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
                        id: record.id,
                        model: record.model,                     
                      discript: record.discript,

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
              </Space>
           
              </Col>
           
            </Row>
           
          </Form>
        </Drawer>
    </>
  );
}
export default ManageCarModel;