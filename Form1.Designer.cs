namespace gif_animado
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
            valor1 = new TextBox();
            valor2 = new TextBox();
            valor3 = new TextBox();
            n1 = new TextBox();
            n2 = new TextBox();
            n3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 28);
            label1.Name = "label1";
            label1.Size = new Size(369, 25);
            label1.TabIndex = 0;
            label1.Text = "Ordenar 3 números de mayor a menor";
            // 
            // valor1
            // 
            valor1.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            valor1.Location = new Point(24, 99);
            valor1.Name = "valor1";
            valor1.Size = new Size(95, 33);
            valor1.TabIndex = 1;
            // 
            // valor2
            // 
            valor2.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            valor2.Location = new Point(142, 99);
            valor2.Name = "valor2";
            valor2.Size = new Size(95, 33);
            valor2.TabIndex = 2;
            // 
            // valor3
            // 
            valor3.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            valor3.Location = new Point(263, 99);
            valor3.Name = "valor3";
            valor3.Size = new Size(95, 33);
            valor3.TabIndex = 3;
            // 
            // n1
            // 
            n1.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            n1.Location = new Point(24, 252);
            n1.Name = "n1";
            n1.Size = new Size(95, 33);
            n1.TabIndex = 4;
            // 
            // n2
            // 
            n2.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            n2.Location = new Point(142, 252);
            n2.Name = "n2";
            n2.Size = new Size(95, 33);
            n2.TabIndex = 5;
            // 
            // n3
            // 
            n3.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            n3.Location = new Point(263, 252);
            n3.Name = "n3";
            n3.Size = new Size(95, 33);
            n3.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 178);
            button1.Name = "button1";
            button1.Size = new Size(115, 37);
            button1.TabIndex = 7;
            button1.Text = "ORDENAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(133, 178);
            button2.Name = "button2";
            button2.Size = new Size(116, 37);
            button2.TabIndex = 8;
            button2.Text = "BORRAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(255, 178);
            button3.Name = "button3";
            button3.Size = new Size(105, 37);
            button3.TabIndex = 9;
            button3.Text = "SALIR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(58, 135);
            label2.Name = "label2";
            label2.Size = new Size(25, 25);
            label2.TabIndex = 10;
            label2.Text = "A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(175, 135);
            label3.Name = "label3";
            label3.Size = new Size(24, 25);
            label3.TabIndex = 11;
            label3.Text = "B";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(302, 135);
            label4.Name = "label4";
            label4.Size = new Size(25, 25);
            label4.TabIndex = 12;
            label4.Text = "C";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 325);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(n3);
            Controls.Add(n2);
            Controls.Add(n1);
            Controls.Add(valor3);
            Controls.Add(valor2);
            Controls.Add(valor1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Practica 17";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox valor1;
        private TextBox valor2;
        private TextBox valor3;
        private TextBox n1;
        private TextBox n2;
        private TextBox n3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}