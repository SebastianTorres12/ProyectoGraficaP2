namespace ProyectoGraficaP2
{
    partial class FrmCicloide
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
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.grbCanvas = new System.Windows.Forms.GroupBox();
            this.grbAccion = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGraficarA = new System.Windows.Forms.Button();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.btnResetear = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.txtSaltos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.grbDatos.SuspendLayout();
            this.grbCanvas.SuspendLayout();
            this.grbAccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.txtRadio);
            this.grbDatos.Controls.Add(this.label2);
            this.grbDatos.Controls.Add(this.txtSaltos);
            this.grbDatos.Controls.Add(this.label1);
            this.grbDatos.Location = new System.Drawing.Point(3, 13);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(210, 145);
            this.grbDatos.TabIndex = 0;
            this.grbDatos.TabStop = false;
            // 
            // grbCanvas
            // 
            this.grbCanvas.Controls.Add(this.picCanvas);
            this.grbCanvas.Location = new System.Drawing.Point(220, 13);
            this.grbCanvas.Name = "grbCanvas";
            this.grbCanvas.Size = new System.Drawing.Size(720, 562);
            this.grbCanvas.TabIndex = 1;
            this.grbCanvas.TabStop = false;
            // 
            // grbAccion
            // 
            this.grbAccion.Controls.Add(this.btnRegresar);
            this.grbAccion.Controls.Add(this.btnResetear);
            this.grbAccion.Controls.Add(this.btnGraficar);
            this.grbAccion.Controls.Add(this.btnGraficarA);
            this.grbAccion.Location = new System.Drawing.Point(3, 164);
            this.grbAccion.Name = "grbAccion";
            this.grbAccion.Size = new System.Drawing.Size(210, 411);
            this.grbAccion.TabIndex = 2;
            this.grbAccion.TabStop = false;
            this.grbAccion.Enter += new System.EventHandler(this.grbAccion_Enter);
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(7, 19);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(707, 538);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saltos:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnGraficarA
            // 
            this.btnGraficarA.BackColor = System.Drawing.Color.Blue;
            this.btnGraficarA.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraficarA.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGraficarA.Location = new System.Drawing.Point(21, 60);
            this.btnGraficarA.Name = "btnGraficarA";
            this.btnGraficarA.Size = new System.Drawing.Size(173, 44);
            this.btnGraficarA.TabIndex = 0;
            this.btnGraficarA.Text = "Graficar Animado";
            this.btnGraficarA.UseVisualStyleBackColor = false;
            this.btnGraficarA.Click += new System.EventHandler(this.btnGraficarA_Click);
            // 
            // btnGraficar
            // 
            this.btnGraficar.BackColor = System.Drawing.Color.Blue;
            this.btnGraficar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraficar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGraficar.Location = new System.Drawing.Point(21, 136);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(173, 44);
            this.btnGraficar.TabIndex = 1;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = false;
            this.btnGraficar.Click += new System.EventHandler(this.btnGraficar_Click);
            // 
            // btnResetear
            // 
            this.btnResetear.BackColor = System.Drawing.Color.Blue;
            this.btnResetear.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnResetear.Location = new System.Drawing.Point(21, 210);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(173, 44);
            this.btnResetear.TabIndex = 2;
            this.btnResetear.Text = "Resetear";
            this.btnResetear.UseVisualStyleBackColor = false;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Crimson;
            this.btnRegresar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegresar.Location = new System.Drawing.Point(21, 288);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(173, 44);
            this.btnRegresar.TabIndex = 3;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // txtSaltos
            // 
            this.txtSaltos.Location = new System.Drawing.Point(67, 102);
            this.txtSaltos.Name = "txtSaltos";
            this.txtSaltos.Size = new System.Drawing.Size(127, 20);
            this.txtSaltos.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Radio:";
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(67, 41);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(127, 20);
            this.txtRadio.TabIndex = 3;
            // 
            // FrmCicloide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(943, 581);
            this.Controls.Add(this.grbAccion);
            this.Controls.Add(this.grbCanvas);
            this.Controls.Add(this.grbDatos);
            this.Name = "FrmCicloide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCicloide";
            this.Load += new System.EventHandler(this.FrmCicloide_Load);
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.grbCanvas.ResumeLayout(false);
            this.grbAccion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.GroupBox grbCanvas;
        private System.Windows.Forms.GroupBox grbAccion;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.Button btnGraficar;
        private System.Windows.Forms.Button btnGraficarA;
        private System.Windows.Forms.TextBox txtSaltos;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.Label label2;
    }
}