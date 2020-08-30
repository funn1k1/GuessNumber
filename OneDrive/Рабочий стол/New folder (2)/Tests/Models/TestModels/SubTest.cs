using System.Collections.Generic;

namespace WinFormsTests.Models.TestModels
{
    public class SubTest
    {
        private List<SubSubTest> _subSubTests;

        public string Name { get; }

        public IReadOnlyList<SubSubTest> SubSubTests => _subSubTests.AsReadOnly();
        
        public SubTest(string name)
        {
            _subSubTests = new List<SubSubTest>();
            Name = name;
        }

        public void AddSubSubTest(SubSubTest subSubTest) => _subSubTests.Add(subSubTest);

        public override string ToString() => Name;
    }
}