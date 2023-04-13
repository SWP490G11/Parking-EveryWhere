import React from 'react'
import { Button, Avatar, Input, List } from 'antd';
const { TextArea } = Input
export const Feedback = ({feedbacks = []}) => {
    return (
        <div title="Feedback">
            <List
                style={{paddingBottom: 20}}
                itemLayout="horizontal"
                dataSource={feedbacks}
                renderItem={(item, index) => (
                <List.Item>
                    <List.Item.Meta
                    avatar={<Avatar src={item.avatar || `https://joesch.moe/api/v1/random?key=${index}`} />}
                    title={item.username}
                    description={item.content}
                    />
                </List.Item>
                )}
            />
            <TextArea  style={{marginBottom: 20}} rows={6}/>
            <Button type="primary">
                Gửi
            </Button>
      </div>
    )
}