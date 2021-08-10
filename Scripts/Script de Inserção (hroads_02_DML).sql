use HROADS

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






insert into Personagens(nomePer, idClasse, maxVida, maxMana, Atualização, Criação)
values ('BitBug', 4, '70','100')

insert into Personagens(nomePer, idClasse, maxVida, maxMana)
values ('Fer8', 7, '75', '60')

insert into Personagens(nomePer, idClasse , maxVida, maxMana, Atualização, Criação)
values ('Matheus Pereira', 3, '80', '50','','')



insert into Personagens(nomePer, idClasse, maxVida, maxMana)
values ('DeuBug', 1, '100', '80' )
 
select * from Personagens

select nomePer, nomeDaClasse, maxVida, maxMana, Atualização, Criação from Personagens
full outer join Classe
on Personagens.idClasse = Classe.idClasse
left join Intermediaria
on Personagens.idClasse = Intermediaria.idClasse
inner join Habilidades
on Habilidades.idHabilidades = Intermediaria.idHabilidades


select * from Intermediaria

update Personagens
set nomePer = 'fer7'
where idPersonagens = 7


personagem join classe join intermediaria join habilidades
personagem join classe join intermediaria join habilidades
personagem join classe join intermediaria join habilidades
personagem join classe join intermediaria join habilidades
personagem join classe join intermediaria join habilidades
personagem join classe join intermediaria join habilidades
personagem join classe join intermediaria join habilidades
personagem join classe join intermediaria join habilidades
personagem join classe join intermediaria join habilidades