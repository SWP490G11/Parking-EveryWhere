import "../style/home.css";
import {
  FacebookOutlined,
  TwitterOutlined,
  InstagramOutlined,
} from "@ant-design/icons";
function FooterComp() {
  return (
    <footer>
      <div className="container">
        <div id="ft-container">
          <div id="ft-about">
            <h3 style={{ display: "center", textAlign: "center" }}>About Us</h3>
            <p>
              Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean
              vestibulum justo nec sapien hendrerit, in lobortis erat sagittis.
              Nunc congue eros id libero varius tristique.{" "}
            </p>
          </div>
          <div id="ft-contact">
            <h3 style={{ display: "center", textAlign: "center" }}>
              Contact Us
            </h3>
            <ul>
              <li>
                <a href="#">Email : najumy1807.2k@gmail.com</a>
              </li>
              <li>
                <a href="#">Phone : 0981949455</a>
              </li>
              <li>
                <a href="#">Address : Mễ Trì - Hà Nội</a>
              </li>
            </ul>
          </div>
          <div id="ft-social">
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
          </div>
        </div>
      </div>
    </footer>
  );
}
export default FooterComp;
