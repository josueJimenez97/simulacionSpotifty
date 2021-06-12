
DROP TABLE IF EXISTS Genero_Musical;
CREATE TABLE Genero_Musical (
  cod_genero INTEGER  IDENTITY(1,1) NOT NULL,
  nombre_genero VARCHAR(50) NOT NULL,
  PRIMARY KEY(cod_genero)
);

DROP TABLE IF EXISTS Usuario;
CREATE TABLE Usuario (
  cod_usuario INTEGER IDENTITY(1,1) NOT NULL,
  nombre_usuario VARCHAR(20) NOT NULL,
  email VARCHAR(30) NOT NULL,
  contrasenia VARCHAR(20) NOT NULL,
  fecha_nac DATE NOT NULL,
  sexo CHAR NOT NULL,
  pais  VARCHAR(20) NOT NULL,
  premium BIT NOT NULL,
  PRIMARY KEY(cod_usuario)
);

DROP TABLE IF EXISTS Artista;
CREATE TABLE Artista (
  cod_artista INTEGER IDENTITY(1,1) NOT NULL,
  nombre_artista VARCHAR(30) NOT NULL,
  img VARCHAR NOT NULL,
  PRIMARY KEY(cod_artista)
);

DROP TABLE IF EXISTS Playlist;
CREATE TABLE Playlist (
  cod_playlist INTEGER IDENTITY(1,1) NOT NULL,
  cod_usuario INTEGER NOT NULL,
  titulo VARCHAR(50) NOT NULL,
  nro_canciones INTEGER NOT NULL,
  activa BIT NOT NULL,
  fechaEliminacion DATE NULL,
  PRIMARY KEY(cod_playlist),
  FOREIGN KEY(cod_usuario)
    REFERENCES Usuario(cod_usuario)
      ON DELETE CASCADE
      ON UPDATE CASCADE
);

DROP TABLE IF EXISTS Suscripcion;
CREATE TABLE Suscripcion (
  cod_suscripcion INTEGER IDENTITY(1,1) NOT NULL,
  cod_usuario INTEGER NOT NULL,
  fecha_suscripcion DATE NOT NULL,
  fecha_renovacion DATE NOT NULL,
  PRIMARY KEY(cod_suscripcion),
  FOREIGN KEY(cod_usuario)
    REFERENCES Usuario(cod_usuario)
      ON DELETE CASCADE
      ON UPDATE CASCADE
);

DROP TABLE IF EXISTS Album;
CREATE TABLE Album (
  cod_album INTEGER IDENTITY(1,1) NOT NULL,
  cod_artista INTEGER NOT NULL,
  titulo VARCHAR(40) NOT NULL,
  anio_publicacion INTEGER NOT NULL,
  img VARCHAR NULL,
  PRIMARY KEY(cod_album),
  FOREIGN KEY(cod_artista)
    REFERENCES Artista(cod_artista)
      ON DELETE CASCADE
      ON UPDATE CASCADE
);

DROP TABLE IF EXISTS Tarjeta_Credito;
CREATE TABLE Tarjeta_Credito (
  cod_tarjeta INTEGER IDENTITY(1,1) NOT NULL,
  cod_suscripcion INTEGER NOT NULL,
  nro_tarjeta INTEGER NOT NULL,
  fecha_caducidad DATE NOT NULL,
  codigo_seguridad VARCHAR(50) NOT NULL,
  PRIMARY KEY(cod_tarjeta),
  FOREIGN KEY(cod_suscripcion)
    REFERENCES Suscripcion(cod_suscripcion)
      ON DELETE CASCADE
      ON UPDATE CASCADE
);

DROP TABLE IF EXISTS Pago;
CREATE TABLE Pago (
  nro_orden INTEGER IDENTITY(1,1) NOT NULL,
  cod_suscripcion INTEGER NOT NULL,
  fecha_pago DATE NOT NULL,
  PRIMARY KEY(nro_orden),
  FOREIGN KEY(cod_suscripcion)
    REFERENCES Suscripcion(cod_suscripcion)
      ON DELETE CASCADE
      ON UPDATE CASCADE
);


DROP TABLE IF EXISTS Cancion;
CREATE TABLE Cancion (
  cod_cancion INTEGER IDENTITY(1,1) NOT NULL,
  cod_album INTEGER NOT NULL,
  cod_genero INTEGER NOT NULL,
  titulo VARCHAR(60) NOT NULL,
  duracion FLOAT NOT NULL,
  nro_reproducciones INTEGER NOT NULL,
  PRIMARY KEY(cod_cancion),
  FOREIGN KEY(cod_genero)
    REFERENCES Genero_Musical(cod_genero)
      ON DELETE CASCADE
      ON UPDATE CASCADE,
  FOREIGN KEY(cod_album)
    REFERENCES Album(cod_album)
      ON DELETE CASCADE
      ON UPDATE CASCADE
);

DROP TABLE IF EXISTS Cambios_Playlist;
CREATE TABLE Cambios_Playlist (
  cod_usuario INTEGER NOT NULL,
  cod_playlist INTEGER NOT NULL,
  creador BIT NOT NULL,
  fechaCambio DATE NOT NULL,
  PRIMARY KEY(cod_usuario, cod_playlist),
  FOREIGN KEY(cod_usuario)
    REFERENCES Usuario(cod_usuario)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION,
  FOREIGN KEY(cod_playlist)
    REFERENCES Playlist(cod_playlist)
      ON DELETE CASCADE
      ON UPDATE CASCADE
);

DROP TABLE IF EXISTS Usuario_Sigue_Artista;
CREATE TABLE Usuario_Sigue_Artista (
  cod_usuario INTEGER NOT NULL,
  cod_artista INTEGER NOT NULL,
  PRIMARY KEY(cod_usuario, cod_artista),
  FOREIGN KEY(cod_usuario)
    REFERENCES Usuario(cod_usuario)
      ON DELETE CASCADE
      ON UPDATE CASCADE,
  FOREIGN KEY(cod_artista)
    REFERENCES Artista(cod_artista)
      ON DELETE CASCADE
      ON UPDATE CASCADE
);

DROP TABLE IF EXISTS Albumes_Favoritos;
CREATE TABLE Albumes_Favoritos (
  cod_usuario INTEGER NOT NULL,
  cod_album INTEGER NOT NULL,
  PRIMARY KEY(cod_usuario, cod_album),
  FOREIGN KEY(cod_usuario)
    REFERENCES Usuario(cod_usuario)
      ON DELETE CASCADE
      ON UPDATE CASCADE,
  FOREIGN KEY(cod_album)
    REFERENCES Album(cod_album)
      ON DELETE CASCADE
      ON UPDATE CASCADE
);

DROP TABLE IF EXISTS Canciones_Playlist;
CREATE TABLE Canciones_Playlist (
  cod_playlist INTEGER NOT NULL,
  cod_cancion INTEGER NOT NULL,
  PRIMARY KEY(cod_playlist, cod_cancion),
  FOREIGN KEY(cod_playlist)
    REFERENCES Playlist(cod_playlist)
      ON DELETE CASCADE
      ON UPDATE CASCADE,
  FOREIGN KEY(cod_cancion)
    REFERENCES Cancion(cod_cancion)
      ON DELETE CASCADE
      ON UPDATE CASCADE
);

DROP TABLE IF EXISTS Canciones_Favoritas;
CREATE TABLE Canciones_Favoritas (
  cod_cancion INTEGER NOT NULL,
  cod_usuario INTEGER NOT NULL,
  PRIMARY KEY(cod_cancion, cod_usuario),
  FOREIGN KEY(cod_cancion)
    REFERENCES Cancion(cod_cancion)
      ON DELETE CASCADE
      ON UPDATE CASCADE,
  FOREIGN KEY(cod_usuario)
    REFERENCES Usuario(cod_usuario)
      ON DELETE CASCADE
      ON UPDATE CASCADE
);

DROP TABLE IF EXISTS PayPal;
CREATE TABLE PayPal (
  cod_payPal INTEGER IDENTITY(1,1) NOT NULL,
  cod_suscripcion INTEGER NOT NULL,
  usuario_paypal VARCHAR(20) NOT NULL,
  PRIMARY KEY(cod_payPal),
  FOREIGN KEY(cod_suscripcion)
    REFERENCES Suscripcion(cod_suscripcion)
      ON DELETE CASCADE
      ON UPDATE CASCADE
);

--Usuarios
insert into Usuario (nombre_usuario,email,contrasenia,fecha_nac,sexo, pais, premium)
values ('jhona','jhona@gmail.com','jhona123','1991-07-15','M','Bolivia',0);
insert into Usuario (nombre_usuario,email,contrasenia,fecha_nac,sexo, pais, premium)
values ('jose','jose@gmail.com','jose123','1999-07-06','M','Bolivia',0);
insert into Usuario (nombre_usuario,email,contrasenia,fecha_nac,sexo, pais, premium)
values ('andrea','andrea@gmail.com','andrea123','1992-06-11','F','Bolivia',0);
insert into Usuario (nombre_usuario,email,contrasenia,fecha_nac,sexo, pais, premium)
values ('maria','maria@gmail.com','maria123','1995-06-05','F','Bolivia',0);
insert into Usuario (nombre_usuario,email,contrasenia,fecha_nac,sexo, pais, premium)
values ('juan','juan@gmail.com','juan123','1998-03-28','M','Bolivia',0);

--Generos musicales
SET IDENTITY_INSERT Genero_Musical ON;
insert into Genero_Musical (cod_genero, nombre_genero) values (1, 'Rock Español');
insert into Genero_Musical (cod_genero, nombre_genero) values (2, 'Rock Alternativo');
insert into Genero_Musical (cod_genero, nombre_genero) values (3, 'Electronico');
insert into Genero_Musical (cod_genero, nombre_genero) values (4, 'Folklorico');
SET IDENTITY_INSERT Genero_Musical OFF;

--Artistas
SET IDENTITY_INSERT Artista ON;
insert into Artista (cod_artista,nombre_artista,img) values (1,'Octavia','');
insert into Artista (cod_artista,nombre_artista,img) values (2,'LMFO','');
insert into Artista (cod_artista,nombre_artista,img) values (3,'Green day','');
insert into Artista (cod_artista,nombre_artista,img) values (4,'Soda Stereo','');
insert into Artista (cod_artista,nombre_artista,img) values (5,'Kjarkas','');
SET IDENTITY_INSERT Artista OFF;

--Artista Octavia 
SET IDENTITY_INSERT Album ON;
insert into Album (cod_album, cod_artista, titulo,anio_publicacion) 
values (1,1,'Medular',2016);
insert into Album (cod_album, cod_artista, titulo,anio_publicacion) 
values (2,1,'8via Sinfonia',2018);
insert into Album (cod_album, cod_artista, titulo,anio_publicacion) 
values (3,1,'Talisman',2016);
SET IDENTITY_INSERT Album OFF;

--Canciones Album Medular
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (1, 1,'Viaje',3.42,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (1, 1,'Invierno',3.39,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (1, 1,'Acercate',3.31,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (1, 1,'Bienvenido',2.42,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (1, 1,'Autodestruccion',3.40,0);

--Canciones Album 8via Sinfonia
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (2, 1,'Eternidad',3.52,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (2, 1,'Ajayu',4.17,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (2, 1,'Despues de ti',4.25,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (2, 1,'La noche',3.27,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (2, 1,'Sere tu musica',3.53,0);

--Canciones Album Talisman
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (3, 1,'A partir de hoy',4.11,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (3, 1,'Aterrizame',4.07,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (3, 1,'Despiertame',3.25,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (3, 1,'Heridas',3.27,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (3, 1,'Azul eterno',3.32,0);

--Artista LMFO
SET IDENTITY_INSERT Album ON;
insert into Album (cod_album, cod_artista, titulo,anio_publicacion) 
values (4,2,'Party Rock',2009);
insert into Album (cod_album, cod_artista, titulo,anio_publicacion) 
values (5,2,'Sorry for Party Rocking',2011);
insert into Album (cod_album, cod_artista, titulo,anio_publicacion) 
values (6,2,'Party Rock Anthem',2011);
SET IDENTITY_INSERT Album OFF;

--Canciones Album Party Rock
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (4, 3,'Get crazy',3.45,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (4, 3,'La la la',3.30,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (4, 3,'Yes',3.03,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (4, 3,'Shots',3.42,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (4, 3,'Bounce',4.03,0);

--Canciones Album Sorry for Party Rocking
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (5, 3,'Sexy and i know it',3.19,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (5, 3,'One day',3.17,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (5, 3,'Best night',5.00,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (5, 3,'Hot dog',2.26,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (5, 3,'Sorry for Party rocking',1.53,0);

--Canciones Album Party Rock Anthem
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (6, 3,'Party rock anthem',4.50,0);

--Albumes Artista Green Day
SET IDENTITY_INSERT Album ON;
insert into Album (cod_album, cod_artista, titulo,anio_publicacion) 
values (7,3,'Revolution radio',2016);
insert into Album (cod_album, cod_artista, titulo,anio_publicacion) 
values (8,3,'Demolicious',2014);
insert into Album (cod_album, cod_artista, titulo,anio_publicacion) 
values (9,3,'Father of all...',2020);
SET IDENTITY_INSERT Album OFF;

--Canciones Album Revolution radio
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (7, 2,'Oh yeah!',2.51,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (7, 2,'Sugar Youth',1.54,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (7, 2,'Meet me on the roof',2.39,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (7, 2,'Take the money and Crawl',2.08,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (7, 2,'Graffitia',3.17,0);

--Canciones Album Demolicious
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (8, 2,'Angel Blue',2.55,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (8, 2,'Carpie diem',3.39,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (8, 2,'99 revolutions',4.06,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (8, 2,'Ashley',2.47,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (8, 2,'Nuclear Family',3.03,0);

--Canciones Album Father of all...
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (9, 2,'Father of all...',2.31,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (9, 2,'Fire, Ready, aim',1.52,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (9, 2,'You in the heart',2.10,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (9, 2,'Junkies on a high',2.31,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (9, 2,'I was a teenage',3.44,0);

--Albumes Artista Soda stereo
SET IDENTITY_INSERT Album ON;
insert into Album (cod_album, cod_artista, titulo,anio_publicacion) 
values (10,4,'Septimo dia',2017);
insert into Album (cod_album, cod_artista, titulo,anio_publicacion) 
values (11,4,'Nada personal',1985);
insert into Album (cod_album, cod_artista, titulo,anio_publicacion) 
values (12,4,'Doble vida',1988);
SET IDENTITY_INSERT Album OFF;

--Canciones Album Father of all...
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (10, 1,'En el septimo dia',5.20,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (10, 1,'Cae el sol',3.04,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (10, 1,'Profugos',4.25,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (10, 1,'Persiana americana',3.34,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (10, 1,'Hombre al agua',5.53,0);

--Canciones Album nada personal
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (11, 1,'Cuando pase el temblor',3.49,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (11, 1,'Danza rota',3.31,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (11, 1,'Estoy azulado',5.17,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (11, 1,'Observandonos',3.06,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (11, 1,'Ecos',4.57,0);

--Canciones Album nada personal
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (12, 1,'En la cuidad de la furia',5.46,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (12, 1,'En el borde',4.42,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (12, 1,'Dia comun',4.39,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (12, 1,'Corazon delator',5.12,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (12, 1,'El ritmo de tus ojos',3.57,0);


--Albumes Artista Kjarkas
SET IDENTITY_INSERT Album ON;
insert into Album (cod_album, cod_artista, titulo,anio_publicacion) 
values (13,5,'Reclamando tu cariño',1990);
insert into Album (cod_album, cod_artista, titulo,anio_publicacion) 
values (14,5,'35 años',2006);
insert into Album (cod_album, cod_artista, titulo,anio_publicacion) 
values (15,5,'Asi suena Bolivia',2021);
SET IDENTITY_INSERT Album OFF;

--Canciones Album nada Reclamando tu cariño
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (13, 4,'Imillitay',3.35,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (13, 4,'Negrita',4.25,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (13, 4,'El ritmo negro',4.09,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (13, 4,'Tiempo al tiempo',4.21,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (13, 4,'Vivo por ti',3.49,0);  


--Canciones Album 35 años
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (14, 4,'Kamachaka',3.13,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (14, 4,'A tu ventana',4.20,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (14, 4,'No te puedo olvidar',4.04,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (14, 4,'Loco por ti',3.45,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (14, 4,'Fria',3.38,0);

--Canciones Album Asi suena Bolivia
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (15, 4,'Ave de cristal',5.40,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (15, 4,'El ritmo negro',4.09,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (15, 4,'El arbol de mi destino',3.10,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (15, 4,'Saya sensual',4.25,0);
insert into Cancion (cod_album,cod_genero,titulo,duracion,nro_reproducciones)
values (15, 4,'Munasqechay',4.15,0);