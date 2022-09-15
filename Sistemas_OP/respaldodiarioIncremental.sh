#!/bin/bash
fecha=(date +"%d-%m-%y")

mkadir /etc/home/respaldodiario$fecha

cp /etc/passwd /etc/passwdBackup 
gzip /etc/passwdBackup 
mv /etc/passwdBackup.gz   /etc/home/respaldodiario$fecha
  
#Respaldo /etc/group 
cp /etc/group /etc/groupBackup 
gzip /etc/groupBackup 
mv /etc/groupBackup.gz  /etc/home/respaldodiario$fecha
   
#Respaldo /etc/shadow 
cp /etc/shadow /etc/shadowBackup 
gzip /etc/shadowBackup 
mv /etc/shadowBackup.gz  /etc/home/respaldodiario$fecha

#Respaldo /etc/login.defs 
cp /etc/login.defs /etc/login.defsBackup 
gzip /etc/login.defsBackup 
mv /etc/login.defsBackup.gz   /etc/home/respaldodiario$fecha

mysqldump -u root -p contrasña  sport360 > /home/respaldodiario$fecha/sport360.sql

mt -t /dev/nst0 rewind
mt -t /dev/nst0 eod
tar -cz -g /snapshot -f /dev/nst0 -T /etc/home/respaldodiario$fecha.tar.gz
mt -t /dev/nst0 rewind


rm -r   /etc/home/respaldodiario$fecha