using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsTests.Models.TestModels;

namespace WinFormsTests.Forms
{
	public partial class PassQuestionForm : Form
	{
		public PassQuestionForm(OpenQuestion question)
		{
			InitializeComponent();
			
			Question.Text = question.Text;
		}

		public string Ans = null;

		private void Pass_Click(object sender, EventArgs e)
		{
			Ans = Answer.Text;
			Close();
		}
	}
}
