-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 01, 2024 at 12:31 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_redesinte`
--

-- --------------------------------------------------------

--
-- Table structure for table `nivel1`
--

CREATE TABLE `nivel1` (
  `ID` int(11) NOT NULL,
  `projeto` int(11) NOT NULL,
  `descricao` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `nivel1`
--

INSERT INTO `nivel1` (`ID`, `projeto`, `descricao`) VALUES
(1, 1, 'Definir escopo de projetos'),
(3, 1, 'Formação da equipe do projeto'),
(4, 2, 'Configurar ambiente'),
(6, 2, 'Estabelecimento de acordos com stakeholders'),
(11, 10, 'Gestão de recursos'),
(16, 6, 'Gestão de finâncias '),
(18, 4, 'RH'),
(20, 25, 'Receber equipamentos');

-- --------------------------------------------------------

--
-- Table structure for table `nivel2`
--

CREATE TABLE `nivel2` (
  `ID` int(11) NOT NULL,
  `projeto` int(11) NOT NULL,
  `nivel1` int(11) NOT NULL,
  `descricao` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `nivel2`
--

INSERT INTO `nivel2` (`ID`, `projeto`, `nivel1`, `descricao`) VALUES
(1, 15, 6, 'acordos'),
(2, 1, 1, 'escopo'),
(7, 6, 6, 'acordos'),
(11, 6, 4, 'configuração do ambiente'),
(16, 1, 1, 'escopos'),
(20, 25, 20, 'armazenagem e instalação');

-- --------------------------------------------------------

--
-- Table structure for table `projetos`
--

CREATE TABLE `projetos` (
  `ID` int(11) NOT NULL,
  `titulo` varchar(20) NOT NULL,
  `descricao` varchar(100) NOT NULL,
  `inicio` date NOT NULL,
  `termino` date NOT NULL,
  `custo` double(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `projetos`
--

INSERT INTO `projetos` (`ID`, `titulo`, `descricao`, `inicio`, `termino`, `custo`) VALUES
(1, 'Mod. Casas Brasil', 'Modernização sistema elétrico', '2023-07-04', '2023-07-04', 32450.78),
(2, 'Mod. Banco Magazine', 'Modernização sistema elétrico', '2023-07-04', '2023-07-04', 64789.12),
(3, 'Mazine', 'Modernização sistema elétrico', '2023-07-04', '2023-07-04', 352478.00),
(4, 'Mercado Alves', 'Modernização sistema elétrico', '2023-07-04', '2023-07-04', 478036.00),
(5, 'Conveniência CC', 'Modernização sistema elétrico', '2023-07-04', '2023-07-04', 450.00),
(6, 'Loja Eltric Now', 'Modernização sistema elétrico', '2001-01-01', '2001-01-01', 88.00),
(7, 'Mega Cargas', 'Modernização sistema elétrico', '2001-01-01', '2001-01-01', 48756.00),
(8, 'Trans AL', 'Modernização sistema elétrico', '2023-07-04', '2023-07-04', 852.00),
(9, 'America Basics', 'Modernização sistema elétrico', '2023-07-04', '2023-07-04', 8565.00),
(10, 'America Premium', 'Modernização sistema elétrico', '2023-07-04', '2023-07-04', 5465.00),
(11, 'Associate America', 'Modernização sistema elétrico', '2023-07-04', '2023-07-04', 7.00),
(12, 'Industry AL', 'Modernização sistema elétrico', '2023-07-04', '2023-07-04', 4.00),
(13, 'AL Projetos', 'Modernização sistema elétrico', '2023-07-04', '2023-07-04', 452.00),
(14, 'Indústria Criativa A', 'Modernização sistema elétrico', '2001-01-01', '2001-01-01', 4.00),
(15, 'Co. AL', 'Modernização sistema elétrico', '2023-07-04', '2023-07-04', 55.00),
(16, 'Planeta GM', 'Modernização sistema elétrico', '2023-07-04', '2023-07-04', 151.00),
(17, 'GM Turismo', 'Modernização sistema elétrico', '2023-07-04', '2023-07-04', 45.00),
(18, 'Hospital de Base Lon', 'Modernização do Sistema Elétrico', '2023-07-31', '2025-06-10', 147652.12),
(19, 'Co. Vertical', 'Modernização sistema elétrico', '2023-07-03', '2023-07-14', 278451.33),
(20, 'Vertical Inside', 'Modernização sistema elétrico', '2023-07-31', '2023-07-31', 6566.00),
(22, 'Tam Linhas Aéreas', 'Modernização sistema elétrico.', '2023-08-01', '2023-10-06', 45000.79),
(24, 'Panair', 'Variabilidade energética', '2023-12-21', '2024-04-26', 350985.31),
(25, 'Latam', 'Instalação de painéis solares', '2023-12-11', '2023-12-14', 45786.89);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `nivel1`
--
ALTER TABLE `nivel1`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `Projeto` (`projeto`);

--
-- Indexes for table `nivel2`
--
ALTER TABLE `nivel2`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `nivel1` (`nivel1`),
  ADD KEY `projeto` (`projeto`);

--
-- Indexes for table `projetos`
--
ALTER TABLE `projetos`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `nivel1`
--
ALTER TABLE `nivel1`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `nivel2`
--
ALTER TABLE `nivel2`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `projetos`
--
ALTER TABLE `projetos`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `nivel1`
--
ALTER TABLE `nivel1`
  ADD CONSTRAINT `nivel1_ibfk_1` FOREIGN KEY (`projeto`) REFERENCES `projetos` (`ID`);

--
-- Constraints for table `nivel2`
--
ALTER TABLE `nivel2`
  ADD CONSTRAINT `nivel2_ibfk_1` FOREIGN KEY (`nivel1`) REFERENCES `nivel1` (`ID`),
  ADD CONSTRAINT `nivel2_ibfk_2` FOREIGN KEY (`projeto`) REFERENCES `projetos` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
