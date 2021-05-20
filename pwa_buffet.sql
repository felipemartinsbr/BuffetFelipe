CREATE DATABASE  IF NOT EXISTS `pwa_buffet` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `pwa_buffet`;
-- MariaDB dump 10.19  Distrib 10.5.9-MariaDB, for Win64 (AMD64)
--
-- Host: localhost    Database: pwa_buffet
-- ------------------------------------------------------
-- Server version	10.5.9-MariaDB

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
-- Table structure for table `__efmigrationshistory`
--

DROP TABLE IF EXISTS `__efmigrationshistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(95) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `__efmigrationshistory`
--

LOCK TABLES `__efmigrationshistory` WRITE;
/*!40000 ALTER TABLE `__efmigrationshistory` DISABLE KEYS */;
INSERT INTO `__efmigrationshistory` VALUES ('20210519141003_SuperTabela','3.1.13');
/*!40000 ALTER TABLE `__efmigrationshistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetroleclaims`
--

DROP TABLE IF EXISTS `aspnetroleclaims`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aspnetroleclaims` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `RoleId` char(36) NOT NULL,
  `ClaimType` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  `ClaimValue` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_AspNetRoleClaims_RoleId` (`RoleId`),
  CONSTRAINT `FK_AspNetRoleClaims_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetroleclaims`
--

LOCK TABLES `aspnetroleclaims` WRITE;
/*!40000 ALTER TABLE `aspnetroleclaims` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetroleclaims` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetroles`
--

DROP TABLE IF EXISTS `aspnetroles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aspnetroles` (
  `Id` char(36) NOT NULL,
  `Name` varchar(256) CHARACTER SET utf8mb4 DEFAULT NULL,
  `NormalizedName` varchar(256) CHARACTER SET utf8mb4 DEFAULT NULL,
  `ConcurrencyStamp` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `RoleNameIndex` (`NormalizedName`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetroles`
--

LOCK TABLES `aspnetroles` WRITE;
/*!40000 ALTER TABLE `aspnetroles` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetroles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetuserclaims`
--

DROP TABLE IF EXISTS `aspnetuserclaims`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aspnetuserclaims` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `UserId` char(36) NOT NULL,
  `ClaimType` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  `ClaimValue` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_AspNetUserClaims_UserId` (`UserId`),
  CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetuserclaims`
--

LOCK TABLES `aspnetuserclaims` WRITE;
/*!40000 ALTER TABLE `aspnetuserclaims` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetuserclaims` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetuserlogins`
--

DROP TABLE IF EXISTS `aspnetuserlogins`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aspnetuserlogins` (
  `LoginProvider` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
  `ProviderKey` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
  `ProviderDisplayName` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  `UserId` char(36) NOT NULL,
  PRIMARY KEY (`LoginProvider`,`ProviderKey`),
  KEY `IX_AspNetUserLogins_UserId` (`UserId`),
  CONSTRAINT `FK_AspNetUserLogins_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetuserlogins`
--

LOCK TABLES `aspnetuserlogins` WRITE;
/*!40000 ALTER TABLE `aspnetuserlogins` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetuserlogins` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetuserroles`
--

DROP TABLE IF EXISTS `aspnetuserroles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aspnetuserroles` (
  `UserId` char(36) NOT NULL,
  `RoleId` char(36) NOT NULL,
  PRIMARY KEY (`UserId`,`RoleId`),
  KEY `IX_AspNetUserRoles_RoleId` (`RoleId`),
  CONSTRAINT `FK_AspNetUserRoles_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_AspNetUserRoles_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetuserroles`
--

LOCK TABLES `aspnetuserroles` WRITE;
/*!40000 ALTER TABLE `aspnetuserroles` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetuserroles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetusers`
--

DROP TABLE IF EXISTS `aspnetusers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aspnetusers` (
  `Id` char(36) NOT NULL,
  `UserName` varchar(256) CHARACTER SET utf8mb4 DEFAULT NULL,
  `NormalizedUserName` varchar(256) CHARACTER SET utf8mb4 DEFAULT NULL,
  `Email` varchar(256) CHARACTER SET utf8mb4 DEFAULT NULL,
  `NormalizedEmail` varchar(256) CHARACTER SET utf8mb4 DEFAULT NULL,
  `EmailConfirmed` tinyint(1) NOT NULL,
  `PasswordHash` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  `SecurityStamp` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  `ConcurrencyStamp` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  `PhoneNumber` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  `PhoneNumberConfirmed` tinyint(1) NOT NULL,
  `TwoFactorEnabled` tinyint(1) NOT NULL,
  `LockoutEnd` datetime(6) DEFAULT NULL,
  `LockoutEnabled` tinyint(1) NOT NULL,
  `AccessFailedCount` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `UserNameIndex` (`NormalizedUserName`),
  KEY `EmailIndex` (`NormalizedEmail`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetusers`
--

LOCK TABLES `aspnetusers` WRITE;
/*!40000 ALTER TABLE `aspnetusers` DISABLE KEYS */;
INSERT INTO `aspnetusers` VALUES ('08d91b0b-5764-4d2d-892b-5c918972fe89','fmsbr@msn.com','FMSBR@MSN.COM','fmsbr@msn.com','FMSBR@MSN.COM',0,'AQAAAAEAACcQAAAAEBlT+7uEask8X1YstFaFCIOLwHA48Q6ADRZhvLniN6uZjFFrxagoxCIPCU0UeeQqNA==','KMRM2OEYOM7MZO3HQUXPTKPNATDX2YYY','2a294154-5fa9-478f-b21b-762a45e31959',NULL,0,0,NULL,1,0);
/*!40000 ALTER TABLE `aspnetusers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetusertokens`
--

DROP TABLE IF EXISTS `aspnetusertokens`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aspnetusertokens` (
  `UserId` char(36) NOT NULL,
  `LoginProvider` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
  `Name` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
  `Value` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  PRIMARY KEY (`UserId`,`LoginProvider`,`Name`),
  CONSTRAINT `FK_AspNetUserTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetusertokens`
--

LOCK TABLES `aspnetusertokens` WRITE;
/*!40000 ALTER TABLE `aspnetusertokens` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetusertokens` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clientes`
--

DROP TABLE IF EXISTS `clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `clientes` (
  `Id` char(36) NOT NULL,
  `Nome` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  `Email` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  `Endereco` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  `Cpf` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  `Cnpj` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  `DataDeNascimento` datetime(6) NOT NULL,
  `Observaçoes` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  `EntradaCliente` datetime(6) NOT NULL,
  `UltimaModificacaoCliente` datetime(6) NOT NULL,
  `TipoClienteId` char(36) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_Clientes_TipoClienteId` (`TipoClienteId`),
  CONSTRAINT `FK_Clientes_TipoCliente_TipoClienteId` FOREIGN KEY (`TipoClienteId`) REFERENCES `tipocliente` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clientes`
--

LOCK TABLES `clientes` WRITE;
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
INSERT INTO `clientes` VALUES ('1','Felipe','teste@testando.com','Rua Teste Doido','15685966658','0','1989-11-01 00:00:00.000000','Cliente estressado','2021-05-19 00:00:00.000000','2021-05-19 00:00:00.000000','1');
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `convidados`
--

DROP TABLE IF EXISTS `convidados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `convidados` (
  `Id` char(36) NOT NULL,
  `Nome` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  `Email` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  `Cpf` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  `DataDeNascimento` datetime(6) NOT NULL,
  `EventoId` char(36) DEFAULT NULL,
  `TypeId` char(36) DEFAULT NULL,
  `Observacoes` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  `DataConvidadoInserido` datetime(6) NOT NULL,
  `DataConvidadoModificado` datetime(6) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_Convidados_EventoId` (`EventoId`),
  KEY `IX_Convidados_TypeId` (`TypeId`),
  CONSTRAINT `FK_Convidados_Eventos_EventoId` FOREIGN KEY (`EventoId`) REFERENCES `eventos` (`Id`),
  CONSTRAINT `FK_Convidados_SituacaoConvidado_TypeId` FOREIGN KEY (`TypeId`) REFERENCES `situacaoconvidado` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `convidados`
--

LOCK TABLES `convidados` WRITE;
/*!40000 ALTER TABLE `convidados` DISABLE KEYS */;
/*!40000 ALTER TABLE `convidados` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `eventos`
--

DROP TABLE IF EXISTS `eventos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `eventos` (
  `Id` char(36) NOT NULL,
  `Nome` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  `Descricao` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  `DataInicio` datetime(6) NOT NULL,
  `DataFim` datetime(6) NOT NULL,
  `ClienteId` char(36) DEFAULT NULL,
  `TipoDeEventoId` char(36) DEFAULT NULL,
  `SituacaoId` char(36) DEFAULT NULL,
  `LocalId` char(36) DEFAULT NULL,
  `Observacoes` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  `DataEventoInserido` datetime(6) NOT NULL,
  `DataEventoModificado` datetime(6) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_Eventos_ClienteId` (`ClienteId`),
  KEY `IX_Eventos_LocalId` (`LocalId`),
  KEY `IX_Eventos_SituacaoId` (`SituacaoId`),
  KEY `IX_Eventos_TipoDeEventoId` (`TipoDeEventoId`),
  CONSTRAINT `FK_Eventos_Clientes_ClienteId` FOREIGN KEY (`ClienteId`) REFERENCES `clientes` (`Id`),
  CONSTRAINT `FK_Eventos_Local_LocalId` FOREIGN KEY (`LocalId`) REFERENCES `local` (`Id`),
  CONSTRAINT `FK_Eventos_SituacaoEvento_SituacaoId` FOREIGN KEY (`SituacaoId`) REFERENCES `situacaoevento` (`Id`),
  CONSTRAINT `FK_Eventos_TipoEvento_TipoDeEventoId` FOREIGN KEY (`TipoDeEventoId`) REFERENCES `tipoevento` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `eventos`
--

LOCK TABLES `eventos` WRITE;
/*!40000 ALTER TABLE `eventos` DISABLE KEYS */;
/*!40000 ALTER TABLE `eventos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `local`
--

DROP TABLE IF EXISTS `local`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `local` (
  `Id` char(36) NOT NULL,
  `Descricao` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  `Endereco` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `local`
--

LOCK TABLES `local` WRITE;
/*!40000 ALTER TABLE `local` DISABLE KEYS */;
/*!40000 ALTER TABLE `local` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `situacaoconvidado`
--

DROP TABLE IF EXISTS `situacaoconvidado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `situacaoconvidado` (
  `Id` char(36) NOT NULL,
  `Descricao` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `situacaoconvidado`
--

LOCK TABLES `situacaoconvidado` WRITE;
/*!40000 ALTER TABLE `situacaoconvidado` DISABLE KEYS */;
/*!40000 ALTER TABLE `situacaoconvidado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `situacaoevento`
--

DROP TABLE IF EXISTS `situacaoevento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `situacaoevento` (
  `Id` char(36) NOT NULL,
  `Descricao` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `situacaoevento`
--

LOCK TABLES `situacaoevento` WRITE;
/*!40000 ALTER TABLE `situacaoevento` DISABLE KEYS */;
/*!40000 ALTER TABLE `situacaoevento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipocliente`
--

DROP TABLE IF EXISTS `tipocliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipocliente` (
  `Id` char(36) NOT NULL,
  `Descricao` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipocliente`
--

LOCK TABLES `tipocliente` WRITE;
/*!40000 ALTER TABLE `tipocliente` DISABLE KEYS */;
INSERT INTO `tipocliente` VALUES ('1','Pessoa Física'),('2','Pessoa Jurídica');
/*!40000 ALTER TABLE `tipocliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipoevento`
--

DROP TABLE IF EXISTS `tipoevento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipoevento` (
  `Id` char(36) NOT NULL,
  `Descricao` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipoevento`
--

LOCK TABLES `tipoevento` WRITE;
/*!40000 ALTER TABLE `tipoevento` DISABLE KEYS */;
/*!40000 ALTER TABLE `tipoevento` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-05-20  0:48:59
