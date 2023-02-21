import * as React from "react";
import "../style/header.css";

export default function Header() {
  return (
    <div className="header">
      <div id="left-side">
        <a href="#">LOGO</a>
      </div>
      <div id="right-side">
        <ul>
          <li>
            <a id="sign-up" href="#">
              Đăng ký
            </a>
          </li>
          <li>
            <a id="log-in" href="#">
              Đăng nhập
            </a>
          </li>
          <li>
            <a href="#"></a>
          </li>
        </ul>
      </div>
    </div>
  );
}
