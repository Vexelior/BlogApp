import { Outlet } from 'react-router-dom'
import Navbar from '../Layout/Navbar';

export default function Layout() {
    return (
        <>
            <div className='App'>
                <Navbar />
                <div className='page'>
                    <Outlet />
                </div>
            </div>
        </>
    );
}