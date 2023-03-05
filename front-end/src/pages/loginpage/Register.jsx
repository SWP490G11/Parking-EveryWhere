import {
  AutoComplete,
  Button,
  Checkbox,
  Form,
  Input,
  Spin,
  DatePicker,
  Radio,
} from "antd";
import axios from "axios";
import { useNavigate } from "react-router-dom";
import { useEffect, useState } from "react";
import "./Register.css";
import { LoadingOutlined } from "@ant-design/icons";

const formItemLayout = {
  labelCol: {
    xs: {
      span: 24,
    },
    sm: {
      span: 8,
    },
  },
  wrapperCol: {
    xs: {
      span: 24,
    },
    sm: {
      span: 16,
    },
  },
};
const tailFormItemLayout = {
  wrapperCol: {
    xs: {
      span: 24,
      offset: 0,
    },
    sm: {
      span: 16,
      offset: 8,
    },
  },
};

const Register = () => {
  const [form] = Form.useForm();
  const navigate = useNavigate();
  const [valuez, setValuez] = useState(1);
  const antIcon = <LoadingOutlined style={{ fontSize: "24px" }} spin />;
  const LOADING = {
    LOADING: "loading",
    FAIL: "fail",
    SUCCESS: "success",
    NONE: "none",
  };
  const [isLoading, setLoading] = useState(LOADING.NONE);
  const [role,setRole]=useState();
  const onFinish = (fieldsValue) => {
    setLoading(LOADING.LOADING)
    const values = {
      ...fieldsValue,
      dateOfBirth: fieldsValue["dateOfBirth"].format("YYYY-MM-DD"),
    };
    axios
      .post(`${process.env.REACT_APP_Backend_URI}api/User/Register`, {
        firstName: values.firstName,
        lastName: values.lastName,
        dateOfBirth: values.dateOfBirth,
        gender: values.gender,
        email: values.email,
        userName: values.userName,
        password: values.cfpassword,
        phoneNumber: values.phoneNumber,
        role:role,
        lastModifyAt: new Date(),
      })
      .then(() => {
        setTimeout(() => {
          setLoading(LOADING.FAIL);
        }, 3000);
        navigate("/login");
      })
      .catch((error) => {
        console.log(error);
      });
    console.log("Received values of form: ", values);
  };
  

  const [autoCompleteResult, setAutoCompleteResult] = useState([]);
  const onEmailChange = (value) => {
    if (!value) {
      setAutoCompleteResult([]);
    } else {
      setAutoCompleteResult(
        ["@gmail.com", "@yahoo.com"].map((domain) => `${value}${domain}`)
      );
    }
  };
  const emailOptions = autoCompleteResult.map((email) => ({
    label: email,
    value: email,
  }));
  useEffect(() => {
   if(valuez===1){
    document.getElementById("reg1").style.display = "flex";
    document.getElementById("reg2").style.display = "none";
    setRole(1);
   }
   else{setRole(2);}
},[valuez]);
  const onChange = (e) => {
    
    if (e.target.value === 2) {
      document.getElementById("reg1").style.display = "none";
      document.getElementById("reg2").style.display = "flex";
    } else {
      document.getElementById("reg1").style.display = "flex";
      document.getElementById("reg2").style.display = "none";
    }
    setValuez(e.target.value);
    console.log("radio checked", e.target.value);
  };
  
  return (
    <div className="signup-page">
      <div className="illustration-wrapper">
        <img
          src="https://mixkit.imgix.net/art/preview/mixkit-left-handed-man-sitting-at-a-table-writing-in-a-notebook-27-original-large.png?q=80&auto=format%2Ccompress&h=700"
          alt="Login"
        />
      </div>
      <div className="form">  
      <p className="form-title">Welcome back</p>
        <p>Register new account</p>
      <div className="chosez">  <Form.Item >
        <Radio.Group onChange={onChange} value={valuez} optionType="button"
        buttonStyle="solid">
          <Radio value={1} >Vehicle Owner</Radio>
          <Radio value={2}>Parking Owner</Radio>
        </Radio.Group>
      </Form.Item>
      </div>
      
      
       <div id="reg1" className="">

        <Form
          {...formItemLayout}
          form={form}
        
          onFinish={onFinish}
          initialValues={{
            prefix: "86",
          }}
          style={{
         
            maxWidth: 600,
          }}
          scrollToFirstError
        >
          <Form.Item
            name="firstName"
            label="FirstName"
            rules={[
              {
                required: true,
                message: "Please input your FirstName!",
                whitespace: true,
              },
            ]}
          >
            <Input />
          </Form.Item>
          <Form.Item
            name="lastName"
            label="LastName"
            rules={[
              {
                required: true,
                message: "Please input your LastName!",
                whitespace: true,
              },
            ]}
          >
            <Input />
          </Form.Item>

          <Form.Item
            name="userName"
            label="UserName"
            rules={[
              {
                required: true,
                message: "Please input your UserName!",
                whitespace: true,
              },
            ]}
          >
            <Input />
          </Form.Item>
          <Form.Item
            name="password"
            label="Password"
            tooltip="Cần ít nhất 1 chữ in hoa và 1 số "
            rules={[
              {
                required: true,
                pattern: new RegExp("^[a-zA-Z0-9]+$"),
                message: "Please input your password!",
              },
            ]}
            hasFeedback
          >
            <Input.Password />
          </Form.Item>

          <Form.Item
            name="cfpassword"
            label="Confirm Password"
            tooltip="Cần ít nhất 1 chữ in hoa và 1 số "
            dependencies={["password"]}
            hasFeedback
            rules={[
              {
                required: true,
                pattern: new RegExp("^[a-zA-Z0-9]+$"),
                message: "Please confirm your password!",
              },
              ({ getFieldValue }) => ({
                validator(_, value) {
                  if (!value || getFieldValue("password") === value) {
                    return Promise.resolve();
                  }
                  return Promise.reject(
                    new Error(
                      "The two passwords that you entered do not match!"
                    )
                  );
                },
              }),
            ]}
          >
            <Input.Password />
          </Form.Item>
          <Form.Item
            name="email"
            label="E-mail"
            rules={[
              {
                type: "email",
                message: "The input is not valid E-mail!",
              },
              {
                required: true,
                message: "Please input your E-mail!",
              },
            ]}
            hasFeedback
          >
            <AutoComplete
              options={emailOptions}
              onChange={onEmailChange}
              placeholder="Email"
            >
              <Input />
            </AutoComplete>
          </Form.Item>
          <Form.Item
            name="phoneNumber"
            label="Phone Number"
            rules={[
              {
                required: true,
                message: "Please input your phone number!",
              },
            ]}
          >
            <Input
             
              style={{
                width: "100%",
              }}
            />
          </Form.Item>
          <Form.Item
            name="dateOfBirth"
            label="Date of birth"
            rules={[
              {
                type: "object",
                required: true,
                message: "Please select time!",
              },
            ]}
          >
            <DatePicker style={{width: 332}} />
          </Form.Item>
          <Form.Item
            name="gender"
            label="Gender"
            rules={[
              {
                required: true,
                message: "Please select gender!",
              },
            ]}
          >
            <Radio.Group>
              <Radio value={0}>Male</Radio>
              <Radio value={1}>FeMale</Radio>
              <Radio value={2}>Other</Radio>
            </Radio.Group>
          </Form.Item>

          <Form.Item
            name="agreement"
            valuePropName="checked"
            rules={[
              {
                validator: (_, value) =>
                  value
                    ? Promise.resolve()
                    : Promise.reject(new Error("Should accept agreement")),
              },
            ]}
            {...tailFormItemLayout}
          >
            <Checkbox>
              I have read the <a href="#">agreement</a>
            </Checkbox>
          </Form.Item>
          <Form.Item {...tailFormItemLayout}>
            <Button type="primary"  htmlType="submit"
            disabled={isLoading === LOADING.LOADING}>
             <span>
                {isLoading === LOADING.LOADING ? (
                  <Spin indicator={antIcon} />
                )  : (
                  "Register"
                )}
              </span>
            </Button>
            <Button type="second" onClick={() => navigate(-1)}>
              Back
            </Button>
          </Form.Item>
        </Form>
        </div>
        <div id="reg2" className="">
        
        <Form
          {...formItemLayout}
          form={form}
          title={"register"}
          onFinish={onFinish}
          initialValues={{
            prefix: "86",
          }}
          style={{
            
            maxWidth: 600,
          }}
          scrollToFirstError
        >
          <Form.Item
            name="firstName"
            label="FirstName"
            rules={[
              {
                required: true,
                message: "Please input your FirstName!",
                whitespace: true,
              },
            ]}
          >
            <Input />
          </Form.Item>
          <Form.Item
            name="lastName"
            label="LastName"
            rules={[
              {
                required: true,
                message: "Please input your LastName!",
                whitespace: true,
              },
            ]}
          >
            <Input />
          </Form.Item>

          <Form.Item
            name="userName"
            label="UserName"
            rules={[
              {
                required: true,
                message: "Please input your UserName!",
                whitespace: true,
              },
            ]}
          >
            <Input />
          </Form.Item>
          <Form.Item
            name="password"
            label="Password"
            tooltip="Cần ít nhất 1 chữ in hoa và 1 số "
            rules={[
              {
                required: true,
                pattern: new RegExp("^[a-zA-Z0-9]+$"),
                message: "Please input your password!",whitespace: false,
              },
            ]}
            hasFeedback
          >
            <Input.Password />
          </Form.Item>

          <Form.Item
            name="cfpassword"
            label="Confirm Password"
            tooltip="Cần ít nhất 1 chữ in hoa và 1 số "
            dependencies={["password"]}
            hasFeedback
            rules={[
              {
                required: true,

                pattern: new RegExp("^[a-zA-Z0-9]+$"),
                message: "Please confirm your password!",
              },
              ({ getFieldValue }) => ({
                validator(_, value) {
                  if (!value || getFieldValue("password") === value) {
                    return Promise.resolve();
                  }
                  return Promise.reject(
                    new Error(
                      "The two passwords that you entered do not match!"
                    )
                  );
                },
              }),
            ]}
          >
            <Input.Password />
          </Form.Item>
          <Form.Item
            name="email"
            label="E-mail"
            rules={[
              {
                type: "email",
                message: "The input is not valid E-mail!",
              },
              {
                required: true,
                message: "Please input your E-mail!",
              },
            ]}
            hasFeedback
          >
            <AutoComplete
              options={emailOptions}
              onChange={onEmailChange}
              placeholder="Email"
            >
              <Input />
            </AutoComplete>
          </Form.Item>
          <Form.Item
            name="phoneNumber"
            label="Phone Number"
            rules={[
              {
                required: true,
                message: "Please input your phone number!",
              },
            ]}
          >
            <Input
             
              style={{
                width: "100%",
              }}
            />
          </Form.Item>
          <Form.Item
            name="dateOfBirth"
            label="Date of birth"
            rules={[
              {
                type: "object",
                required: true,
                message: "Please select time!",
              },
            ]}
          >
            <DatePicker style={{ width: 332 }}/>
          </Form.Item>
          <Form.Item
            name="gender"
            label="Gender"
            rules={[
              {
                required: true,
                message: "Please select gender!",
              },
            ]}
          >
            <Radio.Group>
              <Radio value={0}>Male</Radio>
              <Radio value={1}>FeMale</Radio>
              <Radio value={2}>Other</Radio>
            </Radio.Group>
          </Form.Item>

          <Form.Item
            name="agreement"
            valuePropName="checked"
            rules={[
              {
                validator: (_, value) =>
                  value
                    ? Promise.resolve()
                    : Promise.reject(new Error("Should accept agreement")),
              },
            ]}
            {...tailFormItemLayout}
          >
            <Checkbox>
              I have read the <a href="">agreement</a>
            </Checkbox>
          </Form.Item>
          <Form.Item {...tailFormItemLayout}>
            <Button type="primary" htmlType="submit">
              Register
            </Button>
            <Button type="second" onClick={() => navigate(-1)}>
              Back
            </Button>
          </Form.Item>
        </Form>
        </div>
      </div>
     
    </div>
  );
};
export default Register;
