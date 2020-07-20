-- MySQL dump 10.13  Distrib 8.0.18, for Win64 (x86_64)
--
-- Host: localhost    Database: brg
-- ------------------------------------------------------
-- Server version	8.0.18

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `trilha`
--

DROP TABLE IF EXISTS `trilha`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `trilha` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Prazo` datetime(6) NOT NULL,
  `ColaboradorId` int(11) NOT NULL,
  `HabilidadeId` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_Trilha_ColaboradorId` (`ColaboradorId`),
  KEY `IX_Trilha_HabilidadeId` (`HabilidadeId`),
  CONSTRAINT `FK_Trilha_Colaborador_ColaboradorId` FOREIGN KEY (`ColaboradorId`) REFERENCES `colaborador` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_Trilha_Habilidade_HabilidadeId` FOREIGN KEY (`HabilidadeId`) REFERENCES `habilidade` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trilha`
--

LOCK TABLES `trilha` WRITE;
/*!40000 ALTER TABLE `trilha` DISABLE KEYS */;
/*!40000 ALTER TABLE `trilha` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-07-20 16:38:05
