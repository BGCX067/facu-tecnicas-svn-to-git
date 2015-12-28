# MySQL-Front 4.2  (Build 2.77)

/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE */;
/*!40101 SET SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES */;
/*!40103 SET SQL_NOTES='ON' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS */;
/*!40014 SET FOREIGN_KEY_CHECKS=0 */;


# Host: localhost    Database: tccg
# ------------------------------------------------------
# Server version 5.0.22-community-nt

DROP DATABASE IF EXISTS `tccg`;
CREATE DATABASE `tccg` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `tccg`;

#
# Table structure for table asiento_contable_cabecera
#

CREATE TABLE `asiento_contable_cabecera` (
  `Id_asiento_contable_cabecera` int(11) NOT NULL auto_increment,
  `motivo` varchar(255) default NULL,
  `fecha` date default NULL,
  PRIMARY KEY  (`Id_asiento_contable_cabecera`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Dumping data for table asiento_contable_cabecera
#
LOCK TABLES `asiento_contable_cabecera` WRITE;
/*!40000 ALTER TABLE `asiento_contable_cabecera` DISABLE KEYS */;

INSERT INTO `asiento_contable_cabecera` VALUES (30,'por la compra de un escritorio','2011-08-01');
INSERT INTO `asiento_contable_cabecera` VALUES (31,'por la compra de una pc','2011-08-01');
INSERT INTO `asiento_contable_cabecera` VALUES (32,'Por Contrasiento Nro: 30 de la fecha: 01/08/2011 12:00:00 a.m.','2011-11-08');
/*!40000 ALTER TABLE `asiento_contable_cabecera` ENABLE KEYS */;
UNLOCK TABLES;

#
# Table structure for table asientos_contables
#

CREATE TABLE `asientos_contables` (
  `Id_asiento_contable` int(11) NOT NULL auto_increment,
  `id_plan` int(11) default NULL,
  `debito` float(15,2) default NULL,
  `credito` float(15,2) default NULL,
  `Id_asiento_contable_cabecera` int(11) default NULL,
  PRIMARY KEY  (`Id_asiento_contable`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Dumping data for table asientos_contables
#
LOCK TABLES `asientos_contables` WRITE;
/*!40000 ALTER TABLE `asientos_contables` DISABLE KEYS */;

INSERT INTO `asientos_contables` VALUES (69,6,100,0,30);
INSERT INTO `asientos_contables` VALUES (70,7,0,100,30);
INSERT INTO `asientos_contables` VALUES (71,6,1000,0,31);
INSERT INTO `asientos_contables` VALUES (72,6,100,0,31);
INSERT INTO `asientos_contables` VALUES (73,6,120,0,31);
INSERT INTO `asientos_contables` VALUES (74,7,0,1220,31);
INSERT INTO `asientos_contables` VALUES (75,6,0,100,32);
INSERT INTO `asientos_contables` VALUES (76,7,100,0,32);
/*!40000 ALTER TABLE `asientos_contables` ENABLE KEYS */;
UNLOCK TABLES;

#
# Table structure for table menues
#

CREATE TABLE `menues` (
  `Id_menu` int(11) NOT NULL auto_increment,
  `nombre_menu` varchar(255) default NULL,
  `Id_nivel_menu` int(11) default NULL,
  `Id_nivel_acceso` varchar(255) default NULL,
  `id_menu_padre` varchar(255) default NULL,
  `form` varchar(80) NOT NULL default '',
  PRIMARY KEY  (`Id_menu`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Dumping data for table menues
#
LOCK TABLES `menues` WRITE;
/*!40000 ALTER TABLE `menues` DISABLE KEYS */;

INSERT INTO `menues` VALUES (1,'Archivo',0,'8','1',' ');
INSERT INTO `menues` VALUES (2,'Plan Cuentas',1,'8','5','ABM_PlanCuentas');
INSERT INTO `menues` VALUES (3,'ABM Usuarios',1,'1','1','ABM_Usuarios');
INSERT INTO `menues` VALUES (4,'Asientos Contables',1,'1','5','Asientos_Contables');
INSERT INTO `menues` VALUES (5,'Cuentas',0,'10','5','');
INSERT INTO `menues` VALUES (6,'Consulta Asientos',1,'1','5','Consulta_Asientos_Contables');
INSERT INTO `menues` VALUES (8,'Libro Mayor',1,'1','5','Libro_Mayor');
INSERT INTO `menues` VALUES (9,'Libro Mayor Resumen',1,'1','5','Libro_Mayor_Resumen');
/*!40000 ALTER TABLE `menues` ENABLE KEYS */;
UNLOCK TABLES;

#
# Table structure for table niveles_acceso
#

CREATE TABLE `niveles_acceso` (
  `Id_nivel_acceso` int(11) NOT NULL auto_increment,
  `nivel_acceso` varchar(255) default NULL,
  PRIMARY KEY  (`Id_nivel_acceso`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Dumping data for table niveles_acceso
#
LOCK TABLES `niveles_acceso` WRITE;
/*!40000 ALTER TABLE `niveles_acceso` DISABLE KEYS */;

INSERT INTO `niveles_acceso` VALUES (1,'Administrador');
INSERT INTO `niveles_acceso` VALUES (2,'Mesa de Entrada');
INSERT INTO `niveles_acceso` VALUES (3,'Usuario Comun');
/*!40000 ALTER TABLE `niveles_acceso` ENABLE KEYS */;
UNLOCK TABLES;

#
# Table structure for table niveles_menu
#

CREATE TABLE `niveles_menu` (
  `Id_nivel_menu` int(11) NOT NULL auto_increment,
  `nivel_menu` varchar(255) default NULL,
  PRIMARY KEY  (`Id_nivel_menu`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Dumping data for table niveles_menu
#
LOCK TABLES `niveles_menu` WRITE;
/*!40000 ALTER TABLE `niveles_menu` DISABLE KEYS */;

/*!40000 ALTER TABLE `niveles_menu` ENABLE KEYS */;
UNLOCK TABLES;

#
# Table structure for table plan_cuentas
#

CREATE TABLE `plan_cuentas` (
  `Id_Plan` int(11) NOT NULL auto_increment,
  `Clave_Contable` varchar(16) NOT NULL default '',
  `Descripcion` varchar(300) default NULL,
  `Ajuste_Inflacion` varchar(1) default NULL,
  `Baja` varchar(1) default NULL,
  `Imputable` varchar(1) default 'N',
  PRIMARY KEY  (`Id_Plan`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Dumping data for table plan_cuentas
#
LOCK TABLES `plan_cuentas` WRITE;
/*!40000 ALTER TABLE `plan_cuentas` DISABLE KEYS */;

INSERT INTO `plan_cuentas` VALUES (83,'1-00-000-000-000','ACTIVO','N','N','N');
INSERT INTO `plan_cuentas` VALUES (84,'1-01-000-000-000','Disponibilidades','N','N','N');
INSERT INTO `plan_cuentas` VALUES (85,'1-01-001-000-000','Caja y Bancos','N','N','N');
INSERT INTO `plan_cuentas` VALUES (86,'1-01-001-001-000','Cajas','N','N','N');
INSERT INTO `plan_cuentas` VALUES (87,'1-01-001-001-001','Caja en $','N','N','N');
INSERT INTO `plan_cuentas` VALUES (88,'1-01-001-001-002','Caja en U$S','N','N','N');
INSERT INTO `plan_cuentas` VALUES (89,'1-01-001-002-000','Bancos','N','N','N');
INSERT INTO `plan_cuentas` VALUES (90,'1-01-001-002-001','Banco Nación  c/c','N','N','N');
INSERT INTO `plan_cuentas` VALUES (91,'1-01-001-002-002','Banco Nacíón c/a','N','N','N');
INSERT INTO `plan_cuentas` VALUES (92,'1-01-001-003-000','Fondo Fijo','N','N','N');
INSERT INTO `plan_cuentas` VALUES (93,'1-01-001-004-000','Valores a Depositar','N','N','N');
INSERT INTO `plan_cuentas` VALUES (94,'1-02-000-000-000','Creditos por ventas','N','N','N');
INSERT INTO `plan_cuentas` VALUES (95,'1-02-001-000-000','Deudores','N','N','N');
INSERT INTO `plan_cuentas` VALUES (96,'1-02-001-001-000','Deudores por Ventas','N','N','N');
INSERT INTO `plan_cuentas` VALUES (97,'1-02-001-002-000','Deudores Morosos','N','N','N');
INSERT INTO `plan_cuentas` VALUES (98,'1-02-001-003-000','Deudores en Gestión Judicial','N','N','N');
INSERT INTO `plan_cuentas` VALUES (99,'1-02-001-004-000','Deudores Varios','N','N','N');
INSERT INTO `plan_cuentas` VALUES (100,'1-02-002-000-000','Documentos a Cobrar','N','N','N');
INSERT INTO `plan_cuentas` VALUES (101,'1-03-000-000-000','Otros Créditos','N','N','N');
INSERT INTO `plan_cuentas` VALUES (102,'1-03-001-000-000','Prestamos otorgados','N','N','N');
INSERT INTO `plan_cuentas` VALUES (103,'1-03-002-000-000','Prestamos otorgados','N','N','N');
INSERT INTO `plan_cuentas` VALUES (104,'1-03-003-000-000','Anticipos','N','N','N');
INSERT INTO `plan_cuentas` VALUES (105,'1-03-003-001-000','Anticipo a proveedores','N','N','N');
INSERT INTO `plan_cuentas` VALUES (106,'1-03-003-002-000','Anticipo de impuestos','N','N','N');
INSERT INTO `plan_cuentas` VALUES (107,'1-03-003-003-000','Anticipo al personal','N','N','N');
INSERT INTO `plan_cuentas` VALUES (108,'1-03-003-004-000','Anticipo a proveedores','N','N','N');
INSERT INTO `plan_cuentas` VALUES (109,'1-03-004-000-000','Alquileres pagados por adelantado','N','N','N');
INSERT INTO `plan_cuentas` VALUES (110,'1-03-005-000-000','Intereses pagados por adelantado','N','N','N');
INSERT INTO `plan_cuentas` VALUES (111,'1-04-000-000-000','Inversiones','N','N','N');
INSERT INTO `plan_cuentas` VALUES (112,'1-04-001-000-000','Acciones','N','N','N');
INSERT INTO `plan_cuentas` VALUES (113,'1-04-001-001-000','Acciones transitorias','N','N','N');
INSERT INTO `plan_cuentas` VALUES (114,'1-04-001-002-000','Acciones permanentes','N','N','N');
INSERT INTO `plan_cuentas` VALUES (115,'1-04-002-000-000','Títulos públicos','N','N','N');
INSERT INTO `plan_cuentas` VALUES (116,'1-04-003-000-000','Inmuebles para alquilar','N','N','N');
INSERT INTO `plan_cuentas` VALUES (117,'1-05-000-000-000','Bienes de Cambio','N','N','N');
INSERT INTO `plan_cuentas` VALUES (118,'1-05-001-000-000','Mercaderías','N','N','N');
INSERT INTO `plan_cuentas` VALUES (119,'1-05-001-001-000','Mercaderías','N','N','N');
INSERT INTO `plan_cuentas` VALUES (120,'1-05-001-002-000','Mercaderías en tránsito','N','N','N');
INSERT INTO `plan_cuentas` VALUES (121,'1-05-001-003-000','Mercaderías entregadas en consignación','N','N','N');
INSERT INTO `plan_cuentas` VALUES (122,'1-05-002-000-000','Materias primas','N','N','N');
INSERT INTO `plan_cuentas` VALUES (123,'1-05-003-000-000','Productos','N','N','N');
INSERT INTO `plan_cuentas` VALUES (124,'1-05-003-001-000','Productos en curso de elaboración','N','N','N');
INSERT INTO `plan_cuentas` VALUES (125,'1-05-003-002-000','Productos elaborados','N','N','N');
INSERT INTO `plan_cuentas` VALUES (126,'1-05-004-000-000','Materiales Varios','N','N','N');
INSERT INTO `plan_cuentas` VALUES (127,'1-06-000-000-000','Bienes de Uso','N','N','N');
INSERT INTO `plan_cuentas` VALUES (128,'1-06-001-000-000','Rodados','N','N','N');
INSERT INTO `plan_cuentas` VALUES (129,'1-06-002-000-000','Instalaciones','N','N','N');
INSERT INTO `plan_cuentas` VALUES (130,'1-06-003-000-000','Maquinarias','N','N','N');
INSERT INTO `plan_cuentas` VALUES (131,'1-06-004-000-000','Herramientas','N','N','N');
INSERT INTO `plan_cuentas` VALUES (132,'1-06-005-000-000','Muebles y Útiles','N','N','N');
INSERT INTO `plan_cuentas` VALUES (133,'1-06-006-000-000','Equipos','N','N','N');
INSERT INTO `plan_cuentas` VALUES (134,'1-06-007-000-000','Inmuebles','N','N','N');
INSERT INTO `plan_cuentas` VALUES (135,'1-07-000-000-000','Bienes Inmateriales','N','N','N');
INSERT INTO `plan_cuentas` VALUES (136,'1-07-001-000-000','Llave de negocio','N','N','N');
INSERT INTO `plan_cuentas` VALUES (137,'1-07-002-000-000','Marcas de fábrica','N','N','N');
INSERT INTO `plan_cuentas` VALUES (138,'1-07-003-000-000','Concesiones y franquicias','N','N','N');
INSERT INTO `plan_cuentas` VALUES (139,'1-07-004-000-000','Patentes de invensión','N','N','N');
INSERT INTO `plan_cuentas` VALUES (140,'1-08-000-000-000','Cargos Diferidos','N','N','N');
INSERT INTO `plan_cuentas` VALUES (141,'1-08-001-000-000','Gastos','N','N','N');
INSERT INTO `plan_cuentas` VALUES (142,'1-08-001-001-000','Gastos de constitución','N','N','N');
INSERT INTO `plan_cuentas` VALUES (143,'1-08-001-002-000','Gastos de organización','N','N','N');
INSERT INTO `plan_cuentas` VALUES (144,'1-08-001-003-000','Gastos de reorganización','N','N','N');
INSERT INTO `plan_cuentas` VALUES (145,'1-08-001-004-000','Gastos de investigación y desarrollo','N','N','N');
INSERT INTO `plan_cuentas` VALUES (146,'2-00-000-000-000','PASIVO','N','N','N');
INSERT INTO `plan_cuentas` VALUES (147,'2-01-000-000-000','Deudas','N','N','N');
INSERT INTO `plan_cuentas` VALUES (148,'2-01-001-000-000','Deudas comerciales','N','N','N');
INSERT INTO `plan_cuentas` VALUES (149,'2-01-001-001-000','Proveedores','N','N','N');
INSERT INTO `plan_cuentas` VALUES (150,'2-01-001-002-000','Anticipo de clientes','N','N','N');
INSERT INTO `plan_cuentas` VALUES (151,'2-01-001-003-000','Obligaciones a Pagar','N','N','N');
INSERT INTO `plan_cuentas` VALUES (152,'2-01-002-000-000','Deudas bancarias y financieras','N','N','N');
INSERT INTO `plan_cuentas` VALUES (153,'2-01-002-001-000','Adelantos en cuenta corriente','N','N','N');
INSERT INTO `plan_cuentas` VALUES (154,'2-01-002-002-000','Prestamos bancarios','N','N','N');
INSERT INTO `plan_cuentas` VALUES (155,'2-01-002-003-000','Obligaciones a Pagar','N','N','N');
INSERT INTO `plan_cuentas` VALUES (156,'2-01-002-004-000','Obligaciones','N','N','N');
INSERT INTO `plan_cuentas` VALUES (157,'2-01-002-004-001','Obligaciones a pagar con garantía real','N','N','N');
INSERT INTO `plan_cuentas` VALUES (158,'2-01-002-004-002','Obligaciones a pagar hipotecarias','N','N','N');
INSERT INTO `plan_cuentas` VALUES (159,'2-01-002-004-003','Obligaciones a pagar prendarias','N','N','N');
INSERT INTO `plan_cuentas` VALUES (160,'2-01-002-005-000','Acreedores','N','N','N');
INSERT INTO `plan_cuentas` VALUES (161,'2-01-002-005-001','Acreedores hipotecarios','N','N','N');
INSERT INTO `plan_cuentas` VALUES (162,'2-01-002-005-002','Acreedores prendarios','N','N','N');
INSERT INTO `plan_cuentas` VALUES (163,'2-02-000-000-000','Deudas fiscales','N','N','N');
INSERT INTO `plan_cuentas` VALUES (164,'2-02-001-000-000','Impuestos a pagar','N','N','N');
INSERT INTO `plan_cuentas` VALUES (165,'2-02-002-000-000','IVA a pagar','N','N','N');
INSERT INTO `plan_cuentas` VALUES (166,'2-02-003-000-000','Provisión pra impuestos','N','N','N');
INSERT INTO `plan_cuentas` VALUES (167,'2-03-000-000-000','Deudas sociales','N','N','N');
INSERT INTO `plan_cuentas` VALUES (168,'2-03-001-000-000','Sueldos a pagar','N','N','N');
INSERT INTO `plan_cuentas` VALUES (169,'2-03-002-000-000','Cargas Sociales a pagar','N','N','N');
INSERT INTO `plan_cuentas` VALUES (170,'2-03-003-000-000','Provisiones','N','N','N');
INSERT INTO `plan_cuentas` VALUES (171,'2-03-003-001-000','Provisión para SAC','N','N','N');
INSERT INTO `plan_cuentas` VALUES (172,'2-03-003-002-000','Provisión para cargas sociales','N','N','N');
INSERT INTO `plan_cuentas` VALUES (173,'2-03-004-000-000','Retenciones a depositar','N','N','N');
INSERT INTO `plan_cuentas` VALUES (174,'2-04-000-000-000','Otras deudas','N','N','N');
INSERT INTO `plan_cuentas` VALUES (175,'2-04-001-000-000','Acreedores Varios','N','N','N');
INSERT INTO `plan_cuentas` VALUES (176,'2-04-002-000-000','Dividendos a pagar','N','N','N');
INSERT INTO `plan_cuentas` VALUES (177,'2-04-003-000-000','Alquileres cobrados por adelantados','N','N','N');
INSERT INTO `plan_cuentas` VALUES (178,'2-04-004-000-000','Intereses cobrados por adelantados','N','N','N');
INSERT INTO `plan_cuentas` VALUES (179,'2-04-005-000-000','Provisiones','N','N','N');
INSERT INTO `plan_cuentas` VALUES (180,'2-04-005-001-000','Provisión para gastos','N','N','N');
INSERT INTO `plan_cuentas` VALUES (181,'2-04-005-002-000','Provisión para honorarios','N','N','N');
INSERT INTO `plan_cuentas` VALUES (182,'2-04-006-000-000','Honorarios directores y síndicos a pagar','N','N','N');
INSERT INTO `plan_cuentas` VALUES (183,'2-04-007-000-000','Rentas anticipadas','N','N','N');
INSERT INTO `plan_cuentas` VALUES (184,'2-05-000-000-000','Previsiones','N','N','N');
INSERT INTO `plan_cuentas` VALUES (185,'2-05-001-000-000','Previsión Indemnización por despidos','N','N','N');
INSERT INTO `plan_cuentas` VALUES (186,'2-05-002-000-000','Previsión para juicios pendientes','N','N','N');
INSERT INTO `plan_cuentas` VALUES (187,'2-05-003-000-000','Previsión para garantías por service','N','N','N');
INSERT INTO `plan_cuentas` VALUES (188,'3-00-000-000-000','PATRIMONIO NETO','N','N','N');
INSERT INTO `plan_cuentas` VALUES (189,'3-01-000-000-000','Capital Social','N','N','N');
INSERT INTO `plan_cuentas` VALUES (190,'3-01-001-000-000','Capital suscripto','N','N','N');
INSERT INTO `plan_cuentas` VALUES (191,'3-01-002-000-000','Acciones en circulación','N','N','N');
INSERT INTO `plan_cuentas` VALUES (192,'3-01-003-000-000','Dividendos a distribuir en acciones','N','N','N');
INSERT INTO `plan_cuentas` VALUES (193,'3-02-000-000-000','Aportes no capitalizados','N','N','N');
INSERT INTO `plan_cuentas` VALUES (194,'3-02-001-000-000','Primas de emisión','N','N','N');
INSERT INTO `plan_cuentas` VALUES (195,'3-02-002-000-000','Aportes irrevocables para futuras suscripciones','N','N','N');
INSERT INTO `plan_cuentas` VALUES (196,'3-03-000-000-000','Ganancias Reservadas','N','N','N');
INSERT INTO `plan_cuentas` VALUES (197,'3-03-001-000-000','Reservas','N','N','N');
INSERT INTO `plan_cuentas` VALUES (198,'3-03-001-001-000','Reserva legal','N','N','N');
INSERT INTO `plan_cuentas` VALUES (199,'3-03-001-002-000','Reserva estatutaria','N','N','N');
INSERT INTO `plan_cuentas` VALUES (200,'3-03-001-003-000','Reserva facultativa','N','N','N');
INSERT INTO `plan_cuentas` VALUES (201,'3-03-001-004-000','Reserva para renovación de bienes de uso','N','N','N');
INSERT INTO `plan_cuentas` VALUES (202,'3-04-000-000-000','Resultados no Asignados','N','N','N');
INSERT INTO `plan_cuentas` VALUES (203,'3-04-001-000-000','Resultados acumulados','N','N','N');
INSERT INTO `plan_cuentas` VALUES (204,'3-04-002-000-000','Resultados acumulados del ejercicio anterior','N','N','N');
INSERT INTO `plan_cuentas` VALUES (205,'3-04-003-000-000','Resultado del ejercicio','N','N','N');
INSERT INTO `plan_cuentas` VALUES (206,'4-00-000-000-000','PERDIDAS','N','N','N');
INSERT INTO `plan_cuentas` VALUES (207,'4-01-000-000-000','Costo de mercaderías vendidas','N','N','N');
INSERT INTO `plan_cuentas` VALUES (208,'4-02-000-000-000','Devolución de ventas','N','N','N');
INSERT INTO `plan_cuentas` VALUES (209,'4-03-000-000-000','Deudores Incobrables','N','N','N');
INSERT INTO `plan_cuentas` VALUES (210,'4-04-000-000-000','Amortización Bienes de Uso','N','N','N');
INSERT INTO `plan_cuentas` VALUES (211,'4-05-000-000-000','Intereses perdidos','N','N','N');
INSERT INTO `plan_cuentas` VALUES (212,'4-06-000-000-000','Alquileres perdidos','N','N','N');
INSERT INTO `plan_cuentas` VALUES (213,'4-07-000-000-000','Faltante de Caja','N','N','N');
INSERT INTO `plan_cuentas` VALUES (214,'4-08-000-000-000','Comisiones perdidas','N','N','N');
INSERT INTO `plan_cuentas` VALUES (215,'4-09-000-000-000','Sueldos y Jornales','N','N','N');
INSERT INTO `plan_cuentas` VALUES (216,'4-10-000-000-000','Sueldo Anual Complementario','N','N','N');
INSERT INTO `plan_cuentas` VALUES (217,'4-11-000-000-000','Gastos de Publicidad y Prograganda','N','N','N');
INSERT INTO `plan_cuentas` VALUES (218,'4-12-000-000-000','Comisiones y Gastos Bancarios','N','N','N');
INSERT INTO `plan_cuentas` VALUES (219,'5-00-000-000-000','GANANCIAS','N','N','N');
INSERT INTO `plan_cuentas` VALUES (220,'5-01-000-000-000','Ventas','N','N','N');
INSERT INTO `plan_cuentas` VALUES (221,'5-02-000-000-000','Recupero Deudores Incobrables','N','N','N');
INSERT INTO `plan_cuentas` VALUES (222,'5-03-000-000-000','Utilidad Venta Bienes de Uso','N','N','N');
INSERT INTO `plan_cuentas` VALUES (223,'5-04-000-000-000','Sobrante de Caja','N','N','N');
INSERT INTO `plan_cuentas` VALUES (224,'5-05-000-000-000','Alquileres ganados','N','N','N');
INSERT INTO `plan_cuentas` VALUES (225,'5-06-000-000-000','Intereses ganados','N','N','N');
INSERT INTO `plan_cuentas` VALUES (226,'5-07-000-000-000','Dividendos ganados','N','N','N');
INSERT INTO `plan_cuentas` VALUES (227,'5-08-000-000-000','Donaciones recibidas','N','N','N');
INSERT INTO `plan_cuentas` VALUES (228,'6-00-000-000-000','CUENTAS DE ORDEN','N','N','N');
INSERT INTO `plan_cuentas` VALUES (229,'6-01-000-000-000','Documentos descontados','N','N','N');
INSERT INTO `plan_cuentas` VALUES (230,'6-02-000-000-000','Banco Nación, Documentos descontados','N','N','N');
INSERT INTO `plan_cuentas` VALUES (231,'6-03-000-000-000','Documentos endosados','N','N','N');
INSERT INTO `plan_cuentas` VALUES (232,'6-04-000-000-000','Mercaderías recibidas en consignación','N','N','N');
/*!40000 ALTER TABLE `plan_cuentas` ENABLE KEYS */;
UNLOCK TABLES;

#
# Table structure for table usuarios
#

CREATE TABLE `usuarios` (
  `Id_usuario` int(11) NOT NULL auto_increment,
  `apellido` varchar(255) default NULL,
  `nombre` varchar(255) default NULL,
  `login` varchar(255) default NULL,
  `password` varchar(255) default NULL,
  `Id_nivel` int(11) default NULL,
  PRIMARY KEY  (`Id_usuario`),
  KEY `Nuevo índice` (`Id_nivel`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Dumping data for table usuarios
#
LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;

INSERT INTO `usuarios` VALUES (1,'Garrido','Guillermo ','gg','gg',2);
INSERT INTO `usuarios` VALUES (2,'Troilo','Anibal','anibal','anibal',2);
INSERT INTO `usuarios` VALUES (3,'Costa','Leandro','lea','lea',10);
INSERT INTO `usuarios` VALUES (4,'Administrador','Administrador','adm','adm',1);
INSERT INTO `usuarios` VALUES (5,'Costa','jose','jose','jose',1);
INSERT INTO `usuarios` VALUES (6,'Garridos','Guillermo ','gg','gg',2);
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;

/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
