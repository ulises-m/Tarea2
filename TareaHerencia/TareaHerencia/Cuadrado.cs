
using System;

namespace TareaHerencia
{

	public class Cuadrado:Figura//Herencia de la clase figura
	{
			private double _lado;//variable global _lado
		public Cuadrado( double lado )
		{
		
			this._lado = lado; 
		
		}
		
		public override void Dibujar()//se sobreescribe el metodo Dibujar de la clase base Figura
		{
			Console.WriteLine("Dibujando Cuadrado");
		}
		
		public override double Area()
		{
			return  Math.Pow(this._lado,2);//Area del cuadrado funciones de la libreria Math
		}
	}
}
