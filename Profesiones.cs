/*Proyecto; Damage Control.
Equipo N°5. Integrantes:
Yurisbellys Brizuela. C.I: 27.142.239
Franklin Camacho. C.I: 26.796.912
Jesús Leal. C.I: 26.561.030
Marihec Miranda. C.I: 26.120.075
Gustavo Rivero. C.I: 26.772.857*/

//Profesiones: Ventana genérica que permite ingresar las respectivas profesiones de un instructor.

//Se colocan las librerías a utilizar por el programa.
using System;
using Gtk;

namespace DamageControl
{
	public partial class Profesiones : Gtk.Window
	{
		//Entry a utilizar.
		Entry ent;
		ConexBD con;

		//Sentencia SQL para las profesiones.
		string Sentencia;

		//Variables a utilizar.
		string[] profesionesArreglo;
		int profesionesNum;

		public Profesiones (string codigoInstructor, string nombreCompletoInstructor, ref Entry entProf, ref string SentenciaSQL) : base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
			con = new ConexBD (this);

			ent = entProf;
			Sentencia = SentenciaSQL;

			entCodigoInstructor.Text = codigoInstructor;
			entNombreInstructor.Text = nombreCompletoInstructor;
			entCodigoInstructor.IsEditable = false;
			entNombreInstructor.IsEditable = false;

			//Inicialización de ComboBoxes
			cbboxProfesion1.Model = cargarProfesiones ();
			cbboxProfesion2.Model = cargarProfesiones ();
			cbboxProfesion3.Model = cargarProfesiones ();
			cbboxProfesion4.Model = cargarProfesiones ();
			cbboxProfesion5.Model = cargarProfesiones ();
			cbboxProfesion6.Model = cargarProfesiones ();
			cbboxProfesion7.Model = cargarProfesiones ();
			cbboxProfesion8.Model = cargarProfesiones ();

			//De traer un Instructor existente.
			//instructorExistente ();
		
		}

		//Método que permite cargar un listado, específicamente de Profesiones.
		protected ListStore cargarProfesiones ()
		{
			//Se crea el objeto que servirá de lista.
			ListStore profesiones = new ListStore(typeof(string));

			//Se elabora la sentencia SQL.
			string sentencia = "select codPro, descripcionPro from profesion where estatusPro = 'A'";

			//Se elabora la sentencia SQL para conocer cuantos registros existen.
			int cantidadProfesiones = con.Contar("select count(codPro) from profesion where estatusPro = 'A'");

			//Se cargan los datos de la Base de Datos en un arreglo.
			string[] profesionMatriz = con.ListadoMD(2, cantidadProfesiones, sentencia);

			//Se modifica el arreglo existente.
			profesionesArreglo = new string[cantidadProfesiones];

			//Se inicializa la variable.
			profesionesNum = 0;

			for (int i = 0; i < cantidadProfesiones * 2; i++)
			{
				//Se van añadiendo los datos de la Base de Datos en la variable global.
				profesionesArreglo[profesionesNum] = profesionMatriz[i];
				i++;
				profesionesNum++;
			}

			for (int i = 1; i < cantidadProfesiones * 2; i++)
			{
				//Se añaden los datos de la Base de datos en el objeto.
				profesiones.AppendValues(profesionMatriz[i]);
				i++;
			}

			return profesiones;
		}

		protected void OnButCancelarClicked (object sender, EventArgs e)
		{
			this.Destroy ();

			//throw new NotImplementedException ();
		}

		protected void OnButAgregarProfesion2Clicked (object sender, EventArgs e)
		{
			//Se verifica que los campos estén llenados.
			if (cbboxProfesion1.ActiveText != "" && entFechaTitulo1.Text != "") 
			{
				//Se activan las herramientas para ingresar una nueva profesión.
				labProfesión2.Sensitive = true;
				cbboxProfesion2.Sensitive = true;
				labFechaTitulo1.Sensitive = true;
				entFechaTitulo2.Sensitive = true;
				butCalendarioTituloInstructor1.Sensitive = true;
				butEliminarProfesion2.Sensitive = true;
				butAgregarProfesion3.Sensitive = true;
				butAgregarProfesion2.Sensitive = false;

			} 
			//Caso para cuando los campos se encuentran vacíos.
			else 
			{
				//La contraseña es incorrecta.
				con.Mensaje ("Para agregar otra profesión debe rellenar los campos vacíos.", ButtonsType.Ok, MessageType.Error, "ERROR");
			}

			//throw new NotImplementedException ();
		}

		protected void OnButAgregarProfesion3Clicked (object sender, EventArgs e)
		{
			//Se verifica que los campos estén llenados.
			if (cbboxProfesion2.ActiveText != "" && entFechaTitulo2.Text != "") 
			{
				//Se activan las herramientas para ingresar una nueva profesión.
				labProfesión3.Sensitive = true;
				cbboxProfesion3.Sensitive = true;
				labFechaTitulo2.Sensitive = true;
				entFechaTitulo3.Sensitive = true;
				butCalendarioTituloInstructor2.Sensitive = true;
				butEliminarProfesion3.Sensitive = true;
				butAgregarProfesion4.Sensitive = true;
				butAgregarProfesion3.Sensitive = false;

			} 
			//Caso para cuando los campos se encuentran vacíos.
			else 
			{
				//La contraseña es incorrecta.
				con.Mensaje ("Para agregar otra profesión debe rellenar los campos vacíos.", ButtonsType.Ok, MessageType.Error, "ERROR");
			}

			//throw new NotImplementedException ();
		}

		protected void OnButAgregarProfesion4Clicked (object sender, EventArgs e)
		{
			//Se verifica que los campos estén llenados.
			if (cbboxProfesion3.ActiveText != "" && entFechaTitulo3.Text != "") 
			{
				//Se activan las herramientas para ingresar una nueva profesión.
				labProfesión4.Sensitive = true;
				cbboxProfesion4.Sensitive = true;
				labFechaTitulo3.Sensitive = true;
				entFechaTitulo4.Sensitive = true;
				butCalendarioTituloInstructor3.Sensitive = true;
				butEliminarProfesion4.Sensitive = true;
				butAgregarProfesion5.Sensitive = true;
				butAgregarProfesion4.Sensitive = false;

			} 
			//Caso para cuando los campos se encuentran vacíos.
			else 
			{
				//La contraseña es incorrecta.
				con.Mensaje ("Para agregar otra profesión debe rellenar los campos vacíos.", ButtonsType.Ok, MessageType.Error, "ERROR");
			}

			//throw new NotImplementedException ();
		}

		protected void OnButAgregarProfesion5Clicked (object sender, EventArgs e)
		{
			//Se verifica que los campos estén llenados.
			if (cbboxProfesion4.ActiveText != "" && entFechaTitulo4.Text != "") 
			{
				//Se activan las herramientas para ingresar una nueva profesión.
				labProfesión5.Sensitive = true;
				cbboxProfesion5.Sensitive = true;
				labFechaTitulo4.Sensitive = true;
				entFechaTitulo5.Sensitive = true;
				butCalendarioTituloInstructor4.Sensitive = true;
				butEliminarProfesion5.Sensitive = true;
				butAgregarProfesion6.Sensitive = true;
				butAgregarProfesion5.Sensitive = false;

			} 
			//Caso para cuando los campos se encuentran vacíos.
			else 
			{
				//La contraseña es incorrecta.
				con.Mensaje ("Para agregar otra profesión debe rellenar los campos vacíos.", ButtonsType.Ok, MessageType.Error, "ERROR");
			}

			//throw new NotImplementedException ();
		}

		protected void OnButAgregarProfesion6Clicked (object sender, EventArgs e)
		{
			//Se verifica que los campos estén llenados.
			if (cbboxProfesion5.ActiveText != "" && entFechaTitulo5.Text != "") 
			{
				//Se activan las herramientas para ingresar una nueva profesión.
				labProfesión6.Sensitive = true;
				cbboxProfesion6.Sensitive = true;
				labFechaTitulo5.Sensitive = true;
				entFechaTitulo6.Sensitive = true;
				butCalendarioTituloInstructor5.Sensitive = true;
				butEliminarProfesion6.Sensitive = true;
				butAgregarProfesion7.Sensitive = true;
				butAgregarProfesion6.Sensitive = false;

			} 
			//Caso para cuando los campos se encuentran vacíos.
			else 
			{
				//La contraseña es incorrecta.
				con.Mensaje ("Para agregar otra profesión debe rellenar los campos vacíos.", ButtonsType.Ok, MessageType.Error, "ERROR");
			}

			//throw new NotImplementedException ();
		}

		protected void OnButAgregarProfesion7Clicked (object sender, EventArgs e)
		{
			//Se verifica que los campos estén llenados.
			if (cbboxProfesion6.ActiveText != "" && entFechaTitulo6.Text != "") 
			{
				//Se activan las herramientas para ingresar una nueva profesión.
				labProfesión7.Sensitive = true;
				cbboxProfesion7.Sensitive = true;
				labFechaTitulo6.Sensitive = true;
				entFechaTitulo7.Sensitive = true;
				butCalendarioTituloInstructor6.Sensitive = true;
				butEliminarProfesion7.Sensitive = true;
				butAgregarProfesion8.Sensitive = true;
				butAgregarProfesion7.Sensitive = false;

			} 
			//Caso para cuando los campos se encuentran vacíos.
			else 
			{
				//La contraseña es incorrecta.
				con.Mensaje ("Para agregar otra profesión debe rellenar los campos vacíos.", ButtonsType.Ok, MessageType.Error, "ERROR");
			}

			//throw new NotImplementedException ();
		}

		protected void OnButAgregarProfesion8Clicked (object sender, EventArgs e)
		{
			//Se verifica que los campos estén llenados.
			if (cbboxProfesion7.ActiveText != "" && entFechaTitulo7.Text != "") 
			{
				//Se activan las herramientas para ingresar una nueva profesión.
				labProfesión8.Sensitive = true;
				cbboxProfesion8.Sensitive = true;
				labFechaTitulo7.Sensitive = true;
				entFechaTitulo8.Sensitive = true;
				butCalendarioTituloInstructor7.Sensitive = true;
				butEliminarProfesion8.Sensitive = true;
				butAgregarProfesion8.Sensitive = false;
				butAgregarProfesion8.Sensitive = false;

			} 
			//Caso para cuando los campos se encuentran vacíos.
			else 
			{
				//La contraseña es incorrecta.
				con.Mensaje ("Para agregar otra profesión debe rellenar los campos vacíos.", ButtonsType.Ok, MessageType.Error, "ERROR");
			}

			//throw new NotImplementedException ();
		}

		protected void OnButCalendarioTituloInstructorClicked (object sender, EventArgs e)
		{
			Calendario cal = new Calendario (ref entFechaTitulo1);
			cal.Show ();

			//throw new NotImplementedException ();
		}


		protected void OnButCalendarioTituloInstructor1Clicked (object sender, EventArgs e)
		{
			Calendario cal = new Calendario (ref entFechaTitulo2);
			cal.Show ();

			//throw new NotImplementedException ();
		}

		protected void OnButCalendarioTituloInstructor2Clicked (object sender, EventArgs e)
		{
			Calendario cal = new Calendario (ref entFechaTitulo3);
			cal.Show ();

			//throw new NotImplementedException ();
		}

		protected void OnButCalendarioTituloInstructor3Clicked (object sender, EventArgs e)
		{
			Calendario cal = new Calendario (ref entFechaTitulo4);
			cal.Show ();

			//throw new NotImplementedException ();
		}

		protected void OnButCalendarioTituloInstructor4Clicked (object sender, EventArgs e)
		{
			Calendario cal = new Calendario (ref entFechaTitulo5);
			cal.Show ();

			//throw new NotImplementedException ();
		}

		protected void OnButCalendarioTituloInstructor5Clicked (object sender, EventArgs e)
		{
			Calendario cal = new Calendario (ref entFechaTitulo6);
			cal.Show ();

			//throw new NotImplementedException ();
		}

		protected void OnButCalendarioTituloInstructor6Clicked (object sender, EventArgs e)
		{
			Calendario cal = new Calendario (ref entFechaTitulo7);
			cal.Show ();

			//throw new NotImplementedException ();
		}

		protected void OnButCalendarioTituloInstructor7Clicked (object sender, EventArgs e)
		{
			Calendario cal = new Calendario (ref entFechaTitulo1);
			cal.Show ();

			//throw new NotImplementedException ();
		}

		protected void OnButEliminarProfesion2Clicked (object sender, EventArgs e)
		{
			MessageDialog md;

			md = new MessageDialog (null, DialogFlags.Modal, MessageType.Question, ButtonsType.YesNo, "¿Desea eliminar esta profesión?");
			ResponseType respuesta = (ResponseType)md.Run ();

			if (respuesta == ResponseType.Yes) 
			{
				butAgregarProfesion2.Sensitive = true;
				labProfesión2.Sensitive = false;
				cbboxProfesion2.Active = 0;
				cbboxProfesion2.Sensitive = false;
				labFechaTitulo1.Sensitive = false;
				entFechaTitulo2.Text = "";
				entFechaTitulo2.Sensitive = false;
				butCalendarioTituloInstructor1.Sensitive = false;
				butEliminarProfesion2.Sensitive = false;
				butAgregarProfesion3.Sensitive = false;
				md.Destroy ();

			}
			else {
				md.Destroy ();
			}

			//throw new NotImplementedException ();
		}

		protected void OnButEliminarProfesion3Clicked (object sender, EventArgs e)
		{
			MessageDialog md;

			md = new MessageDialog (null, DialogFlags.Modal, MessageType.Question, ButtonsType.YesNo, "¿Desea eliminar esta profesión?");
			ResponseType respuesta = (ResponseType)md.Run ();

			if (respuesta == ResponseType.Yes) 
			{
				butAgregarProfesion3.Sensitive = true;
				labProfesión3.Sensitive = false;
				cbboxProfesion3.Active = 0;
				cbboxProfesion3.Sensitive = false;
				labFechaTitulo2.Sensitive = false;
				entFechaTitulo3.Text = "";
				entFechaTitulo3.Sensitive = false;
				butCalendarioTituloInstructor2.Sensitive = false;
				butEliminarProfesion3.Sensitive = false;
				butAgregarProfesion4.Sensitive = false;
				md.Destroy ();

			}
			else {
				md.Destroy ();
			}

			//throw new NotImplementedException ();
		}

		protected void OnButEliminarProfesion4Clicked (object sender, EventArgs e)
		{
			MessageDialog md;

			md = new MessageDialog (null, DialogFlags.Modal, MessageType.Question, ButtonsType.YesNo, "¿Desea eliminar esta profesión?");
			ResponseType respuesta = (ResponseType)md.Run ();

			if (respuesta == ResponseType.Yes) 
			{
				butAgregarProfesion4.Sensitive = true;
				labProfesión4.Sensitive = false;
				cbboxProfesion4.Active = 0;
				cbboxProfesion4.Sensitive = false;
				labFechaTitulo3.Sensitive = false;
				entFechaTitulo4.Text = "";
				entFechaTitulo4.Sensitive = false;
				butCalendarioTituloInstructor3.Sensitive = false;
				butEliminarProfesion4.Sensitive = false;
				butAgregarProfesion5.Sensitive = false;
				md.Destroy ();

			}
			else {
				md.Destroy ();
			}

			//throw new NotImplementedException ();
		}

		protected void OnButEliminarProfesion5Clicked (object sender, EventArgs e)
		{
			MessageDialog md;

			md = new MessageDialog (null, DialogFlags.Modal, MessageType.Question, ButtonsType.YesNo, "¿Desea eliminar esta profesión?");
			ResponseType respuesta = (ResponseType)md.Run ();

			if (respuesta == ResponseType.Yes) 
			{
				butAgregarProfesion5.Sensitive = true;
				labProfesión5.Sensitive = false;
				cbboxProfesion5.Active = 0;
				cbboxProfesion5.Sensitive = false;
				labFechaTitulo4.Sensitive = false;
				entFechaTitulo5.Text = "";
				entFechaTitulo5.Sensitive = false;
				butCalendarioTituloInstructor4.Sensitive = false;
				butEliminarProfesion5.Sensitive = false;
				butAgregarProfesion6.Sensitive = false;
				md.Destroy ();

			}
			else {
				md.Destroy ();
			}

			//throw new NotImplementedException ();
		}

		protected void OnButEliminarProfesion6Clicked (object sender, EventArgs e)
		{
			MessageDialog md;

			md = new MessageDialog (null, DialogFlags.Modal, MessageType.Question, ButtonsType.YesNo, "¿Desea eliminar esta profesión?");
			ResponseType respuesta = (ResponseType)md.Run ();

			if (respuesta == ResponseType.Yes) 
			{
				butAgregarProfesion6.Sensitive = true;
				labProfesión6.Sensitive = false;
				cbboxProfesion6.Active = 0;
				cbboxProfesion6.Sensitive = false;
				labFechaTitulo5.Sensitive = false;
				entFechaTitulo6.Text = "";
				entFechaTitulo6.Sensitive = false;
				butCalendarioTituloInstructor5.Sensitive = false;
				butEliminarProfesion6.Sensitive = false;
				butAgregarProfesion7.Sensitive = false;
				md.Destroy ();

			}
			else {
				md.Destroy ();
			}

			//throw new NotImplementedException ();
		}

		protected void OnButEliminarProfesion7Clicked (object sender, EventArgs e)
		{
			MessageDialog md;

			md = new MessageDialog (null, DialogFlags.Modal, MessageType.Question, ButtonsType.YesNo, "¿Desea eliminar esta profesión?");
			ResponseType respuesta = (ResponseType)md.Run ();

			if (respuesta == ResponseType.Yes) 
			{
				butAgregarProfesion7.Sensitive = true;
				labProfesión7.Sensitive = false;
				cbboxProfesion7.Active = 0;
				cbboxProfesion7.Sensitive = false;
				labFechaTitulo6.Sensitive = false;
				entFechaTitulo7.Text = "";
				entFechaTitulo7.Sensitive = false;
				butCalendarioTituloInstructor6.Sensitive = false;
				butEliminarProfesion7.Sensitive = false;
				butAgregarProfesion8.Sensitive = false;
				md.Destroy ();

			}
			else {
				md.Destroy ();
			}

			//throw new NotImplementedException ();
		}

		protected void OnButEliminarProfesion8Clicked (object sender, EventArgs e)
		{
			MessageDialog md;

			md = new MessageDialog (null, DialogFlags.Modal, MessageType.Question, ButtonsType.YesNo, "¿Desea eliminar esta profesión?");
			ResponseType respuesta = (ResponseType)md.Run ();

			if (respuesta == ResponseType.Yes) 
			{
				butAgregarProfesion8.Sensitive = true;
				labProfesión8.Sensitive = false;
				cbboxProfesion8.Active = 0;
				cbboxProfesion8.Sensitive = false;
				labFechaTitulo7.Sensitive = false;
				entFechaTitulo8.Text = "";
				entFechaTitulo8.Sensitive = false;
				butCalendarioTituloInstructor7.Sensitive = false;
				butEliminarProfesion8.Sensitive = false;
				md.Destroy ();

			}
			else {
				md.Destroy ();
			}

			//throw new NotImplementedException ();
		}

		protected void OnButAceptarClicked (object sender, EventArgs e)
		{
			//Profesión 1
			if (cbboxProfesion1.ActiveText != "" && entFechaTitulo1.Text != "") {

				string[] codPro1 = con.Listado (1, "SELECT codPro FROM profesion where descripcionPro = '" + cbboxProfesion1.ActiveText + "' and estatusPro ='A'");

				Sentencia = "insert into instuctor_profesion values ('" + entNombreInstructor.Text + "','" + codPro1[0] + "', '" + entFechaTitulo1.Text + "')";

				if (cbboxProfesion2.Sensitive == true) {

					//Profesión 2
					if (cbboxProfesion2.ActiveText != "" && entFechaTitulo2.Text != "") {

						string[] codPro2 = con.Listado (1, "SELECT codPro FROM profesion where descripcionPro = '" + cbboxProfesion2.ActiveText + "' and estatusPro ='A'");

						Sentencia += ", ('" + entNombreInstructor.Text + "','" + codPro2[0] + "', '" + entFechaTitulo2.Text + "')";

						if (cbboxProfesion3.Sensitive == true) {
							//Profesión 3
							if (cbboxProfesion3.ActiveText != "" && entFechaTitulo3.Text != "") {

								string[] codPro3 = con.Listado (1, "SELECT codPro FROM profesion where descripcionPro = '" + cbboxProfesion3.ActiveText + "' and estatusPro ='A'");

								Sentencia += ", ('" + entNombreInstructor.Text + "','" + codPro3[0] + "', '" + entFechaTitulo3.Text + "')";

								if (cbboxProfesion4.Sensitive == true) {
								
									//Profesión 4
									if(cbboxProfesion4.ActiveText != "" && entFechaTitulo4.Text != ""){

										string[] codPro4 = con.Listado (1, "SELECT codPro FROM profesion where descripcionPro = '" + cbboxProfesion4.ActiveText + "' and estatusPro ='A'");

										Sentencia += ", ('" + entNombreInstructor.Text + "','" + codPro4[0] + "', '" + entFechaTitulo4.Text + "')";

										if (cbboxProfesion5.Sensitive == true) {
											
											//Profesión 5
											if(cbboxProfesion5.ActiveText != "" && entFechaTitulo5.Text != ""){

												string[] codPro5 = con.Listado (1, "SELECT codPro FROM profesion where descripcionPro = '" + cbboxProfesion5.ActiveText + "' and estatusPro ='A'");

												Sentencia += ", ('" + entNombreInstructor.Text + "','" + codPro5[0] + "', '" + entFechaTitulo5.Text + "')";

												if (cbboxProfesion6.Sensitive == true) {

													//Profesión 6
													if(cbboxProfesion6.ActiveText != "" && entFechaTitulo6.Text != ""){

														string[] codPro6 = con.Listado (1, "SELECT codPro FROM profesion where descripcionPro = '" + cbboxProfesion6.ActiveText + "' and estatusPro ='A'");

														Sentencia += ", ('" + entNombreInstructor.Text + "','" + codPro6[0] + "', '" + entFechaTitulo6.Text + "')";

														if (cbboxProfesion7.Sensitive == true) {

															//Profesión 7
															if(cbboxProfesion7.ActiveText != "" && entFechaTitulo7.Text != ""){

																string[] codPro7 = con.Listado (1, "SELECT codPro FROM profesion where descripcionPro = '" + cbboxProfesion7.ActiveText + "' and estatusPro ='A'");

																Sentencia += ", ('" + entNombreInstructor.Text + "','" + codPro7[0] + "', '" + entFechaTitulo7.Text + "')";

																if (cbboxProfesion8.Sensitive == true) {
																
																	//Profesión 8
																	if(cbboxProfesion8.ActiveText != "" && entFechaTitulo8.Text != ""){

																		string[] codPro8 = con.Listado (1, "SELECT codPro FROM profesion where descripcionPro = '" + cbboxProfesion8.ActiveText + "' and estatusPro ='A'");

																		Sentencia += ", ('" + entNombreInstructor.Text + "','" + codPro8[0] + "', '" + entFechaTitulo8.Text + "')";

																	}
																	//Sin cargar Profesión 8
																	else{
																		con.Mensaje ("Rellene los campos vacíos para proceder.", ButtonsType.Ok, MessageType.Error, "ERROR");
																	}
																}

															}
															//Sin cargar Profesión 7
															else{
																con.Mensaje ("Rellene los campos vacíos para proceder.", ButtonsType.Ok, MessageType.Error, "ERROR");
															}
														}

													}
													//Sin cargar Profesión 6
													else{
														con.Mensaje ("Rellene los campos vacíos para proceder.", ButtonsType.Ok, MessageType.Error, "ERROR");
													}
												}

											}
											//Sin cargar Profesión 5
											else{
												con.Mensaje ("Rellene los campos vacíos para proceder.", ButtonsType.Ok, MessageType.Error, "ERROR");
											}
										}

									}
									//Sin cargar Profesión 4
									else{
										con.Mensaje ("Rellene los campos vacíos para proceder.", ButtonsType.Ok, MessageType.Error, "ERROR");
									}
								}

							}
							//Sin cargar Profesión 3
							else {
								con.Mensaje ("Rellene los campos vacíos para proceder.", ButtonsType.Ok, MessageType.Error, "ERROR");
							}

						}

					}
					//Sin cargar Profesión 2
					else {
						con.Mensaje ("Rellene los campos vacíos para proceder.", ButtonsType.Ok, MessageType.Error, "ERROR");
					}

				}

			}
			//Sin cargar Profesión 1
			else {
				con.Mensaje ("Rellene los campos vacíos para proceder.", ButtonsType.Ok, MessageType.Error, "ERROR");
			}

			if(Sentencia != "")
				ent.Text = "Datos Cargados.";
			if (Sentencia == "")
				ent.Text = "Sin datos cargados.";
			this.Destroy ();

			//throw new NotImplementedException ();
		}

		protected void recibirProfesiones(string[] arreglo, ComboBox combo, Entry ent)
		{
			for (int i = 0; i < (profesionesNum * 2); i++) 
			{
				if (combo.ActiveText == arreglo [i]) 
				{
					combo.Active = i;
					DateTime fechaTitulo = Convert.ToDateTime(arreglo [i + 1]);
					ent.Text = fechaTitulo.ToString("yyyy/MM/dd");
				}
			}
		}

		protected void instructorExistente ()
		{

			if (con.BuscarEliminado ("codIns", "instructor", entCodigoInstructor.Text, "estatusIns") == false) {
				string sentenciaCantidad = String.Format ("SELECT count(distinct descripcionPro) from profesion, instructor, instuctor_profesion where instructor.codIns = instuctor_profesion.codIns and profesion.codPro = instuctor_profesion.codPro and estatusIns = 'A' and estatusPro = 'A' and instructor.codIns = '{0}'", entCodigoInstructor.Text);
				int cantidad = Convert.ToInt16 (con.EjecutarScalar (sentenciaCantidad));

				string sentenciaSQL = String.Format ("SELECT descripcionPro, fechaTitulo from profesion, instructor, instuctor_profesion where instructor.codIns = instuctor_profesion.codIns and profesion.codPro = instuctor_profesion.codPro and estatusIns = 'A' and estatusPro = 'A' and instructor.codIns = '{0}'", entCodigoInstructor.Text);
				string[] array = con.ListadoMD (2, cantidad, sentenciaSQL);

				switch (array.Length) {
				case 1:
					{
						recibirProfesiones (array, cbboxProfesion1, entFechaTitulo1);
						break;
					}
				case 2:
					{
						recibirProfesiones (array, cbboxProfesion1, entFechaTitulo1);
						recibirProfesiones (array, cbboxProfesion2, entFechaTitulo2);
						break;
					}
				case 3:
					{
						recibirProfesiones (array, cbboxProfesion1, entFechaTitulo1);
						recibirProfesiones (array, cbboxProfesion2, entFechaTitulo2);
						recibirProfesiones (array, cbboxProfesion3, entFechaTitulo3);
						break;
					}
				case 4:
					{
						recibirProfesiones (array, cbboxProfesion1, entFechaTitulo1);
						recibirProfesiones (array, cbboxProfesion2, entFechaTitulo2);
						recibirProfesiones (array, cbboxProfesion3, entFechaTitulo3);
						recibirProfesiones (array, cbboxProfesion4, entFechaTitulo4);
						break;
					}
				case 5:
					{
						recibirProfesiones (array, cbboxProfesion1, entFechaTitulo1);
						recibirProfesiones (array, cbboxProfesion2, entFechaTitulo2);
						recibirProfesiones (array, cbboxProfesion3, entFechaTitulo3);
						recibirProfesiones (array, cbboxProfesion4, entFechaTitulo4);
						recibirProfesiones (array, cbboxProfesion5, entFechaTitulo5);
						break;
					}
				case 6:
					{
						recibirProfesiones (array, cbboxProfesion1, entFechaTitulo1);
						recibirProfesiones (array, cbboxProfesion2, entFechaTitulo2);
						recibirProfesiones (array, cbboxProfesion3, entFechaTitulo3);
						recibirProfesiones (array, cbboxProfesion4, entFechaTitulo4);
						recibirProfesiones (array, cbboxProfesion5, entFechaTitulo5);
						recibirProfesiones (array, cbboxProfesion6, entFechaTitulo6);
						break;
					}
				case 7:
					{
						recibirProfesiones (array, cbboxProfesion1, entFechaTitulo1);
						recibirProfesiones (array, cbboxProfesion2, entFechaTitulo2);
						recibirProfesiones (array, cbboxProfesion3, entFechaTitulo3);
						recibirProfesiones (array, cbboxProfesion4, entFechaTitulo4);
						recibirProfesiones (array, cbboxProfesion5, entFechaTitulo5);
						recibirProfesiones (array, cbboxProfesion6, entFechaTitulo6);
						recibirProfesiones (array, cbboxProfesion7, entFechaTitulo7);
						break;
					}
				case 8:
					{
						recibirProfesiones (array, cbboxProfesion1, entFechaTitulo1);
						recibirProfesiones (array, cbboxProfesion2, entFechaTitulo2);
						recibirProfesiones (array, cbboxProfesion3, entFechaTitulo3);
						recibirProfesiones (array, cbboxProfesion4, entFechaTitulo4);
						recibirProfesiones (array, cbboxProfesion5, entFechaTitulo5);
						recibirProfesiones (array, cbboxProfesion6, entFechaTitulo6);
						recibirProfesiones (array, cbboxProfesion7, entFechaTitulo7);
						recibirProfesiones (array, cbboxProfesion8, entFechaTitulo8);
						break;
					}

				}
			} 

			else 
			{
				
			}

		}

		protected void OnEntCodigoInstructorChanged (object sender, EventArgs e)
		{
			

			//throw new NotImplementedException ();
		}
	}
}

