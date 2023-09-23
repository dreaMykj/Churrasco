int AdultosComAlcool, AdultosSemAlcool, criancas, adultos, pessoas;
double carne, acompanhamentos, cerveja, refrigerante,agua;

Console.WriteLine("--- Churrasco ---");

Console.Write("Adultos (que consomem bebidas alcoólicas).......: ");
AdultosComAlcool = Convert.ToInt32(Console.ReadLine());

Console.Write("Adultos (que não consomem bebidas alcoólicas)...: ");
AdultosSemAlcool = Convert.ToInt32(Console.ReadLine());

Console.Write("Crianças........................................: ");
criancas = Convert.ToInt32(Console.ReadLine());

adultos = AdultosComAlcool + AdultosSemAlcool;
pessoas = adultos + criancas;

carne = 0.4 * adultos + 0.2 * criancas;
acompanhamentos = 0.2 * pessoas;
cerveja = 2 * AdultosComAlcool;
refrigerante = 0.5 * (AdultosSemAlcool + criancas);
agua = 0.4 * pessoas;

Console.WriteLine();

Console.WriteLine($"Carne.............: {carne:N1}kg");
Console.WriteLine($"Acompanhamentos...: {acompanhamentos:N1}kg");
Console.WriteLine($"Cerveja...........: {cerveja:N1}L");
Console.WriteLine($"Refrigerante......: {refrigerante:N1}L");
Console.WriteLine($"Água..............: {agua:N1}L");