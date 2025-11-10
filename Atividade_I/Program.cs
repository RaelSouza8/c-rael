#region Q1 - leia dois número inteiros, calcule a diferença e exiba o resultadod

/* int primeiroNumero;
int segundoNumero;
int diferença;

Console.Write("Insira primeiro número inteiro: ");
primeiroNumero = int.Parse(Console.ReadLine()!);

Console.Write("Insira o segundo número inteiro: ");
segundoNumero = int.Parse(Console.ReadLine()!);

diferença = primeiroNumero - segundoNumero;

Console.WriteLine($"A diferença do número {primeiroNumero} e {segundoNumero} é igual a {diferença}");
 */
#endregion

#region Q2 - leia um número decimal, calcule o dobro dele e mostre o resultado com 2 casas decimais



/* decimal primeiroNumero;
decimal dobro;

Console.WriteLine("Insira número decimal: ");
primeiroNumero = decimal.Parse(Console.ReadLine()!);

dobro = primeiroNumero * 2;

Console.WriteLine($"O dobro do número decimal {primeiroNumero} é {dobro:F2}");
 */
#endregion

#region Q3 - leia um número float. calcule a metade desse número e exiba o resultado



/* float primeiroNumeroo;
float metade;

Console.WriteLine("Insira número float: ");
primeiroNumeroo = float.Parse(Console.ReadLine()!);

metade = primeiroNumeroo / 2;

Console.WriteLine($"A metade do número {primeiroNumeroo} é {metade}"); */

#endregion

#region Q4 - leia dois números inteiros, calcule o produto e mostre o resultado 

/* int primeiroNumero;
int segundoNumero;
int multiplicação;

Console.WriteLine("Insira primeiro número inteiro: ");
primeiroNumero = int.Parse(Console.ReadLine()!);

Console.WriteLine("Insira o segundo número inteiro: ");
segundoNumero = int.Parse(Console.ReadLine()!);

multiplicação = primeiroNumero * segundoNumero;

Console.WriteLine($"O produto do número {primeiroNumero} e {segundoNumero} é igual a {multiplicação}"); */

#endregion

#region Q5 - leia um número inteiro e calcule seu cubo(elevar ao cubo). Exiba o resultado

/* int primeiroNumero;
int cubo;

Console.Write("Insira um número inteiro: ");
primeiroNumero = int.Parse(Console.ReadLine()!);

cubo = primeiroNumero * primeiroNumero * primeiroNumero;

Console.Write($"O número {primeiroNumero} elevado ao cubo é {cubo}");
 */
#endregion

#region Q6 - Leia dois números double e calcule o resto da divisão do primeiro pelo segundo. Exiba o resultado

double primeiroNumero;
double segundoNumero;
double divisao;
double modulo;

Console.Write("Insira o primeiro número double: ");
primeiroNumero = double.Parse(Console.ReadLine()!);

Console.Write("Insira o segundo número double: ");
segundoNumero = double.Parse(Console.ReadLine()!);

divisao = primeiroNumero / segundoNumero;
modulo = primeiroNumero % segundoNumero;
Console.Write($"A divisão do primeiro número {primeiroNumero} e do segundo número {segundoNumero} é {divisao}");
Console.Write($"\nA divisão do primeiro número {primeiroNumero} e do segundo número {segundoNumero} é {modulo}");


#endregion