create database DBVoiture;
use DBVoiture;
create table connexion(login varchar(30) not null,password varchar(250) not null, profil varchar(30));
insert into connexion values ('admin','123456789','Manager');
select * from connexion;

create table client(NumeroCli int primary key,nom varchar(50),prenom varchar(50),adresse varchar(150),
ville varchar(100), Tel int, email varchar(100));
create table voiture(Matricule varchar(100) primary key,modele varchar(50),marque varchar(100),
km int,carburant varchar(50),disponible varchar(3));

create table reservation(NumeroCli int,Matricule varchar(100),date_D_Reservation date,
date_F_Reservation date, Montant float, status varchar(30),foreign key(NumeroCli) references client(NumeroCli),
foreign key(Matricule) references voiture(Matricule));