-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema Comercialdb0191
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema Comercialdb0191
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `Comercialdb0191` DEFAULT CHARACTER SET utf8 ;
USE `Comercialdb0191` ;

-- -----------------------------------------------------
-- Table `Comercialdb0191`.`Clientes`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Comercialdb0191`.`Clientes` (
  `idcli` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(60) NOT NULL,
  `cpf` CHAR(11) NOT NULL,
  `email` VARCHAR(60) NOT NULL,
  `datacad` TIMESTAMP NOT NULL DEFAULT current_timestamp,
  `ativo` BIT NOT NULL,
  PRIMARY KEY (`idcli`),
  UNIQUE INDEX `cpf_UNIQUE` (`cpf` ASC) VISIBLE,
  UNIQUE INDEX `email_UNIQUE` (`email` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Comercialdb0191`.`Usuarios`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Comercialdb0191`.`Usuarios` (
  `iduser` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(60) NOT NULL,
  `email` VARCHAR(60) NOT NULL,
  `senha` VARCHAR(32) NOT NULL,
  `nivel` VARCHAR(15) NOT NULL DEFAULT 'A',
  `ativo` BIT NOT NULL DEFAULT 1,
  PRIMARY KEY (`iduser`),
  UNIQUE INDEX `email_UNIQUE` (`email` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Comercialdb0191`.`pedidos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Comercialdb0191`.`pedidos` (
  `idped` INT NOT NULL AUTO_INCREMENT,
  `data` TIMESTAMP NOT NULL DEFAULT current_date,
  `status_ped` VARCHAR(10) NOT NULL DEFAULT 'A',
  `desconto` DECIMAL(10,2) NOT NULL,
  `idcli_ped` INT NOT NULL,
  `iduser_ped` INT NOT NULL,
  PRIMARY KEY (`idped`),
  INDEX `fk_pedidos_Clientes_idx` (`idcli_ped` ASC) VISIBLE,
  INDEX `fk_pedidos_Usuarios1_idx` (`iduser_ped` ASC) VISIBLE,
  CONSTRAINT `fk_pedidos_Clientes`
    FOREIGN KEY (`idcli_ped`)
    REFERENCES `Comercialdb0191`.`Clientes` (`idcli`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_pedidos_Usuarios1`
    FOREIGN KEY (`iduser_ped`)
    REFERENCES `Comercialdb0191`.`Usuarios` (`iduser`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Comercialdb0191`.`Produtos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Comercialdb0191`.`Produtos` (
  `idprod` INT NOT NULL AUTO_INCREMENT,
  `descricao` VARCHAR(100) NOT NULL,
  `unidade` VARCHAR(14) NOT NULL,
  `codbar` CHAR(13) NOT NULL,
  `desconto` DECIMAL(10,2) NOT NULL,
  `valor` DECIMAL(10,2) NOT NULL,
  PRIMARY KEY (`idprod`),
  UNIQUE INDEX `codbar_UNIQUE` (`codbar` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Comercialdb0191`.`itemPedido`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Comercialdb0191`.`itemPedido` (
  `idped_ped` INT NOT NULL,
  `idprod_ip` INT NOT NULL,
  `quantidade` DECIMAL(10,2) NOT NULL,
  `valor` DECIMAL(10,2) NOT NULL,
  `desconto` DECIMAL(10,2) NOT NULL,
  INDEX `fk_itemPedido_pedidos1_idx` (`idped_ped` ASC) VISIBLE,
  INDEX `fk_itemPedido_Produtos1_idx` (`idprod_ip` ASC) VISIBLE,
  CONSTRAINT `fk_itemPedido_pedidos1`
    FOREIGN KEY (`idped_ped`)
    REFERENCES `Comercialdb0191`.`pedidos` (`idped`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_itemPedido_Produtos1`
    FOREIGN KEY (`idprod_ip`)
    REFERENCES `Comercialdb0191`.`Produtos` (`idprod`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Comercialdb0191`.`Caixas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Comercialdb0191`.`Caixas` (
  `idcx` INT NOT NULL,
  `data_abertura` TIMESTAMP NOT NULL DEFAULT current_timestamp,
  `caixascol` DECIMAL(10,2) NOT NULL,
  `status_caixa` VARCHAR(32) NOT NULL,
  `iduser_cx` INT NOT NULL,
  PRIMARY KEY (`idcx`),
  INDEX `fk_caixas_Usuarios1_idx` (`iduser_cx` ASC) VISIBLE,
  CONSTRAINT `fk_caixas_Usuarios1`
    FOREIGN KEY (`iduser_cx`)
    REFERENCES `Comercialdb0191`.`Usuarios` (`iduser`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Comercialdb0191`.`TiposPag`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Comercialdb0191`.`TiposPag` (
  `idtipo` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(20) NOT NULL,
  `sigla` VARCHAR(10) NOT NULL,
  PRIMARY KEY (`idtipo`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Comercialdb0191`.`Vendas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Comercialdb0191`.`Vendas` (
  `idvnd` INT NOT NULL AUTO_INCREMENT,
  `data_vnd` TIMESTAMP NOT NULL DEFAULT current_timestamp,
  `status_vnd` VARCHAR(15) NOT NULL DEFAULT 'A',
  `desconto` DECIMAL(10,2) NOT NULL,
  `idcx_vnd` INT NOT NULL,
  `idped_vnd` INT NOT NULL,
  PRIMARY KEY (`idvnd`),
  INDEX `fk_vendas_caixas1_idx` (`idcx_vnd` ASC) VISIBLE,
  INDEX `fk_vendas_pedidos1_idx` (`idped_vnd` ASC) VISIBLE,
  CONSTRAINT `fk_vendas_caixas1`
    FOREIGN KEY (`idcx_vnd`)
    REFERENCES `Comercialdb0191`.`Caixas` (`idcx`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_vendas_pedidos1`
    FOREIGN KEY (`idped_vnd`)
    REFERENCES `Comercialdb0191`.`pedidos` (`idped`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Comercialdb0191`.`Pagamentos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Comercialdb0191`.`Pagamentos` (
  `idPag` INT NOT NULL AUTO_INCREMENT,
  `valor` DECIMAL(10,2) NOT NULL,
  `idvnd_pag` INT NOT NULL,
  `idtipo_pag` INT NOT NULL,
  PRIMARY KEY (`idPag`),
  INDEX `fk_Pagamentos_Vendas1_idx` (`idvnd_pag` ASC) VISIBLE,
  INDEX `fk_Pagamentos_TiposPag1_idx` (`idtipo_pag` ASC) VISIBLE,
  CONSTRAINT `fk_Pagamentos_Vendas1`
    FOREIGN KEY (`idvnd_pag`)
    REFERENCES `Comercialdb0191`.`Vendas` (`idvnd`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Pagamentos_TiposPag1`
    FOREIGN KEY (`idtipo_pag`)
    REFERENCES `Comercialdb0191`.`TiposPag` (`idtipo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

-- -----------------------------------------------------
-- PROCEDURES CLIENTES
-- -----------------------------------------------------

-- INSERIR CLIENTE --
delimiter |
create procedure cliente_inserir(
_nome varchar (60),
_cpf varchar (11),
_email varchar(60)
)
begin
insert into clientes(nome, cpf, email, datacad, ativo)
values (_nome, _cpf, _email, default, default);
select * from cliente where idcli = (select @@identity);
end
|

-- -----------------------------------------------------
-- PROCEDURES PRODUTOS
-- -----------------------------------------------------

-- INSERIR PRODUTO --
delimiter |
create procedure produto_inserir(
_descricao varchar (100),
_unidade varchar (14),
_codbar char(13),
_desconto DECIMAL(10,2),
_valor DECIMAL(10,2)
)
begin
insert into produtos(descricao, unidade, codbar, desconto, valor)
values (_descricao, _unidade, _codbar, _desconto, _valor);
select * from produtos where idprod = (select @@identity);
end
|

-- -----------------------------------------------------
-- PROCEDURES USUARIOS
-- -----------------------------------------------------

-- INSERIR USUARIO --
CREATE DEFINER=`root`@`localhost` PROCEDURE `usuario_inserir`(
_nome varchar (60),
_email varchar (60),
_senha varchar (32),
_nivel varchar (15),
_foto VARBINARY(9000)
)
begin
insert into usuarios(nome, email, senha, nivel, ativo, foto)
values (_nome, _email, (md5(_senha)), _nivel, default, _foto);
select * from usuarios where iduser = (select @@identity);
end
