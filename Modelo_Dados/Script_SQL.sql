-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema comercialdb0191
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema comercialdb0191
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `comercialdb0191` DEFAULT CHARACTER SET utf8 ;
-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8 ;
USE `comercialdb0191` ;

-- -----------------------------------------------------
-- Table `comercialdb0191`.`nivel`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `comercialdb0191`.`nivel` (
  `idnv` INT(11) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) NOT NULL,
  `sigla` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idnv`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `comercialdb0191`.`usuarios`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `comercialdb0191`.`usuarios` (
  `iduser` INT(11) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(60) NOT NULL,
  `email` VARCHAR(60) NOT NULL,
  `senha` VARCHAR(32) NOT NULL,
  `ativo` BIT(1) NOT NULL DEFAULT b'1',
  `idnv` INT(11) NOT NULL,
  PRIMARY KEY (`iduser`),
  UNIQUE INDEX `email_UNIQUE` (`email` ASC) VISIBLE,
  INDEX `fk_usuarios_nivel1_idx` (`idnv` ASC) VISIBLE,
  CONSTRAINT `fk_usuarios_nivel1`
    FOREIGN KEY (`idnv`)
    REFERENCES `comercialdb0191`.`nivel` (`idnv`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 37
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `comercialdb0191`.`caixas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `comercialdb0191`.`caixas` (
  `idcx` INT(11) NOT NULL,
  `data_abertura` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP(),
  `caixascol` DECIMAL(10,2) NOT NULL,
  `status_caixa` VARCHAR(32) NOT NULL,
  `iduser` INT(11) NOT NULL,
  PRIMARY KEY (`idcx`),
  INDEX `fk_caixas_Usuarios1_idx` (`iduser` ASC) VISIBLE,
  CONSTRAINT `fk_caixas_Usuarios1`
    FOREIGN KEY (`iduser`)
    REFERENCES `comercialdb0191`.`usuarios` (`iduser`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `comercialdb0191`.`clientes`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `comercialdb0191`.`clientes` (
  `idcli` INT(11) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(60) NOT NULL,
  `cpf` CHAR(11) NOT NULL,
  `email` VARCHAR(60) NOT NULL,
  `datacad` VARCHAR(60) NOT NULL DEFAULT CURRENT_TIMESTAMP(),
  `ativo` BIT(1) NOT NULL DEFAULT b'1',
  `observacoes` VARCHAR(100) NULL DEFAULT NULL,
  PRIMARY KEY (`idcli`),
  UNIQUE INDEX `cpf_UNIQUE` (`cpf` ASC) VISIBLE,
  UNIQUE INDEX `email_UNIQUE` (`email` ASC) VISIBLE)
ENGINE = InnoDB
AUTO_INCREMENT = 92
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `comercialdb0191`.`enderecos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `comercialdb0191`.`enderecos` (
  `idcli` INT(11) NOT NULL,
  `logradouro` VARCHAR(60) NOT NULL,
  `cep` CHAR(8) NOT NULL,
  `numero` VARCHAR(20) NOT NULL,
  `cidade` VARCHAR(30) NOT NULL,
  `bairro` VARCHAR(30) NOT NULL,
  `estado` VARCHAR(30) NOT NULL,
  `tipo` VARCHAR(20) NOT NULL,
  `uf` VARCHAR(45) NOT NULL,
  `complemento` VARCHAR(30) NULL DEFAULT NULL,
  INDEX `fk_Enderecos_clientes1_idx` (`idcli` ASC) VISIBLE,
  CONSTRAINT `fk_Enderecos_clientes1`
    FOREIGN KEY (`idcli`)
    REFERENCES `comercialdb0191`.`clientes` (`idcli`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `comercialdb0191`.`produtos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `comercialdb0191`.`produtos` (
  `idprod` INT(11) NOT NULL AUTO_INCREMENT,
  `descricao` VARCHAR(100) NOT NULL,
  `unidade` VARCHAR(14) NOT NULL,
  `codbar` CHAR(13) NOT NULL,
  `desconto` DOUBLE NOT NULL,
  `valor` DOUBLE NOT NULL,
  `descontinuado` BIT(1) NOT NULL DEFAULT b'1',
  PRIMARY KEY (`idprod`),
  UNIQUE INDEX `codbar_UNIQUE` (`codbar` ASC) VISIBLE)
ENGINE = InnoDB
AUTO_INCREMENT = 39
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `comercialdb0191`.`pedidos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `comercialdb0191`.`pedidos` (
  `idped` INT(11) NOT NULL AUTO_INCREMENT,
  `data` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP(),
  `status_ped` VARCHAR(10) NOT NULL DEFAULT 'A',
  `desconto` DECIMAL(10,2) NOT NULL,
  `idcli` INT(11) NOT NULL,
  `iduser` INT(11) NOT NULL,
  PRIMARY KEY (`idped`),
  INDEX `fk_pedidos_Clientes_idx` (`idcli` ASC) VISIBLE,
  INDEX `fk_pedidos_Usuarios1_idx` (`iduser` ASC) VISIBLE,
  CONSTRAINT `fk_pedidos_Clientes`
    FOREIGN KEY (`idcli`)
    REFERENCES `comercialdb0191`.`clientes` (`idcli`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_pedidos_Usuarios1`
    FOREIGN KEY (`iduser`)
    REFERENCES `comercialdb0191`.`usuarios` (`iduser`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `comercialdb0191`.`itempedido`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `comercialdb0191`.`itempedido` (
  `idped` INT(11) NOT NULL,
  `idprod` INT(11) NOT NULL,
  `quantidade` DECIMAL(10,2) NOT NULL,
  `valor` DECIMAL(10,2) NOT NULL,
  `desconto` DECIMAL(10,2) NOT NULL,
  INDEX `fk_itemPedido_pedidos1_idx` (`idped` ASC) VISIBLE,
  INDEX `fk_itemPedido_Produtos1_idx` (`idprod` ASC) VISIBLE,
  CONSTRAINT `fk_itemPedido_Produtos1`
    FOREIGN KEY (`idprod`)
    REFERENCES `comercialdb0191`.`produtos` (`idprod`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_itemPedido_pedidos1`
    FOREIGN KEY (`idped`)
    REFERENCES `comercialdb0191`.`pedidos` (`idped`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `comercialdb0191`.`tipospag`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `comercialdb0191`.`tipospag` (
  `idtipo` INT(11) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(20) NOT NULL,
  `sigla` VARCHAR(10) NOT NULL,
  PRIMARY KEY (`idtipo`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `comercialdb0191`.`vendas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `comercialdb0191`.`vendas` (
  `idvnd` INT(11) NOT NULL AUTO_INCREMENT,
  `data_vnd` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP(),
  `status_vnd` VARCHAR(15) NOT NULL DEFAULT 'A',
  `desconto` DECIMAL(10,2) NOT NULL,
  `idcx` INT(11) NOT NULL,
  `idped` INT(11) NOT NULL,
  PRIMARY KEY (`idvnd`),
  INDEX `fk_vendas_caixas1_idx` (`idcx` ASC) VISIBLE,
  INDEX `fk_vendas_pedidos1_idx` (`idped` ASC) VISIBLE,
  CONSTRAINT `fk_vendas_caixas1`
    FOREIGN KEY (`idcx`)
    REFERENCES `comercialdb0191`.`caixas` (`idcx`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_vendas_pedidos1`
    FOREIGN KEY (`idped`)
    REFERENCES `comercialdb0191`.`pedidos` (`idped`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `comercialdb0191`.`pagamentos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `comercialdb0191`.`pagamentos` (
  `idPag` INT(11) NOT NULL AUTO_INCREMENT,
  `valor` DECIMAL(10,2) NOT NULL,
  `idvnd` INT(11) NOT NULL,
  `idtipo` INT(11) NOT NULL,
  PRIMARY KEY (`idPag`),
  INDEX `fk_Pagamentos_Vendas1_idx` (`idvnd` ASC) VISIBLE,
  INDEX `fk_Pagamentos_TiposPag1_idx` (`idtipo` ASC) VISIBLE,
  CONSTRAINT `fk_Pagamentos_TiposPag1`
    FOREIGN KEY (`idtipo`)
    REFERENCES `comercialdb0191`.`tipospag` (`idtipo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Pagamentos_Vendas1`
    FOREIGN KEY (`idvnd`)
    REFERENCES `comercialdb0191`.`vendas` (`idvnd`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `comercialdb0191`.`telefone`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `comercialdb0191`.`telefone` (
  `numero` INT(11) NOT NULL,
  `tipo` VARCHAR(20) NOT NULL,
  `idcli` INT(11) NOT NULL,
  INDEX `fk_telefone_clientes1_idx` (`idcli` ASC) VISIBLE,
  CONSTRAINT `fk_telefone_clientes1`
    FOREIGN KEY (`idcli`)
    REFERENCES `comercialdb0191`.`clientes` (`idcli`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

USE `mydb` ;

-- -----------------------------------------------------
-- Table `mydb`.`user`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`user` (
  `username` VARCHAR(16) NOT NULL,
  `email` VARCHAR(255) NULL DEFAULT NULL,
  `password` VARCHAR(32) NOT NULL,
  `create_time` TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP())
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

USE `comercialdb0191` ;

-- -----------------------------------------------------
-- procedure caixa_alterar
-- -----------------------------------------------------

DELIMITER $$
USE `comercialdb0191`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `caixa_alterar`(
_id int,
_status_caixa varchar(32),
_iduser int
)
begin
	update caixas set status_caixa = _status_caixa, iduser = _iduser where idcx = _idcx;
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure caixa_inserir
-- -----------------------------------------------------

DELIMITER $$
USE `comercialdb0191`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `caixa_inserir`(
_data_abertura timestamp,
_status_caixa varchar(32),
_iduser int
)
begin
	insert into caixas(data_abertura, status_caixa, iduser)
	values (_data_abertura, _status_caixa, _iduser);
	select * from caixas where idcx = (select @@identity);
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure cliente_alterar
-- -----------------------------------------------------

DELIMITER $$
USE `comercialdb0191`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `cliente_alterar`(
_id int,
_nome varchar (60),
_email char(60),
_ativo bit(1),
_observacoes varchar(100)
)
begin
	update clientes set nome = _nome, email = _email, ativo = _ativo, observacoes = _observacoes where idcli = _id;
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure cliente_inserir
-- -----------------------------------------------------

DELIMITER $$
USE `comercialdb0191`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `cliente_inserir`(
_nome varchar (60),
_cpf varchar (11),
_email varchar(60),
_observacoes varchar(100)
)
begin
insert into clientes(nome, cpf, email, datacad, ativo, observacoes)
values (_nome, _cpf, _email, default, default, _observacoes);
select * from clientes where idcli = (select @@identity);
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure endereco_alterar
-- -----------------------------------------------------

DELIMITER $$
USE `comercialdb0191`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `endereco_alterar`(
_idcli int(11),
_logradouro varchar (60),
_cep char(8),
_numero varchar(20),
_cidade varchar(30),
_bairro varchar(30),
_estado varchar(30),
_uf varchar(30),
_tipo varchar(20),
_complemento varchar(30)
)
begin
	update enderecos set logradouro = _Logradouro,
    cep = _cep,
	numero = _numero,
	cidade = _cidade,
	bairro = _bairro,
	estado = _estado,
    uf = _uf,
	tipo = _tipo,
    complemento = _complemento
    where idcli = _idcli;
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure endereco_inserir
-- -----------------------------------------------------

DELIMITER $$
USE `comercialdb0191`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `endereco_inserir`(
_idcli int(11),
_logradouro varchar (60),
_cep char(8),
_numero varchar(20),
_cidade varchar(30),
_bairro varchar(30),
_estado varchar(30),
_uf varchar(30),
_tipo varchar(20),
_complemento varchar(30)
)
begin
	insert into enderecos(idcli, logradouro, cep, numero, cidade, bairro, estado, tipo, uf,complemento)
	values (_idcli, _logradouro, _cep, _numero, _cidade, _bairro, _estado, _tipo, _uf,_complemento);
	select * from enderecos where idcli = (select @@identity);
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure inserir_produto
-- -----------------------------------------------------

DELIMITER $$
USE `comercialdb0191`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `inserir_produto`(
_descricao varchar(100),
_unidade varchar(14),
_codbar char(13),
_desconto decimal(10,2),
_valor decimal(10,2),
_descontinuado bit
)
begin
	insert into produtos (descricao, unidade, codbar, desconto, valor, descontinuado)
	values (_descricao,_unidade, _codbar, _desconto, _valor, _descontinuado );
	select * from produtos where idprod = (select @@identity);
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure itempedido_alterar
-- -----------------------------------------------------

DELIMITER $$
USE `comercialdb0191`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `itempedido_alterar`(
_idped int,
_idprod int,
_quantidade decimal(10,2),
_valor decimal(10,2),
_desconto decimal(10,2)
)
begin
	update pedidos set idped = _idped, idprod = _idprod, quantidade = _quantidade, valor = _valor, desconto = _desconto where idped = _idped and idprod = _idprod;
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure itempedido_inserir
-- -----------------------------------------------------

DELIMITER $$
USE `comercialdb0191`$$
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
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure nivel_alterar
-- -----------------------------------------------------

DELIMITER $$
USE `comercialdb0191`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `nivel_alterar`(
_id int,
_nome varchar (45),
_sigla varchar(45)
)
begin
	update nivel set nome = _nome, sigla = _sigla where idnv = _id;
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure nivel_inserir
-- -----------------------------------------------------

DELIMITER $$
USE `comercialdb0191`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `nivel_inserir`(
_nome varchar (45),
_sigla varchar(45)
)
begin
	insert into nivel (nome, sigla)
	values (_nome, _sigla);
	select * from nivel where idnv = (select @@identity);
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure pagamento_alterar
-- -----------------------------------------------------

DELIMITER $$
USE `comercialdb0191`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `pagamento_alterar`(
_id int,
_valor decimal(10,2),
_idvnd int,
_idtipo int
)
begin
	update pedidos set valor = _valor, idvnd = _idvnd, idtipo = _idtipo where idpag = _id;
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure pagamento_inserir
-- -----------------------------------------------------

DELIMITER $$
USE `comercialdb0191`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `pagamento_inserir`(
_valor decimal(10,2),
_idvnd int,
_idtipo int
)
begin
	insert into pagamentos(valor, idvnd, idtipo)
	values (_valor, _idvnd, _idtipo);
	select * from pagamentos where idpag = (select @@identity);
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure pedido_alterar
-- -----------------------------------------------------

DELIMITER $$
USE `comercialdb0191`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `pedido_alterar`(
_id int,
_status_ped varchar(10),
_desconto decimal(10,2),
_idcli int,
_iduser int
)
begin
	update pedidos set status_ped = _status_ped, desconto = _desconto, idcli = _idcli, iduser = _iduser where idped = _id;
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure pedido_inserir
-- -----------------------------------------------------

DELIMITER $$
USE `comercialdb0191`$$
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
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure produto_alterar
-- -----------------------------------------------------

DELIMITER $$
USE `comercialdb0191`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `produto_alterar`(
_id int,
_descricao varchar (100),
_unidade varchar (14),
_desconto DECIMAL(10,2),
_valor DECIMAL(10,2),
_descontinuado bit
)
begin
	update produtos set descricao = _descricao, unidade = _unidade, desconto = _desconto, valor = _valor, descontinuado = _descontinuado where idprod = _id;
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure usuario_alterar
-- -----------------------------------------------------

DELIMITER $$
USE `comercialdb0191`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `usuario_alterar`(
_id int,
_nome varchar (60),
_email varchar (60),
_senha varchar (32),
_idnv int
)
begin
	update usuarios set nome = _nome, email = _email, senha = (md5(_senha)), idnv = _idnv where iduser = _id;
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure usuario_inserir
-- -----------------------------------------------------

DELIMITER $$
USE `comercialdb0191`$$
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
end$$

DELIMITER ;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
