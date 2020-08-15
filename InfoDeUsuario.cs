/*Proyecto; Damage Control.
Equipo N°5. Integrantes:
Yurisbellys Brizuela. C.I: 27.142.239
Franklin Camacho. C.I: 26.796.912
Jesús Leal. C.I: 26.561.030
Marihec Miranda. C.I: 26.120.075
Gustavo Rivero. C.I: 26.772.857*/

//InfoDeUsuario: Ventana que muestra la información de la empresa y del usuario que está conectado.

//Se colocan las librerías a utilizar por el programa.
using System;
using Gtk;
using System.Timers;

//Librerías que facilitan la elaboración del programa.
using Comandos;

namespace DamageControl
{
	public partial class InfoDeUsuario : Gtk.Window
	{

		public InfoDeUsuario (string usuario, int tipoU) : base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
			indicadorPermisos (tipoU);
			indicadorTipoU (tipoU);
			idUsuario (usuario);

			//Se crea el objeto de temporizador.
			Timer fechaActual = new Timer();
			//Se le da formato de fecha actual al labFecha.
			labFecha.Text = Convert.ToString(DateTime.Now);
			//Se configura la fecha.
			fechaActual.Interval = 1000;
			fechaActual.Elapsed += new ElapsedEventHandler(fecha);
			fechaActual.Enabled = true;
		}

		//Método que asigna fecha al labFecha.
		protected void fecha(object sender, ElapsedEventArgs e)
		{
			labFecha.Text = Convert.ToString(DateTime.Now);
		}

		//Método que asigna el nombre de usuario al labUsuario.
		protected void idUsuario(string usuario)
		{
			labUsuario.Text = usuario;
		}

		//Método que asigna al labPermisosIndicador la información sobre los permisos que tiene el usuario conectado.
		public void indicadorPermisos (int tipoU)
		{
			if (tipoU == 1)
				labPermisosIndicador.Text = "Actualizaciones.";
			if (tipoU == 2)
				labPermisosIndicador.Text = "Reportes.";
			if (tipoU == 3)
				labPermisosIndicador.Text = "Actualización / Reportes.";
		}

		//Método que asigna al labTipoUsuarioIndicador la información sobre los permisos que tiene el usuario conectado.
		public void indicadorTipoU (int tipoU)
		{
			if (tipoU == 1)
				labTipoUsuarioIndicador.Text = "Editor de información.";
			if (tipoU == 2)
				labTipoUsuarioIndicador.Text = "Generador de reportes.";
			if (tipoU == 3)
				labTipoUsuarioIndicador.Text = "Administrador.";
		}

		//Método que por medio del botón "Cerrar" permite cerrar esta ventana.
		protected void OnButCerrarClicked (object sender, EventArgs e)
		{
			this.Destroy ();

			//throw new NotImplementedException ();
		}
	}
}

