namespace Calculadora
{
    class Program
    {
        public static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            try
            {
                Console.WriteLine("Calculadora da Daiane");
                Console.WriteLine("O que deseja fazer?");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtracao");
                Console.WriteLine("3 - Multiplicacao");
                Console.WriteLine("4 - Divisao");
                Console.WriteLine("5 - Sair");

                Console.WriteLine("-----------");
                Console.WriteLine("Selecione uma opcao: ");
                short res = short.Parse(Console.ReadLine());

                switch (res)
                {
                    case 1: Soma(); break;
                    case 2: Subtracao(); break;
                    case 3: Multiplicacao(); break;
                    case 4: Divisao(); break;
                    case 5: Environment.Exit(0); break;
                    default: Menu(); break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Você escolheu uma opcao do Menu invalida");
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
        }

        static void Soma()
        {
            Console.Clear();
            float[] numeros = ReadValuesFromConsole();

            float resultado = numeros[0] + numeros[1];
            //Console.WriteLine("O resultado da soma é " + resultado);
            Console.WriteLine($"\nO resultado da soma é {resultado}");
            // Console.WriteLine($"O resultado da soma é {v1+v2}");
            //Console.WriteLine("O Resultado da soma é " + (v1+v2));

            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();
            float[] numeros = ReadValuesFromConsole();

            float resultado = numeros[0] - numeros[1];
            Console.WriteLine($"\nO resultado da subtracao é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            float[] numeros = ReadValuesFromConsole();

            float resultado = numeros[0] * numeros[1];
            Console.WriteLine($"\nO resultado da multiplicacao é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();
            float[] numeros = ReadValuesFromConsole();

            if (numeros[1] == 0)
            {
                Console.WriteLine("\nNão é possível dividir um numero por 0!");
            }
            else
            {
                float resultado = numeros[0] / numeros[1];
                Console.WriteLine($"\nO resultado da divisao é {resultado}");
            }

            Console.ReadKey();
            Menu();
        }

        static float[] ReadValuesFromConsole()
        {
            try
            {
                Console.WriteLine("Primeiro valor: ");
                float firstValue = float.Parse(Console.ReadLine());

                Console.WriteLine("Segundo valor: ");
                float secondValue = float.Parse(Console.ReadLine());

                float[] readNumber = [firstValue, secondValue];

                return readNumber;
            }
            catch (Exception)
            {
                Console.WriteLine("Numero inválido, tente novamente!");
                Console.ReadKey();
                Console.Clear();
                Menu();
                return [];
            }
        }
    }
}