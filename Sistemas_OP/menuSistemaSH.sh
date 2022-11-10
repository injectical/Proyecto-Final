!#/bin/bash
clear
opcPrincipal=1
while [ $opcPrincipal -ne 0 ]

do

echo "0-Salir"
echo "1-Administrar usuarios"
echo "2-Ver eventos de log"
echo "3-Administrar conexiones"
echo "4-Adminsitrar procesos"
echo "5-Adminsitrar servicios"
echo "6-Administrar respaldos"
echo""
read -p "elija una opcion: " opcPrincipal


case $opcPrincipal in 

1)

clear
opcUsuarios=1 
while [ $opcUsuarios -ne 0 ]

do 

echo "0- Salir"
echo "1- Alta de usuario"
echo "2- Modificacion de usuario"
echo "3- Eliminar usuario"
read -p "Ingrese opcion: " opcUsuarios

case $opcUsuarios in

1) read -p "Ingrese el nombre de usuario: " nombre
   #Chequea que el usuario no exista para dar paso a useradd y passwd
   getent passwd $nombre > /dev/null
     
     if [ $? -eq 0 ];
     then
        echo -e "\033[31mEl usuario ya existe\033[0m"
        sleep 2
     else
	useradd $nombre
	passwd $nombre

     fi
;;

2) read -p "Ingrese el nombre de usuario: " nombre
   read -p "Ingrese el nombre nuevo: " nuevoNombre
   usermod -l $nuevoNombre $nombre
   passwd $nuevoNombre
;;

3) read -p "Ingrese el nombre de usuario: " nombre
   userdel -rf $nombre
;;

0) clear
;;

*) echo "opcion incorrecta"
   clear
;;

esac

done
;;

2)
clear
opcLogs=1
while [ $opcLogs -ne 0 ]

do

echo "0-Atrás"
echo "1-Ver inicios de sesión"
echo "2-Ver quien esta conectado"
echo "3-Ver intentos fallidos de inicio de sesión"
echo "4-Ver actividad actual"
echo "5-Ver ultimo inicio de sesión de cada usuario"

echo ""
read -p "Elija una opcion: " opcLogs


case $opcLogs in 

1)clear
	read -p "Ingrese la cantidad de lineas que desea ver " num 
	last -d -"$num" | tac
	echo
	read -p "Presione enter para continuar"
;;

2)clear
	who -H
  	echo 
	read -p "Presione enter para continuar"

;;

3)clear
 	lastb | tac
        echo
	read -p "Presione enter para continuar"
;;

4)clear
	w
	echo
	read -p "Presione enter para continuar"
;;

5)clear
	lastlog
	echo
	read -p "Presione enter para continuar"

;;
0)clear
;;

*)clear 
	echo -e "\033[31m opcion incorrecta\033[0m"
        echo
;;

esac

done 
;;
3)
clear 
opcConexion=1

while  [ $opcConexion -ne 0 ] 
do

echo "0- Atrás"
echo "1- Ver estado general de la red"
echo "2- Cambiar el nombre del host"
echo "3- Resetear la red"
echo "4- Activar/desactivar una conexión"
echo "5- Crear una nueva conexión"
echo " "
read -p "Ingrese opción " opcConexion

case $opcConexion in

1) nmcli general status
   sleep 3
   clear
;;

2) read -p "Ingrese nuevo nombre de host " nombre
   nmcli general hostname $nombre

   if [ $? -eq 0 ];
then
   sleep 1
   read -p "¡Nombre de host cambiado con éxito! Reiniciar el equipo?S o N" reiniciar
   if [ $reiniciar == S ] || [ $reiniciar == s ];
then 
     reboot
else 
    echo "El cambio se verá en el próximo reinicio"
    sleep 2
    clear
fi
fi
;;

3) nmcli networking off
   sleep 1
   nmcli net on 2> /dev/null
   if [ $? -eq 0 ];
then 
   sleep 3
   echo "Conectividad:" && nmcli networking connectivity check
   sleep 2
else 
   
   echo "Hubo un error al activar la red"
   sleep 2
fi
clear

;;

4)  
   sleep 1
   opcConn=1
   while [ $opcConn -ne 0 ]
do
   nmcli connection show
   echo "0-Salir "
   echo "1-Activar conexion"
   echo "2-Desactivar conexion"
   
   read -p "Que desea hacer? " opcConn
   case $opcConn in
         1) read -p "Ingrese nombre de la conexion" nombreConn
            nmcli connection up $nombreConn 1> /dev/null
            sleep 1
            nmcli general status
            sleep 3
            clear
	 ;;
 	 
         2) read -p "Ingrese nombre de la conexion" nombreConn
            nmcli connection down $nombreConn 1> /dev/null
            sleep 1
            nmcli general status
            sleep 3
            clear
         ;;
         0) clear
         ;;
         *) echo -e "\033[31mOpcion incorrecta\033[0m"
            clear
         ;; 
         
esac
done    

;;

5)  echo "Lista de interfaces disponibles (ifname): "
    cat /etc/sysconfig/network-scripts/ifcfg* | grep DEVICE
    sleep 3
    read -p "Agregar nueva conexion? S/N " opc
    if [ $opc == s ] || [ $opc == S ];
then 
    read -p "Nombre de la conexion: " nombre
    read -p "Interaz (ver lista disponibles) " interfaz
    read -p "Ingrese dirección IP para la conexion " ip
    read -p "Ingrese puerta de enlace para la conexion " gw
    nmcli connection add con-name $nombre ifname $interfaz type ethernet ip4 $ip gw4 $gw 1> /dev/null && 2> /dev/null
fi 
    if [ $? -eq 0 ];
then
    echo -e "\033[32mNueva conexion creada satisfactoriamente\033[0m"
    sleep 2
else 
    echo -e "\033[31mHubo un error al crear la conexion\033[0m"
    sleep 2
fi
clear
;;

0) clear
;;

*) clear  
;;  
esac
done

;;

4)
clear
opcProcesos=1
while [ $opcProcesos -ne 0 ]

do

echo "0-Atrás"
echo "1-Ver procesos"
echo "2-Detener un proceso"
echo ""
read -p "Elija una opcion: " opcProcesos


case $opcProcesos in 
 1) ps -a | ps -A | more
   
;;
 2) clear
    
    opcTerminar=1
    while [ $opcTerminar -ne 0 ] 
do 

echo "0- Atrás"
echo "1- Terminar un proceso por ID"
echo "2- Terminar un proceso por nombre"
echo ""
read -p "Ingrese una opción " opcTerminar

case $opcTerminar in

1) ps -a | ps -A  
read -p "Ingrese ID de proceso a terminar " numProc
ps -p $numProc 1> /dev/null && 2> /dev/null
if [ $? -eq 0 ];
then
   kill $numProc 
   sleep 3
   ps -p $numProc 1> /dev/null && 2> /dev/null
   if [ $? -eq 1 ];
then 
    
    echo -e "\033[32mProceso terminado con exito\033[0m"
else 
    echo -e "\033[31mOcurrio un error\033[0m"
fi
else
   echo -e "\033[31mNo existe un proceso con ese numero\033[0m"
fi
;;
2) read -p "Ingrese NOMBRE de proceso a terminar " nomProc
ps -C $nomProc 1> /dev/null && 2> /dev/null
if [ $? -eq 0 ];
then
    pkill -9 $nomProc
    ps -a | ps -A | grep $nomProc
    if [ $? -eq 1 ];
then 
    echo -e "\033[32m Proceso terminado con exito \033[0m"
else 
    echo -e "\033[31m Ocurrio un problema \033[0m"
fi
else 
    echo -e "\033[31m No existe un proceso con ese nombre \033[0m"
fi
;;
0) $opcTerminar=0
 clear
;;
*) clear
;;
esac
done
;;
 0) clear
;;

*) clear
;;
esac
done
;;

5)
clear
opcServicios=1
while [ $opcServicios -ne 0 ]

do

echo "0-Atrás"
echo "1-Ver "
echo "2-Ver "
echo "3-Ver "
echo "4-Ver "
echo "5-Ver "
echo ""
read -p "Elija una opcion: " opcServicios


case $opcServicios in 
 1)
;;
 2)
;;
 3)
;;
 4)
;;
 5)
;;
 0)clear
;;
*) clear
;;
esac
done
;;

6)
clear
opcRespaldos=1
while [ $opcRespaldos -ne 0 ]

do

echo "0-Atrás"
echo "1-Respaldar directorio"
echo "2-Ver respaldos programados"
echo ""
read -p "Elija una opcion: " opcRespaldos


case $opcRespaldos in 
 1) cd /
    echo ""
    read -p "Que desea respaldar?" Archivo
    find -iname $Archivo | more
    echo ""
    sleep 2
    indice=0    
    parametro=1   
    camino=" " 
    fecha=$(date "%d %m %y")
    while [ "$camino" != "x" ]
    do
       
       read -p "Escriba el elemento $parametro de la ruta, al finalizar pulse x: " camino

        [ "$camino" = "x" ] && break

	arrayCamino[$indice]=$camino 
        
        (( indice++ ))
        (( parametro++ ))
    done       
    read -p "Nombre del archivo a crear: " nombreRespaldo
    
	for i in "${arrayCamino[@]}"
        do

          path+=/${arrayCamino[i]}
       
        done
    mkdir /respaldos/$nombreRespaldo$fecha.tar.gz
    cp -r $path /respaldos/$nombreRespaldo$fecha.tar.gz
    tar -czvfr /respaldos/$nombreRespaldo$fecha.tar.gz
;;
 2) crontab -l | sed -n 1p
    echo ""
    crontab -l | sed -n 4p
    sleep 5
    clear
  
;;

0) 
   
;;
*) clear
;;

esac

done
;;
0) exit
;;
*) clear
;;
esac 
done
