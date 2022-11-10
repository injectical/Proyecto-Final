create database sport360;

use sport360;

create table disciplina(
id_disciplina int auto_increment,
nombre varchar(50) not null,
primary key (id_disciplina) 

);

create table deportista(
id_deportista int primary key not null auto_increment,
fecha_nac date not null,
nombre varchar(50) not null,
apellido varchar(50) not null,
pais varchar(50),
id_disciplina_depor int not null,
foreign key (id_disciplina_depor) references disciplina (id_disciplina)
on delete cascade 
on update cascade
);

create table equipo(
id_equipo int primary key not null auto_increment,
nombre varchar(50) not null,
pais varchar(50) not null,
id_disciplina_equipo int not null,
foreign key (id_disciplina_equipo) references disciplina (id_disciplina)
on delete cascade 
on update cascade
);

create table evento(
id_evento int primary key not null auto_increment,
pais varchar(50) not null,
nombre varchar(50) not null,
fecha_inicio date not null,
hora_de_inicio time,
inicio boolean not null,
final boolean not null,
resultado varchar(100)

);


create table usuario(
id_usuario int primary key not null auto_increment,
nombre varchar(20) not null,
apellido varchar(20) not null,
email varchar(50) not null,
rol enum ('1','2','3','4')not null,
nombre_clave varchar(16) not null

);
create table detalles(
id_detalles int primary key not null auto_increment,
nombre_det varchar(10) not null
);


create table deportista_grup(
id_depr_grup int primary key not null auto_increment,
posicion varchar(50),
foreign key (id_depr_grup) references deportista (id_deportista)
on delete cascade 
on update cascade
);


create table deportista_individual(
id_depr_individual int primary key not null,
foreign key (id_depr_individual) references deportista (id_deportista)
on delete cascade 
on update cascade
);

create table vs(
id_evento_vs int primary key not null,
p1 varchar(80) not null,
p2 varchar(80) not null,
result_p1 varchar(100),
result_p2 varchar(100),
foreign key (id_evento_vs) references evento (id_evento)
on delete cascade 
on update cascade
);
create table masivo(
id_evnt_mas int primary key not null,
descripcion varchar(80), 
foreign key (id_evnt_mas) references evento(id_evento)
on delete cascade 
on update cascade
);

create table se_juega_por(
id_event_vs int primary key not null,
id_event_mso int not null,
foreign key (id_event_vs) references vs (id_evento_vs) 
on delete cascade
on update cascade,
foreign key (id_event_mso) references masivo (id_evnt_mas)
on delete cascade 
on update cascade

);

create table usuario_pago(
id_us_pago int primary key not null,
fecha_pago date not null,
pago boolean,
foreign key (id_us_pago) references usuario (id_usuario)
on delete cascade 
on update cascade

);
create table usuario_invitado(
id_us_invi int primary key not null,
foreign key(id_us_invi) references usuario (id_usuario)
on delete cascade 
on update cascade

);

create table usuario_adm(
id_us_adm int primary key not null,
foreign key (id_us_adm) references usuario (id_usuario)
on delete cascade 
on update cascade

);

create table banners(
id_banners int primary key not null auto_increment,
ruta varchar(120) not null
);

create table notificaciones(
id_notificacion int primary key not null auto_increment,
ruta varchar(120) not null
);

create table idioma(
id_idioma int primary key not null auto_increment,
idioma enum ('1','2')not null
);


create table pertenece(
id_depor_grup int  not null,
id_equipo int  not null,
fecha_fichaje date not null,
primary key (id_depor_grup,id_equipo),
foreign key (id_depor_grup) references deportista(id_deportista),
foreign key (id_equipo) references equipo (id_equipo)
);

create table participan(
id_equipo int not null,
id_depor_grup int not null,
id_evento_vs int not null,
resultado enum('gano','empato','perdio') null,
primary key(id_equipo,id_depor_grup,id_evento_vs), 
foreign key (id_equipo) references equipo (id_equipo),
foreign key (id_depor_grup) references deportista_grup(id_depr_grup),
foreign key (id_evento_vs) references vs (id_evento_vs)
);

create table participa(
id_depor_individual int not null,
id_evento_vs int not null,
resultado enum ('gano','empato','perdio') not null,
primary key (id_depor_individual,id_evento_vs),
foreign key (id_depor_individual) references deportista_individual(id_depr_individual),
foreign key (id_evento_vs) references vs (id_evento_vs)
);

create table corresponde(
id_evento int  not null,
id_disciplina int  not null,
 primary key (id_evento,id_disciplina ),
foreign key (id_evento) references evento (id_evento)
on delete cascade 
on update cascade,
foreign key (id_disciplina) references disciplina (id_disciplina)
on delete cascade 
on update cascade

);

create table tiene(
id_evento int primary key not null,
id_detalles int not null,
descripcion varchar(150) not null,
foreign key (id_evento) references evento (id_evento)
on delete cascade 
on update cascade,
foreign key (id_detalles) references detalles (id_detalles)
on delete cascade 
on update cascade

);

create table prefiere(
id_usuario int  not null,
id_idioma int  not null,
primary key(id_usuario,id_idioma),
foreign key (id_usuario) references usuario (id_usuario)
on delete cascade 
on update cascade,
foreign key (id_idioma) references idioma (id_idioma)
on delete cascade 
on update cascade

);

create table se_muestra(
id_us_invi int not null,
id_banners int not null,
primary key (id_us_invi,id_banners),
foreign key (id_us_invi) references usuario_invitado (id_us_invi)on delete cascade 
on update cascade,
foreign key (id_banners) references banners (id_banners)
on delete cascade 
on update cascade

);

create table ingresa(
id_us_adm int  not null,
id_notificacion int  not null,
primary key(id_us_adm,id_notificacion),
foreign key (id_us_adm) references usuario_adm(id_us_adm) on delete cascade 
on update cascade,
foreign key (id_notificacion) references notificaciones (id_notificacion)
on delete cascade 
on update cascade

);

create table se_envia(
id_us_pago int not null,
id_not int  not null,
primary key(id_us_pago,id_not),
foreign key (id_us_pago) references usuario_pago(id_us_pago)on delete cascade 
on update cascade,
foreign key (id_not) references notificaciones (id_notificacion)
on delete cascade 
on update cascade

);


create table participan_masivo(
id_evento_mas int  not null,
id_equipo int not null,
id_depor_grup int  not null,
lugarenpodio int not null,
primary key (id_evento_mas,id_equipo,id_depor_grup),
foreign key (id_evento_mas) references masivo(id_evnt_mas)on delete cascade 
on update cascade,
foreign key (id_equipo) references equipo(id_equipo),
foreign key (id_depor_grup) references deportista_grup(id_depr_grup)
on delete cascade 
on update cascade

);

create table participa_masivo(
id_evento_mas int  not null,
id_depor_individual int not null,
lugarenpodio int not null,
primary key(id_evento_mas,id_depor_individual),
foreign key (id_evento_mas) references masivo (id_evnt_mas)on delete cascade 
on update cascade
,
foreign key (id_depor_individual) references deportista_individual(id_depr_individual)on delete cascade 
on update cascade

);
/*se va a usra para colocar en espera a los usuarios que quieran realizar el pago*/
create table usuario_espera_pago(
nombre_clave varchar(50) not null,
primary key (nombre_clave)
);


CREATE TABLE `usuario_provisorio` (
  id int(11) NOT NULL AUTO_INCREMENT,
  nombre varchar(45) NOT NULL,
  apellido varchar(45) NOT NULL,
  email varchar(45) NOT NULL,
  rol varchar(45) NOT NULL,
  nombre_clave varchar(45) NOT NULL,
  contrasena varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
);

alter table usuario_espera_pago 
add id_usuario int not null; 