namespace DataEntryInCShap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string name = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o seu ultimo nome, idade e altuta (na mesma linha)");
            string[] vet = Console.ReadLine().Split(' ');

            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(price);
            Console.WriteLine(vet[0]);
            Console.WriteLine(vet[1]);
            Console.WriteLine(vet[2]);
        }
    }
}