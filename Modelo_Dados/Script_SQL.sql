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
-- PROCEDURES CAIXA
-- -----------------------------------------------------
delimiter |
CREATE DEFINER=`root`@`localhost` PROCEDURE `caixa_alterar`(
_id int,
_status_caixa varchar(32),
_iduser int
)
begin
	update caixas set status_caixa = _status_caixa, iduser = _iduser where idcx = _idcx;
end
|

delimiter |
CREATE DEFINER=`root`@`localhost` PROCEDURE `caixa_inserir`(
_data_abertura timestamp,
_status_caixa varchar(32),
_iduser int
)
begin
	insert into caixas(data_abertura, status_caixa, iduser)
	values (_data_abertura, _status_caixa, _iduser);
	select * from caixas where idcx = (select @@identity);
end
|

-- -----------------------------------------------------
-- PROCEDURES PRODUTO
-- -----------------------------------------------------

delimiter |
CREATE DEFINER=`root`@`localhost` PROCEDURE `produto_alterar`(
_id int,
_descricao varchar (100),
_unidade varchar (14),
_codbar char(13),
_desconto DECIMAL(10,2),
_valor DECIMAL(10,2),
_descontinuado bit
)
begin
	update produtos set descricao = _descricao, unidade = _unidade, codbar = _codbar, desconto = _desconto, valor = _valor, descontinuado = _descontinuado where idnv = _id;
end
|

delimiter |
CREATE DEFINER=`root`@`localhost` PROCEDURE `pedido_inserir`(
_data datetime,
_status_ped varchar(10),
_desconto decimal(10,2),
_idcli int,
_iduser int
)
begin
	insert into pedidos (data, status_ped, _desconto, _idcli, _iduser)
	values (_data,_status_ped, _desconto, _idcli, _iduser );
	select * from pedidos where idped = (select @@identity);
end
|

-- -----------------------------------------------------
-- PROCEDURES CLIENTE
-- -----------------------------------------------------

delimiter |
CREATE DEFINER=`root`@`localhost` PROCEDURE `cliente_alterar`(
_id int,
_nome varchar (60),
_email char(60),
_ativo bit(1)
)
begin
	update clientes set nome = _nome, email = _email, ativo = _ativo where idcli = _id;
end
|

delimiter |
CREATE DEFINER=`root`@`localhost` PROCEDURE `cliente_inserir`(
_nome varchar (60),
_cpf varchar (11),
_email varchar(60)
)
begin
insert into clientes(nome, cpf, email, datacad, ativo)
values (_nome, _cpf, _email, default, default);
select * from clientes where idcli = (select @@identity);
end
|

-- -----------------------------------------------------
-- PROCEDURES ITEMPEDIDO
-- -----------------------------------------------------

delimiter |
CREATE DEFINER=`root`@`localhost` PROCEDURE `itempedido_inserir`(
_idped int,
_idprod int,
_quantidade decimal(10,2),
_valor decimal(10,2),
_desconto decimal(10,2)
)
begin
	insert into itempedido(idped, idprod, quantidade,_valor, _desconto )
	values (_idped, _idprod, _quantidade,_valor,_desconto  );
end
|

delimiter |
CREATE DEFINER=`root`@`localhost` PROCEDURE `itempedido_alterar`(
_idped int,
_idprod int,
_quantidade decimal(10,2),
_valor decimal(10,2),
_desconto decimal(10,2)
)
begin
	update pedidos set idped = _idped, idprod = _idprod, quantidade = _quantidade, valor = _valor, desconto = _desconto where idped = _idped and idprod = _idprod;
end
|

-- -----------------------------------------------------
-- PROCEDURES NIVEL
-- -----------------------------------------------------

delimiter |
CREATE DEFINER=`root`@`localhost` PROCEDURE `nivel_inserir`(
_id int,
_nome varchar (45)
)
begin
	insert into nivel (nome)
	values (_nome);
	select * from nivel where idnv = (select @@identity);
end
|

delimiter |
CREATE DEFINER=`root`@`localhost` PROCEDURE `nivel_alterar`(
_id int,
_nome varchar (45)
)
begin
	update nivel set nome = _nome where idnv = _id;
end
|

-- -----------------------------------------------------
-- PROCEDURES PAGAMENTO
-- -----------------------------------------------------
delimiter |
CREATE DEFINER=`root`@`localhost` PROCEDURE `pagamento_alterar`(
_id int,
_valor decimal(10,2),
_idvnd int,
_idtipo int
)
begin
	update pedidos set valor = _valor, idvnd = _idvnd, idtipo = _idtipo where idpag = _id;
end
|

delimiter |
CREATE DEFINER=`root`@`localhost` PROCEDURE `pagamento_inserir`(
_valor decimal(10,2),
_idvnd int,
_idtipo int
)
begin
	insert into pagamentos(valor, idvnd, idtipo)
	values (_valor, _idvnd, _idtipo);
	select * from pagamentos where idpag = (select @@identity);
end
|

-- -----------------------------------------------------
-- PROCEDURES PEDIDO
-- -----------------------------------------------------
delimiter |
CREATE DEFINER=`root`@`localhost` PROCEDURE `pedido_alterar`(
_id int,
_status_ped varchar(10),
_desconto decimal(10,2),
_idcli int,
_iduser int
)
begin
	update pedidos set status_ped = _status_ped, desconto = _desconto, idcli = _idcli, iduser = _iduser where idped = _id;
end
|

delimiter |
CREATE DEFINER=`root`@`localhost` PROCEDURE `pedido_inserir`(
_data datetime,
_status_ped varchar(10),
_desconto decimal(10,2),
_idcli int,
_iduser int
)
begin
	insert into pedidos (data, status_ped, _desconto, _idcli, _iduser)
	values (_data,_status_ped, _desconto, _idcli, _iduser );
	select * from pedidos where idped = (select @@identity);
end
|
-- -----------------------------------------------------
-- PROCEDURES TIPOSPAG
-- -----------------------------------------------------
delimiter |
CREATE DEFINER=`root`@`localhost` PROCEDURE `tipospag_alterar`(
_id int,
_nome varchar(200),
_sigla varchar(10)
)
begin
	update tipospag set nome = _nome, sigla = _sigla where idtipo = _id;
end
|

delimiter |
CREATE DEFINER=`root`@`localhost` PROCEDURE `tipospag_inserir`(
_nome varchar(200),
_sigla varchar(10)
)
begin
	insert into tipospag(nome, sigla)
	values (_nome, _sigla);
	select * from tipospag where idtipo = (select @@identity);
end
|

-- -----------------------------------------------------
-- PROCEDURES USUARIO
-- -----------------------------------------------------
delimiter |
CREATE DEFINER=`root`@`localhost` PROCEDURE `usuario_alterar`(
_id int,
_nome varchar (60),
_email varchar (60),
_senha varchar (32),
_idnv int
)
begin
	update usuarios set nome = _nome, email = _email, senha = (md5(_senha)), idnv = _idnv where iduser = _id;
end
|

delimiter |
CREATE DEFINER=`root`@`localhost` PROCEDURE `usuario_inserir`(
_nome varchar (60),
_email varchar (60),
_senha varchar (32),
_idnv int
)
begin
	insert into usuarios (nome, email, senha, idnv, ativo)
	values (_nome, _email, (md5(_senha)), _idnv, default);
	select * from usuarios where iduser = (select @@identity);
end
|

-- -----------------------------------------------------
-- PROCEDURES VENDA
-- -----------------------------------------------------
delimiter |
CREATE DEFINER=`root`@`localhost` PROCEDURE `venda_alterar`(
_id int,
_status_vnd varchar(15),
_desconto decimal(10,2),
_idcx int,
_idped int
)
begin
	update vendas set status_vnd = _status_vnd, desconto = _desconto, idcx = _idcx, idped = _idped where idvnd = _id;
end
|

delimiter |
CREATE DEFINER=`root`@`localhost` PROCEDURE `venda_inserir`(
_data_vnd timestamp,
_status_vnd varchar(15),
_desconto decimal(10,2),
_idcx int,
_idped int
)
begin
	insert into vendas(data_vnd, status_vnd, desconto, idcx, idped)
	values (_data_vnd, _status_vnd,_desconto,_idcx ,_idped );
	select * from vendas where idvnd = (select @@identity);
end
|
