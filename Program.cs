//Proyecto; Damage Control.
//Equipo N°5. Integrantes:
//Yurisbellys Brizuela. C.I: 27.142.239
//Franklin Camacho. C.I: 26.796.912
//Jesús Leal. C.I: 26.561.030
//Marihec Miranda. C.I: 26.120.075
//Gustavo Rivero. C.I: 26.772.857

/*Cada archivo utilizado en el programa se encuentra explicado por medio de comentarios, con el fin de
facilitar a cualquier persona al entendimiento del código del mismo.*/

//Program: Archivo principal e imprescindible para el funcionamiento del programa.

//NOTA: No tocar.
using System;
using Gtk;

namespace DamageControl
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			Login win = new Login ();
			win.Show ();
			Application.Run ();
		}
	}
}
