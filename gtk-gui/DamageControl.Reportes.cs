
// This file has been generated by the GUI designer. Do not modify.
namespace DamageControl
{
	public partial class Reportes
	{
		private global::Gtk.VBox vbox1;
		
		private global::Gtk.Alignment alignMarcoReportes;
		
		private global::Gtk.Frame frameReportes;
		
		private global::Gtk.Alignment GtkAlignment;
		
		private global::Gtk.VBox vbox4;
		
		private global::Gtk.HBox hbox3;
		
		private global::Gtk.Button butInfoUsuario;
		
		private global::Gtk.Label labUsuario;
		
		private global::Gtk.Fixed fixedReportes;
		
		private global::Gtk.Label labFecha;
		
		private global::Gtk.HBox hbox8;
		
		private global::Gtk.Notebook notBookReportes;
		
		private global::Gtk.Alignment alignListadoCursos;
		
		private global::Gtk.VBox vboxListadoCursos;
		
		private global::Gtk.HBox hboxConsulta;
		
		private global::Gtk.VBox vboxFechas;
		
		private global::Gtk.HBox hboxFechaInicial;
		
		private global::Gtk.Label labFechaInicial;
		
		private global::Gtk.Entry entFechaInicial;
		
		private global::Gtk.Button butFechaInicial;
		
		private global::Gtk.HBox hboxFechaFinal;
		
		private global::Gtk.Label labFechaFinal;
		
		private global::Gtk.Entry entFechaFinal;
		
		private global::Gtk.Button butFechaFinal;
		
		private global::Gtk.Fixed fixedConsulta;
		
		private global::Gtk.Button butConsultarCursos;
		
		private global::Gtk.Button butLimpiarCursos;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		
		private global::Gtk.TreeView tViewCursos;
		
		private global::Gtk.Label labListadoCursos;
		
		private global::Gtk.Alignment alignListadoGruposCulminados;
		
		private global::Gtk.VBox vboxListadoGruposCulminados;
		
		private global::Gtk.VBox vbox5;
		
		private global::Gtk.HBox hbox6;
		
		private global::Gtk.Fixed fixedConsulta1;
		
		private global::Gtk.Button butConsultarGrupos;
		
		private global::Gtk.Button butLimpiarGrupos;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow1;
		
		private global::Gtk.TreeView tViewGrupos;
		
		private global::Gtk.Label labListadoGruposCulminados;
		
		private global::Gtk.HBox hbox7;
		
		private global::Gtk.Button butCerrarSesion;
		
		private global::Gtk.Button butRegresar;
		
		private global::Gtk.Button butSalir;
		
		private global::Gtk.Label frameReportes1;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget DamageControl.Reportes
			this.Name = "DamageControl.Reportes";
			this.Title = global::Mono.Unix.Catalog.GetString ("Reportes");
			this.WindowPosition = ((global::Gtk.WindowPosition)(3));
			// Container child DamageControl.Reportes.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.alignMarcoReportes = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignMarcoReportes.Name = "alignMarcoReportes";
			// Container child alignMarcoReportes.Gtk.Container+ContainerChild
			this.frameReportes = new global::Gtk.Frame ();
			this.frameReportes.Name = "frameReportes";
			this.frameReportes.ShadowType = ((global::Gtk.ShadowType)(1));
			this.frameReportes.BorderWidth = ((uint)(15));
			// Container child frameReportes.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment.Name = "GtkAlignment";
			this.GtkAlignment.LeftPadding = ((uint)(12));
			this.GtkAlignment.BorderWidth = ((uint)(15));
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.butInfoUsuario = new global::Gtk.Button ();
			this.butInfoUsuario.WidthRequest = 40;
			this.butInfoUsuario.HeightRequest = 35;
			this.butInfoUsuario.CanFocus = true;
			this.butInfoUsuario.Name = "butInfoUsuario";
			this.butInfoUsuario.UseUnderline = true;
			global::Gtk.Image w1 = new global::Gtk.Image ();
			w1.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-dialog-info", global::Gtk.IconSize.Menu);
			this.butInfoUsuario.Image = w1;
			this.hbox3.Add (this.butInfoUsuario);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.butInfoUsuario]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			w2.Padding = ((uint)(10));
			// Container child hbox3.Gtk.Box+BoxChild
			this.labUsuario = new global::Gtk.Label ();
			this.labUsuario.WidthRequest = 150;
			this.labUsuario.Name = "labUsuario";
			this.labUsuario.Xalign = 0F;
			this.labUsuario.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>labUsuario</b>");
			this.labUsuario.UseMarkup = true;
			this.labUsuario.UseUnderline = true;
			this.hbox3.Add (this.labUsuario);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.labUsuario]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Padding = ((uint)(10));
			// Container child hbox3.Gtk.Box+BoxChild
			this.fixedReportes = new global::Gtk.Fixed ();
			this.fixedReportes.Name = "fixedReportes";
			this.fixedReportes.HasWindow = false;
			this.hbox3.Add (this.fixedReportes);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.fixedReportes]));
			w4.Position = 2;
			// Container child hbox3.Gtk.Box+BoxChild
			this.labFecha = new global::Gtk.Label ();
			this.labFecha.WidthRequest = 200;
			this.labFecha.Name = "labFecha";
			this.labFecha.Xalign = 0F;
			this.labFecha.LabelProp = global::Mono.Unix.Catalog.GetString ("labFecha");
			this.hbox3.Add (this.labFecha);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.labFecha]));
			w5.Position = 3;
			w5.Expand = false;
			w5.Padding = ((uint)(10));
			this.vbox4.Add (this.hbox3);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox3]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox8 = new global::Gtk.HBox ();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.notBookReportes = new global::Gtk.Notebook ();
			this.notBookReportes.CanFocus = true;
			this.notBookReportes.Name = "notBookReportes";
			this.notBookReportes.CurrentPage = 0;
			// Container child notBookReportes.Gtk.Notebook+NotebookChild
			this.alignListadoCursos = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignListadoCursos.Name = "alignListadoCursos";
			this.alignListadoCursos.BorderWidth = ((uint)(15));
			// Container child alignListadoCursos.Gtk.Container+ContainerChild
			this.vboxListadoCursos = new global::Gtk.VBox ();
			this.vboxListadoCursos.Name = "vboxListadoCursos";
			this.vboxListadoCursos.Spacing = 6;
			// Container child vboxListadoCursos.Gtk.Box+BoxChild
			this.hboxConsulta = new global::Gtk.HBox ();
			this.hboxConsulta.Name = "hboxConsulta";
			this.hboxConsulta.Spacing = 6;
			// Container child hboxConsulta.Gtk.Box+BoxChild
			this.vboxFechas = new global::Gtk.VBox ();
			this.vboxFechas.Name = "vboxFechas";
			this.vboxFechas.Spacing = 6;
			// Container child vboxFechas.Gtk.Box+BoxChild
			this.hboxFechaInicial = new global::Gtk.HBox ();
			this.hboxFechaInicial.Name = "hboxFechaInicial";
			this.hboxFechaInicial.Spacing = 6;
			// Container child hboxFechaInicial.Gtk.Box+BoxChild
			this.labFechaInicial = new global::Gtk.Label ();
			this.labFechaInicial.WidthRequest = 100;
			this.labFechaInicial.Name = "labFechaInicial";
			this.labFechaInicial.Xalign = 0F;
			this.labFechaInicial.LabelProp = global::Mono.Unix.Catalog.GetString ("Fecha inicial: ");
			this.hboxFechaInicial.Add (this.labFechaInicial);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hboxFechaInicial [this.labFechaInicial]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Padding = ((uint)(25));
			// Container child hboxFechaInicial.Gtk.Box+BoxChild
			this.entFechaInicial = new global::Gtk.Entry ();
			this.entFechaInicial.WidthRequest = 150;
			this.entFechaInicial.CanFocus = true;
			this.entFechaInicial.Name = "entFechaInicial";
			this.entFechaInicial.IsEditable = false;
			this.entFechaInicial.InvisibleChar = '•';
			this.hboxFechaInicial.Add (this.entFechaInicial);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hboxFechaInicial [this.entFechaInicial]));
			w8.Position = 1;
			w8.Expand = false;
			// Container child hboxFechaInicial.Gtk.Box+BoxChild
			this.butFechaInicial = new global::Gtk.Button ();
			this.butFechaInicial.WidthRequest = 40;
			this.butFechaInicial.CanFocus = true;
			this.butFechaInicial.Name = "butFechaInicial";
			this.butFechaInicial.UseUnderline = true;
			global::Gtk.Image w9 = new global::Gtk.Image ();
			w9.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "stock_calendar", global::Gtk.IconSize.Menu);
			this.butFechaInicial.Image = w9;
			this.hboxFechaInicial.Add (this.butFechaInicial);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hboxFechaInicial [this.butFechaInicial]));
			w10.Position = 2;
			w10.Expand = false;
			w10.Fill = false;
			this.vboxFechas.Add (this.hboxFechaInicial);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vboxFechas [this.hboxFechaInicial]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vboxFechas.Gtk.Box+BoxChild
			this.hboxFechaFinal = new global::Gtk.HBox ();
			this.hboxFechaFinal.Name = "hboxFechaFinal";
			this.hboxFechaFinal.Spacing = 6;
			// Container child hboxFechaFinal.Gtk.Box+BoxChild
			this.labFechaFinal = new global::Gtk.Label ();
			this.labFechaFinal.WidthRequest = 100;
			this.labFechaFinal.Name = "labFechaFinal";
			this.labFechaFinal.Xalign = 0F;
			this.labFechaFinal.LabelProp = global::Mono.Unix.Catalog.GetString ("Fecha final: ");
			this.hboxFechaFinal.Add (this.labFechaFinal);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hboxFechaFinal [this.labFechaFinal]));
			w12.Position = 0;
			w12.Expand = false;
			w12.Padding = ((uint)(25));
			// Container child hboxFechaFinal.Gtk.Box+BoxChild
			this.entFechaFinal = new global::Gtk.Entry ();
			this.entFechaFinal.WidthRequest = 150;
			this.entFechaFinal.CanFocus = true;
			this.entFechaFinal.Name = "entFechaFinal";
			this.entFechaFinal.IsEditable = false;
			this.entFechaFinal.InvisibleChar = '•';
			this.hboxFechaFinal.Add (this.entFechaFinal);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hboxFechaFinal [this.entFechaFinal]));
			w13.Position = 1;
			w13.Expand = false;
			// Container child hboxFechaFinal.Gtk.Box+BoxChild
			this.butFechaFinal = new global::Gtk.Button ();
			this.butFechaFinal.WidthRequest = 40;
			this.butFechaFinal.CanFocus = true;
			this.butFechaFinal.Name = "butFechaFinal";
			this.butFechaFinal.UseUnderline = true;
			global::Gtk.Image w14 = new global::Gtk.Image ();
			w14.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "stock_calendar", global::Gtk.IconSize.Menu);
			this.butFechaFinal.Image = w14;
			this.hboxFechaFinal.Add (this.butFechaFinal);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hboxFechaFinal [this.butFechaFinal]));
			w15.Position = 2;
			w15.Expand = false;
			w15.Fill = false;
			this.vboxFechas.Add (this.hboxFechaFinal);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vboxFechas [this.hboxFechaFinal]));
			w16.Position = 1;
			w16.Expand = false;
			w16.Fill = false;
			this.hboxConsulta.Add (this.vboxFechas);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hboxConsulta [this.vboxFechas]));
			w17.Position = 0;
			// Container child hboxConsulta.Gtk.Box+BoxChild
			this.fixedConsulta = new global::Gtk.Fixed ();
			this.fixedConsulta.Name = "fixedConsulta";
			this.fixedConsulta.HasWindow = false;
			this.hboxConsulta.Add (this.fixedConsulta);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hboxConsulta [this.fixedConsulta]));
			w18.Position = 1;
			w18.Padding = ((uint)(5));
			// Container child hboxConsulta.Gtk.Box+BoxChild
			this.butConsultarCursos = new global::Gtk.Button ();
			this.butConsultarCursos.WidthRequest = 80;
			this.butConsultarCursos.HeightRequest = 70;
			this.butConsultarCursos.CanFocus = true;
			this.butConsultarCursos.Name = "butConsultarCursos";
			this.butConsultarCursos.Label = global::Mono.Unix.Catalog.GetString ("Consultar");
			this.hboxConsulta.Add (this.butConsultarCursos);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hboxConsulta [this.butConsultarCursos]));
			w19.Position = 2;
			w19.Expand = false;
			w19.Fill = false;
			// Container child hboxConsulta.Gtk.Box+BoxChild
			this.butLimpiarCursos = new global::Gtk.Button ();
			this.butLimpiarCursos.WidthRequest = 80;
			this.butLimpiarCursos.HeightRequest = 70;
			this.butLimpiarCursos.CanFocus = true;
			this.butLimpiarCursos.Name = "butLimpiarCursos";
			this.butLimpiarCursos.Label = global::Mono.Unix.Catalog.GetString ("Limpiar");
			this.hboxConsulta.Add (this.butLimpiarCursos);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hboxConsulta [this.butLimpiarCursos]));
			w20.PackType = ((global::Gtk.PackType)(1));
			w20.Position = 3;
			w20.Expand = false;
			w20.Padding = ((uint)(25));
			this.vboxListadoCursos.Add (this.hboxConsulta);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vboxListadoCursos [this.hboxConsulta]));
			w21.Position = 0;
			w21.Expand = false;
			w21.Fill = false;
			// Container child vboxListadoCursos.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.tViewCursos = new global::Gtk.TreeView ();
			this.tViewCursos.CanFocus = true;
			this.tViewCursos.Name = "tViewCursos";
			this.GtkScrolledWindow.Add (this.tViewCursos);
			this.vboxListadoCursos.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vboxListadoCursos [this.GtkScrolledWindow]));
			w23.Position = 1;
			this.alignListadoCursos.Add (this.vboxListadoCursos);
			this.notBookReportes.Add (this.alignListadoCursos);
			// Notebook tab
			this.labListadoCursos = new global::Gtk.Label ();
			this.labListadoCursos.Name = "labListadoCursos";
			this.labListadoCursos.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Listado de Cursos</b>");
			this.labListadoCursos.UseMarkup = true;
			this.notBookReportes.SetTabLabel (this.alignListadoCursos, this.labListadoCursos);
			this.labListadoCursos.ShowAll ();
			// Container child notBookReportes.Gtk.Notebook+NotebookChild
			this.alignListadoGruposCulminados = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignListadoGruposCulminados.Name = "alignListadoGruposCulminados";
			this.alignListadoGruposCulminados.BorderWidth = ((uint)(15));
			// Container child alignListadoGruposCulminados.Gtk.Container+ContainerChild
			this.vboxListadoGruposCulminados = new global::Gtk.VBox ();
			this.vboxListadoGruposCulminados.Name = "vboxListadoGruposCulminados";
			this.vboxListadoGruposCulminados.Spacing = 6;
			// Container child vboxListadoGruposCulminados.Gtk.Box+BoxChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox ();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.fixedConsulta1 = new global::Gtk.Fixed ();
			this.fixedConsulta1.Name = "fixedConsulta1";
			this.fixedConsulta1.HasWindow = false;
			this.hbox6.Add (this.fixedConsulta1);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.fixedConsulta1]));
			w26.Position = 0;
			// Container child hbox6.Gtk.Box+BoxChild
			this.butConsultarGrupos = new global::Gtk.Button ();
			this.butConsultarGrupos.WidthRequest = 80;
			this.butConsultarGrupos.HeightRequest = 70;
			this.butConsultarGrupos.CanFocus = true;
			this.butConsultarGrupos.Name = "butConsultarGrupos";
			this.butConsultarGrupos.Label = global::Mono.Unix.Catalog.GetString ("Consultar");
			this.hbox6.Add (this.butConsultarGrupos);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.butConsultarGrupos]));
			w27.Position = 1;
			w27.Expand = false;
			w27.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.butLimpiarGrupos = new global::Gtk.Button ();
			this.butLimpiarGrupos.WidthRequest = 80;
			this.butLimpiarGrupos.CanFocus = true;
			this.butLimpiarGrupos.Name = "butLimpiarGrupos";
			this.butLimpiarGrupos.Label = global::Mono.Unix.Catalog.GetString ("Limpiar");
			this.hbox6.Add (this.butLimpiarGrupos);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.butLimpiarGrupos]));
			w28.Position = 2;
			w28.Expand = false;
			w28.Fill = false;
			w28.Padding = ((uint)(25));
			this.vbox5.Add (this.hbox6);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.hbox6]));
			w29.Position = 0;
			w29.Expand = false;
			w29.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.tViewGrupos = new global::Gtk.TreeView ();
			this.tViewGrupos.CanFocus = true;
			this.tViewGrupos.Name = "tViewGrupos";
			this.GtkScrolledWindow1.Add (this.tViewGrupos);
			this.vbox5.Add (this.GtkScrolledWindow1);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.GtkScrolledWindow1]));
			w31.Position = 1;
			this.vboxListadoGruposCulminados.Add (this.vbox5);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.vboxListadoGruposCulminados [this.vbox5]));
			w32.Position = 0;
			this.alignListadoGruposCulminados.Add (this.vboxListadoGruposCulminados);
			this.notBookReportes.Add (this.alignListadoGruposCulminados);
			global::Gtk.Notebook.NotebookChild w34 = ((global::Gtk.Notebook.NotebookChild)(this.notBookReportes [this.alignListadoGruposCulminados]));
			w34.Position = 1;
			// Notebook tab
			this.labListadoGruposCulminados = new global::Gtk.Label ();
			this.labListadoGruposCulminados.Name = "labListadoGruposCulminados";
			this.labListadoGruposCulminados.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Listado de Grupos Culminados</b>");
			this.labListadoGruposCulminados.UseMarkup = true;
			this.notBookReportes.SetTabLabel (this.alignListadoGruposCulminados, this.labListadoGruposCulminados);
			this.labListadoGruposCulminados.ShowAll ();
			this.hbox8.Add (this.notBookReportes);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.notBookReportes]));
			w35.Position = 0;
			this.vbox4.Add (this.hbox8);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox8]));
			w36.Position = 1;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox7 = new global::Gtk.HBox ();
			this.hbox7.Name = "hbox7";
			this.hbox7.Homogeneous = true;
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.butCerrarSesion = new global::Gtk.Button ();
			this.butCerrarSesion.HeightRequest = 50;
			this.butCerrarSesion.CanFocus = true;
			this.butCerrarSesion.Name = "butCerrarSesion";
			this.butCerrarSesion.UseUnderline = true;
			this.butCerrarSesion.Label = global::Mono.Unix.Catalog.GetString ("Cerrar sesión");
			this.hbox7.Add (this.butCerrarSesion);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.butCerrarSesion]));
			w37.Position = 0;
			// Container child hbox7.Gtk.Box+BoxChild
			this.butRegresar = new global::Gtk.Button ();
			this.butRegresar.CanFocus = true;
			this.butRegresar.Name = "butRegresar";
			this.butRegresar.UseUnderline = true;
			this.butRegresar.Label = global::Mono.Unix.Catalog.GetString ("Ventana anterior");
			this.hbox7.Add (this.butRegresar);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.butRegresar]));
			w38.Position = 1;
			// Container child hbox7.Gtk.Box+BoxChild
			this.butSalir = new global::Gtk.Button ();
			this.butSalir.CanFocus = true;
			this.butSalir.Name = "butSalir";
			this.butSalir.UseUnderline = true;
			this.butSalir.Label = global::Mono.Unix.Catalog.GetString ("Salir");
			this.hbox7.Add (this.butSalir);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.butSalir]));
			w39.Position = 2;
			w39.Expand = false;
			this.vbox4.Add (this.hbox7);
			global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox7]));
			w40.Position = 2;
			w40.Expand = false;
			w40.Fill = false;
			this.GtkAlignment.Add (this.vbox4);
			this.frameReportes.Add (this.GtkAlignment);
			this.frameReportes1 = new global::Gtk.Label ();
			this.frameReportes1.Name = "frameReportes1";
			this.frameReportes1.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Menú de reportes</b>");
			this.frameReportes1.UseMarkup = true;
			this.frameReportes.LabelWidget = this.frameReportes1;
			this.alignMarcoReportes.Add (this.frameReportes);
			this.vbox1.Add (this.alignMarcoReportes);
			global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.alignMarcoReportes]));
			w44.Position = 0;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 708;
			this.DefaultHeight = 511;
			this.Show ();
			this.butInfoUsuario.Clicked += new global::System.EventHandler (this.OnButInfoUsuarioClicked);
			this.butFechaInicial.Clicked += new global::System.EventHandler (this.OnButFechaInicialClicked);
			this.butFechaFinal.Clicked += new global::System.EventHandler (this.OnButFechaFinalClicked);
			this.butConsultarCursos.Clicked += new global::System.EventHandler (this.OnButConsultarCursosClicked);
			this.butLimpiarCursos.Clicked += new global::System.EventHandler (this.OnButLimpiarCursosClicked);
			this.butConsultarGrupos.Clicked += new global::System.EventHandler (this.OnButConsultarGruposClicked);
			this.butLimpiarGrupos.Clicked += new global::System.EventHandler (this.OnButLimpiarGruposClicked);
			this.butCerrarSesion.Clicked += new global::System.EventHandler (this.OnButCerrarSesionClicked);
			this.butRegresar.Clicked += new global::System.EventHandler (this.OnButRegresarClicked);
			this.butSalir.Clicked += new global::System.EventHandler (this.OnButSalirClicked);
		}
	}
}
