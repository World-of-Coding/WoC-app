/*
 * Created by SharpDevelop.
 * User: aadi_
 * Date: 2/18/2021
 * Time: 9:27 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace woc_app
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.minbut = new System.Windows.Forms.Button();
			this.Exitbut = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(42)))));
			this.panel1.Controls.Add(this.minbut);
			this.panel1.Controls.Add(this.Exitbut);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(889, 539);
			this.panel1.TabIndex = 0;
			// 
			// minbut
			// 
			this.minbut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.minbut.Location = new System.Drawing.Point(765, 12);
			this.minbut.Name = "minbut";
			this.minbut.Size = new System.Drawing.Size(57, 22);
			this.minbut.TabIndex = 10;
			this.minbut.Text = "Minimize";
			this.minbut.UseVisualStyleBackColor = false;
			this.minbut.Click += new System.EventHandler(this.MinbutClick);
			// 
			// Exitbut
			// 
			this.Exitbut.BackColor = System.Drawing.Color.Red;
			this.Exitbut.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Exitbut.Location = new System.Drawing.Point(820, 12);
			this.Exitbut.Name = "Exitbut";
			this.Exitbut.Size = new System.Drawing.Size(54, 22);
			this.Exitbut.TabIndex = 9;
			this.Exitbut.Text = "Exit";
			this.Exitbut.UseVisualStyleBackColor = false;
			this.Exitbut.Click += new System.EventHandler(this.ExitbutClick);
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Blue;
			this.pictureBox2.Location = new System.Drawing.Point(0, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(876, 34);
			this.pictureBox2.TabIndex = 8;
			this.pictureBox2.TabStop = false;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(102)))), ((int)(((byte)(190)))));
			this.label8.Location = new System.Drawing.Point(26, 248);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(431, 49);
			this.label8.TabIndex = 7;
			this.label8.Text = "WORLD /OF/ CODING";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(102)))), ((int)(((byte)(190)))));
			this.label7.Location = new System.Drawing.Point(26, 199);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(431, 49);
			this.label7.TabIndex = 6;
			this.label7.Text = "WORLD /OF/ CODING";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(102)))), ((int)(((byte)(190)))));
			this.label6.Location = new System.Drawing.Point(26, 150);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(431, 49);
			this.label6.TabIndex = 5;
			this.label6.Text = "WORLD /OF/ CODING";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(102)))), ((int)(((byte)(190)))));
			this.label5.Location = new System.Drawing.Point(26, 150);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(431, 49);
			this.label5.TabIndex = 5;
			this.label5.Text = "WORLD /OF/ CODING";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(102)))), ((int)(((byte)(190)))));
			this.label4.Location = new System.Drawing.Point(26, 101);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(431, 49);
			this.label4.TabIndex = 4;
			this.label4.Text = "WORLD /OF/ CODING";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(102)))), ((int)(((byte)(190)))));
			this.label3.Location = new System.Drawing.Point(26, 52);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(431, 49);
			this.label3.TabIndex = 3;
			this.label3.Text = "WORLD /OF/ CODING";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = null;
			this.pictureBox1.Location = new System.Drawing.Point(471, 40);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(392, 235);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(111)))), ((int)(((byte)(99)))));
			this.label2.Location = new System.Drawing.Point(490, 344);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(372, 201);
			this.label2.TabIndex = 1;
			this.label2.Text = "Hey we are WoC the coding community of discord For newer and old coders alike!";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(180)))), ((int)(((byte)(169)))));
			this.label1.Location = new System.Drawing.Point(476, 271);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(401, 65);
			this.label1.TabIndex = 0;
			this.label1.Text = "Who are we?";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(889, 539);
			this.Controls.Add(this.panel1);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "World of Coding app";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button minbut;
		private System.Windows.Forms.Button Exitbut;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
	}
}
