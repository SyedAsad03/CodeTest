import React, { useState } from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import Navbar from './components/Navbar';
import LoginPage from './pages/LoginPage';
import EmployeePage from './pages/EmployeePage';
import EmployerPage from './pages/EmployerPage';
import EmployeeListPage from './pages/EmployeeListPage';
import LoginLogsPage from './pages/LoginLogsPage';

const App = () => {
    const [role, setRole] = useState('');
    const [isLoggedIn, setIsLoggedIn] = useState(false);

    return (
        <Router>
            <Navbar role={role} isLoggedIn={isLoggedIn} />
            <Routes>
                <Route path="/" element={<LoginPage setRole={setRole} setIsLoggedIn={setIsLoggedIn} />} />
                <Route path="/employee" element={<EmployeePage />} />
                <Route path="/employer" element={<EmployerPage />} />
                <Route path="/employees" element={<EmployeeListPage />} />
                <Route path="/login-logs" element={<LoginLogsPage />} />
            </Routes>
        </Router>
    );
};

export default App;
