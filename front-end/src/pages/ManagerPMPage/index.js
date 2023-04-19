import React, { useState, useEffect } from "react";
import { Table, Input, Button, Menu, Dropdown, Row, Col, Modal,Empty,notification,Form } from "antd";
import {
  FilterOutlined,
  RedoOutlined,ExclamationCircleFilled
} from "@ant-design/icons";
import moment from "moment";
import api from "../../services/api";
import AddPM from "../../containers/pages/ManageParking/AddPM";
export default function ManageParkingManager() {
  const [data, setData] = useState([]);
  const [searchText, setSearchText] = useState("");
  const [page, setPage] = useState(1);
  const [pageSize, setPageSize] = useState(10);
  const [type, setType] = useState("Gender");
  const [open, setOpen] = useState(false);
  const [infor,setInfor]=useState({
    fullname: "",
    userName:"",
    password:"",
    email:"",
    dateOfBirth:"",

});
  const [openInfo,setOpenInfor]=useState(false);
  const [modal, setModal] = useState({
    isOpen: false,
    data: {},
  });
  const columns = [
    {
        title: "ID",
        dataIndex: "id",
        key: "id",
        width: "15%",
      },
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
        title: "Vị trí",
        dataIndex: "role",
        key: "role",
      },
      {
        title: "Trạng thái",
        dataIndex: "trangthai",
        key: "trangthai",
        sorter: (a, b) => {
          if (a.trangthai > b.trangthai) {
            return -1;
          }
          if (b.trangthai > a.trangthai) {
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
    api.get(`parking-manager-of-owner`)
      .then(function (response) {
        let respData = response.data;
      

        respData.forEach((element) => {
            element.fullName = element.lastName + " " + element.firstName;
            element.role = element.role=== 'ParkingManager' ? 'Nhân viên' : " "
            element.trangthai = element.isDisable ? "Dừng hoạt động": "Đang hoạt động"
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

  const dataBytype = type === "Gender" ? data : data.filter((u) => u.gender === type);
  const finalData =
    searchText === ""
      ? dataBytype
      : (dataBytype.filter(
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
      showTotal: total => `Tổng ${total} nhân viên`
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
        <Col xs={8} sm={8} md={7} lg={7} xl={6} xxl={5}>
            {/*Filter Gender */}
        <Dropdown.Button
            placement="bottom"
            icon={<FilterOutlined />}
            overlay={
              <Menu>
                <Menu.Item
                  value="Male"
                  onClick={() => {
                    setType("Male");
                  }}
                >
                  {" "}
                  Male
                </Menu.Item>
                <Menu.Item
                  value="Female"
                  onClick={() => {
                    setType("Female");
                  }}
                >
                  {" "}
                  Female
                </Menu.Item>
                <Menu.Item
                  value="Other"
                  onClick={() => {
                    setType("Other");
                  }}
                >
                  {" "}
                  Other
                </Menu.Item>
                <Menu.Item
                  onClick={() => {
                    setType("Gender");
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
            placeholder="Tìm kiếm"
            maxLength={255}
            allowClear
            onSearch={(e) => {
              setPage(1);
              setSearchText(e.replace(/ /g, ""));
            }}
          />
        </Col>
        <Col xs={8} sm={8} md={7} lg={7} xl={9} xxl={9}>
          <Button style={{ background: "#33CCFF", color: "white" }} onClick={e => setOpen(true)} >
          Thêm nhân viên 
          </Button>
        </Col>
      </Row>
      
      <Modal
        open={modal.isOpen}
        title="Detail Student"
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
            <td style={{ width:"50px",fontSize: "18px", color: "#838688" }}>User Name</td>
            <td
              style={{
                fontSize: "18px",
                color: "#838688",
                textAlign: "justify",
                paddingLeft: "35px",
              }}
            >
              {modal.data.userName}
            </td>
          </tr>
          <tr>
            <td style={{width:"50px", fontSize: "18px", color: "#838688" }}>Full Name</td>
            <td
              style={{
                fontSize: "18px",
                color: "#838688",
                textAlign: "justify",
                paddingLeft: "35px",
              }}
            >
              {modal.data.fullName}
            </td>
          </tr>
          <tr>
            <td style={{width:"50px", fontSize: "18px", color: "#838688" }}>Phone Number</td>
            <td
              style={{
                fontSize: "18px",
                color: "#838688",
                textAlign: "justify",
                paddingLeft: "35px",
              }}
            >
              {modal.data.phoneNumber}
            </td>
          </tr>
          <tr>
            <td style={{width:"50px", fontSize: "18px", color: "#838688" }}>Email </td>
            <td
              style={{
                fontSize: "18px",
                color: "#838688",
                textAlign: "justify",
                paddingLeft: "35px",
              }}
            >
              {modal.data.email}
            </td>
          </tr>
          <tr>
            <td style={{width:"50px", fontSize: "18px", color: "#838688" }}>Gender</td>
            <td
              style={{
                fontSize: "18px",
                color: "#838688",
                textAlign: "justify",
                paddingLeft: "35px",
              }}
            >
              {modal.data.gender}
            </td>
          </tr>
          <tr>
            <td style={{width:"50px", fontSize: "18px", color: "#838688" }}>
              Date of Birth
            </td>
            <td
              style={{
                fontSize: "18px",
                color: "#838688",
                textAlign: "justify",
                paddingLeft: "35px",
              }}
            >
              {modal.data.dateOfBirth}
            </td>
          </tr>
        </table>
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
                      fullName: record.lastName+" "+record.firstName,
                      phoneNumber: record.phoneNumber,
                      dateOfBirth: record.dateOfBirth,
                      gender: record.gender,
                      email: record.email,

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
                        fullName: record.lastName+" "+record.firstName,
                        phoneNumber: record.phoneNumber,
                      dateOfBirth: record.dateOfBirth,
                      gender: record.gender,
                      email: record.email,
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
      {!open ? <></> : 
      <AddPM setOpen={setOpen} open={open} setInfor={setInfor} setOpenInfor={setOpenInfor} infor={infor} />
      }
        <Modal
        title="Thông tin"
        open={openInfo}
        footer={null}
        onCancel={()=>setOpenInfor(false)}
        onOk={()=>setOpenInfor(false) }
      >
           <Form
        >
          <Form.Item
            name="lastName"
            label="Họ tên:"
           
          > {infor.fullname}
            {/* <Input disabled /> */}
          </Form.Item>
          <Form.Item
            name="firstName"
            label="Tài khoản:"
             
          >
              {infor.userName}
          </Form.Item>
          

          <Form.Item
            name="userName"
            label="Password"
          >
            {infor.password}
          </Form.Item>
         
          <Form.Item
            name="email"
            label="E-mail :"
            
          >        
             {infor.email}
          </Form.Item>
          <Form.Item
            name="phoneNumber"
            label="Ngày sinh :"
           
          >
            {infor.dateOfBirth}
          </Form.Item>
          
         
          
        </Form>
        
              
               
                
               
               
      </Modal>
    </>
  );
}