import {Table, Modal, Button,Row,Col,Input,notification,Menu,Dropdown,Form,Empty} from 'antd';

import React, {useEffect, useState} from 'react';
import {ExclamationCircleFilled,MoneyCollectFilled, CloseSquareOutlined,FilterOutlined} from "@ant-design/icons";
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
    const [open, setOpen] =useState(false);
    const [infor,setInfor]= useState({
      id:"",
               carNumber:"",
               note:"",
                parkingDate:"",
               pickUpDate:"",
               totalPrice:"",
    });
    // const handleDeleteOk = (id) => {
       
    //     api
    //         .patch(`request/cancel-request/${id}`)
    //         .then((res) => {
                
    //             notification.success({
    //                 message: `Thành công`,
    //                 description: "Bạn đã hủy yêu cầu",
    //                 placement: "topLeft",
    //               });
    //             //window.location.reload();
    //         }).catch((error) => {
    //             notification.warning({
    //                 message: `Thât bại`,
    //                 description: "Vui lòng thử lại",
    //                 placement: "topLeft",
    //               });
    //     })
    // }
    
      const showPromiseOk = (id) => {
        Modal.confirm({
          title: 'Bạn  có muốn thanh toán ?',
          icon: <ExclamationCircleFilled />,
          okText: 'Đồng ý',
    
            cancelText: 'Hủy',
          content: 'Bạn sẽ thanh toán với xe này !',
          onOk() {
            return new Promise((resolve, reject) => {
                api
            .patch(`parkingdetail/${id}/CarOut`)
            .then((res) => {
                setOpen(true);
                setInfor({...res.data,parkingDate:moment(new Date(res.data.parkingDate).toLocaleDateString('en-CA')).format('DD-MM-YYYY')
                ,pickUpDate:moment(new Date(res.data.pickUpDate).toLocaleDateString('en-CA')).format('DD-MM-YYYY'),carNumber: res.data.car.carNumber
              })
                
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
const parkingID = localStorage.getItem('parkingID');
    useEffect(() => {
        api.get(`parkingdetails/${parkingID}/GetParkingDetailsByParking`, {})
        .then(function(response)  {
            let respData = response.data
            respData.forEach((element) => {
                //element.state = element.state === 'WaitingForAcceptance' ? 'Waiting For Acceptance' : element.state;
             element.parkingDate = moment(new Date(element.parkingDate).toLocaleDateString("en-US")).format('DD/MM/YYYY');
             element.pickUpDate = element.pickUpDate !==null ?   moment(new Date(element.pickUpDate).toLocaleDateString("en-US")).format('DD/MM/YYYY') :'Xe đang đỗ';
              element.carNumber = element.car.carNumber
                


                element.action = [
                    <Button disabled={element.pickUpDate ==='Xe đang đỗ' ? false : true}
                    className="buttonState"
                   
                    onClick={() => {
                        showPromiseOk(element.id);
                        
                    }}
                >
                   <MoneyCollectFilled  style={{color:"green"}} />
                </Button>,
                    
                  

                ]
            })
            setData(respData.sort((a, b) => {
                if (a.id.trim().toLowerCase() > b.id.trim().toLowerCase()) {
                  return 1;
                }
                if (b.id.trim().toLowerCase() > a.id.trim().toLowerCase()) {
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
            title: "Ngày trả ",
            dataIndex: "pickUpDate",
            key: "pickUpDate",
            sorter: (a, b) => {
                if (a.pickUpDate > b.pickUpDate) {
                    return -1;
                }
                if (b.pickUpDate > a.pickUpDate) {
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
            title: "Đơn giá",
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
            title: "",
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
        Quản lý chỗ đỗ xe
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

            <Modal
        title="Hóa đơn"
        open={open}
        footer={null}
        onCancel={()=>setOpen(false)}
        onOk={()=>setOpen(false) }
      >
           <Form
        >
          <Form.Item
            name="lastName"
            label="Mã hóa đơn:"
           
          > {infor.id}
            {/* <Input disabled /> */}
          </Form.Item>
          <Form.Item
            name="firstName"
            label="Biển số xe :"
             
          >
              {infor.carNumber}
          </Form.Item>
          

          <Form.Item
            name="userName"
            label=" Ghi chú :"
          >
            {infor.note}
          </Form.Item>
         
          <Form.Item
            name="email"
            label=" Ngày đỗ xe :"
            
          >        
             {infor.parkingDate}
          </Form.Item>
          <Form.Item
            name="phoneNumber"
            label="Ngày lấy xe :"
           
          >
            {infor.pickUpDate}
          </Form.Item>
          <Form.Item
            name="dateOfBirth"
            label="Thành tiền :"
           
          >
              {infor.totalPrice}
          </Form.Item>
         
          
        </Form>
        
              
               
                
               
               
      </Modal>
        </>
    )
}
export default ManageParkingDetail;