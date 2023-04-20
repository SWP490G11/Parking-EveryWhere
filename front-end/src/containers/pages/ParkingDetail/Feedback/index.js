
import { Button, Avatar, Input, List,Form,Rate,notification,Space,Row,Col,Divider,Image,Modal } from 'antd';
import api from '../../../../services/api';
import { useAuthState } from '../../../../hooks/authState';
import {
  EditOutlined,
  DeleteOutlined,
  } from "@ant-design/icons";
  import UploadImage from '../../../../components/UploadImage'
import { useParams } from 'react-router-dom';
import React, {useEffect, useState } from 'react';
const { TextArea } = Input
const IconText = ({ icon, text }) => (
    <Space>
      {React.createElement(icon)}
      {text}
    </Space>
  );
export const Feedback = () => {
    const [authState] = useAuthState();
    const [form] = Form.useForm();
    const [formz] = Form.useForm();
    const [open,setOpen] =useState(false);
    const [image,setImage]=useState([]);
    const [oldImage,setOldImage]=useState("");
    const [newImage,setNewImage]=useState([]);
    const [feedbacks,setFeedbacks]=useState([])
    const param = useParams();
    const id = param.parkingID;
    const [feedbackID,setFeedbackID] =useState();
    const [value, setValue] = useState(2.5);
   const userID = localStorage.getItem('userID');
    useEffect(() => {
        api.get(`feedbacks-of-parking/${id}`)
          .then((response) =>{ setFeedbacks(response.data)}).catch((e)=>{notification.warning({
            message: `Lỗi dữ liệu`,
            description: "Tải dữ liệu bị lỗi",
            placement: "topLeft",
          });});
    }, [feedbacks,id])
    const data=feedbacks.map((e)=>({
        title: e.feedbackby.userName,
        id: e.id,
        avatar: 'https://thumbsnap.com/i/SR3LQucs.jpg',
        content: e.content,
        rating: e.rating,
        images :e.images,
        userID: e.feedbackby.id,

    }),[])
    const InfoFeedback =(id)=>{
      api
          .get(`feedback/${id}`)
          .then((res) => {
              
            setOpen(true);
            setFeedbackID(id);
            formz.setFieldsValue({
              rating: res.data.rating,
              content: res.data.content,
            })
            setOldImage(res.data.images[0].url);
              //window.location.reload();
          }).catch((error) => {
              notification.warning({
                  message: `Thât bại`,
                  description: "Vui lòng thử lại",
                  placement: "topLeft",
                });
      })
    }
    const handleDeleteOk = (id) => {
       
      api
          .delete(`feedback/${id}`)
          .then((res) => {
              
              notification.success({
                  message: `Thành công`,
                  description: "Bạn đã xóa phản hồi",
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
        title: 'Bạn có muốn xóa phản hồi này?',
        
        okText: 'Đồng ý',
  okType: 'danger',
  cancelText: 'Hủy',
        content: 'Phản hồi sẽ bị xóa khi bạn đồng ý',
        onOk() {
          return new Promise((resolve, reject) => {
              handleDeleteOk(id);
            setTimeout(Math.random() > 0.5 ? resolve : reject, 1000);
          }).catch(() => console.log('Oops errors!'));
        },
        onCancel() {},
      });
    };
    const handleUpdateOk = (values) => {
       
      api
          .put(`feedback/${feedbackID}`,{
            content: values.content,
            rating: value,
            imageURLs: [newImage.length >0 ? newImage[0] : oldImage],
            parkingID: id,
          })
          .then((res) => {
                setOpen(false);
                window.location.reload();
              notification.success({
                  message: `Thành công`,
                  description: "Bạn đã xóa phản hồi",
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
   
    const onFinish = (values) => {
    
        api
          .post(`feedback`, {
            content: values.content,
            rating: value,
            imageURLs: [image.length >0 ? image[0] :'https://thumbsnap.com/i/nJ5ET935.jpg'],
            parkingID: id,
          })
          .then(() => {
            window.location.reload();
            notification.success({
              message: `Thành công`,
              description: "",
              placement: "topLeft",
            });
            form.setFieldsValue({
                content: "",
                rating :"",
              })
              setImage("")
            
          })
          .catch((error) => {
            notification.warning({
              message: `Thất bại`,
              description: "Vui lòng thử lại",
              placement: "topLeft",
            });
            
          });
      };
      console.log(value)
    return (
        <div title="Feedback">
            {authState?.data?.role === 'ParkingOwner'? <></>: 
            <Form form={form} onFinish={onFinish} style={{width:"100%"}} layout="vertical" hideRequiredMark>
            <Form.Item
            name="rating"
            label="Đánh giá"
            required={true}
          >
            <Rate allowHalf onChange={setValue} value={value} />
           
          </Form.Item>
          <Form.Item
            name="content"
            label="Nội dung"
            rules={[
              {
                required: true,
                message: "Vui lòng nhập nội dung đánh giá",
              },
            ]}
          >
            <TextArea  style={{marginBottom: 20}} rows={6}/>
          </Form.Item>
          <Row>
      <Col span={8}><UploadImage setImages={setImage} images={image} count={1}/></Col>
     
            <Col span={12}> {image.length > 0 ? <Image
    width={200}
    height={125}
    src={image[0]}
  />: <></> }</Col>
      <Col span={4} >
      <Button htmlType="submit" type="primary">
                Gửi
              </Button>
      </Col>
    </Row>
          <br/>
    <Divider orientation="left"><p style={{color:'red',fontWeight: "bold"}}>Danh sách phản hồi từ khách hàng</p></Divider>
         
            </Form>}
            
            <List
    itemLayout="vertical"
    size="large"
    pagination={{
      onChange: (page) => {
        console.log(page);
      },
      pageSize: 5,
    }}
    dataSource={data}
    renderItem={(item) => (
      <List.Item
        key={item.title}
        actions={[
            item.userID === userID ? (<>
            <Button type="text" onClick={()=>{InfoFeedback(item.id)}}  ><EditOutlined/> Chỉnh sửa</Button>
            <Button type="text" onClick={()=>{showPromiseDelete(item.id)}}  ><DeleteOutlined/> Xóa</Button>
            
            </>): <></>
           
        ]}
        extra={
          
          <Image
            width={200}
            height={125}
            alt="logo"
            src={item.images}
          />
        }
      >
        <List.Item.Meta
          avatar={<Avatar src={item.avatar} />}
          title={item.title}
          description={item.content}
        />
        <Rate allowHalf  disabled value={item.rating} />
        
      </List.Item>
    )}
  />
            <Modal
        title="Chỉnh sửa phản hồi"
        open={open}
        onCancel={()=>{
          window.location.reload();
          setOpen(false);
           formz.setFieldsValue({
          rating: "",
          content: "",
 });
          setNewImage("");
}}
       
        footer={null}
        width={1000}
      >
         <Form form={formz} onFinish={handleUpdateOk} style={{width:"100%"}} layout="vertical" hideRequiredMark>
            <Form.Item
            name="rating"
            label="Đánh giá"
            required={true}
          >
            <Rate allowHalf onChange={setValue} value={value} />
           
          </Form.Item>
          
            <Form.Item
            name="content"
            label="Nội dung"
            rules={[
              {
                required: true,
                message: "Vui lòng nhập nội dung đánh giá",
              },
            ]}
          >
            <TextArea  style={{marginBottom: 20}} rows={6}/>
          </Form.Item>
           
          <Row>
      <Col span={8}><UploadImage setImages={setNewImage} images={newImage} count={1}/></Col>
      <Col span={4} >
     
      </Col>
            <Col span={8}> {newImage.length > 0 ? <Image
    width={200}
    height={125}
    src={newImage[0]}
  />: <Image
  width={200}
            height={125}
  src={oldImage}
/> }</Col>
<Col span={4} >
<Button htmlType="submit" type="primary">
                Lưu
              </Button>
     </Col>
    </Row>
         
  
            </Form>
      </Modal>
            
            
      </div>
    )
}