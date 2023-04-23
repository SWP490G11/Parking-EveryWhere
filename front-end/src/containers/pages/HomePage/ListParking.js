import {  List, Tag,Image } from 'antd';
import {  Status } from '../../../utils/constants';
import { calDistance, toRoute } from '../../../utils/helpers';
import { routes } from '../../../utils/routes';
import config from '../../../config';
//import { ConfirmDelete } from './ConfirmDelete';
//import { useAuthState } from '../../../hooks/authState';
import { useNavigate } from "react-router-dom";
import { useLocationState } from '../../../hooks/locationState';
const ListParking = ({ search, filter, parkings, setLocation }) => {
    //const [authState] = useAuthState()
    const [locationState] = useLocationState()
    const navigateTo = useNavigate();
    const data = parkings.filter((item) => {
        if (search) {
            if (
                item.parkingName.toLowerCase().includes(String(search).toLowerCase())
                ||
                item.addressDetail.toLowerCase().includes(String(search).toLowerCase())
                ||
                item.discription.toLowerCase().includes(String(search).toLowerCase())
            ) {
                return true
            }
            return false
        }
        return true
    })
    .filter((item) => {
        try {
            if (filter?.distance) {
                const distance = calDistance(locationState.lat, locationState.lng, item.lat, item.lon)
                if(distance <= filter?.distance){
                    return true
                }
                return false
            }
            return true
        } catch(e) {
            return true
        }
    })
   ;
    return (
        <List
            className="parking-list"
            itemLayout="horizontal"
            pagination={{
                onChange: (page) => {
                    console.log(page);
                },
                pageSize: 8,
            }}

            dataSource={data}
            renderItem={(item) => (
                <List.Item
                    className='parking-list-item'
                    onClick={e => {
                        const _loation = {
                            address: item.addressDetail,
                            location: {
                                lat: item.lat,
                                lng: item.lon
                            }
                        }
                        setLocation(_loation)
                    }}  
                    style={{ cursor: 'pointer' }}
                >
                    <List.Item.Meta
                        avatar={<Image style={{ width: 100, height: 100, border: 'solid 1px lightgrey', borderRadius: '5px', objectfit: 'contain' }} src={item?.imageUrls ? item.imageUrls : config.DEFAULT_IMG_URL} alt='' />}
                        // eslint-disable-next-line jsx-a11y/anchor-is-valid
                        title={<a onClick={()=>navigateTo(toRoute(routes.PARKING_DETAIL, { parkingID: item.parkingID }))}>{item.parkingName}</a>}
                        description={<div>
                            <div style={{ marginBottom: '0.25rem' }}>
                                {item.addressDetail}
                            </div>
                            <div>
                                {item.discription}
                            </div>
                        </div>}
                    />
                    <div className='parking-content'>
                        {/* <div className='parking-status'>
                            <h4>STATUS</h4>
                            <div>
                                20/20
                            </div>
                            <Tag color={item.status === Status.Available ? 'green' : 'volcano'} key={'tag'}>
                                {
                                    item.status === Status.Available
                                        ?
                                        Status.Available
                                        :
                                        "Not Available"
                                }
                            </Tag>
                            
                        </div> */}
                        <div className='parking-button-wapper'>
                           
                        <Tag color={item.status === Status.Available ? 'green' : 'volcano'} key={'tag'}>
                                {
                                    item.status === Status.Available
                                        ?
                                        Status.Available
                                        :
                                        Status.NotAvailable
                                }
                            </Tag>
                                    {/* <Button
                                        type='primary'
                                        style={{ marginBottom: '0.25rem' }}
                                        onClick={e => navigateTo(toRoute(routes.PARKING_DETAIL, { parkingID: item.parkingID }))}
                                    >
                                        Detail
                                    </Button> */}
                            
                        </div>
                    </div>
                </List.Item>
            )}
        />
    );
};
export default ListParking;
