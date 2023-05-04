import {Table, Modal, Button,Row,Col,Input,Empty,Descriptions,notification,Spin} from 'antd';
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
    //const [status,setStatus] = useState("Tất cả");
    const [loading, setLoading] = useState(true);
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
                notification.success({
                    message: `Thành công`,
                    description: 'Bạn đã chấp thuận bãi đỗ',
                    placement: 'topLeft',
                  })
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
                notification.warning({
                    message: `Thất bại`,
                    description: 'Bạn đã từ chối phê duyệt bãi đỗ',
                    placement: 'topLeft',
                  })
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
                  
                  
                    element.action = [
                        <Button disabled={element.status==="Từ chối"? true : false}
                            className='buttonState'
                           
                            onClick={() => {
                                showModal()
                                handleCheckId(element.parkingID)
                            }}
                        >
                            <CheckOutlined
                                style={{color: 'red'}}
                            />
                        </Button>,
                        <Button disabled={element.status==="Từ chối"? true : false}
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
                setLoading(false);

            })
            .catch(() => {
                setLoading(false);

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
    // const dataByStatus =
    //     status === "Status" ? data : data.filter((u) => u.status === status);
    const finalData =
    searchText === ""
      ? data
      : (data.filter(
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
    //   const renderContent = () => {
    //     switch(status) {
    //         case 'Status':
    //           return 'Tất cả'
    //         case 'Pending':
    //           return 'Chờ duyệt'
    //         case 'Cancel':
    //           return 'Từ chối'
    //         default:
    //           return 'Tất cả'
    //       }
    //   };
    return (
        <>
         <Spin spinning={loading} size="large" tip="Vui lòng đợi..."> 
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
        Danh sách yêu câu bãi đỗ cần phê duyệt
      </p>
        <Row gutter={45} style={{ marginBottom: "30px" }}>
        <Col span={8}>
            {/*Filter Gender */}
            {/* <Form.Item label={'Trạng thái'}>
            <Dropdown.Button
            placement="bottom"
            icon={<FilterOutlined />}
            overlay={
              <Menu>
                <Menu.Item
                  value="Male"
                  onClick={() => {
                    setStatus("Chờ duyệt");
                  }}
                >
                  {" "}
                  Chờ duyệt
                </Menu.Item>
                <Menu.Item
                  value="Female"
                  onClick={() => {
                    setStatus("Từ chối");
                  }}
                >
                  {" "}
                  Từ chối
                </Menu.Item>
               
                <Menu.Item
                  onClick={() => {
                    setStatus("Tất cả");
                  }}
                >
                  {" "}
                  Tất cả
                </Menu.Item>
              </Menu>
            }
          > 
          {status}
            
          </Dropdown.Button>
            </Form.Item> */}
        
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
        <Col span={8}></Col>
        </Row>
        
        {/*Infor parking*/} 
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
        <Descriptions title="Thông tin bãi đỗ" bordered>
        <Descriptions.Item label="Tên Bãi Đỗ" span={3}>{modal.data.parkingName}</Descriptions.Item>
    <Descriptions.Item label="Trạng thái" >{modal.data.status}</Descriptions.Item>
    <Descriptions.Item label="Tọa độ" span={2}>{modal.data.latitude} - {modal.data.longitude}</Descriptions.Item>
    <Descriptions.Item label="Địa chỉ" span={3} >{modal.data.addressDetail}</Descriptions.Item>
    <Descriptions.Item label="Thông tin thêm" span={3}>{modal.data.description}</Descriptions.Item>
   
    </Descriptions>
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

                    </Spin>
        </>
    )
}
export default ApproveParking;