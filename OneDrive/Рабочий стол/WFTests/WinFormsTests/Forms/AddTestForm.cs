using System;
using System.Windows.Forms;
using WinFormsTests.Models.TestModels;

namespace WinFormsTests.Forms
{
	public partial class AddTestForm : Form
	{
		public AddTestForm(Test test, bool isEdit = false)
		{
			InitializeComponent();

			_isEdit = isEdit;

			_test = test;

			if (_isEdit)
			{
				TestName.Text = _test.Name;
				if (_test.Time != null)
					TestTime.Value = (int)_test.Time.Value.TotalMinutes;
			}

			PrintTree();
		}

		private Test _test;

		private bool _isEdit;

		public void PrintTree()
		{
			TestTree.Nodes.Clear();

			foreach (var subTest in _test.SubTests)
			{
				var node = TestTree.Nodes.Add(subTest.Name);

				foreach (var question in subTest.Questions)
					node.Nodes.Add(question.Text);
			}

			AddQuestion.Enabled = false;
			DeleteNode.Enabled = false;
			DeleteNode.Text = "Удалить";
		}

		private void AddSubTest_Click(object sender, EventArgs e)
		{
			_test.AddSubTest(new SubTest(SubTestName.Text));
			PrintTree();
		}

		private void AddQuestion_Click(object sender, EventArgs e)
		{
			var node = TestTree.SelectedNode;

			var index = TestTree.Nodes.IndexOf(node);

			while (true)
			{
				var f = new CreatingQuestionForm();
				f.ShowDialog();
				var question = f.Question;

				if (question == null)
					return;

				_test.SubTests[index].AddQuestion(question);

				PrintTree();
			}
		}

		private void SaveTest_Click(object sender, EventArgs e)
		{
			_test.Name = TestName.Text;
			_test.Time = TestTime.Value == 0 ? (TimeSpan?)null : TimeSpan.FromMinutes((int)TestTime.Value);

			if (!_isEdit)
				ProgramData.TestContainer.AddTest(_test);

			ProgramData.SaveData();

			Close();
		}

		private void TestTree_AfterSelect(object sender, TreeViewEventArgs e)
		{
			if (e.Node.Parent == null)
			{
				AddQuestion.Enabled = true;
				DeleteNode.Enabled = true;
				DeleteNode.Text = "Удалить выбранный подтест";
			}
			else
			{
				AddQuestion.Enabled = false;
				DeleteNode.Enabled = true;
				DeleteNode.Text = "Удалить выбранный вопрос";
			}
		}

		private void DeleteNode_Click(object sender, EventArgs e)
		{
			var node = TestTree.SelectedNode;

			if (node == null)
			{
				MessageBox.Show("Ошибка");
				return;
			}

			if (node.Parent != null)
			{
				var subTestIndex = TestTree.Nodes.IndexOf(node.Parent);

				var subTest = _test.SubTests[subTestIndex];

				var questionIndex = TestTree.Nodes[subTestIndex].Nodes.IndexOf(node);

				subTest.RemoveQuestion(questionIndex);
			}
			else
			{
				var subTestIndex = TestTree.Nodes.IndexOf(node);

				_test.RemoveSubTest(subTestIndex);
			}

			PrintTree();
		}
	}
}
