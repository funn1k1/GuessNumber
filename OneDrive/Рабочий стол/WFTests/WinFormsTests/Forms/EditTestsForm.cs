using System;
using System.Windows.Forms;

namespace WinFormsTests.Forms
{
	public partial class EditTestsForm : Form
	{
		public EditTestsForm()
		{
			InitializeComponent();

			PrintListBox();
		}

		private void PrintListBox()
		{
			TestList.Items.Clear();

			foreach (var test in ProgramData.TestContainer.Tests)
				TestList.Items.Add(test.Name);

			Edit.Enabled = false;
			DeleteTest.Enabled = false;
		}

		private void TestList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (TestList.SelectedIndex == -1)
			{
				Edit.Enabled = false;
				DeleteTest.Enabled = false;
			}
			else
			{
				Edit.Enabled = true;
				DeleteTest.Enabled = true;
			}
		}

		private void Edit_Click(object sender, EventArgs e)
		{
			var test = ProgramData.TestContainer.Tests[TestList.SelectedIndex];

			var f = new AddTestForm(test, true);
			f.ShowDialog();

			PrintListBox();
		}

		private void DeleteTest_Click(object sender, EventArgs e)
		{
			ProgramData.TestContainer.RemoveTest(TestList.SelectedIndex);

			PrintListBox();
		}
	}
}
