using System;
using System.Collections.Generic;

namespace WinFormsTests.Models.TestModels
{
   [Serializable]
    public class Test
    {
        private List<SubTest> _subTests;

        public string Name { get; set; }

        public TimeSpan? Time { get; set; } // nullable структура, т.е. структура которая может быть при этом равна null

        public IReadOnlyList<SubTest> SubTests => _subTests.AsReadOnly();
        
        public Test(string name, TimeSpan? time)
        {
            _subTests = new List<SubTest>();
            Name = name;
            Time = time;
        }

        public void RemoveSubTest(int index) => _subTests.RemoveAt(index);

        public void AddSubTest(SubTest subTest) => _subTests.Add(subTest);

        public override string ToString() => Name;
    }
}