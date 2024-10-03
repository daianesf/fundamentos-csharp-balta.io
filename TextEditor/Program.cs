namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Oque você deseja fazer?");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar arquivo");
            Console.WriteLine("3 - Editar arquivo");
            Console.WriteLine("0 - Sair");
            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Escrever(); break;
                case 3: Editar(); break;
                default: Menu(); break;
            }
        }

        static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo?");
            string path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }
            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }

        static void Escrever()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
            Console.WriteLine("-----------------------");
            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Salvar(text);
        }

        static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo a ser editado?");
            string path = Console.ReadLine();

            var text = File.ReadAllText(path);
            Console.WriteLine(text);

            Console.WriteLine("\nDigite o novo texto a ser adicionado (ESC para sair)");
            Console.WriteLine("-----------------------");

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            File.WriteAllText(path, text);

            Console.WriteLine("\nArquivo editado com sucesso!");
            Console.ReadLine();
            Menu();
        }

        static void Salvar(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual caminho para salvar o arquivo e o nome do arquivo (Exemplo: C:/my_folder/my_file.txt)?");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($" Arquivo {path} salvo com sucesso!");
            Console.ReadLine();
            Menu();
        }
    }
}