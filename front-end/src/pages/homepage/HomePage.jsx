import { Layout, Col, Row  } from "antd";

import React from "react";
import "../../style/home.css";
import Mapbox from "../../components/Mapbox";
import ParkingList from "../parkingPage/ParkingList";
import FilterComp from "../../components/FilterComp";
// Menu
const HomePage = ({routers}) => {
  return (
    <section>
    <Layout>
      {/* Header */}
      {/* <HeaderComp /> */}
      <FilterComp />
      {/* Body */}
      <div className="body">
      <Row>
        {/*ParkingList*/}
      <Col span={10} >
      <ParkingList />
      </Col>
        {/* Map */}
      <Col span={14}>
      <Mapbox />
      </Col>
    </Row>
    
   
      </div>
    
      
    </Layout>
    </section>
  );
};
export default HomePage;
