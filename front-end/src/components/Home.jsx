import * as React from "react";
import Header from "./Header";
import Navigation from "./Navigation";
import Filter from "./Filter";
import Map from "./Map";

export default function Home() {
  return (
    <div className="home-page">
      <Header />
      <Navigation />

      <Map />
    </div>
  );
}
