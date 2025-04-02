using System.Globalization;

// variaveis
double largura;
double comprimento, area, valorMetro, valorTerreno;
//pode fazer em mesma linha

//Entrada
largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
valorMetro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

// Calculo
area = largura * comprimento;

valorTerreno = area * valorMetro;

// saida
Console.WriteLine("AREA - " + area.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("PRECO = " + valorTerreno.ToString("F2", CultureInfo.InvariantCulture));
//F2 duas casas decimais
//CultureInfo.InvariantCulture serve para trocar , por . 
