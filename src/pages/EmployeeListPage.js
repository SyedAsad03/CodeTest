import React, { useEffect, useState } from 'react';
import { Container, Typography, Table, TableBody, TableCell, TableHead, TableRow } from '@mui/material';
import axios from 'axios';

const EmployeeListPage = () => {
    const [employees, setEmployees] = useState([]);

    useEffect(() => {
        const fetchEmployees = async () => {
            try {
                const response = await axios.get('http://localhost:5000/api/employer/employees');
                setEmployees(response.data);
            } catch (error) {
                console.error('Failed to fetch employees', error);
            }
        };

        fetchEmployees();
    }, []);

    return (
        <Container>
            <Typography variant="h4">Employees</Typography>
            <Table>
                <TableHead>
                    <TableRow>
                        <TableCell>Employee ID</TableCell>
                        <TableCell>Employee Name</TableCell>
                    </TableRow>
                </TableHead>
                <TableBody>
                    {employees.map((employee) => (
                        <TableRow key={employee.employeeId}>
                            <TableCell>{employee.employeeId}</TableCell>
                            <TableCell>{employee.employeeName}</TableCell>
                        </TableRow>
                    ))}
                </TableBody>
            </Table>
        </Container>
    );
};

export default EmployeeListPage;
