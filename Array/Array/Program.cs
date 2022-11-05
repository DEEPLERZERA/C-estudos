// See https://aka.ms/new-console-template for more information
string [] lgbtqia = { "Homossexual", "Bissexual", "Lésbica", "Transsexual", "Queer", "Interssexual", "Assexual", "Não binário" };  //Cria vetor

for (int i = 0; i < lgbtqia.Length; i++) //Percorre vetor
{
    Console.WriteLine(lgbtqia[i]);

}


foreach(string var in lgbtqia) {  //Percorre vetor com foreach

    if(var == "Lésbica")  //Condicional
    {
        Console.WriteLine($"A opção é {var}: As lésbicas são pessoas" + $" que sentem-se atraídas por outras mulheres"); 
    }
    else if(var == "Bissexual") //Condicional
    {
        Console.WriteLine($"A opção é {var}: Os bissexuais são pessoas" + $" que optam por qualquer dos dois gêneros");
    }
}

var multidimensionalArray = new string[3,2]  {{"Cis","Homossexual"},{"Mulher", "Homem"},{"Transsexual","Assexuado"}}; //Cria vetor multidimensional

foreach(var item in multidimensionalArray) //Percorre vetor com foreach
{
    Console.WriteLine($"Valor: {item}"); 
}

int[] vetor1 = { 1, 2, 3, 4 }; //Cria vetor
int[] vetor2 = { 3, 5, 2, 1 };


foreach(int item in vetor1) //Percorre vetor
{
    foreach(int item2 in vetor2) //Percorre vetor
    {
        Console.WriteLine(item * item2); //Imprimindo na tela
    }
}