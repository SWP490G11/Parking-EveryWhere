import { Layout, Rate, Button } from "antd";

import React from "react";

import HeaderComp from "../../components/HeaderComp";
import FooterComp from "../../components/FooterComp";

const { Header, Content, Sider } = Layout;

const ParkingHistory = () => {
  return (
    <Layout>
      {/* Header */}
      <HeaderComp />

      {/* Body */}
      <div className="">
        <h1 style={{ textAlign: "center" }}>
          Danh sách lịch sử bãi đỗ của bạn{" "}
        </h1>

        <ul id="list">
          <li>
            <h3 style={{ padding: "15px" }}>
              <a href="#"> Tên bãi đỗ</a>
            </h3>
            <h3 style={{ padding: "15px" }}>Ngày đỗ - thời gian đỗ</h3>
            <h3 style={{ padding: "15px" }}>Loại bãi đỗ </h3>
            <h3 style={{ padding: "15px" }}>Đánh giá</h3>
          </li>
          <li>
            <h3 style={{ padding: "15px" }}>
              <a href="#"> AAAAAAAA</a>
            </h3>
            <h3 style={{ padding: "15px" }}>1/3/2023</h3>
            <h3 style={{ padding: "15px" }}>Có mái che</h3>
            <Rate
              style={{ padding: "15px" }}
              allowHalf
              defaultValue={2.5}
            />{" "}
            <Button onClick>Chi tiết bãi đỗ</Button>{" "}
          </li>
        </ul>
      </div>
      {/* About */}
      {/* Footer */}

      <FooterComp />
    </Layout>
  );
};
export default ParkingHistory;