-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Tempo de geração: 16-Mar-2023 às 10:44
-- Versão do servidor: 5.7.31
-- versão do PHP: 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `livraria`
--

CREATE DATABASE livraria;

USE livraria;
-- --------------------------------------------------------

--
-- Estrutura da tabela `cliente`
--

DROP TABLE IF EXISTS `cliente`;
CREATE TABLE IF NOT EXISTS `cliente` (
  `Codigo_Cliente` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `Nome` varchar(45) NOT NULL,
  `cpf` varchar(45) NOT NULL,
  `Telefone` varchar(15) NOT NULL,
  `RG` varchar(45) NOT NULL,
  `Endereco` varchar(45) NOT NULL,
  `UF` char(2) NOT NULL,
  `Complemento` varchar(45) NOT NULL,
  `Numero` char(5) NOT NULL,
  `Cidade` varchar(45) NOT NULL,
  `Bairro` varchar(45) NOT NULL,
  `CEP` char(10) NOT NULL,
  `Logradouro` varchar(45) NOT NULL,
  PRIMARY KEY (`Codigo_Cliente`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `cliente`
--

INSERT INTO `cliente` (`Codigo_Cliente`, `Nome`, `cpf`, `Telefone`, `RG`, `Endereco`, `UF`, `Complemento`, `Numero`, `Cidade`, `Bairro`, `CEP`, `Logradouro`) VALUES
(1, 'Vinicius', '111111111111', '3133321100', '33333330', 'Rua rua', 'MG', 'Casa', '245', 'Contagem', 'Industrial', '32231165', 'Rua'),
(2, 'Joao', '111111111111', '3133321100', '33333330', 'Rua China', 'MG', 'Casa', '245', 'Belo Horizonte', 'Industrial', '32231165', 'Rua'),
(3, 'Ana', '6565446411', '54354546664', '33333330', 'Rua Japao', 'MG', 'Casa', '245', 'Belo Horizonte', 'Industrial', '32231165', 'Rua import_request_variables'),
(4, 'Ana Clara', '525626324627', '89929292', '33333330', 'Rua Uruguai', 'MG', 'Casa', '245', 'Belo Horizonte', 'Industrial', '32231165', 'Rua Nada');

-- --------------------------------------------------------

--
-- Estrutura da tabela `efetua_compra`
--

DROP TABLE IF EXISTS `efetua_compra`;
CREATE TABLE IF NOT EXISTS `efetua_compra` (
  `Cliente_CPF` int(11) NOT NULL,
  `Obras_ISBN` int(11) NOT NULL,
  `Codigo` varchar(45) NOT NULL,
  PRIMARY KEY (`Codigo`),
  KEY `Cliente_CPF` (`Cliente_CPF`),
  KEY `Obras_ISBN` (`Obras_ISBN`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `funcionarios`
--

DROP TABLE IF EXISTS `funcionarios`;
CREATE TABLE IF NOT EXISTS `funcionarios` (
  `Matricula` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `Nome` varchar(45) NOT NULL  UNIQUE,
  `Senha` int(20) NOT NULL,
  `RG` varchar(45) NOT NULL,
  `cpf` varchar(45) NOT NULL,
  `telefone` varchar(10) NOT NULL,
  `Sexo` char(1) NOT NULL,
  `Data_nascimento` varchar(45) NOT NULL,
  `Endereco` varchar(45) NOT NULL,
  `Bairro` varchar(45) NOT NULL,
  `Cidade` varchar(45) NOT NULL,
  `Complemento` varchar(45) NOT NULL,
  `UF` char(2) NOT NULL,
  `Numero` char(5) NOT NULL,
  `logradouro` varchar(45) NOT NULL,
  `CEP` char(10) NOT NULL,
  PRIMARY KEY (`Matricula`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `funcionarios`
--

INSERT INTO `funcionarios` (`Matricula`, `Nome`, `Senha`, `RG`, `cpf`, `telefone`, `Sexo`, `Data_nascimento`, `Endereco`, `Bairro`, `Cidade`, `Complemento`, `UF`, `Numero`, `logradouro`, `CEP`) VALUES
(1, 'Vinicius', 1234, '30000', '14888', '31999999', 'm', '13071995', 'sgdsgsd', 'fafsaf', 'fafsaf', 'afssa', 'MG', '245', 'dasfaaf', '32223334');

-- --------------------------------------------------------

--
-- Estrutura da tabela `gera`
--

DROP TABLE IF EXISTS `gera`;
CREATE TABLE IF NOT EXISTS `gera` (
  `Funcionarios_Matricula` int(11) NOT NULL,
  `Movimentaçao_cod_movimentacao` int(11) NOT NULL,
  `Codigo` varchar(45) NOT NULL,
  PRIMARY KEY (`Codigo`),
  KEY `Funcionarios_Matricula` (`Funcionarios_Matricula`),
  KEY `Movimentaçao_cod_movimentacao` (`Movimentaçao_cod_movimentacao`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `livraria`
--

DROP TABLE IF EXISTS `livraria`;
CREATE TABLE IF NOT EXISTS `livraria` (
  `CNPJ` int(11) NOT NULL,
  `Nome` varchar(45) NOT NULL,
  `Endereco` varchar(45) NOT NULL,
  `cidade` varchar(45) NOT NULL,
  `complemento` varchar(45) NOT NULL,
  `UF` varchar(45) NOT NULL,
  `Numero` char(5) NOT NULL,
  `Logradouro` varchar(45) NOT NULL,
  `CEP` char(10) NOT NULL,
  `bairro` varchar(45) NOT NULL,
  `telefone` char(10) NOT NULL,
  PRIMARY KEY (`CNPJ`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `movimentaçao`
--

DROP TABLE IF EXISTS `movimentaçao`;
CREATE TABLE IF NOT EXISTS `movimentaçao` (
  `cod_movimentacao` int(11) NOT NULL,
  `quantia` int(11) NOT NULL,
  `tipo` varchar(45) NOT NULL,
  `hora` time NOT NULL,
  `data` date NOT NULL,
  PRIMARY KEY (`cod_movimentacao`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `obras`
--

DROP TABLE IF EXISTS `obras`;
CREATE TABLE IF NOT EXISTS `obras` (
  `ISBN` varchar(20) NOT NULL,
  `nome` varchar(45) NOT NULL,
  `Autor` varchar(45) NOT NULL,
  `Editora` varchar(45) NOT NULL,
  `Nacionalidade` varchar(45) NOT NULL,
  `Classificacao` varchar(45) NOT NULL,
  `Quantidade` varchar(45) NOT NULL,
  `Valor` int(80) NOT NULL,
  `cod_obra` int(10) DEFAULT NULL,
  PRIMARY KEY (`ISBN`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `obras`
--

INSERT INTO `obras` (`ISBN`, `nome`, `Autor`, `Editora`, `Nacionalidade`, `Classificacao`, `Quantidade`, `Valor`, `cod_obra`) VALUES
('2195981958190', 'O retorno da fenix', 'Vinicius', 'Abril', 'Brasileira', 'Livre para todos os publicos', '5', 100, NULL),
('9990909809802', 'ORei leao', 'Junio', 'Abril', 'Brasileira', 'Livre para todos os publicos', '5', 100, NULL),
('1321333165466', 'Novo livro', 'vinicius', 'vinicius', 'br', 'L', '5', 50, NULL);


/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
