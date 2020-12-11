using System;
namespace _POO_Class_Polimorfismo_main
{
    public class Funcionario
    {
        //LISTAGEM
        public string [] lista = { "Yuri", "Eduardo", "Paulo", "Tsuka", "Thiago"};
            
       //MOSTRAR
       public void Mostrar(){

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
       }

       //MOSTRAR2
       public void Mostrar(int indice){
           Console.WriteLine(lista[indice]);
       }

       //MOSTRAR3
        public void Mostrar(string busca){
            
            foreach (var item in lista)
            {
               if (item == busca)
               {
                    Console.WriteLine("Resultado da busca -- "+ item);
               }
            }
       }
    }
}