import "../style/home.css";
import {
  FacebookOutlined,
  TwitterOutlined,
  InstagramOutlined,
} from "@ant-design/icons";
import { Layout,Col,Row } from 'antd';
import React from 'react';
const {Footer } = Layout;
function FooterComp() {
  const footerStyle = {
    textAlign: 'center',
    color: '#fff',
    backgroundColor: '#7dbcea',
  }
  return (
    <Footer style={footerStyle}>
      <Row>
      <Col span={8}>
        <h3 style={{ display: "center", textAlign: "center" }}>About Us</h3>
            <p>
              Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean
              vestibulum justo nec sapien hendrerit, in lobortis erat sagittis.
              Nunc congue eros id libero varius tristique.{" "}
            </p>
            </Col>
      <Col span={8}>
      <h3 style={{ display: "center", textAlign: "center" }}>
              Contact Us
            </h3>
            <ul>
              <li>
                Email : najumy1807.2k@gmail.com
              </li>
              <li>
                Phone : 0981949455
              </li>
              <li>
                Address : Mễ Trì - Hà Nội
              </li>
            </ul>
        </Col>
      <Col span={8}>
      <h3  style={{ display: "center", textAlign: "center" }}>Social Media</h3>
            <ul id="social-icons">
              <li>
                <FacebookOutlined href="#" />
                Facebook
              </li>
              <li>
                <TwitterOutlined />
                Twitter
              </li>
              <li>
                <InstagramOutlined />
                Instagram
              </li>
            </ul>
        </Col>
    </Row>

    </Footer>
   
  );
}
export default FooterComp;
