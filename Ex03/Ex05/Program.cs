// Calculadora que recebe 2 numeros e apresenta + - * /


Console.WriteLine("Escreva o primeiro numero");
int numero1=int.Parse(Console.ReadLine());

Console.WriteLine("Escreva o segundo numero");
int numero2 = int.Parse(Console.ReadLine());

Console.Clear();

Console.WriteLine("+ :" + (numero1+numero2));
Console.WriteLine("- :" + (numero1 - numero2));
Console.WriteLine("* :" + (numero1 * numero2));
Console.WriteLine("/ :" + (numero1 / numero2));

// Verifica se o segundo numero é dferente de zero antes de realizar a divisão

if (numero2 != 0)
{
    Console.WriteLine("/:" + (numero1 / numero2));

}
else
    Console.WriteLine("/ : DIVISÃO POR ZERO NÃO É PERMITIDA");

Console.WriteLine("=========================");
Console.WriteLine("Os numeros são iguais? " + (numero1 == numero2));
Console.WriteLine("numero1 é maior numero2? " + (numero1 > numero2));
Console.WriteLine("numero1 é menor numero2? " + (numero1 < numero2));
Console.WriteLine("numero1 é maior ou igual numero2? " + (numero1 >= numero2));
Console.WriteLine("numero1 é menor ou igual numero2? " + (numero1 <= numero2));







