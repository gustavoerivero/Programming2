
// This file has been generated by the GUI designer. Do not modify.
namespace DamageControl
{
	public partial class InfoDeUsuario
	{
		private global::Gtk.Frame frameInfo;
		
		private global::Gtk.Alignment GtkAligInterior;
		
		private global::Gtk.VBox vbox3;
		
		private global::Gtk.HBox hbox13;
		
		private global::Gtk.Fixed fixedInfo;
		
		private global::Gtk.Label labFecha;
		
		private global::Gtk.Image imgLogoInfo;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		
		private global::Gtk.TextView textview1;
		
		private global::Gtk.HBox hbox6;
		
		private global::Gtk.Label labUsuarioConectado;
		
		private global::Gtk.Label labUsuario;
		
		private global::Gtk.HBox hbox7;
		
		private global::Gtk.Label labTipoU;
		
		private global::Gtk.Label labTipoUsuarioIndicador;
		
		private global::Gtk.HBox hbox8;
		
		private global::Gtk.Label labPermisos;
		
		private global::Gtk.Label labPermisosIndicador;
		
		private global::Gtk.Button butCerrar;
		
		private global::Gtk.Label GtkLabInformación;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget DamageControl.InfoDeUsuario
			this.Name = "DamageControl.InfoDeUsuario";
			this.Title = global::Mono.Unix.Catalog.GetString ("Información");
			this.WindowPosition = ((global::Gtk.WindowPosition)(3));
			this.BorderWidth = ((uint)(15));
			// Container child DamageControl.InfoDeUsuario.Gtk.Container+ContainerChild
			this.frameInfo = new global::Gtk.Frame ();
			this.frameInfo.Name = "frameInfo";
			this.frameInfo.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child frameInfo.Gtk.Container+ContainerChild
			this.GtkAligInterior = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAligInterior.Name = "GtkAligInterior";
			this.GtkAligInterior.LeftPadding = ((uint)(12));
			this.GtkAligInterior.BorderWidth = ((uint)(15));
			// Container child GtkAligInterior.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox13 = new global::Gtk.HBox ();
			this.hbox13.Name = "hbox13";
			this.hbox13.Spacing = 6;
			// Container child hbox13.Gtk.Box+BoxChild
			this.fixedInfo = new global::Gtk.Fixed ();
			this.fixedInfo.WidthRequest = 20;
			this.fixedInfo.Name = "fixedInfo";
			this.fixedInfo.HasWindow = false;
			this.hbox13.Add (this.fixedInfo);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox13 [this.fixedInfo]));
			w1.Position = 0;
			// Container child hbox13.Gtk.Box+BoxChild
			this.labFecha = new global::Gtk.Label ();
			this.labFecha.WidthRequest = 200;
			this.labFecha.Name = "labFecha";
			this.labFecha.Xalign = 0F;
			this.labFecha.LabelProp = global::Mono.Unix.Catalog.GetString ("labFecha");
			this.hbox13.Add (this.labFecha);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox13 [this.labFecha]));
			w2.Position = 1;
			w2.Expand = false;
			this.vbox3.Add (this.hbox13);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox13]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.imgLogoInfo = new global::Gtk.Image ();
			this.imgLogoInfo.Name = "imgLogoInfo";
			this.imgLogoInfo.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("DamageControl.imagenes.Logo-Damage-Control.png");
			this.vbox3.Add (this.imgLogoInfo);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.imgLogoInfo]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.textview1 = new global::Gtk.TextView ();
			this.textview1.Buffer.Text = @"Damage Control, C.A., es una empresa de servicios dedicada a impartir los mejores cursos del país en cuanto a temas como ""Tecnología de punta"", ""Desarrollo de programas de escritorio"" y ""Aplicaciones móviles (iOS y Android)"". Esta empresa cuenta con instructores jóvenes altamente capacitados en el área y que se encuentran en constante aprendizaje, motivados a impartir sus conocimientos. La empresa también dispone de equipos actualizados con los software y hardware de vanguardia, brindando así calidad en la enseñanza. Todo esto con la finalidad de transmitir a todos sus estudiantes un conocimiento amplio y completo, cubriendo así sus altas expectativas y necesidades.";
			this.textview1.CanFocus = true;
			this.textview1.Name = "textview1";
			this.textview1.Editable = false;
			this.textview1.CursorVisible = false;
			this.textview1.AcceptsTab = false;
			this.textview1.Justification = ((global::Gtk.Justification)(3));
			this.textview1.WrapMode = ((global::Gtk.WrapMode)(2));
			this.textview1.PixelsAboveLines = 10;
			this.textview1.PixelsBelowLines = 10;
			this.textview1.PixelsInsideWrap = 2;
			this.textview1.LeftMargin = 10;
			this.textview1.RightMargin = 10;
			this.textview1.Indent = 30;
			this.GtkScrolledWindow.Add (this.textview1);
			this.vbox3.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.GtkScrolledWindow]));
			w6.Position = 2;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox ();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.labUsuarioConectado = new global::Gtk.Label ();
			this.labUsuarioConectado.Name = "labUsuarioConectado";
			this.labUsuarioConectado.Xalign = 0F;
			this.labUsuarioConectado.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Usuario conectado: </b>");
			this.labUsuarioConectado.UseMarkup = true;
			this.hbox6.Add (this.labUsuarioConectado);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.labUsuarioConectado]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Padding = ((uint)(50));
			// Container child hbox6.Gtk.Box+BoxChild
			this.labUsuario = new global::Gtk.Label ();
			this.labUsuario.WidthRequest = 250;
			this.labUsuario.Name = "labUsuario";
			this.labUsuario.Xalign = 0F;
			this.labUsuario.LabelProp = global::Mono.Unix.Catalog.GetString ("labUsuario");
			this.hbox6.Add (this.labUsuario);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.labUsuario]));
			w8.Position = 1;
			w8.Expand = false;
			this.vbox3.Add (this.hbox6);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox6]));
			w9.Position = 3;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox7 = new global::Gtk.HBox ();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.labTipoU = new global::Gtk.Label ();
			this.labTipoU.Name = "labTipoU";
			this.labTipoU.Xalign = 0F;
			this.labTipoU.LabelProp = global::Mono.Unix.Catalog.GetString ("Tipo de usuario: ");
			this.hbox7.Add (this.labTipoU);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.labTipoU]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Padding = ((uint)(50));
			// Container child hbox7.Gtk.Box+BoxChild
			this.labTipoUsuarioIndicador = new global::Gtk.Label ();
			this.labTipoUsuarioIndicador.WidthRequest = 250;
			this.labTipoUsuarioIndicador.Name = "labTipoUsuarioIndicador";
			this.labTipoUsuarioIndicador.Xalign = 0F;
			this.labTipoUsuarioIndicador.LabelProp = global::Mono.Unix.Catalog.GetString ("labTipoUsuarioIndicador");
			this.hbox7.Add (this.labTipoUsuarioIndicador);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.labTipoUsuarioIndicador]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Padding = ((uint)(31));
			this.vbox3.Add (this.hbox7);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox7]));
			w12.Position = 4;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox8 = new global::Gtk.HBox ();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.labPermisos = new global::Gtk.Label ();
			this.labPermisos.Name = "labPermisos";
			this.labPermisos.Xalign = 0F;
			this.labPermisos.LabelProp = global::Mono.Unix.Catalog.GetString ("Permisos: ");
			this.hbox8.Add (this.labPermisos);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.labPermisos]));
			w13.Position = 0;
			w13.Expand = false;
			w13.Padding = ((uint)(50));
			// Container child hbox8.Gtk.Box+BoxChild
			this.labPermisosIndicador = new global::Gtk.Label ();
			this.labPermisosIndicador.WidthRequest = 250;
			this.labPermisosIndicador.Name = "labPermisosIndicador";
			this.labPermisosIndicador.Xalign = 0F;
			this.labPermisosIndicador.LabelProp = global::Mono.Unix.Catalog.GetString ("labPermisosIndicador");
			this.hbox8.Add (this.labPermisosIndicador);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.labPermisosIndicador]));
			w14.Position = 1;
			w14.Expand = false;
			w14.Padding = ((uint)(73));
			this.vbox3.Add (this.hbox8);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox8]));
			w15.Position = 5;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.butCerrar = new global::Gtk.Button ();
			this.butCerrar.HeightRequest = 50;
			this.butCerrar.CanFocus = true;
			this.butCerrar.Name = "butCerrar";
			this.butCerrar.UseUnderline = true;
			this.butCerrar.Label = global::Mono.Unix.Catalog.GetString ("Cerrar");
			this.vbox3.Add (this.butCerrar);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.butCerrar]));
			w16.Position = 6;
			w16.Expand = false;
			w16.Fill = false;
			this.GtkAligInterior.Add (this.vbox3);
			this.frameInfo.Add (this.GtkAligInterior);
			this.GtkLabInformación = new global::Gtk.Label ();
			this.GtkLabInformación.Name = "GtkLabInformación";
			this.GtkLabInformación.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Información</b>");
			this.GtkLabInformación.UseMarkup = true;
			this.frameInfo.LabelWidget = this.GtkLabInformación;
			this.Add (this.frameInfo);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 648;
			this.DefaultHeight = 613;
			this.Show ();
			this.butCerrar.Clicked += new global::System.EventHandler (this.OnButCerrarClicked);
		}
	}
}
