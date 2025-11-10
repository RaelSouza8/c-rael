#region "Exemplo 1"
/* 
for (int i = 0; i <= 10; i++)
{
    Console.Write($"1 x {i} = {i}\n");
}
 */
#endregion

#region exemplo 2
/* 
int numero_tabuada;

Console.Write("Digite o número da tabuada que você deseja");
numero_tabuada = int.Parse(Console.ReadLine()!);

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"{numero_tabuada} x {i} = {numero_tabuada * i}");
} */

#endregion

#region Vamos ver né pessoal
/* 
int primeiro = 1;
int segundo = 0;
int terceiro = 0;
int resultado;

Console.Write("A sequência do número somando com anteiores: ");

terceiro = primeiro + segundo;
resultado = terceiro + segundo;

for (int i = 0; i <= 12; i++)
{
    Console.WriteLine($"{resultado} + {i} = {resultado + i}");
}
 */

#endregion

#region A verdade (resposta do prof)
/* 
int n1 = 0, n2 = 1, soma = 0, proximo = 0;

Console.Write("0, ");

for (int i = 0; i <= 12; i++)
{
    proximo = n2;
    soma = n1 + n2;
    n1 = n2;
    n2 = soma;
    Console.Write($"{proximo}, ");
}
 */
#endregion

#region Exemplo While
/* 
int numero;

Console.Write("Digite número oisitivo: ");
numero = int.Parse(Console.ReadLine()!);

while (numero <= 0)
{
    Console.Write("Número inválido, digite número positivo: ");
    numero = int.Parse(Console.ReadLine()!);
}
 */
#endregion

#region Exemplo Do While
/* 
char opçao;
char continuar;

do
{
    Console.WriteLine("----------------");
    Console.WriteLine("Escolha a opção");
    Console.WriteLine("a) Somar");
    Console.WriteLine("b) substração");
    Console.WriteLine("opção: ");
    opçao = Console.ReadKey().KeyChar;

    switch (opçao)
    {
        case 'a': Console.WriteLine("Somando número"); break;
        case 'b': Console.WriteLine("Subtraindo número"); break;
        default: Console.WriteLine("Opção inválida"); break;
    }
    Console.WriteLine("----------------");
    Console.WriteLine("Você deseja continuar\na) Sim \nb) Não");
    continuar = Console.ReadKey().KeyChar;
} while (continuar == 'a');
 */
#endregion

#region Q4 - Peça para o usuário digitar um número inteiro positivo e calcule o fatorial
/* 
int numero;
int resultado;

Console.Write("Digite um número inteiro: ");
numero = int.Parse(Console.ReadLine()!);

while (numero > 0)
{
    Console.Write("Número inválido, digite número positivo: ");
    numero = int.Parse(Console.ReadLine()!);
}

for ( int i = numero; i <= 0; )
{
    Console.Write($"")
}
 */
#endregion

#region faça um programa que crie uma coleção do tipo inteiro, leia esse valor com foreach e verifique quantos pares tem nessa lista(coleção)
/* 
List<int> numeros = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
int quantidadesPares = 0;
foreach (var par in numeros)
{
    if (par % 2 == 0)
    {
        quantidadesPares++;
        Console.Write($"{par} ");
    }
}
Console.WriteLine($"\nA quantidade de número de pares é {quantidadesPares}");
 */

#endregion

#region Q4 - dado um array de strings contendo os nomes de frutas, escreva um programa que imprima cada fruta em uma linha mas que ignore as frutas que começam com letra 'A'.


List<string> frutas = ["Maçã", "Banana", "Abacaxi", "Laranja", "Amora"];


char vogal = 'a';


foreach (var fruta in frutas)
{
    if (vogal >= 0) 
    {
        Console.Write($"{fruta}  ");
    }
}


#endregion