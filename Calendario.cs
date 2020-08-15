/*Proyecto; Damage Control.
Equipo N°5. Integrantes:
Yurisbellys Brizuela. C.I: 27.142.239
Franklin Camacho. C.I: 26.796.912
Jesús Leal. C.I: 26.561.030
Marihec Miranda. C.I: 26.120.075
Gustavo Rivero. C.I: 26.772.857*/

//Calendario: Ventana genérica que muestra un calendario y ayuda a enviar una fecha seleccionada a algún entry.

//Se colocan las librerías a utilizar por el programa.
using System;
using Gtk;

namespace DamageControl
{
	public partial class Calendario : Gtk.Window
	{
		//Entry a utilizar.
		Entry ent;

		public Calendario(ref Entry entry) : base(Gtk.WindowType.Toplevel)
		{
			this.Build();
			ent = entry;
		}

		//Método que por medio del botón "Aceptar" permite pasar la fecha señalada al entry recibido por referencia.
		protected void OnButAceptarClicked(object sender, EventArgs e)
		{
			ent.IsEditable = true;
			ent.Sensitive = true;
			ent.Text = calendar.Date.ToString("yyyy/MM/dd");
			ent.IsEditable = false;
			this.Destroy();
		}

		//Método que por medio del botón "Cancelar" permite cerrar la ventana.
		protected void OnButCancelarClicked(object sender, EventArgs e)
		{
			this.Destroy();
		}

		protected void OnCalendarioDaySelected(object sender, EventArgs e)
		{

		}

		//Al realizar doble click, se envía el valor de la fecha seleccionada al entry pasado por referencia.
		protected void OnCalendarDaySelectedDoubleClick (object sender, EventArgs e)
		{
			ent.IsEditable = true;
			ent.Sensitive = true;
			ent.Text = calendar.Date.ToString("yyyy/MM/dd");
			ent.IsEditable = false;
			this.Destroy();
			//throw new NotImplementedException ();
		}
	}
}
