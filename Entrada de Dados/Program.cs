internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite o seu nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Olá, " + nome);

        Console.WriteLine("Digite sua idade: ");
        string idade = Console.ReadLine();
        Console.WriteLine(nome + "a sua idade é: " + idade + " anos ");
        int idadeInt = Convert.ToInt32(idade);

        Console.WriteLine("Pressione qualquer tecla: ");
        char TeclaPressionada = Console.ReadKey(true).KeyChar;

        string TeclaPressionadaString = Convert.ToString(Console.ReadKey(true).KeyChar);
        string TeclaPressionadaString2 = Console.ReadKey(true).KeyChar.ToString();

        Console.WriteLine("Olá " + nome + " a tecla que você pressionou foi: " + TeclaPressionada);

        Console.WriteLine("Pressione qualquer tecla para sair!");

        Console.ReadKey();
    }
}