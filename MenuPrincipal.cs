/*Proyecto; Damage Control.
Equipo N°5. Integrantes:
Yurisbellys Brizuela. C.I: 27.142.239
Franklin Camacho. C.I: 26.796.912
Jesús Leal. C.I: 26.561.030
Marihec Miranda. C.I: 26.120.075
Gustavo Rivero. C.I: 26.772.857*/

//MenuPrincipal: Ventana que contiene botones que permiten dirigirse al resto de ventanas existentes.

//Se colocan las librerías a utilizar por el programa.
using System;
using Gtk;
using System.Timers;

//Librerías que facilitan la elaboración del programa.
using Comandos;

namespace DamageControl
{
	public partial class MenuPrincipal : Gtk.Window
	{
		ConexBD con;

		//Variables que se usará para enviar a las clases actualizaciones y reportes
		string id;
		int tipoUsuario;

		/*El constructor principal recibe como parámetro el tipo de usuario que, permitirá que cada
		usuario, dependiendo de los permisos que posea, pueda realizar sus actividades correspondientes.*/
		public MenuPrincipal (string usuario, int tipoU) : base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
			con = new ConexBD (this);
			permisosUsuario (tipoU);
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
			labUsuario.UseMarkup = true;
			labUsuario.Text = usuario;
			id = usuario;
		}

		//Método que habilita los botones del menú para que cada usuario realice sus actividades según su tipo de Usuario.
		protected void permisosUsuario (int tipoU)
		{
			//Usuario tipo 1: Actualización de datos.
			if(tipoU == 1)
			{
				tipoUsuario = 1;
				butActualizar.Sensitive = true;
				butReportes.Sensitive = false;
			}

			//Usuario tipo 2: Reportes.
			else if (tipoU == 2)
			{
				tipoUsuario = 2;
				butActualizar.Sensitive = false;
				butReportes.Sensitive = true;
			}

			//Usuario tipo 3: (Administrador) posee los permisos del Usuario tipo 1 y del Usuario tipo 2.
			else if (tipoU == 3)
			{
				tipoUsuario = 3;
				butActualizar.Sensitive = true;
				butReportes.Sensitive = true;
			}
		}

		//Método que por medio del botón "Salir" permite cerrar la Aplicación.
		protected void OnButSalirClicked (object sender, EventArgs e)
		{
			//Validación para cerrar el programa.
			MessageDialog md;
			md = new MessageDialog (null, DialogFlags.Modal, MessageType.Question, ButtonsType.YesNo, "¿Desea cerrar el programa?");
			ResponseType respuesta = (ResponseType)md.Run ();
			if (respuesta == ResponseType.Yes) {
				md.Destroy ();
				Application.Quit ();
			}
			else {
				md.Destroy ();
			}
			//throw new NotImplementedException ();
		}

		//Método que por medio del botón "Cerrar Sesión" permite volver al Login.
		protected void OnButCerrarSesionClicked (object sender, EventArgs e)
		{
			//Botón que realiza la función de regresar al login

			//Se declara el objeto para el cuadro de mensaje
			MessageDialog md;

			//Se crea el objeto para el cuadro de mensaje
			md = new MessageDialog (null, DialogFlags.Modal, MessageType.Question, ButtonsType.YesNo, "¿Desea cerrar sesión?");

			//Se crea el objeto para la decisión tomada por el usuario y se ejecuta el cuadro de mensaje
			ResponseType respuesta = (ResponseType)md.Run ();

			//Caso afirmativo para el ResponseType
			//Destruye el cuadro de mensaje y ejecuta la siguiente función
			if (respuesta == ResponseType.Yes) {
				md.Destroy ();

				//Cierra la ventana actual y muestra la del login
				Login log = new Login ();
				log.Show ();
				this.Hide ();
			}
			else {
				//Caso negativo para el ResponseType
				//Destruye el cuadro de mensaje y se mantiene en la ventana actual
				md.Destroy ();
			}
			//throw new NotImplementedException ();
		}

		//Método que por medio del botón "Actualizar" se abre la ventana para Actualizaciones.
		protected void OnButActualizarClicked (object sender, EventArgs e)
		{
			Actualizaciones act = new Actualizaciones (id, tipoUsuario);
			act.Show ();
			this.Hide ();
			//throw new NotImplementedException ();
		}

		//Método que por medio del botón "Reportes" se abre la ventana para los respectivos Reportes.
		protected void OnButReportesClicked (object sender, EventArgs e)
		{
			Reportes rep = new Reportes (id, tipoUsuario);
			rep.Show ();
			this.Hide ();

			//throw new NotImplementedException ();
		}

		//Muestra la ventana de InfoDeUsuario que contiene la información de la empresa y del usuario que está conectado.
		protected void OnButInfoUsuarioClicked (object sender, EventArgs e)
		{
			InfoDeUsuario info = new InfoDeUsuario (id, tipoUsuario);
			info.Show ();

			//throw new NotImplementedException ();
		}
	}

}

