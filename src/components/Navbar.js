import React from 'react';
import { AppBar, Toolbar, Button } from '@mui/material';
import { Link } from 'react-router-dom';

const Navbar = ({ role, isLoggedIn }) => {
    return (
        <AppBar position="static">
            <Toolbar>
                <Button color="inherit" component={Link} to="/">Home</Button>
                {!isLoggedIn && <Button color="inherit" component={Link} to="/login">Login</Button>}
                {role === 'Employer' && <Button color="inherit" component={Link} to="/register-employee">Register Employee</Button>}
                {isLoggedIn && <Button color="inherit" component={Link} to="/logout">Sign Out</Button>}
            </Toolbar>
        </AppBar>
    );
};

export default Navbar;
