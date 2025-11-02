using System.Numerics;

namespace DesafioNivel1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine()!;

        Console.WriteLine($"Olá, {nome}! Seja muito bem-vindo!");
        Console.WriteLine("");

        Console.WriteLine("Digite seu sobrenome:");
        string sobrenome = Console.ReadLine()!;

        string nomeCompleto = nome + " " + sobrenome;   
        Console.WriteLine($"Seu nome completo é: {nomeCompleto}");
        Console.WriteLine("");

        Console.WriteLine("Agora digite dois numeros para realizarmos calculos");
        Console.WriteLine("Numero 1");
        double numero1 = Convert.ToDouble(Console.ReadLine()!);
        Console.WriteLine("Numero 2");
        double numero2 = Convert.ToDouble(Console.ReadLine()!);

        Console.WriteLine($"A soma de dois números: {numero1 + numero2}");
        Console.WriteLine($"A subtração entre os dois números: {numero1 - numero2}");
        Console.WriteLine($"A multiplicação entre os dois números: {numero1 * numero2}");

        if(numero2 == 0)
        {
            Console.WriteLine("Nao é possivel fazer a divisão por zero");
        } else
        {
            Console.WriteLine($"A divisão entre os dois números: {numero1 / numero2}");
        }

        double media = (numero1 + numero2) / 2;
        Console.WriteLine($"A média entre os dois números é :{media} ");
        Console.WriteLine("");

        Console.WriteLine("Digita uma ou mais palavras para ser exibido a quantidade de caracteres tem");
        string palavras = Console.ReadLine()!;

        int quantidadeCaracteres = 0;
        foreach (var letra in palavras)
        {
            if(char.IsLetter(letra))
            {
                quantidadeCaracteres++;
            }
        }

        Console.WriteLine($"A quantidade de caracteres digitados é: {quantidadeCaracteres}");
        Console.WriteLine("");

        Console.WriteLine("Digite a placa de um veículo para o programa verifica se a placa é válida");
        string placa = Console.ReadLine()!.ToUpper();

        if (!VerificarQuantidadeCaracteresPlaca(placa))
            Console.WriteLine("A placa não possui 7 caracteres");

        if (!VerificarSeOsTresPrimeirosNumerosSaoLetras(placa))
            Console.WriteLine("Os três primeiros caracteres não são letras");

        if (!VerificarSeOsQuatroUltimosNumerosSaoDigitos(placa))
            Console.WriteLine("Os quatro últimos caracteres não são dígitos");

        if (VerificarQuantidadeCaracteresPlaca(placa) &&
            VerificarSeOsTresPrimeirosNumerosSaoLetras(placa) &&
            VerificarSeOsQuatroUltimosNumerosSaoDigitos(placa))
        {
            Console.WriteLine("A placa é válida");
        }
        else
        {
            Console.WriteLine("A placa é inválida");
        }

        Console.WriteLine("");
        Console.WriteLine("Esse programa irá exibir a data atual em diferentes formatos");
        DateTime dataAtual = DateTime.Now;
        Console.WriteLine($"Data atual (dd/MM/yyyy H:m:s): {dataAtual.ToString("dd/MM/yyyy H:m:s")}");
        Console.WriteLine($"Data atual (formato curto): {dataAtual.ToShortDateString()}");
        Console.WriteLine($"Data atual (apenas a hora): {dataAtual.Hour}");
        Console.WriteLine($"Data atual (formato longo): {dataAtual.ToLongDateString()} {dataAtual.ToLongTimeString()}");

    }

    public static bool VerificarQuantidadeCaracteresPlaca(string placa)
    {
        return placa.Length == 7;
    }

    public static bool VerificarSeOsTresPrimeirosNumerosSaoLetras(string placa)
    {
        for (int i = 0; i < 3; i++)
        {
            if (!char.IsLetter(placa[i]) || char.IsNumber(placa[i]))
                return false;
        }
        return true;
    }

    public static bool VerificarSeOsQuatroUltimosNumerosSaoDigitos(string placa)
    {
        for (int i = 3; i < 7; i++)
        {
            if (!char.IsNumber(placa[i]) || char.IsLetter(placa[i]))
                return false;
        }
        return true;
    }
}