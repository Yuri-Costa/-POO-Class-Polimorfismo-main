using System;

namespace _POO_Class_Polimorfismo_main
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine("Listagem");
            Console.ForegroundColor= ConsoleColor.Cyan;
            f.Mostrar();
            Console.ForegroundColor= ConsoleColor.White;
            Console.WriteLine("--------------------------");
            Console.ForegroundColor= ConsoleColor.Yellow;
            f.Mostrar("Yuri"); 
            Console.ForegroundColor= ConsoleColor.White;
            Console.WriteLine("--------------------------");
            Console.ForegroundColor= ConsoleColor.Magenta;
            f.Mostrar(2);
        }
    }
}
