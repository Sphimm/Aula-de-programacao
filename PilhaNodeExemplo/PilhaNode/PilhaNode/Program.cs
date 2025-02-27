// See https://aka.ms/new-console-template for more information

using PilhaNode;

//ExemploPilha pilha= new ExemploPilha();
//pilha.ExemploPushPop();

ListaPilha pilha = new ListaPilha();
Pilha<int> p = pilha.CriarPilha<int>(new int[] {2, 5, 6, 7});
pilha.ShowPilha(p.Peek());

