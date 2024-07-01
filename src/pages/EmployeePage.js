import React, { useEffect, useState } from 'react';
import { Container, Typography } from '@mui/material';
import axios from 'axios';

const EmployeePage = () => {
    const [employee, setEmployee] = useState(null);

    useEffect(() => {
        const fetchEmployee = async () => {
            try {
                const response = await axios.get('https://localhost:7000/api/Employee/1'); // Replace 1 with actual employee ID
                setEmployee(response.data);
            } catch (error) {
                console.error('Failed to fetch employee', error);
            }
        };

        fetchEmployee();
    }, []);

    return (
        <Container>
            <Typography variant="h4">Employee Details</Typography>
            {employee && (
                <>
                    <Typography>Name: {employee.employeeName}</Typography>
                    <Typography>Description: {employee.employeeDescription}</Typography>
                    <Typography>Age: {employee.employeeAge}</Typography>
                    <Typography>Gender: {employee.employeeGender}</Typography>
                </>
            )}
        </Container>
    );
};

export default EmployeePage;
