
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace woc_app
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		bool mouseDown;
		private Point offset;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			
		}
		
		
		
		void ExitbutClick(object sender, EventArgs e)
		{
		
			MessageBoxButtons buttons = MessageBoxButtons.YesNo;
			DialogResult res = MessageBox.Show("Are you sure you want to close world of coding?", "Close app", buttons, MessageBoxIcon.Exclamation);
			if(res == DialogResult.Yes)
			{
				Application.Exit();
				
			}else
				MessageBox.Show("OK! Have fun!", "OK", MessageBoxButtons.OK);
		
			
		}
		
		void MinbutClick(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			Home.Hide();
			info.Hide();
			Loading.Show();
			timer1.Enabled = true;
			progressBar1.Show();
			label1.Show();
			
		}
		
		
		
	
		
		void HomenavClick(object sender, EventArgs e)
		{
			Home.Show();
			info.Hide();
		}
		
		void InfonavClick(object sender, EventArgs e)
		{
			Home.Hide();
			info.Show();
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			progressBar1.Value += 2;
			label1.Text = progressBar1.Value.ToString();
			if(progressBar1.Value == 100)
			{
				timer1.Enabled = false;
				progressBar1.Hide();
				Loading.Hide();
				Home.Show();
				info.Hide();
				label1.Hide();
			}
		}
		// custom bar movement start
		private void mouseDownEvent(object sender, MouseEventArgs e)
		{
			offset.X = e.X;
			offset.Y = e.Y;
			mouseDown = true;
			
		}
		private void mouseMoveEvent(object sender, MouseEventArgs e)
		{
			if(mouseDown == true)
			{
				Point currectScreenPos = PointToScreen(e.Location);
				Location = new Point(currectScreenPos.X - offset.X, currectScreenPos.Y - offset.Y);
			}
		}
		
		
		private void mouseUpEvent(object sender, MouseEventArgs e)
		{
			mouseDown = false;
		}
	 	// custom bar movement end
		
		void PrefClick(object sender, EventArgs e)
		{
			
		}
		
		void pref_hov(object sender, EventArgs e)
		{
			Pref.ForeColor = System.Drawing.Color.Red;
		}
		
		void pref_bye(object sender, EventArgs e)
		{
			
			Pref.ForeColor = System.Drawing.ColorTranslator.FromHtml("#8080ff");
		}
		
		void inf_double(object sender, EventArgs e)
		{
			infonav.ForeColor = System.Drawing.Color.Purple;
		}
		
		void inf_hov(object sender, EventArgs e)
		{
			infonav.ForeColor = System.Drawing.Color.Red;
		}
		
		void inf_bye(object sender, EventArgs e)
		{
			infonav.ForeColor = System.Drawing.ColorTranslator.FromHtml("#8080ff");
		}
		
		void pref_mouseDown(object sender, MouseEventArgs e)
		{
			Pref.ForeColor = System.Drawing.Color.Yellow;
		}
		
		void pref_event_mouseUp(object sender, MouseEventArgs e)
		{
			Pref.ForeColor = System.Drawing.ColorTranslator.FromHtml("#8080ff");
		}
		
		void Inf_eventMouseDown(object sender, MouseEventArgs e)
		{
			infonav.ForeColor = System.Drawing.Color.Yellow;
		}
		
		void inf_EventMOUSEUP(object sender, MouseEventArgs e)
		{
			infonav.ForeColor = System.Drawing.ColorTranslator.FromHtml("#8080ff");
		}
		
		void home_EventmouseHov(object sender, EventArgs e)
		{
			Homenav.ForeColor = System.Drawing.Color.Red;
		}
		
		void home_EventmouseLev(object sender, EventArgs e)
		{
			Homenav.ForeColor = System.Drawing.ColorTranslator.FromHtml("#8080ff");
		}
		
		void home_EventmouseDown(object sender, MouseEventArgs e)
		{
			try
			{
				Homenav.ForeColor = System.Drawing.Color.Yellow;
			}catch
			{
				MessageBox.Show("Error: Line 178, an error or crash occured!", "BUTTON ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		
		void home_EventmouseUp(object sender, MouseEventArgs e)
		{
			Homenav.ForeColor = System.Drawing.ColorTranslator.FromHtml("#8080ff");
		}
	}
}
/*
 
 	Home.Show(); //OwO
	info.Hide();
 */
