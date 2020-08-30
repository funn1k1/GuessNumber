using System;
using System.Collections.Generic;
using WinFormsTests.Models.TestModels;

namespace WinFormsTests.Models.ProgressTestModels
{
   [Serializable]
    public class ProgressTest
    {
        private List<ProgressSubTest> _progressSubTests;

        public IReadOnlyList<ProgressSubTest> ProgressSubTests => _progressSubTests.AsReadOnly();

        public Test Test { get; }

        public bool SubTestPassed => CurrentSubTest == _progressSubTests.Count; // все подтесты пройдены тогда, когда номер текущего подтеста выходит за границы массива
        
        public int CurrentSubTest { get; private set; }

        public ProgressTest(Test test)
        {
            _progressSubTests = new List<ProgressSubTest>();
            Test = test;
            CurrentSubTest = 0;
        }

        public ProgressSubTest GetSubTest()
        {
            if (CurrentSubTest == Test.SubTests.Count)
                return null;

            return new ProgressSubTest(Test.SubTests[CurrentSubTest]);
        }

        public bool CheckSubTest(ProgressSubTest progressSubTest)
        {
            if (!progressSubTest.SubTestPassed)
                return false;

            _progressSubTests.Add(progressSubTest);
            CurrentSubTest++;
            return true;
        }
        
        public (int right, int all) GetResult() // метод который возвращает результат в виде ValueTuple
        {
            var right = 0;
            var all = 0;

            foreach (var progressSubTest in _progressSubTests)
            {
                var (r, a) = progressSubTest.GetResult();

                right += r;
                all += a;
            }

            return (right, all);
        }

        public override string ToString()
        {
            var (right, all) = GetResult();
            
            var percent = (double) right / all * 100d;
            percent = Math.Round(percent, 2);

            return $"Тест {Test.Name} - {percent}% правильно";
        }
    }
}