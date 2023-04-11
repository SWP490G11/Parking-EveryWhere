import React from 'react'
import { Button, Card, Input } from 'antd';
const { TextArea } = Input
export const Feedback = () => {
    return (
        <div title="Feedback">
            <TextArea  style={{marginBottom: 20}} rows={6}/>
            <Button type="primary">
                Submit
            </Button>
      </div>
    )
}