using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinFormsTests.Models.ProgressTestModels;
using WinFormsTests.Models.TestModels;

namespace WinFormsTests.Models
{
	[Serializable]
	public class TestContainer
	{
		private List<ProgressTest> _passedTests;

		private List<Test> _tests;

		public IReadOnlyList<ProgressTest> PassedTests => _passedTests.AsReadOnly();

		public void AddPassedTest(ProgressTest progressTest) => _passedTests.Add(progressTest);

		public string GetStat()
		{
			var result = new StringBuilder();

			result.AppendLine("Статистика");
			result.AppendLine($"Всего тестов пройдено: {_passedTests.Count}");

			var groups = _passedTests.GroupBy(t => t.Test);

			result.AppendLine($"Результаты по тестам:");

			foreach (var @group in groups)
			{
				var statRight = group.Sum(t => t.GetResult().right);
				var statAll = group.Sum(t => t.GetResult().all);

				var percent = (double) statRight / statAll * 100d;

				percent = Math.Round(percent, 2);

				result.AppendLine($"Тест: {group.Key.Name}, средний результат - {percent}%");
			}

			return result.ToString();
		}

		public IReadOnlyList<Test> Tests => _tests.AsReadOnly();

		public void AddTest(Test test) => _tests.Add(test);

		public TestContainer()
		{
			_tests = new List<Test>();
			_passedTests = new List<ProgressTest>();
		}

		public void RemoveTest(int index) => _tests.RemoveAt(index);
	}
}
