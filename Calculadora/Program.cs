namespace MeuApp
{
    public class Program
    {
        static void Main()
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que deseja fazer?");

            Console.WriteLine("");

            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("");

            Console.WriteLine("Selecione uma opção: ");
            short opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: OpcaoInvalidaMenu(); break;
            }
        }

        static void OpcaoInvalidaMenu()
        {
            Console.WriteLine("Opção inválida.");
            Console.ReadKey();
            Menu();
        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            var v1 = float.Parse(Console.ReadLine() ?? "");

            Console.WriteLine("O usuário digitou o número: " + v1);

            Console.WriteLine("Segundo valor: ");
            var v2 = float.Parse(Console.ReadLine() ?? "");

            Console.WriteLine("O usuário digitou o número: " + v2);

            var resultado = v1 + v2;

            Console.WriteLine("O resultado da soma v1 + v2 é: " + resultado);
            Console.WriteLine($"O resultado da soma v1 + v2 é: {resultado}");
            Console.WriteLine($"O resultado da soma v1 + v2 é: {v1 + v2}");

            Console.ReadKey();

            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            var v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            var v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            var resultado = v1 - v2;
            Console.WriteLine($"O resultado de v1 - v2 é: {resultado}");

            Console.ReadKey();

            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            var v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Digite o segundo valor: ");
            var v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            var resultado = v1 / v2;
            Console.WriteLine($"A divisão entre v1 e v2 é: {resultado}");

            Console.ReadKey();

            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            var v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Digite o segundo valor: ");
            var v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            var resultado = v1 * v2;
            Console.WriteLine($"O resultado entre v1 e v2 é: {resultado}");

            Console.ReadKey();

            Menu();
        }
    }
}