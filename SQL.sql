-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema SistemVenda
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema SistemVenda
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `SistemVenda` DEFAULT CHARACTER SET utf8 ;
USE `SistemVenda` ;

-- -----------------------------------------------------
-- Table `SistemVenda`.`tb_Clientes`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SistemVenda`.`tb_Clientes` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) NOT NULL,
  `cpf` CHAR(11) NOT NULL,
  `email` VARCHAR(45) NOT NULL,
  `telefone` VARCHAR(14) NULL,
  `ativo` BIT NOT NULL DEFAULT '1',
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SistemVenda`.`tb_Usuarios`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SistemVenda`.`tb_Usuarios` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(60) NOT NULL,
  `email` VARCHAR(60) NOT NULL,
  `senha` VARCHAR(32) NOT NULL,
  `nivel` VARCHAR(15) NOT NULL DEFAULT 'A',
  `ativo` BIT NOT NULL DEFAULT '1',
  PRIMARY KEY (`id`),
  UNIQUE INDEX `email_UNIQUE` (`email` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SistemVenda`.`tb_Pedidos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SistemVenda`.`tb_Pedidos` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `data` TIMESTAMP NOT NULL DEFAULT DF(Current Date)),
  `status_ped` VARCHAR(10) NOT NULL DEFAULT 'A',
  `desconto` DECIMAL(10,2) NOT NULL,
  `idcli` INT NOT NULL,
  `iduser` BIT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_tb_Pedidos_tb_Clientes_idx` (`idcli` ASC) VISIBLE,
  INDEX `fk_tb_Pedidos_tb_Usuarios1_idx` (`iduser` ASC) VISIBLE,
  CONSTRAINT `fk_tb_Pedidos_tb_Clientes`
    FOREIGN KEY (`idcli`)
    REFERENCES `SistemVenda`.`tb_Clientes` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_Pedidos_tb_Usuarios1`
    FOREIGN KEY (`iduser`)
    REFERENCES `SistemVenda`.`tb_Usuarios` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SistemVenda`.`tb_Enderecos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SistemVenda`.`tb_Enderecos` (
  `Clientes_id` INT NOT NULL,
  `cep` CHAR(6) NOT NULL,
  `numero` VARCHAR(50) NOT NULL,
  `bairro` VARCHAR(50) NOT NULL,
  `logradouro` VARCHAR(50) NOT NULL,
  `tipo` VARCHAR(50) NOT NULL,
  `cidade` VARCHAR(45) NOT NULL,
  `complemento` VARCHAR(50) NULL,
  INDEX `fk_tb_enderecos_tb_Clientes1_idx` (`Clientes_id` ASC) VISIBLE,
  CONSTRAINT `fk_tb_enderecos_tb_Clientes1`
    FOREIGN KEY (`Clientes_id`)
    REFERENCES `SistemVenda`.`tb_Clientes` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SistemVenda`.`tb_Produtos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SistemVenda`.`tb_Produtos` (
  `idprod` INT NOT NULL AUTO_INCREMENT,
  `descicao` VARCHAR(100) NOT NULL,
  `unidade` VARCHAR(14) NOT NULL,
  `codbar` VARCHAR(13) NOT NULL,
  `valor` DECIMAL(10,2) NOT NULL,
  `desconto` DECIMAL(10,2) NOT NULL,
  `descontinuado` BIT NOT NULL DEFAULT '1',
  PRIMARY KEY (`idprod`),
  UNIQUE INDEX `codbar_UNIQUE` (`codbar` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SistemVenda`.`tb_ItemPedido`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SistemVenda`.`tb_ItemPedido` (
  `idped` INT NOT NULL,
  `idprod` INT NOT NULL,
  `valor` DECIMAL(10,2) NOT NULL,
  `quantidade` DECIMAL(10,2) NOT NULL,
  `desconto` INT NOT NULL,
  INDEX `fk_tb_ItemPedido_tb_Pedidos1_idx` (`idped` ASC) VISIBLE,
  INDEX `fk_tb_ItemPedido_tb_Produtos1_idx` (`idprod` ASC) VISIBLE,
  CONSTRAINT `fk_tb_ItemPedido_tb_Pedidos1`
    FOREIGN KEY (`idped`)
    REFERENCES `SistemVenda`.`tb_Pedidos` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_ItemPedido_tb_Produtos1`
    FOREIGN KEY (`idprod`)
    REFERENCES `SistemVenda`.`tb_Produtos` (`idprod`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
