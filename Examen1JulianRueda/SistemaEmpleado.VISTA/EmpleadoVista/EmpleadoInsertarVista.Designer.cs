﻿namespace SistemaEmpleado.VISTA.EmpleadoVista
{
	partial class EmpleadoInsertarVista
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
			button1 = new Button();
			textBox1 = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			button2 = new Button();
			button3 = new Button();
			textBox2 = new TextBox();
			textBox3 = new TextBox();
			textBox4 = new TextBox();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(186, 312);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 0;
			button1.Text = "GUARDAR";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(275, 78);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(206, 27);
			textBox1.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(90, 81);
			label1.Name = "label1";
			label1.Size = new Size(93, 20);
			label1.TabIndex = 2;
			label1.Text = "ID PERSONA";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(90, 129);
			label2.Name = "label2";
			label2.Size = new Size(61, 20);
			label2.TabIndex = 3;
			label2.Text = "PUESTO";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(90, 179);
			label3.Name = "label3";
			label3.Size = new Size(68, 20);
			label3.TabIndex = 4;
			label3.Text = "SALARIO";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(90, 224);
			label4.Name = "label4";
			label4.Size = new Size(190, 20);
			label4.TabIndex = 5;
			label4.Text = "FECHA DE CONTRATACION";
			// 
			// button2
			// 
			button2.Location = new Point(341, 312);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 6;
			button2.Text = "CANCELAR";
			button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			button3.Location = new Point(508, 76);
			button3.Name = "button3";
			button3.Size = new Size(128, 29);
			button3.TabIndex = 7;
			button3.Text = "SELECCIONAR";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(275, 122);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(206, 27);
			textBox2.TabIndex = 8;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(293, 172);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(206, 27);
			textBox3.TabIndex = 9;
			// 
			// textBox4
			// 
			textBox4.Location = new Point(293, 217);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(206, 27);
			textBox4.TabIndex = 10;
			// 
			// EmpleadoInsertarVista
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(695, 412);
			Controls.Add(textBox4);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(textBox1);
			Controls.Add(button1);
			Name = "EmpleadoInsertarVista";
			Text = "EmpleadoInsertarVista";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private TextBox textBox1;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Button button2;
		private Button button3;
		private TextBox textBox2;
		private TextBox textBox3;
		private TextBox textBox4;
	}
}