using System;
using System.Collections.Generic;
using WinFormsTests.Models.TestModels;

namespace WinFormsTests.Activities
{
    public class MainActivity
    {
        private List<Test> _tests;

        public IReadOnlyList<Test> Tests => _tests.AsReadOnly();

        public MainActivity()
        {
            _tests = new List<Test>();
        }

        public void GetControl()
        {
            Start();
        }

        private void Start()
        {
            Console.WriteLine("1 - пройти тест");
            Console.WriteLine("2 - добавить новый тест");

            var num = Helpers.ReadInt(1, 2);

            if (num == 1)
                Test();
            
            if (num == 2)
                AddTest();
        }

        private void Test()
        {
            
        }

        private void AddTest()
        {
            
        }
    }
}