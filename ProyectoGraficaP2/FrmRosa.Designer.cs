namespace ProyectoGraficaP2
{
    partial class frmRosa
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
            this.grbDatosRosa = new System.Windows.Forms.GroupBox();
            this.txtNPetalos = new System.Windows.Forms.TextBox();
            this.txtTamanio = new System.Windows.Forms.TextBox();
            this.lblPetalos = new System.Windows.Forms.Label();
            this.lblTamanio = new System.Windows.Forms.Label();
            this.grbAccionRosa = new System.Windows.Forms.GroupBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnResetear = new System.Windows.Forms.Button();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.grbCanvas = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.grbDatosRosa.SuspendLayout();
            this.grbAccionRosa.SuspendLayout();
            this.grbCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDatosRosa
            // 
            this.grbDatosRosa.Controls.Add(this.txtNPetalos);
            this.grbDatosRosa.Controls.Add(this.txtTamanio);
            this.grbDatosRosa.Controls.Add(this.lblPetalos);
            this.grbDatosRosa.Controls.Add(this.lblTamanio);
            this.grbDatosRosa.Location = new System.Drawing.Point(13, 9);
            this.grbDatosRosa.Name = "grbDatosRosa";
            this.grbDatosRosa.Size = new System.Drawing.Size(283, 142);
            this.grbDatosRosa.TabIndex = 0;
            this.grbDatosRosa.TabStop = false;
            // 
            // txtNPetalos
            // 
            this.txtNPetalos.Location = new System.Drawing.Point(186, 95);
            this.txtNPetalos.Name = "txtNPetalos";
            this.txtNPetalos.Size = new System.Drawing.Size(77, 20);
            this.txtNPetalos.TabIndex = 3;
            this.txtNPetalos.TextChanged += new System.EventHandler(this.txtNPetalos_TextChanged);
            // 
            // txtTamanio
            // 
            this.txtTamanio.Location = new System.Drawing.Point(186, 42);
            this.txtTamanio.Name = "txtTamanio";
            this.txtTamanio.Size = new System.Drawing.Size(77, 20);
            this.txtTamanio.TabIndex = 2;
            this.txtTamanio.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblPetalos
            // 
            this.lblPetalos.AutoSize = true;
            this.lblPetalos.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetalos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPetalos.Location = new System.Drawing.Point(18, 91);
            this.lblPetalos.Name = "lblPetalos";
            this.lblPetalos.Size = new System.Drawing.Size(162, 23);
            this.lblPetalos.TabIndex = 1;
            this.lblPetalos.Text = "Número de Pétalos:";
            this.lblPetalos.Click += new System.EventHandler(this.lblPetalos_Click);
            // 
            // lblTamanio
            // 
            this.lblTamanio.AutoSize = true;
            this.lblTamanio.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamanio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTamanio.Location = new System.Drawing.Point(19, 38);
            this.lblTamanio.Name = "lblTamanio";
            this.lblTamanio.Size = new System.Drawing.Size(161, 23);
            this.lblTamanio.TabIndex = 0;
            this.lblTamanio.Text = "Tamaño de pétalos:";
            // 
            // grbAccionRosa
            // 
            this.grbAccionRosa.Controls.Add(this.btnRegresar);
            this.grbAccionRosa.Controls.Add(this.btnResetear);
            this.grbAccionRosa.Controls.Add(this.btnGraficar);
            this.grbAccionRosa.Location = new System.Drawing.Point(14, 157);
            this.grbAccionRosa.Name = "grbAccionRosa";
            this.grbAccionRosa.Size = new System.Drawing.Size(282, 281);
            this.grbAccionRosa.TabIndex = 1;
            this.grbAccionRosa.TabStop = false;
            this.grbAccionRosa.Enter += new System.EventHandler(this.grbAccionRosa_Enter);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Crimson;
            this.btnRegresar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegresar.Location = new System.Drawing.Point(68, 208);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(148, 39);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnResetear
            // 
            this.btnResetear.BackColor = System.Drawing.Color.Blue;
            this.btnResetear.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnResetear.Location = new System.Drawing.Point(68, 132);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(148, 39);
            this.btnResetear.TabIndex = 1;
            this.btnResetear.Text = "Resetear";
            this.btnResetear.UseVisualStyleBackColor = false;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // btnGraficar
            // 
            this.btnGraficar.BackColor = System.Drawing.Color.Blue;
            this.btnGraficar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraficar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGraficar.Location = new System.Drawing.Point(68, 50);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(148, 39);
            this.btnGraficar.TabIndex = 0;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = false;
            this.btnGraficar.Click += new System.EventHandler(this.btnGraficar_Click);
            // 
            // grbCanvas
            // 
            this.grbCanvas.Controls.Add(this.picCanvas);
            this.grbCanvas.Location = new System.Drawing.Point(302, 9);
            this.grbCanvas.Name = "grbCanvas";
            this.grbCanvas.Size = new System.Drawing.Size(577, 436);
            this.grbCanvas.TabIndex = 2;
            this.grbCanvas.TabStop = false;
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(7, 19);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(564, 410);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // frmRosa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(882, 450);
            this.Controls.Add(this.grbCanvas);
            this.Controls.Add(this.grbAccionRosa);
            this.Controls.Add(this.grbDatosRosa);
            this.Name = "frmRosa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmRosa_Load);
            this.grbDatosRosa.ResumeLayout(false);
            this.grbDatosRosa.PerformLayout();
            this.grbAccionRosa.ResumeLayout(false);
            this.grbCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatosRosa;
        private System.Windows.Forms.GroupBox grbAccionRosa;
        private System.Windows.Forms.GroupBox grbCanvas;
        private System.Windows.Forms.TextBox txtNPetalos;
        private System.Windows.Forms.TextBox txtTamanio;
        private System.Windows.Forms.Label lblPetalos;
        private System.Windows.Forms.Label lblTamanio;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.Button btnGraficar;
        private System.Windows.Forms.PictureBox picCanvas;
    }
}

