import React, { useState, useEffect } from "react";
import { Table, Input, Button, Menu, Descriptions,Space,Form, Row, Col, Modal,notification,Drawer,Empty } from "antd";
import {
  FilterOutlined,
  EditFilled,
  
} from "@ant-design/icons";
import api from "../../services/api";
 const ManageCarModel=()=> {
  const [data, setData] = useState([]);
  const [searchText, setSearchText] = useState("");
  const [page, setPage] = useState(1);
  const [pageSize, setPageSize] = useState(10);
 
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
        title: "Mã số",
        dataIndex: "id",
        key: "id",
        width: "25%",
       
      },
      {
        title: "Loại xe",
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
      title: "Thông tin",
      dataIndex: "discript",
      key: "discript",
      width: "50%",
    },
    {
      title: " ",
      dataIndex: "action",
      key: "action",
      width: "10%",
    },
  ];
  
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
        //      <Button
        //      className="buttonState"
        //      // disabled={element.status === 'Pending' || element.isInProgress === false}
        //      onClick={() => {
        //       Modal.confirm({
        //           title: "Bạn muốn xóa",
        //           icon: <CloseOutlined style={{ color: "red" }} />,
        //           content: "Bạn có muốn xóa "+element.model+" ?",
        //           okText: "Xóa",
        //           cancelText: "Hủy",
        //           okButtonProps: { style: { background: "#e30c18", color: "white" } },
            
        //           onOk() {
        //             return new Promise((resolve, reject) => {
        //               setTimeout(Math.random() > 0.5 ? resolve : reject, 1000);
        //               api.delete(`carmodel/${element.id}`)
        //                   .then(() => {
                            
        //                     notification.success({
        //                       message: `Thành công`,
        //                       description: 'Bạn đã xóa thành công',
        //                       placement: 'topLeft',
        //                     });
        //                   })
        //                   .catch(() => {
        //                       notification.error({
        //                           message: `Xóa thất bại`,
        //                           description: 'Vui lòng thử lại',
        //                           placement: 'topLeft',
        //                         });
        //                   });
        //             });
        //           },
        //           onCancel() {},
        //         });
            
        //     }}
        //  >
        //     <CloseOutlined  style={{color: 'red'}}/>
        //  </Button>,
           
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
 
 
  
  const finalData =
    searchText === ""
      ? data
      : (data.filter(
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
      showTotal: total => `Tổng ${total} loại xe`
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
          message: `Thành công`,
          description: "Tạo loại xe mới thành công",
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
          message: `Thất bại`,
          description: "Vui lòng kiểm tra lại thông tin",
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
          message: `Thành công`,
          description: "Chỉnh sửa loại xe thành công",
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
          message: `Thất bại`,
          description: "Vui lòng kiểm tra lại thông tin ",
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
        <Col span={8}>
         
      
           {/*Filter Role */}
        
      
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
        <Col span={8}>
          <Button style={{ background: "#33CCFF", color: "white"  } } 
          onClick={()=>{
            showDrawer();
            form.setFieldsValue({
            model: "",
            discript:"",
            
            
          });}}>
            Thêm loại xe mới
          </Button>
        </Col>
      </Row>
     
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
        <Descriptions title="Thông tin loại xe" bordered>
        <Descriptions.Item label="Mã số " span={3}>{modal.data.id}</Descriptions.Item>
    <Descriptions.Item label="Loại xe" span={3}>{modal.data.model}</Descriptions.Item>
    <Descriptions.Item label="Thông tin" span={3}>{modal.data.discript}</Descriptions.Item>
    
   
    </Descriptions>
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