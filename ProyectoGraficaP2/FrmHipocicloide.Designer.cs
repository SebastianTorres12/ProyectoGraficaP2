namespace ProyectoGraficaP2
{
    partial class FrmHipocicloide
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
            this.txtVueltas = new System.Windows.Forms.TextBox();
            this.txtRMenor = new System.Windows.Forms.TextBox();
            this.txtRMayor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbCanvas = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.grbBotones = new System.Windows.Forms.GroupBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnResetear = new System.Windows.Forms.Button();
            this.btnGraficarAni = new System.Windows.Forms.Button();
            this.grbDatos.SuspendLayout();
            this.grbCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.grbBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.txtVueltas);
            this.grbDatos.Controls.Add(this.txtRMenor);
            this.grbDatos.Controls.Add(this.txtRMayor);
            this.grbDatos.Controls.Add(this.label3);
            this.grbDatos.Controls.Add(this.label2);
            this.grbDatos.Controls.Add(this.label1);
            this.grbDatos.Location = new System.Drawing.Point(4, 13);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(229, 170);
            this.grbDatos.TabIndex = 0;
            this.grbDatos.TabStop = false;
            // 
            // txtVueltas
            // 
            this.txtVueltas.Location = new System.Drawing.Point(123, 119);
            this.txtVueltas.Name = "txtVueltas";
            this.txtVueltas.Size = new System.Drawing.Size(100, 20);
            this.txtVueltas.TabIndex = 5;
            // 
            // txtRMenor
            // 
            this.txtRMenor.Location = new System.Drawing.Point(123, 81);
            this.txtRMenor.Name = "txtRMenor";
            this.txtRMenor.Size = new System.Drawing.Size(100, 20);
            this.txtRMenor.TabIndex = 4;
            // 
            // txtRMayor
            // 
            this.txtRMayor.Location = new System.Drawing.Point(123, 35);
            this.txtRMayor.Name = "txtRMayor";
            this.txtRMayor.Size = new System.Drawing.Size(100, 20);
            this.txtRMayor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vueltas:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Radio Menor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Radio Mayor:";
            // 
            // grbCanvas
            // 
            this.grbCanvas.Controls.Add(this.picCanvas);
            this.grbCanvas.Location = new System.Drawing.Point(239, 13);
            this.grbCanvas.Name = "grbCanvas";
            this.grbCanvas.Size = new System.Drawing.Size(764, 533);
            this.grbCanvas.TabIndex = 1;
            this.grbCanvas.TabStop = false;
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(6, 19);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(749, 504);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // grbBotones
            // 
            this.grbBotones.Controls.Add(this.btnRegresar);
            this.grbBotones.Controls.Add(this.btnResetear);
            this.grbBotones.Controls.Add(this.btnGraficarAni);
            this.grbBotones.Location = new System.Drawing.Point(4, 189);
            this.grbBotones.Name = "grbBotones";
            this.grbBotones.Size = new System.Drawing.Size(229, 357);
            this.grbBotones.TabIndex = 2;
            this.grbBotones.TabStop = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Crimson;
            this.btnRegresar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(32, 256);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(169, 43);
            this.btnRegresar.TabIndex = 3;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnResetear
            // 
            this.btnResetear.BackColor = System.Drawing.Color.Blue;
            this.btnResetear.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetear.ForeColor = System.Drawing.Color.White;
            this.btnResetear.Location = new System.Drawing.Point(32, 159);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(169, 43);
            this.btnResetear.TabIndex = 2;
            this.btnResetear.Text = "Resetear";
            this.btnResetear.UseVisualStyleBackColor = false;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // btnGraficarAni
            // 
            this.btnGraficarAni.BackColor = System.Drawing.Color.Blue;
            this.btnGraficarAni.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraficarAni.ForeColor = System.Drawing.Color.White;
            this.btnGraficarAni.Location = new System.Drawing.Point(32, 61);
            this.btnGraficarAni.Name = "btnGraficarAni";
            this.btnGraficarAni.Size = new System.Drawing.Size(169, 43);
            this.btnGraficarAni.TabIndex = 0;
            this.btnGraficarAni.Text = "Graficar Animado";
            this.btnGraficarAni.UseVisualStyleBackColor = false;
            this.btnGraficarAni.Click += new System.EventHandler(this.btnGraficarAni_Click);
            // 
            // FrmHipocicloide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1006, 548);
            this.Controls.Add(this.grbBotones);
            this.Controls.Add(this.grbCanvas);
            this.Controls.Add(this.grbDatos);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmHipocicloide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHipocicloide";
            this.Load += new System.EventHandler(this.FrmHipocicloide_Load);
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.grbCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.grbBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.GroupBox grbCanvas;
        private System.Windows.Forms.GroupBox grbBotones;
        private System.Windows.Forms.TextBox txtVueltas;
        private System.Windows.Forms.TextBox txtRMenor;
        private System.Windows.Forms.TextBox txtRMayor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.Button btnGraficarAni;
    }
}