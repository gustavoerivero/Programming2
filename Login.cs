/*Proyecto; Damage Control.
Equipo N°5. Integrantes:
Yurisbellys Brizuela. C.I: 27.142.239
Franklin Camacho. C.I: 26.796.912
Jesús Leal. C.I: 26.561.030
Marihec Miranda. C.I: 26.120.075
Gustavo Rivero. C.I: 26.772.857*/

//Login: Ventana que requiere de un Usuario y su respectiva Contraseña para visualizar el resto del programa.

//Se colocan las librerías a utilizar por el programa.
using System;
using Gtk;
using System.Timers;

//Librerías que facilitan la elaboración del programa.
using Comandos;

namespace DamageControl
{
	public partial class Login: Gtk.Window
	{
		//Instanciar clases.
		Basicos bas;
		ConexBD con;

		public Login () : base (Gtk.WindowType.Toplevel)
		{
			this.Build ();

			//Creación de objetos para las clases utilizadas.
			bas = new Basicos ();
			con = new ConexBD (this);

			//Se crea el objeto de temporizador.
			Timer fechaActual = new Timer();
			//Se le da formato de fecha actual al labFecha.
			labFecha.Text = Convert.ToString(DateTime.Now);
			//Se configura la fecha.
			fechaActual.Interval = 1000;
			fechaActual.Elapsed += new ElapsedEventHandler(fecha);
			fechaActual.Enabled = true;
			frameLogin.HeightRequest = 525;

		}

		//Método que asigna fecha al labFecha.
		protected void fecha(object sender, ElapsedEventArgs e)
		{
			labFecha.Text = Convert.ToString(DateTime.Now);
		}

		protected void OnDeleteEvent (object sender, DeleteEventArgs a)
		{
			Application.Quit ();
			a.RetVal = true;
		}

		protected void OnEntUsuarioChanged (object sender, EventArgs e)
		{
			//Valida que la entrada de caracteres en el campo de usuario sean solamente alfanuméricos.
			bas.validarAlfanumerico (entUsuario);

			//throw new NotImplementedException ();
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

		//Método que por medio del botón "Limpiar" se devuelven todas las herramientas usadas a su estado inicial.
		protected void OnButLimpiarClicked (object sender, EventArgs e)
		{
			//Vacía los entries presentes en la pantalla.
			entUsuario.Text = "";
			entContrasena.Text = "";
			chButMostrarCont.Active = false;

			//throw new NotImplementedException ();
		}

		//Método que por medio del botón "Iniciar Sesión" permite abrir la ventana Menú Principal.
		protected void OnButIniciarSesionClicked (object sender, EventArgs e)
		{
			//Valida que los campos no se encuentren vacíos.
			if (entUsuario.Text != "" && entContrasena.Text != "") 
			{
				//Valida si encuentra al usuario.
				if (con.Buscar ("id", "usuario", entUsuario.Text, "estatusU") == true) 
				{
					string sent = "Select id, clave, codTipoU from usuario where id = '" + entUsuario.Text + "' and estatusU = 'A'";
					string[] datos = con.Listado (3, sent);

					//Validación de contraseña
					if (datos [1] == entContrasena.Text) 
					{
						//Variables pasadas por parámetro.
						string id = datos [0], clave = datos[1];
						int tipoU = 0;

						//Se asigna el valor correcto al tipo de Usuario.
							//Actualizaciones.
						if (datos [2] == "TU1")
							tipoU = 1;
							//Reportes.
						else if (datos [2] == "TU2")
							tipoU = 2;
							//Administrador.
						else
							tipoU = 3;
												
						//Ingreso al sistema.
						con.Mensaje ("¡Bienvenido al sistema " + id + "!", ButtonsType.Ok, MessageType.Info, "Damage Control");

						/*Se pasará como parámetro el "Tipo de Usuario, permitiendo que"
						en el menú solo aparezcan las opciones válidas para ese usuario.*/
						MenuPrincipal menu = new MenuPrincipal (id, tipoU);
						menu.Show ();
						this.Hide ();
					} 
					//Contraseña errónea.
					else 
					{
						//La contraseña es incorrecta.
						con.Mensaje ("Contraseña incorrecta.", ButtonsType.Ok, MessageType.Error, "ERROR");
						entContrasena.ChildFocus (DirectionType.Up);
					}

				} 

				else 
				{ 
					//No encontró el usuario.
					con.Mensaje ("Usuario incorrecto.", ButtonsType.Ok, MessageType.Error, "ERROR");
					entContrasena.ChildFocus (DirectionType.Up);
				}
			}

			/*Si los campos de Usuario y Contraseña se encuentran vacíos, muestra mensaje
			solicitando que estos sean llenados.*/
			if((entUsuario.Text.Length == 0) || (entContrasena.Text.Length == 0))
			{
				MessageDialog md;
				md = new MessageDialog (null, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, "Por favor, rellene todos los campos");
				md.Run();
				md.Destroy ();
			}

			//throw new NotImplementedException ();
		}

		//Método que por habilita la visibilidad del Entry de Contraseña.
		protected void OnChButMostrarContClicked (object sender, EventArgs e)
		{
			//Si el CheckBox es marcado, deja que la contraseña sea visible
			if (chButMostrarCont.Active == true) 
				entContrasena.Visibility = true;

			//Si el CheckBox está desmarcado, la contraseña se mantiene invisible
			if (chButMostrarCont.Active == false)
				entContrasena.Visibility = false;

			//throw new NotImplementedException ();
		}
			
		//Se ejecuta el método que permitirá ingresar un nuevo usuario a la Base de Datos.
		protected void OnButRegistrarClicked (object sender, EventArgs e)
		{
			RegistroUsuario reg = new RegistroUsuario();
			reg.Show ();

			//throw new NotImplementedException ();
		}

		//Muestra el contenido del Registro.
		protected void OnExpRegistroActivated (object sender, EventArgs e)
		{
			alignRegistrar.Show ();

			//throw new NotImplementedException ();
		}
	}

}
