USE inlock_games_manha;

INSERT INTO tiposUsuarios(titulo)
VALUES ('Administrador'),('Cliente')

INSERT INTO usuarios(email,senha,idTipoUsuario)
VALUES ('admin@admin.com','admin',1),
	   ('cliente@cliente.com','cliente',2)

INSERT INTO estudios(nomeEstudio)
VALUES ('Blizzard'),('Rockstar Studios'),('Square Enix')

INSERT INTO jogos(nomeJogo,descricao,dataLancamento,valor,idEstudio)
VALUES ('Diablo 3','� um jogo que cont�m bastante a��o e �
viciante, seja voc� um novato ou um f�','15-5-2012',99.00,1),
	   ('Red Dead Redemption II','jogo eletr�nico de a��o-aventura western','26-10-2018',120.00,2)