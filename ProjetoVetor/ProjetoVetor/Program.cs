// See https://aka.ms/new-console-template for more information
using System;

double[] vetA = { 5, 10, 15, 20, 25 }; //Criando vetor
double[] vetB = new double[5]; //Criando vetor double [5]
double[] vetC = new double[20];
int cont = 1;
for (int i = 0; i < vetB.Length; i++) //Criando laço de repetição for
{
    Console.WriteLine($"Digite a nota {cont}"); //Imprimindo digite a nota
    cont++; //Incrementando contador
    double.TryParse(Console.ReadLine(), out vetB[i]); //Pede para escrever e adiciona no vetor
}

double soma = 0;
double media = 0; //Define resultado
Console.WriteLine($"Tamanho do vetor {vetA.Length}");  //Fala o tamanho do vetor
foreach(var v in vetB) //Itera sobre vetB e imprime os seus respectivos valores
{

    Console.WriteLine(v);
}

foreach(var b in vetB) //Iterando sobre vetB
{
    soma += b;  //Faz a somatória dos valores
}

media = soma/ vetB.Length;  //Calcula a média

Console.WriteLine($"Sua média é: {media}"); //Imprime o Console.WriteLine

Random r = new Random(); //Gera valor random
for (int i = 0; i < vetC.Length; i++) //Gera laço de repetição
{
    vetC[i] = r.Next(1, 100); //Pega valor aleatório e atribui a vetC
}

foreach(var c in vetC) //Percorre o vetC
{
    Console.WriteLine(c); //Imprime na tela
}

double maior = 0; //Cria variável maior que é igual a zero
for (var i = 0; i < vetC.Length; i++) //Gera laço de repetição
{
    if (vetC[i] > maior)  //Verifica se o valor do vetor é maior que a variável maior
    {
        maior = vetC[i];  //Caso seja atribui o valor do vetor a variável maior
    }
}

Console.WriteLine($"O maior valor do vetor é: {maior}");  //Imprime na tela

double menor = maior; //Criando variável

for(var i = 0; i < vetC.Length; i++) //Gera laço de repetição
{
    if (vetC[i] < menor)  //Faz verificação se valor do vetor é menor
    {
        menor = vetC[i]; //Atribui valor menor
    }
}

Console.WriteLine($"O menor valor do vetor é: {menor}");  //Imprime na tela


