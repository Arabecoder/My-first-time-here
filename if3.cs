using System; 

namespace Diagrama

{ 
	class program

	{
		static void Main(string[] args)

		{
			Console.WriteLine("INGRESE UN NUMERO DIFERENTE A CERO:");

           Console.WriteLine("Ingrese un numero: ");

          double numero = double.Parse(Console.ReadLine());

          double num = numero*10; 

          if(numero==0){

          	Console.WriteLine("ERROR ERROR ERROR NO PUEDE SER IGUAL A CERO PUTITO");
          }else if(numero !=0){

          	Console.WriteLine("Resultado: " +num);
          }

          Console.ReadKey();

          
		}

	}

}