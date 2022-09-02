-- MariaDB dump 10.19  Distrib 10.4.24-MariaDB, for Win64 (AMD64)
--
-- Host: localhost    Database: sports360
-- ------------------------------------------------------
-- Server version	10.4.24-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `banners`
--

DROP TABLE IF EXISTS `banners`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `banners` (
  `id_banners` int(11) NOT NULL AUTO_INCREMENT,
  `ruta` varchar(120) NOT NULL,
  PRIMARY KEY (`id_banners`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `banners`
--

LOCK TABLES `banners` WRITE;
/*!40000 ALTER TABLE `banners` DISABLE KEYS */;
/*!40000 ALTER TABLE `banners` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `corresponde`
--

DROP TABLE IF EXISTS `corresponde`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `corresponde` (
  `id_evento` int(11) NOT NULL,
  `id_disciplina` int(11) NOT NULL,
  PRIMARY KEY (`id_evento`,`id_disciplina`),
  KEY `id_disciplina` (`id_disciplina`),
  CONSTRAINT `corresponde_ibfk_1` FOREIGN KEY (`id_evento`) REFERENCES `evento` (`id_evento`),
  CONSTRAINT `corresponde_ibfk_2` FOREIGN KEY (`id_disciplina`) REFERENCES `disciplina` (`id_disciplina`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `corresponde`
--

LOCK TABLES `corresponde` WRITE;
/*!40000 ALTER TABLE `corresponde` DISABLE KEYS */;
INSERT INTO `corresponde` VALUES (3,1),(7,1),(8,2),(9,3);
/*!40000 ALTER TABLE `corresponde` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `deportista`
--

DROP TABLE IF EXISTS `deportista`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `deportista` (
  `id_deportista` int(11) NOT NULL AUTO_INCREMENT,
  `fecha_nac` date NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `apellido` varchar(50) NOT NULL,
  `pais` varchar(50) DEFAULT NULL,
  `id_disciplina_depor` int(11) NOT NULL,
  PRIMARY KEY (`id_deportista`),
  KEY `id_disciplina_depor` (`id_disciplina_depor`),
  CONSTRAINT `deportista_ibfk_1` FOREIGN KEY (`id_disciplina_depor`) REFERENCES `disciplina` (`id_disciplina`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `deportista`
--

LOCK TABLES `deportista` WRITE;
/*!40000 ALTER TABLE `deportista` DISABLE KEYS */;
INSERT INTO `deportista` VALUES (1,'1989-10-31','luis','suarez','uruguay',1),(2,'1989-10-31','carlos','bueno','uruguay',1),(3,'1995-05-08','Roberto','Suarez','Uruguay',1),(4,'2000-10-29','Alberto','Diaz','Uruguay',1),(5,'1990-01-13','Willian','Gonzales','Argentina',1),(6,'2001-05-22','Gonzalo','Ramos','Argentina',1),(7,'1993-10-24','Facundo','Torres','España',1),(8,'1987-06-19','Damian','Olivera','España',1);
/*!40000 ALTER TABLE `deportista` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `deportista_group`
--

DROP TABLE IF EXISTS `deportista_group`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `deportista_group` (
  `id_depr_grup` int(11) NOT NULL,
  `posicion` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_depr_grup`),
  CONSTRAINT `deportista_group_ibfk_1` FOREIGN KEY (`id_depr_grup`) REFERENCES `deportista` (`id_deportista`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `deportista_group`
--

LOCK TABLES `deportista_group` WRITE;
/*!40000 ALTER TABLE `deportista_group` DISABLE KEYS */;
INSERT INTO `deportista_group` VALUES (1,'delantero'),(2,'delantero'),(3,'delantero'),(4,'defensa'),(5,'golero'),(6,'defensa'),(7,'defensa'),(8,'medio campista');
/*!40000 ALTER TABLE `deportista_group` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `deportista_individual`
--

DROP TABLE IF EXISTS `deportista_individual`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `deportista_individual` (
  `id_depr_individual` int(11) NOT NULL,
  PRIMARY KEY (`id_depr_individual`),
  CONSTRAINT `deportista_individual_ibfk_1` FOREIGN KEY (`id_depr_individual`) REFERENCES `deportista` (`id_deportista`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `deportista_individual`
--

LOCK TABLES `deportista_individual` WRITE;
/*!40000 ALTER TABLE `deportista_individual` DISABLE KEYS */;
/*!40000 ALTER TABLE `deportista_individual` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalles`
--

DROP TABLE IF EXISTS `detalles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalles` (
  `id_detalles` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_det` varchar(10) NOT NULL,
  PRIMARY KEY (`id_detalles`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalles`
--

LOCK TABLES `detalles` WRITE;
/*!40000 ALTER TABLE `detalles` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `disciplina`
--

DROP TABLE IF EXISTS `disciplina`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `disciplina` (
  `id_disciplina` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) NOT NULL,
  PRIMARY KEY (`id_disciplina`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `disciplina`
--

LOCK TABLES `disciplina` WRITE;
/*!40000 ALTER TABLE `disciplina` DISABLE KEYS */;
INSERT INTO `disciplina` VALUES (1,'futbol'),(2,'basquet'),(3,'tenis'),(4,'rugby');
/*!40000 ALTER TABLE `disciplina` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `equipo`
--

DROP TABLE IF EXISTS `equipo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `equipo` (
  `id_equipo` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) NOT NULL,
  `pais` varchar(50) NOT NULL,
  `id_disciplina_equipo` int(11) NOT NULL,
  PRIMARY KEY (`id_equipo`),
  KEY `id_disciplina_equipo` (`id_disciplina_equipo`),
  CONSTRAINT `equipo_ibfk_1` FOREIGN KEY (`id_disciplina_equipo`) REFERENCES `disciplina` (`id_disciplina`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `equipo`
--

LOCK TABLES `equipo` WRITE;
/*!40000 ALTER TABLE `equipo` DISABLE KEYS */;
INSERT INTO `equipo` VALUES (1,'nasional','uruguay',1),(2,'peñarol','uruguay',1),(3,'Rampla','uruguay',1),(4,'Cerro','Uruguay',1),(5,'Boca','Argentina',1),(6,'River','Argentina',1),(7,'Barcelona','España',1),(8,'Real_Madrid','España',1);
/*!40000 ALTER TABLE `equipo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `evento`
--

DROP TABLE IF EXISTS `evento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `evento` (
  `id_evento` int(11) NOT NULL AUTO_INCREMENT,
  `pais` varchar(50) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `fecha_inicio` varchar(50) NOT NULL,
  `hora_de_inicio` varchar(50) DEFAULT NULL,
  `inicio` tinyint(1) NOT NULL,
  `final` tinyint(1) NOT NULL,
  `resultado` varchar(100) NOT NULL,
  PRIMARY KEY (`id_evento`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `evento`
--

LOCK TABLES `evento` WRITE;
/*!40000 ALTER TABLE `evento` DISABLE KEYS */;
INSERT INTO `evento` VALUES (3,'uruguay','rampla vs cerro','2022-08-13','14:15:00',1,1,'rampla 2 cerro 0'),(7,'Españasa','Barcelona vs Real Madrid','2022-11-16','14:00:00',0,0,'Barcelona 6  Real Madrid 2'),(8,'Uruguay','Aguada - Welcome','2022-05-09','21:00:00',1,1,'Aguada 90 - Welcome 89'),(9,'Uruguay','ATP Uruguay (P. Cuevas vs A. Perez)','2022-06-25','18:00:00',0,0,'6-0 / 6-3 / 5-5'),(11,'d','d','d','d',0,0,'s'),(12,'Uruguay','ATP Uruguay (P. Cuevas vs A. Perez)','2022-06-25','18:00:00',0,0,'6-0 / 6-3 / 5-5');
/*!40000 ALTER TABLE `evento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `idioma`
--

DROP TABLE IF EXISTS `idioma`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `idioma` (
  `id_idioma` int(11) NOT NULL AUTO_INCREMENT,
  `idioma` enum('1','2') NOT NULL,
  PRIMARY KEY (`id_idioma`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `idioma`
--

LOCK TABLES `idioma` WRITE;
/*!40000 ALTER TABLE `idioma` DISABLE KEYS */;
/*!40000 ALTER TABLE `idioma` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ingresa`
--

DROP TABLE IF EXISTS `ingresa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ingresa` (
  `id_us_adm` int(11) NOT NULL,
  `id_notificacion` int(11) NOT NULL,
  PRIMARY KEY (`id_us_adm`,`id_notificacion`),
  KEY `id_notificacion` (`id_notificacion`),
  CONSTRAINT `ingresa_ibfk_1` FOREIGN KEY (`id_us_adm`) REFERENCES `usuario_adm` (`id_us_adm`),
  CONSTRAINT `ingresa_ibfk_2` FOREIGN KEY (`id_notificacion`) REFERENCES `notificaciones` (`id_notificacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ingresa`
--

LOCK TABLES `ingresa` WRITE;
/*!40000 ALTER TABLE `ingresa` DISABLE KEYS */;
/*!40000 ALTER TABLE `ingresa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `masivo`
--

DROP TABLE IF EXISTS `masivo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `masivo` (
  `id_evnt_mas` int(11) NOT NULL,
  `descripcion` varchar(80) DEFAULT NULL,
  PRIMARY KEY (`id_evnt_mas`),
  CONSTRAINT `masivo_ibfk_1` FOREIGN KEY (`id_evnt_mas`) REFERENCES `evento` (`id_evento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `masivo`
--

LOCK TABLES `masivo` WRITE;
/*!40000 ALTER TABLE `masivo` DISABLE KEYS */;
/*!40000 ALTER TABLE `masivo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `notificaciones`
--

DROP TABLE IF EXISTS `notificaciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `notificaciones` (
  `id_notificacion` int(11) NOT NULL AUTO_INCREMENT,
  `ruta` varchar(120) NOT NULL,
  PRIMARY KEY (`id_notificacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `notificaciones`
--

LOCK TABLES `notificaciones` WRITE;
/*!40000 ALTER TABLE `notificaciones` DISABLE KEYS */;
/*!40000 ALTER TABLE `notificaciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `participa`
--

DROP TABLE IF EXISTS `participa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `participa` (
  `id_depor_individual` int(11) NOT NULL,
  `id_evento_vs` int(11) NOT NULL,
  `resultado` enum('gano','empato','perdio') NOT NULL,
  PRIMARY KEY (`id_depor_individual`,`id_evento_vs`),
  KEY `id_evento_vs` (`id_evento_vs`),
  CONSTRAINT `participa_ibfk_1` FOREIGN KEY (`id_depor_individual`) REFERENCES `deportista_individual` (`id_depr_individual`),
  CONSTRAINT `participa_ibfk_2` FOREIGN KEY (`id_evento_vs`) REFERENCES `vs` (`id_evento_vs`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `participa`
--

LOCK TABLES `participa` WRITE;
/*!40000 ALTER TABLE `participa` DISABLE KEYS */;
/*!40000 ALTER TABLE `participa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `participa_masivo`
--

DROP TABLE IF EXISTS `participa_masivo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `participa_masivo` (
  `id_evento_mas` int(11) NOT NULL,
  `id_depor_individual` int(11) NOT NULL,
  `lugarenpodio` int(11) NOT NULL,
  PRIMARY KEY (`id_evento_mas`,`id_depor_individual`),
  KEY `id_depor_individual` (`id_depor_individual`),
  CONSTRAINT `participa_masivo_ibfk_1` FOREIGN KEY (`id_evento_mas`) REFERENCES `masivo` (`id_evnt_mas`),
  CONSTRAINT `participa_masivo_ibfk_2` FOREIGN KEY (`id_depor_individual`) REFERENCES `deportista_individual` (`id_depr_individual`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `participa_masivo`
--

LOCK TABLES `participa_masivo` WRITE;
/*!40000 ALTER TABLE `participa_masivo` DISABLE KEYS */;
/*!40000 ALTER TABLE `participa_masivo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `participan`
--

DROP TABLE IF EXISTS `participan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `participan` (
  `id_equipo` int(11) NOT NULL,
  `id_depor_grup` int(11) NOT NULL,
  `id_evento_vs` int(11) NOT NULL,
  `resultado` enum('gano','empato','perdio') NOT NULL,
  PRIMARY KEY (`id_equipo`,`id_depor_grup`,`id_evento_vs`),
  KEY `id_depor_grup` (`id_depor_grup`),
  KEY `id_evento_vs` (`id_evento_vs`),
  CONSTRAINT `participan_ibfk_1` FOREIGN KEY (`id_equipo`) REFERENCES `equipo` (`id_equipo`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `participan_ibfk_2` FOREIGN KEY (`id_depor_grup`) REFERENCES `deportista_group` (`id_depr_grup`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `participan_ibfk_3` FOREIGN KEY (`id_evento_vs`) REFERENCES `vs` (`id_evento_vs`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `participan`
--

LOCK TABLES `participan` WRITE;
/*!40000 ALTER TABLE `participan` DISABLE KEYS */;
INSERT INTO `participan` VALUES (3,3,3,'gano'),(4,4,3,'perdio');
/*!40000 ALTER TABLE `participan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `participan_masivo`
--

DROP TABLE IF EXISTS `participan_masivo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `participan_masivo` (
  `id_evento_mas` int(11) NOT NULL,
  `id_equipo` int(11) NOT NULL,
  `id_depor_grup` int(11) NOT NULL,
  `lugarenpodio` int(11) NOT NULL,
  PRIMARY KEY (`id_evento_mas`,`id_equipo`,`id_depor_grup`),
  KEY `id_equipo` (`id_equipo`),
  KEY `id_depor_grup` (`id_depor_grup`),
  CONSTRAINT `participan_masivo_ibfk_1` FOREIGN KEY (`id_evento_mas`) REFERENCES `masivo` (`id_evnt_mas`),
  CONSTRAINT `participan_masivo_ibfk_2` FOREIGN KEY (`id_equipo`) REFERENCES `equipo` (`id_equipo`),
  CONSTRAINT `participan_masivo_ibfk_3` FOREIGN KEY (`id_depor_grup`) REFERENCES `deportista_group` (`id_depr_grup`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `participan_masivo`
--

LOCK TABLES `participan_masivo` WRITE;
/*!40000 ALTER TABLE `participan_masivo` DISABLE KEYS */;
/*!40000 ALTER TABLE `participan_masivo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pertenece`
--

DROP TABLE IF EXISTS `pertenece`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pertenece` (
  `id_depor_grup` int(11) NOT NULL,
  `id_equipo` int(11) NOT NULL,
  `fecha_fichaje` date NOT NULL,
  PRIMARY KEY (`id_depor_grup`,`id_equipo`),
  KEY `id_equipo` (`id_equipo`),
  CONSTRAINT `pertenece_ibfk_1` FOREIGN KEY (`id_depor_grup`) REFERENCES `deportista` (`id_deportista`),
  CONSTRAINT `pertenece_ibfk_2` FOREIGN KEY (`id_equipo`) REFERENCES `equipo` (`id_equipo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pertenece`
--

LOCK TABLES `pertenece` WRITE;
/*!40000 ALTER TABLE `pertenece` DISABLE KEYS */;
INSERT INTO `pertenece` VALUES (1,1,'2022-09-24'),(2,2,'2022-09-24'),(3,3,'2022-05-01'),(4,4,'2019-05-08'),(5,5,'2019-01-09'),(6,6,'2019-01-10'),(7,8,'2019-01-11'),(8,7,'2019-01-12');
/*!40000 ALTER TABLE `pertenece` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prefiere`
--

DROP TABLE IF EXISTS `prefiere`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prefiere` (
  `id_usuario` int(11) NOT NULL,
  `id_idioma` int(11) NOT NULL,
  PRIMARY KEY (`id_usuario`,`id_idioma`),
  KEY `id_idioma` (`id_idioma`),
  CONSTRAINT `prefiere_ibfk_1` FOREIGN KEY (`id_usuario`) REFERENCES `usuario` (`id_usuario`),
  CONSTRAINT `prefiere_ibfk_2` FOREIGN KEY (`id_idioma`) REFERENCES `idioma` (`id_idioma`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prefiere`
--

LOCK TABLES `prefiere` WRITE;
/*!40000 ALTER TABLE `prefiere` DISABLE KEYS */;
/*!40000 ALTER TABLE `prefiere` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `se_envia`
--

DROP TABLE IF EXISTS `se_envia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `se_envia` (
  `id_us_pago` int(11) NOT NULL,
  `id_not` int(11) NOT NULL,
  PRIMARY KEY (`id_us_pago`,`id_not`),
  KEY `id_not` (`id_not`),
  CONSTRAINT `se_envia_ibfk_1` FOREIGN KEY (`id_us_pago`) REFERENCES `usuario_pago` (`id_us_pago`),
  CONSTRAINT `se_envia_ibfk_2` FOREIGN KEY (`id_not`) REFERENCES `notificaciones` (`id_notificacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `se_envia`
--

LOCK TABLES `se_envia` WRITE;
/*!40000 ALTER TABLE `se_envia` DISABLE KEYS */;
/*!40000 ALTER TABLE `se_envia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `se_juega_por`
--

DROP TABLE IF EXISTS `se_juega_por`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `se_juega_por` (
  `id_event_vs` int(11) NOT NULL,
  `id_event_mso` int(11) NOT NULL,
  PRIMARY KEY (`id_event_vs`),
  KEY `id_event_mso` (`id_event_mso`),
  CONSTRAINT `se_juega_por_ibfk_1` FOREIGN KEY (`id_event_vs`) REFERENCES `vs` (`id_evento_vs`),
  CONSTRAINT `se_juega_por_ibfk_2` FOREIGN KEY (`id_event_mso`) REFERENCES `masivo` (`id_evnt_mas`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `se_juega_por`
--

LOCK TABLES `se_juega_por` WRITE;
/*!40000 ALTER TABLE `se_juega_por` DISABLE KEYS */;
/*!40000 ALTER TABLE `se_juega_por` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `se_muestra`
--

DROP TABLE IF EXISTS `se_muestra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `se_muestra` (
  `id_us_invi` int(11) NOT NULL,
  `id_banners` int(11) NOT NULL,
  PRIMARY KEY (`id_us_invi`,`id_banners`),
  KEY `id_banners` (`id_banners`),
  CONSTRAINT `se_muestra_ibfk_1` FOREIGN KEY (`id_us_invi`) REFERENCES `usuario_invitado` (`id_us_invi`),
  CONSTRAINT `se_muestra_ibfk_2` FOREIGN KEY (`id_banners`) REFERENCES `banners` (`id_banners`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `se_muestra`
--

LOCK TABLES `se_muestra` WRITE;
/*!40000 ALTER TABLE `se_muestra` DISABLE KEYS */;
/*!40000 ALTER TABLE `se_muestra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tiene`
--

DROP TABLE IF EXISTS `tiene`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tiene` (
  `id_evento` int(11) NOT NULL,
  `id_detalles` int(11) NOT NULL,
  `descripcion` varchar(150) NOT NULL,
  PRIMARY KEY (`id_evento`),
  KEY `id_detalles` (`id_detalles`),
  CONSTRAINT `tiene_ibfk_1` FOREIGN KEY (`id_evento`) REFERENCES `evento` (`id_evento`),
  CONSTRAINT `tiene_ibfk_2` FOREIGN KEY (`id_detalles`) REFERENCES `detalles` (`id_detalles`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tiene`
--

LOCK TABLES `tiene` WRITE;
/*!40000 ALTER TABLE `tiene` DISABLE KEYS */;
/*!40000 ALTER TABLE `tiene` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario` (
  `id_usuario` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(20) NOT NULL,
  `apellido` varchar(20) NOT NULL,
  `email` varchar(50) NOT NULL,
  `rol` enum('1','2','3','4') NOT NULL,
  `nombre_clave` varchar(16) NOT NULL,
  PRIMARY KEY (`id_usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (1,'Pedro','Sanchez','pepes@gmail.com','1','pedrosan'),(2,'Adriana','Vazquez','adrivaz@outlook.com','2','adrivas15'),(3,'Gerardo','Gonsalez','ggonza@hotmail.com','3','geragon29'),(4,'Alberto','Perez','perezal@yahoo.com','4','perezalberto12');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario_adm`
--

DROP TABLE IF EXISTS `usuario_adm`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario_adm` (
  `id_us_adm` int(11) NOT NULL,
  PRIMARY KEY (`id_us_adm`),
  CONSTRAINT `usuario_adm_ibfk_1` FOREIGN KEY (`id_us_adm`) REFERENCES `usuario` (`id_usuario`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario_adm`
--

LOCK TABLES `usuario_adm` WRITE;
/*!40000 ALTER TABLE `usuario_adm` DISABLE KEYS */;
/*!40000 ALTER TABLE `usuario_adm` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario_espera_pago`
--

DROP TABLE IF EXISTS `usuario_espera_pago`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario_espera_pago` (
  `nombre_clave` varchar(50) NOT NULL,
  PRIMARY KEY (`nombre_clave`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario_espera_pago`
--

LOCK TABLES `usuario_espera_pago` WRITE;
/*!40000 ALTER TABLE `usuario_espera_pago` DISABLE KEYS */;
/*!40000 ALTER TABLE `usuario_espera_pago` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario_invitado`
--

DROP TABLE IF EXISTS `usuario_invitado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario_invitado` (
  `id_us_invi` int(11) NOT NULL,
  PRIMARY KEY (`id_us_invi`),
  CONSTRAINT `usuario_invitado_ibfk_1` FOREIGN KEY (`id_us_invi`) REFERENCES `usuario` (`id_usuario`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario_invitado`
--

LOCK TABLES `usuario_invitado` WRITE;
/*!40000 ALTER TABLE `usuario_invitado` DISABLE KEYS */;
/*!40000 ALTER TABLE `usuario_invitado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario_pago`
--

DROP TABLE IF EXISTS `usuario_pago`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario_pago` (
  `id_us_pago` int(11) NOT NULL,
  `nombre_clave` varchar(50) NOT NULL,
  PRIMARY KEY (`id_us_pago`),
  CONSTRAINT `usuario_pago_ibfk_1` FOREIGN KEY (`id_us_pago`) REFERENCES `usuario` (`id_usuario`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario_pago`
--

LOCK TABLES `usuario_pago` WRITE;
/*!40000 ALTER TABLE `usuario_pago` DISABLE KEYS */;
/*!40000 ALTER TABLE `usuario_pago` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario_provisorio`
--

DROP TABLE IF EXISTS `usuario_provisorio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario_provisorio` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) NOT NULL,
  `apellido` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `rol` varchar(45) NOT NULL,
  `nombre_clave` varchar(45) NOT NULL,
  `contraseña` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario_provisorio`
--

LOCK TABLES `usuario_provisorio` WRITE;
/*!40000 ALTER TABLE `usuario_provisorio` DISABLE KEYS */;
/*!40000 ALTER TABLE `usuario_provisorio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `vista_1`
--

DROP TABLE IF EXISTS `vista_1`;
/*!50001 DROP VIEW IF EXISTS `vista_1`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `vista_1` (
  `NOMBRE` tinyint NOT NULL,
  `DISCIPLINA` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `vs`
--

DROP TABLE IF EXISTS `vs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vs` (
  `id_evento_vs` int(11) NOT NULL,
  `p1` varchar(80) NOT NULL,
  `p2` varchar(80) NOT NULL,
  `result_p1` varchar(100) DEFAULT NULL,
  `result_p2` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id_evento_vs`),
  CONSTRAINT `vs_ibfk_1` FOREIGN KEY (`id_evento_vs`) REFERENCES `evento` (`id_evento`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vs`
--

LOCK TABLES `vs` WRITE;
/*!40000 ALTER TABLE `vs` DISABLE KEYS */;
INSERT INTO `vs` VALUES (3,'rampla','cerro','2','0');
/*!40000 ALTER TABLE `vs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Final view structure for view `vista_1`
--

/*!50001 DROP TABLE IF EXISTS `vista_1`*/;
/*!50001 DROP VIEW IF EXISTS `vista_1`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vista_1` AS select `deportista`.`nombre` AS `NOMBRE`,`disciplina`.`nombre` AS `DISCIPLINA` from (`deportista` join `disciplina` on(`deportista`.`id_disciplina_depor` = `disciplina`.`id_disciplina`)) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-09-02 18:58:16
