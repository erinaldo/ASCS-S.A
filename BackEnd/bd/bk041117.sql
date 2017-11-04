/*
SQLyog Community v12.4.3 (32 bit)
MySQL - 5.7.17-log : Database - stockcapiata
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`stockcapiata` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `stockcapiata`;

/*Table structure for table `seguridad` */

DROP TABLE IF EXISTS `seguridad`;

CREATE TABLE `seguridad` (
  `cod_usuario` char(10) NOT NULL,
  `nombre` char(30) NOT NULL,
  `nivel` decimal(2,0) NOT NULL,
  `cod_operador` char(15) NOT NULL,
  `usuario` char(10) NOT NULL,
  `fecha` datetime NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

/*Data for the table `seguridad` */

insert  into `seguridad`(`cod_usuario`,`nombre`,`nivel`,`cod_operador`,`usuario`,`fecha`) values 
('CARDUS','Marcelo Cardus',1,'CARDUS','CARDUS','2012-09-28 06:43:51'),
('WALTER','WALTER',3,'WALTER','WALTER','0000-00-00 00:00:00'),
('MAGALI','MAGALI',1,'MAGALI','MAGALI','0000-00-00 00:00:00'),
('CORTE','MESA DE CORTE',1,'CORTE','CORTE','0000-00-00 00:00:00'),
('MARCADO','SECCION MARCADO',1,'MARCADO','MARCADO','0000-00-00 00:00:00'),
('TEMPLADO','SECCION TEMPLADO',1,'TEMPLADO','TEMPLADO','0000-00-00 00:00:00'),
('SANDRA','SANDRA PEREIRA',2,'SANDRA PEREIRA','SANDRA','2014-12-31 00:00:00'),
('MAYRAB','MAYRA BAEZ',3,'MAYRAB','MAYRAB','2006-10-14 00:00:00'),
('BLANCA','BLANCA',3,'BLANCA','BLANCA','0000-00-00 00:00:00'),
('ANIBAL','ANIBAL BRITEZ',1,'ANIBAL','ANIBAL','2013-07-04 00:00:00'),
('CACOSTA','CACOSTA',3,'CACOSTA','CACOSTA','2012-12-29 02:15:10'),
('CAJA','CAJA URGENCIA',2,'CAJA URGENCIA','CAJA','2014-06-07 00:00:00'),
('ALDER','ALDER CAREAGA',3,'ALDER CAREAGA','ALDER','0000-00-00 00:00:00'),
('JUNIOR','JUNIOR MEDINA',3,'JUNIOR','JUNIOR','2014-03-15 10:49:00'),
('CONTROL','VALIDACION FALTANTE',5,'CONTROL','CONTROL','0000-00-00 00:00:00'),
('GLORIA','GLORIA AQUINO',3,'GLORIA','GLORIA','2014-06-20 00:00:00'),
('MARTINF','MARTIN FERNANDEZ',3,'MARTINF','MARTINF','2014-03-15 10:49:00'),
('FBRITEZ','FRANCISCO BRITEZ',3,'FBRITEZ','FBRITEZ','0000-00-00 00:00:00'),
('MIGUEL','MIGUEL',3,'MIGUEL','MIGUEL','2014-03-15 10:49:00'),
('VICTORQ','VICTOR QUINTANA',3,'VICTORQ','VICTORQ','2014-03-15 10:49:00'),
('MARCELO','MARCELO ROMAN',1,'MARCELO','MARCELO','0000-00-00 00:00:00'),
('FRAN','FRANCISCO DOMINGUEZ',3,'FRAN','FRAN','2015-03-28 10:48:00'),
('JORGE','DR JORGE ROMAN',1,'DR JORGE ROMAN','DR JORGE R','0000-00-00 00:00:00'),
('SISTEMA','SISTEMA',1,'SISTEMA','SISTEMA','0000-00-00 00:00:00'),
('Cardus','Cardus',1,'Cardus','Cardus','0000-00-00 00:00:00');

/*Table structure for table `stcajas` */

DROP TABLE IF EXISTS `stcajas`;

CREATE TABLE `stcajas` (
  `cajaCod` int(11) NOT NULL AUTO_INCREMENT,
  `cod_usuario` char(10) NOT NULL,
  `cajaFechApert` date DEFAULT NULL,
  `cajaFechCierre` date DEFAULT NULL,
  `cajaMontofijo` double DEFAULT NULL,
  `cajaEstado` char(1) DEFAULT NULL,
  PRIMARY KEY (`cajaCod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `stcajas` */

/*Table structure for table `stclientes` */

DROP TABLE IF EXISTS `stclientes`;

CREATE TABLE `stclientes` (
  `clieCod` int(11) NOT NULL AUTO_INCREMENT,
  `clieNombre` varchar(50) NOT NULL,
  `clieRuc` varchar(25) NOT NULL,
  `clieTelef` varchar(25) DEFAULT NULL,
  `clieContacto` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`clieCod`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;

/*Data for the table `stclientes` */

insert  into `stclientes`(`clieCod`,`clieNombre`,`clieRuc`,`clieTelef`,`clieContacto`) values 
(1,'INSTALACIONES','','',''),
(6,'MAYORISTA','','',''),
(8,'FAB CAPIATA','','',''),
(9,'km 9','','',''),
(10,'STOCK B','3','4','VENTAS'),
(11,'SUC. LAMBARE','','',''),
(12,'FAB. LAMBARE','','',''),
(13,'ENERO','','',''),
(14,'FEBRERO','','',''),
(15,'VIDRIOS SERVICE','1441317-5','','CANDIDO GONZALEZ');

/*Table structure for table `stcompras` */

DROP TABLE IF EXISTS `stcompras`;

CREATE TABLE `stcompras` (
  `comprasCod` int(11) NOT NULL,
  `comprasFechaFact` date DEFAULT NULL,
  `comprasEstado` char(4) DEFAULT NULL,
  `comprasNroFactura` varchar(20) DEFAULT NULL,
  `comprasObs` varchar(50) DEFAULT NULL,
  `comprasFechaAnulacion` date DEFAULT NULL,
  `comprasFechaPagado` date DEFAULT NULL,
  `comprasSaldo` double DEFAULT NULL,
  `comprasTipoFact` char(8) DEFAULT NULL,
  `provCodigo` int(11) DEFAULT NULL,
  `comprasUsrIns` char(10) DEFAULT NULL,
  `comprasFechaIns` date DEFAULT NULL,
  `comprasUsrUpd` char(10) DEFAULT NULL,
  `comprasFechaUpd` date DEFAULT NULL,
  PRIMARY KEY (`comprasCod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `stcompras` */

insert  into `stcompras`(`comprasCod`,`comprasFechaFact`,`comprasEstado`,`comprasNroFactura`,`comprasObs`,`comprasFechaAnulacion`,`comprasFechaPagado`,`comprasSaldo`,`comprasTipoFact`,`provCodigo`,`comprasUsrIns`,`comprasFechaIns`,`comprasUsrUpd`,`comprasFechaUpd`) values 
(23,'2017-11-01','Anul','23','Nada que mencionar.','2017-11-03',NULL,0,'Contado',31,'samuel','2017-11-01','samuel','2017-11-03'),
(24,'2017-11-02',NULL,'24','hola',NULL,NULL,0,'Contado',31,'samuel','2017-11-02',NULL,NULL),
(611,'2017-11-03','Acti','0611','Compra a crédtio',NULL,NULL,450000,'Crédito',42,'samuel','2017-11-03',NULL,NULL);

/*Table structure for table `stcomprasdet` */

DROP TABLE IF EXISTS `stcomprasdet`;

CREATE TABLE `stcomprasdet` (
  `comprasCod` int(11) NOT NULL,
  `codigo_base` varchar(25) NOT NULL,
  `comprasCosto` double DEFAULT NULL,
  `comprasImpExcente` double DEFAULT NULL,
  `comprasImp5` double DEFAULT NULL,
  `comprasImp10` double DEFAULT NULL,
  `comprasCanitad` int(11) DEFAULT NULL,
  KEY `codigobase` (`comprasCod`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `stcomprasdet` */

insert  into `stcomprasdet`(`comprasCod`,`codigo_base`,`comprasCosto`,`comprasImpExcente`,`comprasImp5`,`comprasImp10`,`comprasCanitad`) values 
(23,'100',550000,0,0,50000,1),
(23,'100',1100000,0,0,100000,2),
(23,'100',1650000,0,0,150000,3),
(24,'100',1100000,0,0,100000,2),
(611,'100',550000,0,0,50000,1);

/*Table structure for table `stdeposito` */

DROP TABLE IF EXISTS `stdeposito`;

CREATE TABLE `stdeposito` (
  `depoCod` int(11) NOT NULL AUTO_INCREMENT,
  `depoDescripcion` varchar(25) NOT NULL,
  PRIMARY KEY (`depoCod`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

/*Data for the table `stdeposito` */

insert  into `stdeposito`(`depoCod`,`depoDescripcion`) values 
(1,'Stock Grande'),
(2,'Stock B');

/*Table structure for table `stexistencia` */

DROP TABLE IF EXISTS `stexistencia`;

CREATE TABLE `stexistencia` (
  `codigo_base` varchar(25) NOT NULL,
  `depoCod` int(11) DEFAULT NULL,
  `exisCantidad` int(11) DEFAULT NULL,
  `exisUsrIns` char(10) DEFAULT NULL,
  `exisFchIns` datetime DEFAULT NULL,
  `exisNroOt` decimal(10,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `stexistencia` */

insert  into `stexistencia`(`codigo_base`,`depoCod`,`exisCantidad`,`exisUsrIns`,`exisFchIns`,`exisNroOt`) values 
('EMF7043',1,40,'YERUTI','2017-08-29 15:56:26',NULL),
('EMF7029',1,36,'YERUTI','2017-08-29 15:56:26',NULL),
('EMF7042',1,180,'YERUTI','2017-08-29 15:56:26',NULL),
('EMF7039',1,32,'YERUTI','2017-08-29 15:56:26',NULL),
('EMF3016',1,49,'YERUTI','2017-08-29 15:56:26',NULL),
('EMF0254',1,12,'YERUTI','2017-08-29 15:56:26',NULL),
('MF0185',1,79,'YERUTI','2017-08-29 15:56:26',NULL),
('EMF7027',1,64,'YERUTI','2017-08-29 16:38:58',NULL),
('EMF7040',1,24,'YERUTI','2017-08-29 16:38:59',NULL),
('EMF7041',1,82,'YERUTI','2017-08-29 16:38:59',NULL),
('EMF7025',1,30,'YERUTI','2017-08-29 16:38:59',NULL),
('EMF3129',1,330,'YERUTI','2017-08-29 16:38:59',NULL),
('EMF2252',1,222,'YERUTI','2017-08-29 16:38:59',NULL),
('EMF2074',1,425,'YERUTI','2017-08-29 16:38:59',NULL),
('EMF2123',1,84,'YERUTI','2017-08-29 16:38:59',NULL),
('EMF7038F',1,40,'YERUTI','2017-08-29 16:38:59',NULL),
('EMF7043F',1,88,'YERUTI','2017-08-29 16:38:59',NULL),
('EMF7029F',1,84,'YERUTI','2017-08-29 16:45:26',NULL),
('EMF7042F',1,324,'YERUTI','2017-08-29 16:45:26',NULL),
('EMF7024F',1,192,'YERUTI','2017-08-29 16:45:26',NULL),
('EMF7023F',1,250,'YERUTI','2017-08-29 16:45:26',NULL),
('MF0254F',1,3,'YERUTI','2017-08-29 16:45:26',NULL),
('EMF3016F',1,12,'YERUTI','2017-08-29 16:45:26',NULL),
('EMF3127F',1,13,'YERUTI','2017-08-29 16:45:26',NULL),
('MF00150F',1,41,'YERUTI','2017-08-29 16:45:26',NULL),
('MF00232F',1,42,'YERUTI','2017-08-29 16:45:26',NULL),
('EMF7041F',1,35,'YERUTI','2017-08-29 16:45:26',NULL),
('EMF7026F',1,120,'YERUTI','2017-08-29 16:51:06',NULL),
('EMF7027F',1,672,'YERUTI','2017-08-29 16:51:06',NULL),
('EMF7040F',1,192,'YERUTI','2017-08-29 16:51:06',NULL),
('EMF7025F',1,1260,'YERUTI','2017-08-29 16:51:06',NULL),
('EMF3129F',1,2130,'YERUTI','2017-08-29 16:51:06',NULL),
('EMF0185F',1,6,'YERUTI','2017-08-29 16:51:06',NULL),
('BX-084',1,61,'YERUTI','2017-08-29 16:51:06',NULL),
('BX-239P ',1,26,'YERUTI','2017-08-29 16:51:06',NULL),
('BX-239F',1,12,'YERUTI','2017-08-29 16:51:07',NULL),
('BG-001',1,513,'YERUTI','2017-08-29 16:51:07',NULL),
('BX-500',1,57,'YERUTI','2017-08-29 16:51:07',NULL),
('SI-501',1,1,'YERUTI','2017-08-29 16:51:07',NULL),
('EMF0203F',1,6,'YERUTI','2017-08-29 17:10:09',NULL),
('BX-1005',1,109,'YERUTI','2017-08-29 17:10:09',NULL),
('BX-1005F',1,40,'YERUTI','2017-08-29 17:10:09',NULL),
('BX-1005VF',1,106,'YERUTI','2017-08-29 17:10:09',NULL),
('BX-1012VF',1,95,'YERUTI','2017-08-29 17:10:09',NULL),
('BX-1011F',1,40,'YERUTI','2017-08-29 17:10:09',NULL),
('BX-1012',1,18,'YERUTI','2017-08-29 17:10:09',NULL),
('BX-1012F',1,20,'YERUTI','2017-08-29 17:10:09',NULL),
('PU-344F',1,324,'YERUTI','2017-08-29 17:10:09',NULL),
('PU-350F',1,210,'YERUTI','2017-08-29 17:10:10',NULL),
('TG-110',1,9,'YERUTI','2017-08-29 17:10:10',NULL),
('TG-110F',1,9,'YERUTI','2017-08-29 17:10:10',NULL),
('TG-112',1,16,'YERUTI','2017-08-29 17:10:10',NULL),
('TG112F',1,116,'YERUTI','2017-08-29 17:13:30',NULL),
('TQ089',1,132,'YERUTI','2017-08-29 17:13:30',NULL),
('CT-085F',1,35,'YERUTI','2017-08-29 17:13:30',NULL),
('BX-246',1,270,'YERUTI','2017-08-29 17:13:30',NULL),
('FC-419',1,97,'YERUTI','2017-08-29 17:13:30',NULL),
('FC-419F',1,29,'YERUTI','2017-08-29 17:13:31',NULL),
('FC-544',1,98,'YERUTI','2017-08-29 17:13:31',NULL),
('FC-544F',1,21,'YERUTI','2017-08-29 17:13:31',NULL),
('FC-007',1,112,'YERUTI','2017-08-29 17:13:31',NULL),
('FC-007F',1,50,'YERUTI','2017-08-29 17:13:31',NULL),
('BX-258',1,60,'YERUTI','2017-08-29 17:13:31',NULL),
('BX-258F',1,84,'YERUTI','2017-08-29 17:13:31',NULL),
('BX-257',1,72,'YERUTI','2017-08-29 17:13:31',NULL),
('BX-257F',1,46,'YERUTI','2017-08-29 17:13:31',NULL),
('BX-206',1,45,'YERUTI','2017-08-29 17:13:31',NULL),
('BX-206F',1,67,'YERUTI','2017-08-29 17:13:31',NULL),
('IN-006F',1,6,'YERUTI','2017-08-30 09:41:38',NULL),
('IN-008F',1,1,'YERUTI','2017-08-30 09:41:38',NULL),
('IN-018F',1,61,'YERUTI','2017-08-30 09:41:38',NULL),
('IN-017F',1,43,'YERUTI','2017-08-30 09:41:38',NULL),
('CG-182F',1,133,'YERUTI','2017-08-30 09:41:38',NULL),
('IN-047F',1,27,'YERUTI','2017-08-30 09:41:38',NULL),
('IN-012F',1,34,'YERUTI','2017-08-30 09:41:38',NULL),
('IN-013F',1,28,'YERUTI','2017-08-30 09:41:38',NULL),
('IN-011F',1,43,'YERUTI','2017-08-30 09:41:38',NULL),
('IN-004F',1,40,'YERUTI','2017-08-30 09:41:38',NULL),
('IN-003F',1,64,'YERUTI','2017-08-30 09:57:06',NULL),
('IN-009F',1,16,'YERUTI','2017-08-30 09:57:06',NULL),
('IN-010F',1,11,'YERUTI','2017-08-30 09:57:06',NULL),
('IN-015F',1,18,'YERUTI','2017-08-30 09:57:07',NULL),
('CG-179F',1,81,'YERUTI','2017-08-30 09:57:07',NULL),
('CG-171F',1,200,'YERUTI','2017-08-30 09:57:07',NULL),
('IN-056F',1,206,'YERUTI','2017-08-30 09:57:07',NULL),
('IN-058F',1,58,'YERUTI','2017-08-30 09:57:07',NULL),
('IN-061',1,159,'YERUTI','2017-08-30 09:57:07',NULL),
('IN-017',1,386,'YERUTI','2017-08-30 09:57:07',NULL),
('IN-008',1,13,'YERUTI','2017-08-30 09:57:07',NULL),
('IN-047',1,47,'YERUTI','2017-08-30 09:57:07',NULL),
('IN-061',1,332,'YERUTI','2017-08-30 09:57:07',NULL),
('1125B',1,5004,'MAGALI','2017-09-13 11:06:59',3108),
('1125A',1,449,'MAGALI','2017-09-13 11:06:59',3108),
('1125I',1,100,'MAGALI','2017-09-13 11:06:59',3108),
('SIL784',1,140,'MAGALI','2017-09-13 11:06:59',3108),
('SL999A',1,180,'MAGALI','2017-09-13 11:06:59',3108),
('SLCPS',1,10,'MAGALI','2017-09-13 11:06:59',3108),
('SL768I',1,20,'MAGALI','2017-09-13 11:06:59',3108),
('1335D',1,166,'MAGALI','2017-09-13 11:06:59',3108),
('1629JD',1,171,'MAGALI','2017-09-13 11:06:59',3108),
('1038DD',1,276,'MAGALI','2017-09-13 11:06:59',3108),
('1607M',2,10,'MAGALI','2017-09-13 14:55:13',150959),
('1607M',1,-10,'MAGALI','2017-09-13 14:55:13',150959),
('1103D',2,7,'MAGALI','2017-09-13 14:55:13',150959),
('1103D',1,-7,'MAGALI','2017-09-13 14:55:13',150959),
('SL999A',2,20,'MAGALI','2017-09-13 14:55:14',150959),
('SL999A',1,-20,'MAGALI','2017-09-13 14:55:14',150959),
('HDL-84TC',2,24,'MAGALI','2017-09-13 14:55:14',150959),
('HDL-84TC',1,-24,'MAGALI','2017-09-13 14:55:14',150959),
('3530D',2,4,'MAGALI','2017-09-13 14:55:14',150959),
('3530D',1,-4,'MAGALI','2017-09-13 14:55:14',150959),
('3530C',1,-12,'MAGALI','2017-09-13 14:58:22',155776),
('3534C',1,-12,'MAGALI','2017-09-13 14:58:22',155776),
('SL999A',1,-40,'MAGALI','2017-09-13 14:59:04',155783),
('FELPA5X7',1,-4,'MAGALI','2017-09-13 14:59:32',155783),
('FELPA5X7',1,-14,'MAGALI','2017-09-13 15:03:46',155787),
('SL999A',1,-80,'MAGALI','2017-09-13 15:03:46',155787),
('SL999A',1,-80,'MAGALI','2017-09-13 15:11:01',157163),
('SIL784',1,-60,'MAGALI','2017-09-13 15:11:01',157163),
('1125B',1,-400,'MAGALI','2017-09-13 15:11:01',157163),
('1335D',1,-40,'MAGALI','2017-09-13 15:11:01',157163),
('1629JD',1,-40,'MAGALI','2017-09-13 15:11:01',157163),
('1038DD',1,-40,'MAGALI','2017-09-13 15:11:01',157163),
('FELPA5X7',1,-15,'MAGALI','2017-09-13 15:11:01',157163),
('FELPA5X5',1,-10,'MAGALI','2017-09-13 15:11:01',157163),
('3530D',1,-25,'MAGALI','2017-09-13 15:11:01',157163),
('3534D',1,-20,'MAGALI','2017-09-13 15:11:02',157163),
('1629BD',1,-20,'MAGALI','2017-09-13 15:11:02',157163),
('HVA25B',1,-20,'MAGALI','2017-09-13 15:11:02',157163),
('1921D',1,-40,'MAGALI','2017-09-13 15:11:02',157163),
('1571B',1,-15,'MAGALI','2017-09-13 15:11:02',157163),
('1607M',1,-20,'MAGALI','2017-09-13 15:11:02',157163),
('H30C',1,-6,'MAGALI','2017-09-13 15:11:02',157163),
('1125B',1,-100,'MAGALI','2017-09-13 15:12:35',155791),
('3530C',1,-12,'MAGALI','2017-09-13 15:12:35',155791),
('FELPA5X7',1,-5,'MAGALI','2017-09-13 15:12:35',155791),
('1125B',1,-500,'MAGALI','2017-09-13 15:22:18',154226),
('1607M',1,-25,'MAGALI','2017-09-13 15:22:18',154226),
('FELPA5X7',1,-15,'MAGALI','2017-09-13 15:22:18',154226),
('1571B',1,-80,'MAGALI','2017-09-13 15:22:18',154226),
('1504AD',1,-15,'MAGALI','2017-09-13 15:22:18',154226),
('1504AC',1,-10,'MAGALI','2017-09-13 15:22:18',154226),
('1125B',1,-200,'MAGALI','2017-09-13 15:22:59',155794),
('100',1,-1,'samuel','2017-11-01 00:00:00',23),
('100',1,-2,'samuel','2017-11-01 00:00:00',23),
('100',1,-3,'samuel','2017-11-01 00:00:00',23),
('100',1,2,'samuel','2017-11-02 00:00:00',24),
('100',1,1,'samuel','2017-11-03 00:00:00',611);

/*Table structure for table `stimpuesto` */

DROP TABLE IF EXISTS `stimpuesto`;

CREATE TABLE `stimpuesto` (
  `impCod` int(11) NOT NULL AUTO_INCREMENT,
  `impPorcentaje` int(11) DEFAULT NULL,
  `impDesc` varchar(3) DEFAULT NULL,
  PRIMARY KEY (`impCod`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

/*Data for the table `stimpuesto` */

insert  into `stimpuesto`(`impCod`,`impPorcentaje`,`impDesc`) values 
(1,10,'10%'),
(4,5,'5%'),
(5,0,'Exc');

/*Table structure for table `stmovinterno` */

DROP TABLE IF EXISTS `stmovinterno`;

CREATE TABLE `stmovinterno` (
  `movCodigo` int(11) NOT NULL AUTO_INCREMENT,
  `movNro` int(11) NOT NULL,
  `movEstado` char(4) DEFAULT NULL,
  `movFecha` date DEFAULT NULL,
  `movSolicitado` char(25) DEFAULT NULL,
  `movAutorizado` char(25) DEFAULT NULL,
  `provCodigo` int(11) DEFAULT NULL,
  `movLineaNro` int(11) DEFAULT NULL,
  `prodCodigo` varchar(20) DEFAULT NULL,
  `movCantidad` int(11) DEFAULT NULL,
  `movTipo` char(8) DEFAULT NULL,
  `movUsrIns` char(15) DEFAULT NULL,
  `movFchIns` datetime DEFAULT NULL,
  `movUsrUpd` char(15) DEFAULT NULL,
  `movFchUpd` datetime DEFAULT NULL,
  PRIMARY KEY (`movCodigo`,`movNro`),
  UNIQUE KEY `movCodigo` (`movCodigo`)
) ENGINE=InnoDB AUTO_INCREMENT=1890 DEFAULT CHARSET=utf8;

/*Data for the table `stmovinterno` */

insert  into `stmovinterno`(`movCodigo`,`movNro`,`movEstado`,`movFecha`,`movSolicitado`,`movAutorizado`,`provCodigo`,`movLineaNro`,`prodCodigo`,`movCantidad`,`movTipo`,`movUsrIns`,`movFchIns`,`movUsrUpd`,`movFchUpd`) values 
(1613,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,1,'EMF7043',40,'Entrada','YERUTI','2017-08-29 15:56:26',NULL,NULL),
(1614,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,2,'EMF7029',36,'Entrada','YERUTI','2017-08-29 15:56:26',NULL,NULL),
(1615,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,3,'EMF7042',180,'Entrada','YERUTI','2017-08-29 15:56:26',NULL,NULL),
(1616,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,4,'EMF7039',32,'Entrada','YERUTI','2017-08-29 15:56:26',NULL,NULL),
(1617,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,5,'EMF3016',49,'Entrada','YERUTI','2017-08-29 15:56:26',NULL,NULL),
(1618,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,6,'EMF0254',12,'Entrada','YERUTI','2017-08-29 15:56:26',NULL,NULL),
(1619,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,7,'MF0185',79,'Entrada','YERUTI','2017-08-29 15:56:26',NULL,NULL),
(1620,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,1,'EMF7027',64,'Entrada','YERUTI','2017-08-29 16:38:58',NULL,NULL),
(1621,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,2,'EMF7040',24,'Entrada','YERUTI','2017-08-29 16:38:58',NULL,NULL),
(1622,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,3,'EMF7041',82,'Entrada','YERUTI','2017-08-29 16:38:59',NULL,NULL),
(1623,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,4,'EMF7025',30,'Entrada','YERUTI','2017-08-29 16:38:59',NULL,NULL),
(1624,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,5,'EMF3129',330,'Entrada','YERUTI','2017-08-29 16:38:59',NULL,NULL),
(1625,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,6,'EMF2252',222,'Entrada','YERUTI','2017-08-29 16:38:59',NULL,NULL),
(1626,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,7,'EMF2074',425,'Entrada','YERUTI','2017-08-29 16:38:59',NULL,NULL),
(1627,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,8,'EMF2123',84,'Entrada','YERUTI','2017-08-29 16:38:59',NULL,NULL),
(1628,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,9,'EMF7038F',40,'Entrada','YERUTI','2017-08-29 16:38:59',NULL,NULL),
(1629,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,10,'EMF7043F',88,'Entrada','YERUTI','2017-08-29 16:38:59',NULL,NULL),
(1630,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,1,'EMF7029F',84,'Entrada','YERUTI','2017-08-29 16:45:26',NULL,NULL),
(1631,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,2,'EMF7042F',324,'Entrada','YERUTI','2017-08-29 16:45:26',NULL,NULL),
(1632,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,3,'EMF7024F',192,'Entrada','YERUTI','2017-08-29 16:45:26',NULL,NULL),
(1633,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,4,'EMF7023F',250,'Entrada','YERUTI','2017-08-29 16:45:26',NULL,NULL),
(1634,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,5,'MF0254F',3,'Entrada','YERUTI','2017-08-29 16:45:26',NULL,NULL),
(1635,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,6,'EMF3016F',12,'Entrada','YERUTI','2017-08-29 16:45:26',NULL,NULL),
(1636,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,7,'EMF3127F',13,'Entrada','YERUTI','2017-08-29 16:45:26',NULL,NULL),
(1637,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,8,'MF00150F',41,'Entrada','YERUTI','2017-08-29 16:45:26',NULL,NULL),
(1638,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,9,'MF00232F',42,'Entrada','YERUTI','2017-08-29 16:45:26',NULL,NULL),
(1639,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,10,'EMF7041F',35,'Entrada','YERUTI','2017-08-29 16:45:26',NULL,NULL),
(1640,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,1,'EMF7026F',120,'Entrada','YERUTI','2017-08-29 16:51:06',NULL,NULL),
(1641,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,2,'EMF7027F',672,'Entrada','YERUTI','2017-08-29 16:51:06',NULL,NULL),
(1642,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,3,'EMF7040F',192,'Entrada','YERUTI','2017-08-29 16:51:06',NULL,NULL),
(1643,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,4,'EMF7025F',1260,'Entrada','YERUTI','2017-08-29 16:51:06',NULL,NULL),
(1644,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,5,'EMF3129F',2130,'Entrada','YERUTI','2017-08-29 16:51:06',NULL,NULL),
(1645,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,6,'EMF0185F',6,'Entrada','YERUTI','2017-08-29 16:51:06',NULL,NULL),
(1646,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,7,'BX-084',61,'Entrada','YERUTI','2017-08-29 16:51:06',NULL,NULL),
(1647,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,8,'BX-239P ',26,'Entrada','YERUTI','2017-08-29 16:51:06',NULL,NULL),
(1648,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,9,'BX-239F',12,'Entrada','YERUTI','2017-08-29 16:51:06',NULL,NULL),
(1649,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,10,'BG-001',513,'Entrada','YERUTI','2017-08-29 16:51:07',NULL,NULL),
(1650,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,11,'BX-500',57,'Entrada','YERUTI','2017-08-29 16:51:07',NULL,NULL),
(1651,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,12,'SI-501',1,'Entrada','YERUTI','2017-08-29 16:51:07',NULL,NULL),
(1652,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,1,'EMF0203F',6,'Entrada','YERUTI','2017-08-29 17:10:09',NULL,NULL),
(1653,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,2,'BX-1005',109,'Entrada','YERUTI','2017-08-29 17:10:09',NULL,NULL),
(1654,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,3,'BX-1005F',40,'Entrada','YERUTI','2017-08-29 17:10:09',NULL,NULL),
(1655,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,5,'BX-1005VF',106,'Entrada','YERUTI','2017-08-29 17:10:09',NULL,NULL),
(1656,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,6,'BX-1012VF',95,'Entrada','YERUTI','2017-08-29 17:10:09',NULL,NULL),
(1657,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,6,'BX-1011F',40,'Entrada','YERUTI','2017-08-29 17:10:09',NULL,NULL),
(1658,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,7,'BX-1012',18,'Entrada','YERUTI','2017-08-29 17:10:09',NULL,NULL),
(1659,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,8,'BX-1012F',20,'Entrada','YERUTI','2017-08-29 17:10:09',NULL,NULL),
(1660,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,9,'PU-344F',324,'Entrada','YERUTI','2017-08-29 17:10:09',NULL,NULL),
(1661,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,10,'PU-350F',210,'Entrada','YERUTI','2017-08-29 17:10:10',NULL,NULL),
(1662,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,11,'TG-110',9,'Entrada','YERUTI','2017-08-29 17:10:10',NULL,NULL),
(1663,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,12,'TG-110F',9,'Entrada','YERUTI','2017-08-29 17:10:10',NULL,NULL),
(1664,2908,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,13,'TG-112',16,'Entrada','YERUTI','2017-08-29 17:10:10',NULL,NULL),
(1665,2909,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,1,'TG112F',116,'Entrada','YERUTI','2017-08-29 17:13:30',NULL,NULL),
(1666,2909,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,2,'TQ089',132,'Entrada','YERUTI','2017-08-29 17:13:30',NULL,NULL),
(1667,2909,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,3,'CT-085F',35,'Entrada','YERUTI','2017-08-29 17:13:30',NULL,NULL),
(1668,2909,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,4,'BX-246',270,'Entrada','YERUTI','2017-08-29 17:13:30',NULL,NULL),
(1669,2909,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,5,'FC-419',97,'Entrada','YERUTI','2017-08-29 17:13:30',NULL,NULL),
(1670,2909,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,6,'FC-419F',29,'Entrada','YERUTI','2017-08-29 17:13:30',NULL,NULL),
(1671,2909,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,7,'FC-544',98,'Entrada','YERUTI','2017-08-29 17:13:31',NULL,NULL),
(1672,2909,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,8,'FC-544F',21,'Entrada','YERUTI','2017-08-29 17:13:31',NULL,NULL),
(1673,2909,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,9,'FC-007',112,'Entrada','YERUTI','2017-08-29 17:13:31',NULL,NULL),
(1674,2909,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,10,'FC-007F',50,'Entrada','YERUTI','2017-08-29 17:13:31',NULL,NULL),
(1675,2909,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,11,'BX-258',60,'Entrada','YERUTI','2017-08-29 17:13:31',NULL,NULL),
(1676,2909,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,12,'BX-258F',84,'Entrada','YERUTI','2017-08-29 17:13:31',NULL,NULL),
(1677,2909,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,13,'BX-257',72,'Entrada','YERUTI','2017-08-29 17:13:31',NULL,NULL),
(1678,2909,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,14,'BX-257F',46,'Entrada','YERUTI','2017-08-29 17:13:31',NULL,NULL),
(1679,2909,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,15,'BX-206',45,'Entrada','YERUTI','2017-08-29 17:13:31',NULL,NULL),
(1680,2909,'ACTI','2017-08-29','Fáb. Capiatá','Yeruti Vazquez',34,16,'BX-206F',67,'Entrada','YERUTI','2017-08-29 17:13:31',NULL,NULL),
(1681,2909,'ACTI','2017-08-30','Seleccione...','Yeruti Vazquez',34,1,'IN-006F',6,'Entrada','YERUTI','2017-08-30 09:41:38',NULL,NULL),
(1682,2909,'ACTI','2017-08-30','Seleccione...','Yeruti Vazquez',34,2,'IN-008F',1,'Entrada','YERUTI','2017-08-30 09:41:38',NULL,NULL),
(1683,2909,'ACTI','2017-08-30','Seleccione...','Yeruti Vazquez',34,3,'IN-018F',61,'Entrada','YERUTI','2017-08-30 09:41:38',NULL,NULL),
(1684,2909,'ACTI','2017-08-30','Seleccione...','Yeruti Vazquez',34,4,'IN-017F',43,'Entrada','YERUTI','2017-08-30 09:41:38',NULL,NULL),
(1685,2909,'ACTI','2017-08-30','Seleccione...','Yeruti Vazquez',34,5,'CG-182F',133,'Entrada','YERUTI','2017-08-30 09:41:38',NULL,NULL),
(1686,2909,'ACTI','2017-08-30','Seleccione...','Yeruti Vazquez',34,6,'IN-047F',27,'Entrada','YERUTI','2017-08-30 09:41:38',NULL,NULL),
(1687,2909,'ACTI','2017-08-30','Seleccione...','Yeruti Vazquez',34,7,'IN-012F',34,'Entrada','YERUTI','2017-08-30 09:41:38',NULL,NULL),
(1688,2909,'ACTI','2017-08-30','Seleccione...','Yeruti Vazquez',34,8,'IN-013F',28,'Entrada','YERUTI','2017-08-30 09:41:38',NULL,NULL),
(1689,2909,'ACTI','2017-08-30','Seleccione...','Yeruti Vazquez',34,9,'IN-011F',43,'Entrada','YERUTI','2017-08-30 09:41:38',NULL,NULL),
(1690,2909,'ACTI','2017-08-30','Seleccione...','Yeruti Vazquez',34,10,'IN-004F',40,'Entrada','YERUTI','2017-08-30 09:41:38',NULL,NULL),
(1691,2909,'ACTI','2017-08-30','Seleccione...','Yeruti Vazquez',34,1,'IN-003F',64,'Entrada','YERUTI','2017-08-30 09:57:06',NULL,NULL),
(1692,2909,'ACTI','2017-08-30','Seleccione...','Yeruti Vazquez',34,2,'IN-009F',16,'Entrada','YERUTI','2017-08-30 09:57:06',NULL,NULL),
(1693,2909,'ACTI','2017-08-30','Seleccione...','Yeruti Vazquez',34,3,'IN-010F',11,'Entrada','YERUTI','2017-08-30 09:57:06',NULL,NULL),
(1694,2909,'ACTI','2017-08-30','Seleccione...','Yeruti Vazquez',34,4,'IN-015F',18,'Entrada','YERUTI','2017-08-30 09:57:06',NULL,NULL),
(1695,2909,'ACTI','2017-08-30','Seleccione...','Yeruti Vazquez',34,5,'CG-179F',81,'Entrada','YERUTI','2017-08-30 09:57:07',NULL,NULL),
(1696,2909,'ACTI','2017-08-30','Seleccione...','Yeruti Vazquez',34,6,'CG-171F',200,'Entrada','YERUTI','2017-08-30 09:57:07',NULL,NULL),
(1697,2909,'ACTI','2017-08-30','Seleccione...','Yeruti Vazquez',34,7,'IN-056F',206,'Entrada','YERUTI','2017-08-30 09:57:07',NULL,NULL),
(1698,2909,'ACTI','2017-08-30','Seleccione...','Yeruti Vazquez',34,8,'IN-058F',58,'Entrada','YERUTI','2017-08-30 09:57:07',NULL,NULL),
(1699,2909,'ACTI','2017-08-30','Seleccione...','Yeruti Vazquez',34,9,'IN-061',159,'Entrada','YERUTI','2017-08-30 09:57:07',NULL,NULL),
(1700,2909,'ACTI','2017-08-30','Seleccione...','Yeruti Vazquez',34,10,'IN-017',386,'Entrada','YERUTI','2017-08-30 09:57:07',NULL,NULL),
(1701,2909,'ACTI','2017-08-30','Seleccione...','Yeruti Vazquez',34,11,'IN-008',13,'Entrada','YERUTI','2017-08-30 09:57:07',NULL,NULL),
(1702,2909,'ACTI','2017-08-30','Seleccione...','Yeruti Vazquez',34,12,'IN-047',47,'Entrada','YERUTI','2017-08-30 09:57:07',NULL,NULL),
(1703,2909,'ACTI','2017-08-30','Seleccione...','Yeruti Vazquez',34,13,'IN-061',332,'Entrada','YERUTI','2017-08-30 09:57:07',NULL,NULL),
(1704,2909,'ACTI','2017-08-30','Fáb. Capiatá','Yeruti Vazquez',34,1,'IN-056',390,'Entrada','YERUTI','2017-08-30 11:49:14',NULL,NULL),
(1705,2909,'ACTI','2017-08-30','Fáb. Capiatá','Yeruti Vazquez',34,2,'IN-006',41,'Entrada','YERUTI','2017-08-30 11:49:14',NULL,NULL),
(1706,2909,'ACTI','2017-08-30','Fáb. Capiatá','Yeruti Vazquez',34,3,'IN-005',35,'Entrada','YERUTI','2017-08-30 11:49:14',NULL,NULL),
(1707,2909,'ACTI','2017-08-30','Fáb. Capiatá','Yeruti Vazquez',34,4,'IN-010',59,'Entrada','YERUTI','2017-08-30 11:49:14',NULL,NULL),
(1708,2909,'ACTI','2017-08-30','Fáb. Capiatá','Yeruti Vazquez',34,5,'IN-011',126,'Entrada','YERUTI','2017-08-30 11:49:14',NULL,NULL),
(1709,2909,'ACTI','2017-08-30','Fáb. Capiatá','Yeruti Vazquez',34,6,'IN-004',108,'Entrada','YERUTI','2017-08-30 11:49:14',NULL,NULL),
(1710,2909,'ACTI','2017-08-30','Fáb. Capiatá','Yeruti Vazquez',34,7,'IN-003',218,'Entrada','YERUTI','2017-08-30 11:49:14',NULL,NULL),
(1711,2909,'ACTI','2017-08-30','Fáb. Capiatá','Yeruti Vazquez',34,8,'IN-015',46,'Entrada','YERUTI','2017-08-30 11:49:14',NULL,NULL),
(1712,2909,'ACTI','2017-08-30','Fáb. Capiatá','Yeruti Vazquez',34,9,'IN-009',65,'Entrada','YERUTI','2017-08-30 11:49:14',NULL,NULL),
(1713,2909,'ACTI','2017-08-30','Fáb. Capiatá','Yeruti Vazquez',34,10,'IN-013',59,'Entrada','YERUTI','2017-08-30 11:49:14',NULL,NULL),
(1714,2908,'ACTI','2017-08-30','Fáb. Capiatá','Yeruti Vazquez',34,1,'IN-012',108,'Entrada','YERUTI','2017-08-30 11:53:30',NULL,NULL),
(1715,2908,'ACTI','2017-08-30','Fáb. Capiatá','Yeruti Vazquez',34,2,'IN-058',97,'Entrada','YERUTI','2017-08-30 11:53:30',NULL,NULL),
(1716,2908,'ACTI','2017-08-30','Fáb. Capiatá','Yeruti Vazquez',34,3,'IN-018',455,'Entrada','YERUTI','2017-08-30 11:53:30',NULL,NULL),
(1717,2908,'ACTI','2017-08-30','Fáb. Capiatá','Yeruti Vazquez',34,4,'DC-006',100,'Entrada','YERUTI','2017-08-30 11:53:30',NULL,NULL),
(1718,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,1,'1125B',5004,'Entrada','MAGALI','2017-09-13 11:06:59',NULL,NULL),
(1719,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,2,'1125A',449,'Entrada','MAGALI','2017-09-13 11:06:59',NULL,NULL),
(1720,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,3,'1125I',100,'Entrada','MAGALI','2017-09-13 11:06:59',NULL,NULL),
(1721,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,4,'SIL784',140,'Entrada','MAGALI','2017-09-13 11:06:59',NULL,NULL),
(1722,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,5,'SL999A',180,'Entrada','MAGALI','2017-09-13 11:06:59',NULL,NULL),
(1723,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,6,'SLCPS',10,'Entrada','MAGALI','2017-09-13 11:06:59',NULL,NULL),
(1724,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,7,'SL768I',20,'Entrada','MAGALI','2017-09-13 11:06:59',NULL,NULL),
(1725,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,8,'1335D',166,'Entrada','MAGALI','2017-09-13 11:06:59',NULL,NULL),
(1726,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,9,'1629JD',171,'Entrada','MAGALI','2017-09-13 11:06:59',NULL,NULL),
(1727,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,10,'1038DD',276,'Entrada','MAGALI','2017-09-13 11:06:59',NULL,NULL),
(1728,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,1,'1335C',102,'Entrada','MAGALI','2017-09-13 11:10:34',NULL,NULL),
(1729,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,2,'1629JC',220,'Entrada','MAGALI','2017-09-13 11:10:34',NULL,NULL),
(1730,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,3,'1038DC',302,'Entrada','MAGALI','2017-09-13 11:10:34',NULL,NULL),
(1731,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,4,'1335O',212,'Entrada','MAGALI','2017-09-13 11:10:34',NULL,NULL),
(1732,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,5,'1629JO',265,'Entrada','MAGALI','2017-09-13 11:10:34',NULL,NULL),
(1733,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,6,'1038DO',277,'Entrada','MAGALI','2017-09-13 11:10:34',NULL,NULL),
(1734,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,7,'1335F',100,'Entrada','MAGALI','2017-09-13 11:10:34',NULL,NULL),
(1735,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,8,'1629JF',100,'Entrada','MAGALI','2017-09-13 11:10:34',NULL,NULL),
(1736,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,9,'1038DF',100,'Entrada','MAGALI','2017-09-13 11:10:34',NULL,NULL),
(1737,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,10,'1629BD',32,'Entrada','MAGALI','2017-09-13 11:10:34',NULL,NULL),
(1738,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,1,'1571C',129,'Entrada','MAGALI','2017-09-13 11:14:56',NULL,NULL),
(1739,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,2,'1571B',480,'Entrada','MAGALI','2017-09-13 11:14:56',NULL,NULL),
(1740,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,3,'1570B',100,'Entrada','MAGALI','2017-09-13 11:14:56',NULL,NULL),
(1741,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,4,'1570C',119,'Entrada','MAGALI','2017-09-13 11:14:56',NULL,NULL),
(1742,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,5,'1571GRB',52,'Entrada','MAGALI','2017-09-13 11:14:56',NULL,NULL),
(1743,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,6,'1570GRB',55,'Entrada','MAGALI','2017-09-13 11:14:56',NULL,NULL),
(1744,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,7,'3532D',81,'Entrada','MAGALI','2017-09-13 11:14:56',NULL,NULL),
(1745,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,8,'3532C',137,'Entrada','MAGALI','2017-09-13 11:14:56',NULL,NULL),
(1746,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,9,'3532O',107,'Entrada','MAGALI','2017-09-13 11:14:56',NULL,NULL),
(1747,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,10,'3532F',30,'Entrada','MAGALI','2017-09-13 11:14:56',NULL,NULL),
(1748,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,1,'3536D',95,'Entrada','MAGALI','2017-09-13 11:18:10',NULL,NULL),
(1749,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,2,'3536C',149,'Entrada','MAGALI','2017-09-13 11:18:10',NULL,NULL),
(1750,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,3,'3536O',55,'Entrada','MAGALI','2017-09-13 11:18:10',NULL,NULL),
(1751,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,4,'3536F',58,'Entrada','MAGALI','2017-09-13 11:18:10',NULL,NULL),
(1752,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,5,'3530D',215,'Entrada','MAGALI','2017-09-13 11:18:10',NULL,NULL),
(1753,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,6,'3530C',248,'Entrada','MAGALI','2017-09-13 11:18:10',NULL,NULL),
(1754,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,7,'3530O',130,'Entrada','MAGALI','2017-09-13 11:18:10',NULL,NULL),
(1755,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,8,'3530F',20,'Entrada','MAGALI','2017-09-13 11:18:10',NULL,NULL),
(1756,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,9,'3534D',172,'Entrada','MAGALI','2017-09-13 11:18:10',NULL,NULL),
(1757,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,10,'3534C',176,'Entrada','MAGALI','2017-09-13 11:18:10',NULL,NULL),
(1758,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,1,'3534O',54,'Entrada','MAGALI','2017-09-13 11:22:42',NULL,NULL),
(1759,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,2,'3534F',20,'Entrada','MAGALI','2017-09-13 11:22:42',NULL,NULL),
(1760,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,3,'3532MO',28,'Entrada','MAGALI','2017-09-13 11:22:42',NULL,NULL),
(1761,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,4,'3532MC',30,'Entrada','MAGALI','2017-09-13 11:22:42',NULL,NULL),
(1762,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,5,'3536MC',7,'Entrada','MAGALI','2017-09-13 11:22:42',NULL,NULL),
(1763,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,6,'3536MO',15,'Entrada','MAGALI','2017-09-13 11:22:42',NULL,NULL),
(1764,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,7,'3230D',285,'Entrada','MAGALI','2017-09-13 11:22:42',NULL,NULL),
(1765,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,8,'3230C',131,'Entrada','MAGALI','2017-09-13 11:22:42',NULL,NULL),
(1766,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,9,'3230O',70,'Entrada','MAGALI','2017-09-13 11:22:42',NULL,NULL),
(1767,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,10,'3230MC',6,'Entrada','MAGALI','2017-09-13 11:22:42',NULL,NULL),
(1768,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,1,'FELPA7X5',3,'Entrada','MAGALI','2017-09-13 11:30:25',NULL,NULL),
(1769,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,2,'1520D',177,'Entrada','MAGALI','2017-09-13 11:30:25',NULL,NULL),
(1770,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,3,'1520C',102,'Entrada','MAGALI','2017-09-13 11:30:25',NULL,NULL),
(1771,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,4,'1520O',65,'Entrada','MAGALI','2017-09-13 11:30:25',NULL,NULL),
(1772,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,5,'1504D',171,'Entrada','MAGALI','2017-09-13 11:30:25',NULL,NULL),
(1773,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,6,'1504C',37,'Entrada','MAGALI','2017-09-13 11:30:25',NULL,NULL),
(1774,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,7,'1504O',55,'Entrada','MAGALI','2017-09-13 11:30:25',NULL,NULL),
(1775,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,8,'1531D',181,'Entrada','MAGALI','2017-09-13 11:30:25',NULL,NULL),
(1776,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,9,'1531C',66,'Entrada','MAGALI','2017-09-13 11:30:25',NULL,NULL),
(1777,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,10,'1531O',20,'Entrada','MAGALI','2017-09-13 11:30:25',NULL,NULL),
(1778,3109,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,1,'1504AD',168,'Entrada','MAGALI','2017-09-13 11:33:58',NULL,NULL),
(1779,3109,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,2,'1504AC',135,'Entrada','MAGALI','2017-09-13 11:33:58',NULL,NULL),
(1780,3109,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,3,'1504AO',150,'Entrada','MAGALI','2017-09-13 11:33:58',NULL,NULL),
(1781,3109,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,4,'1504MF',16,'Entrada','MAGALI','2017-09-13 11:33:58',NULL,NULL),
(1782,3109,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,5,'1201D',158,'Entrada','MAGALI','2017-09-13 11:33:58',NULL,NULL),
(1783,3109,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,6,'1201C',254,'Entrada','MAGALI','2017-09-13 11:33:58',NULL,NULL),
(1784,3109,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,7,'1201O',166,'Entrada','MAGALI','2017-09-13 11:33:58',NULL,NULL),
(1785,3109,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,8,'1013D',302,'Entrada','MAGALI','2017-09-13 11:33:58',NULL,NULL),
(1786,3109,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,9,'1013C',50,'Entrada','MAGALI','2017-09-13 11:33:58',NULL,NULL),
(1787,3109,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,10,'1013O',209,'Entrada','MAGALI','2017-09-13 11:33:58',NULL,NULL),
(1788,3109,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,1,'1801A',220,'Entrada','MAGALI','2017-09-13 11:39:15',NULL,NULL),
(1789,3109,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,2,'1801AC',356,'Entrada','MAGALI','2017-09-13 11:39:15',NULL,NULL),
(1790,3109,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,3,'1801AO',150,'Entrada','MAGALI','2017-09-13 11:39:15',NULL,NULL),
(1791,3109,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,4,'1101D',127,'Entrada','MAGALI','2017-09-13 11:39:15',NULL,NULL),
(1792,3109,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,5,'1103D',128,'Entrada','MAGALI','2017-09-13 11:39:15',NULL,NULL),
(1793,3109,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,6,'1101C',33,'Entrada','MAGALI','2017-09-13 11:39:15',NULL,NULL),
(1794,3109,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,7,'1103C',35,'Entrada','MAGALI','2017-09-13 11:39:15',NULL,NULL),
(1795,3109,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,8,'1101O',150,'Entrada','MAGALI','2017-09-13 11:39:15',NULL,NULL),
(1796,3109,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,9,'1103O',150,'Entrada','MAGALI','2017-09-13 11:39:15',NULL,NULL),
(1797,3109,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,10,'HDL-84TD',97,'Entrada','MAGALI','2017-09-13 11:39:16',NULL,NULL),
(1798,3109,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,11,'HDL-84TC',252,'Entrada','MAGALI','2017-09-13 11:39:16',NULL,NULL),
(1799,3109,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,1,'BTS-75',22,'Entrada','MAGALI','2017-09-13 11:44:32',NULL,NULL),
(1800,3109,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,2,'FREGDS',106,'Entrada','MAGALI','2017-09-13 11:44:32',NULL,NULL),
(1801,3109,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,3,'1607M',68,'Entrada','MAGALI','2017-09-13 11:44:32',NULL,NULL),
(1802,3109,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,4,'1609',86,'Entrada','MAGALI','2017-09-13 11:44:32',NULL,NULL),
(1803,3109,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,5,'C30C',51,'Entrada','MAGALI','2017-09-13 11:44:32',NULL,NULL),
(1804,3109,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,6,'C45C',35,'Entrada','MAGALI','2017-09-13 11:44:32',NULL,NULL),
(1805,3109,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,7,'H30C',19,'Entrada','MAGALI','2017-09-13 11:44:32',NULL,NULL),
(1806,3109,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,9,'H30RB',31,'Entrada','MAGALI','2017-09-13 11:44:32',NULL,NULL),
(1807,3109,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,9,'H30D',1,'Entrada','MAGALI','2017-09-13 11:44:32',NULL,NULL),
(1808,3109,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,10,'H30B',31,'Entrada','MAGALI','2017-09-13 11:44:32',NULL,NULL),
(1809,3109,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,1,'S30C',52,'Entrada','MAGALI','2017-09-13 14:16:57',NULL,NULL),
(1810,3109,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,2,'S30B',1,'Entrada','MAGALI','2017-09-13 14:16:57',NULL,NULL),
(1811,3109,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,3,'1921D',72,'Entrada','MAGALI','2017-09-13 14:16:57',NULL,NULL),
(1812,3109,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,4,'1921O',223,'Entrada','MAGALI','2017-09-13 14:16:57',NULL,NULL),
(1813,3109,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,5,'1921C',42,'Entrada','MAGALI','2017-09-13 14:16:57',NULL,NULL),
(1814,3109,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,6,'HVA30B',193,'Entrada','MAGALI','2017-09-13 14:16:57',NULL,NULL),
(1815,3109,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,7,'HVA25O',59,'Entrada','MAGALI','2017-09-13 14:16:57',NULL,NULL),
(1816,3109,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,8,'HVA25C',87,'Entrada','MAGALI','2017-09-13 14:16:57',NULL,NULL),
(1817,3109,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,9,'HVA30B',22,'Entrada','MAGALI','2017-09-13 14:16:57',NULL,NULL),
(1818,3109,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,10,'HVA30C',80,'Entrada','MAGALI','2017-09-13 14:16:57',NULL,NULL),
(1819,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,1,'1114D',184,'Entrada','MAGALI','2017-09-13 14:25:15',NULL,NULL),
(1820,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,2,'1114C',120,'Entrada','MAGALI','2017-09-13 14:25:15',NULL,NULL),
(1821,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,3,'1115C',4,'Entrada','MAGALI','2017-09-13 14:25:15',NULL,NULL),
(1822,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,4,'1115D',40,'Entrada','MAGALI','2017-09-13 14:25:15',NULL,NULL),
(1823,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,5,'1230C',175,'Entrada','MAGALI','2017-09-13 14:25:15',NULL,NULL),
(1824,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,6,'1230D',50,'Entrada','MAGALI','2017-09-13 14:25:15',NULL,NULL),
(1825,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,7,'1302C',30,'Entrada','MAGALI','2017-09-13 14:25:15',NULL,NULL),
(1826,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,8,'1307D',12,'Entrada','MAGALI','2017-09-13 14:25:15',NULL,NULL),
(1827,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,9,'CEID',5,'Entrada','MAGALI','2017-09-13 14:25:15',NULL,NULL),
(1828,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,1,'1130D',199,'Entrada','MAGALI','2017-09-13 14:29:30',NULL,NULL),
(1829,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,2,'1310C',12,'Entrada','MAGALI','2017-09-13 14:29:30',NULL,NULL),
(1830,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,3,'1310D',150,'Entrada','MAGALI','2017-09-13 14:29:30',NULL,NULL),
(1831,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,4,'1913',35,'Entrada','MAGALI','2017-09-13 14:29:30',NULL,NULL),
(1832,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,5,'DGSI',20,'Entrada','MAGALI','2017-09-13 14:29:30',NULL,NULL),
(1833,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,6,'1307D',12,'Entrada','MAGALI','2017-09-13 14:29:30',NULL,NULL),
(1834,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,7,'1315D',39,'Entrada','MAGALI','2017-09-13 14:29:30',NULL,NULL),
(1835,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,8,'1132D',14,'Entrada','MAGALI','2017-09-13 14:29:30',NULL,NULL),
(1836,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,9,'1129D',103,'Entrada','MAGALI','2017-09-13 14:29:30',NULL,NULL),
(1837,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,10,'1800CR',4,'Entrada','MAGALI','2017-09-13 14:29:30',NULL,NULL),
(1838,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,1,'1336D',30,'Entrada','MAGALI','2017-09-13 14:33:15',NULL,NULL),
(1839,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,2,'OREJAF',26,'Entrada','MAGALI','2017-09-13 14:33:15',NULL,NULL),
(1840,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,3,'1510CMAC',20,'Entrada','MAGALI','2017-09-13 14:33:15',NULL,NULL),
(1841,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,4,'1510DMAC',50,'Entrada','MAGALI','2017-09-13 14:33:15',NULL,NULL),
(1842,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,5,'1123BD',42,'Entrada','MAGALI','2017-09-13 14:33:15',NULL,NULL),
(1843,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,6,'1123BC',238,'Entrada','MAGALI','2017-09-13 14:33:15',NULL,NULL),
(1844,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,7,'KITBC',35,'Entrada','MAGALI','2017-09-13 14:33:15',NULL,NULL),
(1845,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,8,'KITBD',30,'Entrada','MAGALI','2017-09-13 14:33:15',NULL,NULL),
(1846,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,9,'BCC100C',25,'Entrada','MAGALI','2017-09-13 14:33:15',NULL,NULL),
(1847,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,10,'BCC60C',45,'Entrada','MAGALI','2017-09-13 14:33:15',NULL,NULL),
(1848,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,1,'1800AD',55,'Entrada','MAGALI','2017-09-13 14:36:54',NULL,NULL),
(1849,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,2,'1125R1',100,'Entrada','MAGALI','2017-09-13 14:36:54',NULL,NULL),
(1850,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,3,'BCC42C',86,'Entrada','MAGALI','2017-09-13 14:36:54',NULL,NULL),
(1851,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,4,'1101A',150,'Entrada','MAGALI','2017-09-13 14:36:54',NULL,NULL),
(1852,3108,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',34,5,'1103A',150,'Entrada','MAGALI','2017-09-13 14:36:54',NULL,NULL),
(1853,150959,'ACTI','2017-09-13','Stock B','Yeruti Vazquez',31,1,'1607M',10,'Salida','MAGALI','2017-09-13 14:55:13',NULL,NULL),
(1854,150959,'ACTI','2017-09-13','Stock B','Yeruti Vazquez',31,2,'1103D',7,'Salida','MAGALI','2017-09-13 14:55:13',NULL,NULL),
(1855,150959,'ACTI','2017-09-13','Stock B','Yeruti Vazquez',31,3,'SL999A',20,'Salida','MAGALI','2017-09-13 14:55:14',NULL,NULL),
(1856,150959,'ACTI','2017-09-13','Stock B','Yeruti Vazquez',31,4,'HDL-84TC',24,'Salida','MAGALI','2017-09-13 14:55:14',NULL,NULL),
(1857,150959,'ACTI','2017-09-13','Stock B','Yeruti Vazquez',31,5,'3530D',4,'Salida','MAGALI','2017-09-13 14:55:14',NULL,NULL),
(1858,155776,'ACTI','2017-09-13','Instalaciones','Yeruti Vazquez',31,1,'3530C',12,'Salida','MAGALI','2017-09-13 14:58:22',NULL,NULL),
(1859,155776,'ACTI','2017-09-13','Instalaciones','Yeruti Vazquez',31,2,'3534C',12,'Salida','MAGALI','2017-09-13 14:58:22',NULL,NULL),
(1860,155783,'ACTI','2017-09-13','Instalaciones','Yeruti Vazquez',31,1,'SL999A',40,'Salida','MAGALI','2017-09-13 14:59:04',NULL,NULL),
(1861,155783,'ACTI','2017-09-13','Instalaciones','Yeruti Vazquez',31,1,'FELPA5X7',4,'Salida','MAGALI','2017-09-13 14:59:32',NULL,NULL),
(1862,155787,'ACTI','2017-09-13','Instalaciones','Yeruti Vazquez',31,1,'FELPA5X7',14,'Salida','MAGALI','2017-09-13 15:03:45',NULL,NULL),
(1863,155787,'ACTI','2017-09-13','Instalaciones','Yeruti Vazquez',31,2,'SL999A',80,'Salida','MAGALI','2017-09-13 15:03:46',NULL,NULL),
(1864,157163,'ACTI','2017-09-13','Instalaciones','Yeruti Vazquez',31,1,'SL999A',80,'Salida','MAGALI','2017-09-13 15:11:01',NULL,NULL),
(1865,157163,'ACTI','2017-09-13','Instalaciones','Yeruti Vazquez',31,2,'SIL784',60,'Salida','MAGALI','2017-09-13 15:11:01',NULL,NULL),
(1866,157163,'ACTI','2017-09-13','Instalaciones','Yeruti Vazquez',31,3,'1125B',400,'Salida','MAGALI','2017-09-13 15:11:01',NULL,NULL),
(1867,157163,'ACTI','2017-09-13','Instalaciones','Yeruti Vazquez',31,4,'1335D',40,'Salida','MAGALI','2017-09-13 15:11:01',NULL,NULL),
(1868,157163,'ACTI','2017-09-13','Instalaciones','Yeruti Vazquez',31,5,'1629JD',40,'Salida','MAGALI','2017-09-13 15:11:01',NULL,NULL),
(1869,157163,'ACTI','2017-09-13','Instalaciones','Yeruti Vazquez',31,6,'1038DD',40,'Salida','MAGALI','2017-09-13 15:11:01',NULL,NULL),
(1870,157163,'ACTI','2017-09-13','Instalaciones','Yeruti Vazquez',31,7,'FELPA5X7',15,'Salida','MAGALI','2017-09-13 15:11:01',NULL,NULL),
(1871,157163,'ACTI','2017-09-13','Instalaciones','Yeruti Vazquez',31,8,'FELPA5X5',10,'Salida','MAGALI','2017-09-13 15:11:01',NULL,NULL),
(1872,157163,'ACTI','2017-09-13','Instalaciones','Yeruti Vazquez',31,9,'3530D',25,'Salida','MAGALI','2017-09-13 15:11:01',NULL,NULL),
(1873,157163,'ACTI','2017-09-13','Instalaciones','Yeruti Vazquez',31,10,'3534D',20,'Salida','MAGALI','2017-09-13 15:11:02',NULL,NULL),
(1874,157163,'ACTI','2017-09-13','Instalaciones','Yeruti Vazquez',31,11,'1629BD',20,'Salida','MAGALI','2017-09-13 15:11:02',NULL,NULL),
(1875,157163,'ACTI','2017-09-13','Instalaciones','Yeruti Vazquez',31,12,'HVA25B',20,'Salida','MAGALI','2017-09-13 15:11:02',NULL,NULL),
(1876,157163,'ACTI','2017-09-13','Instalaciones','Yeruti Vazquez',31,13,'1921D',40,'Salida','MAGALI','2017-09-13 15:11:02',NULL,NULL),
(1877,157163,'ACTI','2017-09-13','Instalaciones','Yeruti Vazquez',31,14,'1571B',15,'Salida','MAGALI','2017-09-13 15:11:02',NULL,NULL),
(1878,157163,'ACTI','2017-09-13','Instalaciones','Yeruti Vazquez',31,15,'1607M',20,'Salida','MAGALI','2017-09-13 15:11:02',NULL,NULL),
(1879,157163,'ACTI','2017-09-13','Instalaciones','Yeruti Vazquez',31,16,'H30C',6,'Salida','MAGALI','2017-09-13 15:11:02',NULL,NULL),
(1880,155791,'ACTI','2017-09-13','Instalaciones','Yeruti Vazquez',31,1,'1125B',100,'Salida','MAGALI','2017-09-13 15:12:35',NULL,NULL),
(1881,155791,'ACTI','2017-09-13','Instalaciones','Yeruti Vazquez',31,2,'3530C',12,'Salida','MAGALI','2017-09-13 15:12:35',NULL,NULL),
(1882,155791,'ACTI','2017-09-13','Instalaciones','Yeruti Vazquez',31,3,'FELPA5X7',5,'Salida','MAGALI','2017-09-13 15:12:35',NULL,NULL),
(1883,154226,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',31,1,'1125B',500,'Salida','MAGALI','2017-09-13 15:22:18',NULL,NULL),
(1884,154226,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',31,2,'1607M',25,'Salida','MAGALI','2017-09-13 15:22:18',NULL,NULL),
(1885,154226,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',31,3,'FELPA5X7',15,'Salida','MAGALI','2017-09-13 15:22:18',NULL,NULL),
(1886,154226,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',31,4,'1571B',80,'Salida','MAGALI','2017-09-13 15:22:18',NULL,NULL),
(1887,154226,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',31,5,'1504AD',15,'Salida','MAGALI','2017-09-13 15:22:18',NULL,NULL),
(1888,154226,'ACTI','2017-09-13','Fáb. Capiatá','Yeruti Vazquez',31,6,'1504AC',10,'Salida','MAGALI','2017-09-13 15:22:18',NULL,NULL),
(1889,155794,'ACTI','2017-09-13','Instalaciones','Yeruti Vazquez',31,1,'1125B',200,'Salida','MAGALI','2017-09-13 15:22:59',NULL,NULL);

/*Table structure for table `stproductos` */

DROP TABLE IF EXISTS `stproductos`;

CREATE TABLE `stproductos` (
  `prodCodigo` varchar(20) NOT NULL,
  `prodDescripcion` varchar(60) NOT NULL,
  `prodEspesor` decimal(10,2) DEFAULT NULL,
  `prodLargo` decimal(10,0) DEFAULT NULL,
  `prodAlto` decimal(10,0) DEFAULT NULL,
  `prodM2` decimal(10,2) DEFAULT NULL,
  `prodVenta` double DEFAULT NULL,
  `prodColor` varchar(10) DEFAULT NULL,
  `prodStockMinimo` int(11) DEFAULT NULL,
  `prodTipo` char(10) DEFAULT NULL,
  PRIMARY KEY (`prodCodigo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `stproductos` */

insert  into `stproductos`(`prodCodigo`,`prodDescripcion`,`prodEspesor`,`prodLargo`,`prodAlto`,`prodM2`,`prodVenta`,`prodColor`,`prodStockMinimo`,`prodTipo`) values 
('100','Mesa',2.00,2,2,2.00,500000,'D',40,'Herrajes'),
('1013C','PIVOT CROMADO	',0.00,0,0,0.00,0,'C',10,'Herrajes'),
('1013D','PIVOT DORADO	',0.00,0,0,0.00,0,'G',10,'Herrajes'),
('1013O','PIVOT ORO',0.00,0,0,0.00,10060,'G',10,'Herrajes'),
('1038D','CONTRA PASADOR CILINDRO DORADO	',0.00,0,0,0.00,0,'D',10,'Herrajes'),
('1038DC','CONTRA PASADOR OMEGA CROMADO	',0.00,0,0,0.00,0,'C',10,'Herrajes'),
('1038DD','CONTRA PASADOR OMEGA DORADO	',0.00,0,0,0.00,0,'D',10,'Herrajes'),
('1038DF','CONTRA PASADOR OMEGA FOSCO	',0.00,0,0,0.00,0,'F',10,'Herrajes'),
('1038DO','CONTRA PASADOR OMEGA ORO	',0.00,0,0,0.00,0,'O',10,'Herrajes'),
('1101A','ZOCALO SUPERIOR ALUMINIO',0.00,0,0,0.00,27000,'N',10,'Herrajes'),
('1101C','ZOCALO SUPERIOR CROMADO	',0.00,0,0,0.00,0,'C',10,'Herrajes'),
('1101D','ZOCALO SUPERIOR DORADO	',0.00,0,0,0.00,0,'D',10,'Herrajes'),
('1101O','ZOCALO SUPERIOR ORO',0.00,0,0,0.00,0,'O',10,'Herrajes'),
('1103A','ZOCALO INFERIOR ALUMINIO',0.00,0,0,0.00,39000,'N',10,'Herrajes'),
('1103C','ZOCALO INFERIOR CROMADO	',0.00,0,0,0.00,0,'C',10,'Herrajes'),
('1103D','ZOCALO INFERIOR DORADO	',0.00,0,0,0.00,0,'D',10,'Herrajes'),
('1103O','ZOCALO INFERIOR ORO',0.00,0,0,0.00,0,'O',10,'Herrajes'),
('1114C','BISAGRA AUTOMAYICA P/ BOX V/P CROMADO	',0.00,0,0,0.00,0,'C',20,'Herrajes'),
('1114D','BISAGRA AUTOMATICA P/ BOX V/P	',0.00,0,0,0.00,0,'G',20,'Herrajes'),
('1115C','BISAGRA SIMPLE P/ BOX V/P CROMADO	',0.00,0,0,0.00,0,'D',20,'Herrajes'),
('1115D','BISAGRA SIMPLE P/ BOX V/P DORADO	',0.00,0,0,0.00,0,'C',20,'Herrajes'),
('1123BC','SOPORTE BASCULANTE  MACHO CROMADO',0.00,0,0,0.00,0,'C',10,'Herrajes'),
('1123BD','SOPORTE BASCULANTE MACHO',0.00,0,0,0.00,0,'D',10,'Herrajes'),
('1123D','SOPORTE P/ BASCULANTE CHICO MACHO DORADO	',0.00,0,0,0.00,0,'C',20,'Herrajes'),
('1125A','RUEDITA DOBLE DE CORRER	',0.00,0,0,0.00,0,'C',20,'Herrajes'),
('1125B','RUEDITA SIMPLE DE CORRER	',0.00,0,0,0.00,0,'C',20,'Herrajes'),
('1125B2','RUEDITA DOBLE CON REGULADOR R2	',0.00,0,0,0.00,0,'D',20,'Herrajes'),
('1125I','RUEDITA PARA 6MM',0.00,0,0,0.00,0,'G',0,'Herrajes'),
('1125R1','RUEDITA CON REGULADOR R1	',0.00,0,0,0.00,0,'D',20,'Herrajes'),
('1125R2','RUEIDTA DOBLE CON CARRO',0.00,0,0,0.00,0,'D',10,'Herrajes'),
('1127A','SOPORTE CENTRAL PTA. PLEGADIZA	',0.00,0,0,0.00,0,'D',20,'Herrajes'),
('1128A','BISAGRA HORIZONTAL SIMPLE C/PUNTO DE GIRO DORADO	',0.00,0,0,0.00,0,'D',20,'Herrajes'),
('1128AC','BISAGRA HORIZONTAL SIMPLE C/PUNTO DE GIRO CROMADO	',0.00,0,0,0.00,0,'D',20,'Herrajes'),
('1129D','BISAGRA AUTOMATICA V/V DORADO',0.00,0,0,0.00,0,'D',10,'Herrajes'),
('1130D','SOPORTE BASCULANTE GRANDE DORADO',0.00,0,0,0.00,0,'D',10,'Herrajes'),
('1132D','BISAGRA HORIZONTAL DOBLE',0.00,0,0,0.00,0,'D',10,'Herrajes'),
('1201C','BUJE P/ ZOCALO SUPERIOR CROMADO	',0.00,0,0,0.00,0,'D',20,'Herrajes'),
('1201D','BUJE P/ ZOCALO SUPERIOR DORADO	',0.00,0,0,0.00,0,'D',20,'Herrajes'),
('1201O','BUJE ORO',0.00,0,0,0.00,4980,'G',10,'Herrajes'),
('1203','SOPORTE P/BANDEROLA V/P DORADO	',0.00,0,0,0.00,0,'D',20,'Herrajes'),
('1203C','SOPORTE P/BANDEROLA V/P CROMADO	',0.00,0,0,0.00,0,'C',20,'Herrajes'),
('1230C','SOPORTE BASCULANTE HEMBRA CROMADO',0.00,0,0,0.00,0,'C',10,'Herrajes'),
('1230D','SOPORTE BASCULANTE HEMBRA V/V DORADO',0.00,0,0,0.00,0,'D',10,'Herrajes'),
('1302','SOPORTE ESQUINERO DORADO	',0.00,0,0,0.00,0,'D',20,'Herrajes'),
('1302C','SOPORTE ESQUINERO CROMADO	',0.00,0,0,0.00,0,'C',20,'Herrajes'),
('1307D','SOPORTE T3 S/NUCLEO DORADO',0.00,0,0,0.00,0,'D',10,'Herrajes'),
('1308D','SOPORTE T3 S/NUCLEO',0.00,0,0,0.00,0,'D',10,'Herrajes'),
('1310C','SOPORTE L3 P/3 VIDRIOS CROMADO',0.00,0,0,0.00,0,'D',10,'Herrajes'),
('1310D','SOPORTE L3 P/3 VIDRIOS DORADO',0.00,0,0,0.00,0,'D',10,'Herrajes'),
('1315D','SOPORTE L3 C/ TOPE DORADO',0.00,0,0,0.00,0,'D',10,'Herrajes'),
('1329','SOPOR. DE CENTRO',0.00,0,0,0.00,0,'D',20,'Herrajes'),
('1329C','SOPOR. DE CENTRO CROMADO	',0.00,0,0,0.00,0,'C',20,'Herrajes'),
('1335C','PASADOR CHICO S/ NUCLEO CROMADO',0.00,0,0,0.00,0,'C',20,'Herrajes'),
('1335D','PASADOR CHICO S/ NUCLEO DORADO	',0.00,0,0,0.00,0,'D',20,'Herrajes'),
('1335F','PASADOR CHICO S/ NUCLEO FOSCO	',0.00,0,0,0.00,0,'D',20,'Herrajes'),
('1335O','PASADOR CHICO S/ NUCLEO ORO',0.00,0,0,0.00,0,'O',20,'Herrajes'),
('1336D','SOPORTE DE CANTO Y PASADOR DORADO',0.00,0,0,0.00,0,'D',10,'Herrajes'),
('1504AC','ESPEJO CENTRO CROMADO',0.00,0,0,0.00,6028,'G',10,'Herrajes'),
('1504AD','ESPEJO CENTRO DORADO',0.00,0,0,0.00,8044,'G',10,'Herrajes'),
('1504AO','ESPEJO CENTRO ORO',0.00,0,0,0.00,6028,'G',10,'Herrajes'),
('1504C','CONTRA CERRADURA CENTRO S/ TOPE CROMADO	',0.00,0,0,0.00,0,'C',20,'Herrajes'),
('1504D','CONTRA CERRADURA CENTRO S/ TOPE DORADO',0.00,0,0,0.00,0,'D',20,'Herrajes'),
('1504MF','MINI ESPEJO CENTRO FOSCO',0.00,0,0,0.00,0,'G',10,'Herrajes'),
('1504O','CONTRA CERRADURA CENTRO SIN TOPE ORO',0.00,0,0,0.00,20140,'G',10,'Herrajes'),
('1510CMAC','CERRADURA P/BATIENTE MAC CROMADO',0.00,0,0,0.00,0,'C',10,'Herrajes'),
('1510DMAC','CERRADURA P/BATIENTE MAC DORADO',0.00,0,0,0.00,0,'C',10,'Herrajes'),
('1520C','CERRADURA CENTRO CROMADO	',0.00,0,0,0.00,0,'C',20,'Herrajes'),
('1520D','CERRADURA CENTRO DORADO	',0.00,0,0,0.00,0,'D',20,'Herrajes'),
('1520O','CERRADURA CENTRO ORO',0.00,0,0,0.00,0,'G',10,'Herrajes'),
('1531C','CONTRA CERRADURA DE CENTRO C/ TOPE CRO	',0.00,0,0,0.00,0,'C',20,'Herrajes'),
('1531D','CONTRA CERRADURA DE CENTRO C/ TOPE	',0.00,0,0,0.00,0,'D',20,'Herrajes'),
('1531O','CONTRA CERRADURA CENTRO CON TOPE ORO',0.00,0,0,0.00,20140,'G',10,'Herrajes'),
('1570B','FECHO V.V. BRONCE',0.00,0,0,0.00,0,'B',20,'Herrajes'),
('1570C','FECHO V. V. CROMADO	',0.00,0,0,0.00,0,'C',20,'Herrajes'),
('1570GRB','FECHO V/V GRANDE BCE',0.00,0,0,0.00,33264,'G',10,'Herrajes'),
('1571B','FECHO V.P. BRONCE	',0.00,0,0,0.00,0,'B',20,'Herrajes'),
('1571C','FECHO V. P. CROMADO	',0.00,0,0,0.00,0,'C',20,'Herrajes'),
('1571GRB','FECHO V/P GRANDE BCE',0.00,0,0,0.00,15120,'G',10,'Herrajes'),
('1607M','MANIJON DE MADERA MOGNO',0.00,0,0,0.00,0,'D',20,'Herrajes'),
('1609','MANIJON ACRILICO	',0.00,0,0,0.00,0,'D',20,'Herrajes'),
('1629BC','TIRADOR DOBLE CROMADO	',0.00,0,0,0.00,0,'C',20,'Herrajes'),
('1629BD','TIRADOR DOBLE DORADO	',0.00,0,0,0.00,0,'D',20,'Herrajes'),
('1629JC','TIRADOR SIMPLE CROMADO	',0.00,0,0,0.00,0,'C',20,'Herrajes'),
('1629JD','TIRADOR SIMPLE DORADO	',0.00,0,0,0.00,0,'D',20,'Herrajes'),
('1629JF','TIRADOR SIMPLE FOSCO	',0.00,0,0,0.00,0,'D',20,'Herrajes'),
('1629JO','TIRADOR SIMPLE ORO	',0.00,0,0,0.00,0,'O',20,'Herrajes'),
('1800AD','PASADOR POSTIZO LATERAL DORADO	',0.00,0,0,0.00,0,'D',20,'Herrajes'),
('1800C','PASADOR POSTIZO P/ BATIENTE CROMADO	',0.00,0,0,0.00,0,'C',20,'Herrajes'),
('1800CR','PASADOR POSTIZO CROMADO',0.00,0,0,0.00,0,'C',10,'Herrajes'),
('1800D','PASADOR POSTIZO P/ BATIENTE DORADO	',0.00,0,0,0.00,0,'D',20,'Herrajes'),
('1801A','CONTRA PASADOR CHAPITA DORADO	',0.00,0,0,0.00,0,'D',20,'Herrajes'),
('1801AC','CONTRA PASADOR CHAPITA CROMADO	',0.00,0,0,0.00,0,'C',20,'Herrajes'),
('1801AO','CONTRA PASADOR CHAPITA ORO',0.00,0,0,0.00,0,'O',10,'Herrajes'),
('1913','NUCLEO PARA ZOCALO INFERIOR',0.00,0,0,0.00,0,'D',10,'Herrajes'),
('1921C','BISAGRA P/ PROYECTANTE V/P CROMADO	',0.00,0,0,0.00,0,'C',20,'Herrajes'),
('1921D','BISAGRA P/ PROYECTANTE V/P BRONCE	',0.00,0,0,0.00,0,'D',20,'Herrajes'),
('1921O','BISAGRA PARA PROYECTANTE V/P ORO',0.00,0,0,0.00,0,'O',10,'Herrajes'),
('3230C','ESPEJO CERRADURA CORRER CROMADO	',0.00,0,0,0.00,0,'C',20,'Herrajes'),
('3230D','ESPEJO CERRADURA CORRER	DORADO',0.00,0,0,0.00,0,'D',20,'Herrajes'),
('3230MC','MINI ESPEJO DE CORRER CROMADO',0.00,0,0,0.00,0,'G',10,'Herrajes'),
('3230O','ESPEJO DE CORRER ORO',0.00,0,0,0.00,8044,'G',10,'Herrajes'),
('3530C','CERRADURA P/ PUERTA DE CORRER CROMADO	',0.00,0,0,0.00,0,'C',20,'Herrajes'),
('3530D','CERRADURA P/ PUERTA DE CORRER DORADO	',0.00,0,0,0.00,0,'D',20,'Herrajes'),
('3530F','CERRADURA DE CORRER PUERTA FOSCO',0.00,0,0,0.00,78422,'G',10,'Herrajes'),
('3530O','CERRADURA DE CORRER PUERTA ORO',0.00,0,0,0.00,50400,'G',10,'Herrajes'),
('3532C','CERRADURA P/ VENTANA DE CORRER CROMADO	',0.00,0,0,0.00,0,'C',20,'Herrajes'),
('3532D','CERRADURA P/ VENTANA DE CORRER DORADO	',0.00,0,0,0.00,0,'D',20,'Herrajes'),
('3532F','CERRADURA DE CORRER VENTANA FOSCO',0.00,0,0,0.00,0,'F',10,'Herrajes'),
('3532MC','MINI CERRADURA DE CORRER VENTANA CROMADO',0.00,0,0,0.00,0,'G',10,'Herrajes'),
('3532MO','MINI CERRADURA DE CORRER VENTANA ORO',0.00,0,0,0.00,0,'G',10,'Herrajes'),
('3532O','CERRADURA DE CORRER VENTANA ORO',0.00,0,0,0.00,50198,'G',10,'Herrajes'),
('3534C','CONTRA CERRADURA P/ PUERTA DE CORRER CROMADO	',0.00,0,0,0.00,0,'C',20,'Herrajes'),
('3534D','CONTRA CERRADURA P/ PUERTA DE CORRER DORADO	',0.00,0,0,0.00,0,'D',20,'Herrajes'),
('3534F','CONTRA CERRADURA DE CORRER PUERTA FOSCO',0.00,0,0,0.00,49715,'G',10,'Herrajes'),
('3534O','CONTRA CERRADURA DE CORRER PUERTA ORO',0.00,0,0,0.00,28204,'G',10,'Herrajes'),
('3536C','CONTRA CERRADURA P/ VENTANA DE CORRER CROMADO	',0.00,0,0,0.00,0,'C',20,'Herrajes'),
('3536D','CONTRA CERRADURA P/ VENTANA DE CORRER DORADO	',0.00,0,0,0.00,0,'D',20,'Herrajes'),
('3536F','CONTRA CERRADURA DE CORRER VENTANA FOSCO',0.00,0,0,0.00,49715,'G',10,'Herrajes'),
('3536MC','MINI CONTRA CERRADURA DE CORRER VENTANA CROMADO',0.00,0,0,0.00,0,'G',10,'Herrajes'),
('3536MO','MINI CONTRA CERRADURA DE CORRER VENTANA ORO',0.00,0,0,0.00,0,'G',10,'Herrajes'),
('3536O','CONTRA CERRADURA DE CORRER VENTANA ORO',0.00,0,0,0.00,26006,'G',10,'Herrajes'),
('BCC100C','MANIJON DE 1MT CROMADO',0.00,0,0,0.00,0,'C',10,'Herrajes'),
('BCC42C','MANIJON DE 1 PERFORACION CROMADO',0.00,0,0,0.00,0,'C',10,'Herrajes'),
('BCC60C','MANIJON DE 60CM CROMADO',0.00,0,0,0.00,0,'C',10,'Herrajes'),
('BG-001','PORTA VIDRIO L25 BRONCE',0.00,0,0,0.00,0,'B',10,'Herrajes'),
('BTS-75','FRENO DE PISO DORMA BTS-75	',0.00,0,0,0.00,0,'D',20,'Herrajes'),
('BTS-75V','EJE BTS DORMA	',0.00,0,0,0.00,0,'D',20,'Herrajes'),
('BX-068','TAPA GUIA INFERIOR 8MM BRONCE',0.00,0,0,0.00,0,'B',20,'Perfiles'),
('BX-068F','TAPA GUIA INFERIOR 8MM FOSCO',0.00,0,0,0.00,0,'F',20,'Perfiles'),
('BX-068V','TAPA GUIA INFERIOR LEVE BRONCE',0.00,0,0,0.00,0,'B',0,'Perfiles'),
('BX-084','GUIA SUPERIOR P/BOX BRONCE',0.00,0,0,0.00,0,'B',10,'Perfiles'),
('BX-1005','GUIA INFERIOR 8MM BRONCE',0.00,0,0,0.00,0,'F',20,'Perfiles'),
('BX-1005F','GUIA INFERIOR 8MM FOSCO',0.00,0,0,0.00,0,'F',20,'Perfiles'),
('BX-1005V','GUIA INFERIOR LEVE BRONCE',0.00,0,0,0.00,0,'B',0,'Perfiles'),
('BX-1005VF','GUIA INFERIOR LEVE FOSCO',0.00,0,0,0.00,0,'F',0,'Perfiles'),
('BX-1011','GUIA SUPERIOR 8MM BRONCE',0.00,0,0,0.00,0,'B',20,'Perfiles'),
('BX-1011F','GUIA SUPERIOR 8MM FOSCO',0.00,0,0,0.00,0,'F',20,'Perfiles'),
('BX-1011V','GUIA SUPERIOR LEVE BRONCE',0.00,0,0,0.00,0,'B',10,'Perfiles'),
('BX-1011VF','GUIA SUPERIOR LEVE FOSCO',0.00,0,0,0.00,0,'F',0,'Perfiles'),
('BX-1012','TAPA GUIA SUPERIOR 8MM BRONCE',0.00,0,0,0.00,0,'B',20,'Perfiles'),
('BX-1012F','TAPA GUIA SUPERIOR 8MM FOSCO',0.00,0,0,0.00,0,'B',20,'Perfiles'),
('BX-1012V','TAPA SUPERIOR LEVE BRONCE',0.00,0,0,0.00,0,'B',0,'Perfiles'),
('BX-1012VF','TAPA GUIA SUPERIOR LEVE FOSCO',0.00,0,0,0.00,0,'F',0,'Perfiles'),
('BX-206','GUIA INFERIOR 10MM BRONCE',0.00,0,0,0.00,0,'B',20,'Perfiles'),
('BX-206F','GUIA INFERIOR 10MM FOSCO',0.00,0,0,0.00,0,'F',20,'Perfiles'),
('BX-239F','GUIA SUPERIOR PESADO FOSCO',0.00,0,0,0.00,0,'F',10,'Perfiles'),
('BX-239P ','GUIA SUPERIOR PULIDO',0.00,0,0,0.00,0,'N',10,'Perfiles'),
('BX-246','VEDACION LATERAL 8MM BRONCE',0.00,0,0,0.00,0,'B',20,'Perfiles'),
('BX-246VP','VEDACION LATERAL 8MM PINTADO',0.00,0,0,0.00,0,'P',0,'Perfiles'),
('BX-257','GUIA SUPERIOR 10MM BRONCE',0.00,0,0,0.00,0,'B',20,'Perfiles'),
('BX-257F','GUIA SUPERIOR 10MM FOSCO',0.00,0,0,0.00,0,'F',20,'Perfiles'),
('BX-258','TAPA SUPERIOR 10MM BRONCE',0.00,0,0,0.00,0,'B',20,'Perfiles'),
('BX-258F','TAPA SUPERIOR 10MM FOSCO',0.00,0,0,0.00,0,'F',20,'Perfiles'),
('BX-261','VEDACION LATERAL 10MM BRONCE',0.00,0,0,0.00,0,'B',20,'Perfiles'),
('BX-261F','VEDACION LATERAL 10MM FOSCO',0.00,0,0,0.00,0,'F',20,'Perfiles'),
('BX-500','TAPA GUIA SUPERIOR P/BOX BRONCE',0.00,0,0,0.00,0,'B',10,'Perfiles'),
('C30C','MANIJON C 30 CM CROMADO	',0.00,0,0,0.00,0,'C',20,'Herrajes'),
('C45C','MANIJON DE 45CM CROMADO',0.00,0,0,0.00,0,'C',10,'Herrajes'),
('CEID','CERRADURA ELECTRICA IZQ DORADO',0.00,0,0,0.00,0,'D',10,'Herrajes'),
('CG-171F','SOPORTE PARA VIDRIO FOSCO',405.00,0,0,0.00,0,'F',10,'Perfiles'),
('CG-179F','PASAMANO PARA GRADIL FOSCO',1214.00,0,0,0.00,0,'F',10,'Perfiles'),
('CG-182F','PARANTE PARA PASAMANO FOSCO',1214.00,0,0,0.00,0,'F',10,'Perfiles'),
('CL-022','TAPA GUIA INFERIOR 10MM BRONCE',0.00,0,0,0.00,0,'B',20,'Perfiles'),
('CL-022F','TAPA GUIA INFERIOR PESADO FOSCO',8.00,0,0,0.00,0,'F',10,'Perfiles'),
('CT-013','ANGULO 25X25 BRONCE',0.00,0,0,0.00,0,'B',20,'Perfiles'),
('CT-013F','ANGULO 25X25 FOSCO',0.00,0,0,0.00,0,'F',20,'Perfiles'),
('CT-015','ANGULO 25 X 25',0.00,0,0,0.00,0,'B',10,'Perfiles'),
('CT-015F','ANGULO 25 X 25 FOSCO',0.00,0,0,0.00,0,'B',10,'Perfiles'),
('CT-085','ANGULO 20X20 BRONCE',0.00,0,0,0.00,0,'B',20,'Perfiles'),
('CT-085F','ANGULO 20X20 FOSCO',0.00,0,0,0.00,0,'F',20,'Perfiles'),
('DC-006','PARASOL BRONCE',0.00,0,0,0.00,185000,'B',0,'Perfiles'),
('DGSI','CONTRA CERRADURA DORMA',0.00,0,0,0.00,0,'D',10,'Herrajes'),
('EMF0185F','TUBO 40X40 1.4 MM FOSCO ',1.40,0,0,0.00,0,'F',20,'Perfiles'),
('EMF0203F','TUBO 50X25 1.00MM FOSCO',0.00,0,0,0.00,0,'F',10,'Perfiles'),
('EMF0254','TUBO 100X50 1.5 MM',1.50,0,0,0.00,0,'B',20,'Perfiles'),
('EMF2074','ANGULO CIELORRASO',0.00,0,0,0.00,0,'B',10,'Perfiles'),
('EMF2074F','ANGULO CIELORRASO FOSCO',0.00,0,0,0.00,0,'F',10,'Perfiles'),
('EMF2123','TUBO 100X50 BRONCE',0.00,0,0,0.00,0,'B',10,'Perfiles'),
('EMF2252','PERFIL T',0.00,0,0,0.00,0,'B',10,'Perfiles'),
('EMF2252F','PERFIL T FOSCO',0.00,0,0,0.00,0,'F',10,'Perfiles'),
('EMF3016','TUBO 50X50 1.5MM',1.50,0,0,0.00,0,'B',20,'Perfiles'),
('EMF3016F','TUBO 50X50 1.5 MM FOSCO ',1.50,0,0,0.00,0,'F',20,'Perfiles'),
('EMF3016N','TUBO 50X50 NATURAL CHINO',0.00,0,0,0.00,0,'B',10,'Perfiles'),
('EMF3016P','TUBO 50X50 PINTADO',0.00,0,0,0.00,0,'B',10,'Perfiles'),
('EMF3127','TUBO 80X40 1.4 MM',1.50,0,0,0.00,0,'B',20,'Perfiles'),
('EMF3127F','TUBO 80X40 1.4 MM FOSCO ',1.40,0,0,0.00,0,'F',20,'Perfiles'),
('EMF3129','PERFIL U 25',10.00,0,0,0.00,0,'B',20,'Perfiles'),
('EMF3129F','PERFIL U 25 FOSCO ',10.00,0,0,0.00,0,'F',20,'Perfiles'),
('EMF3129N','PERFIL U 25 NATURAL',0.00,0,0,0.00,0,'N',10,'Perfiles'),
('EMF3189','PERFIL P/OREJA MURO CORTINA BRONCE',0.00,0,0,0.00,0,'B',20,'Perfiles'),
('EMF3189F','PERFIL P/OREJA MURO CORTINA FOSCO',0.00,0,0,0.00,0,'F',10,'Perfiles'),
('EMF3190','TUBO MURO CORTINA BRONCE',0.00,0,0,0.00,0,'B',20,'Perfiles'),
('EMF3190F','TUBO MURO CORTINA FOSCO',0.00,0,0,0.00,0,'F',20,'Perfiles'),
('EMF7023','GUIA SUPERIOR 10MM',10.00,0,0,0.00,0,'B',10,'Perfiles'),
('EMF7023F','GUIA SUPERIOR 10MM',10.00,0,0,0.00,0,'F',10,'Perfiles'),
('EMF7023N','GUIA SUPERIOR 10MM NATURAL',10.00,0,0,0.00,0,'F',10,'Perfiles'),
('EMF7024','TAPA GUIA SUPERIOR 10MM',10.00,0,0,0.00,0,'B',10,'Perfiles'),
('EMF7024F','TAPA GUIA SUPERIOR 10MM',10.00,0,0,0.00,0,'F',10,'Perfiles'),
('EMF7024N','TAPA GUIA SUPERIOR 10MM NATURAL',10.00,0,0,0.00,0,'N',10,'Perfiles'),
('EMF7025','PERFIL U 20 ',8.00,0,0,0.00,0,'B',20,'Perfiles'),
('EMF7025F','PERFIL U 20 FOSCO ',8.00,0,0,0.00,0,'F',20,'Perfiles'),
('EMF7025N','PERFIL U 20 NATURAL',8.00,0,0,0.00,0,'N',10,'Perfiles'),
('EMF7025P','PERFIL U20 PINTADO',8.00,0,0,0.00,0,'N',10,'Perfiles'),
('EMF7026','VEDACION ENCUENTRO 10MM',10.00,0,0,0.00,0,'B',10,'Perfiles'),
('EMF7026F','VEDACION ENCUENTRO 10MM',10.00,0,0,0.00,0,'F',10,'Perfiles'),
('EMF7026N','VEDACION ENCUENTRO 10MM NATURAL',10.00,0,0,0.00,0,'N',10,'Perfiles'),
('EMF7026P','VEDAC. ENCUENTRO 10MM PINTADO',10.00,0,0,0.00,0,'P',10,'Perfiles'),
('EMF7027','VEDACION LATERAL ',8.00,0,0,0.00,0,'B',20,'Perfiles'),
('EMF7027F','VEDACION LAT. 08 MM FOSCO ',8.00,0,0,0.00,0,'F',20,'Perfiles'),
('EMF7027N','VEDACION LATERAL 08MM NATURAL',8.00,0,0,0.00,0,'N',10,'Perfiles'),
('EMF7028','TAPAGUIA INFERIOR 10MM',10.00,0,0,0.00,0,'B',10,'Perfiles'),
('EMF7028N','TAPA GUIA INFERIOR 10MM NATURAL',10.00,0,0,0.00,0,'N',10,'Perfiles'),
('EMF7029','GUIA INFERIOR 08 MM',8.00,0,0,0.00,0,'B',20,'Perfiles'),
('EMF7029F','GUIA INFERIOR 08 MM FOSCO',8.00,0,0,0.00,0,'F',20,'Perfiles'),
('EMF7029N','GUIA INFERIOR 08MM NATURAL',8.00,0,0,0.00,0,'N',10,'Perfiles'),
('EMF7029P','GUIA INFERIOR PINTADO',8.00,0,0,0.00,0,'P',10,'Perfiles'),
('EMF7038','TAPA GUIA SUP.08 MM',8.00,0,0,0.00,0,'B',20,'Perfiles'),
('EMF7038F','TAPA GUIA SUP.08 MM FOSCO ',8.00,0,0,0.00,0,'F',20,'Perfiles'),
('EMF7038N','TAPA GUIA SUPERIOR 08MM NATURAL',8.00,0,0,0.00,0,'N',10,'Perfiles'),
('EMF7038P','TAPA GUIA SUPERIOR 08 PINTADO',8.00,0,0,0.00,0,'P',10,'Perfiles'),
('EMF7039','GUIA INFERIOR 10MM',10.00,0,0,0.00,0,'B',10,'Perfiles'),
('EMF7039F','GUIA INFERIOR 10MM',10.00,0,0,0.00,0,'F',10,'Perfiles'),
('EMF7039N','GUIA INFERIOR 10MM NATURAL',10.00,0,0,0.00,0,'N',10,'Perfiles'),
('EMF7040','VEDACION LATERAL 10MM',10.00,0,0,0.00,0,'F',10,'Perfiles'),
('EMF7040F','VEDACION LATERAL 10MM',10.00,0,0,0.00,0,'F',10,'Perfiles'),
('EMF7040N','VEDACION LATERAL 10MM NATURAL',10.00,0,0,0.00,0,'N',10,'Perfiles'),
('EMF7041','VEDACION ENCUENTRO ',8.00,0,0,0.00,0,'B',20,'Perfiles'),
('EMF7041F','VEDACION ENCUENTRO FOSCO',8.00,0,0,0.00,0,'F',20,'Perfiles'),
('EMF7041P','VEDACION ENCUENTRO 8MM BRONCE PESADO',0.00,0,0,0.00,0,'B',10,'Perfiles'),
('EMF7042','TAPA GUIA INFERIOR 08 MM',8.00,0,0,0.00,0,'B',20,'Perfiles'),
('EMF7042F','TAPA GUIA INFERIOR FOSCO ',8.00,0,0,0.00,0,'F',20,'Perfiles'),
('EMF7042N','TAPA GUIA INFERIOR 08MM NATURAL',8.00,0,0,0.00,0,'N',10,'Perfiles'),
('EMF7042P','TAPA GUIA INFERIOR 08MM PINTADO',8.00,0,0,0.00,0,'P',10,'Perfiles'),
('EMF7043','GUIA SUPERIOR 08MM',8.00,0,0,0.00,0,'B',20,'Perfiles'),
('EMF7043F','GUIA SUPERIOR 08 MM FOSCO',8.00,0,0,0.00,0,'F',20,'Perfiles'),
('EMF7043N','GUIA SUPERIOR 08MM NATURAL',8.00,0,0,0.00,0,'N',10,'Perfiles'),
('EMF7043P','GUIA SUPERIOR 08 PINTADO',8.00,0,0,0.00,0,'P',10,'Perfiles'),
('FC-007','TUBO MURO CORTINA',0.00,0,0,0.00,0,'B',20,'Perfiles'),
('FC-007F','TUBO MURO CORTINA FOSCO',0.00,0,0,0.00,0,'F',20,'Perfiles'),
('FC-419','PRESCILLA PARA MURO CORTINA BRONCE',0.00,0,0,0.00,0,'B',20,'Perfiles'),
('FC-419F','PRESCILLA MURO CORTINA FOSCO',0.00,0,0,0.00,0,'F',20,'Perfiles'),
('FC-544','TAPA P/MURO CORTINA BRONCE',0.00,0,0,0.00,0,'B',20,'Perfiles'),
('FC-544F','TAPA P/MURO CORTINA FOSCO',0.00,0,0,0.00,0,'F',20,'Perfiles'),
('FEBRVP','FESHO BRASIL V/P	',0.00,0,0,0.00,0,'D',20,'Herrajes'),
('FEBRVV','FESHO BRASIL V/V	',0.00,0,0,0.00,0,'D',20,'Herrajes'),
('FELPA5X5','FELPA 5X5	',0.00,0,0,0.00,0,'D',20,'Herrajes'),
('FELPA5X7','FELPA 5X7	',0.00,0,0,0.00,0,'D',20,'Herrajes'),
('FELPA5X8','FELPA 5X8	',0.00,0,0,0.00,0,'D',20,'Herrajes'),
('FELPA7X5','FELPA 7X5	',0.00,0,0,0.00,0,'D',20,'Herrajes'),
('FREGDS','FRENO CHICO GDS',0.00,0,0,0.00,0,'O',10,'Herrajes'),
('H30B','MANIJON H BRONCE',0.00,0,0,0.00,0,'B',10,'Herrajes'),
('H30C','MANIJON DE 30CM CROMADO',0.00,0,0,0.00,0,'C',10,'Herrajes'),
('H30D','MANIJON H DE 30 CM DORADO',0.00,0,0,0.00,0,'D',10,'Herrajes'),
('H30RB','MANIJON H RECTO DE 30CM BRONCE',0.00,0,0,0.00,0,'B',10,'Herrajes'),
('HDL-84TC','FRENO DE PISO HDL 84T CROMADO',0.00,0,0,0.00,0,'C',20,'Herrajes'),
('HDL-84TD','FRENO DE PISO HDL 84T DORADO	',0.00,0,0,0.00,0,'D',20,'Herrajes'),
('HVA25B','BRAZO P/ PROYECTANTE DE 25CM BRONCE	',0.00,0,0,0.00,0,'B',20,'Herrajes'),
('HVA25C','BRAZO P/ PROYECTANTE DE 25CM CROMADO	',0.00,0,0,0.00,0,'C',20,'Herrajes'),
('HVA25O','BRAZO P/PROYECTANTE DE 25CM ORO',0.00,0,0,0.00,0,'O',10,'Herrajes'),
('HVA30B','BRAZO P/ PROYECTANTE DE 30CM BRONCE',0.00,0,0,0.00,0,'B',20,'Herrajes'),
('HVA30C','BRAZO P/ PROYECTANTE DE 30CM CROMADO	',0.00,0,0,0.00,0,'C',20,'Herrajes'),
('HVA35','BRAZO P/ PROYECTANTE DE 35CM	',0.00,0,0,0.00,0,'D',20,'Herrajes'),
('HVA45','BRAZO P/ PROYECTANTE DE 45CM BRONCE	',0.00,0,0,0.00,0,'B',20,'Herrajes'),
('HVA45C','BRAZO P/ PROYECTANTE DE 45CM CROMADO',0.00,0,0,0.00,0,'C',20,'Herrajes'),
('IN-003','MARCO LATERAL PARA 2 HOJAS BRONCE',546.00,0,0,0.00,0,'B',10,'Perfiles'),
('IN-003F','MARCO LATERAL PARA 2 HOJAS FOSCO',546.00,0,0,0.00,0,'F',10,'Perfiles'),
('IN-004','HOJA DE CORRER SUPERIOR BRONCE',47.00,0,0,0.00,0,'B',10,'Perfiles'),
('IN-004F','HOJA DE CORRER SUPERIOR FOSCO',47.00,0,0,0.00,0,'F',10,'Perfiles'),
('IN-005','HOJA DE CORRER INFERIOR BRONCE',929.00,0,0,0.00,0,'B',10,'Perfiles'),
('IN-005F','HOJA DE CORRER INFERIOR FOSCO',929.00,0,0,0.00,0,'F',10,'Perfiles'),
('IN-006','HOJA LATERAL BRONCE',458.00,0,0,0.00,0,'B',10,'Perfiles'),
('IN-006F','HOJA LATERAL FOSCO',458.00,0,0,0.00,0,'F',10,'Perfiles'),
('IN-007','HOJA ENGANCHE EXTERNO BRONCE',44.00,0,0,0.00,0,'B',10,'Perfiles'),
('IN-007F','HOJA ENGANCHE EXTERNO FOSCO',44.00,0,0,0.00,0,'F',10,'Perfiles'),
('IN-008','HOJA ENGANCHE INTERNO BRONCE',423.00,0,0,0.00,0,'B',10,'Perfiles'),
('IN-008F','HOJA ENGANCHE INTERNO FOSCO',423.00,0,0,0.00,0,'F',10,'Perfiles'),
('IN-009','ENGANCHE PARA PUERTA BRONCE',1018.00,0,0,0.00,0,'B',10,'Perfiles'),
('IN-009F','ENGANCHE PARA PUERTA FOSCO',1018.00,0,0,0.00,0,'F',10,'Perfiles'),
('IN-010','ENGANCHE INTERNO PARA PUERTA BRONCE',1014.00,0,0,0.00,0,'B',10,'Perfiles'),
('IN-010F','ENGANCHE INTERNO PARA PUERTA FOSCO',1014.00,0,0,0.00,0,'F',10,'Perfiles'),
('IN-011','ENGANCHE INTERNO REFORZADO',635.00,0,0,0.00,0,'B',10,'Perfiles'),
('IN-011F','ENGANCHE INTERNO REFORZADO FOSCO',635.00,0,0,0.00,0,'F',10,'Perfiles'),
('IN-012','GUIA SUPERIOR DE 2 HOJAS BRONCE',713.00,0,0,0.00,0,'B',10,'Perfiles'),
('IN-012F','GUIA SUPERIOR DE 2 HOJAS FOSCO',713.00,0,0,0.00,0,'F',10,'Perfiles'),
('IN-013','GUIA INFERIOR DE 2 HOJAS BRONCE',742.00,0,0,0.00,0,'B',10,'Perfiles'),
('IN-013F','GUIA INFERIOR DE 2 HOJAS FOSCO',742.00,0,0,0.00,0,'F',10,'Perfiles'),
('IN-015','DIVISOR DE HOJA BRONCE',503.00,0,0,0.00,0,'B',10,'Perfiles'),
('IN-015F','DIVISOR DE HOJA FOSCO',503.00,0,0,0.00,0,'F',10,'Perfiles'),
('IN-017','CONTRAVIDRIO HORIZONTAL BRONCE',138.00,0,0,0.00,0,'B',10,'Perfiles'),
('IN-017F','CONTRAVIDRIO HORIZONTAL FOSCO',138.00,0,0,0.00,0,'F',10,'Perfiles'),
('IN-018','CONTRAVIDRIO VERTICAL BRONCE',134.00,0,0,0.00,0,'B',10,'Perfiles'),
('IN-018F','CONTRAVIDRIO VERTICAL FOSCO',134.00,0,0,0.00,0,'F',10,'Perfiles'),
('IN-043','LATERAL LISO BRONCE',408.00,0,0,0.00,0,'B',10,'Perfiles'),
('IN-043F','LATERAL LISO FOSCO',408.00,0,0,0.00,0,'F',10,'Perfiles'),
('IN-045','GUIA SUPERIOR DE 2 HOJAS REFORZADO BRONCE',1022.00,0,0,0.00,0,'B',10,'Perfiles'),
('IN-045F','GUIA SUPERIOR DE 2 HOJAS REFORZADO FOSCO',1022.00,0,0,0.00,0,'F',10,'Perfiles'),
('IN-046','GUIA INFERIOR DE 2 HOJAS REFORZADO BRONCE',1086.00,0,0,0.00,0,'B',10,'Perfiles'),
('IN-046F','GUIA INFERIOR DE 2 HOJAS REFORZADO FOSCO',1086.00,0,0,0.00,0,'F',10,'Perfiles'),
('IN-047','GUIA INFERIOR DE 2 HOJAS PARA PUERTA BRONCE',67.00,0,0,0.00,0,'B',10,'Perfiles'),
('IN-047F','GUIA INFERIOR DE 2 HOJAS PARA PUERTA FOSCO',67.00,0,0,0.00,0,'F',10,'Perfiles'),
('IN-056','MARCO PARA PROYECTANTE BRONCE',349.00,0,0,0.00,0,'B',10,'Perfiles'),
('IN-056F','MARCO PARA PROYECTANTE FOSCO',349.00,0,0,0.00,0,'F',10,'Perfiles'),
('IN-058','HOJA SUPERIOR PARA PROYECTANTE BRONCE',37.00,0,0,0.00,0,'B',10,'Perfiles'),
('IN-058F','HOJA SUPERIOR PARA PROYECTANTE FOSCO',37.00,0,0,0.00,0,'F',10,'Perfiles'),
('IN-061','HOJA INFERIOR Y LATERAL PARA PROYECTANTE BRONCE',449.00,0,0,0.00,0,'B',10,'Perfiles'),
('IN-061F','HOJA INFERIOR Y LATERAL PARA PROYECTANTE FOSCO',449.00,0,0,0.00,0,'F',10,'Perfiles'),
('KITBC','KIT BASCULANTE CROMADO',0.00,0,0,0.00,0,'C',10,'Herrajes'),
('KITBD','KIT BASCULANTE DORADO',0.00,0,0,0.00,0,'D',10,'Herrajes'),
('LCT-005','ANGULO 15 X 15 BRONCE',0.00,0,0,0.00,0,'B',10,'Perfiles'),
('LCT-005F','ANGULO 15 X 15 FOSCO',0.00,0,0,0.00,0,'B',10,'Perfiles'),
('LCT-015F','ANGULO 25 X 25 FOSCO',0.00,0,0,0.00,0,'F',10,'Perfiles'),
('MF00134F','TUBO CIRCULAR 50X50 1.5MM FOSCO',0.00,0,0,0.00,0,'F',10,'Perfiles'),
('MF00150F','TUBO CIRCULAR 90X6MM FOSCO',0.00,0,0,0.00,0,'F',10,'Perfiles'),
('MF00232F','TUBO CIRCULAR 160X5MM',0.00,0,0,0.00,0,'F',10,'Perfiles'),
('MF0106A','TUBO 50X50 (2,0MM)',20.00,0,0,0.00,0,'B',10,'Perfiles'),
('MF0106AF','TUBO 50X50 (2,0MM) FOSCO',20.00,0,0,0.00,0,'F',10,'Perfiles'),
('MF0185','TUBO 40X40 1.4MM',1.40,0,0,0.00,0,'B',20,'Perfiles'),
('MF0185FI','TUBO 38X38 BRONCE',0.00,0,0,0.00,0,'B',10,'Perfiles'),
('MF0203','TUBO 25X50 BRONCE',0.00,0,0,0.00,0,'B',10,'Perfiles'),
('MF02123F','TUBO 100X50 02MM FOSCO',2.00,0,0,0.00,0,'F',1,'Perfiles'),
('MF02165','TUBO 40X20 BRONCE',14.00,0,0,0.00,0,'B',20,'Perfiles'),
('MF02165F','TUBO 40X20 1.4MM FOSCO',14.00,0,0,0.00,0,'F',10,'Perfiles'),
('MF0254F','TUBO 100X50X1.5 FOSCO ',1.50,0,0,0.00,0,'F',20,'Perfiles'),
('MF0254N','TUBO 100X50 NATURAL CHINO',0.00,0,0,0.00,0,'N',10,'Perfiles'),
('MF0254P','TUBO 100X50 PINTADO',0.00,0,0,0.00,0,'P',10,'Perfiles'),
('OREJAB','OREJA MURO CORTINA BRONCE',0.00,0,0,0.00,0,'B',10,'Herrajes'),
('OREJAF','OREJA MURO CORTINA FOSCO',0.00,0,0,0.00,0,'F',10,'Herrajes'),
('PU-329F','PERFIL U25 FOSCO',2.00,0,0,0.00,0,'F',1,'Perfiles'),
('PU-344','PERFIL U25 BRONCE',0.00,0,0,0.00,0,'B',20,'Perfiles'),
('PU-344F','PERFIL U25 FOSCO',0.00,0,0,0.00,0,'F',20,'Perfiles'),
('PU-350','PERFIL U20 BRONCE',0.00,0,0,0.00,0,'F',20,'Perfiles'),
('PU-350F','PERFIL U20 FOSCO',0.00,0,0,0.00,0,'F',20,'Perfiles'),
('S30B','MANIJON S DE 30CM BRONCE',0.00,0,0,0.00,0,'B',10,'Herrajes'),
('S30C','MANIJON S DE 30CM CROMADO',0.00,0,0,0.00,0,'C',10,'Herrajes'),
('SI-501','TUBO MURO CORTINA BRONCE',0.00,0,0,0.00,0,'B',10,'Perfiles'),
('SIL2193','SILICONA INCOLORO DEN BRAVEN',0.00,0,0,0.00,12500,'I',1,'Herrajes'),
('SIL784','SILICONA INCOLORO',0.00,0,0,0.00,0,'I',10,'Herrajes'),
('SL768I','SILICONA NEUTRA',0.00,0,0,0.00,0,'I',10,'Herrajes'),
('SL784BL','SILICONA BLANCA',0.00,0,0,0.00,15300,'N',10,'Herrajes'),
('SL999A','SILICONA BRONCE',0.00,0,0,0.00,0,'B',10,'Herrajes'),
('SLCPS','SILICONA GRIS NEUTRO',0.00,0,0,0.00,0,'G',10,'Herrajes'),
('SLG','SILICONA GRIS ALUMINIO',0.00,0,0,0.00,0,'G',10,'Herrajes'),
('TG-110','TUBO 25X50 BRONCE',0.00,0,0,0.00,0,'B',20,'Perfiles'),
('TG-110F','TUBO 25X50 FOSCO',0.00,0,0,0.00,0,'F',20,'Perfiles'),
('TG-112','TUBO 80X40 BRONCE',0.00,0,0,0.00,0,'B',20,'Perfiles'),
('TG072','TUBO 100 X 50 BRONCE',0.00,0,0,0.00,0,'I',10,'Perfiles'),
('TG112F','TUBO 80X40 FOSCO',0.00,0,0,0.00,0,'F',20,'Perfiles'),
('TQ-017','TUBO 50 X 50 BRONCE',0.00,0,0,0.00,0,'B',10,'Perfiles'),
('TQ089','TUBO 50X50 BRONCE',0.00,0,0,0.00,0,'B',20,'Perfiles'),
('TQ089F','TUBO 50X50 FOSCO',0.00,0,0,0.00,0,'F',20,'Perfiles'),
('UE-596F','TUBO 100X50 1.5MM FOSCO',0.00,0,0,0.00,0,'F',20,'Perfiles');

/*Table structure for table `stproveedor` */

DROP TABLE IF EXISTS `stproveedor`;

CREATE TABLE `stproveedor` (
  `provCodigo` int(11) NOT NULL AUTO_INCREMENT,
  `provDescripcion` varchar(25) NOT NULL,
  `provTelef` varchar(25) DEFAULT NULL,
  `provContacto` varchar(50) DEFAULT NULL,
  `provUsuario` varchar(25) DEFAULT NULL,
  `provFechaIns` datetime DEFAULT NULL,
  `provRuc` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`provCodigo`),
  UNIQUE KEY `RUC` (`provRuc`)
) ENGINE=InnoDB AUTO_INCREMENT=57 DEFAULT CHARSET=utf8;

/*Data for the table `stproveedor` */

insert  into `stproveedor`(`provCodigo`,`provDescripcion`,`provTelef`,`provContacto`,`provUsuario`,`provFechaIns`,`provRuc`) values 
(31,'VASA S.A.','789','lll',NULL,NULL,'800'),
(32,'JP FERRAGEMS','','',NULL,NULL,''),
(34,'Stock Inicial','','',NULL,NULL,'1'),
(40,'CHROM S.R.L','','',NULL,NULL,'33'),
(42,'ROSA','','',NULL,NULL,'35'),
(43,'VIDRIOCAR S.A.','','',NULL,NULL,'36'),
(44,'PERFIL AGIL','','',NULL,NULL,'37'),
(49,'FCA. CAPIATA','','',NULL,NULL,'2'),
(50,'DEP. SHOW ROOM','','',NULL,NULL,'3'),
(51,'MONTECRISTO IMPORT S.A','204740','',NULL,NULL,'80060511-0'),
(56,'samuel','0000','Sushi <3','samuel','2017-10-13 00:00:00','45000');

/*Table structure for table `strecibo` */

DROP TABLE IF EXISTS `strecibo`;

CREATE TABLE `strecibo` (
  `reciCod` int(11) NOT NULL AUTO_INCREMENT,
  `cajaCod` int(11) DEFAULT NULL,
  `reciFecha` date DEFAULT NULL,
  `reciFechaAnul` date DEFAULT NULL,
  `clieCod` int(11) DEFAULT NULL,
  `reciTotal` double DEFAULT NULL,
  `reciUsrIns` char(10) DEFAULT NULL,
  `reciFchIns` date DEFAULT NULL,
  `reciUsrUpd` char(10) DEFAULT NULL,
  `reciFchUpd` date DEFAULT NULL,
  `reciObs` varchar(50) DEFAULT NULL,
  `reciNro` varchar(25) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  `reciEstado` char(10) DEFAULT NULL,
  `ventasCod` double DEFAULT NULL,
  `reciFormaPago` varchar(8) DEFAULT NULL,
  `reciChequeNro` varchar(50) DEFAULT NULL,
  `reciBanco` varchar(15) DEFAULT NULL,
  `reciFechaCheque` date DEFAULT NULL,
  PRIMARY KEY (`reciCod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `strecibo` */

/*Table structure for table `strecibodet` */

DROP TABLE IF EXISTS `strecibodet`;

CREATE TABLE `strecibodet` (
  `reciCod` int(11) NOT NULL,
  `ventasCod` int(11) NOT NULL,
  `reciDetMonto` double DEFAULT NULL,
  PRIMARY KEY (`reciCod`,`ventasCod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `strecibodet` */

/*Table structure for table `stroturas` */

DROP TABLE IF EXISTS `stroturas`;

CREATE TABLE `stroturas` (
  `rotuCodigo` int(11) NOT NULL AUTO_INCREMENT,
  `rotuFecha` date DEFAULT NULL,
  `rotuCantidad` int(11) DEFAULT NULL,
  `prodCodigo` varchar(20) NOT NULL,
  `rotuOBS` varchar(200) DEFAULT NULL,
  `rotuUsrIns` char(15) DEFAULT NULL,
  `rotuFchIns` datetime DEFAULT NULL,
  PRIMARY KEY (`rotuCodigo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `stroturas` */

/*Table structure for table `sttipo` */

DROP TABLE IF EXISTS `sttipo`;

CREATE TABLE `sttipo` (
  `Nombre` varchar(15) DEFAULT NULL,
  `Codigo` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`Codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

/*Data for the table `sttipo` */

insert  into `sttipo`(`Nombre`,`Codigo`) values 
('Herrajes',1);

/*Table structure for table `stum` */

DROP TABLE IF EXISTS `stum`;

CREATE TABLE `stum` (
  `umCod` int(11) NOT NULL AUTO_INCREMENT,
  `umDesc` varchar(25) DEFAULT NULL,
  `umAbreviado` varchar(2) DEFAULT NULL,
  PRIMARY KEY (`umCod`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

/*Data for the table `stum` */

insert  into `stum`(`umCod`,`umDesc`,`umAbreviado`) values 
(1,'m2','m2');

/*Table structure for table `stvendedores` */

DROP TABLE IF EXISTS `stvendedores`;

CREATE TABLE `stvendedores` (
  `venCod` int(11) NOT NULL AUTO_INCREMENT,
  `venNombreApellido` varchar(50) DEFAULT NULL,
  `venPorcentaje` int(11) DEFAULT NULL,
  `venTelefono` varchar(25) DEFAULT NULL,
  `venEstado` varchar(8) DEFAULT NULL,
  PRIMARY KEY (`venCod`),
  UNIQUE KEY `unico` (`venNombreApellido`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

/*Data for the table `stvendedores` */

insert  into `stvendedores`(`venCod`,`venNombreApellido`,`venPorcentaje`,`venTelefono`,`venEstado`) values 
(1,'Graciela Calcena',1,'23','Activo'),
(2,'Yeruti Vazquez',1,NULL,NULL),
(3,'Magali Lopez',1,NULL,NULL),
(4,'Paola',1,'22','Activo'),
(5,'dsads',2,'3232','Inactivo');

/*Table structure for table `stventas` */

DROP TABLE IF EXISTS `stventas`;

CREATE TABLE `stventas` (
  `ventasCod` int(11) NOT NULL,
  `clieCod` int(11) NOT NULL,
  `ventasFechaFact` date NOT NULL,
  `ventasNroFactu` varchar(25) DEFAULT NULL,
  `ventasTipoFactura` varchar(8) DEFAULT NULL,
  `depoCod` int(11) NOT NULL,
  `venCod` int(11) NOT NULL,
  `ventasEstado` char(4) DEFAULT NULL,
  `ventasFechaAnul` date DEFAULT NULL,
  `ventasObs` varchar(50) DEFAULT NULL,
  `ventasSaldo` double DEFAULT NULL,
  `ventasReciNro` varchar(20) DEFAULT NULL,
  `ventasUsrIns` char(15) DEFAULT NULL,
  `ventasFchIns` date DEFAULT NULL,
  `ventasUsrUpd` char(15) DEFAULT NULL,
  `ventasFchUpd` date DEFAULT NULL,
  PRIMARY KEY (`ventasCod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `stventas` */

/*Table structure for table `stventasdet` */

DROP TABLE IF EXISTS `stventasdet`;

CREATE TABLE `stventasdet` (
  `ventasCod` int(11) NOT NULL,
  `ventasLineaNro` int(11) NOT NULL,
  `prodCodigo` varchar(20) NOT NULL,
  `impCod` int(11) NOT NULL,
  `umCod` int(11) NOT NULL,
  `ventasDetCantidad` int(11) NOT NULL,
  `ventasPrecioUnitario` double NOT NULL,
  `ventasImpExcenta` double DEFAULT NULL,
  `ventasImp5` double DEFAULT NULL,
  `ventasImp10` double DEFAULT NULL,
  PRIMARY KEY (`ventasCod`,`ventasLineaNro`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `stventasdet` */

/*Table structure for table `ultimacarga` */

DROP TABLE IF EXISTS `ultimacarga`;

CREATE TABLE `ultimacarga` (
  `fecha` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `ultimacarga` */

insert  into `ultimacarga`(`fecha`) values 
('2015-10-21');

/* Trigger structure for table `stcompras` */

DELIMITER $$

/*!50003 DROP TRIGGER*//*!50032 IF EXISTS */ /*!50003 `actualizarExistencia` */$$

/*!50003 CREATE */ /*!50017 DEFINER = 'root'@'localhost' */ /*!50003 TRIGGER `actualizarExistencia` AFTER UPDATE ON `stcompras` FOR EACH ROW BEGIN
	if NEW.comprasEstado = 'Anul' Then
		Update stexistencia e set e.exisCantidad = e.exiscantidad * -1
		where e.exisNroOt =  NEW.comprasCod;
	End if ;
    END */$$


DELIMITER ;

/* Procedure structure for procedure `ActualizarStock` */

/*!50003 DROP PROCEDURE IF EXISTS  `ActualizarStock` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `ActualizarStock`()
BEGIN
INSERT INTO stexistencia (`codigo_base`,`depoCod`,`exisCantidad`,`exisUsrIns`,exisFchIns,exisNroOT)
SELECT `stproductos`.`prodCodigo`,'1',`detalle_ventas`.`cantidad` * -1,'Trigger',DATE_FORMAT(detalle_ventas.fecha,'%Y/%m/%d'),
`detalle_ventas`.`nro_venta` FROM `stockcapiata`.`ultimacarga`, `stockcapiata`.`stproductos` INNER JOIN `casamarco`.`detalle_ventas` 
ON (`stproductos`.`prodCodigo` = `detalle_ventas`.`codigo`) WHERE DATE_FORMAT(detalle_ventas.fecha,'%Y/%m/%d') 
BETWEEN ultimacarga.`fecha` AND DATE_FORMAT(CURDATE(),'%Y/%m/%d');
CALL actualizarFecha();
    END */$$
DELIMITER ;

/* Procedure structure for procedure `padetallecompra` */

/*!50003 DROP PROCEDURE IF EXISTS  `padetallecompra` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `padetallecompra`(IN codigo varchar(25))
Begin 
	select * from `detalleproductocompraview` where `Compra` = codigo;
END */$$
DELIMITER ;

/*Table structure for table `cargacompraparadetalleview` */

DROP TABLE IF EXISTS `cargacompraparadetalleview`;

/*!50001 DROP VIEW IF EXISTS `cargacompraparadetalleview` */;
/*!50001 DROP TABLE IF EXISTS `cargacompraparadetalleview` */;

/*!50001 CREATE TABLE  `cargacompraparadetalleview`(
 `Código` int(11) ,
 `Fecha Factura` date ,
 `Nro. Factura` varchar(20) ,
 `Estado` varchar(7) ,
 `Comentario` varchar(50) ,
 `Fecha Anulacion` date ,
 `Fecha Pagado` date ,
 `Saldo` double ,
 `Tipo` char(8) ,
 `Proveedor` int(11) ,
 `Usuario` char(10) ,
 `Fecha Actualizado` date ,
 `Fecha Compra` date 
)*/;

/*Table structure for table `cargacomprasview` */

DROP TABLE IF EXISTS `cargacomprasview`;

/*!50001 DROP VIEW IF EXISTS `cargacomprasview` */;
/*!50001 DROP TABLE IF EXISTS `cargacomprasview` */;

/*!50001 CREATE TABLE  `cargacomprasview`(
 `Código` int(11) ,
 `Nro. Factura` varchar(20) ,
 `Proveedor` varchar(25) ,
 `Fecha Factura` date ,
 `Estado` varchar(7) ,
 `Fecha Pagado` date 
)*/;

/*Table structure for table `detalleproductocompraview` */

DROP TABLE IF EXISTS `detalleproductocompraview`;

/*!50001 DROP VIEW IF EXISTS `detalleproductocompraview` */;
/*!50001 DROP TABLE IF EXISTS `detalleproductocompraview` */;

/*!50001 CREATE TABLE  `detalleproductocompraview`(
 `Código` varchar(25) ,
 `Compra` int(11) ,
 `Descripción` varchar(60) ,
 `Depósito` varchar(25) ,
 `Cantidad` int(11) ,
 `Iva Excedente` double ,
 `Iva 5%` double ,
 `Iva 10%` double ,
 `Precio Total` double 
)*/;

/*Table structure for table `productosviewcarga` */

DROP TABLE IF EXISTS `productosviewcarga`;

/*!50001 DROP VIEW IF EXISTS `productosviewcarga` */;
/*!50001 DROP TABLE IF EXISTS `productosviewcarga` */;

/*!50001 CREATE TABLE  `productosviewcarga`(
 `Código` varchar(20) ,
 `Descripción` varchar(60) ,
 `Stock` int(11) ,
 `Tipo` char(10) 
)*/;

/*View structure for view cargacompraparadetalleview */

/*!50001 DROP TABLE IF EXISTS `cargacompraparadetalleview` */;
/*!50001 DROP VIEW IF EXISTS `cargacompraparadetalleview` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `cargacompraparadetalleview` AS (select `c`.`comprasCod` AS `Código`,`c`.`comprasFechaFact` AS `Fecha Factura`,`c`.`comprasNroFactura` AS `Nro. Factura`,(case when (`c`.`comprasEstado` = 'Paga') then 'Pagado' when (`c`.`comprasEstado` = 'Anul') then 'Anulado' when (`c`.`comprasEstado` = 'Acti') then 'Activo' end) AS `Estado`,`c`.`comprasObs` AS `Comentario`,`c`.`comprasFechaAnulacion` AS `Fecha Anulacion`,`c`.`comprasFechaPagado` AS `Fecha Pagado`,`c`.`comprasSaldo` AS `Saldo`,`c`.`comprasTipoFact` AS `Tipo`,`c`.`provCodigo` AS `Proveedor`,`c`.`comprasUsrIns` AS `Usuario`,`c`.`comprasFechaUpd` AS `Fecha Actualizado`,`c`.`comprasFechaIns` AS `Fecha Compra` from `stcompras` `c`) */;

/*View structure for view cargacomprasview */

/*!50001 DROP TABLE IF EXISTS `cargacomprasview` */;
/*!50001 DROP VIEW IF EXISTS `cargacomprasview` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `cargacomprasview` AS select `a`.`comprasCod` AS `Código`,`a`.`comprasNroFactura` AS `Nro. Factura`,`b`.`provDescripcion` AS `Proveedor`,`a`.`comprasFechaFact` AS `Fecha Factura`,(case when (`a`.`comprasEstado` = 'Paga') then 'Pagado' when (`a`.`comprasEstado` = 'Anul') then 'Anulado' when (`a`.`comprasEstado` = 'Acti') then 'Activo' end) AS `Estado`,`a`.`comprasFechaPagado` AS `Fecha Pagado` from (`stcompras` `a` join `stproveedor` `b` on((`a`.`provCodigo` = `b`.`provCodigo`))) */;

/*View structure for view detalleproductocompraview */

/*!50001 DROP TABLE IF EXISTS `detalleproductocompraview` */;
/*!50001 DROP VIEW IF EXISTS `detalleproductocompraview` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `detalleproductocompraview` AS (select `e`.`codigo_base` AS `Código`,`d`.`comprasCod` AS `Compra`,`p`.`prodDescripcion` AS `Descripción`,`dp`.`depoDescripcion` AS `Depósito`,`e`.`exisCantidad` AS `Cantidad`,`d`.`comprasImpExcente` AS `Iva Excedente`,`d`.`comprasImp5` AS `Iva 5%`,`d`.`comprasImp10` AS `Iva 10%`,`d`.`comprasCosto` AS `Precio Total` from (((`stcomprasdet` `d` join `stexistencia` `e` on(((`e`.`exisNroOt` = `d`.`comprasCod`) and (`e`.`codigo_base` = `d`.`codigo_base`) and (abs(`d`.`comprasCanitad`) = abs(`e`.`exisCantidad`))))) join `stproductos` `p` on((`p`.`prodCodigo` = `e`.`codigo_base`))) join `stdeposito` `dp` on((`e`.`depoCod` = `dp`.`depoCod`)))) */;

/*View structure for view productosviewcarga */

/*!50001 DROP TABLE IF EXISTS `productosviewcarga` */;
/*!50001 DROP VIEW IF EXISTS `productosviewcarga` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `productosviewcarga` AS (select `stproductos`.`prodCodigo` AS `Código`,`stproductos`.`prodDescripcion` AS `Descripción`,`stproductos`.`prodStockMinimo` AS `Stock`,`stproductos`.`prodTipo` AS `Tipo` from `stproductos`) */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
