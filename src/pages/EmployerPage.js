import React from 'react';
import { Container, Typography, Button } from '@mui/material';
import { useNavigate } from 'react-router-dom';

const EmployerPage = () => {
    const navigate = useNavigate();

    return (
        <Container>
            <Typography variant="h4">Employer Dashboard</Typography>
            <Button variant="contained" onClick={() => navigate('/employees')}>Show List of Employees</Button>
            <Button variant="contained" onClick={() => navigate('/login-logs')}>Show Login Info</Button>
        </Container>
    );
};

export default EmployerPage;
