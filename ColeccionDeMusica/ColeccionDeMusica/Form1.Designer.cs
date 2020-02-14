namespace ColeccionDeMusica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_agregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtb_album = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtb_artista = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtb_rating = new System.Windows.Forms.TextBox();
            this.btn_reproducir = new System.Windows.Forms.Button();
            this.lb_album = new System.Windows.Forms.Label();
            this.lb_artista = new System.Windows.Forms.Label();
            this.lb_rating = new System.Windows.Forms.Label();
            this.ptb_artista = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaCarpetaDePlaylistsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.sesiónPrivadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modoSinSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.ceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deshacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rehacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.cortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.seleccionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.preferenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alejarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reestablecerZoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reproducciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.siguienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anteriorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avanzarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retrocederToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
            this.aleatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repetirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripSeparator();
            this.subirVolumenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajarVolumenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lst_reproducción = new System.Windows.Forms.ListBox();
            this.txt_ruta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_artista)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(12, 182);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 1;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Album";
            // 
            // txtb_album
            // 
            this.txtb_album.BackColor = System.Drawing.SystemColors.Window;
            this.txtb_album.Location = new System.Drawing.Point(53, 63);
            this.txtb_album.Name = "txtb_album";
            this.txtb_album.Size = new System.Drawing.Size(100, 20);
            this.txtb_album.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Artista";
            // 
            // txtb_artista
            // 
            this.txtb_artista.Location = new System.Drawing.Point(53, 89);
            this.txtb_artista.Name = "txtb_artista";
            this.txtb_artista.Size = new System.Drawing.Size(100, 20);
            this.txtb_artista.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rating";
            // 
            // txtb_rating
            // 
            this.txtb_rating.Location = new System.Drawing.Point(53, 115);
            this.txtb_rating.Name = "txtb_rating";
            this.txtb_rating.Size = new System.Drawing.Size(100, 20);
            this.txtb_rating.TabIndex = 3;
            // 
            // btn_reproducir
            // 
            this.btn_reproducir.Location = new System.Drawing.Point(125, 182);
            this.btn_reproducir.Name = "btn_reproducir";
            this.btn_reproducir.Size = new System.Drawing.Size(75, 23);
            this.btn_reproducir.TabIndex = 1;
            this.btn_reproducir.Text = "Reproducir";
            this.btn_reproducir.UseVisualStyleBackColor = true;
            this.btn_reproducir.Click += new System.EventHandler(this.btn_reproducir_Click);
            this.btn_reproducir.MouseHover += new System.EventHandler(this.btn_reproducir_MouseHover);
            // 
            // lb_album
            // 
            this.lb_album.AutoSize = true;
            this.lb_album.Location = new System.Drawing.Point(293, 317);
            this.lb_album.Name = "lb_album";
            this.lb_album.Size = new System.Drawing.Size(36, 13);
            this.lb_album.TabIndex = 4;
            this.lb_album.Text = "Album";
            // 
            // lb_artista
            // 
            this.lb_artista.AutoSize = true;
            this.lb_artista.Location = new System.Drawing.Point(441, 317);
            this.lb_artista.Name = "lb_artista";
            this.lb_artista.Size = new System.Drawing.Size(36, 13);
            this.lb_artista.TabIndex = 4;
            this.lb_artista.Text = "Artista";
            // 
            // lb_rating
            // 
            this.lb_rating.AutoSize = true;
            this.lb_rating.Location = new System.Drawing.Point(552, 317);
            this.lb_rating.Name = "lb_rating";
            this.lb_rating.Size = new System.Drawing.Size(38, 13);
            this.lb_rating.TabIndex = 4;
            this.lb_rating.Text = "Rating";
            // 
            // ptb_artista
            // 
            this.ptb_artista.Image = global::ColeccionDeMusica.Properties.Resources.open_graph_facebook;
            this.ptb_artista.Location = new System.Drawing.Point(373, 43);
            this.ptb_artista.Name = "ptb_artista";
            this.ptb_artista.Size = new System.Drawing.Size(442, 241);
            this.ptb_artista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_artista.TabIndex = 0;
            this.ptb_artista.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.verToolStripMenuItem,
            this.reproducciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(902, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaListaToolStripMenuItem,
            this.nuevaCarpetaDePlaylistsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.importarToolStripMenuItem,
            this.toolStripMenuItem2,
            this.sesiónPrivadaToolStripMenuItem,
            this.modoSinSesiónToolStripMenuItem,
            this.toolStripMenuItem3,
            this.ceToolStripMenuItem,
            this.toolStripMenuItem4,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // nuevaListaToolStripMenuItem
            // 
            this.nuevaListaToolStripMenuItem.Name = "nuevaListaToolStripMenuItem";
            this.nuevaListaToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.nuevaListaToolStripMenuItem.Text = "Nueva Lista";
            // 
            // nuevaCarpetaDePlaylistsToolStripMenuItem
            // 
            this.nuevaCarpetaDePlaylistsToolStripMenuItem.Name = "nuevaCarpetaDePlaylistsToolStripMenuItem";
            this.nuevaCarpetaDePlaylistsToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.nuevaCarpetaDePlaylistsToolStripMenuItem.Text = "Nueva Carpeta de Playlists";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(210, 6);
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.importarToolStripMenuItem.Text = "Importar playlist";
            this.importarToolStripMenuItem.Click += new System.EventHandler(this.importarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(210, 6);
            // 
            // sesiónPrivadaToolStripMenuItem
            // 
            this.sesiónPrivadaToolStripMenuItem.Name = "sesiónPrivadaToolStripMenuItem";
            this.sesiónPrivadaToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.sesiónPrivadaToolStripMenuItem.Text = "Sesión privada";
            // 
            // modoSinSesiónToolStripMenuItem
            // 
            this.modoSinSesiónToolStripMenuItem.Name = "modoSinSesiónToolStripMenuItem";
            this.modoSinSesiónToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.modoSinSesiónToolStripMenuItem.Text = "Modo sin conexión";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(210, 6);
            // 
            // ceToolStripMenuItem
            // 
            this.ceToolStripMenuItem.Name = "ceToolStripMenuItem";
            this.ceToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.ceToolStripMenuItem.Text = "Cerrar sesión";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(210, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deshacerToolStripMenuItem,
            this.rehacerToolStripMenuItem,
            this.toolStripMenuItem5,
            this.cortarToolStripMenuItem,
            this.copiarToolStripMenuItem,
            this.pegarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.toolStripMenuItem6,
            this.seleccionarToolStripMenuItem,
            this.toolStripMenuItem7,
            this.buscarToolStripMenuItem,
            this.filtrarToolStripMenuItem,
            this.toolStripMenuItem8,
            this.preferenciasToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "&Editar";
            // 
            // deshacerToolStripMenuItem
            // 
            this.deshacerToolStripMenuItem.Name = "deshacerToolStripMenuItem";
            this.deshacerToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.deshacerToolStripMenuItem.Text = "Deshacer";
            // 
            // rehacerToolStripMenuItem
            // 
            this.rehacerToolStripMenuItem.Name = "rehacerToolStripMenuItem";
            this.rehacerToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.rehacerToolStripMenuItem.Text = "Rehacer";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(158, 6);
            // 
            // cortarToolStripMenuItem
            // 
            this.cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
            this.cortarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cortarToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.cortarToolStripMenuItem.Text = "Cortar";
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            // 
            // pegarToolStripMenuItem
            // 
            this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            this.pegarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pegarToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.pegarToolStripMenuItem.Text = "Pegar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(158, 6);
            // 
            // seleccionarToolStripMenuItem
            // 
            this.seleccionarToolStripMenuItem.Name = "seleccionarToolStripMenuItem";
            this.seleccionarToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.seleccionarToolStripMenuItem.Text = "seleccionar todo";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(158, 6);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.buscarToolStripMenuItem.Text = "Buscar";
            // 
            // filtrarToolStripMenuItem
            // 
            this.filtrarToolStripMenuItem.Name = "filtrarToolStripMenuItem";
            this.filtrarToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.filtrarToolStripMenuItem.Text = "Filtrar";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(158, 6);
            // 
            // preferenciasToolStripMenuItem
            // 
            this.preferenciasToolStripMenuItem.Name = "preferenciasToolStripMenuItem";
            this.preferenciasToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.preferenciasToolStripMenuItem.Text = "Preferencias";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercarToolStripMenuItem,
            this.alejarToolStripMenuItem,
            this.reestablecerZoomToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "&Ver";
            // 
            // acercarToolStripMenuItem
            // 
            this.acercarToolStripMenuItem.Name = "acercarToolStripMenuItem";
            this.acercarToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.acercarToolStripMenuItem.Text = "Ace&rcar";
            // 
            // alejarToolStripMenuItem
            // 
            this.alejarToolStripMenuItem.Name = "alejarToolStripMenuItem";
            this.alejarToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.alejarToolStripMenuItem.Text = "Alejar";
            // 
            // reestablecerZoomToolStripMenuItem
            // 
            this.reestablecerZoomToolStripMenuItem.Name = "reestablecerZoomToolStripMenuItem";
            this.reestablecerZoomToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.reestablecerZoomToolStripMenuItem.Text = "Reestablecer zoom";
            // 
            // reproducciónToolStripMenuItem
            // 
            this.reproducciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem9,
            this.siguienteToolStripMenuItem,
            this.anteriorToolStripMenuItem,
            this.avanzarToolStripMenuItem,
            this.retrocederToolStripMenuItem,
            this.toolStripMenuItem10,
            this.aleatorioToolStripMenuItem,
            this.repetirToolStripMenuItem,
            this.toolStripMenuItem11,
            this.subirVolumenToolStripMenuItem,
            this.bajarVolumenToolStripMenuItem});
            this.reproducciónToolStripMenuItem.Name = "reproducciónToolStripMenuItem";
            this.reproducciónToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.reproducciónToolStripMenuItem.Text = "&Reproducción";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(148, 6);
            // 
            // siguienteToolStripMenuItem
            // 
            this.siguienteToolStripMenuItem.Name = "siguienteToolStripMenuItem";
            this.siguienteToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.siguienteToolStripMenuItem.Text = "s&iguiente";
            this.siguienteToolStripMenuItem.Click += new System.EventHandler(this.siguienteToolStripMenuItem_Click);
            // 
            // anteriorToolStripMenuItem
            // 
            this.anteriorToolStripMenuItem.Name = "anteriorToolStripMenuItem";
            this.anteriorToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.anteriorToolStripMenuItem.Text = "a&nterior";
            this.anteriorToolStripMenuItem.Click += new System.EventHandler(this.anteriorToolStripMenuItem_Click);
            // 
            // avanzarToolStripMenuItem
            // 
            this.avanzarToolStripMenuItem.Name = "avanzarToolStripMenuItem";
            this.avanzarToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.avanzarToolStripMenuItem.Text = "avanzar";
            // 
            // retrocederToolStripMenuItem
            // 
            this.retrocederToolStripMenuItem.Name = "retrocederToolStripMenuItem";
            this.retrocederToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.retrocederToolStripMenuItem.Text = "retroceder";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(148, 6);
            // 
            // aleatorioToolStripMenuItem
            // 
            this.aleatorioToolStripMenuItem.Name = "aleatorioToolStripMenuItem";
            this.aleatorioToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.aleatorioToolStripMenuItem.Text = "Aleatorio";
            // 
            // repetirToolStripMenuItem
            // 
            this.repetirToolStripMenuItem.Name = "repetirToolStripMenuItem";
            this.repetirToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.repetirToolStripMenuItem.Text = "Repetir";
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(148, 6);
            // 
            // subirVolumenToolStripMenuItem
            // 
            this.subirVolumenToolStripMenuItem.Name = "subirVolumenToolStripMenuItem";
            this.subirVolumenToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.subirVolumenToolStripMenuItem.Text = "Subir volumen";
            // 
            // bajarVolumenToolStripMenuItem
            // 
            this.bajarVolumenToolStripMenuItem.Name = "bajarVolumenToolStripMenuItem";
            this.bajarVolumenToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.bajarVolumenToolStripMenuItem.Text = "Bajar volumen";
            // 
            // lst_reproducción
            // 
            this.lst_reproducción.FormattingEnabled = true;
            this.lst_reproducción.Location = new System.Drawing.Point(225, 43);
            this.lst_reproducción.Name = "lst_reproducción";
            this.lst_reproducción.Size = new System.Drawing.Size(91, 238);
            this.lst_reproducción.TabIndex = 6;
            // 
            // txt_ruta
            // 
            this.txt_ruta.Location = new System.Drawing.Point(53, 141);
            this.txt_ruta.Name = "txt_ruta";
            this.txt_ruta.Size = new System.Drawing.Size(100, 20);
            this.txt_ruta.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ruta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 415);
            this.Controls.Add(this.lst_reproducción);
            this.Controls.Add(this.lb_rating);
            this.Controls.Add(this.lb_artista);
            this.Controls.Add(this.lb_album);
            this.Controls.Add(this.txt_ruta);
            this.Controls.Add(this.txtb_rating);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtb_artista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtb_album);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_reproducir);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.ptb_artista);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_artista)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_artista;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtb_album;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtb_artista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtb_rating;
        private System.Windows.Forms.Button btn_reproducir;
        private System.Windows.Forms.Label lb_album;
        private System.Windows.Forms.Label lb_artista;
        private System.Windows.Forms.Label lb_rating;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaListaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaCarpetaDePlaylistsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sesiónPrivadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modoSinSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem ceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deshacerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rehacerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem cortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem seleccionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem preferenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alejarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reestablecerZoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reproducciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem siguienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anteriorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avanzarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retrocederToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem aleatorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repetirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem subirVolumenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajarVolumenToolStripMenuItem;
        private System.Windows.Forms.ListBox lst_reproducción;
        private System.Windows.Forms.TextBox txt_ruta;
        private System.Windows.Forms.Label label4;
    }
}

