namespace Laboratorio_02_SMN_2_ACT_1._1
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Rlbl = new Label();
            txt2 = new TextBox();
            txt1 = new TextBox();
            txt3 = new TextBox();
            Calcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(230, 43);
            label1.Name = "label1";
            label1.Size = new Size(176, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el primer numero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 80);
            label2.Name = "label2";
            label2.Size = new Size(189, 20);
            label2.TabIndex = 1;
            label2.Text = "Ingrese el segundo numero";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(230, 113);
            label3.Name = "label3";
            label3.Size = new Size(170, 20);
            label3.TabIndex = 2;
            label3.Text = "Ingrese el tercer numero";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(230, 212);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 3;
            label4.Text = "Respuesta";
            // 
            // Rlbl
            // 
            Rlbl.AutoSize = true;
            Rlbl.Location = new Point(484, 212);
            Rlbl.Name = "Rlbl";
            Rlbl.Size = new Size(17, 20);
            Rlbl.TabIndex = 4;
            Rlbl.Text = "0";
            // 
            // txt2
            // 
            txt2.Location = new Point(448, 73);
            txt2.Name = "txt2";
            txt2.Size = new Size(125, 27);
            txt2.TabIndex = 5;
            // 
            // txt1
            // 
            txt1.Location = new Point(448, 40);
            txt1.Name = "txt1";
            txt1.Size = new Size(125, 27);
            txt1.TabIndex = 6;
            txt1.TextChanged += Numero1_TextChanged;
            // 
            // txt3
            // 
            txt3.Location = new Point(448, 106);
            txt3.Name = "txt3";
            txt3.Size = new Size(125, 27);
            txt3.TabIndex = 7;
            // 
            // Calcular
            // 
            Calcular.Location = new Point(353, 319);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(94, 29);
            Calcular.TabIndex = 8;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Calcular);
            Controls.Add(txt3);
            Controls.Add(txt1);
            Controls.Add(txt2);
            Controls.Add(Rlbl);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label Rlbl;
        private TextBox txt2;
        private TextBox txt1;
        private TextBox txt3;
        private Button Calcular;
    }
}