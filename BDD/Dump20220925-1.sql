-- MariaDB dump 10.19  Distrib 10.4.24-MariaDB, for Win64 (AMD64)
--
-- Host: 127.0.0.1    Database: sport360
-- ------------------------------------------------------
-- Server version	10.4.24-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
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
) ENGINE=InnoDB AUTO_INCREMENT=52 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `deportista`
--

LOCK TABLES `deportista` WRITE;
/*!40000 ALTER TABLE `deportista` DISABLE KEYS */;
INSERT INTO `deportista` VALUES (1,'1989-10-31','luis','suarez','uruguay',1),(2,'1989-10-31','carlos','bueno','uruguay',1),(3,'1995-05-08','Roberto','Suarez','Uruguay',1),(4,'2000-10-29','Alberto','Diaz','Uruguay',1),(5,'1990-01-13','Willian','Gonzales','Argentina',1),(6,'2001-05-22','Gonzalo','Ramos','Argentina',1),(7,'1993-10-24','Facundo','Torres','España',1),(8,'1987-06-19','Damian','Olivera','España',1),(9,'1987-06-20','Iñaki','Peña','España',1),(10,'1987-06-21','Sergiño','Dest','Brasil',1),(11,'1987-06-22','Gerade','Pique','España',1),(12,'1987-06-23','Ronald','Araujo','Uruguay',1),(13,'1987-06-24','Jordi','Alba','España',1),(14,'1987-06-25','Sergio','Busquets','España',1),(15,'1987-06-26','Pedri','A','España',1),(16,'1987-06-27','Sergio','Roberto','España',1),(17,'1987-06-28','Robert','Lewandowski','Polonia',1),(18,'1987-06-29','Raphina','D','Brasil',1),(19,'1987-06-20','Ferran','Torres','España',1),(20,'1987-05-01','Courtois','Silva','España',1),(21,'1987-05-02','Daniel','Carvajal','España',1),(22,'1987-05-03','Eder','Militao','Brasil',1),(23,'1987-05-04','David','Alaba','Asturia',1),(24,'1987-05-05','Ferland','Mendy','Francia',1),(25,'1987-05-06','Toni','Kroos','Alemania',1),(26,'1987-05-07','Luka','Modric','Croacia',1),(27,'1987-05-08','Federica','Valverde','Uruguay',1),(28,'1987-05-09','Eden','Hazard','Belgica',1),(29,'1987-05-10','karin','Benzema','Francia',1),(30,'1987-05-11','Mariano','Diaz','España',1),(31,'1987-05-12','Sergio','Rochet','Uruguay',1),(32,'1987-05-13','Nicolas','Marichal','Uruguay',1),(33,'1987-05-14','Camilo','Candido','Uruguay',1),(34,'1987-05-15','Jose','Rodrigez','Uruguay',1),(35,'1987-05-16','Leonardo','Lozano','Uruguay',1),(36,'1987-05-17','Francisco','Ginella','Uruguay',1),(37,'1987-05-18','Felipe','Carballo','Uruguay',1),(38,'1987-05-19','Bruno','Ocampo','Uruguay',1),(39,'1987-05-20','Juan','Gutierrez','Uruguay',1),(40,'1987-05-21','Franco','Fagubndez','Uruguay',1),(41,'1987-05-22','Kevin','Dawson','Uruguay',1),(42,'1987-05-23','Rodrigo','Petryk','Uruguay',1),(43,'1987-05-24','Pedro','Milans','Uruguay',1),(44,'1987-05-25','Yeferson','Quintana','Uruguay',1),(45,'1987-05-26','Matias','Agirregaray','Uruguay',1),(46,'1987-05-27','Brian','Lozano','Uruguay',1),(47,'1987-05-28','Walter','Gargano','Uruguay',1),(48,'1987-05-29','Ignacio','Laquintana','Uruguay',1),(49,'1987-05-30','Juan','Boselli','Uruguay',1),(50,'1987-01-31','Joaquin','Zeballos','Uruguay',1),(51,'1987-08-07','Lucas','Viatri','Argentina',1);
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
INSERT INTO `deportista_group` VALUES (1,'delantero'),(2,'delantero'),(3,'delantero'),(4,'defensa'),(5,'golero'),(6,'defensa'),(7,'defensa'),(8,'medio campista'),(9,'Golero'),(10,'Defensa'),(11,'Defensa'),(12,'Defensa'),(13,'Defensa'),(14,'medio campista'),(15,'medio campista'),(16,'medio campista'),(17,'delantero'),(18,'Dlantero'),(19,'Delantero'),(20,'Golero'),(21,'Defensa'),(22,'Defensa'),(23,'Defensa'),(24,'Defensa'),(25,'medio campista'),(26,'medio campista'),(27,'medio campista'),(28,'Delantero'),(29,'Delantero'),(30,'Delantero'),(31,'Golero'),(32,'Defensa'),(33,'Defensa'),(34,'Defensa'),(35,'Defensa'),(36,'medio campista'),(37,'medio campista'),(38,'Extremo Derecho'),(39,'Delantero'),(40,'Delantero'),(41,'Golero'),(42,'Defensa'),(43,'Defensa'),(44,'Defensa'),(45,'Defensa'),(46,'Mediocampista'),(47,'Mdiocampista'),(48,'Mediocampista'),(49,'Delantero'),(50,'Delantero'),(51,'Delantero');
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
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `disciplina`
--

LOCK TABLES `disciplina` WRITE;
/*!40000 ALTER TABLE `disciplina` DISABLE KEYS */;
INSERT INTO `disciplina` VALUES (1,'futbol');
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
INSERT INTO `equipo` VALUES (1,'Nacional','uruguay',1),(2,'peñarol','uruguay',1),(3,'Rampla','uruguay',1),(4,'Cerro','Uruguay',1),(5,'Boca','Argentina',1),(6,'River','Argentina',1),(7,'Barcelona','España',1),(8,'Real_Madrid','España',1);
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
  `fecha_inicio` date NOT NULL,
  `hora_de_inicio` time DEFAULT NULL,
  `inicio` tinyint(1) NOT NULL,
  `final` tinyint(1) NOT NULL,
  `resultado` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id_evento`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `evento`
--

LOCK TABLES `evento` WRITE;
/*!40000 ALTER TABLE `evento` DISABLE KEYS */;
INSERT INTO `evento` VALUES (1,'uruguay','peñarol vs nasional','0000-00-00','14:15:00',1,1,'peñarol 1 nasional 2'),(2,'uruguay','peñarol vs nasional','2022-01-08','14:15:00',1,1,'peñarol 1 nasional 2'),(3,'uruguay','rampla vs cerro','2022-08-13','14:15:00',1,1,'rampla 2 cerro 0'),(4,'Uruguay','Peñarol vs Nacional','2022-11-21','18:30:00',1,1,'Peñarol 3 Nacional 2'),(5,'Argentina','Boca vs River','2022-10-25','20:30:00',1,1,'Boca 5 River 0'),(6,'España','Barcelona vs Real Madrid','2022-11-16','14:00:00',1,1,'Barcelona 6  Real Madrid 2'),(7,'España','Real Madrid vs Barcelona','2022-12-14','18:30:00',0,0,'  '),(8,'Uruguay','Copa de clubes','2022-02-01','15:00:00',1,1,'Campeon Barcelona'),(9,'Uruguay','Peñarol vs Nacional','2022-02-01','15:00:00',1,1,'Peñarol 1 Nacional 2'),(10,'Uruguay','Barcelona vs Real Madrid','2022-02-02','15:00:00',1,1,'Barcelona 3  Real Madrid 1'),(11,'Uruguay','Bacelona vs nacional','2022-02-04','15:00:00',1,1,'Barcelona 4 nacional 1'),(12,'Uruguay','Real Madrid vs Peñarol','2022-02-06','15:00:00',1,1,'Real madrid 4 Peñarol 1'),(13,'Uruguay','Nacional vs Real Madrid','2022-02-08','15:00:00',1,1,'Nacional 1 Real Madrid 4'),(14,'Uruguay','Peñarol vs Barcelona','2022-02-10','15:00:00',1,1,'Peñarol 1 Barcelona 4');
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
INSERT INTO `masivo` VALUES (8,'copa de clubes');
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
  `resultado` enum('gano','empato','perdio') DEFAULT NULL,
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
  `resultado` enum('gano','empato','perdio') DEFAULT NULL,
  PRIMARY KEY (`id_equipo`,`id_depor_grup`,`id_evento_vs`),
  KEY `id_depor_grup` (`id_depor_grup`),
  KEY `id_evento_vs` (`id_evento_vs`),
  CONSTRAINT `participan_ibfk_1` FOREIGN KEY (`id_equipo`) REFERENCES `equipo` (`id_equipo`),
  CONSTRAINT `participan_ibfk_2` FOREIGN KEY (`id_depor_grup`) REFERENCES `deportista_group` (`id_depr_grup`),
  CONSTRAINT `participan_ibfk_3` FOREIGN KEY (`id_evento_vs`) REFERENCES `vs` (`id_evento_vs`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `participan`
--

LOCK TABLES `participan` WRITE;
/*!40000 ALTER TABLE `participan` DISABLE KEYS */;
INSERT INTO `participan` VALUES (1,1,1,'perdio'),(1,1,9,'gano'),(1,1,11,'perdio'),(1,1,13,'perdio'),(1,31,9,'gano'),(1,31,11,'perdio'),(1,31,13,'perdio'),(1,32,9,'gano'),(1,32,11,'perdio'),(1,32,13,'perdio'),(1,33,9,'gano'),(1,33,11,'perdio'),(1,33,13,'perdio'),(1,34,9,'gano'),(1,34,11,'perdio'),(1,34,13,'perdio'),(1,35,9,'gano'),(1,35,11,'perdio'),(1,35,13,'perdio'),(1,36,9,'gano'),(1,36,11,'perdio'),(1,36,13,'perdio'),(1,37,9,'gano'),(1,37,11,'perdio'),(1,37,13,'perdio'),(1,38,9,'gano'),(1,38,11,'perdio'),(1,38,13,'perdio'),(1,39,9,'gano'),(1,39,11,'perdio'),(1,39,13,'perdio'),(1,40,9,'gano'),(1,40,11,'perdio'),(1,40,13,'perdio'),(2,2,1,'gano'),(2,41,9,'perdio'),(2,41,12,'perdio'),(2,41,14,'perdio'),(2,42,9,'perdio'),(2,42,12,'perdio'),(2,42,14,'perdio'),(2,43,9,'perdio'),(2,43,12,'perdio'),(2,43,14,'perdio'),(2,44,9,'perdio'),(2,44,12,'perdio'),(2,44,14,'perdio'),(2,45,9,'perdio'),(2,45,12,'perdio'),(2,45,14,'perdio'),(2,46,9,'perdio'),(2,46,12,'perdio'),(2,46,14,'perdio'),(2,47,9,'perdio'),(2,47,12,'perdio'),(2,47,14,'perdio'),(2,48,9,'perdio'),(2,48,12,'perdio'),(2,48,14,'perdio'),(2,49,9,'perdio'),(2,49,12,'perdio'),(2,49,14,'perdio'),(2,50,9,'perdio'),(2,50,12,'perdio'),(2,50,14,'perdio'),(2,51,9,'perdio'),(2,51,12,'perdio'),(2,51,14,'perdio'),(3,3,3,'gano'),(4,4,3,'perdio'),(5,5,5,'gano'),(6,6,6,'perdio'),(7,8,6,'gano'),(7,9,7,NULL),(7,9,10,'gano'),(7,9,11,'gano'),(7,9,14,'gano'),(7,10,7,NULL),(7,10,10,'gano'),(7,10,11,'gano'),(7,10,14,'gano'),(7,11,7,NULL),(7,11,10,'gano'),(7,11,11,'gano'),(7,11,14,'gano'),(7,12,7,NULL),(7,12,10,'gano'),(7,12,11,'gano'),(7,12,14,'gano'),(7,13,7,NULL),(7,13,10,'gano'),(7,13,11,'gano'),(7,13,14,'gano'),(7,14,7,NULL),(7,14,10,'gano'),(7,14,11,'gano'),(7,14,14,'gano'),(7,15,7,NULL),(7,15,10,'gano'),(7,15,11,'gano'),(7,15,14,'gano'),(7,16,7,NULL),(7,16,10,'gano'),(7,16,11,'gano'),(7,16,14,'gano'),(7,17,7,NULL),(7,17,10,'gano'),(7,17,11,'gano'),(7,17,14,'gano'),(7,18,7,NULL),(7,18,10,'gano'),(7,18,11,'gano'),(7,18,14,'gano'),(7,19,7,NULL),(7,19,10,'gano'),(7,19,11,'gano'),(7,19,14,'gano'),(8,7,6,'perdio'),(8,20,7,NULL),(8,20,10,'perdio'),(8,20,12,'gano'),(8,20,13,'gano'),(8,21,7,NULL),(8,21,10,'perdio'),(8,21,12,'gano'),(8,21,13,'gano'),(8,22,7,NULL),(8,22,10,'perdio'),(8,22,12,'gano'),(8,22,13,'gano'),(8,23,7,NULL),(8,23,10,'perdio'),(8,23,12,'gano'),(8,23,13,'gano'),(8,24,7,NULL),(8,24,10,'perdio'),(8,24,12,'gano'),(8,24,13,'gano'),(8,25,7,NULL),(8,25,10,'perdio'),(8,25,12,'gano'),(8,25,13,'gano'),(8,26,7,NULL),(8,26,10,'perdio'),(8,26,12,'gano'),(8,26,13,'gano'),(8,27,7,NULL),(8,27,10,'perdio'),(8,27,12,'gano'),(8,27,13,'gano'),(8,28,7,NULL),(8,28,10,'perdio'),(8,28,12,'gano'),(8,28,13,'gano'),(8,29,7,NULL),(8,29,10,'perdio'),(8,29,12,'gano'),(8,29,13,'gano'),(8,30,10,'perdio');
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
INSERT INTO `participan_masivo` VALUES (8,1,1,3),(8,1,31,3),(8,1,32,3),(8,1,33,3),(8,1,34,3),(8,1,35,3),(8,1,36,3),(8,1,37,3),(8,1,38,3),(8,1,39,3),(8,1,40,3),(8,2,41,4),(8,2,42,4),(8,2,43,4),(8,2,44,4),(8,2,45,4),(8,2,46,4),(8,2,47,4),(8,2,48,4),(8,2,49,4),(8,2,50,4),(8,2,51,4),(8,7,9,1),(8,7,10,1),(8,7,11,1),(8,7,12,1),(8,7,13,1),(8,7,14,1),(8,7,15,1),(8,7,16,1),(8,7,17,1),(8,7,18,1),(8,7,19,1),(8,7,20,1),(8,8,21,2),(8,8,22,2),(8,8,23,2),(8,8,24,2),(8,8,25,2),(8,8,26,2),(8,8,27,2),(8,8,28,2),(8,8,29,2),(8,8,30,2);
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
INSERT INTO `pertenece` VALUES (1,1,'2022-09-24'),(2,2,'2022-09-24'),(3,3,'2022-05-01'),(4,4,'2019-05-08'),(5,5,'2019-01-09'),(6,6,'2019-01-10'),(7,8,'2019-01-11'),(8,7,'2019-01-12'),(9,7,'2019-01-13'),(10,7,'2019-01-14'),(11,7,'2019-01-15'),(12,7,'2019-01-16'),(13,7,'2019-01-17'),(14,7,'2019-01-18'),(15,7,'2019-01-19'),(16,7,'2019-01-20'),(17,7,'2019-01-21'),(18,7,'2019-01-22'),(19,7,'2019-01-23'),(20,8,'2010-06-01'),(21,8,'2010-06-02'),(22,8,'2010-06-03'),(23,8,'2010-06-04'),(24,8,'2010-06-05'),(25,8,'2010-06-06'),(26,8,'2010-06-07'),(27,8,'2010-06-08'),(28,8,'2010-06-09'),(29,8,'2010-06-10'),(31,1,'2021-09-01'),(32,1,'2021-09-02'),(33,1,'2021-09-03'),(34,1,'2021-09-04'),(35,1,'2021-09-05'),(36,1,'2021-09-06'),(37,1,'2021-09-07'),(38,1,'2021-09-08'),(39,1,'2021-09-09'),(40,1,'2021-09-10'),(41,2,'2020-03-01'),(42,2,'2020-03-02'),(43,2,'2020-03-03'),(44,2,'2020-03-04'),(45,2,'2020-03-05'),(46,2,'2020-03-06'),(47,2,'2020-03-07'),(48,2,'2020-03-08'),(49,2,'2020-03-09'),(50,2,'2020-03-10'),(51,2,'2020-03-11');
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
INSERT INTO `se_juega_por` VALUES (9,8),(10,8),(11,8),(12,8),(13,8),(14,8);
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
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (2,'FABIO FERNANDEZ','Vazquez','adrivaz@outlook.com','2','adrivas15'),(3,'Gerardo','Gonsalez','ggonza@hotmail.com','3','geragon29'),(4,'Alberto','Perez','perezal@yahoo.com','4','perezalberto12'),(5,'Gonzalo','Fernandez','Gfernandez@gmail.com','3','gfernandez'),(6,'Martin','Suarez','msuarez@gamil.com','2','msuarez'),(7,'Jose','Perez','jperez@gmail.com','3','jperez'),(8,'Daniel','Gonzalez','dgonzalez@gmail.com','4','dgonzalez'),(9,'FABio','Fernandez','f@f','1','root'),(15,'FABio','Fernandez','f@f','3','fabioDaniel5'),(16,'FABio','Fernandez','f@f','3','fabioDaniel6'),(17,'FABio','Fernandez','f@f','3','fabioDaniel7'),(18,'FABio','Fernandez','f@f','3','fabioDaniel8');
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
  CONSTRAINT `fk_user_adm` FOREIGN KEY (`id_us_adm`) REFERENCES `usuario` (`id_usuario`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario_adm`
--

LOCK TABLES `usuario_adm` WRITE;
/*!40000 ALTER TABLE `usuario_adm` DISABLE KEYS */;
INSERT INTO `usuario_adm` VALUES (2);
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
  `id_usuario` int(11) NOT NULL,
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
  CONSTRAINT `fk_user_invi` FOREIGN KEY (`id_us_invi`) REFERENCES `usuario` (`id_usuario`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario_invitado`
--

LOCK TABLES `usuario_invitado` WRITE;
/*!40000 ALTER TABLE `usuario_invitado` DISABLE KEYS */;
INSERT INTO `usuario_invitado` VALUES (15),(16),(17),(18);
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
  `fecha_pago` date NOT NULL,
  `pago` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`id_us_pago`),
  CONSTRAINT `fk_user_pago` FOREIGN KEY (`id_us_pago`) REFERENCES `usuario` (`id_usuario`) ON DELETE CASCADE ON UPDATE CASCADE
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
  `contrasena` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8mb4;
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
  CONSTRAINT `vs_ibfk_1` FOREIGN KEY (`id_evento_vs`) REFERENCES `evento` (`id_evento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vs`
--

LOCK TABLES `vs` WRITE;
/*!40000 ALTER TABLE `vs` DISABLE KEYS */;
INSERT INTO `vs` VALUES (1,'nasional','peñarol','1','2'),(3,'rampla','cerro','2','0'),(4,'Peñarol','Nacional','3','2'),(5,'Boca','River','5','0'),(6,'Barcelona','Real madrid','6','2'),(7,'Real madrid','Barcelona',NULL,NULL),(9,'Peñarol','Nacional','2','1'),(10,'Barcelona','Real madrid','3','1'),(11,'Barcelona','Nacional','4','1'),(12,'Real madrid','peñarol','4','1'),(13,'nasional','Real madrid','1','4'),(14,'Peñarol','Barcelona','1','4');
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

-- Dump completed on 2022-09-25 19:31:03
