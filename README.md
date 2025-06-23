Recebi a missão de automatizar o sistema de estoque de uma papelaria. Cada item precisa registrar seu nome e a quantidade atual em estoque. O sistema deve permitir retirar itens, mas somente se houver quantidade suficiente disponível. Caso contrário, deve exibir uma mensagem informando a falha.

Criei uma classe chamada Produto com:

Propriedade pública Nome.
Campo privado quantidadeEstoque.
Um construtor que receba o nome e a quantidade inicial.
Um método público Retirar(int quantidade) que:
Reduz a quantidade apenas se houver estoque suficiente.
Exiba uma mensagem indicando o sucesso ou a falha da operação.
Um método ExibirEstoque() para mostrar a quantidade atual.

![image](https://github.com/user-attachments/assets/2a3882fc-ae33-4f4e-a422-95dffffe3715)
