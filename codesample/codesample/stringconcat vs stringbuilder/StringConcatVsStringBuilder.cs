using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codesample.stringconcat_vs_stringbuilder
{
    class StringConcatVsStringBuilder
    {
        public static void StringConcatVsStringBuilderRun()
        {
            const int LOOP_COUNT = 1000;
            Stopwatch stopWatch = new Stopwatch();

            #region USING_CONCATENATION
            stopWatch.Start();

            string concatenated = string.Empty;
            for (int i = 0; i < LOOP_COUNT; i++)
            {
                concatenated += "test";
            }

            stopWatch.Stop();
            Console.WriteLine($"Time elapsed in ms (Concatenated): {stopWatch.Elapsed.TotalMilliseconds}");
            #endregion

            stopWatch.Reset();

            #region USING_STRING_BUILDER
            stopWatch.Start();

            StringBuilder stringBuilder = new StringBuilder(4096);
            for (int i = 0; i < LOOP_COUNT; i++)
            {
                stringBuilder.Append("test");
            }

            string s = stringBuilder.ToString();

            stopWatch.Stop();
            Console.WriteLine($"Time elapsed in ms (StringBuilder): {stopWatch.Elapsed.TotalMilliseconds}");
            #endregion
        }
    }
}
