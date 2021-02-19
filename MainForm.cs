
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
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
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
	}
}
