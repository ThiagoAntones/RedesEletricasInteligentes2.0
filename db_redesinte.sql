-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 29/10/2023 às 03:47
-- Versão do servidor: 10.4.28-MariaDB
-- Versão do PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `db_redesinte`
--
CREATE DATABASE `db_redesinte`;
USE `db_redesinte`;

-- --------------------------------------------------------

--
-- Estrutura para tabela `nivel1`
--

CREATE TABLE `nivel1` (
  `ID` int(11) NOT NULL,
  `projeto` int(11) NOT NULL,
  `descricao` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Despejando dados para a tabela `nivel1`
--

INSERT INTO `nivel1` (`ID`, `projeto`, `descricao`) VALUES
(1, 1, 'Definir escopo de projeto'),
(3, 1, 'Formação da equipe do projeto'),
(4, 2, 'Configurar ambiente'),
(5, 2, 'Aquisição de recursos financeiros'),
(6, 2, 'Estabelecimento de acordos com stakeholders'),
(7, 22, 'Identificaçãod e riscos');

-- --------------------------------------------------------

--
-- Estrutura para tabela `nivel2`
--

CREATE TABLE `nivel2` (
  `ID` int(11) NOT NULL,
  `projeto` int(11) NOT NULL,
  `nivel1` int(11) NOT NULL,
  `descricao` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `nivel2`
--

INSERT INTO `nivel2` (`ID`, `projeto`, `nivel1`, `descricao`) VALUES
(2, 1, 1, 'hhhh234'),
(7, 6, 6, 'ffff'),
(11, 6, 4, 'sda'),
(16, 1, 1, 'dops');

-- --------------------------------------------------------

--
-- Estrutura para tabela `projetos`
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
-- Despejando dados para a tabela `projetos`
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
(18, 'Hospital de Base Lon', 'Modernização do Sistema Elétrico', '2023-07-31', '2025-06-10', 0.00),
(19, 'Co. Vertical', 'Modernização sistema elétrico', '2023-07-03', '2023-07-14', 0.00),
(20, 'Vertical Inside', 'Modernização sistema elétrico', '2023-07-31', '2023-07-31', 6566.00),
(22, 'eletro carlos', 'Modernização sistema elétrico.', '2023-08-01', '2023-10-06', 45000.79);

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `nivel1`
--
ALTER TABLE `nivel1`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `Projeto` (`projeto`);

--
-- Índices de tabela `nivel2`
--
ALTER TABLE `nivel2`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `nivel1` (`nivel1`),
  ADD KEY `projeto` (`projeto`);

--
-- Índices de tabela `projetos`
--
ALTER TABLE `projetos`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `nivel1`
--
ALTER TABLE `nivel1`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de tabela `nivel2`
--
ALTER TABLE `nivel2`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT de tabela `projetos`
--
ALTER TABLE `projetos`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- Restrições para tabelas despejadas
--

--
-- Restrições para tabelas `nivel1`
--
ALTER TABLE `nivel1`
  ADD CONSTRAINT `nivel1_ibfk_1` FOREIGN KEY (`projeto`) REFERENCES `projetos` (`ID`);

--
-- Restrições para tabelas `nivel2`
--
ALTER TABLE `nivel2`
  ADD CONSTRAINT `nivel2_ibfk_1` FOREIGN KEY (`nivel1`) REFERENCES `nivel1` (`ID`),
  ADD CONSTRAINT `nivel2_ibfk_2` FOREIGN KEY (`projeto`) REFERENCES `projetos` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
