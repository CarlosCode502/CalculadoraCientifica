
namespace CalculadoraCientifica
{
    partial class Calculadora
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
            this.txt_Display = new System.Windows.Forms.TextBox();
            this.btn_Cero = new System.Windows.Forms.Button();
            this.btn_Punto = new System.Windows.Forms.Button();
            this.btn_Igual = new System.Windows.Forms.Button();
            this.btn_Uno = new System.Windows.Forms.Button();
            this.btn_Dos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_Siete = new System.Windows.Forms.Button();
            this.btn_Seis = new System.Windows.Forms.Button();
            this.btn_Cinco = new System.Windows.Forms.Button();
            this.btn_Cuatro = new System.Windows.Forms.Button();
            this.btn_Tres = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Mas = new System.Windows.Forms.Button();
            this.btn_Menos = new System.Windows.Forms.Button();
            this.btn_Divi = new System.Windows.Forms.Button();
            this.btn_Multi = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_potencia = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_ClearALL = new System.Windows.Forms.Button();
            this.btn_Factorial = new System.Windows.Forms.Button();
            this.btn_Up = new System.Windows.Forms.Button();
            this.btn_Right = new System.Windows.Forms.Button();
            this.btn_Down = new System.Windows.Forms.Button();
            this.btn_Left = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Display
            // 
            this.txt_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Display.Location = new System.Drawing.Point(12, 13);
            this.txt_Display.Multiline = true;
            this.txt_Display.Name = "txt_Display";
            this.txt_Display.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_Display.Size = new System.Drawing.Size(248, 56);
            this.txt_Display.TabIndex = 0;
            this.txt_Display.Text = "0";
            this.txt_Display.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Cero
            // 
            this.btn_Cero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_Cero.Location = new System.Drawing.Point(12, 164);
            this.btn_Cero.Name = "btn_Cero";
            this.btn_Cero.Size = new System.Drawing.Size(37, 34);
            this.btn_Cero.TabIndex = 1;
            this.btn_Cero.Text = "0";
            this.btn_Cero.UseVisualStyleBackColor = true;
            this.btn_Cero.Click += new System.EventHandler(this.DetectarNumero);
            // 
            // btn_Punto
            // 
            this.btn_Punto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_Punto.Location = new System.Drawing.Point(67, 164);
            this.btn_Punto.Name = "btn_Punto";
            this.btn_Punto.Size = new System.Drawing.Size(37, 34);
            this.btn_Punto.TabIndex = 2;
            this.btn_Punto.Text = ".";
            this.btn_Punto.UseVisualStyleBackColor = true;
            this.btn_Punto.Click += new System.EventHandler(this.DetectarNumero);
            // 
            // btn_Igual
            // 
            this.btn_Igual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_Igual.Location = new System.Drawing.Point(121, 164);
            this.btn_Igual.Name = "btn_Igual";
            this.btn_Igual.Size = new System.Drawing.Size(37, 34);
            this.btn_Igual.TabIndex = 3;
            this.btn_Igual.Text = "=";
            this.btn_Igual.UseVisualStyleBackColor = true;
            this.btn_Igual.Click += new System.EventHandler(this.btn_Igual_Click);
            // 
            // btn_Uno
            // 
            this.btn_Uno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_Uno.Location = new System.Drawing.Point(12, 115);
            this.btn_Uno.Name = "btn_Uno";
            this.btn_Uno.Size = new System.Drawing.Size(37, 34);
            this.btn_Uno.TabIndex = 4;
            this.btn_Uno.Text = "1";
            this.btn_Uno.UseVisualStyleBackColor = true;
            this.btn_Uno.Click += new System.EventHandler(this.DetectarNumero);
            // 
            // btn_Dos
            // 
            this.btn_Dos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_Dos.Location = new System.Drawing.Point(67, 115);
            this.btn_Dos.Name = "btn_Dos";
            this.btn_Dos.Size = new System.Drawing.Size(37, 34);
            this.btn_Dos.TabIndex = 5;
            this.btn_Dos.Text = "2";
            this.btn_Dos.UseVisualStyleBackColor = true;
            this.btn_Dos.Click += new System.EventHandler(this.DetectarNumero);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_9);
            this.panel1.Controls.Add(this.btn_8);
            this.panel1.Controls.Add(this.btn_Siete);
            this.panel1.Controls.Add(this.btn_Seis);
            this.panel1.Controls.Add(this.btn_Cinco);
            this.panel1.Controls.Add(this.btn_Cuatro);
            this.panel1.Controls.Add(this.btn_Tres);
            this.panel1.Controls.Add(this.btn_Dos);
            this.panel1.Controls.Add(this.btn_Cero);
            this.panel1.Controls.Add(this.btn_Uno);
            this.panel1.Controls.Add(this.btn_Punto);
            this.panel1.Controls.Add(this.btn_Igual);
            this.panel1.Location = new System.Drawing.Point(11, 234);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 210);
            this.panel1.TabIndex = 6;
            // 
            // btn_9
            // 
            this.btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_9.Location = new System.Drawing.Point(121, 13);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(37, 34);
            this.btn_9.TabIndex = 12;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.DetectarNumero);
            // 
            // btn_8
            // 
            this.btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_8.Location = new System.Drawing.Point(67, 13);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(37, 34);
            this.btn_8.TabIndex = 11;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.DetectarNumero);
            // 
            // btn_Siete
            // 
            this.btn_Siete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_Siete.Location = new System.Drawing.Point(12, 13);
            this.btn_Siete.Name = "btn_Siete";
            this.btn_Siete.Size = new System.Drawing.Size(37, 34);
            this.btn_Siete.TabIndex = 10;
            this.btn_Siete.Text = "7";
            this.btn_Siete.UseVisualStyleBackColor = true;
            this.btn_Siete.Click += new System.EventHandler(this.DetectarNumero);
            // 
            // btn_Seis
            // 
            this.btn_Seis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_Seis.Location = new System.Drawing.Point(121, 66);
            this.btn_Seis.Name = "btn_Seis";
            this.btn_Seis.Size = new System.Drawing.Size(37, 34);
            this.btn_Seis.TabIndex = 9;
            this.btn_Seis.Text = "6";
            this.btn_Seis.UseVisualStyleBackColor = true;
            this.btn_Seis.Click += new System.EventHandler(this.DetectarNumero);
            // 
            // btn_Cinco
            // 
            this.btn_Cinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_Cinco.Location = new System.Drawing.Point(67, 66);
            this.btn_Cinco.Name = "btn_Cinco";
            this.btn_Cinco.Size = new System.Drawing.Size(37, 34);
            this.btn_Cinco.TabIndex = 8;
            this.btn_Cinco.Text = "5";
            this.btn_Cinco.UseVisualStyleBackColor = true;
            this.btn_Cinco.Click += new System.EventHandler(this.DetectarNumero);
            // 
            // btn_Cuatro
            // 
            this.btn_Cuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_Cuatro.Location = new System.Drawing.Point(12, 66);
            this.btn_Cuatro.Name = "btn_Cuatro";
            this.btn_Cuatro.Size = new System.Drawing.Size(37, 34);
            this.btn_Cuatro.TabIndex = 7;
            this.btn_Cuatro.Text = "4";
            this.btn_Cuatro.UseVisualStyleBackColor = true;
            this.btn_Cuatro.Click += new System.EventHandler(this.DetectarNumero);
            // 
            // btn_Tres
            // 
            this.btn_Tres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_Tres.Location = new System.Drawing.Point(121, 115);
            this.btn_Tres.Name = "btn_Tres";
            this.btn_Tres.Size = new System.Drawing.Size(37, 34);
            this.btn_Tres.TabIndex = 6;
            this.btn_Tres.Text = "3";
            this.btn_Tres.UseVisualStyleBackColor = true;
            this.btn_Tres.Click += new System.EventHandler(this.DetectarNumero);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Mas);
            this.panel2.Controls.Add(this.btn_Menos);
            this.panel2.Controls.Add(this.btn_Divi);
            this.panel2.Controls.Add(this.btn_Multi);
            this.panel2.Location = new System.Drawing.Point(196, 234);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(64, 210);
            this.panel2.TabIndex = 7;
            // 
            // btn_Mas
            // 
            this.btn_Mas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_Mas.Location = new System.Drawing.Point(14, 164);
            this.btn_Mas.Name = "btn_Mas";
            this.btn_Mas.Size = new System.Drawing.Size(37, 34);
            this.btn_Mas.TabIndex = 16;
            this.btn_Mas.Tag = "+";
            this.btn_Mas.Text = "+";
            this.btn_Mas.UseVisualStyleBackColor = true;
            this.btn_Mas.Click += new System.EventHandler(this.DetectarOperacion);
            // 
            // btn_Menos
            // 
            this.btn_Menos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Menos.Location = new System.Drawing.Point(14, 115);
            this.btn_Menos.Name = "btn_Menos";
            this.btn_Menos.Size = new System.Drawing.Size(37, 34);
            this.btn_Menos.TabIndex = 15;
            this.btn_Menos.Tag = "-";
            this.btn_Menos.Text = "-";
            this.btn_Menos.UseVisualStyleBackColor = true;
            this.btn_Menos.Click += new System.EventHandler(this.DetectarOperacion);
            // 
            // btn_Divi
            // 
            this.btn_Divi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_Divi.Location = new System.Drawing.Point(14, 66);
            this.btn_Divi.Name = "btn_Divi";
            this.btn_Divi.Size = new System.Drawing.Size(37, 34);
            this.btn_Divi.TabIndex = 14;
            this.btn_Divi.Tag = "/";
            this.btn_Divi.Text = "/";
            this.btn_Divi.UseVisualStyleBackColor = true;
            this.btn_Divi.Click += new System.EventHandler(this.DetectarOperacion);
            // 
            // btn_Multi
            // 
            this.btn_Multi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_Multi.Location = new System.Drawing.Point(14, 13);
            this.btn_Multi.Name = "btn_Multi";
            this.btn_Multi.Size = new System.Drawing.Size(37, 34);
            this.btn_Multi.TabIndex = 13;
            this.btn_Multi.Tag = "*";
            this.btn_Multi.Text = "x";
            this.btn_Multi.UseVisualStyleBackColor = true;
            this.btn_Multi.Click += new System.EventHandler(this.DetectarOperacion);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_potencia);
            this.panel3.Controls.Add(this.btn_Clear);
            this.panel3.Controls.Add(this.btn_ClearALL);
            this.panel3.Controls.Add(this.btn_Factorial);
            this.panel3.Location = new System.Drawing.Point(12, 140);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(245, 62);
            this.panel3.TabIndex = 8;
            // 
            // btn_potencia
            // 
            this.btn_potencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_potencia.Location = new System.Drawing.Point(197, 13);
            this.btn_potencia.Name = "btn_potencia";
            this.btn_potencia.Size = new System.Drawing.Size(37, 34);
            this.btn_potencia.TabIndex = 20;
            this.btn_potencia.Tag = "²";
            this.btn_potencia.Text = "x²";
            this.btn_potencia.UseVisualStyleBackColor = true;
            this.btn_potencia.Click += new System.EventHandler(this.DetectarOperacion);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_Clear.Location = new System.Drawing.Point(135, 13);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(37, 34);
            this.btn_Clear.TabIndex = 19;
            this.btn_Clear.Text = "C";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_ClearALL
            // 
            this.btn_ClearALL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_ClearALL.Location = new System.Drawing.Point(73, 13);
            this.btn_ClearALL.Name = "btn_ClearALL";
            this.btn_ClearALL.Size = new System.Drawing.Size(37, 34);
            this.btn_ClearALL.TabIndex = 18;
            this.btn_ClearALL.Text = "CL";
            this.btn_ClearALL.UseVisualStyleBackColor = true;
            this.btn_ClearALL.Click += new System.EventHandler(this.btn_ClearALL_Click);
            // 
            // btn_Factorial
            // 
            this.btn_Factorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_Factorial.Location = new System.Drawing.Point(11, 13);
            this.btn_Factorial.Name = "btn_Factorial";
            this.btn_Factorial.Size = new System.Drawing.Size(37, 34);
            this.btn_Factorial.TabIndex = 17;
            this.btn_Factorial.Tag = "!";
            this.btn_Factorial.Text = "x!";
            this.btn_Factorial.UseVisualStyleBackColor = true;
            this.btn_Factorial.Click += new System.EventHandler(this.DetectarOperacion);
            // 
            // btn_Up
            // 
            this.btn_Up.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_Up.Location = new System.Drawing.Point(126, 75);
            this.btn_Up.Name = "btn_Up";
            this.btn_Up.Size = new System.Drawing.Size(18, 23);
            this.btn_Up.TabIndex = 17;
            this.btn_Up.Text = "↑";
            this.btn_Up.UseVisualStyleBackColor = true;
            // 
            // btn_Right
            // 
            this.btn_Right.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_Right.Location = new System.Drawing.Point(102, 95);
            this.btn_Right.Name = "btn_Right";
            this.btn_Right.Size = new System.Drawing.Size(18, 23);
            this.btn_Right.TabIndex = 18;
            this.btn_Right.Text = "←";
            this.btn_Right.UseVisualStyleBackColor = true;
            // 
            // btn_Down
            // 
            this.btn_Down.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_Down.Location = new System.Drawing.Point(126, 111);
            this.btn_Down.Name = "btn_Down";
            this.btn_Down.Size = new System.Drawing.Size(18, 23);
            this.btn_Down.TabIndex = 19;
            this.btn_Down.Text = "↓";
            this.btn_Down.UseVisualStyleBackColor = true;
            // 
            // btn_Left
            // 
            this.btn_Left.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_Left.Location = new System.Drawing.Point(150, 95);
            this.btn_Left.Name = "btn_Left";
            this.btn_Left.Size = new System.Drawing.Size(18, 23);
            this.btn_Left.TabIndex = 20;
            this.btn_Left.Text = "→";
            this.btn_Left.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(12, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 24);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Red;
            this.pictureBox2.Location = new System.Drawing.Point(192, 94);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 24);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 458);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Left);
            this.Controls.Add(this.btn_Down);
            this.Controls.Add(this.btn_Right);
            this.Controls.Add(this.btn_Up);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_Display);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Display;
        private System.Windows.Forms.Button btn_Cero;
        private System.Windows.Forms.Button btn_Punto;
        private System.Windows.Forms.Button btn_Igual;
        private System.Windows.Forms.Button btn_Uno;
        private System.Windows.Forms.Button btn_Dos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_Siete;
        private System.Windows.Forms.Button btn_Seis;
        private System.Windows.Forms.Button btn_Cinco;
        private System.Windows.Forms.Button btn_Cuatro;
        private System.Windows.Forms.Button btn_Tres;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Menos;
        private System.Windows.Forms.Button btn_Divi;
        private System.Windows.Forms.Button btn_Multi;
        private System.Windows.Forms.Button btn_Mas;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_potencia;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_ClearALL;
        private System.Windows.Forms.Button btn_Factorial;
        private System.Windows.Forms.Button btn_Up;
        private System.Windows.Forms.Button btn_Right;
        private System.Windows.Forms.Button btn_Down;
        private System.Windows.Forms.Button btn_Left;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}