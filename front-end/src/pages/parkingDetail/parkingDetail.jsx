import { Layout, Button } from "antd";

import React from "react";

import Mapbox from "../../components/Mapbox";

import HeaderComp from "../../components/HeaderComp";
import FooterComp from "../../components/FooterComp";
import "../../style/parkingDetail.css";
const { Header, Content, Sider } = Layout;

const ParkingDetail = () => {
  return (
    <Layout>
      {/* Header */}
      <HeaderComp />

      {/* Body */}
      <div className="body">
        <div id="left-side">
          {" "}
          <div id="pk-title">
            BÃI ĐỖ XE A1 - DỊCH VỌNG HẬU - CẦU GIẤY- HÀ NỘI
          </div>
          <div id="image">
            <img src="#" />
          </div>
          <div id="pk-detail">
            <ul>
              <li>
                <div id="pk-info">
                  <h3>Thông tin mô tả</h3>
                  <p>
                    Bãi đỗ có thể chứa được đủ các loại xe trừ xe chuyên dụng và
                    xe xây dựng
                  </p>
                </div>
              </li>
              <li></li>
              <li></li>
              <li>
                <h3>Hotline</h3>
                <p>09xxxxxxxxx</p>
              </li>
              <li>
                <h3>Địa điểm</h3>
                <Mapbox />
              </li>
            </ul>
          </div>
        </div>
        <div id="right-side">
          <h3>Trạng thái : </h3> <h3 style={{ color: "green" }}>Còn slot</h3>
          <p>
            {" "}
            - Trống 3/20 slot có mái che <br />- Trống 15/20 slot không có mái
            che
          </p>
          <Button onClick>Đăng ký slot</Button>
        </div>
        {/* Map */}

        <div></div>
      </div>
      {/* About */}
      {/* Footer */}

      <FooterComp />
    </Layout>
  );
};
export default ParkingDetail;
