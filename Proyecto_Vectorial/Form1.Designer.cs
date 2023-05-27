
namespace Proyecto_Vectorial
{
    partial class Gradiente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gradiente));
            this.Definicion = new System.Windows.Forms.Button();
            this.CalGrad = new System.Windows.Forms.Button();
            this.CalValMax = new System.Windows.Forms.Button();
            this.Grad_Const = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Potencia = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Button();
            this.ansBoX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.borrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Definicion
            // 
            this.Definicion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Definicion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Definicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Definicion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Definicion.ForeColor = System.Drawing.Color.White;
            this.Definicion.Location = new System.Drawing.Point(458, 144);
            this.Definicion.Name = "Definicion";
            this.Definicion.Size = new System.Drawing.Size(89, 29);
            this.Definicion.TabIndex = 0;
            this.Definicion.Text = "Definicion";
            this.Definicion.UseVisualStyleBackColor = false;
            this.Definicion.Click += new System.EventHandler(this.Definicion_Click);
            // 
            // CalGrad
            // 
            this.CalGrad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CalGrad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CalGrad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalGrad.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalGrad.ForeColor = System.Drawing.Color.White;
            this.CalGrad.Location = new System.Drawing.Point(50, 230);
            this.CalGrad.Name = "CalGrad";
            this.CalGrad.Size = new System.Drawing.Size(92, 45);
            this.CalGrad.TabIndex = 1;
            this.CalGrad.Text = "Gradiente X";
            this.CalGrad.UseVisualStyleBackColor = false;
            this.CalGrad.Click += new System.EventHandler(this.CalGrad_Click);
            // 
            // CalValMax
            // 
            this.CalValMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CalValMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CalValMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalValMax.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalValMax.ForeColor = System.Drawing.Color.White;
            this.CalValMax.Location = new System.Drawing.Point(148, 230);
            this.CalValMax.Name = "CalValMax";
            this.CalValMax.Size = new System.Drawing.Size(87, 45);
            this.CalValMax.TabIndex = 2;
            this.CalValMax.Text = "Gradiente Y";
            this.CalValMax.UseVisualStyleBackColor = false;
            this.CalValMax.Click += new System.EventHandler(this.CalValMax_Click);
            // 
            // Grad_Const
            // 
            this.Grad_Const.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Grad_Const.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Grad_Const.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Grad_Const.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grad_Const.ForeColor = System.Drawing.Color.White;
            this.Grad_Const.Location = new System.Drawing.Point(241, 230);
            this.Grad_Const.Name = "Grad_Const";
            this.Grad_Const.Size = new System.Drawing.Size(107, 45);
            this.Grad_Const.TabIndex = 3;
            this.Grad_Const.Text = "Gradiente Constante";
            this.Grad_Const.UseVisualStyleBackColor = false;
            this.Grad_Const.Click += new System.EventHandler(this.button3_Click);
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salir.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.ForeColor = System.Drawing.Color.White;
            this.Salir.Location = new System.Drawing.Point(458, 246);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(89, 29);
            this.Salir.TabIndex = 4;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(619, 98);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Potencia
            // 
            this.Potencia.AutoSize = true;
            this.Potencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Potencia.Location = new System.Drawing.Point(200, 128);
            this.Potencia.Name = "Potencia";
            this.Potencia.Size = new System.Drawing.Size(148, 13);
            this.Potencia.TabIndex = 7;
            this.Potencia.Text = "DATOS DEL PROBLEMA";
            this.Potencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultado
            // 
            this.resultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.resultado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resultado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.ForeColor = System.Drawing.Color.White;
            this.resultado.Location = new System.Drawing.Point(458, 177);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(89, 28);
            this.resultado.TabIndex = 27;
            this.resultado.Text = "Resultado";
            this.resultado.UseVisualStyleBackColor = false;
            this.resultado.Click += new System.EventHandler(this.resultado_Click);
            // 
            // ansBoX
            // 
            this.ansBoX.Location = new System.Drawing.Point(122, 167);
            this.ansBoX.Name = "ansBoX";
            this.ansBoX.Size = new System.Drawing.Size(187, 20);
            this.ansBoX.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Gradiente: ";
            // 
            // borrar
            // 
            this.borrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.borrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrar.ForeColor = System.Drawing.Color.White;
            this.borrar.Location = new System.Drawing.Point(458, 211);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(89, 29);
            this.borrar.TabIndex = 28;
            this.borrar.Text = "Borrar";
            this.borrar.UseVisualStyleBackColor = false;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // Gradiente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(619, 315);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ansBoX);
            this.Controls.Add(this.Potencia);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Grad_Const);
            this.Controls.Add(this.CalValMax);
            this.Controls.Add(this.CalGrad);
            this.Controls.Add(this.Definicion);
            this.Name = "Gradiente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo de Gradiente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Definicion;
        private System.Windows.Forms.Button CalGrad;
        private System.Windows.Forms.Button CalValMax;
        private System.Windows.Forms.Button Grad_Const;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Potencia;
        private System.Windows.Forms.Button resultado;
        private System.Windows.Forms.TextBox ansBoX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button borrar;
    }
}

