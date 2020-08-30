using System;
using System.Windows.Forms;
using WinFormsTests.Models.TestModels;

namespace WinFormsTests.Forms
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

			ProgramData.LoadData();
		}

		private void AddTest_Click(object sender, EventArgs e)
		{
			var test = new Test(null, null);

			var f = new AddTestForm(test);
			f.ShowDialog();
		}

		private void PassTest_Click(object sender, EventArgs e) => (new PassTestForm()).ShowDialog();

		private void EditTests_Click(object sender, EventArgs e) => (new EditTestsForm()).ShowDialog();
	}
}
