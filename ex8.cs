using System;
class Tádoidomem{
    static void Main(){
        Console.WriteLine("Hello World seus doidos, pega a visão do dev programando!!\n");

        Console.WriteLine("\nDigite um número corresponde a um ano, para que meu programa a horrível ligação entre esses dois fatos distintos\n");
        Console.ForegroundColor = ConsoleColor.Black;
        int ano = Convert.ToInt32(Console.ReadLine());
        Console.ResetColor();

        if(ano % 4 == 0 ){ 
            Console.WriteLine("\n Esse ano é bissexto");
        }
        else{
            Console.WriteLine("Esse ano não é bissexto");
        }
    }
}