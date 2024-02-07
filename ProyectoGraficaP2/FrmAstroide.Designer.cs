namespace ProyectoGraficaP2
{
    partial class FrmAstroide
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
            this.grbDatosAstroide = new System.Windows.Forms.GroupBox();
            this.txtTamanio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbCanvas = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.grbAccionAstroide = new System.Windows.Forms.GroupBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnResetear = new System.Windows.Forms.Button();
            this.btnGraficarAni = new System.Windows.Forms.Button();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.grbDatosAstroide.SuspendLayout();
            this.grbCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.grbAccionAstroide.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDatosAstroide
            // 
            this.grbDatosAstroide.Controls.Add(this.txtTamanio);
            this.grbDatosAstroide.Controls.Add(this.label1);
            this.grbDatosAstroide.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosAstroide.Location = new System.Drawing.Point(13, 8);
            this.grbDatosAstroide.Name = "grbDatosAstroide";
            this.grbDatosAstroide.Size = new System.Drawing.Size(200, 163);
            this.grbDatosAstroide.TabIndex = 0;
            this.grbDatosAstroide.TabStop = false;
            // 
            // txtTamanio
            // 
            this.txtTamanio.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTamanio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTamanio.Location = new System.Drawing.Point(86, 76);
            this.txtTamanio.Name = "txtTamanio";
            this.txtTamanio.Size = new System.Drawing.Size(100, 26);
            this.txtTamanio.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(6, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tamaño:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // grbCanvas
            // 
            this.grbCanvas.Controls.Add(this.picCanvas);
            this.grbCanvas.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCanvas.Location = new System.Drawing.Point(220, 8);
            this.grbCanvas.Name = "grbCanvas";
            this.grbCanvas.Size = new System.Drawing.Size(676, 543);
            this.grbCanvas.TabIndex = 1;
            this.grbCanvas.TabStop = false;
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(7, 17);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(663, 520);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // grbAccionAstroide
            // 
            this.grbAccionAstroide.Controls.Add(this.btnGraficar);
            this.grbAccionAstroide.Controls.Add(this.btnRegresar);
            this.grbAccionAstroide.Controls.Add(this.btnResetear);
            this.grbAccionAstroide.Controls.Add(this.btnGraficarAni);
            this.grbAccionAstroide.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAccionAstroide.Location = new System.Drawing.Point(12, 177);
            this.grbAccionAstroide.Name = "grbAccionAstroide";
            this.grbAccionAstroide.Size = new System.Drawing.Size(200, 374);
            this.grbAccionAstroide.TabIndex = 2;
            this.grbAccionAstroide.TabStop = false;
            this.grbAccionAstroide.Enter += new System.EventHandler(this.grbAccionAstroide_Enter);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Crimson;
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegresar.Location = new System.Drawing.Point(23, 290);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(157, 47);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnResetear
            // 
            this.btnResetear.BackColor = System.Drawing.Color.Blue;
            this.btnResetear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnResetear.Location = new System.Drawing.Point(23, 208);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(157, 50);
            this.btnResetear.TabIndex = 1;
            this.btnResetear.Text = "Resetear";
            this.btnResetear.UseVisualStyleBackColor = false;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // btnGraficarAni
            // 
            this.btnGraficarAni.BackColor = System.Drawing.Color.Blue;
            this.btnGraficarAni.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGraficarAni.Location = new System.Drawing.Point(23, 53);
            this.btnGraficarAni.Name = "btnGraficarAni";
            this.btnGraficarAni.Size = new System.Drawing.Size(157, 47);
            this.btnGraficarAni.TabIndex = 0;
            this.btnGraficarAni.Text = "Graficar Animado";
            this.btnGraficarAni.UseVisualStyleBackColor = false;
            this.btnGraficarAni.Click += new System.EventHandler(this.btnGraficar_Click);
            // 
            // btnGraficar
            // 
            this.btnGraficar.BackColor = System.Drawing.Color.Blue;
            this.btnGraficar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGraficar.Location = new System.Drawing.Point(23, 126);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(157, 47);
            this.btnGraficar.TabIndex = 3;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = false;
            this.btnGraficar.Click += new System.EventHandler(this.btnGraficar_Click_1);
            // 
            // FrmAstroide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(908, 563);
            this.Controls.Add(this.grbAccionAstroide);
            this.Controls.Add(this.grbCanvas);
            this.Controls.Add(this.grbDatosAstroide);
            this.Name = "FrmAstroide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAstroide";
            this.Load += new System.EventHandler(this.FrmAstroide_Load);
            this.grbDatosAstroide.ResumeLayout(false);
            this.grbDatosAstroide.PerformLayout();
            this.grbCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.grbAccionAstroide.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatosAstroide;
        private System.Windows.Forms.TextBox txtTamanio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbCanvas;
        private System.Windows.Forms.GroupBox grbAccionAstroide;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.Button btnGraficarAni;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button btnGraficar;
    }
}