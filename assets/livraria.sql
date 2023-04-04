-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Tempo de geração: 04-Abr-2023 às 20:31
-- Versão do servidor: 5.7.40
-- versão do PHP: 8.0.26

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
  `UF` varchar(45) NOT NULL,
  `Complemento` varchar(45) NOT NULL,
  `Numero` char(5) NOT NULL,
  `Cidade` varchar(45) NOT NULL,
  `Bairro` varchar(45) NOT NULL,
  `CEP` char(10) NOT NULL,
  `Logradouro` varchar(45) NOT NULL,
  PRIMARY KEY (`Codigo_Cliente`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `cliente`
--

INSERT INTO `cliente` (`Codigo_Cliente`, `Nome`, `cpf`, `Telefone`, `RG`, `Endereco`, `UF`, `Complemento`, `Numero`, `Cidade`, `Bairro`, `CEP`, `Logradouro`) VALUES
(1, 'Vinicius Abreu Oliveira', '111-111-111-11', '(313) 332-1100', '33333330', 'Rua rua', 'MG', 'Casa', '245', 'Contagem', 'Industrial', '32231-165', 'Rua'),
(2, 'Joao', '111111111111', '3133321100', '33333330', 'Rua China', 'MG', 'Casa', '245', 'Belo Horizonte', 'Industrial', '32231165', 'Rua'),
(3, 'Ana Luisa Nunes', '656-544-641-1', '(543) 545-4666', '33333330', 'Rua Japao', 'MG', 'Casa', '245', 'Belo Horizonte', 'Industrial', '32231-165', 'Rua import_request_variables'),
(4, 'Ana Clara', '525626324627', '89929292', '33333330', 'Rua Uruguai', 'MG', 'Casa', '245', 'Belo Horizonte', 'Industrial', '32231165', 'Rua Nada'),
(5, 'Ana Dada', '656-544-641-1', '(543) 545-4666', '33333330', 'Rua Japao', 'MG', 'Casa', '245', 'Belo Horizonte', 'Industrial', '32231-165', 'Rua import_request_variables'),
(12, 'Vinicius Abreu Oliveira', '111-111-111-11', '(313) 332-1100', '33333330', 'Rua rua', 'MG', 'Casa', '245', 'Contagem', 'Industrial', '32231-165', 'Rua'),
(13, 'Vinicius Abreu Oliveira nunes', '111-111-111-11', '(313) 332-1100', '33333330', 'Rua rua', 'MG', 'Casa', '245', 'Contagem', 'Industrial', '32231-165', 'Rua'),
(14, 'Vinicius Abreu Oliveira', '111-111-111-11', '(313) 332-1100', '33333330', 'Rua rua', 'MG', 'Casa', '245', 'Contagem', 'Industrial', '32231-165', 'Rua');

-- --------------------------------------------------------

--
-- Estrutura da tabela `efetua_compra`
--

DROP TABLE IF EXISTS `efetua_compra`;
CREATE TABLE IF NOT EXISTS `efetua_compra` (
  `cliente_Codigo_Cliente` int(10) UNSIGNED NOT NULL,
  `obras_ISBN` varchar(20) NOT NULL,
  PRIMARY KEY (`cliente_Codigo_Cliente`,`obras_ISBN`),
  KEY `fk_cliente_has_obras_obras1_idx` (`obras_ISBN`),
  KEY `fk_cliente_has_obras_cliente1_idx` (`cliente_Codigo_Cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `funcionarios`
--

DROP TABLE IF EXISTS `funcionarios`;
CREATE TABLE IF NOT EXISTS `funcionarios` (
  `Matricula` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `Nome` varchar(45) NOT NULL,
  `Senha` int(20) UNSIGNED NOT NULL,
  `RG` varchar(45) NOT NULL,
  `cpf` varchar(45) NOT NULL,
  `Telefone` varchar(15) NOT NULL,
  `Sexo` char(1) NOT NULL,
  `Data_nascimento` varchar(45) NOT NULL,
  `Endereco` varchar(45) NOT NULL,
  `Bairro` varchar(45) NOT NULL,
  `Cidade` varchar(45) NOT NULL,
  `Complemento` varchar(45) NOT NULL,
  `UF` varchar(45) NOT NULL,
  `Numero` char(5) NOT NULL,
  `Logradouro` varchar(45) NOT NULL,
  `CEP` char(10) NOT NULL,
  PRIMARY KEY (`Matricula`),
  UNIQUE KEY `Nome_UNIQUE` (`Nome`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `funcionarios`
--

INSERT INTO `funcionarios` (`Matricula`, `Nome`, `Senha`, `RG`, `cpf`, `Telefone`, `Sexo`, `Data_nascimento`, `Endereco`, `Bairro`, `Cidade`, `Complemento`, `UF`, `Numero`, `Logradouro`, `CEP`) VALUES
(1, 'Vinicius', 1234, '30000', '14888', '31999999', 'm', '13/07/1995', 'sgdsgsd', 'fafsaf', 'fafsaf', 'afssa', 'MG', '245', 'dasfaaf', '32223334'),
(2, 'Lorena', 12345, '12132231', '111-132-332-23', '(031) 999-9999', 'M', '01/10/1994', 'Teste', 'teste', 'teste', 'Casa', 'te', '12', 'Rua 1', '12333-2223');

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
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `obras`
--

INSERT INTO `obras` (`ISBN`, `nome`, `Autor`, `Editora`, `Nacionalidade`, `Classificacao`, `Quantidade`, `Valor`, `cod_obra`) VALUES
('1111112132323', 'Outro livro', 'Vinicius', 'Abril', 'Brasileira', 'Livre para todos os publicos', '200', 100, NULL),
('1122211221220', 'O retorno da fenix 3', 'Vinicius', 'Abril', 'Brasileira', 'Maior 18', '1', 100, NULL),
('1223000216156', 'Como criar beija flores', 'Vinicius', 'Abril', 'Brasileira', 'Livre para todos os publicos', '80', 850, NULL),
('1223131655466', 'O Livro do Hugo', 'Vinicius', 'Abril', 'Brasileira', 'Livre para todos os publicos', '1', 100, NULL),
('1321333165466', 'Novo livro', 'vinicius', 'vinicius', 'br', 'L', '0', 50, NULL),
('1321534564449', 'Teste', 'Teste', 'Teste', 'Teste', 'Teste', '0', 350, NULL),
('2164567778989', 'O retorno da fenixes', 'Vinicius', 'Abril', 'Brasileira', 'Livre para todos os publicos', '1', 100, NULL),
('2195981958190', 'O retorno da fenixes', 'Vinicius', 'Abril', 'Brasileira', 'Livre para todos os publicos', '0', 100, NULL),
('2195981958191', 'O retorno da fenix 2', 'Vinicius', 'Abril', 'Brasileira', 'Livre para todos os publicos', '0', 100, NULL),
('5885446998891', 'O segro da vida a dois!', 'Vinicius', 'Abril', 'Brasileira', 'Livre para todos os publicos', '5', 100, NULL),
('6565125484812', 'Dois carecas brigando por 1 pente', 'Vinicius', 'Abril', 'Brasileira', 'Livre para todos os publicos', '5', 100, NULL),
('9788567002873', 'O Outro Nome de Aslam', 'Vinicius A. Miranda e Gabriele Greggersen', 'Abril', 'Brasileira', 'Livre para todos os publicos', '5', 100, NULL),
('9990909809802', 'ORei leao', 'Junio', 'Abril', 'Brasileira', 'Livre para todos os publicos', '5', 100, NULL);

-- --------------------------------------------------------

--
-- Estrutura da tabela `venda`
--

DROP TABLE IF EXISTS `venda`;
CREATE TABLE IF NOT EXISTS `venda` (
  `funcionarios_Matricula` int(10) DEFAULT '0',
  `obras_ISBN` varchar(20) NOT NULL,
  `Qtde_Venda` varchar(45) NOT NULL,
  `cliente_Codigo_Cliente` int(10) DEFAULT '0',
  KEY `fk_funcionarios_has_obras_obras1_idx` (`obras_ISBN`),
  KEY `fk_funcionarios_has_obras_funcionarios1_idx` (`funcionarios_Matricula`),
  KEY `fk_clientes` (`cliente_Codigo_Cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `venda`
--

INSERT INTO `venda` (`funcionarios_Matricula`, `obras_ISBN`, `Qtde_Venda`, `cliente_Codigo_Cliente`) VALUES
(0, '1111112132323', '2', 0),
(1, '1122211221220', '3', 5),
(1, '1111112132323', '3', 0),
(0, '1223000216156', '1', 0),
(0, '1223000216156', '2', 0),
(2, '1321333165466', '4', 5),
(1, '2195981958191', '5', 4),
(1, '1321333165466', '1', 5),
(1, '2164567778989', '1', 13),
(1, '1321534564449', '1', 0),
(1, '2164567778989', '1', 5),
(0, '1122211221220', '1', 0),
(1, '1223131655466', '1', 0),
(0, '2195981958190', '3', 4),
(0, '1223131655466', '1', 13),
(1, '1122211221220', '1', 3),
(1, '1111112132323', '8', 2),
(1, '1111112132323', '2', 0),
(1, '1111112132323', '1', 0),
(1, '1111112132323', '9', 0),
(1, '1122211221220', '4', 5),
(1, '1122211221220', '1', 5),
(1, '1321534564449', '899', 14);

--
-- Acionadores `venda`
--
DROP TRIGGER IF EXISTS `Tgr_Venda_Delete`;
DELIMITER $$
CREATE TRIGGER `Tgr_Venda_Delete` AFTER DELETE ON `venda` FOR EACH ROW BEGIN
	UPDATE obras SET Quantidade = Quantidade + OLD.Qtde_Venda
WHERE ISBN = OLD.obras_ISBN;
END
$$
DELIMITER ;
DROP TRIGGER IF EXISTS `Tgr_Venda_Insert`;
DELIMITER $$
CREATE TRIGGER `Tgr_Venda_Insert` AFTER INSERT ON `venda` FOR EACH ROW BEGIN
	UPDATE obras SET Quantidade = Quantidade - NEW.Qtde_Venda
WHERE ISBN = NEW.obras_ISBN;
END
$$
DELIMITER ;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `efetua_compra`
--
ALTER TABLE `efetua_compra`
  ADD CONSTRAINT `fk_cliente_has_obras_cliente1` FOREIGN KEY (`cliente_Codigo_Cliente`) REFERENCES `cliente` (`Codigo_Cliente`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_cliente_has_obras_obras1` FOREIGN KEY (`obras_ISBN`) REFERENCES `obras` (`ISBN`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
