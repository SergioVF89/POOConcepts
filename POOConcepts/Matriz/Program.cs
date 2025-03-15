

using Matriz;


    try
    {
        Console.Write("Ingrese orden de la matriz: ");
        int N = int.Parse(Console.ReadLine());
   
        Operaciones matrizOps = new Operaciones(N);
  
        matrizOps.MostrarMatriz();

        int sumatoria = matrizOps.CalcularSumatoria();
        Console.WriteLine($"\nLa sumatoria es: {sumatoria}");

        int mayor = matrizOps.EncontrarMayor();
        Console.WriteLine($"El valor máximo es: {mayor}");

        int menor = matrizOps.EncontrarMenor();
        Console.WriteLine($"El valor mínimo es: {menor}");
    }
    
    catch (ArgumentException ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
    


