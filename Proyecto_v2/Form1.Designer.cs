
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
            this.msiAgregarProd = new System.Windows.Forms.ToolStripMenuItem();
            this.msiModificarProd = new System.Windows.Forms.ToolStripMenuItem();
            this.msiEliminarProd = new System.Windows.Forms.ToolStripMenuItem();
            this.msiAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.msiSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.pProductos = new System.Windows.Forms.Panel();
            this.lCantProdLista = new System.Windows.Forms.Label();
            this.cbProveedores = new System.Windows.Forms.ComboBox();
            this.lTotalProductos = new System.Windows.Forms.Label();
            this.lFin = new System.Windows.Forms.Label();
            this.lInicio = new System.Windows.Forms.Label();
            this.dtFin = new System.Windows.Forms.DateTimePicker();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.rbAccesorios = new System.Windows.Forms.RadioButton();
            this.rbInstrumentos = new System.Windows.Forms.RadioButton();
            this.rbTodosProd = new System.Windows.Forms.RadioButton();
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
            this.pProveedores.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPrincipal
            // 
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiProveedores,
            this.msiProductos,
            this.msiAcercaDe,
            this.msiSalir});
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Size = new System.Drawing.Size(805, 24);
            this.msPrincipal.TabIndex = 0;
            this.msPrincipal.Text = "menuStrip1";
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
            this.msiProveedores.Text = "Proveedores";
            // 
            // miAgregarProveedor
            // 
            this.miAgregarProveedor.Name = "miAgregarProveedor";
            this.miAgregarProveedor.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.miAgregarProveedor.Size = new System.Drawing.Size(180, 22);
            this.miAgregarProveedor.Text = "Agregar";
            this.miAgregarProveedor.Click += new System.EventHandler(this.miAgregarProveedor_Click);
            // 
            // miModificarProveedor
            // 
            this.miModificarProveedor.Name = "miModificarProveedor";
            this.miModificarProveedor.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.miModificarProveedor.Size = new System.Drawing.Size(180, 22);
            this.miModificarProveedor.Text = "Modificar";
            this.miModificarProveedor.Click += new System.EventHandler(this.miModificarProveedor_Click);
            // 
            // miEliminarProveedor
            // 
            this.miEliminarProveedor.Name = "miEliminarProveedor";
            this.miEliminarProveedor.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.miEliminarProveedor.Size = new System.Drawing.Size(180, 22);
            this.miEliminarProveedor.Text = "Eliminar";
            this.miEliminarProveedor.Click += new System.EventHandler(this.miEliminarProveedor_Click);
            // 
            // msiProductos
            // 
            this.msiProductos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiAgregarProd,
            this.msiModificarProd,
            this.msiEliminarProd});
            this.msiProductos.Name = "msiProductos";
            this.msiProductos.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.msiProductos.Size = new System.Drawing.Size(73, 20);
            this.msiProductos.Text = "Productos";
            // 
            // msiAgregarProd
            // 
            this.msiAgregarProd.Name = "msiAgregarProd";
            this.msiAgregarProd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.msiAgregarProd.Size = new System.Drawing.Size(180, 22);
            this.msiAgregarProd.Text = "Agregar";
            // 
            // msiModificarProd
            // 
            this.msiModificarProd.Name = "msiModificarProd";
            this.msiModificarProd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.msiModificarProd.Size = new System.Drawing.Size(180, 22);
            this.msiModificarProd.Text = "Modificar";
            // 
            // msiEliminarProd
            // 
            this.msiEliminarProd.Name = "msiEliminarProd";
            this.msiEliminarProd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.msiEliminarProd.Size = new System.Drawing.Size(180, 22);
            this.msiEliminarProd.Text = "Eliminar";
            // 
            // msiAcercaDe
            // 
            this.msiAcercaDe.Name = "msiAcercaDe";
            this.msiAcercaDe.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.msiAcercaDe.Size = new System.Drawing.Size(72, 20);
            this.msiAcercaDe.Text = "Acerca De";
            this.msiAcercaDe.Click += new System.EventHandler(this.msiAcercaDe_Click);
            // 
            // msiSalir
            // 
            this.msiSalir.Name = "msiSalir";
            this.msiSalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.msiSalir.Size = new System.Drawing.Size(41, 20);
            this.msiSalir.Text = "Salir";
            this.msiSalir.Click += new System.EventHandler(this.msiSalir_Click);
            // 
            // pProductos
            // 
            this.pProductos.Controls.Add(this.lCantProdLista);
            this.pProductos.Controls.Add(this.cbProveedores);
            this.pProductos.Controls.Add(this.lTotalProductos);
            this.pProductos.Controls.Add(this.lFin);
            this.pProductos.Controls.Add(this.lInicio);
            this.pProductos.Controls.Add(this.dtFin);
            this.pProductos.Controls.Add(this.dtInicio);
            this.pProductos.Controls.Add(this.cbCategoria);
            this.pProductos.Controls.Add(this.rbAccesorios);
            this.pProductos.Controls.Add(this.rbInstrumentos);
            this.pProductos.Controls.Add(this.rbTodosProd);
            this.pProductos.Controls.Add(this.lbProductos);
            this.pProductos.Location = new System.Drawing.Point(431, 58);
            this.pProductos.Name = "pProductos";
            this.pProductos.Size = new System.Drawing.Size(344, 422);
            this.pProductos.TabIndex = 1;
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
            // cbProveedores
            // 
            this.cbProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProveedores.FormattingEnabled = true;
            this.cbProveedores.Items.AddRange(new object[] {
            "Todos"});
            this.cbProveedores.Location = new System.Drawing.Point(223, 31);
            this.cbProveedores.Name = "cbProveedores";
            this.cbProveedores.Size = new System.Drawing.Size(97, 21);
            this.cbProveedores.TabIndex = 9;
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
            // lFin
            // 
            this.lFin.AutoSize = true;
            this.lFin.Location = new System.Drawing.Point(34, 76);
            this.lFin.Name = "lFin";
            this.lFin.Size = new System.Drawing.Size(54, 13);
            this.lFin.TabIndex = 8;
            this.lFin.Text = "Fecha Fin";
            // 
            // lInicio
            // 
            this.lInicio.AutoSize = true;
            this.lInicio.Location = new System.Drawing.Point(34, 38);
            this.lInicio.Name = "lInicio";
            this.lInicio.Size = new System.Drawing.Size(65, 13);
            this.lInicio.TabIndex = 7;
            this.lInicio.Text = "Fecha Inicio";
            // 
            // dtFin
            // 
            this.dtFin.CustomFormat = "dd/MM/yyyy";
            this.dtFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFin.Location = new System.Drawing.Point(129, 70);
            this.dtFin.Name = "dtFin";
            this.dtFin.Size = new System.Drawing.Size(85, 20);
            this.dtFin.TabIndex = 6;
            this.dtFin.ValueChanged += new System.EventHandler(this.dtFin_ValueChanged);
            // 
            // dtInicio
            // 
            this.dtInicio.CustomFormat = "dd/MM/yyy";
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInicio.Location = new System.Drawing.Point(129, 32);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(85, 20);
            this.dtInicio.TabIndex = 5;
            this.dtInicio.ValueChanged += new System.EventHandler(this.dtInicio_ValueChanged);
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(223, 68);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(97, 21);
            this.cbCategoria.TabIndex = 4;
            // 
            // rbAccesorios
            // 
            this.rbAccesorios.AutoSize = true;
            this.rbAccesorios.Location = new System.Drawing.Point(243, 121);
            this.rbAccesorios.Name = "rbAccesorios";
            this.rbAccesorios.Size = new System.Drawing.Size(77, 17);
            this.rbAccesorios.TabIndex = 3;
            this.rbAccesorios.TabStop = true;
            this.rbAccesorios.Text = "Accesorios";
            this.rbAccesorios.UseVisualStyleBackColor = true;
            // 
            // rbInstrumentos
            // 
            this.rbInstrumentos.AutoSize = true;
            this.rbInstrumentos.Location = new System.Drawing.Point(129, 121);
            this.rbInstrumentos.Name = "rbInstrumentos";
            this.rbInstrumentos.Size = new System.Drawing.Size(85, 17);
            this.rbInstrumentos.TabIndex = 2;
            this.rbInstrumentos.TabStop = true;
            this.rbInstrumentos.Text = "Instrumentos";
            this.rbInstrumentos.UseVisualStyleBackColor = true;
            // 
            // rbTodosProd
            // 
            this.rbTodosProd.AutoSize = true;
            this.rbTodosProd.Checked = true;
            this.rbTodosProd.Location = new System.Drawing.Point(23, 121);
            this.rbTodosProd.Name = "rbTodosProd";
            this.rbTodosProd.Size = new System.Drawing.Size(55, 17);
            this.rbTodosProd.TabIndex = 1;
            this.rbTodosProd.TabStop = true;
            this.rbTodosProd.Text = "Todos";
            this.rbTodosProd.UseVisualStyleBackColor = true;
            // 
            // lbProductos
            // 
            this.lbProductos.FormattingEnabled = true;
            this.lbProductos.Location = new System.Drawing.Point(23, 144);
            this.lbProductos.Name = "lbProductos";
            this.lbProductos.Size = new System.Drawing.Size(297, 225);
            this.lbProductos.TabIndex = 0;
            // 
            // pProveedores
            // 
            this.pProveedores.Controls.Add(this.lCantProvLista);
            this.pProveedores.Controls.Add(this.lTotalProveedores);
            this.pProveedores.Controls.Add(this.rbTodosProv);
            this.pProveedores.Controls.Add(this.rbNacionales);
            this.pProveedores.Controls.Add(this.rbExtranjeros);
            this.pProveedores.Controls.Add(this.lbProveedores);
            this.pProveedores.Location = new System.Drawing.Point(28, 58);
            this.pProveedores.Name = "pProveedores";
            this.pProveedores.Size = new System.Drawing.Size(350, 422);
            this.pProveedores.TabIndex = 2;
            // 
            // lCantProvLista
            // 
            this.lCantProvLista.AutoSize = true;
            this.lCantProvLista.Location = new System.Drawing.Point(24, 378);
            this.lCantProvLista.Name = "lCantProvLista";
            this.lCantProvLista.Size = new System.Drawing.Size(185, 13);
            this.lCantProvLista.TabIndex = 8;
            this.lCantProvLista.Text = "Cantidad de proveedores en la lista: 0";
            // 
            // lTotalProveedores
            // 
            this.lTotalProveedores.AutoSize = true;
            this.lTotalProveedores.Location = new System.Drawing.Point(25, 398);
            this.lTotalProveedores.Name = "lTotalProveedores";
            this.lTotalProveedores.Size = new System.Drawing.Size(161, 13);
            this.lTotalProveedores.TabIndex = 7;
            this.lTotalProveedores.Text = "Cantidad total de proveedores: 0";
            // 
            // rbTodosProv
            // 
            this.rbTodosProv.AutoSize = true;
            this.rbTodosProv.Checked = true;
            this.rbTodosProv.Location = new System.Drawing.Point(27, 82);
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
            this.rbNacionales.Location = new System.Drawing.Point(135, 82);
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
            this.rbExtranjeros.Location = new System.Drawing.Point(239, 82);
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
            this.lbProveedores.Location = new System.Drawing.Point(27, 105);
            this.lbProveedores.Name = "lbProveedores";
            this.lbProveedores.Size = new System.Drawing.Size(297, 264);
            this.lbProveedores.TabIndex = 1;
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 533);
            this.Controls.Add(this.pProductos);
            this.Controls.Add(this.pProveedores);
            this.Controls.Add(this.msPrincipal);
            this.MainMenuStrip = this.msPrincipal;
            this.Name = "FPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instrumentos Musicales";
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.pProductos.ResumeLayout(false);
            this.pProductos.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem msiAgregarProd;
        private System.Windows.Forms.ToolStripMenuItem msiModificarProd;
        private System.Windows.Forms.ToolStripMenuItem msiEliminarProd;
    }
}

