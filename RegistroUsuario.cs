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
	public partial class RegistroUsuario : Gtk.Window
	{
		//Instanciar clases.
		Basicos bas;
		ConexBD con;

		//Variables a utilizar.
		bool validar = false;

		//Códigos de autorización para registro de nuevo usuario.
		const string codigoTipo1 = "TU1"; 	//Permisos para actualizar datos.
		const string codigoTipo2 = "TU2"; 	//Permisos para solicitar reportes.
		const string codigoTipo3 = "TU3";	//Permisos de Administrador de Sistema.

		public RegistroUsuario () : base (Gtk.WindowType.Toplevel)
		{
			//Creación de objetos para las clases utilizadas.
			bas = new Basicos ();
			con = new ConexBD (this);

			this.Build ();
		}

		public void RegistrarNuevoUsuario ()
		{
			//Variable a utilizar.
			string tipoUsuarioNuevo;

			//Valida que todos los campos se encuentren llenos.
			if (entUsuarioRegistro.Text == "" || entContrasenaRegistro.Text == "" || entConfirmarContrasenaRegistro.Text == "" || entCodigoAutorizacion.Text == "")
			{

				con.Mensaje ("Rellene los campos vacíos.", ButtonsType.Ok, MessageType.Error, "Error");

			}
			//Se procede al registro.
			else
			{
				//Si las contraseñas son iguales.
				if (entContrasenaRegistro.Text == entConfirmarContrasenaRegistro.Text)
				{
					//Valida que el código de autorización sea el correcto.
					if (entCodigoAutorizacion.Text == codigoTipo1 || entCodigoAutorizacion.Text == codigoTipo2 || entCodigoAutorizacion.Text == codigoTipo3) 
					{ 
						//Asigna el cógido de autorización a la variable.
						tipoUsuarioNuevo = entCodigoAutorizacion.Text;

						//Se crean las variables que se agregaran a la sentencia SQL.
						string nuevoUsuario = entUsuarioRegistro.Text, nuevaContrasena = entContrasenaRegistro.Text;
						//Sentencia SQL
						string sentenciaNuevoUsuario = "INSERT INTO usuario VALUES ('" + nuevoUsuario + "', '" + nuevaContrasena + "', '" + tipoUsuarioNuevo + "', 'A')";
						//Se ejecuta la sentencia en la Base de Datos
						con.EjecutarSentencia (sentenciaNuevoUsuario);
						//Registro exitoso.
						con.Mensaje ("Ahora, formas parte de Damage Control System.\nYa puedes ingresar al sistema " + nuevoUsuario + ".", ButtonsType.Ok, MessageType.Info, "Registro Exitoso");

						//Se vacían todos los entries presentes en la pantalla.
						entUsuarioRegistro.Text = "";
						entContrasenaRegistro.Text = "";
						entConfirmarContrasenaRegistro.Text = "";
						entCodigoAutorizacion.Text = "";
						validar = false;

						//Se destruye la ventana.
						this.Destroy ();

					}
					//Código de autorización erróneo.
					else
					{
						con.Mensaje ("El código de autorización es erróneo.\n\nIntente nuevamente.", ButtonsType.Ok, MessageType.Error, "Error");

					}
				}
				//Las contraseñas son distintas.
				else
				{
					con.Mensaje ("Las contraseñas no coinciden.", ButtonsType.Ok, MessageType.Error, "Error");

				}

			}
		}

		//Permite hacer una búsqueda del id ingresado para el nuevo usuario y valida si ya existe o no.
		protected void OnButBuscarUsuarioClicked (object sender, EventArgs e)
		{
			//Si el campo está vacío, el sistema solicita que sea llenado.
			if (entUsuarioRegistro.Text == "") 
			{
				con.Mensaje ("Ingrese un id en el campo de Usuario.", ButtonsType.Ok, MessageType.Error, "Error");
			} 
			//Si el campo de Usuario se encuentra con datos, procede.
			else 
			{
				if (con.Buscar ("id", "usuario", entUsuarioRegistro.Text, "estatusU") == true) 
				{
					con.Mensaje ("El usuario ya existe. \n\nIngrese un nuevo id.", ButtonsType.Ok, MessageType.Error, "Error");

				} 
				else 
				{
					con.Mensaje ("El id para el usuario es válido.", ButtonsType.Ok, MessageType.Info, "Info");
					entContrasenaRegistro.Sensitive = true;
					entConfirmarContrasenaRegistro.Sensitive = true;
					entCodigoAutorizacion.Sensitive = true;
					validar = true;
				}
			}

			//throw new NotImplementedException ();
		}

		//Salir del registro.
		protected void OnButCancelarRegClicked (object sender, EventArgs e)
		{
			//Validación para cerrar el la ventana de registro.
			MessageDialog md;
			md = new MessageDialog (null, DialogFlags.Modal, MessageType.Question, ButtonsType.YesNo, "¿Desea salir del registro?");
			ResponseType respuesta = (ResponseType)md.Run ();
			if (respuesta == ResponseType.Yes) {
				md.Destroy ();
				this.Destroy ();
			}
			else {
				md.Destroy ();
			}

			//throw new NotImplementedException ();
		}

		//Dejar la ventana en su estado inicial.
		protected void OnButLimpiarRegClicked (object sender, EventArgs e)
		{
			//Se vacían los campos.
			entUsuarioRegistro.Text = "";
			entContrasenaRegistro.Text = "";
			entConfirmarContrasenaRegistro.Text = "";
			entCodigoAutorizacion.Text = "";
			//Se bloquean los campos.
			entContrasenaRegistro.Sensitive = false;
			entConfirmarContrasenaRegistro.Sensitive = false;
			entCodigoAutorizacion.Sensitive = false;
			//Se devuelve la variable a su estado inicial.
			validar = false;
		
			//throw new NotImplementedException ();
		}

		protected void OnButRegistrarClicked (object sender, EventArgs e)
		{
			//Validaciónes para el registro.
			if (entUsuarioRegistro.Text != "") 
			{
				//Si el id ingresado es válido, se procede al registro.
				if (validar) 
				{
					RegistrarNuevoUsuario ();
				} 
				//Si no se ha realizado la búsqueda del id válido.
				else 
				{
					con.Mensaje ("Verifique si el id ingresado es válido.", ButtonsType.Ok, MessageType.Error, "Verificación");
				}
			}
			//Si no se ha ingresado ningún dato en el campo de Usuario.
			else 
			{
				con.Mensaje ("Rellene el campo de Usuario.", ButtonsType.Ok, MessageType.Error, "Verificación");
			}

			//throw new NotImplementedException ();
		}

		//Muestra el HBox que contiene el código de Autorización.
		protected void OnExpCodigoAutorizacionActivated (object sender, EventArgs e)
		{
			hboxRegistro.Show ();

			//throw new NotImplementedException ();
		}
	}
}

