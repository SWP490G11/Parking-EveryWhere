import React, { useState, useEffect } from "react";
import { Table, Input, Button, Menu, Dropdown, Row, Col, Modal } from "antd";
import {
  FilterOutlined,
  EditFilled,
  CloseCircleOutlined,
  CloseSquareOutlined,
  LoadingOutlined,
} from "@ant-design/icons";
import { Link } from "react-router-dom";
import axios from "axios";
import moment from "moment";


export default function ManageUser() {
  const [data, setData] = useState([]);
  const [searchText, setSearchText] = useState("");
  const [page, setPage] = useState(1);
  const [pageSize, setPageSize] = useState(10);
  const [type, setType] = useState("Gender");
  const [role, setRole] = useState("Role");
  const [modal, setModal] = useState({
    isOpen: false,
    data: {},
  });

  const columns = [
    {
        title: "ID",
        dataIndex: "id",
        key: "id",
       
      },
      {
        title: "FullName",
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
      title: "User Name",
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
      title: "Gender",
      dataIndex: "gender",
      key: "gender",
     
    },
   
    {
      title: "Date of Birth",
      dataIndex: "dateOfBirth",
      key: "dateOfBirth",
    },  
    {
      title: "Phone Number",
      dataIndex: "phoneNumber",
      key: "phoneNumber",
    },
    {
        title: "Role",
        dataIndex: "role",
        key: "role",
      },
    {
      title: "Action",
      dataIndex: "action",
      key: "action",
      
    },
  ];
  const [deleteModal, setDeleteModal] = useState({
    isOpen: false,
    title: "Notice",
    content: <p>Do you want to disable this account?</p>,
    footer: (
      <div style={{ textAlign: "left" }}>
        <Button className="buttonSave">Disable</Button>
       
      </div>
    ),
  });
  useEffect(() => {
    axios
      .get(
        `${process.env.REACT_APP_Backend_URI}api/User/GetAll`,
        {}
      )
      .then(function (response) {
        let respData = response.data;
        console.log(respData);

        respData.forEach((element) => {
            element.fullName = element.lastName + " " + element.firstName;
          element.dateOfBirth = moment(
            new Date(element.dateOfBirth).toLocaleDateString("en-US")
          ).format("DD/MM/YYYY");
          element.action = [
            <Link to={`/editUser/${element.studentId}`} id="editButton">
              <EditFilled style={{  fontSize: "25px" }} />
            </Link>,
            <CloseCircleOutlined
              onClick={() => {
                setDeleteModal({
                  ...deleteModal,
                  footer: (
                    <div >
                      <Button 
                        className="ant-btn ant-btn-danger"
                        onClick={() => {
                          axios
                            .put(
                              `${process.env.REACT_APP_Backend_URI}api/User/DisableOrActive?id=${element.id}`
                            )
                            .then(() => {
                              setDeleteModal({
                                ...deleteModal,
                                isOpen: false,
                              });
                              //window.location.reload();
                            })
                            .catch(() => {
                              setDeleteModal({
                                ...deleteModal,
                                isOpen: true,
                                footer: null,
                                title: "Can not disable user",
                                content: (
                                  <p>
                                    There are valid assignments belonging to
                                    this user. Please Close all assignments
                                    before disabling user.
                                  </p>
                                ),
                              });
                            });
                        }}
                      >
                        Disable
                      </Button>
                      
                    </div>
                  ),
                  isOpen: true,
                });
              }}
              style={{ color: "red", fontSize: "25px", marginLeft: "10px" }}
            />,
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
  }, [deleteModal,data]);
  //const[userInfor,setUserInfor]=useState([])
  // const userInfordata = (idz) => {
  //   axios.get(`${process.env.REACT_APP_Backend_URI}api/User/GetUser?id=${idz}`)
  //   .then(function(response) {
  //     setUserInfor(response.data);
      
  //   }).catch((error) => {
     
  //   })
  // };
  const dataBytype =
    type === "Gender" ? data : data.filter((u) => u.gender === type);
    const dataRole= role === "Role" ? dataBytype : dataBytype.filter((u) => u.role === role);
  const finalData =
    searchText === ""
      ? dataRole
      : (dataRole.filter(
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
      showTotal: total => `Total ${total} Student`
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
        User List
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
           {/*Filter Role */}
          <Dropdown.Button
            placement="bottom"
            icon={<FilterOutlined />}
            overlay={
                <Menu>
                <Menu.Item
               onClick={() => {
                 setRole("ParkingManager");
               }}
             >
               {" "}
               ParkingManager
             </Menu.Item>
             <Menu.Item
               onClick={() => {
                setRole("ParkingOwner");
               }}
             >
               {" "}
               ParkingOwner
             </Menu.Item>
             <Menu.Item
               onClick={() => {
                setRole("Customer");
               }}
             >
               {" "}
               Customer
             </Menu.Item>
             <Menu.Item
               onClick={() => {
                setRole("Admin");
               }}
             >
               {" "}
               Admin
             </Menu.Item>
             <Menu.Item
               onClick={() => {
                setRole("Role");
               }}
             >
               {" "}
               All
             </Menu.Item>
              </Menu>
            }
          >
            {role}
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
          <Button style={{ background: "#33CCFF", color: "white" }}>
            <Link to="/addStudent"> Add new Student</Link>
          </Button>
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
    </>
  );
}