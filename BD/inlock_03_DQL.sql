USE inlock_games_manha;

SELECT * FROM usuarios;
GO
SELECT * FROM estudios;
GO
SELECT * FROM jogos;
GO
SELECT jogos.nomeJogo AS Jogo, estudios.nomeEstudio AS Estudio
FROM jogos
LEFT JOIN estudios
ON jogos.idEstudio = estudios.idEstudio;
GO
SELECT estudios.nomeEstudio AS Estudio, jogos.nomeJogo AS Jogo
FROM jogos
RIGHT JOIN estudios
ON jogos.idEstudio = estudios.idEstudio;
GO
SELECT * FROM jogos
WHERE idJogo = '1';
GO
SELECT * FROM estudios
WHERE idEstudio = '1';
GO
SELECT * FROM usuarios
WHERE email = 'admin@admin.com' and senha = 'admin';