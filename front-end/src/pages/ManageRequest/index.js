import {Table, Modal, Button,Row,Col,Input} from 'antd';
import axios from 'axios';
import React, {useEffect, useState} from 'react';
import {CheckOutlined, CloseOutlined, CloseSquareOutlined} from "@ant-design/icons";
import moment from "moment";
import api from "../../services/api";
export default function ManageRequest() {
    const [data, setData] = useState([])
    const [modal, setModal] = useState({
        isOpen: false,
        data: {},
    });
    const [isModalVisible, setIsModalVisible] = useState(false);
    const [isModalCancelVisible, setIsModalCancelVisible] = useState(false);
   
    const [idCompleted, setIdCompleted] = useState();
    const [page, setPage] = useState(1);
    const [pageSize, setPageSize] = useState(10);
    const [searchText, setSearchText] = useState("");
    const showModal = () => {
        setIsModalVisible(true);

    };
    const handleOk = () => {
        setIsModalVisible(false);

        axios
            .put(`https://rookiesgroup3.azurewebsites.net/api/Assignments/${idCompleted}/accepted`)
            .then((res) => {
                window.location.reload();
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
        axios
            .put(`https://rookiesgroup3.azurewebsites.net/api/Assignments/${idCompleted}/declined`)
            .then((res) => {
                setIdCompleted(null)

                window.location.reload();
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
                respData.forEach((element) => {
                    //element.state = element.state === 'WaitingForAcceptance' ? 'Waiting For Acceptance' : element.state;
                    element.lastModifyAt = moment(new Date(element.lastModifyAt).toLocaleDateString("en-US")).format('DD/MM/YYYY');
                    element.requestBy = element.requestby.userName;
                    element.parkingName = element.parkings.parkingName;
                    


                    element.action = [
                        <Button
                            className='buttonState'
                            disabled={element.state === 'Cancel' || element.isInProgress === false}
                            onClick={() => {
                                showModal()
                                handleCheckId(element.id)
                            }}
                        >
                            <CheckOutlined
                                style={{color: 'red'}}
                            />
                        </Button>,
                        <Button
                            className="buttonState"
                            disabled={element.state === 'Done' || element.isInProgress === false}
                            onClick={() => {
                                showModalDelete()
                                handleCheckDeleteId(element.id)
                            }}
                        >
                            <CloseOutlined/>
                        </Button>,
                      

                    ]
                })
                setData(response.data);


            })
            .catch((error) => {

            })
    }, [])

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
            title: "Assigned Date",
            dataIndex: "assignedDate",
            key: "assignedDate",
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
            title: "Assigned By",
            dataIndex: "assignedBy",
            key: "assignedBy",
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
            title: "Note",
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
            title: "State",
            dataIndex: "state",
            key: "state",
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
            title: "Action",
            dataIndex: "action",
            key: "action",
        },
    ];
    const finalData =
    searchText === ""
      ? data
      : (data.filter(
          (u) =>
            u.parkingName
              .toLowerCase()
              .replace(/\s+/g, "")
              .includes(searchText.toLowerCase().replace(/\s+/g, "")) ||
            u.requestBy.toLowerCase().replace(/\s+/g, "").includes(searchText.toLowerCase().replace(/\s+/g, ""))
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
            <Modal
                closable={false}
                title="Are You Sure?" visible={isModalVisible} okText="Yes" cancelText="No" onOk={handleOk}
                onCancel={handleCancel}
                footer={[
                    <div style={{textAlign: "left"}}>
                        <Button key="Yes" onClick={handleOk} className="buttonSave">Accept</Button>
                        <Button key="No" onClick={handleCancel} className='buttonCancel'>Cancel</Button>
                    </div>
                ]}>
                <p>Do you want to accept this request?</p>
            </Modal>
            <Modal
                closable={false}
                title="Are You Sure?" visible={isModalCancelVisible} okText="Yes" cancelText="No" onOk={handleDeleteOk}
                onCancel={handleCancelModal}
                footer={[
                    <div style={{textAlign: "left"}}>
                        <Button key="Yes" onClick={handleDeleteOk} className="buttonSave">Decline</Button>
                        <Button key="No" onClick={handleCancelModal} className=' buttonCancel'>Cancel</Button>
                    </div>
                ]}>
                <p>Do you want to cancel this request?</p>
            </Modal>
          


            <div>
                <h1 style={{color: "red", float: "left"}}>Manage Request</h1>
                <Table
                    columns={columns}
                    pagination={pagination}
                    dataSource={data}
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