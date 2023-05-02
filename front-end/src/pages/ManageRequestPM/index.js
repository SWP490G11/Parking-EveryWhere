import {Table, Modal, Button,Row,Col,Input,notification,Menu,Dropdown,Form,Empty,Descriptions} from 'antd';
import { useAuthState } from '../../hooks/authState';
import React, {useEffect, useState} from 'react';
import {ExclamationCircleFilled, CloseOutlined,CheckOutlined, CloseSquareOutlined,FilterOutlined} from "@ant-design/icons";
import moment from "moment";
import { Role } from '../../utils/constants';
import api from "../../services/api";
 const ManageRequestPM=()=> {
    const [data, setData] = useState([])
    const [modal, setModal] = useState({
        isOpen: false,
        data: {},
    });
   
    const [page, setPage] = useState(1);
    const [pageSize, setPageSize] = useState(10);
    const [searchText, setSearchText] = useState("");
    const [status,setStatus] = useState("Status");
    const [authState] = useAuthState();
    const handleDeleteOk = (id) => {
       
        api
            .patch(`request/cancel-request/${id}`)
            .then((res) => {
                
                notification.success({
                    message: `Thành công`,
                    description: "Bạn đã từ chối yêu cầu ",
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
                    description: "Yêu cầu đã được bạn chấp thuận",
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

const ParkingID =localStorage.getItem("parkingID"); 

    useEffect(() => {
    //  authState?.data?.role ===Role.ParkingOwner
    api.get(`pending-request/${ParkingID}`)
        .then(function(response)  {
          let respData = response.data
  respData.forEach((element) => {
      //element.state = element.state === 'WaitingForAcceptance' ? 'Waiting For Acceptance' : element.state;
      element.requestAt = moment(new Date(element.requestAt).toLocaleDateString("en-US")).format('DD/MM/YYYY');
      element.status = element.status === 'Pending' ? 'Chờ duyệt' : (element.status === 'Done' ? 'Đã duyệt':'Từ chối');
      element.parkingName = element.parkingId.parkingName;
      element.requestBy = element.requestby.userName;


      element.action = [
          <Button disabled={(element.status==="Từ chối"||element.status==="Đã duyệt") ? true : false}
          className="buttonState"
         
          onClick={() => {
              showPromiseOk(element.id);
              
          }}
      >
         <CheckOutlined style={{color:"green"}} />
      </Button>,
          <Button disabled={(element.status==="Từ chối"||element.status==="Đã duyệt")? true : false}
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
          .catch(() => {});
      //   else{
      //     api.get(`pending-request/${ParkingID}`)
      // .then(function (response) {
      //   setUpData(response)
      // }, [])
      // .catch(() => {});
      //   }

}, [data])

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
            title: "Bãi đỗ",
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
          title: "Người gửi",
          dataIndex: "requestBy",
          key: "requestBy",
          sorter: (a, b) => {
              if (a.requestBy > b.requestBy) {
                  return -1;
              }
              if (b.requestBy > a.requestBy) {
                  return 1;
              }
              return 0;
          },
      },


        {
            title: "Ngày gửi yêu cầu",
            dataIndex: "requestAt",
            key: "requestAt",
            sorter: (a, b) => {
                if (a.requestAt > b.requestAt) {
                    return -1;
                }
                if (b.requestAt > a.requestAt) {
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
          showTotal: total => `Tổng ${total} yêu cầu`
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
        Quản lý yêu cầu khách hàng
      </p>
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
        <Descriptions title="Thông tin yêu cầu" bordered>
        <Descriptions.Item label="ID" span={3}>{modal.data.id}</Descriptions.Item>
    <Descriptions.Item label="Bãi đỗ"span={3} >{modal.data.parkingName}</Descriptions.Item>
   
     <Descriptions.Item label="Người gửi yêu cầu"span={2} >{modal.data.requestBy}</Descriptions.Item>
     
    <Descriptions.Item label="Ngày gửi" span={2}>{modal.data.requestAt}</Descriptions.Item>
    <Descriptions.Item label="Trạng thái" span={1}>{modal.data.status}</Descriptions.Item>
    <Descriptions.Item label="Nội dung" span={3}>{modal.data.note}</Descriptions.Item>
   
    </Descriptions>
            


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
                                            id: record.id,
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

                </Table>)}
            </div>


        </>
    )
}
export default ManageRequestPM;