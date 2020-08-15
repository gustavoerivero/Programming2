/*Proyecto; Damage Control.
Equipo N°5. Integrantes:
Yurisbellys Brizuela. C.I: 27.142.239
Franklin Camacho. C.I: 26.796.912
Jesús Leal. C.I: 26.561.030
Marihec Miranda. C.I: 26.120.075
Gustavo Rivero. C.I: 26.772.857*/

/*UsoPDF; Archivo que contiene ciertos comandos que permiten la manipulación, edición, creación, entre otras cosas, de archivos PDF.
Todos los comandos que se encuentran en el archivo se encuentran explicados por medio de comentarios.*/

//ARCHIVO INCOMPLETO...

/*NOTA: Es preferible utilizar los métodos, clases, objetos, que provee iTextSharp directamente en el archivo
que se vaya a utilizar un documento PDF, de tal forma se podrá manejar mayor libertad en cuanto a la programación.
Este archivo es más que todo instructivo.*/
using Gtk;
using System;

/*Se agregan estas librerías para poder manipular, crear, editar archivos .PDF.
Posteriormente, en ".NET Assembly" seleccionar "itextsharp.dll" y finalizar haciendo click en "Aceptar".*/
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace UsoPDF
{
	public class iText
	{
		private Document doc;

		public iText ()
		{
			
		}

		/*Es necesario crear una instancia de este objeto para poder trabajar con el PDF en la memoria.
		Esto crea una nueva instancia con la configuración predefinida. 
		El tamaño es A4 y los márgenes están configurados a medida de pulgada.*/
		public void nuevoDoc ()
		{
			var doc = new Document ();
		}

		/*Permite crear una instancia con el tamaño A0
		841mm x 1189mm; 33,1" x 46,8".*/
		public void nuevoDocA0 ()
		{
			var doc = new Document (PageSize.A0);
		}

		/*Permite crear una instancia con el tamaño A1.
		594mm x 841mm; 23,4" x 33,1".*/
		public void nuevoDocA1 ()
		{
			var doc = new Document (PageSize.A1);
		}

		/*Permite crear una instancia con el tamaño A2.
		420mm x 594mm; 16,5" x 23,4".*/
		public void nuevoDocA2 ()
		{
			var doc = new Document (PageSize.A2);
		}

		/*Permite crear una instancia con el tamaño A3.
		297mm x 420mm; 11,7" x 16,5".*/
		public void nuevoDocA3 ()
		{
			var doc = new Document (PageSize.A3);
		}

		/*Permite crear una instancia con el tamaño A4.
		210mm x 297mm; 8,3" x 11,7".*/
		public void nuevoDocA4 ()
		{
			var doc = new Document (PageSize.A4);
		}

		/*Permite crear una instancia con el tamaño A5.
		148mm x 210mm; 5,8" x 8,3".*/
		public void nuevoDocA5 ()
		{
			var doc = new Document (PageSize.A5);
		}

		/*Permite crear una instancia con el tamaño A6.
		105mm x 148mm; 4,1" x 5,8".*/
		public void nuevoDocA6 ()
		{
			var doc = new Document (PageSize.A6);
		}

		/*Permite crear una instancia con el tamaño A7.
		74mm x 105mm; 2,9" x 4,1".*/
		public void nuevoDocA7 ()
		{
			var doc = new Document (PageSize.A7);
		}

		/*Permite crear una instancia con el tamaño A8.
		52mm x 74mm; 2,1" x 2,9".*/
		public void nuevoDocA8 ()
		{
			var doc = new Document (PageSize.A8);
		}

		/*Permite crear una instancia con el tamaño A9.
		37mm x 52mm; 1,5" x 2,1".*/
		public void nuevoDocA9 ()
		{
			var doc = new Document (PageSize.A9);
		}

		//Permite crear una instancia con el tamaño A10.
		public void nuevoDocA10 ()
		{
			var doc = new Document (PageSize.A10);
		}

		/*Permite crear una instancia con el tamaño B0.
		1000mm x 1414mm; 39,4" x 55,7".*/
		public void nuevoDocB0 ()
		{
			var doc = new Document (PageSize.B0);
		}

		/*Permite crear una instancia con el tamaño B1.
		707mm x 1000mm; 27,8" x 39,4".*/
		public void nuevoDocB1 ()
		{
			var doc = new Document (PageSize.B1);
		}

		/*Permite crear una instancia con el tamaño B2.
		500mm x 707mm; 19,7" x 27,8".*/
		public void nuevoDocB2 ()
		{
			var doc = new Document (PageSize.B2);
		}

		/*Permite crear una instancia con el tamaño B3.
		353mm x 500mm; 13,9" x 19,7".*/
		public void nuevoDocB3 ()
		{
			var doc = new Document (PageSize.B3);
		}

		/*Permite crear una instancia con el tamaño B4.
		250mm x 353mm; 9,8" x 13,9".*/
		public void nuevoDocB4 ()
		{
			var doc = new Document (PageSize.B4);
		}

		/*Permite crear una instancia con el tamaño B5.
		176mm x 250mm; 6,9" x 9,8".*/
		public void nuevoDocB5 ()
		{
			var doc = new Document (PageSize.B5);
		}

		/*Permite crear una instancia con el tamaño B6.
		125mm x 176mm; 4,9" x 6,9".*/
		public void nuevoDocB6 ()
		{
			var doc = new Document (PageSize.B6);
		}

		/*Permite crear una instancia con el tamaño B7.
		88mm x 125mm; 3,5" x 4,9".*/
		public void nuevoDocB7 ()
		{
			var doc = new Document (PageSize.B7);
		}

		/*Permite crear una instancia con el tamaño B8.
		62mm x 88mm; 2,4" x 3,5".*/
		public void nuevoDocB8 ()
		{
			var doc = new Document (PageSize.B8);
		}

		/*Permite crear una instancia con el tamaño B9.
		44mm x 62mm; 1,7" x 2,4".*/
		public void nuevoDocB9 ()
		{
			var doc = new Document (PageSize.B9);
		}

		/*Permite crear una instancia con el tamaño B10.
		31mm x 44mm; 1,2" x 1,7".*/
		public void nuevoDocB10 ()
		{
			var doc = new Document (PageSize.B10);
		}

		/*Permite crear una instancia con el tamaño Legal.
		215,9mm x 355,6mm; 8,5" x 14,0".*/
		public void nuevoDocLegal ()
		{
			var doc = new Document (PageSize.LEGAL);
		}

		/*Permite crear una instancia con el tamaño Ledger.
		431,8mm x 279,4mm; 17" x 11".*/
		public void nuevoDocLedger ()
		{
			var doc = new Document (PageSize.LEDGER);
		}

		/*Permite crear una instancia con el tamaño Letter.
		215,9mm x 279,4mm; 8,5" x 11,0".*/
		public void nuevoDocLetter ()
		{
			var doc = new Document (PageSize.LETTER);
		}

		//Permite crear una instancia con el tamaño PostCard.
		public void nuevoDocPostCard ()
		{
			var doc = new Document (PageSize.POSTCARD);
		}

		/*Permite crear una instancia con el tamaño Tabloid.
		279,4mm x 431,8mm; 11,0" x 17,0".*/
		public void nuevoDocTabloid ()
		{
			var doc = new Document (PageSize.TABLOID);
		}

		/*Si se desea elaborar una instancia con un tamaño personalizado,
		se debe utilizar la clase Rectangle
		Ejemplo;
		new Rectangle (100f, 300f);
		var doc = new Document (new Rectangle (100f, 300f));*/

		//Para poder grabar el documento al disco, se necesita la clase PdfWriter.
		/*public void PDFWriter (){
			string path = Server.MapPath("PDFs");
		PdfWriter.GetInstance(doc, new FileStream (path + "/Doc.pdf", FileMode.Create));
		}*/

		/*Estoy buscando como solucionar el guardado, la librería es para uso de 
		Visual Studio con posible adaptación a Monodevelop.*/
		//PdfWriter writer = PdfWriter.GetInstance (doc, );

		//Abrir el documento PDF
		public void abrirDoc ()
		{
			doc.Open ();
		}

		//Cerrar el documento PDF
		public void cerrarDoc ()
		{
			doc.Close ();
		}

		//Para añadir objetos al documento PDF
		//doc.add(objeto);

		/*Para cambiar el color de la página del PDF
		Ejemplo;
			Rectangle r = new Rectangle (100f, 300f);
		Código CMYK
			r.BackgroundColor = new CMYK(25, 90, 25, 0);
		Código RGB
		 	r.BackgroundCOlor = new Color (191, 64, 124);*/

		//Para insertar Textos en el documento PDF

		/*"Chunk" es la pieza más pequeña de texto dentro de un coumento PDF.
		No crean una nueva línea por cada "Chunk" creado.*/
		public void insertarChunk (string x)
		{
			Chunk c = new Chunk (x);
		}

		/*Phrase" es un arreglo de objetos "Chunk".
		Este objeto si toma en consideración el espacio entre ellos y crea nuevas líneas.*/
		public void insertarPhrase (string x)
		{
			Phrase p = new Phrase ();
			p.Add (x);
		}

		/*"Paragraph" es un conjunto de objetos "Chunk" y "Phrase".
		Se rige por los márgenes de la página y siempre hay una nueva línea entre objetos "Paragraph".*/
		public void insertarParagraph(string x)
		{
			Paragraph pa = new Paragraph (new Phrase(x));
			pa.Add (pa);
		}

		//Permite agregar un valor numérico para añadir sangrado a la primera línea.
		public void insertSangria1raLinea (float y)
		{
			Paragraph pa = new Paragraph ();
			pa.FirstLineIndent = y;
		}

		//Permite añadir sangrado al lado izquierdo.
		public void insertSangria1raLinea (float y)
		{
			Paragraph pa = new Paragraph ();
			pa.IndentationLeft = y;
		}

		//Permite añadir sangrado al lado derecho.
		public void insertSangria1raLinea (float y)
		{
			Paragraph pa = new Paragraph ();
			pa.IndentationRight = y;
		}

		//Define la cantidad de espacio antes del párrafo.
		public void insertSangria1raLinea (float y)
		{
			Paragraph pa = new Paragraph ();
			pa.SpacingBefore = y;
		}

		//Define la cantidad de espacio después del párrafo.
		public void insertSangria1raLinea (float y)
		{
			Paragraph pa = new Paragraph ();
			pa.SpacingAfter = y;
		}

	}
}*/