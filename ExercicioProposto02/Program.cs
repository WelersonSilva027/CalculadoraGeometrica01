using System.Diagnostics.SymbolStore;
using System;
using System.Globalization;

double B, A, Area, Perimetro, Diagonal;

Console.WriteLine("Olá Seja Bem Vindo(a)!");
Console.ReadLine();

Console.WriteLine("Aqui, iremos calcular formas geométricas.");
Console.ReadLine();

Console.WriteLine("Vamos Inicar com um Retângulo...");
Console.ReadLine();

Console.WriteLine("Daremos os valores da Area, Perimetro e da Diagonal calculando os valores da Base e Altura");


Console.WriteLine("Digite um valor para a base do seu rentângulo:");
B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Digite agora um valor para a altura do seu retângulo:");

A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Area = B * A;
Perimetro = 2 * B + 2 * A;
Diagonal = Math.Sqrt(Math.Pow(B, 2.0) + Math.Pow(A, 2.0));

 Console.WriteLine("O Tamanho da Area é: " + Area.ToString("F4"), CultureInfo.InvariantCulture);
 
Console.WriteLine("O Tamanho do Perimetro é: " + Perimetro.ToString("F4"), CultureInfo.InvariantCulture);

Console.WriteLine("O Tamanho da Diagonal é: " + Diagonal.ToString("F4"), CultureInfo.InvariantCulture);

Console.ReadLine();

//Como calcular um perimetro com os dados de Base e Altura
//Como calcular uma diagonal