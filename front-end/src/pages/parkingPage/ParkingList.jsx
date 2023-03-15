import { Avatar, List, Space } from 'antd';
import React, { useEffect, useState } from "react";
import { LikeOutlined, MessageOutlined, StarOutlined } from '@ant-design/icons';
import axios from 'axios';

const IconText = ({ icon, text }) => (
  <Space>
    {React.createElement(icon)}
    {text}
  </Space>
);

const ParkingList = () => {
  const [itemz,setItemz]=useState([]);;
  useEffect(()=>{
    axios.get(`${process.env.REACT_APP_Backend_URI}parkings`)
    .then(function(response) {
      setItemz(response.data);
    })
  });
   
  const data = itemz.map((it) => ({
    href: `/parking/detail/${it.parkingID}`,
    title: it.parkingName,
    avatar: `https://joesch.moe/api/v1/random`,
    description: it.discription,
    content: it.addressDetail,
  }));
  return (
  <List
    itemLayout="vertical"
    size="normal"
    pagination={{
      onChange: (page) => {
        console.log(page);
      },
      pageSize: 3,
    }}
    dataSource={data}
    renderItem={(item) => (
      <List.Item
        key={item.title}
        actions={[
          <IconText icon={StarOutlined} text="156" key="list-vertical-star-o" />,
          <IconText icon={LikeOutlined} text="156" key="list-vertical-like-o" />,
          <IconText icon={MessageOutlined} text="2" key="list-vertical-message" />,
        ]}
        extra={
          <img
            width={250}
            height={215}
            alt="logo"
            src="https://gw.alipayobjects.com/zos/rmsportal/mqaQswcyDLcXyDKnZfES.png"
          />
        }
      >
        <List.Item.Meta
          avatar={<Avatar src={item.avatar} />}
          title={<a href={item.href}>{item.title}</a>}
          description={item.description}
        />
        {item.content}
      </List.Item>
    )}
  />)
      };
export default ParkingList;