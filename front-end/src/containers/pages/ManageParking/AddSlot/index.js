// import { ParkingService } from "../../../../services/parkingServices";
// import { Input, Button,Form,Drawer,Space,notification,AutoComplete,DatePicker,Radio,Select } from "antd";
// import api from "../../../../services/api";
// import React, { useState, useEffect } from "react";
// const AddSlot=({open,setOpen,parkingID,parkingName})=>{

//   const [form] = Form.useForm();
  
//   const [parkings, setParking] = useState([]);
 
//   const [autoCompleteResult, setAutoCompleteResult] = useState([]);
//   const onEmailChange = (value) => {
//     if (!value) {
//       setAutoCompleteResult([]);
//     } else {
//       setAutoCompleteResult(
//         ["@gmail.com", "@yahoo.com"].map((domain) => `${value}${domain}`)
//       );
//     }
//   };
//   const emailOptions = autoCompleteResult.map((email) => ({
//     label: email,
//     value: email,
//   }));
//   useEffect(() => {
//     console.log(parkingName);
//     ParkingService.getAllParkingOwner(setParking);
// }, [])
//   const onFinish = (values) => {
    
//     api
//       .post(`api/User/RegisterForParkingManager`, {
        
//         parkingID: values.parkingID,
//           firstName: values.firstName,
//           lastName: values.lastName,
//           dateOfBirth: values.dateOfBirth,
//           gender: values.gender,
//           phoneNumber: values.phoneNumber,
//           email: values.email,
//           lastModifyAt: new Date(),
//           imageURL: 'https://thumbsnap.com/i/nJ5ET935.jpg'
        
//       })
//       .then(() => {
//         // sessionStorage.setItem("changeStatus", true);
//         notification.success({
//           message: `Thành công`,
//           description: "Thêm nhân viên quản lý thành công",
//           placement: "topLeft",
//         });
//         form.setFieldsValue({
//           parkingID: "",
//           firstName: "",
//           lastName: "",
//           dateOfBirth: "",
//           gender: "",
//           phoneNumber: "",
//           email: "",
            
//           })
//         setOpen(false);
//        // window.location.reload();
//       })
//       .catch((error) => {
//         notification.warning({
//           message: `Thất bại`,
//           description: "Vui lòng thử lại",
//           placement: "topLeft",
//         });
//         form.setFieldsValue({
//           parkingID: "",
//           firstName: "",
//           lastName: "",
//           dateOfBirth: "",
//           gender: "",
//           phoneNumber: "",
//           email: "",
            
//           })
//       });
//   };
//   const onClose = () => {
//     setOpen(false);
// };
//     return(
     
//     )
// }
// export default AddSlot;