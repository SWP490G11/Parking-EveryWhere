import React, { useState, useEffect } from "react";
import { Table, Input, Button, Menu, Dropdown, Row, Col, Modal,Empty } from "antd";
import {
  FilterOutlined,
  EditFilled,
  CloseSquareOutlined,
} from "@ant-design/icons";
import { useNavigate } from "react-router-dom";
import { toRoute } from '../../utils/helpers';
import api from "../../services/api";
import { routes } from '../../utils/routes';
import AddSlot from "../../containers/pages/ManageParking/AddSlot";
export default function ManageParking() {
  const [data, setData] = useState([]);
  const navigateTo = useNavigate();
  const [searchText, setSearchText] = useState("");
  const [page, setPage] = useState(1);
  const [open, setOpen] = useState(false);
  const [pageSize, setPageSize] = useState(10);
  const [status,setStatus]= useState("Status");
  const [modal, setModal] = useState({
    isOpen: false,
    data: {},
  });
  const [parkingID,setParkingID] = useState("");
  const [parkingName,setParkingName] = useState("");
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
    },
    {
        title: "Trạng thái",
        dataIndex: "statuz",
        key: "statuz",
        sorter: (a, b) => {
            if (a.statuz > b.statuz) {
                return -1;
            }
            if (b.statuz > a.statuz) {
                return 1;
            }
            return 0;
        },
    },
    {
        title: "Hành động",
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
    api.get(`parkings-of-owner`)
      .then(function (response) {
        let respData = response.data;
        console.log(respData);  
        respData.forEach((element) => {
          element.parkingmanager= element.parkingManagers.userName;
          element.action = [
             <Button className='buttonState'
             onClick={e => navigateTo(toRoute(routes.PARKING_DETAIL_UPDATE, { parkingID: element.parkingID }))}
                        >
                        <EditFilled/>
                </Button>,
          ];
          switch(element.status) {
            case 'Pending':
              return element.statuz = 'Chờ duyệt'
            case 'Cancel':
              return element.statuz = 'Từ chối'
            case 'Available':
              return element.statuz = 'Khả dụng'
            default:
              return null
          };
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
                  Khả dụng
                </Menu.Item>
                <Menu.Item
                  value="Pending"
                  onClick={() => {
                    setStatus("Pending");
                  }}
                >
                  {" "}
                  Chờ duyệt
                </Menu.Item>
                <Menu.Item
                  value="Cancel"
                  onClick={() => {
                    setStatus("Cancel");
                  }}
                >
                  {" "}
                  Từ chối
                </Menu.Item>
               
                <Menu.Item
                  onClick={() => {
                    setStatus("Status");
                  }}
                >
                  {" "}
                  Tất cả
                </Menu.Item>
              </Menu>
            }
          >   {(() => {
            switch(status) {
              case 'Status':
                return <p>Tất cả</p>
              case 'Pending':
                return <>Chờ duyệt</>
              case 'Cancel':
                return <>Từ chối</>
              default:
                return null
            }
          })}
          </Dropdown.Button>
        </Col>
        <Col xs={8} sm={8} md={7} lg={7} xl={8} xxl={8}>
          <Input.Search
            placeholder="Search User"
            maxLength={255}
            allowClear
            onChange={e => {
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
                visible={modal.isOpen}
                title='Thông tin bãi đỗ'
                onCancel={()=>{setModal({...modal,isOpen:false})}}
                // closeIcon={<CloseSquareOutlined style={{color: "red", fontSize: "20px"}}/>}
                footer={
                    null
                }
            >
                <table>
                    <tr>
                        <td style={{fontSize: '18px', color: '#838688'}}>Tên Bãi Đỗ</td>
                        <td style={{
                            fontSize: '18px',
                            color: '#838688',
                            textAlign: 'justify',
                            paddingLeft: '35px'
                        }}>{modal.data.parkingName}</td>
                    </tr>
                    
                    <tr>
                        <td style={{fontSize: '18px', color: '#838688'}}>Địa chỉ</td>
                        <td style={{
                            fontSize: '18px',
                            color: '#838688',
                            textAlign: 'justify',
                            paddingLeft: '35px'
                        }}>{modal.data.addressDetail}</td>
                    </tr>
                    <tr>
                        <td style={{fontSize: '18px', color: '#838688'}}>Thông tin thêm</td>
                        <td style={{
                            fontSize: '18px',
                            color: '#838688',
                            textAlign: 'justify',
                            paddingLeft: '35px'
                        }}>{modal.data.description}</td>
                    </tr>
                    <tr>
                        <td style={{fontSize: '18px', color: '#838688'}}> Tọa độ</td>
                        <td style={{
                            fontSize: '18px',
                            color: '#838688',
                            textAlign: 'justify',
                            paddingLeft: '35px'
                        }}>{modal.data.latitude} - {modal.data.longitude}</td>
                    </tr>

                    <tr>

                        <td style={{fontSize: '18px', color: '#838688'}}>Trạng thái</td>
                        <td style={{
                            fontSize: '18px',
                            color: '#838688',
                            textAlign: 'justify',
                            paddingLeft: '35px'
                        }}>{modal.data.status}</td>
                    </tr>
                    <tr>
                        <td style={{fontSize: '18px', color: '#838688'}}>Hợp pháp</td>
                        <td style={{
                            fontSize: '18px',
                            color: '#838688',
                            textAlign: 'justify',
                            paddingLeft: '35px'
                        }}>{
                        modal.data.isLegal ===true ? (<>Hợp pháp</>): (<>Không hợp pháp</>)
                        }</td>
                    </tr>
                </table>


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
           expandable={{
            
            expandedRowRender: (record) => (
              <p
                style={{
                  margin: 0,
                }}
              >
                
               <Button  onClick={e => {setOpen(true);setParkingID(record.parkingID);setParkingName(record.parkingName);
                
              }}>Thêm slot</Button>
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
                      addressDetail: record.addressDetail,
                      description: record.discription,
                      latitude: record.lat,
                      longitude: record.lon,
                      image: record.imageUrls,
                      status: record.statuz,
                      isLegal: record.isLegal,
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
                      addressDetail: record.addressDetail,
                      description: record.discription,
                      latitude: record.lat,
                      longitude: record.lon,
                      image: record.imageUrls,
                      status: record.statuz,
                      isLegal: record.isLegal,
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
      <AddSlot setOpen={setOpen} open={open} parkingID={parkingID} parkingName={parkingName}/>
      }
    </>
  );
}