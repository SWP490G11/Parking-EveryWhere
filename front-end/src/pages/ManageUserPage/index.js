import React, { useState, useEffect } from "react";
import { Table, Input, Button, Menu, Dropdown,Descriptions, Row, Col, Modal,Empty,notification,Form } from "antd";
import {
  FilterOutlined,
  RedoOutlined,ExclamationCircleFilled
} from "@ant-design/icons";
import moment from "moment";
import api from "../../services/api";
import AddPM from "../../containers/pages/ManageParking/AddPM";
export default function ManageUser() {
  const [data, setData] = useState([]);
  const [searchText, setSearchText] = useState("");
  const [page, setPage] = useState(1);
  const [pageSize, setPageSize] = useState(10);
  const [type, setType] = useState("Tất cả");
  const [disable,setDisable] = useState("Tất cả");
  const [role,setRole] = useState("Tất cả");
  const [modal, setModal] = useState({
    isOpen: false,
    data: {},
  });
  const columns = [
    
      {
        title: "Họ tên",
        dataIndex: "fullName",
        key: "fullName",
        sorter: (a, b) => {
          if (a.fullName > b.fullName) {
            return -1;
          }
          if (b.fullName > a.fullName) {
            return 1;
          }
          return 0;
        },
      },
    {
      title: "Tài khoản",
      dataIndex: "userName",
      key: "userName",

      sorter: (a, b) => {
        if (a.userName > b.userName) {
          return -1;
        }
        if (b.userName > a.userName) {
          return 1;
        }
        return 0;
      },
      width: "10%",
    },
    {
      title: "Giới tính",
      dataIndex: "gender",
      key: "gender",
     
    },
   
    {
      title: "Ngày sinh",
      dataIndex: "dateOfBirth",
      key: "dateOfBirth",
    },  
    {
      title: "Số điện thoại",
      dataIndex: "phoneNumber",
      key: "phoneNumber",
    },
    
    {
        title: "Vai trò",
        dataIndex: "role",
        key: "role",
      },
      {
        title: "Trạng thái",
        dataIndex: "isDisable",
        key: "isDisable",
        sorter: (a, b) => {
          if (a.isDisable > b.isDisable) {
            return -1;
          }
          if (b.isDisable > a.isDisable) {
            return 1;
          }
          return 0;
        },
        width: "10%",
      },
      
    {
      title: " ",
      dataIndex: "action",
      key: "action",
      
    },
  ];

  const showPromiseConfirm = (ID) => {
    Modal.confirm({
      title: 'Thay đổi trạng thái của người dùng',
      icon: <ExclamationCircleFilled />,
      content: 'Bạn có muốn thay đổi trạng thái của người này không',
      onOk() {
        return new Promise((resolve, reject) => {
          setTimeout(Math.random() > 0.5 ? resolve : reject, 1000);
          api.patch(`api/User/DisableOrActive?id=${ID}`).then(()=>{notification.success({
            message: `Thành công`,
            description: 'Thay đổi trạng thái thành cong',
            placement: 'topLeft',
          });}).catch(()=>{
            notification.error({
              message: `Thất bại`,
              description: 'Thay đổi trạng thái thất bại',
              placement: 'topLeft',
            });
          });
        }).catch(() => console.log('Xảy ra lỗi'));
      },
      onCancel() {},
    });
  };
  useEffect(() => {
    api.get(`api/User/GetAll`)
      .then(function (response) {
        let respData = response.data;
      

        respData.forEach((element) => {
            element.fullName = element.lastName + " " + element.firstName;
            element.role = element.role=== 'ParkingManager' ? 'Nhân viên' :
            (element.role=== 'ParkingOwner'? 'Chủ bãi đỗ': 
            (element.role=== 'Admin'? 'Quản trị viên':'Người dùng' ) );
               //element.gender = element.gender === 'Male' ? 'Nam' : (element.gender === 'Female'? 'Nữ' : 'Khác');
            element.gender = element.gender === 'Male' ? 'Nam' : (element.gender === 'Female'? 'Nữ' : 'Khác');
            //element.parkingName = element?.parking?.parkingName;
            element.isDisable = element.isDisable ? "Dừng hoạt động": "Đang hoạt động"
          element.dateOfBirth = moment(
            new Date(element.dateOfBirth).toLocaleDateString("en-US")
          ).format("DD/MM/YYYY");
          element.action = [
           
            <Button 
            className="ant-btn ant-btn-danger"
            onClick={() => { 
             
              showPromiseConfirm(element.id);
            }}
          >
            <RedoOutlined               
            />
          </Button>
            
          ];
        });
        
        setData(
          respData.sort((a, b) => {
            if (
              a.userName.trim().toLowerCase() >
              b.userName.trim().toLowerCase()
            ) {
              return 1;
            }
            if (
              b.userName.trim().toLowerCase() >
              a.userName.trim().toLowerCase()
            ) {
              return -1;
            }
            return 0;
          })
        );
      }, [])
      .catch(() => {});
  }, [data]);

  const dataBytype = type === "Tất cả" ? data : data.filter((u) => u.gender === type);
  
  const dataDisable = disable === "Tất cả" ? dataBytype : dataBytype.filter((u) => u.isDisable === disable);
  const dataByRole = role === "Tất cả" ? dataDisable : dataDisable.filter((u) => u.gender === type);
  const finalData =
    searchText === ""
      ? dataByRole
      : (dataByRole.filter(
          (u) =>
            u.userName
              .toLowerCase()
              .replace(/\s+/g, "")
              .includes(searchText.toLowerCase().replace(/\s+/g, "")) ||
            u.id.toLowerCase().includes(searchText.toLowerCase())
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
      showTotal: total => `Tổng ${total} người dùng`
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
        Danh sách nhân viên
      </p>
      <Row gutter={45} style={{ marginBottom: "30px" }}>
        <Col span={13}>
          <Row>
            <Col span={8}>
            <Form.Item label={'Giới tính'}>
        <Dropdown.Button
            placement="bottom"
            icon={<FilterOutlined />}
            overlay={
              <Menu>
                <Menu.Item
                  value="Male"
                  onClick={() => {
                    setType("Nam");
                  }}
                >
                  {" "}
                  Nam
                </Menu.Item>
                <Menu.Item
                  value="Female"
                  onClick={() => {
                    setType("Nữ");
                  }}
                >
                  {" "}
                  Nữ
                </Menu.Item>
                <Menu.Item
                  value="Other"
                  onClick={() => {
                    setType("Khác");
                  }}
                >
                  {" "}
                  Khác
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
            {type}
          </Dropdown.Button>
          </Form.Item>
            </Col>
            <Col span={8}>
            <Form.Item label={'Trạng thái'}>
        <Dropdown.Button
            placement="bottom"
            icon={<FilterOutlined />}
            overlay={
              <Menu>
                <Menu.Item
                  value="Male"
                  onClick={() => {
                    setDisable("Đang hoạt động");
                  }}
                >
                  {" "}
                  Đang hoạt động
                </Menu.Item>
                <Menu.Item
                  value="Female"
                  onClick={() => {
                    setDisable("Dừng hoạt động");
                  }}
                >
                  {" "}
                  Dừng hoạt động
                </Menu.Item>
                
                <Menu.Item
                  onClick={() => {
                    setDisable("Tất cả");
                  }}
                >
                  {" "}
                  Tất cả
                </Menu.Item>
              </Menu>
            }
          >
            {disable}
          </Dropdown.Button>
          </Form.Item>
      
            </Col>
            <Col span={8}>
            <Form.Item label={'Vai trò'}>
        <Dropdown.Button
            placement="bottom"
            icon={<FilterOutlined />}
            overlay={
              <Menu>
                <Menu.Item
                  value="Male"
                  onClick={() => {
                    setRole("Quản trị viên");
                  }}
                >
                  {" "}
                  Quản trị viên
                </Menu.Item>
                <Menu.Item
                  value="Female"
                  onClick={() => {
                    setRole("Người dùng");
                  }}
                >
                  {" "}
                  Người dùng
                </Menu.Item>
                <Menu.Item
                  value="Female"
                  onClick={() => {
                    setRole("Chủ bãi xe");
                  }}
                >
                  {" "}
                  Chủ bãi xe
                </Menu.Item>
                <Menu.Item
                  value="Female"
                  onClick={() => {
                    setRole("Nhân viên");
                  }}
                >
                  {" "}
                  Nhân viên
                </Menu.Item>
                <Menu.Item
                  onClick={() => {
                    setRole("Tất cả");
                  }}
                >
                  {" "}
                  Tất cả
                </Menu.Item>
              </Menu>
            }
          >
            {role}
          </Dropdown.Button>
          </Form.Item>
      
            </Col>
          </Row>
            {/*Filter Gender */}
            
         
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
        <Descriptions title="Thông tin nhân viên" bordered>
        <Descriptions.Item label="ID" span={3}>{modal.data.id}</Descriptions.Item>
    <Descriptions.Item label="Tài khoản" span={1.5}>{modal.data.userName}</Descriptions.Item>
    <Descriptions.Item label="Trạng thái" span={1.5}>{modal.data.isDisable}</Descriptions.Item>
    <Descriptions.Item label="Họ tên"span={1.5} > {modal.data.fullName}</Descriptions.Item>
    <Descriptions.Item label="Số điện thoại" span={1.5}>{modal.data.phoneNumber}</Descriptions.Item>
    <Descriptions.Item label="E-mail" span={1.5}>{modal.data.email}</Descriptions.Item>
    <Descriptions.Item label="Giới tính" span={1.5}>{modal.data.gender}</Descriptions.Item>
    <Descriptions.Item label="Ngày sinh" span={1.5}>{modal.data.dateOfBirth}</Descriptions.Item>
    <Descriptions.Item label="Vai trò" span={1.5}>{modal.data.role}</Descriptions.Item>
    {modal?.data?.parking ?   <Descriptions.Item label="Nhân viên bãi đõ" span={3}>{modal.data.parking}</Descriptions.Item>: ""}
    {modal?.data?.parkings ?   <Descriptions.Item label="Chủ bãi đỗ" span={3}>{modal.data.parkings.filter(u=>u.status==='Available').map((e,index)=>(
    <>{index+1}. Bãi đỗ {e.parkingName} - Địa chỉ: {e.addressDetail}  <br/></>)) }</Descriptions.Item>: ""}
   
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
                        userName: record.userName,
                        isDisable : record.isDisable,
                      fullName: record.lastName+" "+record.firstName,
                      phoneNumber: record.phoneNumber,
                      dateOfBirth: record.dateOfBirth,
                      role: record.role,
                      parkings: record.role==='Chủ bãi đỗ' ? record.parkings:"",
                      parking: record.role==='Nhân viên' ? record.parking.parkingName:"",
                      gender: record.gender,
                      email: record.email,
                      parkingName: record.parkingName
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
                        userName: record.userName,
                        isDisable : record.isDisable,
                      fullName: record.lastName+" "+record.firstName,
                      phoneNumber: record.phoneNumber,
                      dateOfBirth: record.dateOfBirth,
                      role: record.role,
                      parkings: record.role==='Chủ bãi đỗ' ? record.parkings:"",
                      parking: record.role==='Nhân viên' ? record.parking.parkingName:"",
                      gender: record.gender,
                      email: record.email,
                      parkingName: record.parkingName
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
     
       
    </>
  );
}