﻿namespace SistemaEmpleado.VISTA.PersonasVista
{
	partial class PersonasEditarVsita
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
			button2 = new Button();
			textBox2 = new TextBox();
			label3 = new Label();
			label2 = new Label();
			textBox1 = new TextBox();
			label1 = new Label();
			button1 = new Button();
			SuspendLayout();
			// 
			// button2
			// 
			button2.Location = new Point(255, 200);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 13;
			button2.Text = "CANCELAR";
			button2.UseVisualStyleBackColor = true;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(177, 116);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(238, 27);
			textBox2.TabIndex = 12;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(56, 209);
			label3.Name = "label3";
			label3.Size = new Size(0, 20);
			label3.TabIndex = 11;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(56, 123);
			label2.Name = "label2";
			label2.Size = new Size(75, 20);
			label2.TabIndex = 10;
			label2.Text = "APELLIDO";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(177, 55);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(238, 27);
			textBox1.TabIndex = 9;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(56, 58);
			label1.Name = "label1";
			label1.Size = new Size(70, 20);
			label1.TabIndex = 8;
			label1.Text = "NOMBRE";
			// 
			// button1
			// 
			button1.Location = new Point(89, 200);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 7;
			button1.Text = "GUARDAR";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// PersonasEditarVsita
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(507, 272);
			Controls.Add(button2);
			Controls.Add(textBox2);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Controls.Add(button1);
			Name = "PersonasEditarVsita";
			Text = "PersonasEditarVsita";
			Load += PersonasEditarVsita_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button2;
		private TextBox textBox2;
		private Label label3;
		private Label label2;
		private TextBox textBox1;
		private Label label1;
		private Button button1;
	}
}