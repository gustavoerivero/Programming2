
// This file has been generated by the GUI designer. Do not modify.
namespace DamageControl
{
	public partial class MenuPrincipal
	{
		private global::Gtk.Frame frameMenu;
		
		private global::Gtk.Alignment GtkAligInterior;
		
		private global::Gtk.Alignment alignment1;
		
		private global::Gtk.VBox vbox1;
		
		private global::Gtk.HBox hbox4;
		
		private global::Gtk.Button butInfoUsuario;
		
		private global::Gtk.Label labUsuario;
		
		private global::Gtk.Fixed fixed7;
		
		private global::Gtk.Label labFecha;
		
		private global::Gtk.Image imgMenuPrincipal;
		
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.Notebook notebookMenu;
		
		private global::Gtk.Alignment alignActualizar;
		
		private global::Gtk.VBox vbox2;
		
		private global::Gtk.Image imgActualizar;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		
		private global::Gtk.TextView textVActualizar;
		
		private global::Gtk.Button butActualizar;
		
		private global::Gtk.Label labActualizaciones;
		
		private global::Gtk.Alignment alignReportes;
		
		private global::Gtk.VBox vbox3;
		
		private global::Gtk.Image imgReportes;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow1;
		
		private global::Gtk.TextView textVReportes;
		
		private global::Gtk.Button butReportes;
		
		private global::Gtk.Label labReportes;
		
		private global::Gtk.Alignment alignCreditos;
		
		private global::Gtk.VBox vbox4;
		
		private global::Gtk.Image imgCreditos;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow2;
		
		private global::Gtk.TextView textVCreditos;
		
		private global::Gtk.Label labCreditos;
		
		private global::Gtk.HBox hbox3;
		
		private global::Gtk.Button butCerrarSesion;
		
		private global::Gtk.Button butSalir;
		
		private global::Gtk.Label GtkLabDamageControl;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget DamageControl.MenuPrincipal
			this.Name = "DamageControl.MenuPrincipal";
			this.Title = global::Mono.Unix.Catalog.GetString ("Menú Principal");
			this.WindowPosition = ((global::Gtk.WindowPosition)(3));
			// Container child DamageControl.MenuPrincipal.Gtk.Container+ContainerChild
			this.frameMenu = new global::Gtk.Frame ();
			this.frameMenu.Name = "frameMenu";
			this.frameMenu.ShadowType = ((global::Gtk.ShadowType)(1));
			this.frameMenu.BorderWidth = ((uint)(15));
			// Container child frameMenu.Gtk.Container+ContainerChild
			this.GtkAligInterior = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAligInterior.Name = "GtkAligInterior";
			this.GtkAligInterior.LeftPadding = ((uint)(12));
			this.GtkAligInterior.BorderWidth = ((uint)(15));
			// Container child GtkAligInterior.Gtk.Container+ContainerChild
			this.alignment1 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment1.Name = "alignment1";
			// Container child alignment1.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.butInfoUsuario = new global::Gtk.Button ();
			this.butInfoUsuario.WidthRequest = 40;
			this.butInfoUsuario.HeightRequest = 35;
			this.butInfoUsuario.CanFocus = true;
			this.butInfoUsuario.Name = "butInfoUsuario";
			this.butInfoUsuario.UseUnderline = true;
			global::Gtk.Image w1 = new global::Gtk.Image ();
			w1.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-dialog-info", global::Gtk.IconSize.Menu);
			this.butInfoUsuario.Image = w1;
			this.hbox4.Add (this.butInfoUsuario);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.butInfoUsuario]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			w2.Padding = ((uint)(10));
			// Container child hbox4.Gtk.Box+BoxChild
			this.labUsuario = new global::Gtk.Label ();
			this.labUsuario.WidthRequest = 150;
			this.labUsuario.Name = "labUsuario";
			this.labUsuario.Xalign = 0F;
			this.labUsuario.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>labUsuario</b>");
			this.labUsuario.UseMarkup = true;
			this.labUsuario.UseUnderline = true;
			this.hbox4.Add (this.labUsuario);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.labUsuario]));
			w3.Position = 1;
			w3.Expand = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.fixed7 = new global::Gtk.Fixed ();
			this.fixed7.Name = "fixed7";
			this.fixed7.HasWindow = false;
			this.hbox4.Add (this.fixed7);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.fixed7]));
			w4.Position = 2;
			// Container child hbox4.Gtk.Box+BoxChild
			this.labFecha = new global::Gtk.Label ();
			this.labFecha.WidthRequest = 200;
			this.labFecha.Name = "labFecha";
			this.labFecha.Xalign = 0F;
			this.labFecha.LabelProp = global::Mono.Unix.Catalog.GetString ("labFecha");
			this.hbox4.Add (this.labFecha);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.labFecha]));
			w5.Position = 3;
			w5.Expand = false;
			this.vbox1.Add (this.hbox4);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox4]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.imgMenuPrincipal = new global::Gtk.Image ();
			this.imgMenuPrincipal.Name = "imgMenuPrincipal";
			this.imgMenuPrincipal.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("DamageControl.imagenes.Logo-Damage-Control.png");
			this.vbox1.Add (this.imgMenuPrincipal);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.imgMenuPrincipal]));
			w7.Position = 1;
			w7.Expand = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.notebookMenu = new global::Gtk.Notebook ();
			this.notebookMenu.CanFocus = true;
			this.notebookMenu.Name = "notebookMenu";
			this.notebookMenu.CurrentPage = 1;
			this.notebookMenu.TabPos = ((global::Gtk.PositionType)(0));
			this.notebookMenu.BorderWidth = ((uint)(5));
			// Container child notebookMenu.Gtk.Notebook+NotebookChild
			this.alignActualizar = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignActualizar.Name = "alignActualizar";
			this.alignActualizar.LeftPadding = ((uint)(15));
			this.alignActualizar.TopPadding = ((uint)(10));
			this.alignActualizar.RightPadding = ((uint)(5));
			this.alignActualizar.BottomPadding = ((uint)(5));
			// Container child alignActualizar.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.imgActualizar = new global::Gtk.Image ();
			this.imgActualizar.Name = "imgActualizar";
			this.imgActualizar.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("DamageControl.imagenes.Actualizar.png");
			this.vbox2.Add (this.imgActualizar);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.imgActualizar]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.textVActualizar = new global::Gtk.TextView ();
			this.textVActualizar.Buffer.Text = @"Damage Control, C.A. maneja información importante en cuanto los cursos que dicta, los grupos que reciben las clases dadas, los instructores que laboran en la empresa y los mismísimos estudiantes que, a fin de cuenta, es a quien va dirigida nuestra misión y razón de ser.
Esta opción de ""Actualizar"" permite la inclusión, modificación, eliminación en cuanto a la información de los cursos, grupos, instructores y estudiantes presentes en nuestra organización.";
			this.textVActualizar.CanFocus = true;
			this.textVActualizar.Name = "textVActualizar";
			this.textVActualizar.Editable = false;
			this.textVActualizar.CursorVisible = false;
			this.textVActualizar.AcceptsTab = false;
			this.textVActualizar.Justification = ((global::Gtk.Justification)(3));
			this.textVActualizar.WrapMode = ((global::Gtk.WrapMode)(3));
			this.textVActualizar.PixelsAboveLines = 5;
			this.textVActualizar.PixelsBelowLines = 5;
			this.textVActualizar.LeftMargin = 15;
			this.textVActualizar.RightMargin = 10;
			this.textVActualizar.Indent = 25;
			this.GtkScrolledWindow.Add (this.textVActualizar);
			this.vbox2.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.GtkScrolledWindow]));
			w10.Position = 1;
			// Container child vbox2.Gtk.Box+BoxChild
			this.butActualizar = new global::Gtk.Button ();
			this.butActualizar.HeightRequest = 50;
			this.butActualizar.CanFocus = true;
			this.butActualizar.Name = "butActualizar";
			this.butActualizar.UseUnderline = true;
			this.butActualizar.Label = global::Mono.Unix.Catalog.GetString ("Actualizar datos");
			this.vbox2.Add (this.butActualizar);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.butActualizar]));
			w11.Position = 2;
			w11.Expand = false;
			w11.Fill = false;
			this.alignActualizar.Add (this.vbox2);
			this.notebookMenu.Add (this.alignActualizar);
			// Notebook tab
			this.labActualizaciones = new global::Gtk.Label ();
			this.labActualizaciones.Name = "labActualizaciones";
			this.labActualizaciones.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Actualizar</b>");
			this.labActualizaciones.UseMarkup = true;
			this.notebookMenu.SetTabLabel (this.alignActualizar, this.labActualizaciones);
			this.labActualizaciones.ShowAll ();
			// Container child notebookMenu.Gtk.Notebook+NotebookChild
			this.alignReportes = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignReportes.Name = "alignReportes";
			this.alignReportes.LeftPadding = ((uint)(15));
			this.alignReportes.TopPadding = ((uint)(10));
			this.alignReportes.RightPadding = ((uint)(5));
			this.alignReportes.BottomPadding = ((uint)(5));
			// Container child alignReportes.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.imgReportes = new global::Gtk.Image ();
			this.imgReportes.Name = "imgReportes";
			this.imgReportes.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("DamageControl.imagenes.Reporte.png");
			this.vbox3.Add (this.imgReportes);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.imgReportes]));
			w14.Position = 0;
			w14.Expand = false;
			w14.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.textVReportes = new global::Gtk.TextView ();
			this.textVReportes.Buffer.Text = @"Damage Control, C.A. mantiene un control sobre los cursos que dicta y los grupos que han formado parte de la organización, es por eso que trabaja con reportes que indican información importante para la toma de decisiones en la empresa.
Esta opción de ""Reportes"" permite generar dos diferentes tipos de listados; ""Listado de cursos"" que permite conocer por parte de cada curso, la cantidad de grupos de ese curso en una determinada fecha. Y ""Listado de grupos culminados a la fecha actual"" que indica los grupos que han finalizado hasta la fecha.";
			this.textVReportes.CanFocus = true;
			this.textVReportes.Name = "textVReportes";
			this.textVReportes.Editable = false;
			this.textVReportes.CursorVisible = false;
			this.textVReportes.AcceptsTab = false;
			this.textVReportes.Justification = ((global::Gtk.Justification)(3));
			this.textVReportes.WrapMode = ((global::Gtk.WrapMode)(3));
			this.textVReportes.PixelsAboveLines = 5;
			this.textVReportes.PixelsBelowLines = 5;
			this.textVReportes.LeftMargin = 15;
			this.textVReportes.RightMargin = 10;
			this.textVReportes.Indent = 25;
			this.GtkScrolledWindow1.Add (this.textVReportes);
			this.vbox3.Add (this.GtkScrolledWindow1);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.GtkScrolledWindow1]));
			w16.Position = 1;
			// Container child vbox3.Gtk.Box+BoxChild
			this.butReportes = new global::Gtk.Button ();
			this.butReportes.HeightRequest = 50;
			this.butReportes.CanFocus = true;
			this.butReportes.Name = "butReportes";
			this.butReportes.UseUnderline = true;
			this.butReportes.Label = global::Mono.Unix.Catalog.GetString ("Solicitar reportes");
			this.vbox3.Add (this.butReportes);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.butReportes]));
			w17.Position = 2;
			w17.Expand = false;
			this.alignReportes.Add (this.vbox3);
			this.notebookMenu.Add (this.alignReportes);
			global::Gtk.Notebook.NotebookChild w19 = ((global::Gtk.Notebook.NotebookChild)(this.notebookMenu [this.alignReportes]));
			w19.Position = 1;
			// Notebook tab
			this.labReportes = new global::Gtk.Label ();
			this.labReportes.Name = "labReportes";
			this.labReportes.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Reportes</b>");
			this.labReportes.UseMarkup = true;
			this.notebookMenu.SetTabLabel (this.alignReportes, this.labReportes);
			this.labReportes.ShowAll ();
			// Container child notebookMenu.Gtk.Notebook+NotebookChild
			this.alignCreditos = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignCreditos.Name = "alignCreditos";
			this.alignCreditos.LeftPadding = ((uint)(15));
			this.alignCreditos.TopPadding = ((uint)(10));
			this.alignCreditos.RightPadding = ((uint)(5));
			this.alignCreditos.BottomPadding = ((uint)(5));
			// Container child alignCreditos.Gtk.Container+ContainerChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.imgCreditos = new global::Gtk.Image ();
			this.imgCreditos.Name = "imgCreditos";
			this.imgCreditos.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("DamageControl.imagenes.Creditos1.png");
			this.vbox4.Add (this.imgCreditos);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.imgCreditos]));
			w20.Position = 0;
			w20.Expand = false;
			w20.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.GtkScrolledWindow2 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow2.Name = "GtkScrolledWindow2";
			this.GtkScrolledWindow2.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow2.Gtk.Container+ContainerChild
			this.textVCreditos = new global::Gtk.TextView ();
			this.textVCreditos.Buffer.Text = @"Damage Control System es una aplicación de escritorio elaborada por el equipo de trabajo UCLASoftware, con la finalidad de dar sencillez en la manipulación de los datos e información importante de la empresa Damage Control, C.A. La aplicación fue hecha en el período diciembre, 2018 a  enero, 2019, utilizando el lenguaje de programación C# bajo el entorno de desarrollo Monodevelop 5.10 para Sistemas Operativos Linux y el sistema de gestión de base de datos MySQL Workbrench 6.3.6.
El equipo de UCLASoftware está conformado por estudiantes de Ingeniería en Informática en la Universidad Centroccidental ""Lisandro Alvarado"". Los integrantes de este equipo, son:
	- Brizuela, Yurisbellys.
	- Camacho, Franklin.
	- Leal, Jesús.
	- Miranda, Marihec.
	- Rivero Gustavo.";
			this.textVCreditos.CanFocus = true;
			this.textVCreditos.Name = "textVCreditos";
			this.textVCreditos.Editable = false;
			this.textVCreditos.CursorVisible = false;
			this.textVCreditos.AcceptsTab = false;
			this.textVCreditos.Justification = ((global::Gtk.Justification)(3));
			this.textVCreditos.WrapMode = ((global::Gtk.WrapMode)(3));
			this.textVCreditos.PixelsAboveLines = 5;
			this.textVCreditos.PixelsBelowLines = 5;
			this.textVCreditos.LeftMargin = 15;
			this.textVCreditos.RightMargin = 10;
			this.textVCreditos.Indent = 25;
			this.GtkScrolledWindow2.Add (this.textVCreditos);
			this.vbox4.Add (this.GtkScrolledWindow2);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.GtkScrolledWindow2]));
			w22.Position = 1;
			this.alignCreditos.Add (this.vbox4);
			this.notebookMenu.Add (this.alignCreditos);
			global::Gtk.Notebook.NotebookChild w24 = ((global::Gtk.Notebook.NotebookChild)(this.notebookMenu [this.alignCreditos]));
			w24.Position = 2;
			// Notebook tab
			this.labCreditos = new global::Gtk.Label ();
			this.labCreditos.Name = "labCreditos";
			this.labCreditos.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Créditos</b>");
			this.labCreditos.UseMarkup = true;
			this.notebookMenu.SetTabLabel (this.alignCreditos, this.labCreditos);
			this.labCreditos.ShowAll ();
			this.hbox1.Add (this.notebookMenu);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.notebookMenu]));
			w25.Position = 0;
			w25.Padding = ((uint)(15));
			this.vbox1.Add (this.hbox1);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
			w26.Position = 2;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Homogeneous = true;
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.butCerrarSesion = new global::Gtk.Button ();
			this.butCerrarSesion.HeightRequest = 50;
			this.butCerrarSesion.CanFocus = true;
			this.butCerrarSesion.Name = "butCerrarSesion";
			this.butCerrarSesion.UseUnderline = true;
			this.butCerrarSesion.Label = global::Mono.Unix.Catalog.GetString ("Cerrar sesión");
			this.hbox3.Add (this.butCerrarSesion);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.butCerrarSesion]));
			w27.Position = 0;
			w27.Expand = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.butSalir = new global::Gtk.Button ();
			this.butSalir.HeightRequest = 50;
			this.butSalir.CanFocus = true;
			this.butSalir.Name = "butSalir";
			this.butSalir.UseUnderline = true;
			this.butSalir.Label = global::Mono.Unix.Catalog.GetString ("Salir");
			this.hbox3.Add (this.butSalir);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.butSalir]));
			w28.Position = 1;
			w28.Expand = false;
			this.vbox1.Add (this.hbox3);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox3]));
			w29.Position = 3;
			w29.Expand = false;
			w29.Fill = false;
			this.alignment1.Add (this.vbox1);
			this.GtkAligInterior.Add (this.alignment1);
			this.frameMenu.Add (this.GtkAligInterior);
			this.GtkLabDamageControl = new global::Gtk.Label ();
			this.GtkLabDamageControl.Name = "GtkLabDamageControl";
			this.GtkLabDamageControl.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Damage Control</b>");
			this.GtkLabDamageControl.UseMarkup = true;
			this.frameMenu.LabelWidget = this.GtkLabDamageControl;
			this.Add (this.frameMenu);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 706;
			this.DefaultHeight = 681;
			this.Show ();
			this.butInfoUsuario.Clicked += new global::System.EventHandler (this.OnButInfoUsuarioClicked);
			this.butActualizar.Clicked += new global::System.EventHandler (this.OnButActualizarClicked);
			this.butReportes.Clicked += new global::System.EventHandler (this.OnButReportesClicked);
			this.butCerrarSesion.Clicked += new global::System.EventHandler (this.OnButCerrarSesionClicked);
			this.butSalir.Clicked += new global::System.EventHandler (this.OnButSalirClicked);
		}
	}
}
