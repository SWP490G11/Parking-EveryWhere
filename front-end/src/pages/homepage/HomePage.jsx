import { Layout } from "antd";

import React from "react";
import "../../style/home.css";
import Mapbox from "../../components/Mapbox";

import HeaderComp from "../../components/HeaderComp";
import FooterComp from "../../components/FooterComp";
// Menu

const { Header, Content, Sider } = Layout;

const HomePage = () => {
  return (
    <Layout>
      {/* Header */}
      <HeaderComp />

      {/* Body */}
      <div className="body">
        {/* Map */}
        <Mapbox />
      </div>
      {/* About */}
      {/* Footer */}

      <FooterComp />
    </Layout>
  );
};
export default HomePage;
