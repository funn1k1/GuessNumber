using System;
using System.Collections.Generic;

namespace WinFormsTests.Models.TestModels
{
    public class Test
    {
        private List<SubTest> _subTests;

        public IReadOnlyList<SubTest> SubTests => _subTests.AsReadOnly();

        public string Name { get; }

        public TimeSpan? Time { get; }
        
        public Test(string name, TimeSpan? time)
        {
            _subTests = new List<SubTest>();
            Name = name;
            Time = time;
        }

        public void AddSubTest(SubTest subTest) => _subTests.Add(subTest);

        public override string ToString() => Name;
    }
}