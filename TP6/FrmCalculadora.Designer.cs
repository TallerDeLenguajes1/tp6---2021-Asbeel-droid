
namespace TP6
{
    partial class FrmCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPantalla = new System.Windows.Forms.TextBox();
            this.btnC = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPantalla
            // 
            this.txtPantalla.Location = new System.Drawing.Point(29, 26);
            this.txtPantalla.MaxLength = 20;
            this.txtPantalla.Name = "txtPantalla";
            this.txtPantalla.ReadOnly = true;
            this.txtPantalla.Size = new System.Drawing.Size(177, 25);
            this.txtPantalla.TabIndex = 0;
            this.txtPantalla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPantalla_KeyPress);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(212, 26);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(55, 25);
            this.btnC.TabIndex = 1;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(29, 255);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(55, 60);
            this.btn0.TabIndex = 2;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(29, 189);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(55, 60);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(90, 189);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(55, 60);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(151, 189);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(55, 60);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(29, 123);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(55, 60);
            this.btn4.TabIndex = 6;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(90, 123);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(55, 60);
            this.btn5.TabIndex = 7;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(151, 123);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(55, 60);
            this.btn6.TabIndex = 8;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(29, 57);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(55, 60);
            this.btn7.TabIndex = 9;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(90, 57);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(55, 60);
            this.btn8.TabIndex = 10;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(151, 57);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(55, 60);
            this.btn9.TabIndex = 11;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnPunto
            // 
            this.btnPunto.Location = new System.Drawing.Point(90, 255);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(55, 60);
            this.btnPunto.TabIndex = 12;
            this.btnPunto.Text = ",";
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(212, 57);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(55, 60);
            this.btnSuma.TabIndex = 13;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.agregarOperador);
            // 
            // btnResta
            // 
            this.btnResta.Location = new System.Drawing.Point(212, 123);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(55, 60);
            this.btnResta.TabIndex = 14;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.ClientSizeChanged += new System.EventHandler(this.agregarOperador);
            this.btnResta.Click += new System.EventHandler(this.agregarOperador);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.Location = new System.Drawing.Point(212, 189);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(55, 60);
            this.btnMultiplicacion.TabIndex = 15;
            this.btnMultiplicacion.Text = "*";
            this.btnMultiplicacion.UseVisualStyleBackColor = true;
            this.btnMultiplicacion.Click += new System.EventHandler(this.agregarOperador);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(212, 255);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(55, 60);
            this.btnDivision.TabIndex = 16;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.agregarOperador);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(151, 255);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(55, 60);
            this.btnIgual.TabIndex = 17;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // FrmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 332);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.txtPantalla);
            this.Name = "FrmCalculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPantalla;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnIgual;
    }
}

