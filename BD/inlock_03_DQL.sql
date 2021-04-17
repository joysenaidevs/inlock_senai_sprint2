USE inlock_games_manha;

SELECT * FROM usuarios
SELECT * FROM estudios
SELECT * FROM jogos

SELECT jogos.nomeJogo AS Jogo, estudios.nomeEstudio AS Estudio
FROM jogos
LEFT JOIN estudios
ON jogos.idEstudio = estudios.idEstudio

SELECT estudios.nomeEstudio AS Estudio, jogos.nomeJogo AS Jogo
FROM jogos
RIGHT JOIN estudios
ON jogos.idEstudio = estudios.idEstudio

SELECT * FROM jogos
WHERE idJogo = '1'

SELECT * FROM estudios
WHERE idEstudio = '1'