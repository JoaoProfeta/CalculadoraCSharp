# Calculadora C#

uma Calculadora normal, porém, feita de uma forma diferente!

## =========== desafios ===========

O maior desafio desse projeto foi minha curiosidade, a Calculadora é para ser feita usando o Switch Case mesmo? só isso? é o melhor que uma linguagem tão vasta como o C# poderia me proporcionar de opção? fui avante, fui perguntar para algumas pessoas, para saber se tinha outro modo, independente se seria bonito ou feio, se seria fácil ou dificil, eu queria uma forma de simplismente interpolar as coisas em uma unica string, e deixar a linguagem fazer o resto.
### 1 erro:
Não tinha como armazenar os sinais "+,-,*,/" sem ser em uma forma de string, eu não consigo colocar ele em string, e depois concatenar com interpolação :$"{numero1} {operador} {numero2}". os sinais, ou operadores aritméticos não tem um tipo, e não consigo convertelos juntamente com os dois numeros para um tipo double por exemplo. 
### 2 erro: 
Procurar por referências erradas, meu maior erro que foi o problema da demora dessa Calculadora, foi não saber de fato o que eu queria pesquisar, eu sabia definitivamente o que eu queria fazer, só não sabia pesquisar corretamente sobre o assunto.
### 3 erro:
não ter parado de simplismente perguntar a quem tem mais experiencia, e simplismente ter colocado a mão na massa. esse foi fatal, eu sabia que tinha gente que tem essas experiências e tal, mas minha pergunta foi meio doida, uma pessoa respondeu "Creio que voce usou algum tipo de intorpecente"! KKKK de fato, eu nesse momento concordei, mas era só café, falta de saber oq pesquisar, e falta de por a mão na massa, foi o meu principal erro fatal aqui, colocando a mão na massa, eu entendi o que eu derveria ter pesquisado, e fui atrás e encontrei, na documentação da Microsoft O <a href="https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable.compute?view=net-8.0">DataTable</a>

### solução :
