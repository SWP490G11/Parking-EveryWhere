import { ParkingService } from "../../../../services/parkingServices";
import { Input, Button,Form,Drawer,Space,notification,AutoComplete,DatePicker,Radio,Select,Modal } from "antd";
import api from "../../../../services/api";
import moment from "moment";
import React, { useState, useEffect } from "react";
const AddPM=({open,setOpen,setInfor,setOpenInfor,infor})=>{

  const [form] = Form.useForm();
  
  const [parkings, setParking] = useState([]);
 
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
    ParkingService.getAllParkingOwner(setParking);
}, [parkings])
  const onFinish = (fieldsValue) => {
    const values = {
      ...fieldsValue,
      dateOfBirth: fieldsValue["dateOfBirth"].format("YYYY-MM-DD"),
    };
    api
      .post(`api/User/RegisterForParkingManager`, {
        
        parkingID: values.parkingID,
          firstName: values.firstName,
          lastName: values.lastName,
          dateOfBirth: values.dateOfBirth,
          gender: values.gender,
          phoneNumber: values.phoneNumber,
          email: values.email,
          lastModifyAt: new Date(),
          imageURL: 'https://thumbsnap.com/i/nJ5ET935.jpg'
        
      })
      .then((res) => {
        setInfor({...res.data,fullname: res.data.lastName+ res.data.firstName, password: res.data.userName+"@"+(moment(new Date(res.data.dateOfBirth).toLocaleDateString('en-CA')).format('DDMMYYYY'))})
        setOpenInfor(true);
        notification.success({
          message: `Thành công`,
          description: "Thêm nhân viên quản lý thành công",
          placement: "topLeft",
        });
        form.setFieldsValue({
          parkingID: "",
          firstName: "",
          lastName: "",
          dateOfBirth: "",
          gender: "",
          phoneNumber: "",
          email: "",
            
          })
        setOpen(false);
       // window.location.reload();
      })
      .catch((error) => {
        notification.warning({
          message: `Thất bại`,
          description: "Vui lòng thử lại",
          placement: "topLeft",
        });
        form.setFieldsValue({
          parkingID: "",
          firstName: "",
          lastName: "",
          dateOfBirth: "",
          gender: "",
          phoneNumber: "",
          email: "",
            
          })
      });
  };
  const onClose = () => {
    setOpen(false);
};
    return(
      <>
      <Drawer
          title="Thêm nhân viên quản lý"
          width={550}
          onClose={onClose}
          open={open}
          bodyStyle={{
            paddingBottom: 80,
          }}
        >
          <Form form={form} onFinish={onFinish} layout="vertical" hideRequiredMark>
          <Form.Item
            name="parkingID"
            label="Bãi đỗ"
            rules={[
              {
                required: true,
                message: "Vui lòng chọn bãi đỗ",
              },
            ]}
          >
            <Select
          placeholder="Chọn bãi đỗ"
           
          virtual={false}
          >
            
            {parkings.filter((u)=>u.status==='Available').map((u)=> (
                      <option value={u.parkingID}>
                        {u.parkingName}
                      </option>
                    ))}
          </Select>
          </Form.Item>
          <Form.Item
            name="firstName"
            label="Họ"
            rules={[
              {
                required: true,
                message: "Vui lòng nhập dữ liệu!",
                whitespace: true,
              },
            ]}
            hasFeedback
          >
            <Input />
          </Form.Item>
          <Form.Item
            name="lastName"
            label="Tên"
            rules={[
              {
                required: true,
                message: "Vui lòng nhập dữ liệu!",
                whitespace: true,
              },
            ]}
            hasFeedback
          >
            <Input />
          </Form.Item>
         
          <Form.Item
            name="email"
            label="E-mail"
            rules={[
              {
                type: "email",
                message: "E-mail không hợp lệ!",
              },
              {
                required: true,
                message: "Vui lòng nhập E-mail",
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
            label="Số điện thoại"
            rules={[
              {
                required: true,
                message: "Vui lòng nhập dữ liệu",
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
            label="Ngày sinh"
            rules={[
              
              {
               
                required: true,
                message: "Vui lòng nhập dữ liệu",
              },
             
            ]}
          >
            <DatePicker style={{width: 332 }} 
            format="DD-MM-YYYY" />
          </Form.Item>
          <Form.Item
            name="gender"
            label="Giới tính"
            rules={[
              {
                required: true,
                message: "Vui lòng chọn giới tính",
              },
            ]}
          >
            <Radio.Group>
              <Radio value={0}>Nam</Radio>
              <Radio value={1}>Nữ</Radio>
              <Radio value={2}>Khác</Radio>
            </Radio.Group>
          </Form.Item>
          <Space>
              <Button onClick={()=>{
                onClose();
                form.setFieldsValue({
                  parkingID: "",
                  firstName: "",
                  lastName: "",
                  dateOfBirth: "",
                  gender: "",
                  phoneNumber: "",
                  email: "",        
                    })
                } }>Hủy</Button>
              <Button htmlType="submit" type="primary">
                Lưu
              </Button>
              </Space>
           
        
          
        </Form>
        </Drawer>
      
     </>   
    )
}
export default AddPM;