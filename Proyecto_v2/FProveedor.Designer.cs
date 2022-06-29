
namespace Proyecto_v2
{
    partial class FProveedor
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
            this.lbl_Cuit = new System.Windows.Forms.Label();
            this.mtCuit = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tRazonSocial = new System.Windows.Forms.TextBox();
            this.bAceptar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.chNacional = new System.Windows.Forms.CheckBox();
            this.epCUIT = new System.Windows.Forms.ErrorProvider(this.components);
            this.epRazon = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epCUIT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRazon)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Cuit
            // 
            this.lbl_Cuit.AutoSize = true;
            this.lbl_Cuit.Location = new System.Drawing.Point(23, 44);
            this.lbl_Cuit.Name = "lbl_Cuit";
            this.lbl_Cuit.Size = new System.Drawing.Size(35, 13);
            this.lbl_Cuit.TabIndex = 0;
            this.lbl_Cuit.Text = "CUIT:";
            // 
            // mtCuit
            // 
            this.mtCuit.Location = new System.Drawing.Point(120, 37);
            this.mtCuit.Mask = "99-99999999-9";
            this.mtCuit.Name = "mtCuit";
            this.mtCuit.Size = new System.Drawing.Size(111, 20);
            this.mtCuit.TabIndex = 0;
            this.mtCuit.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtCuit.Validating += new System.ComponentModel.CancelEventHandler(this.mtCuit_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Razón Social:";
            // 
            // tRazonSocial
            // 
            this.tRazonSocial.Location = new System.Drawing.Point(120, 63);
            this.tRazonSocial.MaxLength = 25;
            this.tRazonSocial.Name = "tRazonSocial";
            this.tRazonSocial.Size = new System.Drawing.Size(111, 20);
            this.tRazonSocial.TabIndex = 1;
            this.tRazonSocial.Validating += new System.ComponentModel.CancelEventHandler(this.tRazonSocial_Validating);
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(28, 125);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(103, 23);
            this.bAceptar.TabIndex = 3;
            this.bAceptar.Text = "&Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancelar.Location = new System.Drawing.Point(150, 125);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(106, 23);
            this.bCancelar.TabIndex = 4;
            this.bCancelar.Text = "&Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            // 
            // chNacional
            // 
            this.chNacional.AutoSize = true;
            this.chNacional.Location = new System.Drawing.Point(120, 93);
            this.chNacional.Name = "chNacional";
            this.chNacional.Size = new System.Drawing.Size(68, 17);
            this.chNacional.TabIndex = 2;
            this.chNacional.Text = "Nacional";
            this.chNacional.UseVisualStyleBackColor = true;
            // 
            // epCUIT
            // 
            this.epCUIT.ContainerControl = this;
            // 
            // epRazon
            // 
            this.epRazon.ContainerControl = this;
            // 
            // FProveedor
            // 
            this.AcceptButton = this.bAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCancelar;
            this.ClientSize = new System.Drawing.Size(279, 163);
            this.Controls.Add(this.chNacional);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.tRazonSocial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtCuit);
            this.Controls.Add(this.lbl_Cuit);
            this.HelpButton = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FProveedor";
            this.Load += new System.EventHandler(this.FProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epCUIT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRazon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Cuit;
        private System.Windows.Forms.MaskedTextBox mtCuit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tRazonSocial;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.CheckBox chNacional;
        private System.Windows.Forms.ErrorProvider epCUIT;
        private System.Windows.Forms.ErrorProvider epRazon;
    }
}