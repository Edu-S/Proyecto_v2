
namespace Proyecto_v2
{
    partial class FProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.mtCodigo = new System.Windows.Forms.MaskedTextBox();
            this.lNombre = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtPrecio = new System.Windows.Forms.MaskedTextBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbTipo = new System.Windows.Forms.GroupBox();
            this.rbAccesorio = new System.Windows.Forms.RadioButton();
            this.rbInstrumento = new System.Windows.Forms.RadioButton();
            this.epCodigo = new System.Windows.Forms.ErrorProvider(this.components);
            this.epNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPrecio = new System.Windows.Forms.ErrorProvider(this.components);
            this.epProveedor = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // bCancelar
            // 
            this.bCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancelar.Location = new System.Drawing.Point(132, 242);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(106, 23);
            this.bCancelar.TabIndex = 8;
            this.bCancelar.Text = "&Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(10, 242);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(103, 23);
            this.bAceptar.TabIndex = 7;
            this.bAceptar.Text = "&Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(125, 91);
            this.tNombre.MaxLength = 25;
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(111, 20);
            this.tNombre.TabIndex = 2;
            this.tNombre.Validating += new System.ComponentModel.CancelEventHandler(this.tNombre_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fecha:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(23, 68);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 7;
            this.lblCodigo.Text = "Código:";
            // 
            // mtCodigo
            // 
            this.mtCodigo.Location = new System.Drawing.Point(125, 65);
            this.mtCodigo.Mask = "0000";
            this.mtCodigo.Name = "mtCodigo";
            this.mtCodigo.Size = new System.Drawing.Size(43, 20);
            this.mtCodigo.TabIndex = 0;
            this.mtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtCodigo.ValidatingType = typeof(int);
            this.mtCodigo.Leave += new System.EventHandler(this.mtCodigo_Leave);
            this.mtCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.mtCodigo_Validating);
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(23, 94);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(47, 13);
            this.lNombre.TabIndex = 15;
            this.lNombre.Text = "Nombre:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(125, 117);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(111, 21);
            this.cbCategoria.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Categoria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Precio:";
            // 
            // mtPrecio
            // 
            this.mtPrecio.Location = new System.Drawing.Point(125, 146);
            this.mtPrecio.Mask = "99999.99";
            this.mtPrecio.Name = "mtPrecio";
            this.mtPrecio.Size = new System.Drawing.Size(62, 20);
            this.mtPrecio.TabIndex = 4;
            this.mtPrecio.ValidatingType = typeof(int);
            this.mtPrecio.Validating += new System.ComponentModel.CancelEventHandler(this.mtPrecio_Validating);
            // 
            // dtFecha
            // 
            this.dtFecha.CustomFormat = "dd/MM/yyyy";
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFecha.Location = new System.Drawing.Point(125, 175);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(111, 20);
            this.dtFecha.TabIndex = 5;
            // 
            // cbProveedor
            // 
            this.cbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(125, 201);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(111, 21);
            this.cbProveedor.TabIndex = 6;
            this.cbProveedor.Validating += new System.ComponentModel.CancelEventHandler(this.cbProveedor_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Proveedor:";
            // 
            // gbTipo
            // 
            this.gbTipo.Controls.Add(this.rbAccesorio);
            this.gbTipo.Controls.Add(this.rbInstrumento);
            this.gbTipo.Location = new System.Drawing.Point(10, 11);
            this.gbTipo.Name = "gbTipo";
            this.gbTipo.Size = new System.Drawing.Size(231, 48);
            this.gbTipo.TabIndex = 23;
            this.gbTipo.TabStop = false;
            // 
            // rbAccesorio
            // 
            this.rbAccesorio.AutoSize = true;
            this.rbAccesorio.Location = new System.Drawing.Point(139, 20);
            this.rbAccesorio.Name = "rbAccesorio";
            this.rbAccesorio.Size = new System.Drawing.Size(72, 17);
            this.rbAccesorio.TabIndex = 1;
            this.rbAccesorio.Text = "Accesorio";
            this.rbAccesorio.UseVisualStyleBackColor = true;
            // 
            // rbInstrumento
            // 
            this.rbInstrumento.AutoSize = true;
            this.rbInstrumento.Location = new System.Drawing.Point(15, 19);
            this.rbInstrumento.Name = "rbInstrumento";
            this.rbInstrumento.Size = new System.Drawing.Size(80, 17);
            this.rbInstrumento.TabIndex = 0;
            this.rbInstrumento.Text = "Instrumento";
            this.rbInstrumento.UseVisualStyleBackColor = true;
            this.rbInstrumento.CheckedChanged += new System.EventHandler(this.rbInstrumento_CheckedChanged);
            // 
            // epCodigo
            // 
            this.epCodigo.ContainerControl = this;
            // 
            // epNombre
            // 
            this.epNombre.ContainerControl = this;
            // 
            // epPrecio
            // 
            this.epPrecio.ContainerControl = this;
            // 
            // epProveedor
            // 
            this.epProveedor.ContainerControl = this;
            // 
            // FProducto
            // 
            this.AcceptButton = this.bAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCancelar;
            this.ClientSize = new System.Drawing.Size(264, 282);
            this.Controls.Add(this.gbTipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.mtCodigo);
            this.Controls.Add(this.cbProveedor);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.mtPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(280, 320);
            this.MinimumSize = new System.Drawing.Size(280, 320);
            this.Name = "FProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar..";
            this.Load += new System.EventHandler(this.FProducto_Load);
            this.gbTipo.ResumeLayout(false);
            this.gbTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.MaskedTextBox mtCodigo;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtPrecio;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbTipo;
        private System.Windows.Forms.RadioButton rbAccesorio;
        private System.Windows.Forms.RadioButton rbInstrumento;
        private System.Windows.Forms.ErrorProvider epCodigo;
        private System.Windows.Forms.ErrorProvider epNombre;
        private System.Windows.Forms.ErrorProvider epPrecio;
        private System.Windows.Forms.ErrorProvider epProveedor;
    }
}