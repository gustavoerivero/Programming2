/*Proyecto; Damage Control.
Equipo N°5. Integrantes:
Yurisbellys Brizuela. C.I: 27.142.239
Franklin Camacho. C.I: 26.796.912
Jesús Leal. C.I: 26.561.030
Marihec Miranda. C.I: 26.120.075
Gustavo Rivero. C.I: 26.772.857*/

/*Reportes: Ventana que posee dos ventanas integradas a ella; 
			Listado de Cursos: Un reporte que emite los cursos activos y la cantidad de grupos que posee.
			Listado de Grupos Culminados: Un reporte que emite los grupos culminados hasta la fecha actual.*/

//Se colocan las librerías a utilizar por el programa.
using System;
using Gtk;
using System.Timers;

//Librerías que facilitan la elaboración del programa.
using Comandos;

namespace DamageControl
{
	public partial class Reportes : Gtk.Window
	{

		ConexBD con;

		//Variables que se enviará como parametro a la clase "MenuPrincipal" cuando se inicie el boton regresar.
		int tipoUsuario;
		string id;

		//Objetos a utilizar.
		ListStore DatosCursos = new ListStore (typeof (string), typeof (string), typeof (string));
		ListStore DatosGrupos = new ListStore (typeof(string), typeof(string), typeof(string), typeof(string), typeof(string));

		public Reportes (string usuario, int tipoU) : base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
			con = new ConexBD (this);
			userAcces (tipoU);
			idUsuario (usuario);

			//Se crea el objeto de temporizador.
			Timer fechaActual = new Timer();
			//Se le da formato de fecha actual al labFecha.
			labFecha.Text = Convert.ToString(DateTime.Now);
			//Se configura la fecha.
			fechaActual.Interval = 1000;
			fechaActual.Elapsed += new ElapsedEventHandler(fecha);
			fechaActual.Enabled = true;

			//Configurar los entries de fechas.
			entFechaInicial.Text = DateTime.Now.ToString("yyyy/MM/01");
			entFechaFinal.Text = DateTime.Now.ToString ("yyyy/MM/dd");

			tViewCursos.Model = DatosCursos;
			//Elaboración de las columnas del TreeView.
			tViewCursos.AppendColumn("Código del Curso", new CellRendererText(), "text", 0);
			tViewCursos.AppendColumn("Nombre del Curso", new CellRendererText(), "text", 1);
			tViewCursos.AppendColumn("Cantidad de Grupos", new CellRendererText(), "text", 2);

			tViewGrupos.Model = DatosGrupos;
			//Elaboración de las columnas del TreeView.
			tViewGrupos.AppendColumn("Código del Grupo", new CellRendererText(), "text", 0);
			tViewGrupos.AppendColumn("Nombre del Curso", new CellRendererText(), "text", 1);
			tViewGrupos.AppendColumn("Fecha de Inicio", new CellRendererText(), "text", 2);
			tViewGrupos.AppendColumn("Fecha de Culminación", new CellRendererText(), "text", 3);
			tViewGrupos.AppendColumn("Turno", new CellRendererText(), "text", 4);
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
			labUsuario.UseMarkup = true;
			id = usuario;
		}

		/*Método que ayuda a almacenar el tipo de usuario logueado en la variable "TipoUsuario" para que al momento de regresar
		a la ventana anterior se mantegan los ajustes para cada usuario*/
		public void userAcces (int tipoU)
		{
			if (tipoU == 2) {
				tipoUsuario = 2;
			}

			if (tipoU == 3) {
				tipoUsuario = 3;
			}
		}

		//Método que por medio del botón "Salir" permite cerrar de la Aplicación.
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

		//Método que por medio del botón "Regresar" permite volver al Menú Principal.
		protected void OnButRegresarClicked (object sender, EventArgs e)
		{
			//Botón que realiza la función de regresar a la ventana anterior

			//Se declara el objeto para el cuadro de mensaje
			MessageDialog md;

			//Se crea el objeto para el cuadro de mensaje
			md = new MessageDialog (null, DialogFlags.Modal, MessageType.Question, ButtonsType.YesNo, "¿Desea volver a la ventana anterior?");

			//Se crea el objeto para la decisión tomada por el usuario y se ejecuta el cuadro de mensaje
			ResponseType respuesta = (ResponseType)md.Run ();

			/*Caso afirmativo para el ResponseType
			Destruye el cuadro de mensaje y ejecuta la siguiente función.*/
			if (respuesta == ResponseType.Yes) {
				md.Destroy ();

				//Cierra la ventana actual y muestra la del menu principal
				MenuPrincipal men = new MenuPrincipal (id, tipoUsuario);
				men.Show ();
				this.Hide ();
			}
			else {
				//Caso negativo para el ResponseType
				//Destruye el cuadro de mensaje y se mantiene en la ventana actual
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

			/*Caso afirmativo para el ResponseType
			Destruye el cuadro de mensaje y ejecuta la siguiente función.*/
			if (respuesta == ResponseType.Yes) {
				md.Destroy ();

				//Cierra la ventana actual y muestra la del login
				Login log = new Login ();
				log.Show ();
				this.Hide ();
			}
			else {
				/*Caso negativo para el ResponseType
				Destruye el cuadro de mensaje y se mantiene en la ventana actual*/
				md.Destroy ();
			}
			//throw new NotImplementedException ();
		}

		//Muestra la ventana de InfoDeUsuario que contiene la información de la empresa y del usuario que está conectado.
		protected void OnButInfoUsuarioClicked (object sender, EventArgs e)
		{
			InfoDeUsuario info = new InfoDeUsuario (id, tipoUsuario);
			info.Show ();

			//throw new NotImplementedException ();
		}


		/*======================================================================================================
		Pestaña "Listado de Cursos": Permite visualizar un reporte de los cursos existentes entre dos fechas.
		======================================================================================================*/

		//Método que abre una ventana con el Widget de calendario. Pasa por referencia un entry y devuelve una fecha.
		protected void OnButFechaInicialClicked (object sender, EventArgs e)
		{
			Calendario cal = new Calendario (ref entFechaInicial);
			cal.Show ();

			//throw new NotImplementedException ();
		}

		//Método que abre una ventana con el Widget de calendario. Pasa por referencia un entry y devuelve una fecha.
		protected void OnButFechaFinalClicked (object sender, EventArgs e)
		{
			Calendario cal = new Calendario (ref entFechaFinal);
			cal.Show ();

			//throw new NotImplementedException ();
		}

		protected void reporteCursos () 
		{
			//Se limpia el treeVie.
			DatosCursos.Clear ();

			//Se elaboran cada una de las sentencias que permitirán recaudar la información necesaria desde la Base de Datos.
			string SentenciaCodCursos = string.Format("SELECT curso.codCur from curso, grupo where estatusCur = 'A' and estatusGru = 'A' and curso.codCur = grupo.codCur and fechaIni >= '{0}' and fechaCul <= '{1}' group by curso.codCur;", Convert.ToDateTime (entFechaInicial.Text).ToString ("yyyy-MM-dd"), Convert.ToDateTime (entFechaFinal.Text).ToString ("yyyy-MM-dd"));
			string SentenciaNombreCursos = string.Format("SELECT nombreCur from curso, grupo where estatusCur = 'A' and estatusGru = 'A' and curso.codCur = grupo.codCur and fechaIni >= '{0}' and fechaCul <= '{1}' group by curso.codCur;", Convert.ToDateTime (entFechaInicial.Text).ToString ("yyyy-MM-dd"), Convert.ToDateTime (entFechaFinal.Text).ToString ("yyyy-MM-dd"));
			string SentenciaCantGruposXCurso = string.Format("SELECT count(codGru) from curso, grupo where estatusCur = 'A' and estatusGru = 'A' and curso.codCur = grupo.codCur and fechaIni >= '{0}' and fechaCul <= '{1}' group by curso.codCur;", Convert.ToDateTime (entFechaInicial.Text).ToString ("yyyy-MM-dd"), Convert.ToDateTime (entFechaFinal.Text).ToString ("yyyy-MM-dd"));

			//Sentencia que permite conocer la cantidad de cursos.
			string SentenciaCantCursos = string.Format("select count(distinct nombreCur) from curso, grupo where estatusCur = 'A' and estatusGru = 'A' and curso.codCur = grupo.codCur and fechaIni >= '{0}' and fechaCul <= '{1}';", Convert.ToDateTime (entFechaInicial.Text).ToString ("yyyy-MM-dd"), Convert.ToDateTime (entFechaFinal.Text).ToString ("yyyy-MM-dd"));

			//Se trae la cantidad de cursos desde la Base de Datos.
			int cantCursos = Convert.ToInt16 (con.EjecutarScalar (SentenciaCantCursos));

			//Se rellenan arreglos con la información solicitada por las sentencias previamente elaboradas.
			string[] listadoCodCursos = con.ListadoMD (1, cantCursos, SentenciaCodCursos);
			string[] listadoNombreCursos = con.ListadoMD (1, cantCursos, SentenciaNombreCursos);
			string[] listadoCantGruposXCurso = con.ListadoMD (1, cantCursos, SentenciaCantGruposXCurso);

			//Se llenan las columnas del treeView con la información que se encuentra en los arreglos.
			for (int x = 0; x < cantCursos; x++) 
			{
				DatosCursos.AppendValues (listadoCodCursos [x], listadoNombreCursos [x], listadoCantGruposXCurso [x]);
			}

			//Se le da forma al treeView.
			tViewCursos.Model = DatosCursos;

		}

		//Método que permite verificar que las fechas sean válidas.
		public bool validarFechas ()
		{
			if (entFechaInicial.Text != "" && entFechaFinal.Text != "") 
			{
				return true;
			}

			else if (Convert.ToDateTime (entFechaInicial.Text) > Convert.ToDateTime (entFechaFinal.Text)) 
			{
				con.Mensaje ("La fecha inicial no puede ser mayor que la fecha final.", ButtonsType.Ok, MessageType.Error, "");
				return false;
			} 

			else 
			{
				con.Mensaje ("Rellene los campos vacíos.", ButtonsType.Ok, MessageType.Error, "");
				return false;
			}
		}

		//Método que por medio del botón "Consultar" permite visualizar el listado correspondiente.
		protected void OnButConsultarCursosClicked (object sender, EventArgs e)
		{
			if (validarFechas ()) 
			{
				TreeViewColumn[] columnas = tViewCursos.Columns;
				for (int i = columnas.Length; i > 0; i--)
				{
					tViewCursos.RemoveColumn(columnas[i - 1]);
				}

				//Elaboración de las columnas del TreeView.
				tViewCursos.AppendColumn("Código del Curso", new CellRendererText(), "text", 0);
				tViewCursos.AppendColumn("Nombre del Curso", new CellRendererText(), "text", 1);
				tViewCursos.AppendColumn("Cantidad de Grupos", new CellRendererText(), "text", 2);

				reporteCursos ();
			}
			//throw new NotImplementedException ();
		}

		//Método que por medio del botón "Limpiar" permite dejar en su estado inicial las herramientas usadas.
		protected void OnButLimpiarCursosClicked (object sender, EventArgs e)
		{
			//Se devuelven a los valores iniciales.
			DatosCursos.Clear ();
			entFechaFinal.Text = DateTime.Now.ToString ("yyyy/MM/dd");
			entFechaInicial.Text = DateTime.Now.ToString("yyyy/MM/01");
			tViewCursos.Model = DatosCursos;

			//throw new NotImplementedException ();
		}


		/*======================================================================================================
		Pestaña "Listado de Cursos Culminados": Permite visualizar un reporte de los grupos culminados hasta 
												la fecha actual.
		======================================================================================================*/


		protected void reporteGrupos () 
		{
			//Se limpia el treeView.
			DatosGrupos.Clear ();

			//Se elaboran cada una de las sentencias que rellenarán el reporte.
			string SentenciaCodigoGrupos = "select grupo.codGru from curso, grupo, turno where estatusCur = 'A' and estatusGru = 'A' and estatusTur = 'A' and curso.codCur = grupo.codCur and codTurGru = turno.codTur and fechaCul <= now();";
			string SentenciaNombreGrupos = "select nombreCur from curso, grupo, turno where estatusCur = 'A' and estatusGru = 'A' and estatusTur = 'A' and curso.codCur = grupo.codCur and codTurGru = turno.codTur and fechaCul <= now();";
			string SentenciaFechasInicio = "select fechaIni from curso, grupo, turno where estatusCur = 'A' and estatusGru = 'A' and estatusTur = 'A' and curso.codCur = grupo.codCur and codTurGru = turno.codTur and fechaCul <= now();";
			string SentenciaFechasFinal = "select fechaCul from curso, grupo, turno where estatusCur = 'A' and estatusGru = 'A' and estatusTur = 'A' and curso.codCur = grupo.codCur and codTurGru = turno.codTur and fechaCul <= now();";
			string SentenciaTurnos = "select codTurGru from curso, grupo, turno where estatusCur = 'A' and estatusGru = 'A' and estatusTur = 'A' and curso.codCur = grupo.codCur and codTurGru = turno.codTur and fechaCul <= now();";

			//Se elabora la sentencia que permitirá conocer la cantidad de grupos culminados
			string SentenciaCantGrupos = "select count(grupo.codGru) from curso, grupo, turno where estatusCur = 'A' and estatusGru = 'A' and estatusTur = 'A' and curso.codCur = grupo.codCur and codTurGru = turno.codTur and fechaCul <= now();";

			//Se obtiene la cantidad de grupos culminados desde la base de datos.
			int cantGrupos = Convert.ToInt16 (con.EjecutarScalar (SentenciaCantGrupos));

			//Se obtienen todos los datos de cada columna desde la base de datos.
			string[] listadoCodigoGrupos = con.ListadoMD (1, cantGrupos, SentenciaCodigoGrupos);
			string[] listadoNombreGrupos = con.ListadoMD (1, cantGrupos, SentenciaNombreGrupos);
			string[] listadoFechasInicio = con.ListadoMD (1, cantGrupos, SentenciaFechasInicio);
			string[] listadoFechasFinal = con.ListadoMD (1, cantGrupos, SentenciaFechasFinal);
			string[] listadoTurnos = con.ListadoMD (1, cantGrupos, SentenciaTurnos);

			//Se rellena el treeView con los datos obtenidos.
			for (int x = 0; x < cantGrupos; x++) 
			{
				DatosGrupos.AppendValues (listadoCodigoGrupos [x], listadoNombreGrupos [x], listadoFechasInicio [x], listadoFechasFinal [x], listadoTurnos [x]);
			}

			//Se da forma al TreeView.
			tViewGrupos.Model = DatosGrupos;

		}

		//Método que por medio del botón "Consultar" permite visualizar el listado correspondiente.
		protected void OnButConsultarGruposClicked (object sender, EventArgs e)
		{
			TreeViewColumn[] columnas = tViewGrupos.Columns;
			for (int i = columnas.Length; i > 0; i--)
			{
				tViewGrupos.RemoveColumn(columnas[i - 1]);
			}

			tViewGrupos.AppendColumn("Código del Grupo", new CellRendererText(), "text", 0);
			tViewGrupos.AppendColumn("Nombre del Curso", new CellRendererText(), "text", 1);
			tViewGrupos.AppendColumn("Fecha de Inicio", new CellRendererText(), "text", 2);
			tViewGrupos.AppendColumn("Fecha de Culminación", new CellRendererText(), "text", 3);
			tViewGrupos.AppendColumn("Turno", new CellRendererText(), "text", 4);

			reporteGrupos ();

			//throw new NotImplementedException ();
		}

		//Método que por medio del botón "Limpiar" permite dejar en su estado inicial las herramientas usadas.
		protected void OnButLimpiarGruposClicked (object sender, EventArgs e)
		{
			DatosGrupos.Clear ();
			tViewGrupos.Model = DatosGrupos;

			//throw new NotImplementedException ();
		}
	}
  }

