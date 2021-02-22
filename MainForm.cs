
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
			DialogResult res = MessageBox.Show("Are you sure you want to close world of coding?", "Close app", buttons);
			if(res == DialogResult.Yes)
			{
				Close();
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
	}
}
/*
 	Home.Show();
	info.Hide();
 */
