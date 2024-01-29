using System;

namespace programa_4 
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int numero1 = 0;
			int numero2 = 0;

            Console.WriteLine("Este programa determinara si el primer numero es mayor al segundo");
            Console.WriteLine("y dependiendo de se tomara diferente accion, digite el primer numero: ");

			try
			{
				numero1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("digite el segundo numero");
				numero2 = Convert.ToInt32(Console.ReadLine());

				if (numero1 > numero2)
				{
                    Console.WriteLine($"la suma de {numero1} y {numero2} es {numero1 + numero2} ");
					Console.WriteLine($"la resta de {numero1} y {numero2} es {numero1 - numero2} ");

				}else if(numero1 < numero2)
				{
					Console.WriteLine($"El producto de {numero1} y {numero2} es {numero1 * numero2} ");
					
					Console.WriteLine($"La division de {numero1} y {numero2} es {numero1 / numero2} ");
				}
				else
				{
					Console.WriteLine("La operacion no es valida");
				}

            }
            catch (Exception ex)
			{
				Console.WriteLine($"Ha ocurrido un error:{ex.Message}");

			}
        }
	}
}