using System;

namespace MemeToNervoso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Usuário, o que você pensa sobre mim?");

            string mensagem = Console.ReadLine();
            string ToNervoso = mensagem.Remove(10) + "... Não, Pera.";
            Console.WriteLine("E sabe o que eu penso de você?");
            Console.WriteLine(ToNervoso);
            Console.WriteLine("Tô nervoso");

        }
    }
}
