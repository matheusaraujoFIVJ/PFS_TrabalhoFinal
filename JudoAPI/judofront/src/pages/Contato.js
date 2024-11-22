import React from "react";

const Contato = () => {
  const textSectionStyle = {
    backgroundColor: "rgba(255, 255, 255, 0.8)",
    padding: "20px",
    borderRadius: "8px",
    display: "flex",
    flexDirection: "column",
    justifyContent: "center",
    alignItems: "center",
    textAlign: "center",
    fontSize: "18px",
    marginBottom: "30px",
  };

  const containerStyle = {
    display: "flex",
    justifyContent: "center",
    gap: "25px",
    flexWrap: "wrap",
  };

  const mapStyle = {
    flex: "1 1 calc(45%)",
    maxWidth: "600px",
    minWidth: "350px",
    height: "400px",
    borderRadius: "30px",
    border: "none",
  };

  const linkStyle = {
    color: "#aa9864",
    textDecoration: "none",
    fontSize: "20px",
    marginBottom: "10px",
  };

  return (
    <div style={{ minHeight: "80vh", padding: "20px" }}>
      {/* Seção de Texto */}
      <div style={textSectionStyle}>
        <p>
          <strong>Grupo dos 13:</strong>
          <br />
          Av Prefeito Samir Nasser, 357
          <br />
          Vila Isabel, Três Rios, RJ
          <br />
          CEP: 25812-461
        </p>

        <p>
          Telefone e Whatsapp:
          <a
            href="https://abrir.link/BUFDc"
            target="_blank"
            rel="noopener noreferrer"
            style={linkStyle}
          >
            <br />
            Matheus Alcântara - (24) 99292-4519
          </a>
        </p>

        <p>
          <strong>Colégio Santa Clara:</strong>
          <br />
          R. Sete de Setembro, 145
          <br />
          Centro, Três Rios, RJ
          <br />
          CEP: 25802-130
        </p>
      </div>

      {/* Seção dos Mapas */}
      <div style={containerStyle}>
        <iframe
          title="Endereço Grupo dos 13"
          src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3696.473401513373!2d-43.189239900000004!3d-22.1079191!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x98f5ef2aa08349%3A0xf09f56b14b24c33!2sGrupo%20Dos%20Treze!5e0!3m2!1spt-BR!2sbr!4v1732285201888!5m2!1spt-BR!2sbr"
          style={mapStyle}
          allowFullScreen
          loading="lazy"
        ></iframe>
        <iframe
          title="Endereço Colégio Santa Clara"
          src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3696.2091232043745!2d-43.20665359999999!3d-22.118001!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x98f67973ad2335%3A0x2b2133233bfb2181!2sCol%C3%A9gio%20Santa%20Clara%20de%20Tr%C3%AAs%20Rios!5e0!3m2!1spt-BR!2sbr!4v1732285449197!5m2!1spt-BR!2sbr"
          style={mapStyle}
          allowFullScreen
          loading="lazy"
        ></iframe>
      </div>
    </div>
  );
};

export default Contato;
