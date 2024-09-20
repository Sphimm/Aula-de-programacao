//preciso de um codigo para testar os metodos da classe Personagem

using Exercicios_Fixação;

Personagem h = new Humano("João", Classe.Guerreiro);
Personagem g = new Goblin("Gobliano", Classe.Ladrao);
Personagem o = new Orc("Orcino", Classe.Mago);
Personagem a = new Anao("Anóide", Classe.Paladino);

h.Mover();
g.pular();
o.Dash();
a.Mover();
