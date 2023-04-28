import React, { useState, useEffect } from "react";
import {
  Table,
  Input,
  Button,
  Space,
  Form,
  Row,
  Col,
  Modal,Select,
  notification,
  Drawer,Empty,Descriptions
} from "antd";
import dayjs from 'dayjs';
import {
  EditFilled,
  CloseCircleOutlined,
  CloseOutlined,
} from "@ant-design/icons";
import axios from "axios";
import api from "../../services/api";
const MyCar = () => {
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
  
  const [carModel,setCarModel]=useState([]);
  //const [loadings, setLoadings] = useState([]);
//   const enterLoading = (index) => {
//     setLoadings((state) => {
//       const newLoadings = [...state];
//       newLoadings[index] = true;
//       return newLoadings;
//     });
//     setTimeout(() => {
//       setLoadings((state) => {
//         const newLoadings = [...state];
//         newLoadings[index] = false;
//         return newLoadings;
//       });
//     }, 6000);
//   };

  const columns = [
    {
      title: "Mã",
      dataIndex: "id",
      key: "id",
      responsive: ['sm'],
    },
    {
      title: "Biển số",
      dataIndex: "carNumber",
      key: "carNumber",
      sorter: (a, b) => {
        if (a.carNumber > b.carNumber) {
          return -1;
        } else if (b.carNumber > a.carNumber) {
          return 1;
        }
        return 0;
      },
      responsive: ['xs','sm'],
      
    },
    {
      title: "Loại xe",
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
       responsive: ['xs','sm'],
     
    },
    {
      title: "Thông tin",
      dataIndex: "discript",
      key: "discript",
      responsive: ['sm'],
    },
    {
      title: "Trạng thái",
      dataIndex: "status",
      key: "status",
      responsive: ['xs','sm'],
    },
    {
      responsive: ['xs','sm'],
      title: "Hành động",
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
  const [idcar, setIdCar] = useState("");
  useEffect(() => {
    api
      .get(`cars-of-owner`, {})
      .then(function (response) {
        let respData = response.data;
        console.log(respData);

        respData.forEach((element) => {
          element.model = element.carModel.model;
          element.discript = element.carModel.discript;
          element.status = element.status ==='Available' ? 'Khả dụng' : 'Xe đang đỗ'
          element.action = [
            <Button onClick={() => {
              showDrawer1();
              form1.setFieldsValue({
                carModelID: element.carModel.id,
                carNumber: element.carNumber,
              
              });
          
              setIdCar(element.id);
            }}>
            <EditFilled/>
            </Button>
            ,
            <Button disabled={element.status==='Xe đang đỗ'? true : false}
            className="buttonState"
           
            onClick={() => {
              Modal.confirm({
                title: "Bạn chắc chứ ?",
                icon: <CloseCircleOutlined style={{ color: "red" }} />,
                content: "Bạn muốn xóa thông tin của xe này ? ",
                okText: "Xóa",
                cancelText: "Hủy",
                okButtonProps: {
                  style: { background: "#e30c18", color: "white" },
                },

                onOk() {
                  return new Promise((resolve, reject) => {
                    setTimeout(Math.random() > 0.5 ? resolve : reject, 1000);
                    api
                      .delete(
                        `car/${element.id}`
                      )
                      .then(() => {
                        notification.success({
                          message: `Xóa thành công`,
                          description: "Xóa xe thành công",
                          placement: "topLeft",
                        });
                      })
                      .catch(() => {
                        notification.error({
                          message: `Xóa không thành công`,
                          description: "Không thể xóa xe này",
                          placement: "topLeft",
                        });
                      });
                    
                  });
                },
                onCancel() {},
              });
                
            }}
        >
            <CloseOutlined style={{color: 'red'}}/>
        </Button>,
            
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
  }, [data, form1]);
  useEffect(() => {
    api.get(`carmodels`)
    .then(function(response){
        setCarModel(response.data);
      }).catch((e)=>{notification.warning({
        message: `Lỗi dữ liệu`,
        description: "Tải dữ liệu bị lỗi",
        placement: "topLeft",
      });});
}, [])
  const finalData =
    searchText === ""
      ? data
      : data.filter((u) =>
          u.carNumber
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
    showTotal: (total) => `Tổng ${total} xe`,
  };
  const showDrawer = () => {
    setOpen(true);
  };
  const onClose = () => {
    setOpen(false);
  };

  const onFinish = (values) => {
    api
      .post(`car`, {
        carModelID: values.carModelID,
        carNumber: values.carNumber,
       
      })
      .then(() => {
        onClose();
        notification.success({
          message: `Thành công`,
          description: "Thêm xe cho bản thân thành công",
          placement: "topLeft",
        });

        form.setFieldsValue({
          carModelID : "",
          carNumber: "",
        });
        setOpen(false);
      
      })
      .catch((error) => {
        notification.warning({
          message: `Thất bài`,
          description: "Vui lòng kiểm tra lại thông tin",
          placement: "topLeft",
        });
        form.setFieldsValue({
          carModelID:"",
          carNumber:"",
         
        });
      });

      
  };
  const onFinishEdit = (values) => {
    api
      .put(`car/${idcar}`, {
        carModelID: values.carModelID,
        carNumber: values.carNumber,

        
      })
      .then(() => {
        // sessionStorage.setItem("changeStatus", true);
        notification.success({
          message: `Thành công`,
          description: "Chỉnh sửa thông tin xe thành công",
          placement: "topLeft",
        });
        form.setFieldsValue({
          carNumber: "",
          carModelID: "",
         
        });
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
          carNumber: "",
          carModelID: "",
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
        Danh sách xe
      </p>
      <Row gutter={45} style={{ marginBottom: "30px" }}>
        <Col xs={0} sm={8} md={7} lg={7} xl={6} xxl={5}>
          {/*Filter Role */}
         
        </Col>
        <Col xs={16} sm={8} md={7} lg={7} xl={8} xxl={8}>
          <Input.Search
            placeholder="Tìm thông tin xe"
            maxLength={255}
            allowClear
            onSearch={(e) => {
              setPage(1);
              setSearchText(e.replace(/ /g, ""));
            }}
          />
        </Col>
        <Col xs={8} sm={8} md={7} lg={7} xl={9} xxl={9}>
          <Button
            style={{ background: "#33CCFF", color: "white" }}
            onClick={() => {
              showDrawer();
              form.setFieldsValue({
                carNumber: "",
                model: "",
               
               
              });
            }}
          >
            Thêm xe 
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
        <Descriptions title="Thông tin xe" bordered>
        <Descriptions.Item label="Mã xe" span={3}>{modal.data.id}</Descriptions.Item>
    <Descriptions.Item label="Biển số xe"span={2} >{modal.data.carNumber}</Descriptions.Item>
    <Descriptions.Item label="Loại xe">{modal.data.model}</Descriptions.Item>
    <Descriptions.Item label="Mô tả" span={2}>{modal.data.discript}</Descriptions.Item>
    <Descriptions.Item label="Trạng thái" >{modal.data.status}</Descriptions.Item>
   
     <Descriptions.Item label="Lịch sử gửi xe" span={3}>
    {modal &&modal?.data?.parkingDetail?.map((e,index)=>(
       <><h4  style={{ color: " red"}}>{index+1}. Bãi đỗ: {e?.parking?.parkingName}</h4>
       Ngày đỗ xe: {dayjs(e?.parkingDate).format('DD/MM/YYYY')} <br/> 
       {e.pickUpDate ? <>Ngày lấy xe: {dayjs(e?.pickUpDate).format('DD/MM/YYYY')}  </>: 'Xe đang đỗ'}
       <p></p>
       </>
    ))}
   </Descriptions.Item> 
          </Descriptions>
    
      </Modal>

      {data.length === 0 ? (
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
                      status: record.status,
                      carNumber: record.carNumber,
                      model: record.model,
                      discript: record.discript,
                      parkingDetail : record.parkingDetail
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
                      status: record.status,
                      carNumber: record.carNumber,
                      model: record.model,
                      discript: record.discript,
                      parkingDetail : record?.parkingDetail? record?.parkingDetail :"Không có lịch sử đỗ xe",
                     
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
        title="Thêm xe mới"
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
                name="carModelID"
                label="Loại xe"
                rules={[
                  {
                    required: true,
                    message: "Vui lòng chọn loại xe",
                  },
                ]}
              >
            <Select
          placeholder="Chọn loại xe"
           
          virtual={false}
          >
            
            {carModel &&carModel?.map((u)=> (
                      <option value={u.id}>
                        {u.model}
                      </option>
                    ))}
          </Select>
          </Form.Item>
              
            </Col>
          </Row>
    
          <Row gutter={16}>
            <Col span={24}>
              <Form.Item
                name="carNumber"
                label="Biển số xe"
                rules={[
                  {
                    required: true,
                    message: "Vui lòng nhập biển số xe  ",
                  },
                ]}
              >
                <Input
                  style={{
                    width: "100%",
                  }}
                  placeholder="Nhập biển số xe "
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
                      carModelID:"",
                      carNumber:"",
                     
                    });
                  }}
                >
                  Hủy
                </Button>
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
        title="Sửa thông tin của xe"
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
                name="carModelID"
                label="Loại xe"
                rules={[
                  {
                    required: true,
                    message: "Vui lòng chọn loại xe",
                  },
                ]}
              >
            <Select
          placeholder="Chọn bãi đỗ"
           
          virtual={false}
          >
            
            {carModel.map((u)=> (
                      <option value={u.id}>
                        {u.model}
                      </option>
                    ))}
          </Select>
          </Form.Item>
            </Col>
          </Row>
          <Row gutter={16}>
            <Col span={24}>
              <Form.Item
                name="carNumber"
                label="Biển số xe"
                rules={[
                  {
                    required: true,
                    message: "Vui lòng nhập biển số xe",
                  },
                ]}
              >
                <Input placeholder="Nhập biển số xe" />
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
                  Hủy
                </Button>
                <Button onClick={onClose1} htmlType="submit" type="primary">
                  Lưu
                </Button>
              </Space>
            </Col>
          </Row>
        </Form>
      </Drawer>
    </>
  );
};

export default MyCar;
