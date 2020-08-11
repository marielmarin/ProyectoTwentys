namespace ProyectoTwentys
{
    partial class CambiarContrasena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambiarContrasena));
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txtContrasenaActual = new System.Windows.Forms.TextBox();
            this.txtContrasenaNueva = new System.Windows.Forms.TextBox();
            this.lblCambiarContrasena = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.ImagenTwentys = new System.Windows.Forms.PictureBox();
            this.txtConfirmarContrasena = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenTwentys)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(780, 330);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.Black;
            this.lineShape3.Enabled = false;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 315;
            this.lineShape3.X2 = 709;
            this.lineShape3.Y1 = 236;
            this.lineShape3.Y2 = 236;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.Black;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 313;
            this.lineShape2.X2 = 707;
            this.lineShape2.Y1 = 177;
            this.lineShape2.Y2 = 177;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Black;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 312;
            this.lineShape1.X2 = 706;
            this.lineShape1.Y1 = 114;
            this.lineShape1.Y2 = 114;
            // 
            // txtContrasenaActual
            // 
            this.txtContrasenaActual.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtContrasenaActual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasenaActual.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenaActual.ForeColor = System.Drawing.Color.Black;
            this.txtContrasenaActual.Location = new System.Drawing.Point(315, 86);
            this.txtContrasenaActual.Name = "txtContrasenaActual";
            this.txtContrasenaActual.Size = new System.Drawing.Size(395, 20);
            this.txtContrasenaActual.TabIndex = 1;
            this.txtContrasenaActual.Text = "CONTRASEÑA ACTUAL ";
            this.txtContrasenaActual.Enter += new System.EventHandler(this.txtContrasenaActual_Enter);
            this.txtContrasenaActual.Leave += new System.EventHandler(this.txtContrasenaActual_Leave);
            // 
            // txtContrasenaNueva
            // 
            this.txtContrasenaNueva.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtContrasenaNueva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasenaNueva.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenaNueva.ForeColor = System.Drawing.Color.Black;
            this.txtContrasenaNueva.Location = new System.Drawing.Point(315, 149);
            this.txtContrasenaNueva.Name = "txtContrasenaNueva";
            this.txtContrasenaNueva.Size = new System.Drawing.Size(395, 20);
            this.txtContrasenaNueva.TabIndex = 2;
            this.txtContrasenaNueva.Text = "CONTRASEÑA NUEVA";
            this.txtContrasenaNueva.Enter += new System.EventHandler(this.txtContrasenaNueva_Enter);
            this.txtContrasenaNueva.Leave += new System.EventHandler(this.txtContrasenaNueva_Leave);
            // 
            // lblCambiarContrasena
            // 
            this.lblCambiarContrasena.AutoSize = true;
            this.lblCambiarContrasena.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambiarContrasena.ForeColor = System.Drawing.Color.Black;
            this.lblCambiarContrasena.Location = new System.Drawing.Point(432, 22);
            this.lblCambiarContrasena.Name = "lblCambiarContrasena";
            this.lblCambiarContrasena.Size = new System.Drawing.Size(234, 22);
            this.lblCambiarContrasena.TabIndex = 0;
            this.lblCambiarContrasena.Text = "CAMBIAR CONTRASEÑA";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.DimGray;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.LightGray;
            this.btnAceptar.Location = new System.Drawing.Point(315, 262);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(408, 40);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(754, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(722, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 9;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // ImagenTwentys
            // 
            this.ImagenTwentys.Image = ((System.Drawing.Image)(resources.GetObject("ImagenTwentys.Image")));
            this.ImagenTwentys.Location = new System.Drawing.Point(0, 0);
            this.ImagenTwentys.Name = "ImagenTwentys";
            this.ImagenTwentys.Size = new System.Drawing.Size(283, 330);
            this.ImagenTwentys.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenTwentys.TabIndex = 10;
            this.ImagenTwentys.TabStop = false;
            this.ImagenTwentys.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImagenTwentys_MouseDown);
            // 
            // txtConfirmarContrasena
            // 
            this.txtConfirmarContrasena.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtConfirmarContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmarContrasena.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarContrasena.ForeColor = System.Drawing.Color.Black;
            this.txtConfirmarContrasena.Location = new System.Drawing.Point(315, 210);
            this.txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            this.txtConfirmarContrasena.Size = new System.Drawing.Size(395, 20);
            this.txtConfirmarContrasena.TabIndex = 3;
            this.txtConfirmarContrasena.Text = "CONFIRMAR CONTRASEÑA";
            this.txtConfirmarContrasena.Enter += new System.EventHandler(this.txtConfirmarContrasena_Enter);
            this.txtConfirmarContrasena.Leave += new System.EventHandler(this.txtConfirmarContrasena_Leave);
            // 
            // CambiarContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.txtConfirmarContrasena);
            this.Controls.Add(this.ImagenTwentys);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblCambiarContrasena);
            this.Controls.Add(this.txtContrasenaNueva);
            this.Controls.Add(this.txtContrasenaActual);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CambiarContrasena";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CambiarContrasena_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenTwentys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox txtContrasenaActual;
        private System.Windows.Forms.TextBox txtContrasenaNueva;
        private System.Windows.Forms.Label lblCambiarContrasena;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox ImagenTwentys;
        private System.Windows.Forms.TextBox txtConfirmarContrasena;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
    }
}

