import React from "react";
import { Outlet, Link } from "react-router-dom";
import { AppBar, Toolbar, Typography } from "@mui/material";
import './style.css';
import logo_judoclube from './images/logo_judoclube.jpg';

const Layout = () => {
  return (
    <>
      <AppBar position="static" className="app-bar">
        <Toolbar>
          <nav>
            <ul className="nav-list">
              <li>
                <img
                  src={logo_judoclube}
                  alt="Logo Judô Clube"
                  className="logo-image"
                />
              </li>

              <li className="nav-item">
                <Typography variant="h4" component="h2" className="nav-title">
                  Judô Clube App
                </Typography>
              </li>

              {/* Links */}
              {["home", "login", "aulas", "contato"].map((item, idx) => (
                <li key={idx} className="nav-item">
                  <Link
                    to={`/${item}`}
                    className="nav-link"
                  >
                    {item.charAt(0).toUpperCase() + item.slice(1)}
                  </Link>
                </li>
              ))}
            </ul>
          </nav>
        </Toolbar>
      </AppBar>

      <main className="main-content">
        <Outlet />
      </main>

      <footer className="footer">
        <Typography variant="body2" className="footer-text">
          <p>
            <strong> Judô Clube App ❖ </strong>  Desenvolvido por Matheus Alcântara &copy; {new Date().getFullYear()}
          </p>
          <a
            href="https://abrir.link/BUFDc"
            target="_blank"
            rel="noopener noreferrer"
            className="footer-link"
          >
            <span className="footer-italic"> Link para contato via Whatsapp! - Matheus Alcântara </span>
          </a>
          <p>Treinos Adulto: Aos Domingos de 10:00 às 12:00 no Grupo dos 13.</p>
          <p>Treinos Infanto-Juvenil: Terças, Quartas, Quintas e Sextas: das 17:40 às 18:40</p>
        </Typography>
      </footer>
    </>
  );
};

export default Layout;
