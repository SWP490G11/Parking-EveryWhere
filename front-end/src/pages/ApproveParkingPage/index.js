import {Table, Modal, Button,Row,Col,Input,Dropdown,Menu,Empty} from 'antd';
import React, {useEffect, useState} from 'react';
import {CheckOutlined, CloseOutlined,FilterOutlined} from "@ant-design/icons";
import api from "../../services/api";

 const ApproveParking=()=> {
    const [data, setData] = useState([])
    const [modal, setModal] = useState({
        isOpen: false,
        data: {},
    });
    const [isModalVisible, setIsModalVisible] = useState(false);
    const [isModalCancelVisible, setIsModalCancelVisible] = useState(false);
    const [status,setStatus] = useState("Status");
    const [idCompleted, setIdCompleted] = useState();
    const [page, setPage] = useState(1);
    const [pageSize, setPageSize] = useState(10);
    const [searchText, setSearchText] = useState("");
    const showModal = () => {
        setIsModalVisible(true);
    };
    const handleOk = () => {
        setIsModalVisible(false);
        api.patch(`aprrove-parking/${idCompleted}`,{})
            .then((res) => {
                //window.location.reload();
                setIdCompleted(null)
            }).catch(() => {
        })
    };
    const handleCancel = () => {
        setIsModalVisible(false);
    };

    const handleCheckId = (id) => {
        setIdCompleted(id)
    }
//===============================================================
    const showModalDelete = () => {
        setIsModalCancelVisible(true);

    };
    const handleCheckDeleteId = (id) => {

        setIdCompleted(id)
    }
    const handleDeleteOk = () => {
        setIsModalCancelVisible(false);
        api.patch(`cancel-parking/${idCompleted}`, {})
            .then((res) => {
                setIdCompleted(null)

                //window.location.reload();
            }).catch((error) => {

        })
    }
    const handleCancelModal = () => {
        setIsModalCancelVisible(false);
    };
//===========================================================
//===============================================

    useEffect(() => {
        api.get(`pending-parkings`, {})
            .then((response) => {
                let respData = response.data
                console.log(respData);
                respData.forEach((element) => {
                    element.status = element.status === 'Pending' ? 'Chờ duyệt' : 'Từ chối';
                   // {element.status ==="Pending"?(<>Chờ duyệt</>):(<>Từ chối</>)}
                  
                    element.action = [
                        <Button
                            className='buttonState'
                            disabled={element.status === 'Cancel'}
                            onClick={() => {
                                showModal()
                                handleCheckId(element.parkingID)
                            }}
                        >
                            <CheckOutlined
                                style={{color: 'red'}}
                            />
                        </Button>,
                        <Button
                            style={{paddingLeft:"10px"}}
                            className="buttonState"
                            // disabled={element.status === 'Pending' || element.isInProgress === false}
                            onClick={() => {
                                showModalDelete()
                                handleCheckDeleteId(element.parkingID)
                            }}
                        >
                            <CloseOutlined/>
                        </Button>
                      

                    ]
                })
                setData(response.data);


            })
            .catch((error) => {

            })
    }, [data])

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
            dataIndex: "status",
            key: "status",
            sorter: (a, b) => {
                if (a.status > b.status) {
                    return -1;
                }
                if (b.status > a.status) {
                    return 1;
                }
                return 0;
            },
        },
        {
            title: "Phê duyệt",
            dataIndex: "action",
            key: "action",
        },
    ];
    const dataByStatus =
        status === "Status" ? data : data.filter((u) => u.status === status);
    const finalData =
    searchText === ""
      ? dataByStatus
      : (dataByStatus.filter(
          (u) =>
            u.parkingName
              .toLowerCase()
              .replace(/\s+/g, "")
              .includes(searchText.toLowerCase().replace(/\s+/g, "")) ||
            u.addressDetail.toLowerCase().replace(/\s+/g, "").includes(searchText.toLowerCase().replace(/\s+/g, ""))
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
          showTotal: total => `Total ${total} Request`
      };
    return (
        <>
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
                    setStatus("Pending");
                  }}
                >
                  {" "}
                  Chờ duyệt
                </Menu.Item>
                <Menu.Item
                  value="Female"
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
                return <>Tất cả</>
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
            onSearch={(e) => {
              setPage(1);
              setSearchText(e.replace(/ /g, ""));
            }}
          />
        </Col>
        </Row>
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
            <Modal
                
                title="Phê duyệt" visible={isModalVisible} okText="Yes" cancelText="No" onOk={handleOk}
                onCancel={handleCancel}
                footer={[
                    <div style={{textAlign: "right"}}>
                        <Button key="Yes" onClick={handleOk} className="buttonSave">Đồng ý</Button>
                        <Button key="No" onClick={handleCancel} className='buttonCancel'>Đóng</Button>
                    </div>
                ]}>
                <p style={{textAlign: "center"}}>Bạn đồng ý phê duyệt cho bãi đỗ này</p>
            </Modal>
            <Modal
                title="Từ chối" visible={isModalCancelVisible} okText="Yes" cancelText="No" onOk={handleDeleteOk}
                onCancel={handleCancelModal}
                footer={[
                    <div style={{textAlign: "right"}}>
                        <Button key="Yes" onClick={handleDeleteOk} className="buttonSave">Từ chối</Button>
                        <Button key="No" onClick={handleCancelModal} className=' buttonCancel'>Đóng</Button>
                    </div>
                ]}>
                 <p style={{textAlign: "center"}}>Bạn từ chối phê duyệt cho bãi đỗ này</p>
            </Modal>
          


            <div>
                <h1 style={{color: "red", float: "left"}}>Manage Aprrove Request</h1>
                {finalData.length === 0 ? (
        <Empty description={"Không có dữ liệu"}/>
      ) : (
                <Table
                    columns={columns}
                    pagination={pagination}
                    dataSource={finalData}
                    onRow={(record) => {
                        return {
                            onClick: (e) => {


                                if (e.target.className !== 'ant-table-cell ant-table-cell-row-hover') {
                                    setModal({...modal, isOpen: false})
                                } else {

                                    setModal({
                                        ...modal, isOpen: true
                                        , data: {
                                            parkingName: record.parkingName,
                                            addressDetail: record.addressDetail,
                                            description: record.discription,
                                            latitude: record.lat,
                                            longitude: record.lon,
                                            image: record.imageUrls,
                                            status: record.status,
                                            isLegal: record.isLegal,
                                        }

                                    });

                                }


                            }
                        }
                    }}
                >

                </Table>
      )}
            </div>


        </>
    )
}
export default ApproveParking;