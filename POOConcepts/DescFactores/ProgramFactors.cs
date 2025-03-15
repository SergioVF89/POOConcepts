using DescFactores;

try
{
    
    Console.Write("Ingrese el número a descomponer: ");
    int num = int.Parse(Console.ReadLine());
    Factores factoresPrimos = new Factores(num);
    List<int> factores = factoresPrimos.DescomponerEnFactores();

    // Mostrar los factores 
    factoresPrimos.MostrarFactores(factores);
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}