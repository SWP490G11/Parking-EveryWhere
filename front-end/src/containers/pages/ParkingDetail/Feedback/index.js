
import { Button, Avatar, Input, List,Form,Rate,notification,Space,Row,Col,Divider,Image } from 'antd';
import api from '../../../../services/api';
import { useAuthState } from '../../../../hooks/authState';
import {
    StarOutlined,
    LikeOutlined,
    MessageOutlined,
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
    const [image,setImage]=useState([]);
    const [feedbacks,setFeedbacks]=useState([])
    const param = useParams();
    const id = param.parkingID;
    const [value, setValue] = useState(2.5);
   
    useEffect(() => {
        api.get(`feedbacks-of-parking/${id}`)
          .then((response) =>{console.log(response.data); setFeedbacks(response.data)}).catch((e)=>{notification.warning({
            message: `Lỗi dữ liệu`,
            description: "Tải dữ liệu bị lỗi",
            placement: "topLeft",
          });});
    }, [id])
    const data=feedbacks.map((e)=>({
        title: e.feedbackby.userName,
        avatar: 'https://thumbsnap.com/i/SR3LQucs.jpg',
        content: e.content,
        rating: e.rating,
        images :e.images[0],
        userID: "e.feedbackby.id",

    }),[])
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
                imageURLs: [],
              })
            
          })
          .catch((error) => {
            notification.warning({
              message: `Thất bại`,
              description: "Vui lòng thử lại",
              placement: "topLeft",
            });
            form.setFieldsValue({
                content: "",
                
                imageURLs: [],
               
              })
          });
      };
      console.log(value)
    return (
        <div title="Feedback">
            {authState?.data?.role === 'ParkingOwner'? <></>: <Form form={form} onFinish={onFinish} style={{width:"100%"}} layout="vertical" hideRequiredMark>
            <Form.Item
            name="rating"
            label="Đánh giá"
            
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
    src={image[0]}
  />: <></> }</Col>
      <Col span={4} >
      <Button htmlType="submit" type="primary">
                Gửi
              </Button>
      </Col>
    </Row>
          <br/>
    <Divider orientation="left">Danh sách phản hồi từ khách hàng</Divider>
         
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
            
           <IconText icon={StarOutlined} text="156" key="list-vertical-star-o" />,
            <IconText icon={LikeOutlined} text="156" key="list-vertical-like-o" />,
            <IconText icon={MessageOutlined} text="2" key="list-vertical-message" />
        ]}
        extra={
          <Image
            width={272}
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
           
            
            
      </div>
    )
}