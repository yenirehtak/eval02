using System;
namespace Numeros
{
	public class Numero
	{
		private int[,] tabla;
		public void CargarTabla()
        {
			tabla = new int[4, 5];
			Console.WriteLine("Ingresa los componentes: ");
			for (int j=0;j< 4; j++)
            {
				for (int k = 0; k < 5; k++)
                {					
					tabla[j, k] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
		public void ImprimirTabla()
		{
			Console.WriteLine("Los componentes son ");
			for (int j = 0; j < 4; j++)
			{
				for (int k = 0; k < 5; k++)
				{
					Console.Write("\n");
					Console.Write(tabla[j,k]+" ");
				}
			}
			Console.ReadKey();
		}
	}
}

