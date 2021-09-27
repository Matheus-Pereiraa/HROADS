use HROADS

use HROADS

select * from Habilidades

select * from Classe

select * from Classe


select nomePer from Personagens
inner join Classe
on Personagens.idClasse = Classe.idClasse


select nomePer, nomeDaClasse, maxVida, maxMana, Atualização, Criação from Personagens
full outer join Classe
on Personagens.idClasse = Classe.idClasse
left join Intermediaria
on Personagens.idClasse = Intermediaria.idClasse
inner join Habilidades
on Habilidades.idHabilidades = Intermediaria.idHabilidades