use HROADS

insert into Classe (NomeDaClasse)
values ('Barbaro'), ('Cruzado'), 
('Caçadora de Demônios'), ('Monge)'), 
('Necromante'), ('Feiticeiro'), 
('Arcanista')


insert into Habilidades (nomeDaHabilidade)
values ('Lança Mortal'), ('Escudo Supremo'),
('Recuperar Vida')






insert into Intermediaria (idClasse, idHabilidades)
values (1,1), (1,2), (2,2), (3,1), (4,3), (4,2), (6,3)











update Habilidades
set nomeDaHabilidade = 'Lança Mortal'
where idHabilidades = 1

update Classe
set NomeDaClasse = 'Monge'
where idClasse = 4





personagem join classe join intermediaria join habilidades
personagem join classe join intermediaria join habilidades
personagem join classe join intermediaria join habilidades
personagem join classe join intermediaria join habilidades
personagem join classe join intermediaria join habilidades