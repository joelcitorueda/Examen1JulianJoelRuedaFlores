﻿namespace SistemaEmpleado.VISTA.PersonasVista
{
	partial class PersonasListarVista
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
			button4 = new Button();
			button3 = new Button();
			button2 = new Button();
			button1 = new Button();
			dataGridView1 = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// button4
			// 
			button4.Location = new Point(372, 395);
			button4.Name = "button4";
			button4.Size = new Size(105, 34);
			button4.TabIndex = 13;
			button4.Text = "ELIMINAR";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// button3
			// 
			button3.Location = new Point(250, 395);
			button3.Name = "button3";
			button3.Size = new Size(105, 34);
			button3.TabIndex = 12;
			button3.Text = "EDITAR";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button2
			// 
			button2.Location = new Point(129, 395);
			button2.Name = "button2";
			button2.Size = new Size(105, 34);
			button2.TabIndex = 11;
			button2.Text = "AGREGAR";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button1
			// 
			button1.DialogResult = DialogResult.OK;
			button1.Location = new Point(544, 395);
			button1.Name = "button1";
			button1.Size = new Size(115, 29);
			button1.TabIndex = 10;
			button1.Text = "SELECCIONAR";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(43, 22);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.Size = new Size(715, 353);
			dataGridView1.TabIndex = 9;
			// 
			// PersonasListarVista
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(dataGridView1);
			Name = "PersonasListarVista";
			Text = "PersonasListarVista";
			Load += PersonasListarVista_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Button button4;
		private Button button3;
		private Button button2;
		private Button button1;
		private DataGridView dataGridView1;
	}
}