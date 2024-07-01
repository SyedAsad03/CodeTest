import React from 'react';
import { Container, Typography } from '@mui/material';

const HomePage = () => {
  return (
    <Container>
      <Typography variant="h3" gutterBottom>
        Home Page
      </Typography>
      <Typography variant="body1">
        Welcome to the home page!
      </Typography>
    </Container>
  );
};

export default HomePage;
