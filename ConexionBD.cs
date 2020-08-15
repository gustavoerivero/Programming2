/*Proyecto; Damage Control.
Equipo N°5. Integrantes:
Yurisbellys Brizuela. C.I: 27.142.239
Franklin Camacho. C.I: 26.796.912
Jesús Leal. C.I: 26.561.030
Marihec Miranda. C.I: 26.120.075
Gustavo Rivero. C.I: 26.772.857*/

//ConexionBD: Archivo que contiene comandos que facilitan la conexión con una Base de Datos.

using System;
using Gtk;

/*Se agregan estas librerías para poder realizar la conexión con la respectiva Base de Datos.
Ir a "Referencias", click derecho y opción "Editar referencias...", luego agregar la librería "System.Data".
Posteriormente, en ".NET Assembly" seleccionar "MySql.Data.dll" y finalizar haciendo click en "Aceptar".*/
using System.Data;
using MySql.Data.MySqlClient;

namespace DamageControl
{
	public class ConexBD
	{
		private MySqlConnection Con;
		Window Ven;

		//Constructor; Realiza la conexión a la base de datos.
		public ConexBD(Window nombreVentana)
		{
			/*En DATABASE colocar la Base de Datos que se desea conectar al programa,
			mientras que PASSWORD la contraseña de la misma.*/
			string conex = "SERVER=localhost; DATABASE=damage_control; UID=root; PASSWORD=Programacion II; SslMode=none";
			Con = new MySqlConnection(conex);
			Ven = nombreVentana;
		}

		//Envía un mensaje en un cuadro de diálogo personalizado.
		public ResponseType Mensaje(string Msj, ButtonsType Tb, MessageType Tm, string titulo)
		{
			MessageDialog Men = new MessageDialog (Ven, DialogFlags.DestroyWithParent, Tm, Tb, Msj);
			ResponseType Respuesta = (ResponseType)Men.Run();
			Men.Title = titulo;
			Men.Destroy();
			return Respuesta;
		}

		//Conectar la base de datos al programa.
		private bool Conectar()
		{
			try
			{
				Con.Open();
				return true;
			}
			catch (MySqlException ex)
			{
				Mensaje(ex.Message, ButtonsType.Ok, MessageType.Error,"Error");
			}
			return false;
		}

		//Desconectar la base de datos del programa.
		private bool Desconectar()
		{
			try
			{
				Con.Close();
				return true;
			}
			catch (MySqlException ex)
			{
				Mensaje(ex.Message, ButtonsType.Ok, MessageType.Error, "Error");
			}
			return false;
		}

		/*Ejecuta una sentencia que no devuelve ningún resultado
		Útil para sentencias de; Insertar, Actualizar, Eliminar.
		Recibe como parámetro la sentencia a ejecutar por la Base de Datos y la ejectua.*/
		public void EjecutarSentencia(string sentencia)
		{
			//Abre la conexión
			if (Conectar() == true)
			{
				//Crea un comando y asigna la conexión.
				MySqlCommand cmd = new MySqlCommand(sentencia, Con);
				try
				{
					//Ejecuta el comando.
					cmd.ExecuteNonQuery();
				}
				catch (MySqlException ex)
				{
					Mensaje(ex.Message, ButtonsType.Ok, MessageType.Error, "Error");
				}
				finally
				{
					cmd.Dispose();
					Desconectar();
				}
			}
		}

		//Verifica la existencia de un registro, siempre que su estado esté Activo.
		//Es decir, valida si existe el registro antes de añadirlo.
		public bool Buscar(string col, string tabla, string parametro, string estatus)
		{
			string sentencia = string.Format("SELECT count({0}) FROM {1} WHERE {0} = '{2}' AND {3} = 'A'", col, tabla, parametro,estatus);
			//Abre la conexión.
			if (Conectar())
			{
				//Crea un comando
				MySqlCommand cmd = new MySqlCommand(sentencia, Con);

				try
				{
					int n = Convert.ToInt16(cmd.ExecuteScalar());
					if (n == 1)
					{
						return true;
					}
					else
					{
						return false;
					}
				} 
				catch (MySqlException ex)
				{
					Mensaje(ex.Message, ButtonsType.Ok, MessageType.Error, "Error");
				}
				finally
				{
					cmd.Dispose();
					Desconectar();
				} 
			}
			return false;
		}
			
		//Verifica la existencia de un registro relacionado en dos tablas, siempre que su estado esté Activo.
		//Es decir, valida si existe el registro antes de añadirlo.
		public bool BuscarEnDosTablas(string colTabla1, string tabla1, string tabla2, string colComparar, string parametro, string colTabla1Comparar, string colTabla2Comparar, string estatus1, string estatus2)
		{
			string sentencia = string.Format("SELECT count({0}) FROM {1}, {2} WHERE {3} = '{4}' AND {5} = {6} AND {7} = 'A' AND {8} = 'A'", colTabla1, tabla1, tabla2, colComparar, parametro, colTabla1Comparar, colTabla2Comparar, estatus1, estatus2);
			//Abre la conexión.
			if (Conectar())
			{
				//Crea un comando
				MySqlCommand cmd = new MySqlCommand(sentencia, Con);

				try
				{
					int n = Convert.ToInt16(cmd.ExecuteScalar());
					if (n == 1)
					{
						return true;
					}
					else
					{
						return false;
					}
				} 
				catch (MySqlException ex)
				{
					Mensaje(ex.Message, ButtonsType.Ok, MessageType.Error, "Error");
				}
				finally
				{
					cmd.Dispose();
					Desconectar();
				} 
			}
			return false;
		}


		//Verifica la existencia de un registro, sea cual sea su estatus.
		//Es decir, valida si existe el registro antes de añadirlo.
		public bool BuscarTodos(string col, string tabla, string parametro)
		{
			string sentencia = string.Format("SELECT count({0}) FROM {1} WHERE {0} = '{2}'", col, tabla, parametro);
			//Abre la conexión.
			if (Conectar())
			{
				//Crea un comando
				MySqlCommand cmd = new MySqlCommand(sentencia, Con);

				try
				{
					int n = Convert.ToInt16(cmd.ExecuteScalar());
					if (n == 1)
					{
						return true;
					}
					else
					{
						return false;
					}
				} 
				catch (MySqlException ex)
				{
					Mensaje(ex.Message, ButtonsType.Ok, MessageType.Error, "Error");
				}
				finally
				{
					cmd.Dispose();
					Desconectar();
				} 
			}
			return false;
		}

		/*Verifica si un registro fue previamente eliminado.
		Es decir, aquellos registros con un estatus "E".*/
		public bool BuscarEliminado(string col, string tabla, string parametro, string estatus)
		{
			string sentencia = string.Format("SELECT count({0}) FROM {1} WHERE {0} = '{2}' AND {3} = 'E'", col, tabla, parametro, estatus);
			//Abre la conexión.
			if (Conectar())
			{
				//Crea un comando
				MySqlCommand cmd = new MySqlCommand(sentencia, Con);

				try
				{
					int n = Convert.ToInt16(cmd.ExecuteScalar());
					if (n == 1)
					{
						return true;
					}
					else
					{
						return false;
					}
				}
				catch (MySqlException ex)
				{
					Mensaje(ex.Message, ButtonsType.Ok, MessageType.Error, "Error");
				}
				finally
				{
					cmd.Dispose();
					Desconectar();
				}
			}
			return false;
		}


		//Cuenta el número de registros que cumplan un requerimiento específico.
		public int Contar(string sentencia)
		{
			int c = -1;

			//Realiza la conexión con la Base de Datos.
			if (Conectar() == true)
			{
				//Crea un comando
				MySqlCommand cmd = new MySqlCommand(sentencia, Con);

				//Ejecuta el comando con ExecuteScalar.
				try {
					c = int.Parse(cmd.ExecuteScalar() + ""); 
				}
				catch (MySqlException ex)
				{
					Mensaje(ex.Message, ButtonsType.Ok, MessageType.Error, "Error");
				}
				finally
				{
					cmd.Dispose();
					Desconectar();
				} 
			}
			return c;
		}

		/*Hacer búsqueda de registros en una tabla
		Trae de la Base de Datos los campos requeridos en la "sentencia".
		El "int p" indica el tamaño que tendrá esté listado, el cual debe coincidir con los campos 
		solicitados en la "sentencia".*/
		public string[] Listado(int p, string sentencia)
		{
			//Crea arreglo de string que cargará con los datos leídos.
			string[] array = new string[p]; 

			//Abre la conexión.
			if (Conectar() == true)
			{
				//Crea el comando MySql.
				MySqlCommand cmd = new MySqlCommand(sentencia, Con);
				try
				{
					//Crea y ejecuta el lector de datos.
					MySqlDataReader read;
					read = cmd.ExecuteReader(); 

					while (read.Read())
					{
						//Cargar el arreglo con los datos leídos
						for (int i = 0; i < p; i++) 
							array[i] = read[i].ToString(); 
					}
					//Cierra el lector
					read.Close();
				}
				catch (MySqlException ex)
				{
					Mensaje(ex.Message, ButtonsType.Ok, MessageType.Error, "Error");
				}
				finally
				{
					cmd.Dispose();
					Desconectar();
				}
			}
			return array;
		}

		public string[] ListadoMD(int i, int j, string sentencia)
		{
			int nelem = i * j;
			int l = 0;
			//Crea arreglo de string que cargará con los datos leídos.
			string[] array = new string[nelem];

			//Abre la conexión.
			if (Conectar() == true)
			{
				//Crea el comando MySql.
				MySqlCommand cmd = new MySqlCommand(sentencia, Con);
				try
				{
					//Crea y ejecuta el lector de datos.
					MySqlDataReader read;
					read = cmd.ExecuteReader();

					while (read.Read())
					{
						//Cargar el arreglo con los datos leídos
						for (int k = 0; k < i; k++)
						{
							array[k + i * l] = read[k].ToString();
						}
						l++;
					}
					//Cierra el lector
					read.Close();
				}
				catch (MySqlException ex)
				{
					Mensaje(ex.Message, ButtonsType.Ok, MessageType.Error, "Error");
				}
				finally
				{
					cmd.Dispose();
					Desconectar();
				}
			}
			return array;
		}

		public string EjecutarScalar(string sentencia)
		{
			string escalar = "";

			//Abre la conexión
			if (Conectar() == true)
			{
				//Crea un comando y asigna la conexión.
				MySqlCommand cmd = new MySqlCommand(sentencia, Con);
				try
				{
					//Ejecuta el comando.
					escalar = cmd.ExecuteScalar().ToString();
				}
				catch (MySqlException ex)
				{
					Mensaje(ex.Message, ButtonsType.Ok, MessageType.Error, "Error");
				}
				finally
				{
					cmd.Dispose();
					Desconectar();
				}
			}

			return escalar;
		}

	}
}