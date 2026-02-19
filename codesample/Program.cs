using codesample.array;
using codesample.condition;
using codesample.logical_and_conditional_operator;
using codesample.loop;
using codesample.operator2;
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
            Sum.SumRun();

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
