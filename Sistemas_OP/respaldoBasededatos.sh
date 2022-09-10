
#!/bin/bash
mysqldump -u root -p contrasña  sport360 > /home/mysql/sport360.sql

#se declara la sigiente variable para el encabezado del nombre del archivo a comprimir

nombre=(date +"%d-%m-%y").tar.gz 

tar -cvfp /dev/tape  /home/mysql/sport360$nombre 

rm -r   /home/mysql/sport360.sql