
namespace Proyecto_v2
{
    partial class FPrincipal
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
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.msiProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.miAgregarProveedor = new System.Windows.Forms.ToolStripMenuItem();
            this.miModificarProveedor = new System.Windows.Forms.ToolStripMenuItem();
            this.miEliminarProveedor = new System.Windows.Forms.ToolStripMenuItem();
            this.msiProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.miAgregarProd = new System.Windows.Forms.ToolStripMenuItem();
            this.miModificarProd = new System.Windows.Forms.ToolStripMenuItem();
            this.miEliminarProd = new System.Windows.Forms.ToolStripMenuItem();
            this.msiAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.msiSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.pProductos = new System.Windows.Forms.Panel();
            this.rbTodosProd = new System.Windows.Forms.RadioButton();
            this.rbInstrumentos = new System.Windows.Forms.RadioButton();
            this.rbAccesorios = new System.Windows.Forms.RadioButton();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbProveedores = new System.Windows.Forms.ComboBox();
            this.bgFechas = new System.Windows.Forms.GroupBox();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFin = new System.Windows.Forms.DateTimePicker();
            this.lInicio = new System.Windows.Forms.Label();
            this.lFin = new System.Windows.Forms.Label();
            this.lCantProdLista = new System.Windows.Forms.Label();
            this.lTotalProductos = new System.Windows.Forms.Label();
            this.lbProductos = new System.Windows.Forms.ListBox();
            this.pProveedores = new System.Windows.Forms.Panel();
            this.lCantProvLista = new System.Windows.Forms.Label();
            this.lTotalProveedores = new System.Windows.Forms.Label();
            this.rbTodosProv = new System.Windows.Forms.RadioButton();
            this.rbNacionales = new System.Windows.Forms.RadioButton();
            this.rbExtranjeros = new System.Windows.Forms.RadioButton();
            this.lbProveedores = new System.Windows.Forms.ListBox();
            this.msPrincipal.SuspendLayout();
            this.pProductos.SuspendLayout();
            this.gbFiltros.SuspendLayout();
            this.bgFechas.SuspendLayout();
            this.pProveedores.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPrincipal
            // 
            this.msPrincipal.BackColor = System.Drawing.SystemColors.MenuBar;
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiProveedores,
            this.msiProductos,
            this.msiAcercaDe,
            this.msiSalir});
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Size = new System.Drawing.Size(784, 24);
            this.msPrincipal.TabIndex = 0;
            // 
            // msiProveedores
            // 
            this.msiProveedores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAgregarProveedor,
            this.miModificarProveedor,
            this.miEliminarProveedor});
            this.msiProveedores.Name = "msiProveedores";
            this.msiProveedores.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
            this.msiProveedores.Size = new System.Drawing.Size(84, 20);
            this.msiProveedores.Text = "Pro&veedores";
            // 
            // miAgregarProveedor
            // 
            this.miAgregarProveedor.Name = "miAgregarProveedor";
            this.miAgregarProveedor.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D1)));
            this.miAgregarProveedor.Size = new System.Drawing.Size(161, 22);
            this.miAgregarProveedor.Text = "&Agregar";
            this.miAgregarProveedor.Click += new System.EventHandler(this.miAgregarProveedor_Click);
            // 
            // miModificarProveedor
            // 
            this.miModificarProveedor.Enabled = false;
            this.miModificarProveedor.Name = "miModificarProveedor";
            this.miModificarProveedor.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D2)));
            this.miModificarProveedor.Size = new System.Drawing.Size(161, 22);
            this.miModificarProveedor.Text = "&Modificar";
            this.miModificarProveedor.Click += new System.EventHandler(this.miModificarProveedor_Click);
            // 
            // miEliminarProveedor
            // 
            this.miEliminarProveedor.Enabled = false;
            this.miEliminarProveedor.Name = "miEliminarProveedor";
            this.miEliminarProveedor.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D3)));
            this.miEliminarProveedor.Size = new System.Drawing.Size(161, 22);
            this.miEliminarProveedor.Text = "&Eliminar";
            this.miEliminarProveedor.Click += new System.EventHandler(this.miEliminarProveedor_Click);
            // 
            // msiProductos
            // 
            this.msiProductos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAgregarProd,
            this.miModificarProd,
            this.miEliminarProd});
            this.msiProductos.Name = "msiProductos";
            this.msiProductos.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.msiProductos.Size = new System.Drawing.Size(73, 20);
            this.msiProductos.Text = "Pro&ductos";
            // 
            // miAgregarProd
            // 
            this.miAgregarProd.Enabled = false;
            this.miAgregarProd.Name = "miAgregarProd";
            this.miAgregarProd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D4)));
            this.miAgregarProd.Size = new System.Drawing.Size(161, 22);
            this.miAgregarProd.Text = "&Agregar";
            this.miAgregarProd.Click += new System.EventHandler(this.miAgregarProd_Click);
            // 
            // miModificarProd
            // 
            this.miModificarProd.Enabled = false;
            this.miModificarProd.Name = "miModificarProd";
            this.miModificarProd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D5)));
            this.miModificarProd.Size = new System.Drawing.Size(161, 22);
            this.miModificarProd.Text = "&Modificar";
            this.miModificarProd.Click += new System.EventHandler(this.miModificarProd_Click);
            // 
            // miEliminarProd
            // 
            this.miEliminarProd.Enabled = false;
            this.miEliminarProd.Name = "miEliminarProd";
            this.miEliminarProd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D6)));
            this.miEliminarProd.Size = new System.Drawing.Size(161, 22);
            this.miEliminarProd.Text = "&Eliminar";
            this.miEliminarProd.Click += new System.EventHandler(this.miEliminarProd_Click);
            // 
            // msiAcercaDe
            // 
            this.msiAcercaDe.Name = "msiAcercaDe";
            this.msiAcercaDe.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.msiAcercaDe.Size = new System.Drawing.Size(71, 20);
            this.msiAcercaDe.Text = "&Acerca de";
            this.msiAcercaDe.Click += new System.EventHandler(this.msiAcercaDe_Click);
            // 
            // msiSalir
            // 
            this.msiSalir.Name = "msiSalir";
            this.msiSalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.msiSalir.Size = new System.Drawing.Size(41, 20);
            this.msiSalir.Text = "&Salir";
            this.msiSalir.Click += new System.EventHandler(this.msiSalir_Click);
            // 
            // pProductos
            // 
            this.pProductos.BackColor = System.Drawing.SystemColors.Control;
            this.pProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pProductos.Controls.Add(this.rbTodosProd);
            this.pProductos.Controls.Add(this.rbInstrumentos);
            this.pProductos.Controls.Add(this.rbAccesorios);
            this.pProductos.Controls.Add(this.gbFiltros);
            this.pProductos.Controls.Add(this.bgFechas);
            this.pProductos.Controls.Add(this.lCantProdLista);
            this.pProductos.Controls.Add(this.lTotalProductos);
            this.pProductos.Controls.Add(this.lbProductos);
            this.pProductos.Location = new System.Drawing.Point(323, 27);
            this.pProductos.Name = "pProductos";
            this.pProductos.Size = new System.Drawing.Size(449, 422);
            this.pProductos.TabIndex = 1;
            // 
            // rbTodosProd
            // 
            this.rbTodosProd.AutoSize = true;
            this.rbTodosProd.Checked = true;
            this.rbTodosProd.Location = new System.Drawing.Point(30, 108);
            this.rbTodosProd.Name = "rbTodosProd";
            this.rbTodosProd.Size = new System.Drawing.Size(55, 17);
            this.rbTodosProd.TabIndex = 1;
            this.rbTodosProd.TabStop = true;
            this.rbTodosProd.Text = "Todos";
            this.rbTodosProd.UseVisualStyleBackColor = true;
            this.rbTodosProd.CheckedChanged += new System.EventHandler(this.ActualizarCategoriasProductos);
            // 
            // rbInstrumentos
            // 
            this.rbInstrumentos.AutoSize = true;
            this.rbInstrumentos.Location = new System.Drawing.Point(184, 108);
            this.rbInstrumentos.Name = "rbInstrumentos";
            this.rbInstrumentos.Size = new System.Drawing.Size(85, 17);
            this.rbInstrumentos.TabIndex = 2;
            this.rbInstrumentos.TabStop = true;
            this.rbInstrumentos.Text = "Instrumentos";
            this.rbInstrumentos.UseVisualStyleBackColor = true;
            this.rbInstrumentos.CheckedChanged += new System.EventHandler(this.ActualizarCategoriasProductos);
            // 
            // rbAccesorios
            // 
            this.rbAccesorios.AutoSize = true;
            this.rbAccesorios.Location = new System.Drawing.Point(356, 108);
            this.rbAccesorios.Name = "rbAccesorios";
            this.rbAccesorios.Size = new System.Drawing.Size(77, 17);
            this.rbAccesorios.TabIndex = 3;
            this.rbAccesorios.TabStop = true;
            this.rbAccesorios.Text = "Accesorios";
            this.rbAccesorios.UseVisualStyleBackColor = true;
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.label2);
            this.gbFiltros.Controls.Add(this.label1);
            this.gbFiltros.Controls.Add(this.cbCategoria);
            this.gbFiltros.Controls.Add(this.cbProveedores);
            this.gbFiltros.Location = new System.Drawing.Point(206, 12);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(227, 75);
            this.gbFiltros.TabIndex = 12;
            this.gbFiltros.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Categoria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Proveedor";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(96, 40);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(119, 21);
            this.cbCategoria.TabIndex = 4;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.ActualizarListadoProductos);
            // 
            // cbProveedores
            // 
            this.cbProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProveedores.FormattingEnabled = true;
            this.cbProveedores.Location = new System.Drawing.Point(96, 16);
            this.cbProveedores.Name = "cbProveedores";
            this.cbProveedores.Size = new System.Drawing.Size(119, 21);
            this.cbProveedores.TabIndex = 9;
            this.cbProveedores.SelectedIndexChanged += new System.EventHandler(this.ActualizarListadoProductos);
            // 
            // bgFechas
            // 
            this.bgFechas.Controls.Add(this.dtInicio);
            this.bgFechas.Controls.Add(this.dtFin);
            this.bgFechas.Controls.Add(this.lInicio);
            this.bgFechas.Controls.Add(this.lFin);
            this.bgFechas.Location = new System.Drawing.Point(17, 12);
            this.bgFechas.Name = "bgFechas";
            this.bgFechas.Size = new System.Drawing.Size(183, 75);
            this.bgFechas.TabIndex = 11;
            this.bgFechas.TabStop = false;
            // 
            // dtInicio
            // 
            this.dtInicio.CustomFormat = "dd/MM/yyy";
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInicio.Location = new System.Drawing.Point(81, 16);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(85, 20);
            this.dtInicio.TabIndex = 5;
            this.dtInicio.ValueChanged += new System.EventHandler(this.dtInicio_ValueChanged);
            // 
            // dtFin
            // 
            this.dtFin.CustomFormat = "dd/MM/yyyy";
            this.dtFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFin.Location = new System.Drawing.Point(83, 41);
            this.dtFin.Name = "dtFin";
            this.dtFin.Size = new System.Drawing.Size(85, 20);
            this.dtFin.TabIndex = 6;
            this.dtFin.ValueChanged += new System.EventHandler(this.ActualizarListadoProductos);
            // 
            // lInicio
            // 
            this.lInicio.AutoSize = true;
            this.lInicio.Location = new System.Drawing.Point(14, 19);
            this.lInicio.Name = "lInicio";
            this.lInicio.Size = new System.Drawing.Size(65, 13);
            this.lInicio.TabIndex = 7;
            this.lInicio.Text = "Fecha Inicio";
            // 
            // lFin
            // 
            this.lFin.AutoSize = true;
            this.lFin.Location = new System.Drawing.Point(16, 43);
            this.lFin.Name = "lFin";
            this.lFin.Size = new System.Drawing.Size(54, 13);
            this.lFin.TabIndex = 8;
            this.lFin.Text = "Fecha Fin";
            // 
            // lCantProdLista
            // 
            this.lCantProdLista.AutoSize = true;
            this.lCantProdLista.Location = new System.Drawing.Point(27, 377);
            this.lCantProdLista.Name = "lCantProdLista";
            this.lCantProdLista.Size = new System.Drawing.Size(173, 13);
            this.lCantProdLista.TabIndex = 10;
            this.lCantProdLista.Text = "Cantidad de productos en la lista: 0";
            // 
            // lTotalProductos
            // 
            this.lTotalProductos.AutoSize = true;
            this.lTotalProductos.Location = new System.Drawing.Point(28, 397);
            this.lTotalProductos.Name = "lTotalProductos";
            this.lTotalProductos.Size = new System.Drawing.Size(149, 13);
            this.lTotalProductos.TabIndex = 9;
            this.lTotalProductos.Text = "Cantidad total de productos: 0";
            // 
            // lbProductos
            // 
            this.lbProductos.FormattingEnabled = true;
            this.lbProductos.Location = new System.Drawing.Point(23, 131);
            this.lbProductos.Name = "lbProductos";
            this.lbProductos.Size = new System.Drawing.Size(410, 238);
            this.lbProductos.TabIndex = 0;
            // 
            // pProveedores
            // 
            this.pProveedores.BackColor = System.Drawing.SystemColors.Control;
            this.pProveedores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pProveedores.Controls.Add(this.lCantProvLista);
            this.pProveedores.Controls.Add(this.lTotalProveedores);
            this.pProveedores.Controls.Add(this.rbTodosProv);
            this.pProveedores.Controls.Add(this.rbNacionales);
            this.pProveedores.Controls.Add(this.rbExtranjeros);
            this.pProveedores.Controls.Add(this.lbProveedores);
            this.pProveedores.Location = new System.Drawing.Point(15, 27);
            this.pProveedores.Name = "pProveedores";
            this.pProveedores.Size = new System.Drawing.Size(295, 422);
            this.pProveedores.TabIndex = 2;
            // 
            // lCantProvLista
            // 
            this.lCantProvLista.AutoSize = true;
            this.lCantProvLista.Location = new System.Drawing.Point(18, 376);
            this.lCantProvLista.Name = "lCantProvLista";
            this.lCantProvLista.Size = new System.Drawing.Size(185, 13);
            this.lCantProvLista.TabIndex = 8;
            this.lCantProvLista.Text = "Cantidad de proveedores en la lista: 0";
            // 
            // lTotalProveedores
            // 
            this.lTotalProveedores.AutoSize = true;
            this.lTotalProveedores.Location = new System.Drawing.Point(19, 396);
            this.lTotalProveedores.Name = "lTotalProveedores";
            this.lTotalProveedores.Size = new System.Drawing.Size(161, 13);
            this.lTotalProveedores.TabIndex = 7;
            this.lTotalProveedores.Text = "Cantidad total de proveedores: 0";
            // 
            // rbTodosProv
            // 
            this.rbTodosProv.AutoSize = true;
            this.rbTodosProv.Checked = true;
            this.rbTodosProv.Location = new System.Drawing.Point(24, 12);
            this.rbTodosProv.Name = "rbTodosProv";
            this.rbTodosProv.Size = new System.Drawing.Size(55, 17);
            this.rbTodosProv.TabIndex = 4;
            this.rbTodosProv.TabStop = true;
            this.rbTodosProv.Text = "Todos";
            this.rbTodosProv.UseVisualStyleBackColor = true;
            this.rbTodosProv.CheckedChanged += new System.EventHandler(this.rbTodosProv_CheckedChanged);
            // 
            // rbNacionales
            // 
            this.rbNacionales.AutoSize = true;
            this.rbNacionales.Location = new System.Drawing.Point(93, 12);
            this.rbNacionales.Name = "rbNacionales";
            this.rbNacionales.Size = new System.Drawing.Size(78, 17);
            this.rbNacionales.TabIndex = 5;
            this.rbNacionales.TabStop = true;
            this.rbNacionales.Text = "Nacionales";
            this.rbNacionales.UseVisualStyleBackColor = true;
            // 
            // rbExtranjeros
            // 
            this.rbExtranjeros.AutoSize = true;
            this.rbExtranjeros.Location = new System.Drawing.Point(183, 12);
            this.rbExtranjeros.Name = "rbExtranjeros";
            this.rbExtranjeros.Size = new System.Drawing.Size(77, 17);
            this.rbExtranjeros.TabIndex = 6;
            this.rbExtranjeros.TabStop = true;
            this.rbExtranjeros.Text = "Extranjeros";
            this.rbExtranjeros.UseVisualStyleBackColor = true;
            this.rbExtranjeros.CheckedChanged += new System.EventHandler(this.rbExtranjeros_CheckedChanged);
            // 
            // lbProveedores
            // 
            this.lbProveedores.FormattingEnabled = true;
            this.lbProveedores.Location = new System.Drawing.Point(22, 40);
            this.lbProveedores.Name = "lbProveedores";
            this.lbProveedores.Size = new System.Drawing.Size(244, 329);
            this.lbProveedores.TabIndex = 1;
            this.lbProveedores.SelectedIndexChanged += new System.EventHandler(this.lbProveedores_SelectedIndexChanged);
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.pProductos);
            this.Controls.Add(this.pProveedores);
            this.Controls.Add(this.msPrincipal);
            this.KeyPreview = true;
            this.MainMenuStrip = this.msPrincipal;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instrumentos Musicales";
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.pProductos.ResumeLayout(false);
            this.pProductos.PerformLayout();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.bgFechas.ResumeLayout(false);
            this.bgFechas.PerformLayout();
            this.pProveedores.ResumeLayout(false);
            this.pProveedores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem msiProveedores;
        private System.Windows.Forms.ToolStripMenuItem miAgregarProveedor;
        private System.Windows.Forms.ToolStripMenuItem msiProductos;
        private System.Windows.Forms.ToolStripMenuItem msiAcercaDe;
        private System.Windows.Forms.ToolStripMenuItem msiSalir;
        private System.Windows.Forms.ToolStripMenuItem miModificarProveedor;
        private System.Windows.Forms.ToolStripMenuItem miEliminarProveedor;
        private System.Windows.Forms.Panel pProductos;
        private System.Windows.Forms.Label lFin;
        private System.Windows.Forms.Label lInicio;
        private System.Windows.Forms.DateTimePicker dtFin;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.RadioButton rbAccesorios;
        private System.Windows.Forms.RadioButton rbInstrumentos;
        private System.Windows.Forms.RadioButton rbTodosProd;
        private System.Windows.Forms.ListBox lbProductos;
        private System.Windows.Forms.Panel pProveedores;
        private System.Windows.Forms.RadioButton rbTodosProv;
        private System.Windows.Forms.RadioButton rbNacionales;
        private System.Windows.Forms.RadioButton rbExtranjeros;
        private System.Windows.Forms.ListBox lbProveedores;
        private System.Windows.Forms.ComboBox cbProveedores;
        private System.Windows.Forms.Label lCantProvLista;
        private System.Windows.Forms.Label lTotalProveedores;
        private System.Windows.Forms.Label lCantProdLista;
        private System.Windows.Forms.Label lTotalProductos;
        private System.Windows.Forms.ToolStripMenuItem miAgregarProd;
        private System.Windows.Forms.ToolStripMenuItem miModificarProd;
        private System.Windows.Forms.ToolStripMenuItem miEliminarProd;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.GroupBox bgFechas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

