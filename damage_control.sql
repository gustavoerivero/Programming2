-- MySQL dump 10.13  Distrib 5.7.25, for Linux (i686)
--
-- Host: localhost    Database: damage_control
-- ------------------------------------------------------
-- Server version	5.7.25-0ubuntu0.16.04.2

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
-- Table structure for table `bloque`
--

DROP TABLE IF EXISTS `bloque`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `bloque` (
  `codBlo` varchar(45) NOT NULL,
  `descripcionBlo` varchar(45) DEFAULT NULL,
  `estatusBlo` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`codBlo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bloque`
--

LOCK TABLES `bloque` WRITE;
/*!40000 ALTER TABLE `bloque` DISABLE KEYS */;
INSERT INTO `bloque` VALUES ('BL01','de 8:00 am a 12:00 pm','A'),('BL02','de 2:00 pm a 6:00 pm','A');
/*!40000 ALTER TABLE `bloque` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ciudad`
--

DROP TABLE IF EXISTS `ciudad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ciudad` (
  `codEsta` varchar(45) DEFAULT NULL,
  `codCiu` varchar(45) NOT NULL,
  `nombreCiu` varchar(45) DEFAULT NULL,
  `estatusCiu` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`codCiu`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ciudad`
--

LOCK TABLES `ciudad` WRITE;
/*!40000 ALTER TABLE `ciudad` DISABLE KEYS */;
INSERT INTO `ciudad` VALUES ('AM','AM01','La Esmeralda','A'),('AM','AM02','San Fernando de Atabapo','A'),('AM','AM03','Puerto Ayacucho','A'),('AM','AM04','Isla Ratón','A'),('AM','AM05','San Juan de Manapiare','A'),('AM','AM06','Maroa','A'),('AM','AM07','San Carlos de Río Negro','A'),('AN','AN01','Anaco','A'),('AN','AN02','Aragua de Barcelona','A'),('AN','AN03','Barcelona','A'),('AN','AN04','Clarines','A'),('AN','AN05','Onoto','A'),('AN','AN06','Valle de Guanape','A'),('AN','AN07','Lechería','A'),('AN','AN08','Cantaura','A'),('AN','AN09','San José de Guanipa','A'),('AN','AN10','Guanta','A'),('AN','AN11','Soledad','A'),('AN','AN12','San Mateo','A'),('AN','AN13','El Chaparro','A'),('AN','AN14','Pariaguán','A'),('AN','AN15','San Diego de Cabrutica','A'),('AN','AN16','Puerto Píritu','A'),('AN','AN17','Píritu','A'),('AN','AN18','Boca de Uchire','A'),('AN','AN19','Santa Ana','A'),('AN','AN20','El Tigre','A'),('AN','AN21','Puerto La Cruz','A'),('AP','AP01','Achaguas','A'),('AP','AP02','Biruaca','A'),('AP','AP03','Bruzual','A'),('AP','AP04','Guasdualito','A'),('AP','AP05','San Juan de Payara','A'),('AP','AP06','Elorza','A'),('AP','AP07','San Fernando de Apure','A'),('AR','AR01','San Mateo','A'),('AR','AR02','Camatagua','A'),('AR','AR03','Santa Rita','A'),('AR','AR04','Maracay','A'),('AR','AR05','Santa Cruz','A'),('AR','AR06','La Victoria','A'),('AR','AR07','El Consejo','A'),('AR','AR08','Palo Negro','A'),('AR','AR09','El Limón','A'),('AR','AR10','Ocumare de la Costa','A'),('AR','AR11','San Casimiro','A'),('AR','AR12','San Sebastián de los Reyes','A'),('AR','AR13','Turmero','A'),('AR','AR14','Las Tejerías','A'),('AR','AR15','Cagua','A'),('AR','AR16','Colonia Tovar','A'),('AR','AR17','Barbacoas','A'),('AR','AR18','Villa de Cura','A'),('BA','BA01','Sabaneta','A'),('BA','BA02','El Cantón','A'),('BA','BA03','Socopó','A'),('BA','BA04','Arismendi','A'),('BA','BA05','Barinas','A'),('BA','BA06','Barinitas','A'),('BA','BA07','Barrancas','A'),('BA','BA08','Santa Bárbara','A'),('BA','BA09','Obispos','A'),('BA','BA10','Ciudad Bolivia','A'),('BA','BA11','Libertad','A'),('BA','BA12','Ciudad de Nutrias','A'),('BO','BO01','Ciudad Guayana','A'),('BO','BO02','Caicara del Orinoco','A'),('BO','BO03','El Callao','A'),('BO','BO04','Santa Elena de Uairén','A'),('BO','BO05','Ciudad Bolívar','A'),('BO','BO06','Upata','A'),('BO','BO07','Ciudad Piar','A'),('BO','BO08','Guasipati','A'),('BO','BO09','Tumeremo','A'),('BO','BO10','Maripa','A'),('BO','BO11','El Palmar','A'),('CA','CA01','Bejuma','A'),('CA','CA02','Güigüe','A'),('CA','CA03','Mariara','A'),('CA','CA04','Guacara','A'),('CA','CA05','Morón','A'),('CA','CA06','Tocuyito','A'),('CA','CA07','Los Guayos','A'),('CA','CA08','Miranda','A'),('CA','CA09','Montalbán','A'),('CA','CA10','Naguanagua','A'),('CA','CA11','Puerto Cabello','A'),('CA','CA12','San Diego','A'),('CA','CA13','San Joaquín','A'),('CA','CA14','Valencia','A'),('CO','CO01','Cojedes','A'),('CO','CO02','Tinaquillo','A'),('CO','CO03','El Baúl','A'),('CO','CO04','Macapo','A'),('CO','CO05','El Pao','A'),('CO','CO06','Libertad','A'),('CO','CO07','Gallegos','A'),('DE','DE01','Curiapo','A'),('DE','DE02','Sierra Imataca','A'),('DE','DE03','Pedernales','A'),('DE','DE04','Tucupita','A'),('DI','DI01','Caracas','A'),('FA','FA01','San Juan de los Cayos','A'),('FA','FA02','San Luis','A'),('FA','FA03','Capatárida','A'),('FA','FA04','Yaracal','A'),('FA','FA05','Punto Fijo','A'),('FA','FA06','La Vela de Coro','A'),('FA','FA07','Dabajuro','A'),('FA','FA08','Pedregal','A'),('FA','FA09','Pueblo Nuevo','A'),('FA','FA10','Churuguara','A'),('FA','FA11','Jacura','A'),('FA','FA12','Santa Cruz de los Taques','A'),('FA','FA13','Mene de Mauroa','A'),('FA','FA14','Santa Ana de Coro','A'),('FA','FA15','Chichiriviche','A'),('FA','FA16','Palmasola','A'),('FA','FA17','Cabure','A'),('FA','FA18','Píritu','A'),('FA','FA19','Mirimire','A'),('FA','FA20','Tucacas','A'),('FA','FA21','La Cruz de Taratara','A'),('FA','FA22','Tocópero','A'),('FA','FA23','Santa Cruz de Bucaral','A'),('FA','FA24','Urumaco','A'),('FA','FA25','Puerto Cumarebo','A'),('GU','GU01','Camaguan','A'),('GU','GU02','Chaguaramas','A'),('GU','GU03','El Socorro','A'),('GU','GU04','Calabozo','A'),('GU','GU05','Tucupido','A'),('GU','GU06','Altagracia de Orituco','A'),('GU','GU07','San Juan de Los Morros','A'),('GU','GU08','El Sombrero','A'),('GU','GU09','Las Mercedes','A'),('GU','GU10','Valle de la Pascua','A'),('GU','GU11','Zaraza','A'),('GU','GU12','Ortíz','A'),('GU','GU13','Guayabal','A'),('GU','GU14','San José de Guaribe','A'),('GU','GU15','Santa María de Ipire','A'),('LA','LA01','Sanare','A'),('LA','LA02','Duaca','A'),('LA','LA03','Barquisimeto','A'),('LA','LA04','Quibor','A'),('LA','LA05','El Tocuyo','A'),('LA','LA06','Cabudare','A'),('LA','LA07','Sarare','A'),('LA','LA08','Carora','A'),('LA','LA09','Siquisique','A'),('ME','ME01','El Vigía','A'),('ME','ME02','La Azulita','A'),('ME','ME03','Santa Cruz de Mora','A'),('ME','ME04','Lagunillas','A'),('ME','ME05','Tovar','A'),('ME','ME06','Nueva Bolivia','A'),('ME ','ME07','Zea','A'),('MI','MI01','Caucagua','A'),('MI','MI02','San José de Barlovento','A'),('MI','MI03','Baruta','A'),('MI','MI04','Higuerote','A'),('MI','MI05','Mamporal','A'),('MI','MI06','Carrizal','A'),('MI','MI07','Chacao','A'),('MI','MI08','Charallave','A'),('MI','MI09','El Hatillo','A'),('MI','MI10','Los Teques','A'),('MI','MI11','Santa Teresa del Tuy','A'),('MI','MI12','Ocumare del Tuy','A'),('MI','MI13','San Antonio de los Altos','A'),('MI','MI14','Río Chico','A'),('MI','MI15','Santa Lucía','A'),('MI','MI16','Cúpira','A'),('MI','MI17','Guarenas','A'),('MI','MI18','San Francisco de Yare','A'),('MI','MI19','Petare','A'),('MI','MI20','Cúa','A'),('MI','MI21','Guatire','A'),('MO','MO01','San Antonio de Capayacuar','A'),('MO','MO02','Aguasai','A'),('MO','MO03','Municipio Bolívar','A'),('MO','MO04','Caicara','A'),('MO','MO05','Punta de Mata','A'),('MO','MO06','Temblador','A'),('MO','MO07','Maturín','A'),('MO','MO08','Aragua','A'),('MO','MO09','Quiriquire','A'),('MO','MO10','Santa Bárbara','A'),('MO','MO11','Barrancas del Orinco','A'),('MO','MO12','Uracoa','A'),('NU','NU01','La Plaza de Paraguachí','A'),('NU','NU02','La Asunción','A'),('NU','NU03','San Juan Bautista','A'),('NU','NU04','El Valle del Espíritu Santo','A'),('NU','NU05','Santa Ana','A'),('NU','NU06','Pampatar','A'),('NU','NU07','Juan Griego','A'),('NU','NU08','Porlamar','A'),('NU','NU09','Boca de Río','A'),('NU','NU10','Punta de Piedras','A'),('NU','NU11','San Pedro de Coche','A'),('PO','PO01','Agua Blanca','A'),('PO','PO02','Araure','A'),('PO','PO03','Píritu','A'),('PO','PO04','Guanare','A'),('PO','PO05','Guanarito','A'),('PO','PO06','Chabasquén de Unda','A'),('PO','PO07','Ospino','A'),('PO','PO08','Acarigua','A'),('PO','PO09','Papelón','A'),('PO','PO10','Boconoíto','A'),('PO','PO11','San Rafael de Onoto','A'),('PO','PO12','El Playón','A'),('PO','PO13','Biscucuy','A'),('PO','PO14','Villa Bruzual','A'),('SU','SU01','Casanay','A'),('SU','SU02','San José de Aerocuar','A'),('SU','SU03','Río Caribe','A'),('SU','SU04','El Pilar','A'),('SU','SU05','Carúpano','A'),('SU','SU06','Marigüitar','A'),('SU','SU07','Yaguaraparo','A'),('SU','SU08','Araya','A'),('SU','SU09','Tunapuy','A'),('SU','SU10','Irapa','A'),('SU','SU11','San Antonio del Golfo','A'),('SU','SU12','Cumanacoa','A'),('SU','SU13','Cariaco','A'),('SU','SU14','Cumaná','A'),('SU','SU15','Güiria','A'),('TA','TA01','Cordero','A'),('TA','TA02','Las Mesas','A'),('TA','TA03','El Colón','A'),('TA','TA04','San Antonio del Táchira','A'),('TA','TA05','Táriba','A'),('TA','TA06','Santa Ana de Táchira','A'),('TA','TA07','San Rafael del Piñal','A'),('TA','TA08','San José de Bolívar','A'),('TA','TA09','La Fría','A'),('TA','TA10','Palmira','A'),('TA','TA11','Capacho Nuevo','A'),('TA','TA12','La Grita','A'),('TA','TA13','El Cobre','A'),('TA','TA14','Rubio','A'),('TA','TA15','Umuquena','A'),('TA','TA16','Capacho Viejo','A'),('TA','TA17','Abejales','A'),('TA','TA18','Lobatera','A'),('TA','TA19','Michelena','A'),('TA','TA20','Coloncito','A'),('TA','TA21','Ureña','A'),('TA','TA22','Delicias','A'),('TA','TA23','La Tendida','A'),('TA','TA24','San Cristóbal','A'),('TA','TA25','Seboruco','A'),('TA','TA26','San Simon','A'),('TA','TA27','Queniquea','A'),('TA','TA28','San Josesito','A'),('TA','TA29','Pregonero','A'),('TR','TR01','Santa Isabel','A'),('TR','TR02','Boconó','A'),('TR','TR03','Sabana Grande','A'),('TR','TR04','Chejendé','A'),('TR','TR05','Carache','A'),('TR','TR06','Escuque','A'),('TR','TR07','El Paradero','A'),('TR','TR08','Campo Elías','A'),('TR','TR09','Santa Apolonia','A'),('TR','TR10','El Dividive','A'),('TR','TR11','Pampán','A'),('TR','TR12','Trujillo','A'),('TR','TR13','San Lazaro','A'),('TR','TR14','Pampanito','A'),('VA','VA01','La Guaira','A'),('YA','YA01','San Pablo','A'),('YA','YA02','Aroa','A'),('YA','YA03','Chivacoa','A'),('YA','YA04','Cocorote','A'),('YA','YA05','Independencia','A'),('ZU','ZU01','El Toro','A'),('ZU','ZU02','San Timoteo','A'),('ZU','ZU03','Cabimas','A'),('ZU','ZU04','Encontrados','A'),('ZU','ZU05','San Carlos del Zulia','A'),('ZU','ZU06','Pueblo Nuevo - El Chivo','A'),('ZU','ZU07','La Concepción','A'),('ZU','ZU08','Casigua El Cubo','A');
/*!40000 ALTER TABLE `ciudad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `curso`
--

DROP TABLE IF EXISTS `curso`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `curso` (
  `codCur` varchar(45) NOT NULL,
  `nombreCur` varchar(100) DEFAULT NULL,
  `descripcionCur` varchar(160) DEFAULT NULL,
  `estatusCur` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`codCur`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `curso`
--

LOCK TABLES `curso` WRITE;
/*!40000 ALTER TABLE `curso` DISABLE KEYS */;
INSERT INTO `curso` VALUES ('BD05','Diseño de base de datos','En este curso se proporciona instrucciones para planear una base de datos de escritorio.','A'),('DW01','Ciclo formativo de grado superior en Desarrollo de aplicaciones web','El ciclo formativo de grado superior de Desarrollo de Aplicaciones Web capacita a las personas en el desarrollo, implementación y mantenimiento de aplicaciones.','A'),('MM07','E-mail Marketing con Mailchimp','Aprende a crear y gestionar campañas de E-mail Marketing y elabora un Plan Estratégico, todo utilizando la aplicación Mailchimp.','A'),('PA04','Android: programacion de aplicaciones','Con este Curso de Programación de Aplicaciones Android aprenderás a diseñar aplicaciones Android manejando varios entornos, usando adecuadamente las APIs.','A'),('PA06','iOS: Dessarrollo de aplicaciones móviles','Aprende el desarrollo de apps usando el lenguaje de programación Swift 3 para dispositivos Apple. n el curso de programación iOS cuentas con un equipo de lídere','A'),('PC02','Introduccion a la programacion en C++','El lenguaje de programación C++ se sigue utilizando en muchas universidades y centros de enseñanza para adentrarse en el mundo de la programación.','A'),('PJ03','Programacion en lenguaje JAVA','La tecnología Java surge ante la necesidad de plantear una respuesta a la supremacía de Microsoft en el mercado del software.','A');
/*!40000 ALTER TABLE `curso` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `diasemana`
--

DROP TABLE IF EXISTS `diasemana`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `diasemana` (
  `codDiaS` varchar(45) NOT NULL,
  `nombreDiaS` varchar(45) DEFAULT NULL,
  `estatusDiaS` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`codDiaS`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `diasemana`
--

LOCK TABLES `diasemana` WRITE;
/*!40000 ALTER TABLE `diasemana` DISABLE KEYS */;
INSERT INTO `diasemana` VALUES ('01','Lunes','A'),('02','Martes','A'),('03','Miercoles','A'),('04','Jueves','A'),('05','Viernes','A'),('06','Sabado','A'),('07','Domingo','A');
/*!40000 ALTER TABLE `diasemana` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `estado`
--

DROP TABLE IF EXISTS `estado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `estado` (
  `codEsta` varchar(45) NOT NULL,
  `nombreEsta` varchar(45) DEFAULT NULL,
  `estatusEsta` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`codEsta`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estado`
--

LOCK TABLES `estado` WRITE;
/*!40000 ALTER TABLE `estado` DISABLE KEYS */;
INSERT INTO `estado` VALUES ('AM','Amazonas','A'),('AN','Anzoátegui','A'),('AP','Apure','A'),('AR','Aragua','A'),('BA','Barinas','A'),('BO','Bolívar','A'),('CA','Carabobo','A'),('CO','Cojedes','A'),('DE','Delta Amacuro','A'),('DI','Distrito Capital','A'),('FA','Falcón','A'),('GU','Guárico','A'),('LA','Lara','A'),('ME','Mérida','A'),('MI','Miranda','A'),('MO','Monagas','A'),('NU','Nueva Esparta','A'),('PO','Portuguesa','A'),('SU','Sucre','A'),('TA','Táchira','A'),('TR','Trujillo','A'),('VA','Vargas','A'),('YA','Yaracuy','A'),('ZU','Zulia','A');
/*!40000 ALTER TABLE `estado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `estudiante`
--

DROP TABLE IF EXISTS `estudiante`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `estudiante` (
  `codEst` varchar(45) NOT NULL,
  `cedulaEst` varchar(45) DEFAULT NULL,
  `nombreEst` varchar(45) DEFAULT NULL,
  `apellidoEst` varchar(45) DEFAULT NULL,
  `generoEst` varchar(45) DEFAULT NULL,
  `direccionEst` varchar(45) DEFAULT NULL,
  `fechaNacEst` date DEFAULT NULL,
  `tlfnEst` varchar(45) DEFAULT NULL,
  `correoEst` varchar(45) DEFAULT NULL,
  `estatusEst` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`codEst`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estudiante`
--

LOCK TABLES `estudiante` WRITE;
/*!40000 ALTER TABLE `estudiante` DISABLE KEYS */;
INSERT INTO `estudiante` VALUES ('AR008','V-26987983','Alfredo','Rivero','Masculino','Av. Santiago de León, calle 10','1998-04-16','04122028022','alfredorivero@gmail.com','A'),('CG018','V-27337933','Carlos','Gomez','Masculino','Av. Cristobal Colón, con Calle Amacuro','2000-07-04','04141459795','gomezcarlos@gmail.com','A'),('EC013','V-27337729','Enmanuel','Colmenarez','Masculino','Av. Venezuela, calle 5','2000-03-17','04121245789','EnmaColmenarez@gmail.com','A'),('FC001','V-27617950','Francis','Camacho','Masculino','Calle Cruz Verde, sector el Rosario','2000-04-08','04127552204','francis63@gmail.com','A'),('FL006','V-27772977','Fabian','Linarez','Masculino','Av. Fuerzas Armadas con Calle Bolívar','1999-04-12','04247732021','fabian99@gmail.com','A'),('FM011','V-27123340','Francisco','Miranda','Masculino','Av. Fernández Padilla, Calle Colón','2000-06-23','02512532090','francoM@hotmail.com','A'),('FP012','V-26954722','Felix','Perez','Masculino','Av. Miranda, calle Sucre','1997-12-03','02532222403','felixperez97@gmail.com','A'),('FV020','V-27340702','Fernando','Vasquez','Masculino','Av. Bolívar, Calle Sucre','2000-09-22','04261022533','fernandovasquez@gmail.com','A'),('HC007','V-27749788','Hector','Campos','Masculino','Calle 36, entre la carretera 24 y 25','1999-02-26','04145747203','hectorcampos@gmail.com','A'),('JA010','V-25340980','Jesus','Aguilar','Masculino','Av. Miranda, calle Urdaneta','1996-08-14','04167800873','jesusaguilar@gmail.com','A'),('JH019','V-26480772','Javier','Hernandez','Masculino','Av. Tosta García, Sector el Brinco','1998-12-02','04167030392','javier0211298@gmail.com','A'),('JM015','V-26120080','Jose','Martinez','Masculino','Calle Miranda con Calle La Paz','1998-04-15','04165407000','martinezjose@gmail.com','A'),('LP016','V-25470980','Luis','Perozo','Masculino','Sector La Inmaculada calle 13','1996-04-12','04242409792','perozo12@gmail.com','A'),('LT022','V-27401706','Luciano','Tovar','Masculino','Av. 8 con Calle 23 y 24','1999-08-25','04128577233','tovarluciano@gmail.com','A'),('MC017','V-25401214','Maria','Castillo','Femenino','Av. 6 con 11-22, sector 18 de Octubre','1995-01-12','04125708019','maria95@gmail.com','A'),('ME014','V-26120073','Mary','Escalona','Femenino','Carrera 15 sector Los Bloques','2000-05-21','04143547231','maryEscalona@gmail.com','A'),('ML005','V-25263225','Mauricio','Leal','Masculino','Av. Rivas entre Calles 5 y 7','1997-10-14','04265707221','mauleal25@gmail.com','A'),('MP004','V-26402263','Mario','Peña','Masculino','Calle 31 entre Av. 41 y 42 sector El Palito','1999-12-12','04160567743','peñamario@gmail.com','A'),('MP021','V-26554614','Marixa','Pacheco','Femenino','Av. Bolívar, calle Zamora','1998-05-05','04128147023','pacheco0505@hotmail.com','A'),('MR002','V-27403587','Milexa','Rrodriguez','Femenino','Calle 6 entre Av. 2 y 3 ','2000-02-02','04124593721','milerodri2000@gmail.com','A'),('MS009','V-27400480','Marcos','Suarez','Masculino','Av. Venezuela, calle 5','2000-03-23','04267035120','marcossuarez@gmail.com','A'),('OC003','V-27845632','Orlando','Carrillo','Masculino','Av. Callizales sector Morita','2000-01-01','04141414573','carrilloOrlan73@gmail.com','A');
/*!40000 ALTER TABLE `estudiante` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `grupo`
--

DROP TABLE IF EXISTS `grupo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `grupo` (
  `codGru` varchar(45) NOT NULL,
  `fechaIni` date DEFAULT NULL,
  `fechaCul` date DEFAULT NULL,
  `codCur` varchar(45) DEFAULT NULL,
  `codTurGru` varchar(45) DEFAULT NULL,
  `estatusGru` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`codGru`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `grupo`
--

LOCK TABLES `grupo` WRITE;
/*!40000 ALTER TABLE `grupo` DISABLE KEYS */;
INSERT INTO `grupo` VALUES ('G001','2019-01-07','2019-02-15','DW01','TUR01','A'),('G002','2019-01-07','2019-02-15','DW01','TUR03','A'),('G003','2018-12-13','2019-01-25','PA04','TUR02','A'),('G004','2018-12-13','2019-01-25','PA04','TUR04','A'),('G005','2019-01-07','2019-02-15','BD05','TUR03','A'),('G006','2019-01-07','2019-02-15','BD05','TUR05','A'),('G007','2018-12-12','2019-01-25','PJ03','TUR04','A'),('G008','2018-11-18','2018-12-18','PJ03','TUR06','A'),('G009','2019-01-07','2019-02-15','PJ03','TUR05','A'),('G010','2018-11-18','2018-12-18','PC02','TUR07','A'),('G012','2019-01-07','2019-02-15','PC02','TUR08','A');
/*!40000 ALTER TABLE `grupo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `grupo_estudiante`
--

DROP TABLE IF EXISTS `grupo_estudiante`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `grupo_estudiante` (
  `codGru` varchar(45) NOT NULL,
  `codEst` varchar(45) NOT NULL,
  `lapsoAcadGE` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `grupo_estudiante`
--

LOCK TABLES `grupo_estudiante` WRITE;
/*!40000 ALTER TABLE `grupo_estudiante` DISABLE KEYS */;
INSERT INTO `grupo_estudiante` VALUES ('G001','JM015','2019-I'),('G002','LP016','2019-I'),('G002','MC017','2019-I'),('G003','CG018','2019-II'),('G004','FV020','2019-II'),('G004','JH019','2019-II'),('G005','LT022','2019-I'),('G005','MP021','2019-I'),('G006','FC001','2019-I'),('G006','MR002','2019-I'),('G007','FL006','2019-II'),('G007','HC007','2019-II'),('G007','ML005','2019-II'),('G007','MP004','2019-II'),('G007','OC003','2019-II'),('G008','AR008','2019-II'),('G010','MS009','2019-I'),('G012','EC013','2019-I'),('G012','FM011','2019-I'),('G012','FP012','2019-I'),('G012','JA010','2019-I'),('G012','ME014','2019-I');
/*!40000 ALTER TABLE `grupo_estudiante` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `grupo_instructor`
--

DROP TABLE IF EXISTS `grupo_instructor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `grupo_instructor` (
  `codGru` varchar(45) NOT NULL,
  `codIns` varchar(45) NOT NULL,
  `lapsoAcadGI` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `grupo_instructor`
--

LOCK TABLES `grupo_instructor` WRITE;
/*!40000 ALTER TABLE `grupo_instructor` DISABLE KEYS */;
INSERT INTO `grupo_instructor` VALUES ('G001','MP01','2019-I'),('G002','SP06','2019-I'),('G003','MG05','2019-II'),('G004','FL09','2019-II'),('G005','JN03','2019-I'),('G006','JN03','2019-I'),('G007','YS02','2019-II'),('G008','JR08','2019-II'),('G009','IP10','2019-II'),('G010','GC07','2019-I'),('G012','LM04','2019-I');
/*!40000 ALTER TABLE `grupo_instructor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `instructor`
--

DROP TABLE IF EXISTS `instructor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `instructor` (
  `codIns` varchar(45) NOT NULL,
  `cedulaIns` varchar(45) DEFAULT NULL,
  `nombreIns` varchar(45) DEFAULT NULL,
  `apellidoIns` varchar(45) DEFAULT NULL,
  `generoIns` varchar(45) DEFAULT NULL,
  `fechaNacIns` date DEFAULT NULL,
  `direccionIns` varchar(50) DEFAULT NULL,
  `fechaIngreso` date DEFAULT NULL,
  `correoIns` varchar(45) DEFAULT NULL,
  `tlfnIns` varchar(45) DEFAULT NULL,
  `codProIns` varchar(45) DEFAULT NULL,
  `estatusIns` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`codIns`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `instructor`
--

LOCK TABLES `instructor` WRITE;
/*!40000 ALTER TABLE `instructor` DISABLE KEYS */;
INSERT INTO `instructor` VALUES ('FL09','V-20820139','Franco','Lopez','Masculino','1990-03-14','Av. Michelena, calle 12.','2016-06-30','lopezf20820@gmail.com','0416-3574022','DA004','A'),('GC07','V-17495929','Gustavo','Camacho','Masculino','1985-04-23','Urb. Atapaima II, Calle 6','2015-03-05','guscamacho85@hotmail.com','0412-7435893','II002','A'),('IP10','V-25042922','Isabel','Perez','Femenino','1994-05-21','Urb. La Puerta, calle 3.','2018-09-03','isaPerez@hotmail.com','0426-8135215','DA004','A'),('JN03','V-20749788','Javier','Navarro','Masculino','1991-01-06','Cabudare Centro.','2016-05-14','javierNavarro79@gmail.com','0414-3578761','IS001','A'),('JR08','V-16120970','Jose','Rivero','Masculino','1984-08-20','Urb. FUNDESFEL.','2018-07-28','rivero2008@hotmail.com','0414-555381','II002','A'),('LM04','V-15707866','Luis','Medina','Masculino','1981-10-01','Av. Rotaria con calle 16.','2014-04-12','medinaL04@gmail.com','0412-5236734','DW003','A'),('MG05','V-19119619','Marcos','Garcia','Masculino','1988-11-16','Calle 18, Sector Italven','2017-11-16','marcos81@gmail.com','0416-8577233','DA004','A'),('MP01','V-25401214','Maria','Perdomo','Femenino','1996-01-08','Calle 60 con Carrera 13.','2017-04-10','mariaperdomo@gmail.com','0412-8134245','II002','A'),('SP06','V-20120075','Sofia','Pacheco','Femenino','1990-11-27','Av. Venezuela con Calle 24','2017-01-10','sofipacheco@hotmail.com','0426-1124683','DW003','A'),('YS02','V-24340980','Yoselin','Santos','Femenino','1993-04-12','Carucieña, calle 2.','2015-02-20','lopezf20820@gmail.com','0414-0568553','DA004','A');
/*!40000 ALTER TABLE `instructor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `profesion`
--

DROP TABLE IF EXISTS `profesion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `profesion` (
  `codPro` varchar(45) NOT NULL,
  `descripcionPro` varchar(70) DEFAULT NULL,
  `estatusPro` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`codPro`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `profesion`
--

LOCK TABLES `profesion` WRITE;
/*!40000 ALTER TABLE `profesion` DISABLE KEYS */;
INSERT INTO `profesion` VALUES ('0000','- - Seleccione - -','A'),('DA004','Ingenieria de desarrollo de aplicaciones moviles','A'),('DW003','Licenciatura en Diseño Web','A'),('II002','Ingenieria en Informatica','A'),('IS001','Ingenieria de Sistemas','A');
/*!40000 ALTER TABLE `profesion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipousuario`
--

DROP TABLE IF EXISTS `tipousuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipousuario` (
  `codTipoU` varchar(45) NOT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `estatusTU` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`codTipoU`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipousuario`
--

LOCK TABLES `tipousuario` WRITE;
/*!40000 ALTER TABLE `tipousuario` DISABLE KEYS */;
INSERT INTO `tipousuario` VALUES ('TU1','Actualización de datos','A'),('TU2','Reportes','A'),('TU3','Administrador del Sistema','A');
/*!40000 ALTER TABLE `tipousuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `turno`
--

DROP TABLE IF EXISTS `turno`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `turno` (
  `codTur` varchar(45) NOT NULL,
  `codDiaS` varchar(45) DEFAULT NULL,
  `codBlo` varchar(45) DEFAULT NULL,
  `estatusTur` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`codTur`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `turno`
--

LOCK TABLES `turno` WRITE;
/*!40000 ALTER TABLE `turno` DISABLE KEYS */;
INSERT INTO `turno` VALUES ('TUR01','01','BL01','A'),('TUR02','01','BL02','A'),('TUR03','02','BL01','A'),('TUR04','02','BL02','A'),('TUR05','03','BL01','A'),('TUR06','03','BL02','A'),('TUR07','04','BL01','A'),('TUR08','04','BL02','A'),('TUR09','05','BL01','A'),('TUR10','05','BL02','A'),('TUR11','06','BL01','A'),('TUR12','06','BL02','A');
/*!40000 ALTER TABLE `turno` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario` (
  `id` varchar(45) NOT NULL,
  `clave` varchar(45) DEFAULT NULL,
  `codTipoU` varchar(45) DEFAULT NULL,
  `estatusU` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES ('avernis','1234','TU1','A'),('gustavoerivero','121297','TU3','A'),('jesus','26561030','TU3','A'),('pipox','1234','TU2','A'),('yjbc','123','TU3','A');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-02-11  7:11:45
