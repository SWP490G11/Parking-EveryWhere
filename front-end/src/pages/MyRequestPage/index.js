import {Table, Modal, Button,Row,Col,Input,notification,Menu,Dropdown,Descriptions,Form} from 'antd';

import React, {useEffect, useState} from 'react';
import {ExclamationCircleFilled, CloseOutlined, CloseSquareOutlined,FilterOutlined} from "@ant-design/icons";
import moment from "moment";
import api from "../../services/api";
 const MyRequest=()=> {
    const [data, setData] = useState([])
    const [modal, setModal] = useState({
        isOpen: false,
        data: {},
    });
   
    
    const [page, setPage] = useState(1);
    const [pageSize, setPageSize] = useState(10);
    const [searchText, setSearchText] = useState("");
    const [status,setStatus] = useState("Tất cả");

 

  
    const handleDeleteOk = (id) => {
       
        api
            .delete(`request/${id}`)
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
    // eslint-disable-next-line react-hooks/exhaustive-deps
    const showPromiseDelete = (id) => {
        Modal.confirm({
          title: 'Bạn có muốn xóa yêu cầu này?',
          icon: <ExclamationCircleFilled />,
          okText: 'Đồng ý',
    okType: 'danger',
    cancelText: 'Hủy',
          content: 'Yêu cầu sẽ bị xóa khi bạn đồng ý',
          onOk() {
            return new Promise((resolve, reject) => {
                handleDeleteOk(id);
              setTimeout(Math.random() > 0.5 ? resolve : reject, 1000);
            }).catch(() => console.log('Oops errors!'));
          },
          onCancel() {},
        });
      };
//===========================================================
   
    
  
//===============================================

    useEffect(() => {
        api
            .get(`request/myRequest`, {})
            .then(function(response)  {
                let respData = response.data
                respData.forEach((element) => {
                    //element.state = element.state === 'WaitingForAcceptance' ? 'Waiting For Acceptance' : element.state;
                    element.requestAt = moment(new Date(element.requestAt).toLocaleDateString("en-US")).format('DD/MM/YYYY');
                    element.status = element.status === 'Pending' ? 'Chờ duyệt' : (element.status === 'Cancel'? 'Từ chối':'Chấp thuận');
                    element.parkingName = element.parkingId.parkingName;
                    


                    element.action = [
                        
                        <Button disabled={element.status==="Từ chối" ||element.status==="Chấp thuận"  ? true : false}
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
                    
      
                  if ( b.status > a.status
                    ) {
                       return -1;
                   }
                   if (  a.status > b.status
                   ) {
                       return 1;
                   }
    
     return 0;
 
   
                  })
                );
              }, [])
            .catch((error) => {

            })
    }, [data, showPromiseDelete])

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
            responsive: ['md'],
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
            responsive: ['xs','sm'],
        },

        {
            title: "Ngày gửi yêu cầu",
            dataIndex: "requestAt",
            key: "requestAt",
            sorter: (a, b) => {
              if (
                (new Date(a.requestAt).getTime() - new Date(b.requestAt).getTime()) > 0) {
                  return -1;
              }
              if ((new Date(b.requestAt).getTime() - new Date(a.requestAt).getTime()) >0 ) 
              {
                  return 1;
               }
               return 0;
          },
            responsive: ['sm'],
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
            responsive: ['xs','sm'],
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
            responsive: ['xs','sm'],
        },
        {
          responsive: ['xs','md'],
            title: "Hành động",
            dataIndex: "action",
            key: "action",
        },
    ];
    const dataByStatus =
    status === "Tất cả" ? data : data.filter((u) => u.status === status);
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
        Danh sách yêu cầu 
      </p>
        <Row gutter={45} style={{ marginBottom: "30px" }}>
        
        <Col xs={24} xl={8} sm={8}>
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
                  value="Female"
                  onClick={() => {
                    setStatus("Chấp thuận");
                  }}
                >
                  {" "}
                  Chấp thuận
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
            </Form.Item>
        
          </Col>
        <Col xs={24} xl={8} sm={8}>
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
        className="ant-col ant-col-xs-24 ant-col-xl-24"
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
        <Descriptions.Item label="Mã số" xs={3} xl={3}>{modal.data.id}</Descriptions.Item>
    <Descriptions.Item label="Bãi đỗ"span={3} >{modal.data.parkingName}</Descriptions.Item>
   
    {/* <Descriptions.Item label="Người gửi yêu cầu"span={2} >{modal.data.requestdBy}</Descriptions.Item>
     */}
    <Descriptions.Item label="Ngày gửi" span={2}>{modal.data.requestAt}</Descriptions.Item>
    <Descriptions.Item label="Trạng thái" span={1}>{modal.data.status}</Descriptions.Item>
    <Descriptions.Item label="Nội dung" span={3}>{modal.data.note}</Descriptions.Item>
   
    </Descriptions>

            </Modal>
           
            
          


            <div>
                
                <Table
                responsive={true}
                className="ant-col ant-col-xs-24 ant-col-xl-24"
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

                </Table>
            </div>


        </>
    )
}
export default MyRequest;