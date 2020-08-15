/*Proyecto; Damage Control.
Equipo N°5. Integrantes:
Yurisbellys Brizuela. C.I: 27.142.239
Franklin Camacho. C.I: 26.796.912
Jesús Leal. C.I: 26.561.030
Marihec Miranda. C.I: 26.120.075
Gustavo Rivero. C.I: 26.772.857*/

/*Comandos: Archivo que contiene ciertos comandos básicos como validaciones, mensajes emergentes, entre otros.
Todos los comandos realizados en el archivo se encuentran explicados por medio de comentarios.*/

using System;
using Gtk;

namespace Comandos
{
	public class Basicos
	{
		public Basicos ()
		{
		}

		//Valida que todos los datos ingresados en un entry sean de tipo "entero".
		public void validarEntero(Entry ent)
		{
			string cadena = ent.Text;
			int x;

			for (x = 0; x < cadena.Length; x++) {
				//Valida el uso de caracteres numéricos
				if (cadena [x] >= '0' && cadena [x] <= '9') {
				} 
				//Impide el uso de caracteres erróneos
				else
					ent.Text = cadena.Substring (0, cadena.Length - 1);
			}
		}

		//Valida que todos los datos ingresados en un entry sean de tipo "decimal".
		public void validarDecimal(Entry ent)
		{
			string cadena = ent.Text;
			int x, c = 0;

			for (x = 0; x < cadena.Length; x++) {
				//Valida el uso de caracteres numéricos y "," o "."
				if (cadena [x] >= '0' && cadena [x] <= '9' || cadena [x] == '.' || cadena [x] == ',') {
					//Valida el uso de un único "." o ","
					if (cadena [x] == ',' || cadena [x] == '.'){
						//Impide el uso de otro "." o ","
						if (c >= 1)
							ent.Text = cadena.Substring (0, cadena.Length - 1);
						else if (cadena [x] == ',')
							//Valida el uso de ","
							c++;
						//Valida el uso de "." y sustituye por ","
						else if (cadena [x] == '.') {
							ent.Text = cadena.Substring (0, cadena.Length - 1) + ',';
							c++;
						}
							
					}

				} 
				//Impide el uso de caracteres erróneos
				else 
					ent.Text = cadena.Substring (0, cadena.Length - 1);
			}
		}

		//Valida que todos los datos ingresados en un entry sean de tipo "alfabéticos".
		public void validarLetras(Entry ent)
		{
			string cadena = ent.Text;
			int x;

			for (x = 0; x < cadena.Length; x++) {
				//Valida el uso de caracteres alfabéticos
				if (cadena [x] >= 'A' && cadena [x] <= 'Z' || cadena [x] == ' ' || cadena [x] >= 'a' && cadena [x] <= 'z') {
				} 
				//Impide el uso de caracteres erróneos
				else 
					ent.Text = cadena.Substring (0, cadena.Length - 1);
			}
		}

		//Valida que todos los datos ingresados en un entry sean de tipo "alfanuméricos".
		public void validarAlfanumerico(Entry ent)
		{
			string cadena = ent.Text;
			int x;

			for (x = 0; x < cadena.Length; x++) {
				//Valida el uso de caracteres apropiados
				if (cadena [x] >= 'A' && cadena [x] <= 'Z' || cadena [x] == ' ' || cadena [x] >= 'a' && cadena [x] <= 'z' || cadena[x] >= '0' && cadena[x] <= '9'){
				} 
				//Impide el uso de caracteres erróneos
				else 
					ent.Text = cadena.Substring (0, cadena.Length - 1);
			}
		}

		//Valida que todos los datos ingresados en un entry sean de tipo "alfanuméricos".
		public void validarDireccion(Entry ent)
		{
			string cadena = ent.Text;
			int x;

			for (x = 0; x < cadena.Length; x++) {
				//Valida el uso de caracteres apropiados
				if (cadena [x] >= 'A' && cadena [x] <= 'Z' || cadena [x] == ',' || cadena [x] == '.' ||cadena [x] == ' ' || cadena [x] >= 'a' && cadena [x] <= 'z' || cadena[x] >= '0' && cadena[x] <= '9') {
				} 
				//Impide el uso de caracteres erróneos
				else 
					ent.Text = cadena.Substring (0, cadena.Length - 1);
			}
		}

		//Valida que todos los datos ingresados en un entry se ingrese un "RIF".
		public void validarRif(Entry ent)
		{
			string cadena = ent.Text;
			int x, c = 0;

			for (x = 0; x < cadena.Length; x++) {
				//Valida caracteres numéricos y guión
				if (cadena [x] >= '0' && cadena [x] <= '9' || cadena [x] == '-') {
					//Valida el uso de un único guión
					if (cadena [x] == '-')
						c++;
					//Impide el uso de otro guión
					if (c == 2)
						ent.Text = cadena.Substring (0, cadena.Length - 1);
					//Impide el uso de caracteres erróneos
					else
						ent.Text = cadena.Substring (0, cadena.Length - 1);
				} 
				//Impide el uso de un caracter erróneo
				else 
					ent.Text = cadena.Substring (0, cadena.Length - 1);
				
			}
		}

		//Valida que todos los datos ingresados en un entry se ingrese un "teléfono".
		public void validarTlf(Entry ent)
		{
			string cadena = ent.Text;
			int x, c = 0;

			for (x = 0; x < cadena.Length; x++) {
				//Valida caracteres numéricos y guión
				if (cadena [x] >= '0' && cadena [x] <= '9' || cadena [x] == '-') {
					//Valida el uso de un único guión
					if (cadena [x] == '-')
						c++;
					//Impide que se ingrese otro guión
					if (c == 2)
						ent.Text = cadena.Substring (0, cadena.Length - 1);
				} else
					//Impide el uso de caracteres erróneos
					ent.Text = cadena.Substring (0, cadena.Length - 1);
			}
		}

		//Valida que todos los datos ingresados en un entry se ingrese un "teléfono".
		public void validarTlfSinCodArea(Entry ent)
		{
			string cadena = ent.Text;
			int x;

			if(cadena.Length <= 7) {
				for (x = 0; x < cadena.Length; x++) {
					//Valida caracteres numéricos y guión
					if (cadena [x] >= '0' && cadena [x] <= '9') {
					} else
						//Impide el uso de caracteres erróneos
						ent.Text = cadena.Substring (0, cadena.Length - 1);
				}
			} else
				//Impide que se ingrese más caracteres.
				ent.Text = cadena.Substring (0, cadena.Length - 1);
		}

		//Valida que todos los datos ingresados en un entry se ingrese un "correo".
		public void validarCorreo(Entry ent)
		{
			string cadena = ent.Text;
			int x, c = 0, y = 0;

			for (x = 0; x < cadena.Length; x++) {
				//Valida caracteres
				if (cadena [x] >= 'A' && cadena [x] <= 'Z' || cadena [x] == '.' || cadena [x] >= 'a' && cadena [x] <= 'z' || cadena [x] >= '0' && cadena [x] <= '9' || cadena [x] == '@') {
					//Valida que se ingrese un solo "@"
					if (cadena [x] == '@')
						c++;
					//Valida que se ingrese un solo "."
					if (cadena [x] == '.')
						y++;
					//Impide que se ingrese otro "@" o "."
					if (c == 2 || y == 2)
						ent.Text = cadena.Substring (0, cadena.Length - 1);
				} else
					//Impide que se ingrese un caracter erróneo
					ent.Text = cadena.Substring (0, cadena.Length - 1);
			}
		}

		/*Comando que impide todo tipo de escritura en un entry.
		NOTA: Impide que se agreguen datos así sean puestos por el programa.*/
		public void impedirEscritura(Entry ent)
		{
			//Método que impide la escritura en el entry
			string cadena = ent.Text;
			ent.Text = "";
		}

		//Genera una ventana emergente para mostrar un mensaje.
		public void ventanaMensaje(string mensaje)
		{
			//Genera una ventana con mensaje personalizado
			MessageDialog md = new MessageDialog(null, DialogFlags.Modal, MessageType.Info , ButtonsType.Ok, mensaje);
			md.Run ();
			md.Destroy ();
		}

		//Genera una ventana emergente para mostrar un mensaje de error.
		public void ventanaError(string mensaje)
		{
			//Genera una ventana con mensaje personalizado de Error
			MessageDialog md = new MessageDialog (null, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, mensaje);
			md.Run ();
			md.Destroy ();
		}

		//Genera una ventana emergente para mostrar un mensaje de peligro.
		public void ventanaPeligro(string mensaje)
		{
			//Genera una ventana con mensaje personalizado de Peligro
			MessageDialog md = new MessageDialog (null, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, mensaje);
			md.Run ();
			md.Destroy ();
		}

		//Comando que muestra y a su vez lleva el comboBox señalado a la posición inicial.
		public void limpiarComboBox(ComboBox lista)
		{
			/*Lleva al ComboBox a la posición "0"
			La primera posición (La posición [0] debe ser " " o "-".*/
			lista.Active = 0;
		}

		//Comando que muestra y a su vez desactiva el checkButton señalado.
		public void limpiarCheck(CheckButton check)
		{
			//Desactiva los checkButton
			check.Active = false;
		}

		//Comando que muestra y a su vez limpia un entry señalado.
		public void limpiarEntry(Entry ent)
		{
			//Limpia contenido del entry
			ent.Text = "";
		}

		//Valida que todos los datos ingresados en un entry sean de tipo "alfanuméricos".
		public void validarCedula(Entry ent)
		{
			string cadena = ent.Text;
			int x;

			for (x = 0; x < cadena.Length; x++) {
				//Valida el uso de caracteres apropiados
				if (cadena [x] >= 'A' && cadena [x] <= 'Z' || cadena [x] == ' ' || cadena [x] >= 'a' && cadena [x] <= 'z' || cadena[x] >= '0' && cadena[x] <= '9' || cadena[x] == '-')  {
				} 
				//Impide el uso de caracteres erróneos
				else 
					ent.Text = cadena.Substring (0, cadena.Length - 1);
			}
		}
			
	}
}

