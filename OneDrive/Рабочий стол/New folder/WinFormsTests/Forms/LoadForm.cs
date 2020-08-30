using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace WinFormsTests.Forms
{
	public partial class LoadForm : Form
	{
		public LoadForm()
		{
			InitializeComponent();
		}

		private void LoadForm_Load(object sender, EventArgs e)
		{
			Back.RunWorkerAsync();
			Back.RunWorkerCompleted += (o, args) =>
			{
				Hide();

				(new MainForm()).ShowDialog();

				Close();
			};
		}

		private void Back_DoWork(object sender, DoWorkEventArgs e)
		{
			var val = 0;

			while (val < 100)
			{
				BeginInvoke(new Action(() => Progress.Value = val));

				Thread.Sleep(500);

				val += 30;
			}
			
		}
	}
}
