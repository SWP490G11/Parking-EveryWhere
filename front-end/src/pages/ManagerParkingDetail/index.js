import {Table, Modal, Button,Row,Col,Input,notification,Descriptions,Form,Empty} from 'antd';

import React, {useEffect, useState} from 'react';
import {ExclamationCircleFilled,DollarOutlined, } from "@ant-design/icons";
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
    //const [status,setStatus] = useState("Tất cả");
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

    useEffect(() => {
        api.get(`parkingdetails/all-parking-of-owner`, {})
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
                   <DollarOutlined  style={{color:"green"}} />
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
            title: "Thanh toán",
            dataIndex: "action",
            key: "action",
        },
    ];
    // const dataByStatus =
    //     status === "Tất cả" ? data : (status=== 'Xe đã lấy' ? (data.filter((u) => u.pickUpDate !== 'null') ): 
    //     (data.filter((u) => u.pickUpDate === 'null') ));
    const finalData =
    searchText === ""
      ? data
      : data.filter(
          (u) =>
            u.car.carNumber
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
          showTotal: total => `Tổng ${total} thông tin đỗ xe`
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
        Thanh toán
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
                    setStatus('Xe đã lấy');
                  }}
                >
                  {" "}
                  Xe đã lấy
                </Menu.Item>
                <Menu.Item
                  value="Female"
                  onClick={() => {
                    setStatus('Xe đang đỗ');
                  }}
                >
                  {" "}
                 Xe đang đỗ
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
   
    {/* <Descriptions.Item label="Người gửi yêu cầu"span={2} >{modal.data.requestdBy}</Descriptions.Item>
     */}
      <Descriptions.Item label="Biển số xe" span={1.5}>{modal.data.carNumber}</Descriptions.Item>
    <Descriptions.Item label="Loãi chỗ đỗ" span={1.5}>{modal.data.typeOfSlot==='ROOFED'? 'Có mái che': 'Không có mái che'}</Descriptions.Item>
    <Descriptions.Item label="Ngày gửi" span={1.5}>{modal.data.parkingDate}</Descriptions.Item>
    <Descriptions.Item label="Ngày trả" span={1.5}>{modal.data.pickUpDate}</Descriptions.Item>
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
                                            carNumber: record.carNumber,
                                            parkingDate: record.parkingDate,
                                            pickUpDate: record.pickUpDate,
                                            parkingName: record?.slot?.parking?.parkingName,
                                            note: record.note,
                                            typeOfSlot: record?.slot?.typeOfSlot
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