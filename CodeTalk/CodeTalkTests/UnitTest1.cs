using CodeTalk.Models;
using System;
using Xunit;

namespace CodeTalkTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanGetFormType()
        {
            Form testForm = new Form();
            testForm.FormType = FormType.ForLoop;
            Form.Equals(FormType.ForLoop, testForm.FormType);
        }

        [Fact]
        public void CanSetFormType()
        {
            Form testForm = new Form();
            testForm.FormType = FormType.Function;
            testForm.FormType = FormType.Variable;
            Form.Equals(FormType.Variable, testForm.FormType);
        }

        [Fact]
        public void CanGetResultID()
        {
            Results testResult = new Results();
            testResult.ID = 3;
            Results.Equals(3, testResult.ID);
        }

        [Fact]
        public void CanGetResultOption()
        {
            Results testResult = new Results();
            testResult.Option = 2;
            Results.Equals(2, testResult.Option);
        }

        [Fact]
        public void CanGetResultBaseString()
        {
            Results testResult = new Results();
            testResult.baseString = "Test String";
            Results.Equals("Test String", testResult.baseString);
        }

        [Fact]
        public void CanGetResultCode()
        {
            Results testResult = new Results();
            testResult.Code = "Test Code";
            Results.Equals("Test Code", testResult.Code);
        }

        [Fact]
        public void CanSetResultID()
        {
            Results testResult = new Results();
            testResult.ID = 4;
            testResult.ID = 3;
            Results.Equals(3, testResult.ID);
        }

        [Fact]
        public void CanSetResultOption()
        {
            Results testResult = new Results();
            testResult.Option = 4;
            testResult.Option = 2;
            Results.Equals(2, testResult.Option);
        }

        [Fact]
        public void CanSetResultBaseString()
        {
            Results testResult = new Results();
            testResult.baseString = "First String";
            testResult.baseString = "Test String";
            Results.Equals("Test String", testResult.baseString);
        }

        [Fact]
        public void CanSetResultCode()
        {
            Results testResult = new Results();
            testResult.Code = "First String";
            testResult.Code = "Test Code";
            Results.Equals("Test Code", testResult.Code);
        }

    }
}
