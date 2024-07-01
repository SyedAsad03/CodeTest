import React, { useEffect, useState } from 'react';
import { Container, Typography, Table, TableBody, TableCell, TableHead, TableRow } from '@mui/material';
import axios from 'axios';

const LoginLogsPage = () => {
    const [logs, setLogs] = useState([]);

    useEffect(() => {
        const fetchLogs = async () => {
            try {
                const response = await axios.get('http://localhost:7000/api/employer/login-logs');
                setLogs(response.data);
            } catch (error) {
                console.error('Failed to fetch logs', error);
            }
        };

        fetchLogs();
    }, []);

    return (
        <Container>
            <Typography variant="h4">Login Logs</Typography>
            <Table>
                <TableHead>
                    <TableRow>
                        <TableCell>Employee ID</TableCell>
                        <TableCell>Login Date</TableCell>
                        <TableCell>Logout Date</TableCell>
                    </TableRow>
                </TableHead>
                <TableBody>
                    {logs.map((log) => (
                        <TableRow key={log.logId}>
                            <TableCell>{log.employeeId}</TableCell>
                            <TableCell>{log.loginDate}</TableCell>
                            <TableCell>{log.logoutDate}</TableCell>
                        </TableRow>
                    ))}
                </TableBody>
            </Table>
        </Container>
    );
};

export default LoginLogsPage;
