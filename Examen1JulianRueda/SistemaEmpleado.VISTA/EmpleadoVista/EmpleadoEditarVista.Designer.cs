namespace SistemaEmpleado.VISTA.EmpleadoVista
{
	partial class EmpleadoEditarVista
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
			textBox4 = new TextBox();
			textBox3 = new TextBox();
			textBox2 = new TextBox();
			button3 = new Button();
			button2 = new Button();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			textBox1 = new TextBox();
			button1 = new Button();
			SuspendLayout();
			// 
			// textBox4
			// 
			textBox4.Location = new Point(246, 195);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(206, 27);
			textBox4.TabIndex = 21;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(246, 150);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(206, 27);
			textBox3.TabIndex = 20;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(228, 100);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(206, 27);
			textBox2.TabIndex = 19;
			// 
			// button3
			// 
			button3.Location = new Point(461, 54);
			button3.Name = "button3";
			button3.Size = new Size(128, 29);
			button3.TabIndex = 18;
			button3.Text = "SELECCIONAR";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button2
			// 
			button2.Location = new Point(294, 290);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 17;
			button2.Text = "CANCELAR";
			button2.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(43, 202);
			label4.Name = "label4";
			label4.Size = new Size(190, 20);
			label4.TabIndex = 16;
			label4.Text = "FECHA DE CONTRATACION";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(43, 157);
			label3.Name = "label3";
			label3.Size = new Size(68, 20);
			label3.TabIndex = 15;
			label3.Text = "SALARIO";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(43, 107);
			label2.Name = "label2";
			label2.Size = new Size(61, 20);
			label2.TabIndex = 14;
			label2.Text = "PUESTO";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(43, 59);
			label1.Name = "label1";
			label1.Size = new Size(93, 20);
			label1.TabIndex = 13;
			label1.Text = "ID PERSONA";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(228, 56);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(206, 27);
			textBox1.TabIndex = 12;
			// 
			// button1
			// 
			button1.Location = new Point(139, 290);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 11;
			button1.Text = "GUARDAR";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// EmpleadoEditarVista
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(630, 376);
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
			Name = "EmpleadoEditarVista";
			Text = "EmpleadoEditarVista";
			Load += EmpleadoEditarVista_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox4;
		private TextBox textBox3;
		private TextBox textBox2;
		private Button button3;
		private Button button2;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
		private TextBox textBox1;
		private Button button1;
	}
}