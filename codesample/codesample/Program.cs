using codesample.array;
using codesample.array_of_arrays;
using codesample.condition;
using codesample.default_arugment;
using codesample.FloatVsDoubleVsDecimal;
using codesample.function;
using codesample.logical_and_conditional_operator;
using codesample.loop;
using codesample.operator2;
using codesample.outparameterModifier;
using codesample.recursive;
using codesample.stringbuilder;
using codesample.stringconcat_vs_stringbuilder;
using codesample.switch_statment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codesample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // char char2 = 'a';
            // int result2 = char2 & '_';
            // Console.WriteLine("result2: " + (char)result2);
            // BitShift();


            // BitFlag.BitFlagRun();

            // condtion
            // InsertStudentInformation2.InsertStudentInformation2Run();

            // 논리표현식
            // LogicalExpressions.LogicalExpressionsRun();

            // 연산자 우선순위
            // OrderOfExpressionEvaluation.OrderOfExpressionEvaluationRun();

            // switch
            //CalculationWithSwitchStatement.CalculationWithSwitchStatementRun();

            // array
            //InsertStudentInformation3.InsertStudentInformation3Run();

            // loop sum
            //Sum.SumRun();

            // recursive
            //Recursive.RecursiveRun();

            // shuffle algorithm
            // RandomShuffling.RandomShuffling.RandomShufflingRun();

            // array of arrays
            // ArrayOfArrays.ArrayOfArraysRun();

            // array of arrays(tokenizer)
            // Tokenizer.TokenizerRun();

            // function
            //FunctionOverLoading.Foo();
            //FunctionOverLoading.Foo(10);
            //FunctionOverLoading.Foo("POCU");
            //FunctionOverLoading.Foo("POCU", "COMP1500", "Intro to programming!");

            // default parameters
            // DefasultParameters.DefaultParametersRun();

            // OutParameterModifier
            // OutParameterModifier.OutParameterModifierRun();

            // StringBuilder
            // StringBuilderExample.StringBuilderRun();

            // StringConcat vs StringBuilder
            // StringConcatVsStringBuilder.StringConcatVsStringBuilderRun();

            // float vs double vs decimal
            FloatVsDoubleVsDecimal.FloatVsDoubleVsDecimal.FloatVsDoubleVsDecimalRun();
        }

        static void BitShift()
        {
            int num1 = 1;

            int result1 = num1 << 1;
            Console.WriteLine("result1: " + result1);

            int result2 = result1 << 2;
            Console.WriteLine("result2: " + result2);

            int result3 = result2 >> 3;
            Console.WriteLine("result3: " + result3);

            // int result4 = result3 << 2.5f;
            // int result5 = 2.1f << 2.5f;
        }
    }
}
