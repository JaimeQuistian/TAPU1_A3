namespace Actividad3
{
    partial class frmAcceso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcceso));
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.gbGrupo1 = new System.Windows.Forms.GroupBox();
            this.lbInformacion = new System.Windows.Forms.Label();
            this.rbOpcion1 = new System.Windows.Forms.RadioButton();
            this.rbOpcion2 = new System.Windows.Forms.RadioButton();
            this.gbContenedor2 = new System.Windows.Forms.GroupBox();
            this.cbColorFondo = new System.Windows.Forms.CheckBox();
            this.cbColorLetra = new System.Windows.Forms.CheckBox();
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.gbContenedor3 = new System.Windows.Forms.GroupBox();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pbImagenCuasar = new System.Windows.Forms.PictureBox();
            this.gbOpciones.SuspendLayout();
            this.gbGrupo1.SuspendLayout();
            this.gbContenedor2.SuspendLayout();
            this.gbContenedor3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenCuasar)).BeginInit();
            this.SuspendLayout();
            // 
            // gbOpciones
            // 
            this.gbOpciones.Controls.Add(this.btnCerrar);
            this.gbOpciones.Controls.Add(this.gbContenedor3);
            this.gbOpciones.Controls.Add(this.gbContenedor2);
            this.gbOpciones.Controls.Add(this.gbGrupo1);
            this.gbOpciones.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpciones.Location = new System.Drawing.Point(12, 12);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(207, 362);
            this.gbOpciones.TabIndex = 0;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "Opciones";
            // 
            // gbGrupo1
            // 
            this.gbGrupo1.Controls.Add(this.rbOpcion2);
            this.gbGrupo1.Controls.Add(this.rbOpcion1);
            this.gbGrupo1.Controls.Add(this.lbInformacion);
            this.gbGrupo1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGrupo1.Location = new System.Drawing.Point(6, 19);
            this.gbGrupo1.Name = "gbGrupo1";
            this.gbGrupo1.Size = new System.Drawing.Size(195, 82);
            this.gbGrupo1.TabIndex = 1;
            this.gbGrupo1.TabStop = false;
            this.gbGrupo1.Text = "Imagen";
            // 
            // lbInformacion
            // 
            this.lbInformacion.AutoSize = true;
            this.lbInformacion.Location = new System.Drawing.Point(6, 19);
            this.lbInformacion.Name = "lbInformacion";
            this.lbInformacion.Size = new System.Drawing.Size(180, 12);
            this.lbInformacion.TabIndex = 2;
            this.lbInformacion.Text = "¿Deseas activar el movimiento?";
            // 
            // rbOpcion1
            // 
            this.rbOpcion1.AutoSize = true;
            this.rbOpcion1.Location = new System.Drawing.Point(46, 52);
            this.rbOpcion1.Name = "rbOpcion1";
            this.rbOpcion1.Size = new System.Drawing.Size(33, 16);
            this.rbOpcion1.TabIndex = 3;
            this.rbOpcion1.Text = "Si";
            this.rbOpcion1.UseVisualStyleBackColor = true;
            this.rbOpcion1.CheckedChanged += new System.EventHandler(this.rbOpcion1_CheckedChanged);
            // 
            // rbOpcion2
            // 
            this.rbOpcion2.AutoSize = true;
            this.rbOpcion2.Checked = true;
            this.rbOpcion2.Location = new System.Drawing.Point(115, 52);
            this.rbOpcion2.Name = "rbOpcion2";
            this.rbOpcion2.Size = new System.Drawing.Size(38, 16);
            this.rbOpcion2.TabIndex = 4;
            this.rbOpcion2.TabStop = true;
            this.rbOpcion2.Text = "No";
            this.rbOpcion2.UseVisualStyleBackColor = true;
            this.rbOpcion2.CheckedChanged += new System.EventHandler(this.rbOpcion2_CheckedChanged);
            // 
            // gbContenedor2
            // 
            this.gbContenedor2.Controls.Add(this.btnRestablecer);
            this.gbContenedor2.Controls.Add(this.cbColorLetra);
            this.gbContenedor2.Controls.Add(this.cbColorFondo);
            this.gbContenedor2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContenedor2.Location = new System.Drawing.Point(6, 108);
            this.gbContenedor2.Name = "gbContenedor2";
            this.gbContenedor2.Size = new System.Drawing.Size(195, 117);
            this.gbContenedor2.TabIndex = 5;
            this.gbContenedor2.TabStop = false;
            this.gbContenedor2.Text = "Apariencia";
            // 
            // cbColorFondo
            // 
            this.cbColorFondo.AutoSize = true;
            this.cbColorFondo.Location = new System.Drawing.Point(6, 29);
            this.cbColorFondo.Name = "cbColorFondo";
            this.cbColorFondo.Size = new System.Drawing.Size(155, 16);
            this.cbColorFondo.TabIndex = 6;
            this.cbColorFondo.Text = "Cambiar color de fondo";
            this.cbColorFondo.UseVisualStyleBackColor = true;
            this.cbColorFondo.CheckedChanged += new System.EventHandler(this.cbColorFondo_CheckedChanged);
            // 
            // cbColorLetra
            // 
            this.cbColorLetra.AutoSize = true;
            this.cbColorLetra.Location = new System.Drawing.Point(6, 61);
            this.cbColorLetra.Name = "cbColorLetra";
            this.cbColorLetra.Size = new System.Drawing.Size(149, 16);
            this.cbColorLetra.TabIndex = 7;
            this.cbColorLetra.Text = "Cambiar color de letra";
            this.cbColorLetra.UseVisualStyleBackColor = true;
            this.cbColorLetra.CheckedChanged += new System.EventHandler(this.cbColorLetra_CheckedChanged);
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.Location = new System.Drawing.Point(21, 85);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(156, 23);
            this.btnRestablecer.TabIndex = 8;
            this.btnRestablecer.Text = "Restablecer";
            this.btnRestablecer.UseVisualStyleBackColor = true;
            this.btnRestablecer.Click += new System.EventHandler(this.btnRestablecer_Click);
            // 
            // gbContenedor3
            // 
            this.gbContenedor3.Controls.Add(this.txtRespuesta);
            this.gbContenedor3.Controls.Add(this.lblRespuesta);
            this.gbContenedor3.Controls.Add(this.lblPregunta);
            this.gbContenedor3.Location = new System.Drawing.Point(6, 231);
            this.gbContenedor3.Name = "gbContenedor3";
            this.gbContenedor3.Size = new System.Drawing.Size(195, 87);
            this.gbContenedor3.TabIndex = 9;
            this.gbContenedor3.TabStop = false;
            this.gbContenedor3.Text = "Pregunta";
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta.Location = new System.Drawing.Point(5, 23);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(181, 12);
            this.lblPregunta.TabIndex = 10;
            this.lblPregunta.Text = "¿Qué es el obejto de la imagen?";
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuesta.Location = new System.Drawing.Point(4, 54);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(67, 12);
            this.lblRespuesta.TabIndex = 11;
            this.lblRespuesta.Text = "Respuesta:";
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespuesta.Location = new System.Drawing.Point(75, 46);
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(111, 20);
            this.txtRespuesta.TabIndex = 12;
            this.txtRespuesta.Text = "Es un ...";
            this.txtRespuesta.Click += new System.EventHandler(this.txtRespuesta_Click);
            this.txtRespuesta.TextChanged += new System.EventHandler(this.txtRespuesta_TextChanged);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(58, 327);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.Text = "Salir";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pbImagenCuasar
            // 
            this.pbImagenCuasar.Image = ((System.Drawing.Image)(resources.GetObject("pbImagenCuasar.Image")));
            this.pbImagenCuasar.Location = new System.Drawing.Point(325, 149);
            this.pbImagenCuasar.Name = "pbImagenCuasar";
            this.pbImagenCuasar.Size = new System.Drawing.Size(244, 129);
            this.pbImagenCuasar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagenCuasar.TabIndex = 1;
            this.pbImagenCuasar.TabStop = false;
            this.pbImagenCuasar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbImagenCuasar_MouseMove);
            // 
            // frmAcceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(676, 393);
            this.ControlBox = false;
            this.Controls.Add(this.pbImagenCuasar);
            this.Controls.Add(this.gbOpciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAcceso";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Actividad de Eventos";
            this.Load += new System.EventHandler(this.frmAcceso_Load);
            this.gbOpciones.ResumeLayout(false);
            this.gbGrupo1.ResumeLayout(false);
            this.gbGrupo1.PerformLayout();
            this.gbContenedor2.ResumeLayout(false);
            this.gbContenedor2.PerformLayout();
            this.gbContenedor3.ResumeLayout(false);
            this.gbContenedor3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenCuasar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOpciones;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox gbContenedor3;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.GroupBox gbContenedor2;
        private System.Windows.Forms.Button btnRestablecer;
        private System.Windows.Forms.CheckBox cbColorLetra;
        private System.Windows.Forms.CheckBox cbColorFondo;
        private System.Windows.Forms.GroupBox gbGrupo1;
        private System.Windows.Forms.RadioButton rbOpcion2;
        private System.Windows.Forms.RadioButton rbOpcion1;
        private System.Windows.Forms.Label lbInformacion;
        private System.Windows.Forms.PictureBox pbImagenCuasar;
    }
}

