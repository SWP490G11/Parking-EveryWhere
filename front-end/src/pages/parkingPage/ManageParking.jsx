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


export default function ManageParking() {
  const [data, setData] = useState([]);
  const [searchText, setSearchText] = useState("");
  const [page, setPage] = useState(1);
  const [pageSize, setPageSize] = useState(10);
  const [status,setStatus]= useState("Status");
  const [modal, setModal] = useState({
    isOpen: false,
    data: {},
  });

  const columns = [
      {
        title: "Parking Name",
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
      },
   
    {
      title: "Address Detail",
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
    },
   
    {
      title: "Status",
      dataIndex: "status",
      key: "status",
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
    content: <p>Do you want to disable student?</p>,
    footer: (
      <div style={{ textAlign: "left" }}>
        <Button className="buttonSave">Disable</Button>
       
      </div>
    ),
  });
  useEffect(() => {
    axios
      .get(
        `${process.env.REACT_APP_Backend_URI}parkings-of-owner`,
        {}
      )
      .then(function (response) {
        let respData = response.data;
        console.log(respData);
        respData.forEach((element) => {
          element.parkingmanager= element.parkingManagers.userName;
         
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
                              `${process.env.REACT_APP_Backend_URI}api/Student/Diable/${element.studentId}`
                            )
                            .then(() => {
                              setDeleteModal({
                                ...deleteModal,
                                isOpen: false,
                              });
                              window.location.reload();
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
  }, [deleteModal]);

  const dataBystatus =
  status === "Status" ? data : data.filter((u) => u.status === status);
  const finalData =
    searchText === ""
      ? dataBystatus
      : (dataBystatus.filter(
          (u) =>
            u.parkingName
              .toLowerCase()
              .replace(/\s+/g, "")
              .includes(searchText.toLowerCase().replace(/\s+/g, "")) 
              // || u.id.toLowerCase().includes(searchText.toLowerCase())
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
        Manage Parking
      </p>
      <Row gutter={45} style={{ marginBottom: "30px" }}>
        <Col xs={8} sm={8} md={7} lg={7} xl={6} xxl={5}>
        <Dropdown.Button
            placement="bottom"
            icon={<FilterOutlined />}
            overlay={
              <Menu>
                <Menu.Item
                  value="Available"
                  onClick={() => {
                    setStatus("Available");
                  }}
                >
                  {" "}
                  Available
                </Menu.Item>
                <Menu.Item
                  value="NotAvailable"
                  onClick={() => {
                    setStatus("NotAvailable");
                  }}
                >
                  {" "}
                  Not Available
                </Menu.Item>
                
                <Menu.Item
                  onClick={() => {
                    setStatus("Status");
                  }}
                >
                  {" "}
                  All
                </Menu.Item>
              </Menu>
            }
          >
            {status}
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
        </table> */}
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
          // key="id"
          rowKey={(data) => data.parkingName}
          columns={columns}
          pagination={pagination}
          dataSource={finalData}
           expandable={{
            expandedRowRender: (record) => (
              <p
                style={{
                  margin: 0,
                }}
              >
               Hello
              </p>
            )
               }}
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
                      parkingmanager: record.parkingmanager,
                      addressDetail: record.addressDetail,
                      status: record.status,
                    
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
                      parkingmanager: record.parkingmanager,
                      addressDetail: record.addressDetail,
                      status: record.status,
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