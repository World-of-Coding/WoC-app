
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.Space = new System.Windows.Forms.Panel();
			this.Pref = new System.Windows.Forms.Label();
			this.Minbut = new System.Windows.Forms.PictureBox();
			this.Exitbut = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.Loading = new woc_app.loading();
			this.infonav = new System.Windows.Forms.Label();
			this.info = new woc_app.Info();
			this.Homenav = new System.Windows.Forms.Label();
			this.Home = new woc_app.Home();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.Space.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Minbut)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Exitbut)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// Space
			// 
			this.Space.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(42)))));
			this.Space.Controls.Add(this.Pref);
			this.Space.Controls.Add(this.Minbut);
			this.Space.Controls.Add(this.Exitbut);
			this.Space.Controls.Add(this.label1);
			this.Space.Controls.Add(this.progressBar1);
			this.Space.Controls.Add(this.Loading);
			this.Space.Controls.Add(this.infonav);
			this.Space.Controls.Add(this.info);
			this.Space.Controls.Add(this.Homenav);
			this.Space.Controls.Add(this.Home);
			this.Space.Controls.Add(this.pictureBox2);
			this.Space.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Space.Location = new System.Drawing.Point(0, 0);
			this.Space.Name = "Space";
			this.Space.Size = new System.Drawing.Size(889, 539);
			this.Space.TabIndex = 0;
			// 
			// Pref
			// 
			this.Pref.BackColor = System.Drawing.Color.Blue;
			this.Pref.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Pref.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.Pref.Location = new System.Drawing.Point(156, 5);
			this.Pref.Name = "Pref";
			this.Pref.Size = new System.Drawing.Size(125, 26);
			this.Pref.TabIndex = 20;
			this.Pref.Text = "Preferences ";
			this.Pref.Click += new System.EventHandler(this.PrefClick);
			this.Pref.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pref_mouseDown);
			this.Pref.MouseLeave += new System.EventHandler(this.pref_bye);
			this.Pref.MouseHover += new System.EventHandler(this.pref_hov);
			this.Pref.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pref_event_mouseUp);
			// 
			// Minbut
			// 
			this.Minbut.BackColor = System.Drawing.Color.Blue;
			this.Minbut.Image = ((System.Drawing.Image)(resources.GetObject("Minbut.Image")));
			this.Minbut.Location = new System.Drawing.Point(825, 9);
			this.Minbut.Name = "Minbut";
			this.Minbut.Size = new System.Drawing.Size(23, 21);
			this.Minbut.TabIndex = 19;
			this.Minbut.TabStop = false;
			this.Minbut.Click += new System.EventHandler(this.MinbutClick);
			// 
			// Exitbut
			// 
			this.Exitbut.BackColor = System.Drawing.Color.Blue;
			this.Exitbut.Image = ((System.Drawing.Image)(resources.GetObject("Exitbut.Image")));
			this.Exitbut.Location = new System.Drawing.Point(854, 8);
			this.Exitbut.Name = "Exitbut";
			this.Exitbut.Size = new System.Drawing.Size(23, 21);
			this.Exitbut.TabIndex = 18;
			this.Exitbut.TabStop = false;
			this.Exitbut.Click += new System.EventHandler(this.ExitbutClick);
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(406, 184);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 17;
			this.label1.Text = "Starting...";
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(332, 226);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(247, 31);
			this.progressBar1.TabIndex = 15;
			// 
			// Loading
			// 
			this.Loading.Location = new System.Drawing.Point(0, 32);
			this.Loading.Name = "Loading";
			this.Loading.Size = new System.Drawing.Size(889, 510);
			this.Loading.TabIndex = 16;
			// 
			// infonav
			// 
			this.infonav.BackColor = System.Drawing.Color.Blue;
			this.infonav.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.infonav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.infonav.Location = new System.Drawing.Point(105, 5);
			this.infonav.Name = "infonav";
			this.infonav.Size = new System.Drawing.Size(45, 26);
			this.infonav.TabIndex = 14;
			this.infonav.Text = "Info";
			this.infonav.Click += new System.EventHandler(this.InfonavClick);
			this.infonav.DoubleClick += new System.EventHandler(this.inf_double);
			this.infonav.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Inf_eventMouseDown);
			this.infonav.MouseLeave += new System.EventHandler(this.inf_bye);
			this.infonav.MouseHover += new System.EventHandler(this.inf_hov);
			this.infonav.MouseUp += new System.Windows.Forms.MouseEventHandler(this.inf_EventMOUSEUP);
			// 
			// info
			// 
			this.info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(42)))));
			this.info.Location = new System.Drawing.Point(0, 32);
			this.info.Name = "info";
			this.info.Size = new System.Drawing.Size(889, 508);
			this.info.TabIndex = 13;
			// 
			// Homenav
			// 
			this.Homenav.BackColor = System.Drawing.Color.Blue;
			this.Homenav.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Homenav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.Homenav.Location = new System.Drawing.Point(35, 5);
			this.Homenav.Name = "Homenav";
			this.Homenav.Size = new System.Drawing.Size(64, 26);
			this.Homenav.TabIndex = 12;
			this.Homenav.Text = "Home";
			this.Homenav.Click += new System.EventHandler(this.HomenavClick);
			this.Homenav.MouseDown += new System.Windows.Forms.MouseEventHandler(this.home_EventmouseDown);
			this.Homenav.MouseLeave += new System.EventHandler(this.home_EventmouseLev);
			this.Homenav.MouseHover += new System.EventHandler(this.home_EventmouseHov);
			this.Homenav.MouseUp += new System.Windows.Forms.MouseEventHandler(this.home_EventmouseUp);
			// 
			// Home
			// 
			this.Home.AutoScroll = true;
			this.Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(42)))));
			this.Home.Location = new System.Drawing.Point(0, 35);
			this.Home.Name = "Home";
			this.Home.Size = new System.Drawing.Size(889, 508);
			this.Home.TabIndex = 11;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Blue;
			this.pictureBox2.Location = new System.Drawing.Point(0, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(889, 34);
			this.pictureBox2.TabIndex = 8;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDownEvent);
			this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMoveEvent);
			this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUpEvent);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(889, 539);
			this.Controls.Add(this.Space);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "World of Coding app";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.Space.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Minbut)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Exitbut)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label Pref;
		private System.Windows.Forms.PictureBox Minbut;
		private System.Windows.Forms.Label label1;
		private woc_app.loading Loading;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label infonav;
		private woc_app.Info info;
		private System.Windows.Forms.Label Homenav;
		private woc_app.Home Home;
		private System.Windows.Forms.PictureBox Exitbut;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Panel Space;
	}
}
