#region Q1 Verificar se um número é positivo ou negativo

/* int numero;

Console.Write("Digite um número inteiro: ");
numero = int.Parse(Console.ReadLine()!);

if (numero > 0)
{
    Console.WriteLine("Esse número é positivo");
}
else if (numero < 0)
{
    Console.WriteLine("Esse número é negativo");
}
else
{
    Console.WriteLine("Esse número é zero");
} */

#endregion

#region Q2 verificar se um aluno  está aprovado ou reprovado

/* int nota;


Console.Write("Digite a nota do aluno de 0 até 10: ");
nota = int.Parse(Console.ReadLine()!);

if (nota >= 7)
{
    Console.WriteLine("Aprovado");
}
else
{
    Console.WriteLine("Reprovado");
} */

#endregion


#region Q3 identificar o dia da semana pelo número


string dia = "1";


Console.Write("Digite algum número de 1 a 7: ");
dia = Console.ReadLine()!;


switch (dia)
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
        Console.WriteLine("Sábado");
        break;
    default:
        Console.WriteLine("Insira NÚMERO de 1 a 7, mano, obrigado e de nada");
        break;
}

#endregion