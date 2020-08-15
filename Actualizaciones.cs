/*Proyecto; Damage Control.
Equipo N°5. Integrantes:
Yurisbellys Brizuela. C.I: 27.142.239
Franklin Camacho. C.I: 26.796.912
Jesús Leal. C.I: 26.561.030
Marihec Miranda. C.I: 26.120.075
Gustavo Rivero. C.I: 26.772.857*/

/*Actualizaciones: Ventana que posee dos ventanas integradas a ella; 
					Instructores: Permite incluir, modificar, eliminar información de un instructor.
					Estudiantes: Permite incluir, modificar, eliminar información de un instructor.*/

//Se colocan las librerías a utilizar por el programa.
using System;
using Gtk;
using System.Timers;

//Librerías que facilitan la elaboración del programa.
using Comandos;

namespace DamageControl
{
	public partial class Actualizaciones : Gtk.Window
	{
		ConexBD con;
		Basicos bas;

		//Variables que se enviará como parametro a la clase "MenuPrincipal" cuando se inicie el botón regresar.
		int tipoUsuario;
		string id;

		//Variables a utilizar.
			//Especialmente para comboboxes.
		string[] profesiones, grupos, turnos, cursos, instructores, lapsosAcademicos;
		int cantProfesiones, cantGrupos, cantTurnos, cantCursos, cantInstructores, cantLapsosAcademicos;
			//Métodos para botones.
				//Instructor
		bool busquedaIns = false, limIns = false, resultadoIns = false;
				//Estudiante
		bool busquedaEst = false, limEst = false, resultadoEst = false;
				//Grupo
		bool busquedaGru = false, limGru = false, resultadoGru = false;
				//Curso
		bool busquedaCur = false, limCur = false, resultadoCur = false;

		public Actualizaciones (string usuario, int tipoU) : base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
			con = new ConexBD (this);
			bas = new Basicos ();

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

			//Inicialización de ComboBoxes
				//Profesiones
			cbboxProfesionInstructor.Model = cargarProfesiones ();
				cbboxProfesionInstructor.Active = 0;
				//Grupos
			cbboxGrupoEstudiante.Model = cargarGrupos ();
				cbboxGrupoEstudiante.Active = 0;
				//Turnos
			cbboxTurnoGrupo.Model = cargarTurnos ();
				cbboxTurnoGrupo.Active = 0;
				//Cursos
			cbboxCursoGrupo.Model = cargarCursos ();
				cbboxCursoGrupo.Active = 0;
				//Instructores
			cbboxInstructorGrupo.Model = cargarInstructores ();
				cbboxInstructorGrupo.Active = 0;
				//Lapsos académicos
			cbboxLapsoAcademico.Model = cargarLapsosAcademicos ();
				cbboxLapsoAcademico.Active = 0;

			//Inicialización de entries.
			labCaracteres.Text = "160";

			//Inicialización de variables.
				//Instructor
			busquedaIns = false;
			limIns = false;
			resultadoIns = false;
				//Estudiante
			busquedaEst = false;
			limEst = false;
			resultadoEst = false;
				//Grupo
			busquedaGru = false;
			limGru = false;
			resultadoGru = false;
				//Curso
			busquedaCur = false;
			limCur = false;
			resultadoCur = false;
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

		public void validacionesBotones(){
			
			//Para Instructor

			if (busquedaIns == true && resultadoIns == false) {
				butIncluirInstructor.Sensitive = true;
			}

			if (busquedaIns == true && resultadoIns == true) {
				butModificarInstructor.Sensitive = true;
				butRetirarInstructor.Sensitive = true;
				butEliminarInstructor.Sensitive = true;
			}

			if(busquedaIns == true && resultadoIns == true && cbboxEstatusInstructor.ActiveText == "Retirado"){
				butReingresoInstructor.Sensitive = true;
			}

			//Para estudiante

			if (busquedaEst == true && resultadoEst == false) {
				butIncluirEstudiante.Sensitive = true;
			}

			if (busquedaEst == true && resultadoEst == true) {
				butModificarEstudiante.Sensitive = true;
				butRetirarEstudiante.Sensitive = true;
				butEliminarEstudiante.Sensitive = true;
			}

			if(busquedaEst == true && resultadoEst == true && cbboxEstatusEstudiante.ActiveText == "Retirado"){
				butReinscribirEstudiante.Sensitive = true;
			}
		}

		/*Método que ayuda a almacenar el tipo de usuario logueado en la variable "TipoUsuario" para que al momento de regresar.
		a la ventana anterior se mantegan los ajustes para cada usuario*/
		public void userAcces (int tipoU)
		{
			if (tipoU == 1) 
			{
				tipoUsuario = 1;
			}

			if (tipoU == 3) 
			{
				tipoUsuario = 3;
			}
			
		}


		//Método que permite cargar un listado, específicamente de Profesiones.
		protected ListStore cargarProfesiones ()
		{
			//Se crea el objeto que servirá de lista.
			ListStore profesion = new ListStore(typeof(string));

			//Se elabora la sentencia SQL.
			string sentencia = "select codPro, descripcionPro from profesion where estatusPro = 'A';";

			//Se elabora la sentencia SQL para conocer cuantos registros existen.
			int cantidadProfesion = con.Contar("select count(codPro) from profesion where estatusPro = 'A';");

			//Se cargan los datos de la Base de Datos en un arreglo.
			string[] profesionesMatriz = con.ListadoMD(2, cantidadProfesion, sentencia);

			//Se modifica el arreglo existente.
			profesiones = new string[cantidadProfesion];

			//Se inicializa la variable.
			cantProfesiones = 0;

			for (int i = 0; i < cantidadProfesion * 2; i++)
			{
				//Se van añadiendo los datos de la Base de Datos en la variable global.
				profesiones[cantProfesiones] = profesionesMatriz[i];
				i++;
				cantProfesiones++;
			}

			for (int i = 1; i < cantidadProfesion * 2; i++)
			{
				//Se añaden los datos de la Base de datos en el objeto.
				profesion.AppendValues(profesionesMatriz[i]);
				i++;
			}

			return profesion;
		}

		//Método que permite cargar un listado, específicamente de Grupos.
		protected ListStore cargarGrupos ()
		{
			//Se crea el objeto que servirá de lista.
			ListStore grupoList = new ListStore(typeof(string));
					
			//Se elabora la sentencia SQL que recibirá como parámetro un valor "string".
			string sentencia = "select codGru, codGru from grupo where estatusGru = 'A';";

			//Se busca conocer la cantidad de registros.
			int cantidadGrupos = con.Contar("select count(codGru) from grupo where estatusGru = 'A'");

			//Se elabora un arreglo que carga con los registros de la Base de datos.
			string[] gruposMatriz = con.ListadoMD(2, cantidadGrupos, sentencia);

			//Se modifica la variable.
			grupos = new string[cantidadGrupos];

			//Se le asigna un valor a la variable.
			cantGrupos = 0;

			for (int i = 0; i < cantidadGrupos * 2; i++)
			{
				//Se van añadiendo los datos de la Base de Datos en la variable global.
				grupos[cantGrupos] = gruposMatriz[i];
				i++;
				cantGrupos++;
			}

			for (int i = 1; i < cantidadGrupos * 2; i++)
			{
				//Se añaden los datos de la Base de datos en el objeto.
				grupoList.AppendValues(gruposMatriz[i]);
				i++;
			}

			return grupoList;
				
		}

		//Método que permite cargar un listado, específicamente de Turnos.
		protected ListStore cargarTurnos ()
		{
			//Se crea el objeto que servirá de lista.
			ListStore turnosList = new ListStore(typeof(string));

			//Se elabora la sentencia SQL.
			string sentencia = "select codTur, codTur from turno where estatusTur = 'A';";

			//Se elabora la sentencia SQL para conocer cuantos registros existen.
			int cantidadTurnos = con.Contar("select count(codTur) from turno where estatusTur = 'A'");

			//Se cargan los datos de la Base de Datos en un arreglo.
			string[] turnosMatriz = con.ListadoMD(2, cantidadTurnos, sentencia);

			//Se modifica el arreglo existente.
			turnos = new string[cantidadTurnos];

			//Se inicializa la variable.
			cantTurnos = 0;

			for (int i = 0; i < cantidadTurnos * 2; i++)
			{
				//Se van añadiendo los datos de la Base de Datos en la variable global.
				turnos[cantTurnos] = turnosMatriz[i];
				i++;
				cantTurnos++;
			}

			for (int i = 1; i < cantidadTurnos * 2; i++)
			{
				//Se añaden los datos de la Base de datos en el objeto.
				turnosList.AppendValues(turnosMatriz[i]);
				i++;
			}

			return turnosList;
		}

		string[] cursosArray;

		//Método que permite cargar un listado, específicamente de Cursos.
		protected ListStore cargarCursos ()
		{
			//Se crea el objeto que servirá de lista.
			ListStore cursosList = new ListStore(typeof(string));

			//Se elabora la sentencia SQL que recibirá como parámetro un valor "string".
			string sentencia = "select codCur, nombreCur from curso where estatusCur = 'A';";
			string sentencia2 = "select nombreCur, nombreCur from curso where estatusCur = 'A';";

			//Se busca conocer la cantidad de registros.
			int cantidadCursos = con.Contar("select count(codCur) from curso where estatusCur = 'A';");

			//Se elabora un arreglo que carga con los registros de la Base de datos.
			string[] cursosMatriz = con.ListadoMD(2, cantidadCursos, sentencia);
			string[] nombreCursosMatriz = con.ListadoMD (2, cantidadCursos, sentencia2);

			//Se modifica la variable.
			cursos = new string[cantidadCursos];
			cursosArray = new string[cantidadCursos];

			//Se le asigna un valor a la variable.
			cantCursos = 0;

			for (int i = 0; i < cantidadCursos * 2; i++)
			{
				//Se van añadiendo los datos de la Base de Datos en la variable global.
				cursos[cantCursos] = cursosMatriz[i];
				cursosArray [cantCursos] = nombreCursosMatriz [i];
				i++;
				cantCursos++;
			}

			for (int i = 1; i < cantidadCursos * 2; i++)
			{
				//Se añaden los datos de la Base de datos en el objeto.
				cursosList.AppendValues(cursosMatriz[i]);
				i++;
			}

			return cursosList;

		}

		//Método que permite cargar un listado, específicamente de Instructores.
		protected ListStore cargarInstructores ()
		{
			//Se crea el objeto que servirá de lista.
			ListStore instructoresList = new ListStore(typeof(string));

			//Se elabora la sentencia SQL que recibirá como parámetro un valor "string".
			string sentencia = "select codIns, codIns from instructor where estatusIns = 'A';";

			//Se busca conocer la cantidad de registros.
			int cantidadInstructores = con.Contar("select count(codIns) from instructor where estatusIns = 'A';");

			//Se elabora un arreglo que carga con los registros de la Base de datos.
			string[] instructoresMatriz = con.ListadoMD(2, cantidadInstructores, sentencia);

			//Se modifica la variable.
			instructores = new string[cantidadInstructores];

			//Se le asigna un valor a la variable.
			cantInstructores = 0;

			for (int i = 0; i < cantidadInstructores * 2; i++)
			{
				//Se van añadiendo los datos de la Base de Datos en la variable global.
				instructores[cantInstructores] = instructoresMatriz[i] ;
				i++;
				cantInstructores++;
			}

			for (int i = 1; i < cantidadInstructores * 2; i++)
			{
				//Se añaden los datos de la Base de datos en el objeto.
				instructoresList.AppendValues(instructoresMatriz[i]);
				i++;
			}

			return instructoresList;

		}

		//Método que permite cargar un listado, específicamente de Lapsos Académicos.
		protected ListStore cargarLapsosAcademicos ()
		{
			//Se crea el objeto que servirá de lista.
			ListStore lapsosList = new ListStore(typeof(string));

			//Se elabora la sentencia SQL que recibirá como parámetro un valor "string".
			string sentencia = "select lapsoAcadGI, lapsoAcadGI from grupo_instructor group by lapsoAcadGI;";

			//Se busca conocer la cantidad de registros.
			int cantidadLapsos = con.Contar("select count(distinct lapsoAcadGI) from grupo_instructor;");

			string[] lapsosMatriz = con.ListadoMD(2, cantidadLapsos, sentencia);

			//Se modifica la variable.
			lapsosAcademicos = new string[cantidadLapsos];

			//Se le asigna un valor a la variable.
			cantLapsosAcademicos = 0;

			for (int i = 0; i < cantidadLapsos * 2; i++)
			{
				//Se van añadiendo los datos de la Base de Datos en la variable global.
				lapsosAcademicos[cantLapsosAcademicos] = lapsosMatriz[i];
				i++;
				cantLapsosAcademicos++;
			}

			for (int i = 1; i < cantidadLapsos * 2; i++)
			{
				//Se añaden los datos de la Base de datos en el objeto.
				lapsosList.AppendValues(lapsosMatriz[i]);
				i++;
			}

			return lapsosList;
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
				Destruye el cuadro de mensaje y se mantiene en la ventana actual.*/
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

				//Cierra la ventana actual y muestra la del "Menú Principal".
				MenuPrincipal men = new MenuPrincipal (id, tipoUsuario);
				men.Show ();
				this.Hide ();
			}
			else {
				/*Caso negativo para el ResponseType
				Destruye el cuadro de mensaje y se mantiene en la ventana actual.*/
				md.Destroy ();
			}

			//throw new NotImplementedException ();
		}

		//Método que por medio del botón "Salir" permite cerrar la Aplicación.
		protected void OnButSalirClicked (object sender, EventArgs e)
		{
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

		//Muestra la ventana de InfoDeUsuario que contiene la información de la empresa y del usuario que está conectado.
		protected void OnButInfoUsuarioClicked (object sender, EventArgs e)
		{
			InfoDeUsuario info = new InfoDeUsuario (id, tipoUsuario);
			info.Show ();

			//throw new NotImplementedException ();
		}

		//Método para modificar información.
		protected void ModificarInfo(bool busqueda, bool resultado, bool lim, bool expresion, string SentenciaSQL)
		{
			//Valida que se realizará la busqueda del registro.
			if (busqueda == false)
			{
				con.Mensaje("Se debe realizar la busqueda del registro.", ButtonsType.Ok, MessageType.Error, "Error");
			}
			else
			{
				//Si el registro existe.
				if (resultado == true)
				{
					//Confirmación para la modificación
					if (expresion == false)
					{
						if (con.Mensaje("¿Está seguro de realizar la modificación?.", ButtonsType.YesNo, MessageType.Question, "Modificación") == ResponseType.Yes)
						{
							con.EjecutarSentencia(SentenciaSQL);
							con.Mensaje("Se ha realizado la operación con exito.", ButtonsType.Ok, MessageType.Info, "¡Modificación Exitosa!");
							lim = true;
						}
					}
					else
					{
						con.Mensaje("ERROR: Los campos solicitados deben estar llenos.", ButtonsType.Ok, MessageType.Error, "Error");
					}
				}

				if (resultado == false)
				{
					con.Mensaje("El registro no existe.", ButtonsType.Ok, MessageType.Warning, "");
				}
			}
		}

		//Metodo para eliminar información.
		protected void EliminarInfo(bool busqueda, bool resultado, bool lim, string SentenciaSQL)
		{   
			//Valida que se realizará la busqueda del registro.
			if (busqueda == false)
			{
				con.Mensaje("Se debe realizar la busqueda del registro.", ButtonsType.Ok, MessageType.Error, "Error");
			}
			else
			{   //Si el registro existe
				if (resultado == true)
				{
					//Confirmación para eliminación.
					if (con.Mensaje("¿Está seguro de eliminar el registro?.", ButtonsType.YesNo, MessageType.Question, "Eliminación") == ResponseType.Yes)
					{
						con.EjecutarSentencia(SentenciaSQL);
						con.Mensaje("Se ha realizado la eliminación con éxito.", ButtonsType.Ok, MessageType.Info, "¡Modificación Exitosa!");
						lim = true;
					}
				}
				//Si el registro no existe
				if (resultado == false)
				{
					con.Mensaje("El registro no existe.", ButtonsType.Ok, MessageType.Warning, "");
				}
			}
		}

		//Metodo para incluir información.
		protected void IncluirInfo(bool busqueda, bool resultado, bool lim, bool expresion, string SentenciaSQL)
		{
			//Valida que se realizara la busqueda del registro
			if (busqueda == false)
			{
				con.Mensaje("Se debe realizar la búsqueda del registro", ButtonsType.Ok, MessageType.Error, "Error");
			}
			else
			{   
				//Si no se encontro el registro.
				if (resultado == false)
				{
					//Confirmación para la inclusión.
					if (expresion == false)
					{
						if (con.Mensaje("¿Está seguro de incluir el nuevo registro?.", ButtonsType.YesNo, MessageType.Question, "Modificación") == ResponseType.Yes)
						{
							con.EjecutarSentencia(SentenciaSQL);
							con.Mensaje("Se ha realizado la operación con exito.", ButtonsType.Ok, MessageType.Info, "¡Modificación Exitosa!");
							lim = true;
						}
					}
					else
					{
						con.Mensaje("Debe llenar todos los campos requeridos.", ButtonsType.Ok, MessageType.Error, "Error");
					}
				}
				//Si el registro ya existe
				if (resultado == true)
				{
					con.Mensaje("El registro ya existe.", ButtonsType.Ok, MessageType.Error, "Error");
				}
			}
		}

		/*======================================================================================================
		Pestaña "Instructores": Permite la actualización, inclusión, eliminación, retiro, de instructores.
		======================================================================================================*/

		//Generalización de métodos repetitivos.

		//Devolver las herramientas de recolección de datos de Instructor a sus valores iniciales.
		protected void limpiarInstructor ()
		{
			
			entCedulaInstructor.Text = "";
			entNombreInstructor.Text = "";
			entApellidoInstructor.Text = "";
			cbboxGeneroInstructor1.Active = 0;
			entFechaNacimientoInstructor.Text = "";
			entDireccionInstructor.Text = "";
			entFechaIngresoInstructor.Text = "";
			entCorreoInstructor.Text = "";
			entTlfInstructor.Text = "";
			cbboxProfesionInstructor.Active = 0;
			cbboxEstatusInstructor.Active = 0;
			butBuscarInstructor.Sensitive = true;
			labEstatusInstructor.Sensitive = true;
			cbboxEstatusInstructor.Sensitive = true;
			entCodigoInstructor.Sensitive = true;
			butIncluirInstructor.Sensitive = false;
			butModificarInstructor.Sensitive = false;
			butRetirarInstructor.Sensitive = false;
			butEliminarInstructor.Sensitive = false;
			butRetirarInstructor.Sensitive = false;
		}

		//Métodos propios de la ventana Instructor.

		protected void OnEntCodigoInstructorChanged (object sender, EventArgs e)
		{
			bas.validarAlfanumerico (entCodigoInstructor);

			//throw new NotImplementedException ();
		}

		//Método que permite buscar un instructor por su código.
		protected void OnButBuscarInstructorClicked (object sender, EventArgs e)
		{
			//Valida que el campo de Código de Estudiante no se encuentre vacío.
			if (entCodigoInstructor.Text == "")
			{
				con.Mensaje("Por favor, ingrese el código del instructor.", ButtonsType.Ok, MessageType.Error, "Error");
			}
			else
			{
				//Valida que exista el registro.
				if (con.BuscarTodos("codIns", "instructor", entCodigoInstructor.Text) == false)
				{
					con.Mensaje("El instructor no existe.", ButtonsType.Ok, MessageType.Error, "");
					busquedaIns = true;
					resultadoIns = false;
					validacionesBotones ();
					return;
				}
				else
				{
					//Se elabora la sentencia con los datos a buscar.
					string sentenciaSQL = "select cedulaIns, nombreIns, apellidoIns, generoIns, fechaNacIns, direccionIns, fechaIngreso, correoIns, tlfnIns, codProIns, estatusIns from instructor where codIns = '" + entCodigoInstructor.Text + "';";
					//Se hace un arreglo que contenga los datos solicitados por la sentencia SQL.
					string[] array = con.Listado(11, sentenciaSQL);

					entCedulaInstructor.Text = array[0];
					entNombreInstructor.Text = array[1];
					entApellidoInstructor.Text = array[2];

					if (array [3] == "Femenino") {
						cbboxGeneroInstructor1.Active = 2;
					}
					if (array [3] == "Masculino") {
						cbboxGeneroInstructor1.Active = 1;
					}


					DateTime fechaNacimiento = Convert.ToDateTime(array[4]);
					entFechaNacimientoInstructor.Text = fechaNacimiento.ToString("yyyy/MM/dd");
					entDireccionInstructor.Text = array[5];
					DateTime fechaIngreso = Convert.ToDateTime(array[6]);
							//Es enviada al entry correspondiente.
					entFechaIngresoInstructor.Text = fechaIngreso.ToString("yyyy/MM/dd");
						//Entry de correo.
					entCorreoInstructor.Text = array[7];
						//Entry de teléfono.
					entTlfInstructor.Text = array[8];

					for (int i = 0; i < profesiones.Length; i++) {
						if (profesiones [i] == array [9])
						cbboxProfesionInstructor.Active = i;
					}

					if (array [10] == "A") {
						cbboxEstatusInstructor.Active = 1;
					}
					else {
						cbboxEstatusInstructor.Active = 2;
					}
		

					//Se bloquea el entry de Código y el botón de Buscar, así mismo, se activa el bool de resultado.
					entCodigoInstructor.Sensitive = false;
					butBuscarInstructor.Sensitive = false;
					labEstatusInstructor.Sensitive = false;
					cbboxEstatusInstructor.Sensitive = false;

					resultadoIns = true;
					busquedaIns = true;
					validacionesBotones ();
				}

			}

			//throw new NotImplementedException ();
		}

		protected void OnEntCedulaInstructorChanged (object sender, EventArgs e)
		{
			bas.validarCedula(entCedulaInstructor);

			//throw new NotImplementedException ();
		}

		protected void OnEntNombreInstructorChanged (object sender, EventArgs e)
		{
			bas.validarLetras (entNombreInstructor);

			//throw new NotImplementedException ();
		}

		protected void OnEntApellidoInstructorChanged (object sender, EventArgs e)
		{
			bas.validarLetras (entApellidoInstructor);

			//throw new NotImplementedException ();
		}

		protected void OnEntDireccionInstructorChanged (object sender, EventArgs e)
		{
			bas.validarDireccion (entDireccionInstructor);

			//throw new NotImplementedException ();
		}

		protected void OnEntCorreoInstructorChanged (object sender, EventArgs e)
		{
			bas.validarCorreo (entCorreoInstructor);

			//throw new NotImplementedException ();
		}

		protected void OnEntTlfInstructorChanged (object sender, EventArgs e)
		{
			for (int i = 0; i < entTlfInstructor.Text.Length; i++) {
				if (entTlfInstructor.Text.Length <= 12)
					bas.validarTlf (entTlfInstructor);
				else
					entTlfInstructor.Text = entTlfInstructor.Text.Substring (0, entTlfInstructor.Text.Length - 1);
			}

			//throw new NotImplementedException ();
		}


		//Método que abre una ventana con el Widget de calendario. Pasa por referencia un entry y devuelve una fecha.
		protected void OnButCalendarioNacimientoInstructorClicked (object sender, EventArgs e)
		{
			Calendario cal = new Calendario (ref entFechaNacimientoInstructor);
			cal.Show ();

			//throw new NotImplementedException ();
		}

		//Método que abre una ventana con el Widget de calendario. Pasa por referencia un entry y devuelve una fecha.
		protected void OnButCalendarioIngresoInstructorClicked (object sender, EventArgs e)
		{
			Calendario cal = new Calendario (ref entFechaIngresoInstructor);
			cal.Show ();

			//throw new NotImplementedException ();
		}

		//Método que permite por medio del botón "Incluir" agregar un nuevo Instructor a la Base de Datos.
		protected void OnButIncluirInstructorClicked (object sender, EventArgs e)
		{
			bool exp = ((entCodigoInstructor.Text == "") || (entCedulaInstructor.Text == "") || (entNombreInstructor.Text == "") || (entApellidoInstructor.Text == "") || (entDireccionInstructor.Text == "") || (entFechaNacimientoInstructor.Text == "") || entFechaIngresoInstructor.Text == "" || entCorreoInstructor.Text == "" || (cbboxEstatusInstructor.Active == 0) || (cbboxGeneroInstructor1.Active == 0));

			string codigo = entCodigoInstructor.Text;
			string cedula =  entCedulaInstructor.Text;
			string nombre = entNombreInstructor.Text;
			string apellido = entApellidoInstructor.Text;
			string genero = cbboxGeneroInstructor1.ActiveText;
			string fechaNac = entFechaNacimientoInstructor.Text;
			string direccion = entDireccionInstructor.Text;
			string fechaIng = entFechaIngresoInstructor.Text;
			string correo = entCorreoInstructor.Text;
			string tlf = entTlfInstructor.Text;
			string profesion = con.EjecutarScalar ("select codPro from profesion where estatusPro = 'A' and descripcionPro = '" + cbboxProfesionInstructor.ActiveText + "';");
			string estatusCombo = cbboxEstatusInstructor.ActiveText;
			string estatus = "";

			if (estatusCombo == "Activo")
				estatus = "A";
			else
				estatus = "E";

			DateTime fechaN = Convert.ToDateTime (fechaNac);

			int resultadoFecha = Convert.ToInt16 (DateTime.Now.Year - fechaN.Year);

			//Método para comprobar el género y la edad.
			//Masculino. La edad del instructor debe estar entre los 25 y 40 años.
			if ((cbboxGeneroInstructor1.Active == 1) && ((resultadoFecha >= 25) && (resultadoFecha <= 40))) 
			{
				genero = cbboxGeneroInstructor1.ActiveText;
			} 
			//Femenino. La edad del instructor debe estar entre los 20 y 30 años.
			else if ((cbboxGeneroInstructor1.Active == 2) && ((resultadoFecha >= 20) && (resultadoFecha <= 30))) 
			{
				genero = cbboxGeneroInstructor1.ActiveText;
			} 
			//Edad incorrecta.
			else 
			{
				con.Mensaje("Verifique el género y la edad ingresada.", ButtonsType.Ok, MessageType.Error, "Verificación");
				return;
			}

			string sent = "INSERT INTO instructor VALUES ('" + codigo + "', '" + cedula + "', '" + nombre + "', '" + apellido + "', '" + genero + "', '" + fechaNac + "', '" + direccion + "', '" + fechaIng + "', '" + correo + "', '" + tlf + "', '" + profesion +"', '" + estatus + "');";

			IncluirInfo (busquedaIns, resultadoIns, limIns, exp, sent);

			if (limIns == true)
			{
				entCodigoInstructor.Text = "";
				limpiarInstructor();
				busquedaIns = false;
				resultadoIns = false;
			}

			butIncluirInstructor.Sensitive = false;
			butBuscarInstructor.Sensitive = true;
			limpiarInstructor();


			//throw new NotImplementedException ();
		}

		//Método que permite por medio del botón "Modificar" la edición de datos de un Instructor en la Base de Datos.
		protected void OnButModificarInstructorClicked (object sender, EventArgs e)
		{
			bool exp = ((entCedulaInstructor.Text == "") || (entNombreInstructor.Text == "") || (entApellidoInstructor.Text == "") || (cbboxGeneroInstructor1.Active == 0) || (entFechaNacimientoInstructor.Text == "") || (entDireccionInstructor.Text == "") || (entFechaIngresoInstructor.Text == "") || (entCorreoInstructor.Text == "") || (entTlfInstructor.Text == "") || (cbboxEstatusInstructor.Active == 0));

			string cedula = entCedulaInstructor.Text;
			string nombre = entNombreInstructor.Text;
			string apellido = entApellidoInstructor.Text;
			string genero = cbboxGeneroInstructor1.ActiveText;
			string fechaNac = entFechaNacimientoInstructor.Text;
			string direccion = entDireccionInstructor.Text;
			string fechaIng = entFechaIngresoInstructor.Text;
			string correo = entCorreoInstructor.Text;
			string tlf = entTlfInstructor.Text;
			string profesion = con.EjecutarScalar ("select codPro from profesion where estatusPro = 'A' and descripcionPro = '" + cbboxProfesionInstructor.ActiveText + "';");
	
			DateTime fechaN = Convert.ToDateTime (fechaNac);

			int resultadoFecha = Convert.ToInt16 (DateTime.Now.Year - fechaN.Year);

			//Método para comprobar el género y la edad.
			//Masculino. La edad del instructor debe estar entre los 25 y 40 años.
			if ((cbboxGeneroInstructor1.Active == 1) && ((resultadoFecha >= 25) && (resultadoFecha <= 40))) 
			{
				genero = cbboxGeneroInstructor1.ActiveText;
			} 
			//Femenino. La edad del instructor debe estar entre los 20 y 30 años.
			else if ((cbboxGeneroInstructor1.Active == 2) && ((resultadoFecha >= 20) && (resultadoFecha <= 30))) 
			{
				genero = cbboxGeneroInstructor1.ActiveText;
			} 
			//Edad incorrecta.
			else 
			{
				con.Mensaje("Verifique el género y la edad ingresada.", ButtonsType.Ok, MessageType.Error, "Verificación");
				return;
			}

			string sent = "UPDATE instructor SET cedulaIns = '" + cedula + "', nombreIns = '" + nombre + "', apellidoIns = '" + apellido + "', generoIns = '" + genero + "', fechaNacIns = '" + fechaNac + "', direccionIns = '" + direccion + "', fechaIngreso = '" + fechaIng + "', correoIns = '" + correo + "', tlfnIns = '" + tlf + "', codProIns = '" + profesion +"' WHERE codIns = '" + entCodigoInstructor.Text + "';";

			ModificarInfo (busquedaIns, resultadoIns, limIns, exp, sent);

			if (limIns == true)
			{
				entCodigoInstructor.Text = "";
				limpiarInstructor();
				busquedaIns = false;
				resultadoIns = false;
			} 


			//throw new NotImplementedException ();
		}

		//Método que permite por medio del botón "Retirar" cambiar el estatus a "Retirado" de un Instructor en la Base de Datos.
		protected void OnButRetirarInstructorClicked (object sender, EventArgs e)
		{
			if (resultadoIns == true) 
			{	
				//Sentencia para verificar que el instructor no se encuentre dando clases a algún grupo.
				int num = Convert.ToInt16(con.EjecutarScalar("select count(codIns) from grupo_instructor, grupo where fechaCul < now() and grupo.codGru = grupo_instructor.codGru and codIns = '" +  entCodigoInstructor.Text + "';"));

				//El instructor se encuentra dando clases a algún grupo.
				if (num != 0) 
				{
					con.Mensaje ("El instructor " + entNombreInstructor.Text + " está dando clases a algún grupo actualmente.\nPrimero modifique la información del grupo.", ButtonsType.Ok, MessageType.Error, "Retiro");
					return;
				} 
				//El instructor no se encuentra dando clases a ningún grupo.
				else 
				{
					if (con.Mensaje ("¿Está seguro de retirar al instructor " + entNombreInstructor.Text + "?", ButtonsType.YesNo, MessageType.Question, "Pregunta") == ResponseType.Yes) 
					{
						con.EjecutarSentencia ("UPDATE instructor SET estatusIns = 'E' WHERE codIns = '" + entCodigoInstructor.Text + "'");
						con.Mensaje ("El instructor " + entNombreInstructor.Text + " ha sido retirado con éxito.", ButtonsType.Ok, MessageType.Info, "Info");
					} 
					else
						return;

					if (limIns == true)
					{
						entCodigoInstructor.Text = "";
						limpiarInstructor();
						busquedaIns = false;
						resultadoIns = false;
					} 
				}
			
			}

			//throw new NotImplementedException ();
		}

		//Método que permite por medio del botón "Eliminar" borrar a un Instructor de la Base de Datos.
		protected void OnButEliminarInstructorClicked (object sender, EventArgs e)
		{
			if (resultadoIns) 
			{
				//Se cuenta las veces que aparece un instructor.
				int num = Convert.ToInt16 (con.EjecutarScalar ("select count(codIns) from grupo_instructor where codIns = '" + entCodigoInstructor.Text + "';"));
				//Si no se encuentra en ningún curso.
				if (num == 0) 
				{
					string sentencia = "delete from instructor where codIns = '" + entCodigoInstructor.Text +"';";
					EliminarInfo (busquedaIns, resultadoIns, limIns, sentencia);
					limIns = true;
				} 
				//Si está registrado a algún grupo.
				else 
				{
					con.Mensaje ("El instructor " + entNombreInstructor.Text + " se encuentra registrado en algunos grupos.\nModifique primero la información de los grupos.", ButtonsType.Ok, MessageType.Error, "Eliminar");
				
				}

				if (limIns == true)
				{
					entCodigoInstructor.Text = "";
					limpiarInstructor();
					busquedaIns = false;
					resultadoIns = false;
				}

			}
			//throw new NotImplementedException ();
		}

		//Método que permite por medio del botón "Reinscribir" cambiar el estatus a "Activo" de un Instructor en la Base de Datos.
		protected void OnButReingresoInstructorClicked (object sender, EventArgs e)
		{
			if (resultadoIns == true) 
			{	
				
				if (con.Mensaje ("¿Está seguro de reingresar al instructor " + entNombreInstructor.Text + "?", ButtonsType.YesNo, MessageType.Question, "Pregunta") == ResponseType.Yes) 
				{
					con.EjecutarSentencia ("UPDATE instructor SET estatusIns = 'A' WHERE codIns = '" + entCodigoInstructor.Text + "'");
					con.Mensaje ("El instructor " + entNombreInstructor.Text + " está disponible para laborar nuevamente.", ButtonsType.Ok, MessageType.Info, "Info");
				} 
				else
					return;

				if (limIns == true)
				{
					entCodigoInstructor.Text = "";
					limpiarInstructor();
					busquedaIns = false;
					resultadoIns = false;
				} 
			}
			//throw new NotImplementedException ();
		}

		/*Método que permite por medio del botón "Limpiar" llevar los respectivos entries, combobox, y demás erramientas de la 
		ventana de Instructor a sus valores iniciales.*/
		protected void OnButLimpiarInstructorClicked (object sender, EventArgs e)
		{
			entCodigoInstructor.Text = "";
			limpiarInstructor ();
			busquedaIns = false;

			//throw new NotImplementedException ();
		}


		/*======================================================================================================
		Pestaña "Estudiantes": Permite la actualización, inclusión, eliminación, retiro, de estudiantes.
		======================================================================================================*/

		//Generalización de métodos repetitivos para Estudiante.

		//Devolver las herramientas de recolección de datos de Estudiante a sus valores iniciales.
		protected void limpiarEstudiante ()
		{
			entCedulaEstudiante.Text = "";
			entNombreEstudiante.Text = "";
			entApellidoEstudiante.Text = "";
			cbboxGeneroEstudiante.Active = 0;
			entFechaNacimientoEstudiante.Text = "";
			entDireccionEstudiante.Text = "";
			entTlfEstudiante.Text = "";
			cbboxGrupoEstudiante.Active = 0;
			entCorreoEstudiante.Text = "";
			entCursoEstudiante.Text = "";
			cbboxEstatusEstudiante.Active = 0;
			butBuscarEstudiante.Sensitive = true;
			labEstatusEstudiante.Sensitive = true;
			cbboxEstatusEstudiante.Sensitive = true;
			entCodigoEstudiante.Sensitive = true;
			butIncluirEstudiante.Sensitive = false;
			butModificarEstudiante.Sensitive = false;
			butRetirarEstudiante.Sensitive = false;
			butEliminarEstudiante.Sensitive = false;
			butRetirarEstudiante.Sensitive = false;
		}

		//Métodos propios de la ventana Estudiante.

		protected void OnEntCodigoEstudianteChanged (object sender, EventArgs e)
		{
			bas.validarAlfanumerico (entCodigoEstudiante);

			//throw new NotImplementedException ();
		}

		protected void OnEntCedulaEstudianteChanged (object sender, EventArgs e)
		{
			bas.validarEntero (entCedulaEstudiante);

			//throw new NotImplementedException ();
		}

		protected void OnButBuscarEstudianteClicked (object sender, EventArgs e)
		{
			//Valida que el campo de Código de Estudiante no se encuentre vacío.
			if (entCodigoEstudiante.Text == "") {
				con.Mensaje ("Por favor, ingrese el código del estudiante.", ButtonsType.Ok, MessageType.Error, "Error");
			}
			else {
				//Valida que exista el registro.
				if (con.BuscarTodos ("codEst", "estudiante", entCodigoEstudiante.Text) == false) {

					con.Mensaje ("El estudiante no existe.", ButtonsType.Ok, MessageType.Error, "");
					busquedaEst = true;
					resultadoEst = false;
					validacionesBotones ();
					return;	
				}

				else 
				{					
					//Se elabora la sentencia con los datos a buscar.
					string sentenciaSQL = "select cedulaEst, nombreEst, apellidoEst, generoEst, direccionEst, fechaNacEst, tlfnEst, grupo.codGru, correoEst, estatusEst from estudiante, grupo, grupo_estudiante where grupo_estudiante.codEst = estudiante.codEst and grupo.codGru = grupo_estudiante.codGru and estudiante.codEst = '" + entCodigoEstudiante.Text + "';";
					//Se hace un arreglo que contenga los datos solicitados por la sentencia SQL.
					string[] array = con.Listado(10, sentenciaSQL);

					entCedulaEstudiante.Text = array [0];
					entNombreEstudiante.Text = array [1];
					entApellidoEstudiante.Text = array [2];

					if (array [3] == "Masculino") {
						cbboxGeneroEstudiante.Active = 1;
					}

					if (array [3] == "Femenino") {
						cbboxGeneroEstudiante.Active = 2;
					}

					entDireccionEstudiante.Text = array [4];

					DateTime fechaNac = Convert.ToDateTime (array [5]);
					entFechaNacimientoEstudiante.Text = fechaNac.ToString ("yyyy/MM/dd");

					entTlfEstudiante.Text = array [6];

					for (int i = 0; i < cantGrupos; i++) {
						if (grupos [i] == array [7])
							cbboxGrupoEstudiante.Active = i;
					}

					entCorreoEstudiante.Text = array [8];

					if (array [9] == "A") {
						cbboxEstatusEstudiante.Active = 1;
					}
					else {
						cbboxEstatusInstructor.Active = 2;
					}

					//Se bloquea el entry de Código y el botón de Buscar, así mismo, se activa el bool de resultado.
					entCodigoEstudiante.Sensitive = false;
					butBuscarEstudiante.Sensitive = false;
					labEstatusEstudiante.Sensitive = false;
					cbboxEstatusEstudiante.Sensitive = false;

					resultadoEst = true;
					busquedaEst = true;
					validacionesBotones ();
				}

			}
		}

		protected void OnEntNombreEstudianteChanged (object sender, EventArgs e)
		{
			bas.validarLetras (entNombreEstudiante);

			//throw new NotImplementedException ();
		}

		protected void OnEntApellidoEstudianteChanged (object sender, EventArgs e)
		{
			bas.validarLetras (entApellidoEstudiante);

			//throw new NotImplementedException ();
		}

		protected void OnEntDireccionEstudianteChanged (object sender, EventArgs e)
		{
			bas.validarDireccion (entDireccionEstudiante);

			//throw new NotImplementedException ();
		}

		//Permite conocer el curso del grupo al que se está accediendo.
		protected void OnCbboxGrupoEstudianteChanged (object sender, EventArgs e)
		{
			string curso = con.EjecutarScalar("select nombreCur from grupo, curso where curso.codCur = grupo.codCur and codGru = '" + cbboxGrupoEstudiante.ActiveText + "';");

			entCursoEstudiante.Text = curso;

			//throw new NotImplementedException ();
		}

		protected void OnEntTlfEstudianteChanged (object sender, EventArgs e)
		{
			for (int i = 0; i < entTlfEstudiante.Text.Length; i++) {
				if (entTlfEstudiante.Text.Length <= 12)
					bas.validarTlf (entTlfEstudiante);
				else
					entTlfEstudiante.Text = entTlfEstudiante.Text.Substring (0, entTlfEstudiante.Text.Length - 1);
			}

			//throw new NotImplementedException ();
		}

		protected void OnEntCorreoEstudianteChanged (object sender, EventArgs e)
		{
			bas.validarCorreo (entCorreoEstudiante);

			//throw new NotImplementedException ();
		}

		//Método que abre una ventana con el Widget de calendario. Pasa por referencia un entry y devuelve una fecha.
		protected void OnButCalendarioEstudianteClicked (object sender, EventArgs e)
		{
			Calendario cal = new Calendario (ref entFechaNacimientoEstudiante);
			cal.Show ();

			//throw new NotImplementedException ();
		}

		//Método que permite por medio del botón "Incluir" agregar un nuevo Estudiante a la Base de Datos.
		protected void OnButIncluirEstudianteClicked (object sender, EventArgs e)
		{
			bool exp = ((entCodigoEstudiante.Text == "") || (entCedulaEstudiante.Text == "") || (entNombreEstudiante.Text == "") ||
                (entApellidoEstudiante.Text == "") || (entDireccionEstudiante.Text == "") || (entFechaNacimientoEstudiante.Text == "") ||
                (entCorreoEstudiante.Text == "") || (cbboxEstatusEstudiante.Active == 0) || (cbboxGeneroEstudiante.Active == 0) ||
                (cbboxGrupoEstudiante.Active == 0) || (entCursoEstudiante.Text == ""));

            string codigo = entCodigoEstudiante.Text;
            string cedula = entCedulaEstudiante.Text;
            string nombre = entNombreEstudiante.Text;
            string apellido = entApellidoEstudiante.Text;
            string genero = cbboxGeneroEstudiante.ActiveText;
            string fechaNac = entFechaNacimientoEstudiante.Text;
            string direccion = entDireccionEstudiante.Text;
            string correo = entCorreoEstudiante.Text;
            string tlf = entTlfEstudiante.Text;
            string grupo = cbboxGrupoEstudiante.ActiveText;
            string estatusCombo = cbboxEstatusEstudiante.ActiveText;
            string cursoEst = entCursoEstudiante.Text;
            string estatus = "";

            if (estatusCombo == "Activo")
                estatus = "A";
            else
                estatus = "E";

			string grupoE = con.EjecutarScalar ("select codGru from grupo where codGrupo = '"+ cbboxGrupoEstudiante.ActiveText + "';");
			string lapso = con.EjecutarScalar("select lapsoAcadGE from grupo_estudiante, grupo, estudiante where grupo.codGru = grupo_estudiante.codGru and estudiante.codEst = grupo_estudiante.codEst and grupo.codGru = '" + grupo + "' and codEst = '" + codigo + "';");

            string sent = "INSERT INTO estudiante VALUES ('" + codigo + "', '" + cedula + "', '" + nombre + "', '" + apellido + "', '" + genero + "','" + direccion + "', '" + fechaNac + "', '" + tlf + "','" + correo + "', '" + estatus + "');";
			string sent2 = "INSERT INTO grupo_estudiante VALUES ('" + grupoE + "', '" + codigo + "', '" + lapso + "');";

			if (resultadoEst == true)
				con.EjecutarSentencia (sent2);

            IncluirInfo(busquedaEst, resultadoEst, limEst, exp, sent);

            if (limIns == true)
            {
                entCodigoEstudiante.Text = "";
                limpiarEstudiante();
                busquedaEst = false;
                resultadoEst = false;
            }

            butIncluirEstudiante.Sensitive = false;
            butBuscarEstudiante.Sensitive = true;
            limpiarEstudiante();

			//throw new NotImplementedException ();
		}

		//Método que permite por medio del botón "Modificar" la edición de datos de un Estudiante en la Base de Datos.
		protected void OnButModificarEstudianteClicked (object sender, EventArgs e)
		{
			bool exp = ((entCedulaEstudiante.Text == "") || (entNombreEstudiante.Text == "") || (entApellidoEstudiante.Text == "") || (cbboxGeneroEstudiante.Active == 0) || (entFechaNacimientoEstudiante.Text == "") || (entDireccionEstudiante.Text == "") || (entCorreoEstudiante.Text == "") || (entTlfEstudiante.Text == "") || (cbboxEstatusEstudiante.Active == 0));

			string codigo = entCodigoEstudiante.Text;
            string cedula = entCedulaEstudiante.Text;
            string nombre = entNombreEstudiante.Text;
            string apellido = entApellidoEstudiante.Text;
            string genero = cbboxGeneroEstudiante.ActiveText;
            string direccion = entDireccionEstudiante.Text;
			string fechaNac = entFechaNacimientoEstudiante.Text;
			string tlf = entTlfEstudiante.Text;
            string correo = entCorreoEstudiante.Text;


			string grupo = cbboxGrupoEstudiante.ActiveText;
			string lapso = con.EjecutarScalar("select lapsoAcadGE from grupo_estudiante, grupo, estudiante where grupo.codGru = grupo_estudiante.codGru and estudiante.codEst = grupo_estudiante.codEst and grupo.codGru = '" + grupo + "' and estudiante.codEst = '" + codigo + "';");
           
          
			string sent = "UPDATE estudiante SET cedulaEst = '" + cedula + "', nombreEst = '" + nombre + "', apellidoEst = '" + apellido + "', generoEst = '" + genero + "', direccionEst = '" + direccion + "',fechaNacEst = '" + fechaNac + "', tlfnEst = '" + tlf + "', correoEst = '" + correo + "' WHERE codEst = '" + codigo + "';";
			string sent2 = "UPDATE grupo_estudiante SET lapsoAcadGE = '" + lapso + "' WHERE codEst = '" + codigo + "' and codGru = '" + grupo + "';";

			if (resultadoEst == true)
				con.EjecutarSentencia (sent2);

			ModificarInfo (busquedaEst, resultadoEst, limEst, exp, sent);

			if (limEst == true)
            {
                entCodigoEstudiante.Text = "";
                limpiarEstudiante();
				busquedaEst = false;
				resultadoEst = false;
            }

			//throw new NotImplementedException ();
		}

		//Método que permite por medio del botón "Retirar" cambiar el estatus a "Retirado" de un Estudiante en la Base de Datos.
		protected void OnButRetirarEstudianteClicked (object sender, EventArgs e)
		{


			//throw new NotImplementedException ();
		}

		//Método que permite por medio del botón "Eliminar" borrar a un Estudiante de la Base de Datos.
		protected void OnButEliminarEstudianteClicked (object sender, EventArgs e)
		{


			//throw new NotImplementedException ();
		}

		//Método que permite por medio del botón "Reinscribir" cambiar el estatus a "Activo" de un Estudiante en la Base de Datos.
		protected void OnButReinscribirEstudianteClicked (object sender, EventArgs e)
		{


			//throw new NotImplementedException ();
		}

		/*Método que permite por medio del botón "Limpiar" llevar los respectivos entries, combobox, y demás herramientas de la 
		ventana de Estudiante a sus valores iniciales.*/
		protected void OnButLimpiarEstudianteClicked (object sender, EventArgs e)
		{
			entCodigoEstudiante.Text = "";
			limpiarEstudiante ();
			busquedaEst = false;

			//throw new NotImplementedException ();
		}


		/*======================================================================================================
		Pestaña "Grupos": Permite la actualización, inclusión, modificación, eliminación, de grupos.
		======================================================================================================*/

		//Generalización de métodos repetitivos.

		//Devuelve a los campos iniciales todas las herramientas de captación de datos.
		protected void limpiarGrupos ()
		{
			entFechaInicioGrupo.Text = "";
			entFechaCulminacionGrupo.Text = "";
			cbboxTurnoGrupo.Active = 0;
			cbboxCursoGrupo.Active = 0;
			cbboxInstructorGrupo.Active = 0;
			cbboxEstatusGrupo.Active = 0;
			cbboxLapsoAcademico.Active = 0;
			butIncluirGrupo.Sensitive = false;
			butModificarGrupo.Sensitive = false;
			butEliminarGrupo.Sensitive = false;
			butLimpiarGrupo.Sensitive = true;
			butBuscarGrupo.Sensitive = true;
			entCodigoGrupo.Sensitive = true;
			labEstatusGrupo.Sensitive = true;

		}


		protected void OnEntCodigoGrupoChanged (object sender, EventArgs e)
		{
			bas.validarAlfanumerico (entCodigoGrupo);

			//throw new NotImplementedException ();
		}

		//Método que por medio del botón "Buscar" permite mostrar en la interfaz la información de un grupo.
		protected void OnButBuscarGrupoClicked (object sender, EventArgs e)
		{
			//Valida que el campo de Código de Estudiante no se encuentre vacío.
			if (entCodigoGrupo.Text == "") {
				con.Mensaje ("Por favor, ingrese el código del grupo.", ButtonsType.Ok, MessageType.Error, "Error");
			} else {
				//Valida que exista el registro.
				if (con.BuscarTodos ("codGru", "grupo", entCodigoGrupo.Text) == false) {
					con.Mensaje ("El grupo no existe.", ButtonsType.Ok, MessageType.Error, "");
					butIncluirGrupo.Sensitive = true;
					busquedaGru = true;
					resultadoGru = false;

					return;

				} 
				else {
					//Se elabora la sentencia con los datos a buscar.
					string sentenciaSQL = "select fechaIni, fechaCul, codTurGru, nombreCur, instructor.codIns, lapsoAcadGI, estatusGru from curso, grupo, instructor, grupo_instructor, turno where curso.codCur = grupo.codCur and codTurGru = codTur and grupo_instructor.codIns = instructor.codIns and grupo.codGru = grupo_instructor.codGru and grupo.codGru = '" + entCodigoGrupo.Text + "';";
					//Se hace un arreglo que contenga los datos solicitados por la sentencia SQL.
					string[] array = con.Listado (7, sentenciaSQL);

					DateTime fechaInicio = Convert.ToDateTime (array [0]);
					entFechaInicioGrupo.Text = fechaInicio.ToString ("yyyy/MM/dd");

					DateTime fechaCulminacion = Convert.ToDateTime (array [1]);
					//Es enviada al entry correspondiente.
					entFechaCulminacionGrupo.Text = fechaCulminacion.ToString ("yyyy/MM/dd");

					//Se lleva a la posición correspondiente del comboBox de turnos.
					for (int i = 0; i < cantTurnos; i++) {
						if (turnos [i] == array [2])
							cbboxTurnoGrupo.Active = i;
					}

					//Se lleva a la posición correspondiente del comboBox de cursos.
					for (int i = 0; i < cantCursos; i++) {
						if (cursosArray [i] == array [3])
							cbboxCursoGrupo.Active = i;
					}

					//Se lleva a la posición correspondiente del comboBox de instructor.
					for (int i = 0; i < cantInstructores; i++) {
						if (instructores [i] == array [4])
							cbboxInstructorGrupo.Active = i;
					}

					//Se lleva a la posición correspondiente del comboBox de lapsos Académicos.
					for (int i = 0; i < cantLapsosAcademicos; i++) {
						if (lapsosAcademicos [i] == array [5])
							cbboxLapsoAcademico.Active = i;
					}

					//Se lleva a la posición correspondiente del comboBox de estatus.
					if (array [6] == "A") {
						cbboxEstatusGrupo.Active = 1;
					} else {
						cbboxEstatusGrupo.Active = 2;
					}

					//Se bloquea el entry de Código y el botón de Buscar, así mismo, se activa el bool de resultado.
					entCodigoGrupo.Sensitive = false;
					butBuscarGrupo.Sensitive = false;

					//Se habilitan los otros botones.
					butModificarGrupo.Sensitive = true;
					butEliminarGrupo.Sensitive = true;

					resultadoGru = true;
					busquedaGru = true;
				}
			}

			//throw new NotImplementedException ();
		}

		protected void OnButCalendarioInicioGrupoClicked (object sender, EventArgs e)
		{
			Calendario cal = new Calendario (ref entFechaInicioGrupo);
			cal.Show ();

			//throw new NotImplementedException ();
		}

		protected void OnButCalendarioCulminacionGruppoClicked (object sender, EventArgs e)
		{
			Calendario cal = new Calendario (ref entFechaCulminacionGrupo);
			cal.Show ();

			//throw new NotImplementedException ();
		}

		//Método que por medio del botón "Incluir" permite añadir nuevos registros a la tabla de Grupo.
		protected void OnButIncluirGrupoClicked (object sender, EventArgs e)
		{
			bool exp = ((entCodigoGrupo.Text == "") || (entFechaInicioGrupo.Text == "") || (entFechaCulminacionGrupo.Text == "") || (cbboxEstatusGrupo.Active == 0));

			string codigo = entCodigoGrupo.Text;
			string fechaIni =  entFechaInicioGrupo.Text;
			string fechaCul = entFechaCulminacionGrupo.Text;
			string turno = cbboxTurnoGrupo.ActiveText;

			string curso = con.EjecutarScalar ("select codCur from curso where nombreCur = '" + cbboxCursoGrupo.ActiveText + "';");

			string estatusCombo = cbboxEstatusGrupo.ActiveText;
			string estatus = "";

			if (estatusCombo == "Activo")
				estatus = "A";
			else
				estatus = "E";

			string codIns = cbboxInstructorGrupo.ActiveText;
			string lapsoAcad = cbboxLapsoAcademico.ActiveText;


			string sent1 = "INSERT INTO grupo VALUES ('" + codigo + "', '" + fechaIni + "', '" + fechaCul + "', '" + curso + "', '" + turno + "', '" + estatus + "');";
			string sent2 = "INSERT INTO grupo_instructor VALUES ('" + codigo + "', '" + codIns + "', '" + lapsoAcad + "');";


			if(resultadoGru == false)
				con.EjecutarSentencia(sent2);
			IncluirInfo (busquedaGru, resultadoGru, limGru, exp, sent1);


			if (limGru == true)
			{
				entCodigoGrupo.Text = "";
				butBuscarGrupo.Sensitive = true;
				limpiarGrupos();
				busquedaGru = false;
				resultadoGru = false;

			}

			//throw new NotImplementedException ();
		}

		//Método que por medio del botón "Modificar" permite editar la información del grupo seleccionado.
		protected void OnButModificarGrupoClicked (object sender, EventArgs e)
		{
			bool exp = ((entCodigoGrupo.Text == "") || (entFechaInicioGrupo.Text == "") || (entFechaCulminacionGrupo.Text == "") || (cbboxEstatusGrupo.Active == 0));

			string codigo = entCodigoGrupo.Text;
			string fechaIni =  entFechaInicioGrupo.Text;
			string fechaCul = entFechaCulminacionGrupo.Text;
			string turno = cbboxTurnoGrupo.ActiveText;
		
			string curso = con.EjecutarScalar ("select codCur from curso where nombreCur = '" + cbboxCursoGrupo.ActiveText + "';");

			string estatusCombo = cbboxEstatusGrupo.ActiveText;
			string estatus = "";

			if (estatusCombo == "Activo")
				estatus = "A";
			else
				estatus = "E";

			string codIns = cbboxInstructorGrupo.ActiveText;
			string lapsoAcad = cbboxLapsoAcademico.ActiveText;


			string sent1 = "UPDATE grupo SET fechaIni = '" + fechaIni + "', fechaCul = '" + fechaCul + "', codCur = '" + curso + "', codTurGru = '" + turno + "', estatusGru = '" + estatus + "' WHERE codGru = '" + codigo + "';";
			string sent2 = "UPDATE grupo_instructor SET codIns = '" + codIns + "', lapsoAcadGI = '" + lapsoAcad + "' WHERE codGru = '" + codigo + "';";


			if(resultadoGru == true)
				con.EjecutarSentencia(sent2);
			ModificarInfo (busquedaGru, resultadoGru, limGru, exp, sent1);


			if (limGru == true)
			{
				entCodigoGrupo.Text = "";
				butBuscarGrupo.Sensitive = true;
				limpiarGrupos();
				busquedaGru = false;
				resultadoGru = false;

			}


			//throw new NotImplementedException ();
		}

		//Método que por medio del botón "Eliminar" permite borrar la información del grupo seleccionado.
		protected void OnButEliminarGrupoClicked (object sender, EventArgs e)
		{
			if (resultadoGru) 
			{
				//Se verifica que el grupo esté inactivo.
				string estatusGru = con.EjecutarScalar("select estatusGru from grupo where codGru = '" + entCodigoGrupo.Text + "';");
				int num = 0;

				//Se asigna un valor a num.
				if (estatusGru == "A")
					num = 1;
				else
					num = 0;
				
				//Si no se encuentra activo.
				if (num == 0) 
				{
					string sentencia = "delete from grupo where codGru = '" + entCodigoGrupo.Text +"';";
					EliminarInfo (busquedaGru, resultadoGru, limGru, sentencia);

					con.EjecutarSentencia ("delete from grupo_instructor where codGru = '" + entCodigoGrupo.Text +"';");
					limGru = true;
				} 
				//Si está registrado a algún grupo.
				else 
				{
					con.Mensaje ("El grupo " + entCodigoGrupo.Text + " se encuentra activo.\nModifique primero su información.", ButtonsType.Ok, MessageType.Error, "Eliminar");

				}

				if (limGru == true)
				{
					entCodigoGrupo.Text = "";
					limpiarGrupos();
					busquedaGru = false;
					resultadoGru = false;
				}

			}

			//throw new NotImplementedException ();
		}

		//Método que por medio del botón "Limpiar" permite devolver a sus estados inciales todas las herramientas.
		protected void OnButLimpiarGrupoClicked (object sender, EventArgs e)
		{
			entCodigoGrupo.Text = "";
			limpiarGrupos ();


			//throw new NotImplementedException ();
		}



		/*======================================================================================================
		Pestaña "Cursos": Permite la actualización, inclusión, eliminación, de cursos.
		======================================================================================================*/

		protected void limpiarCurso ()
		{
			entCodigoCurso.Text = "";
			entNombreCurso.Text = "";
			entDescripcion.Text = "";
			cbboxEstatusCurso.Active = 0;
			butIncluirCurso.Sensitive = false;
			butModificarCurso.Sensitive = false;
			butEliminarCurso.Sensitive = false;
			butLimpiarCurso.Sensitive = true;
			butBuscarCurso.Sensitive = true;
			entCodigoCurso.Sensitive = true;
			labEstatusCurso.Sensitive = true;
			labCaracteres.Text = "160";

		}


		protected void OnEntDescripcionChanged (object sender, EventArgs e)
		{
			string descripcion = entDescripcion.Text;

			for (int i = 0; i < descripcion.Length; i++) 
			{
				if (descripcion.Length <= 160) 
				{
					
				} 
				else 
				{
					entDescripcion.Text = descripcion.Substring (0, descripcion.Length - 1);
				}

				labCaracteres.Text = Convert.ToString (160 - descripcion.Length);
						
			}

			//throw new NotImplementedException ();
		}

		protected void OnButBuscarCursoClicked (object sender, EventArgs e)
		{
			//Valida que el campo de Código de Estudiante no se encuentre vacío.
			if (entCodigoCurso.Text == "") {
				con.Mensaje ("Por favor, ingrese el código del curso.", ButtonsType.Ok, MessageType.Error, "Error");
			} else {
				//Valida que exista el registro.
				if (con.BuscarTodos ("codCur", "curso", entCodigoCurso.Text) == false) {
					con.Mensaje ("El curso no existe.", ButtonsType.Ok, MessageType.Error, "");
					butIncluirCurso.Sensitive = true;
					busquedaCur = true;
					resultadoCur = false;

					return;

				} 
				else {
					//Se elabora la sentencia con los datos a buscar.
					string sentenciaSQL = "select nombreCur, descripcionCur, estatusCur from curso where codCur = '" + entCodigoCurso.Text + "';";
					//Se hace un arreglo que contenga los datos solicitados por la sentencia SQL.
					string[] array = con.Listado (3, sentenciaSQL);

					entNombreCurso.Text = array [0];
					entDescripcion.Text = array [1];

					//Se lleva a la posición correspondiente del comboBox de estatus.
					if (array [2] == "A") {
						cbboxEstatusCurso.Active = 1;
					} else {
						cbboxEstatusCurso.Active = 2;
					}

					//Se bloquea el entry de Código y el botón de Buscar, así mismo, se activa el bool de resultado.
					entCodigoCurso.Sensitive = false;
					butBuscarCurso.Sensitive = false;

					//Se habilitan los otros botones.
					butModificarCurso.Sensitive = true;
					butEliminarCurso.Sensitive = true;

					resultadoCur = true;
					busquedaCur = true;
				}
			}

			//throw new NotImplementedException ();
		}

		protected void OnButIncluirCursoClicked (object sender, EventArgs e)
		{
			bool exp = ((entCodigoCurso.Text == "") || (entNombreCurso.Text == "") || (entDescripcion.Text == "") || (cbboxEstatusCurso.Active == 0));

			string codigo = entCodigoCurso.Text;
			string nombre =  entNombreCurso.Text;
			string descripcion = entDescripcion.Text;

			string estatusCombo = cbboxEstatusGrupo.ActiveText;
			string estatus = "";

			if (estatusCombo == "Activo")
				estatus = "A";
			else
				estatus = "E";

		
			string sent = "INSERT INTO grupo VALUES ('" + codigo + "', '" + nombre + "', '" + descripcion + "', '" + estatus + "');";
		
			IncluirInfo (busquedaCur, resultadoCur, limCur, exp, sent);


			if (limCur == true)
			{
				entCodigoCurso.Text = "";
				butBuscarCurso.Sensitive = true;
				limpiarCurso ();
				busquedaCur = false;
				resultadoCur = false;

			}

			//throw new NotImplementedException ();
		}

		protected void OnButModificarCursoClicked (object sender, EventArgs e)
		{
			bool exp = ((entCodigoCurso.Text == "") || (entNombreCurso.Text == "") || (entDescripcion.Text == "") || (cbboxEstatusCurso.Active == 0));

			//Se verifica que el grupo esté inactivo.
			int num = Convert.ToInt16(con.EjecutarScalar("select count(codGru) from grupo where fechaCul >= now() and codCur = '" + entCodigoCurso.Text + "';"));

				if(num != 0)
				{
					con.Mensaje("El curso tiene adjunto así mismo varios grupos. Modifique la información de los grupos.", ButtonsType.Ok, MessageType.Error, "Error");
					return;
				}


			string codigo = entCodigoCurso.Text;
			string nombre =  entNombreCurso.Text;
			string descripcion = entDescripcion.Text;

			string estatusCombo = cbboxEstatusGrupo.ActiveText;
			string estatus = "";

			if (estatusCombo == "Activo")
				estatus = "A";
			else
				estatus = "E";

			string sent1 = "UPDATE curso SET nombreCur = '" + nombre + "', descripcionCur = '" + descripcion + "', estatusCur = '" + estatus + "' WHERE codCur = '" + codigo + "';";
	
			ModificarInfo (busquedaCur, resultadoCur, limCur, exp, sent1);


			if (limCur == true)
			{
				entCodigoCurso.Text = "";
				butBuscarCurso.Sensitive = true;
				limpiarCurso ();
				busquedaCur = false;
				resultadoCur = false;

			}

			//throw new NotImplementedException ();
		}

		protected void OnButEliminarCursoClicked (object sender, EventArgs e)
		{
			if (resultadoCur) 
			{
				//Se verifica que el grupo esté inactivo.
				int num = Convert.ToInt16(con.EjecutarScalar("select count(codGru) from grupo where codCur = '" + entCodigoCurso.Text + "';"));

				//Si no se encuentra activo.
				if (num == 0) 
				{
					string sentencia = "delete from curso where codCur = '" + entCodigoCurso.Text +"';";
					EliminarInfo (busquedaCur, resultadoCur, limCur, sentencia);

					con.EjecutarSentencia ("delete from grupo where codCur = '" + entCodigoCurso.Text +"';");
					limCur = true;
				} 
				//Si está registrado a algún grupo.
				else 
				{
					con.Mensaje ("El curso " + entCodigoCurso.Text + " tiene algunos grupos adjuntos a él.\nModifique primero la información de los grupos.", ButtonsType.Ok, MessageType.Error, "Eliminar");

				}

				if (limCur == true)
				{
					entCodigoCurso.Text = "";
					limpiarCurso ();
					busquedaCur = false;
					resultadoCur = false;
				}

			}

			//throw new NotImplementedException ();
		}

		protected void OnButLimpiarCursoClicked (object sender, EventArgs e)
		{
			entCodigoCurso.Text = "";
			limpiarCurso ();

			//throw new NotImplementedException ();
		}

		protected void OnEntDiaSemanaChanged (object sender, EventArgs e)
		{
			string dia = con.EjecutarScalar ("select nombreDiaS from turno, diasemana where turno.codDiaS = diasemana.codDiaS and codTur = '" + cbboxTurnoGrupo.ActiveText + "';");

			entDiaSemana.Text = dia;

			//throw new NotImplementedException ();
		}

		protected void OnEntBloqueChanged (object sender, EventArgs e)
		{
			string bloque = con.EjecutarScalar ("select codBlo from turno where codTur = '" + cbboxTurnoGrupo.ActiveText + "';");
			string descr = con.EjecutarScalar ("select descripcionBlo from bloque, turno where turno.codBlo = bloque.codBlo and codTur = '" + cbboxTurnoGrupo.ActiveText + "';");

			entBloque.Text = bloque + ": " + descr;

		//	throw new NotImplementedException ();
		}
	}
}

