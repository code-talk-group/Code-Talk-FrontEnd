using CodeTalk.Models;
using System;
using System.Threading.Tasks;
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
            testResult.returnString = "Test String";
            Results.Equals("Test String", testResult.returnString);
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
            testResult.returnString = "First String";
            testResult.returnString = "Test String";
            Results.Equals("Test String", testResult.returnString);
        }

        [Fact]
        public void CanSetResultCode()
        {
            Results testResult = new Results();
            testResult.Code = "First String";
            testResult.Code = "Test Code";
            Results.Equals("Test Code", testResult.Code);
        }

        [Fact]
        public void CanGetForLoopID()
        {
            ForLoop testForLoop = new ForLoop();
            testForLoop.ID = 1;
            ForLoop.Equals(1, testForLoop.ID);
        }

        [Fact]
        public void CanGetForLoopCodeName()
        {
            ForLoop testforLoop = new ForLoop();
            testforLoop.CodeName = "Test CodeName";
            ForLoop.Equals("Test CodeName", testforLoop.CodeName);
        }

        [Fact]
        public void CanGetForLoopMethodName()
        {
            ForLoop testForLoop = new ForLoop();
            testForLoop.MethodName = "Test MethodName";
            ForLoop.Equals("Test MethodName", testForLoop.MethodName);
        }

        [Fact]
        public void CanGetForLoopArrayName()
        {
            ForLoop testForLoop = new ForLoop();
            testForLoop.ArrayName = "Test ArrayName";
            ForLoop.Equals("Test ArrayName", testForLoop.ArrayName);
        }

        [Fact]
        public void CanSetForLoopID()
        {
            ForLoop testForLoop = new ForLoop();
            testForLoop.ID = 2;
            testForLoop.ID = 1;
            ForLoop.Equals(1, testForLoop.ID);
        }

        [Fact]
        public void CanSetForLoopCodeName()
        {
            ForLoop testforLoop = new ForLoop();
            testforLoop.CodeName = "Test Code";
            testforLoop.CodeName = "Test CodeName";
            ForLoop.Equals("Test CodeName", testforLoop.CodeName);
        }

        [Fact]
        public void CanSetForLoopMethodName()
        {
            ForLoop testForLoop = new ForLoop();
            testForLoop.MethodName = "Test Method";
            testForLoop.MethodName = "Test MethodName";
            ForLoop.Equals("Test MethodName", testForLoop.MethodName);
        }

        [Fact]
        public void CanSetForLoopArrayName()
        {
            ForLoop testForLoop = new ForLoop();
            testForLoop.ArrayName = "Test Array";
            testForLoop.ArrayName = "Test ArrayName";
            ForLoop.Equals("Test ArrayName", testForLoop.ArrayName);
        }

        [Fact]
        public void CanGetFunctionID()
        {
            Function testFunction = new Function();
            testFunction.ID = 1;
            Function.Equals(1, testFunction.ID);
        }

        [Fact]
        public void CanGetFunctionCodeName()
        {
            Function testFunction = new Function();
            testFunction.CodeName = "Test CodeName";
            Function.Equals("Test CodeName", testFunction.CodeName);
        }

        [Fact]
        public void CanGetFunctionMethodName()
        {
            Function testFunction = new Function();
            testFunction.MethodName = "Test MethodName";
            Function.Equals("Test MethodName", testFunction.MethodName);
        }

        [Fact]
        public void CanGetFunctionDataType()
        {
            Function testFunction = new Function();
            testFunction.DataType = "Test DataType";
            Function.Equals("Test DataType", testFunction.DataType);
        }

        [Fact]
        public void CanGetFunctionParameterName()
        {
            Function testFunction = new Function();
            testFunction.ParameterName = "Test ParameterName";
            Function.Equals("Test ParameterName", testFunction.ParameterName);
        }

        [Fact]
        public void CanSetFunctionID()
        {
            Function testFunction = new Function();
            testFunction.ID = 2;
            testFunction.ID = 1;
            Function.Equals(1, testFunction.ID);
        }

        [Fact]
        public void CanSetFunctionCodeName()
        {
            Function testFunction = new Function();
            testFunction.CodeName = "Test Code";
            testFunction.CodeName = "Test CodeName";
            Function.Equals("Test CodeName", testFunction.CodeName);
        }

        [Fact]
        public void CanSetFunctionMethodName()
        {
            Function testFunction = new Function();
            testFunction.MethodName = "Test Method";
            testFunction.MethodName = "Test MethodName";
            Function.Equals("Test MethodName", testFunction.MethodName);
        }

        [Fact]
        public void CanSetFunctionDataType()
        {
            Function testFunction = new Function();
            testFunction.DataType = "Test Data";
            testFunction.DataType = "Test DataType";
            Function.Equals("Test DataType", testFunction.DataType);
        }

        [Fact]
        public void CanSetFunctionParameterName()
        {
            Function testFunction = new Function();
            testFunction.ParameterName = "Test Parameter";
            testFunction.ParameterName = "Test ParameterName";
            Function.Equals("Test ParameterName", testFunction.ParameterName);
        }

        [Fact]
        public void CanGetIfStatementID()
        {
            IfStatement testIfStatement = new IfStatement();
            testIfStatement.ID = 1;
            IfStatement.Equals(1, testIfStatement.ID);
        }

        [Fact]
        public void CanGetIfStatementCodeName()
        {
            IfStatement testIfStatement = new IfStatement();
            testIfStatement.CodeName = "Test CodeName";
            IfStatement.Equals("Test CodeName", testIfStatement.CodeName);
        }

        [Fact]
        public void CanGetIfStatementMethodName()
        {
            IfStatement testIfStatement = new IfStatement();
            testIfStatement.MethodName = "Test MethodName";
            IfStatement.Equals("Test MethodName", testIfStatement.MethodName);
        }

        [Fact]
        public void CanGetIfStatementParameterName()
        {
            IfStatement testIfStatement = new IfStatement();
            testIfStatement.ParameterName = "Test ParameterName";
            IfStatement.Equals("Test ParameterName", testIfStatement.ParameterName);
        }

        [Fact]
        public void CanGetIfStatementIntegerValue()
        {
            IfStatement testIfStatement = new IfStatement();
            testIfStatement.IntegerValue = "Test IntergerValue";
            IfStatement.Equals("Test IntergerValue", testIfStatement.IntegerValue);
        }

        [Fact]
        public void CanSetIfStatementID()
        {
            IfStatement testIfStatement = new IfStatement();
            testIfStatement.ID = 2;
            testIfStatement.ID = 1;
            IfStatement.Equals(1, testIfStatement.ID);
        }

        [Fact]
        public void CanSetIfStatementCodeName()
        {
            IfStatement testIfStatement = new IfStatement();
            testIfStatement.CodeName = "Test Code";
            testIfStatement.CodeName = "Test CodeName";
            IfStatement.Equals("Test CodeName", testIfStatement.CodeName);
        }

        [Fact]
        public void CanSetIfStatementMethodName()
        {
            IfStatement testIfStatement = new IfStatement();
            testIfStatement.MethodName = "Test Method";
            testIfStatement.MethodName = "Test MethodName";
            IfStatement.Equals("Test MethodName", testIfStatement.MethodName);
        }

        [Fact]
        public void CanSetIfStatementParameterName()
        {
            IfStatement testIfStatement = new IfStatement();
            testIfStatement.ParameterName = "Test Parameter";
            testIfStatement.ParameterName = "Test ParameterName";
            IfStatement.Equals("Test ParameterName", testIfStatement.ParameterName);
        }

        [Fact]
        public void CanSetIfStatementIntegerValue()
        {
            IfStatement testIfStatement = new IfStatement();
            testIfStatement.IntegerValue = "Test Integer";
            testIfStatement.IntegerValue = "Test IntergerValue";
            IfStatement.Equals("Test IntergerValue", testIfStatement.IntegerValue);
        }

        [Fact]
        public void CanGetVariableID()
        {
            Variable testVariable = new Variable();
            testVariable.ID = 1;
            Variable.Equals(1, testVariable.ID);
        }

        [Fact]
        public void CanGetVariableCodeName()
        {
            Variable testVariable = new Variable();
            testVariable.CodeName = "Test CodeName";
            Variable.Equals("Test CodeName", testVariable.CodeName);
        }


        [Fact]
        public void CanGetVariableMethodName()
        {
            Variable testVariable = new Variable();
            testVariable.MethodName = "Test MethodName";
            Variable.Equals("Test MethodName", testVariable.MethodName);
        }

        [Fact]
        public void CanGetVariableDataType()
        {
            Variable testVariable = new Variable();
            testVariable.DataType = "Test DataType";
            Variable.Equals("Test DataType", testVariable.DataType);
        }

        [Fact]
        public void CanGetVariableVariableName()
        {
            Variable testVariable = new Variable();
            testVariable.VariableName = "Test VariableName";
            Variable.Equals("Test VariableName", testVariable.VariableName);
        }

        [Fact]
        public void CanGetVariableVariableValue()
        {
            Variable testVariable = new Variable();
            testVariable.VariableValue = "Test VariableValue";
            Variable.Equals("Test VariableVale", testVariable.VariableValue);
        }

        [Fact]
        public void CanSetVariableID()
        {
            Variable testVariable = new Variable();
            testVariable.ID = 2;
            testVariable.ID = 1;
            Variable.Equals(1, testVariable.ID);
        }

        [Fact]
        public void CanSetVariableCodeName()
        {
            Variable testVariable = new Variable();
            testVariable.CodeName = "Test Code";
            testVariable.CodeName = "Test CodeName";
            Variable.Equals("Test CodeName", testVariable.CodeName);
        }


        [Fact]
        public void CanSetVariableMethodName()
        {
            Variable testVariable = new Variable();
            testVariable.MethodName = "Test Method";
            testVariable.MethodName = "Test MethodName";
            Variable.Equals("Test MethodName", testVariable.MethodName);
        }

        [Fact]
        public void CanSetVariableDataType()
        {
            Variable testVariable = new Variable();
            testVariable.DataType = "Test Data";
            testVariable.DataType = "Test DataType";
            Variable.Equals("Test DataType", testVariable.DataType);
        }

        [Fact]
        public void CanSetVariableVariableName()
        {
            Variable testVariable = new Variable();
            testVariable.VariableName = "Test VariableName";
            Variable.Equals("Test VariableName", testVariable.VariableName);
        }

        [Fact]
        public void CanSetVariableVariableValue()
        {
            Variable testVariable = new Variable();
            testVariable.VariableValue = "Test Variable";
            testVariable.VariableValue = "Test VariableValue";
            Variable.Equals("Test VariableVale", testVariable.VariableValue);
        }



        //[Fact]
        //public async Task Index_ReturnsAViewResult_WithAListOfCodeSentences()
        //{
        //    //Arrange
        //    var mockRepo = new Mock
        //} 

    }
}
