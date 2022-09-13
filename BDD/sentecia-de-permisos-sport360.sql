

/*este usuario se va a usar para que los usuarios puedan registrace
 por primera ves, se le adjudicaran permisos de insert en la tabla usuario_temporal para guardar los datos personales 
 luego un administrador levantara los datos y creara un usuario en mysql para el nuevo cliente*/
 
create user 'usuario_invitado'@'localhost' identified by '1234';
grant insert  on sport360.usuario_temporal to 'nuevoUsuario_nvitado'@'localhost';


/*luego de que se le de de alta al nuevo usuario se le daran los sigientes permisos, en este caso se trabaja con un usuario invitado,
 luego el usuario debera ingresar una nueva contraseña */

grant select  on  sport360.usuario to 'usuario_invitado'@'localhost';
grant select on sport360.deportista to 'usuario_invitado'@'localhost';
grant select on sport360.deportista_group to 'usuario_invitado'@'localhost';
grant select on sport.deportista_individual to 'usuario_invitado'@'localhost';
grant select on sport360.equipo to 'usuario_invitado'@'localhost';
grant select on sport360.disciplina to 'usuario_invitado'@'localhost';
grant select on sport360.evento to 'usuario_invitado'@'localhost';
grant select on sport360.vs to 'usuario_invitado'@'localhost';
grant select on sport360.se_juega_por to 'usuario_invitado'@'localhost';
grant select on sport360.masivo to 'usuario_invitado'@'localhost';
grant select on sport360.detalles to 'usuario_invitado'@'localhost';
grant select on sport360.usuario_invitado to 'usuario_invitado'@'localhost';
grant select on sport360.banners to 'usuario_invitado'@'localhost';
grant select on sport360.idioma to 'usuario_invitado'@'localhost';
grant select on sport360.pertenece to 'usuario_invitado'@'localhost';
grant select on sport360.participan to 'usuario_invitado'@'localhost';
grant select on sport360.participa to 'usuario_invitado'@'localhost';
grant select on sport360.corresponde to 'usuario_invitado'@'localhost';
grant select on sport360.tiene to 'usuario_invitado'@'localhost';
grant select on sport360.prefiere to 'usuario_invitado'@'localhost';
grant select on sport360.se_muestra to 'usuario_invitado'@'localhost';
grant select on sport360.participa_masivo to 'usuario_invitado'@'localhost';
grant select on sport360.consulta to 'usuario_invitado'@'localhost';

/*se le asignan permisos de modificacion*/
grant update (nombre,apellido,email) on sport360.usuario to  'usuario_invitado'@'localhost';

/*para cambiar contraseña*/
set password for 'usuario_invitado'@'localhost' = password('12345678');
flush privileges;

/*###############################################################################################*/

/*se crea super usuario */
create user 'super_usuario'@'localhost' identified by '1234';


/*sentencias de permiso para el super usuario */
grant all privileges on sport360.* to 'superUsuario'@'localhost';

/*para cambiar contraseña*/
set password for 'super_usuario'@'localhost' = password('12345678');
flush privileges;

/*#################################################################################################3*/

/*se crea usuario administrador deportivo */
create user 'usuario_adm'@'localhost' identified by '1234';

/*para cambiar contraseña*/
set password for 'usuario_adm'@'localhost' = password('12345678');

/*sentencias de permiso para el usuario administrador deportivo */

grant all privileges on sport360.deportista to 'usuario_adm'@'localhost';
grant all privileges on sport360.deportista_group to'usuario_adm'@'localhost';
grant all privileges on sport.deportista_individual to 'usuario_adm'@'localhost';
grant all privileges on sport360.equipo to 'usuario_adm'@'localhost';
grant all privileges on sport360.disciplina to 'usuario_adm'@'localhost';
grant all privileges on sport360.evento to 'usuario_adm'@'localhost';
grant all privileges on sport360.vs to 'usuario_adm'@'localhost';
grant all privileges on sport360.se_juega_por to'usuario_adm'@'localhost';
grant all privileges on sport360.masivo to 'usuario_adm'@'localhost';
grant all privileges on sport360.detalles to 'usuario_adm'@'localhost';
grant all privileges on sport360.usuario_invitado to 'usuario_adm'@'localhost';
grant all privileges on sport360.banners to 'usuario_adm'@'localhost';
grant all privileges on sport360.pertenece to 'usuario_adm'@'localhost';
grant all privileges on sport360.participan to 'usuario_adm'@'localhost';
grant all privileges on sport360.participa to 'usuario_adm'@'localhost';
grant all privileges on sport360.corresponde to 'usuario_adm'@'localhost';
grant all privileges on sport360.tiene to 'usuario_adm'@'localhost';
grant all privileges on sport360.se_muestra to 'usuario_adm'@'localhost';
grant all privileges on sport360.participa_masivo to 'usuario_adm'@'localhost';

flush privileges;



