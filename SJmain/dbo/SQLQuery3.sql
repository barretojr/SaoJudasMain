INSERT INTO Departamento (iddepartamento, nomedepartamento) VALUES
(2, 'Contabilidade'),
(3, 'Fiscal'),
(4, 'Logistica'),
(1, 'Master'),
(6, 'Pessoal'),
(7, 'Societario'),
(5, 'Tecnologia');
INSERT INTO Usuario ( iddepartamento, nome, nomeusuario, senha, cpfusuario, telefone, email) VALUES
            (5, 'Jonathan Barreto', 'Jonathan', 'admin', 1234567891, 12341234, 'jonathan@saojudas'),
            (1, 'Administrador', 'admin', 'admin', 69696969, 44284428, 'admin@saojudas'),
            (5, 'Higor Chagas', 'Higor', 'admin', 123456789, 1123232342, 'higor@saojudas'),
            (5, 'Pedro Amoroso', 'Pedro', 'admin', 485748521, 77885566, 'pedro@saojudas'),
            (5, 'Wilson Shoity', 'Wilson', 'admin', 158654114, 11955884, 'wilson@saojudas');