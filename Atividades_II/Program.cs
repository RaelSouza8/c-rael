#region Q1 - faça um programa que receba um número inteiro e informe se ele é par ou ímpar

/* int numero1;

Console.Write("Insira um número: ");
numero1 = int.Parse(Console.ReadLine()!);

if (numero1 % 2 == 0) 
{
    Console.WriteLine($"O número {numero1} é par");
}
else
    Console.WriteLine($"O número {numero1} é ímpar"); */

#endregion

#region Q2 - Receba a idade de uma pessoa e informe se ela é maior ou menor de idade(18 anos)

/* int idade;

Console.Write("Insira sua idade: ");
idade = int.Parse(Console.ReadLine()!);

if (idade >= 18)
{
    Console.WriteLine("Você é de maior de idade");
}
else
{
    Console.WriteLine("Você é de menor de idade");
}
 */


#endregion

#region Q3 - Peça uma nota de 0 a 10 e informe se o aluno foi aprovado

 /* int nota;

Console.Write("Insira a nota do aluno: ");
nota = int.Parse(Console.ReadLine()!);

if (nota >= 7)
{
    Console.WriteLine("Aprovado");
}
else
{
    Console.WriteLine("Reprovado");
} 
 */
#endregion

#region Q4 - Receba um número e informe se ele é positivo, negativo ou zero

/* int numero;

Console.Write("Insira um número para verificar se ele é positivo, negativo ou zero: ");
numero = int.Parse(Console.ReadLine()!);

if (numero > 0)
{
    Console.WriteLine("Seu número é positivo");
}
else if (numero < 0)
{
    Console.WriteLine("Seu número é negativo");
}
else
{
    Console.WriteLine("Seu número é zero");
} */


#endregion

#region Q5 - Leia um caractere e informe se ele é uma vogal (a, e, i, o, u)

/* char vogal = 'a';

Console.Write("Insira uma caractere: ");
vogal = char.Parse(Console.ReadLine()!);

switch ("a")
{
    case "a":
        Console.WriteLine("A caractere é uma vogal");
        break;
    case "e":
        Console.WriteLine("A caractere é uma vogal");
        break;
    case "i":
        Console.WriteLine("A caractere é uma vogal");
        break;
    case "o":
        Console.WriteLine("A caractere é uma vogal");
        break;
    case "u":
        Console.WriteLine("A caractere é uma vogal");
        break;
    default:
        Console.WriteLine("A caractere não é uma vogal");
        break;

}
 */

#endregion

#region Q6 - Leia um número de 1 a 7 e informe o dia da semana correspondente

/* 
string numero = "1";

Console.Write("Insira um número de 1 a 7: ");
numero = Console.ReadLine()!;

switch (numero)
{
    case "1":
        Console.WriteLine("Domingo");
        break;
    case "2":
        Console.WriteLine("Segunda feira");
        break;
    case "3":
        Console.WriteLine("Terça feira");
        break;
    case "4":
        Console.WriteLine("Quarta feira");
        break;
    case "5":
        Console.WriteLine("Quinta feira");
        break;
    case "6":
        Console.WriteLine("Sexta feira");
        break;
    case "7":
        Console.WriteLine("Sabado");
        break;
    default:
        Console.WriteLine("Parece que deu erro, insira número de 1 a 7");
        break;

}
 */
#endregion

#region Q7 - Receba dois números e informe qual é o maior

/* int numero1;
int numero2;

Console.Write("Insira primeiro número: ");
numero1 = int.Parse(Console.ReadLine()!);

Console.Write("Insira segundo número: ");
numero2 = int.Parse(Console.ReadLine()!);

if (numero1 > numero2)
    Console.WriteLine($"O número {numero1} é maior que {numero2}");
else
    Console.WriteLine($"O número {numero1} é menor que {numero2} ");
 */
#endregion

#region Q8 - Leia um número e informe se ele está entre o 10 e 20(inclusive)

/* int numero;

Console.Write("Insira um número: ");
numero = int.Parse(Console.ReadLine()!);

if (numero >=10 && numero <=20)
{
    Console.WriteLine("Ele está entre o 10 e 20");
}
else
    Console.WriteLine("não está entre o 10 e 20");
 */

#endregion

#region Q9 - Receba um caractere e informe se ele é uma letra maiúscula

/* char letra;

Console.Write("Insira uma letra: ");
letra = char.Parse(Console.ReadLine()!);

if (letra >= 'A' && letra <= 'Z')
{
    Console.WriteLine("Ele é uma letra maiúscula");
}
else
    Console.WriteLine("Ele é uma letra minúscula");
 */
#endregion

#region Q10 - Peça ao usuário um número e informe "positivo" ou "negativo" usando operador ternário

/* int numero;

Console.Write("Insira um número: ");
numero = int.Parse(Console.ReadLine()!);

if (numero > 0) 
{
    Console.WriteLine($"Esse número é positivo");
}
else
    Console.WriteLine($"Esse número é negativo"); */
#endregion