import {Table, Modal, Button,Row,Col,Input,notification,Menu,Dropdown,Form} from 'antd';

import React, {useEffect, useState} from 'react';
import {ExclamationCircleFilled, CloseOutlined,CheckOutlined, CloseSquareOutlined,FilterOutlined} from "@ant-design/icons";
import moment from "moment";
import api from "../../services/api";
 const ManageParkingDetail=()=> {
    const [data, setData] = useState([])
    const [modal, setModal] = useState({
        isOpen: false,
        data: {},
    });
   
    const [page, setPage] = useState(1);
    const [pageSize, setPageSize] = useState(10);
    const [searchText, setSearchText] = useState("");
    const [status,setStatus] = useState("Status");
    const handleDeleteOk = (id) => {
       
        api
            .patch(`request/cancel-request/${id}`)
            .then((res) => {
                
                notification.success({
                    message: `Thành công`,
                    description: "Bạn đã hủy yêu cầu",
                    placement: "topLeft",
                  });
                //window.location.reload();
            }).catch((error) => {
                notification.warning({
                    message: `Thât bại`,
                    description: "Vui lòng thử lại",
                    placement: "topLeft",
                  });
        })
    }
    const showPromiseDelete = (id) => {
        Modal.confirm({
          title: 'Bạn  muốn từ chối yêu cầu ?',
          icon: <ExclamationCircleFilled />,
          okText: 'Đồng ý',
    okType: 'danger',
    cancelText: 'Hủy',
          content: 'Bạn sẽ từ chối yêu cầu của khách hàng !',
          onOk() {
            return new Promise((resolve, reject) => {
                handleDeleteOk(id);
              setTimeout(Math.random() > 0.5 ? resolve : reject, 1000);
            }).catch(() => console.log('Oops errors!'));
          },
          onCancel() {},
        });
      };
      const showPromiseOk = (id) => {
        Modal.confirm({
          title: 'Bạn  muốn chấp thuận yêu cầu ?',
          icon: <ExclamationCircleFilled />,
          okText: 'Đồng ý',
    
            cancelText: 'Hủy',
          content: 'Bạn sẽ chấp thuận yêu cầu của khách hàng !',
          onOk() {
            return new Promise((resolve, reject) => {
                api
            .patch(`request/aprove-request/${id}`)
            .then((res) => {
                
                notification.success({
                    message: `Thành công`,
                    description: "Bạn đã hủy yêu cầu",
                    placement: "topLeft",
                  });
                //window.location.reload();
            }).catch((error) => {
                notification.warning({
                    message: `Thât bại`,
                    description: "Vui lòng thử lại",
                    placement: "topLeft",
                  });
        }) 
              setTimeout(Math.random() > 0.5 ? resolve : reject, 1000);
            }).catch(() => console.log('Oops errors!'));
          },
          onCancel() {},
        });
      };
//===========================================================
//===============================================

    useEffect(() => {
        api.get(`pending-request-of-all-parkings-of-owner`, {})
        .then(function(response)  {
            let respData = response.data
            respData.forEach((element) => {
                //element.state = element.state === 'WaitingForAcceptance' ? 'Waiting For Acceptance' : element.state;
                element.requestAt = moment(new Date(element.requestAt).toLocaleDateString("en-US")).format('DD/MM/YYYY');
                element.status = element.status === 'Pending' ? 'Chờ duyệt' : 'Từ chối';
                element.parkingName = element.parkingId.parkingName;
                


                element.action = [
                    <Button disabled={(element.status==="Từ chối"||element.status==="Chấp nhận") ? true : false}
                    className="buttonState"
                   
                    onClick={() => {
                        showPromiseOk(element.id);
                        
                    }}
                >
                   <CheckOutlined style={{color:"green"}} />
                </Button>,
                    <Button disabled={(element.status==="Từ chối"||element.status==="Chấp nhận")? true : false}
                        className="buttonState"
                       
                        onClick={() => {
                            showPromiseDelete(element.id);
                            
                        }}
                    >
                        <CloseOutlined/>
                    </Button>,
                  

                ]
            })
            setData(respData.sort((a, b) => {
                if (a.parkingId.parkingName.trim().toLowerCase() > b.parkingId.parkingName.trim().toLowerCase()) {
                  return 1;
                }
                if (b.parkingId.parkingName.trim().toLowerCase() > a.parkingId.parkingName.trim().toLowerCase()) {
                  return -1;
                }
                return 0;
              })
            );
          }, [])
        .catch((error) => {

        })
}, [])

    const columns = [
        {
            title: "Mã số",
            dataIndex: "id",
            key: "id",
            sorter: (a, b) => {
                if (a.id > b.id) {
                    return -1;
                }
                if (b.id > a.id) {
                    return 1;
                }
                return 0;
            },
            width: "15%",
        },
        {
            title: "Biển số xe",
            dataIndex: "carNumber",
            key: "carNumber",
            sorter: (a, b) => {
                if (a.carNumber > b.carNumber) {
                    return -1;
                }
                if (b.carNumber > a.carNumber) {
                    return 1;
                }
                return 0;
            },
        },

        {
            title: "Ngày gửi ",
            dataIndex: "parkingDate",
            key: "parkingDate",
            sorter: (a, b) => {
                if (a.parkingDate > b.parkingDate) {
                    return -1;
                }
                if (b.parkingDate > a.parkingDate) {
                    return 1;
                }
                return 0;
            },
        },
        
        {
            title: "Nội dung",
            dataIndex: "note",
            key: "note",
            sorter: (a, b) => {
                if (a.note > b.note) {
                    return -1;
                }
                if (b.note > a.note) {
                    return 1;
                }
                return 0;
            },
        },
        {
            title: "Trạng thái",
            dataIndex: "totalPrice",
            key: "totalPrice",
            sorter: (a, b) => {
                if (a.totalPrice > b.totalPrice) {
                    return -1;
                }
                if (b.totalPrice > a.totalPrice) {
                    return 1;
                }
                return 0;
            },
        },
        {
            title: "Action",
            dataIndex: "action",
            key: "action",
        },
    ];
    const dataByStatus =
        status === "Status" ? data : data.filter((u) => u.status === status);
    const finalData =
    searchText === ""
      ? dataByStatus
      : dataByStatus.filter(
          (u) =>
            u.parkingId.parkingName
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
       showSizeChanger:true, 
          showTotal: total => `Total ${total} Request`
      };
      const renderContent = () => {
        switch(status) {
            case 'Status':
              return 'Tất cả'
            case 'Pending':
              return 'Chờ duyệt'
            case 'Cancel':
              return 'Từ chối'
            default:
              return 'Tất cả'
          }
      };
    return (
        <>
        <Row gutter={45} style={{ marginBottom: "30px" }}>
        <Col xs={8} sm={8} md={7} lg={7} xl={6} xxl={5}>
            {/*Filter Gender */}
            <Form.Item label={'Trạng thái'}>
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
                    setStatus("Status");
                  }}
                >
                  {" "}
                  Tất cả
                </Menu.Item>
              </Menu>
            }
          > 
          {renderContent()}
            
          </Dropdown.Button>
            </Form.Item>
        
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
                title='Detail Assignment Information'
                onCancel={()=>{setModal({...modal,isOpen:false})}}
                closeIcon={<CloseSquareOutlined style={{color: "red", fontSize: "20px"}}/>}
                footer={
                    null
                }
            >
                <table>

                    <tr>
                        <td style={{fontSize: '18px', color: '#838688'}}>ID</td>
                        <td style={{
                            fontSize: '18px',
                            color: '#838688',
                            textAlign: 'justify',
                            paddingLeft: '35px'
                        }}>{modal.data.id}</td>
                    </tr>
                    <tr>
                        <td style={{fontSize: '18px', color: '#838688'}}>Parking Name</td>
                        <td style={{
                            fontSize: '18px',
                            color: '#838688',
                            textAlign: 'justify',
                            paddingLeft: '35px'
                        }}>{modal.data.parkingName}</td>
                    </tr>
                    
                    <tr>
                        <td style={{fontSize: '18px', color: '#838688'}}>Request By</td>
                        <td style={{
                            fontSize: '18px',
                            color: '#838688',
                            textAlign: 'justify',
                            paddingLeft: '35px'
                        }}>{modal.data.requestdBy}</td>
                    </tr>
                    <tr>
                        <td style={{fontSize: '18px', color: '#838688'}}>Request At</td>
                        <td style={{
                            fontSize: '18px',
                            color: '#838688',
                            textAlign: 'justify',
                            paddingLeft: '35px'
                        }}>{modal.data.requestAt}</td>
                    </tr>

                    <tr>

                        <td style={{fontSize: '18px', color: '#838688'}}>Status</td>
                        <td style={{
                            fontSize: '18px',
                            color: '#838688',
                            textAlign: 'justify',
                            paddingLeft: '35px'
                        }}>{modal.data.status}</td>
                    </tr>
                    <tr>
                        <td style={{fontSize: '18px', color: '#838688'}}>Note</td>
                        <td style={{
                            fontSize: '18px',
                            color: '#838688',
                            textAlign: 'justify',
                            paddingLeft: '35px'
                        }}>{modal.data.note}</td>
                    </tr>
                </table>


            </Modal>
           


            <div>
                <h1 style={{color: "red", float: "left"}}>Manage Request</h1>
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
                                            id: record.stt,
                                            parkingName: record.parkingName,
                                            requestBy: record.requestBy,
                                            requestAt: record.requestAt,
                                            status: record.status,
                                            note: record.note
                                        }

                                    });

                                }


                            }
                        }
                    }}
                >

                </Table>
            </div>


        </>
    )
}
export default ManageParkingDetail;