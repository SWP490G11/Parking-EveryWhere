import React from "react";
import { Carousel } from 'antd';
const contentStyle = {
    height: '160px',
    width: '100%',
    color: '#fff',
    lineHeight: '160px',
    textAlign: 'center',
    background: '#1e81d2',
};

const ImageCarousel = (props) => {

    const listImage = props.listImage;

    return (
        <Carousel autoplay>
            {
                listImage?.map((data, key) => (
                    <div key={key}>
                        <img style={contentStyle} src={data?.url} alt="" />
                    </div>
                ))
            }
        </Carousel>

    )
}

export default ImageCarousel;