import React from "react";
import { Carousel } from 'antd';
const contentStyle = {
     height: '250px',
     width: '100%',
    objectfit: 'contain',
    borderRadius: '15px',
    border: '1px solid #ddd',
    lineHeight: '160px',
    textAlign: 'center',
    background: '#1e81d2',
};

const ImageCarousel = (props) => {

    const listImage = props.listImage;

    return (
        <Carousel autoplay  className="ant-col ant-col-xs-24 ant-col-xl-24">
            {
                listImage?.map((data, key) => (
                    <div key={key}>
                        <img style={contentStyle} src={data} alt="" />
                    </div>
                ))
            }
        </Carousel>

    )
}

export default ImageCarousel;