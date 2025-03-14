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

        if (IMC < 18.5)
        {
            Console.WriteLine("Abaixo do peso");
        }
        else if (IMC >= 18.5 && IMC <= 24.9)
        {
            Console.WriteLine("Peso normal");
        }
        else if (IMC >= 25 && IMC <= 29.9)
        {
            Console.WriteLine("Excesso de Peso");
        }
        else if (IMC >= 30 && IMC <= 34.9)
        {
            Console.WriteLine("Obsidade I");
        }
        else if (IMC >= 35 && IMC <= 39.9)
        {
            Console.WriteLine("Obesidade II");
        }
        else
        {
            Console.WriteLine("Obesidade III");
        }
    }
}