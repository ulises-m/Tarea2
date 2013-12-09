
using System;

namespace TareaHerencia
{

	public class Circulo:Figura//Herencia de la clase Figura
	{
		private double _radio;//variable global _radio 
		public Circulo( double radio )
		{
			this._radio = radio;
		}
		
	public override void Dibujar()//se sobrescribe el metodo abstracto Dibujar de la clase base Figura
	{Console.WriteLine("\nDibujando Circulo");
	}
		
		public override double Area()
		{
			return Math.PI*Math.Pow(this._radio,2);//Area del circulo funciones de la libreria Math
		}
	}
}
