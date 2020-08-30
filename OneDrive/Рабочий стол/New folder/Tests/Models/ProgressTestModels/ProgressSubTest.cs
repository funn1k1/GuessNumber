using System;
using System.Collections.Generic;
using WinFormsTests.Models.TestModels;

namespace WinFormsTests.Models.ProgressTestModels
{
    public class ProgressSubTest
    {
        private List<ProgressSubSubTest> _progressSubSubTests;

        public IReadOnlyList<ProgressSubSubTest> ProgressSubSubTests => _progressSubSubTests.AsReadOnly();

        public SubTest SubTest { get; }

        public bool SubTestPassed => CurrentSubSubTest == _progressSubSubTests.Count;
        
        public int CurrentSubSubTest { get; private set; }

        public ProgressSubTest(SubTest subTest)
        {
            _progressSubSubTests = new List<ProgressSubSubTest>();
            SubTest = subTest;
            CurrentSubSubTest = 0;
        }

        public ProgressSubSubTest GetSubSubTest()
        {
            if (CurrentSubSubTest == SubTest.SubSubTests.Count)
                return null;

            return new ProgressSubSubTest(SubTest.SubSubTests[CurrentSubSubTest]);
        }

        public bool CheckSubSubTest(ProgressSubSubTest progressSubSubTest)
        {
            if (!progressSubSubTest.SubSubTestPassed)
                return false;

            CurrentSubSubTest++;
            return true;
        }
        
        public (int right, int all) GetResult()
        {
            var right = 0;
            var all = 0;

            foreach (var progressSubSubTest in _progressSubSubTests)
            {
                var (r, a) = progressSubSubTest.GetResult();

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

            return $"Подтест {SubTest.Name} - {percent}% правильно";
        }
    }
}