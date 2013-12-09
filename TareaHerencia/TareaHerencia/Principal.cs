
using System;

namespace TareaHerencia
{
 class Principal
	{
		static void Main (string[] args){
	
 		var cuadrado = new Cuadrado(4.0);//instancia de la clase cuadrado que hereda de figura con parametro double
 		cuadrado.Dibujar(); //metodo sobreescrito de la clase Cuadrado heredado de la clase Figura
 		
 		Console.WriteLine("El area del cuadrado es:{0}",cuadrado.Area());
	
 		
 		var circulo = new Circulo(4.0);//instancia de la clase circulo que hereda de Figura con parametro double
 		circulo.Dibujar();//metodo sobreescrito de la clase Circulo heredado de la clase Figura
 		
 		Console.WriteLine("El area del circulo es:{0}",circulo.Area());
	
 		Console.ReadKey();
 	}
  }

 }
