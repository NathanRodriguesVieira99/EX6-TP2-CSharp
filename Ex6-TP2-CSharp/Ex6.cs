class Ex6
{
    static void Main()
    {
        // dessa forma le o que esta no input
        Console.WriteLine("Informe seu peso: ");
        string pesoInformado = Console.ReadLine();

        // aqui valido se o peso é valido
        if (!double.TryParse(pesoInformado, out double peso) || peso <= 0)
        {
            Console.WriteLine("Peso inválido");
            return;
        }

        // dessa forma le o que esta no input
        Console.WriteLine("Informe sua altura ");
        string alturaInformada = Console.ReadLine();

        // aqui valido se altura é valida
        if (!double.TryParse(alturaInformada, out double altura) || altura <= 0)
        {
            Console.WriteLine("Altura inválida");
            return;
        }

        // calculo do IMC
        double IMC = peso / (altura * altura);
        Console.WriteLine($"Seu IMC: {IMC:F2}");
    }
}