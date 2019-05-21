using System;
using System.CodeDom.Compiler;
using System.Threading;

namespace Model
{
    public static class Analyzer_do_while
    {
        public static AnalysisResult Analyze(string inputStructure)
        {
            //Определим, что перед нами действительно for
            /*int position = 0;
            bool isFor = false;
            int positionStartCycle;
            int inputStructureLength = inputStructure.Length;
            do
            {
                positionStartCycle = inputStructure.IndexOf("do", position);

                if (positionStartCycle == -1) break;

                //for...
                if (positionStartCycle == 0)
                {
                    if (inputStructureLength > 3 && !char.IsLetterOrDigit(inputStructure[3]))
                    {
                        isFor = true;
                        break;
                    }
                }

                //...for(...)
                if (positionStartCycle + 1 < inputStructureLength)
                {
                    var prevChar = inputStructure[positionStartCycle - 1];
                    var nextChar = inputStructure[positionStartCycle + 3];

                    if (!char.IsLetterOrDigit(prevChar) && prevChar != '/' && !char.IsLetterOrDigit(nextChar))
                    {
                        isFor = true;
                        break;
                    }
                }

                position = positionStartCycle;

            } while (position < inputStructure.Length && position != -1);

            int countQuotes = 0;
            if (isFor)
            {
                int i = positionStartCycle;
                int positionEndCycle = inputStructure.LastIndexOf('}') + 1;

                while (i < positionEndCycle)
                {
                    char curChar = inputStructure[i];
                    if (curChar == '{')
                        countQuotes++;
                    else if (curChar == '}')
                        countQuotes--;
                    i++;
                }

            }

            if (countQuotes != 0 || position >= inputStructure.Length || position == -1)
                return new AnalysisResult(
                    new CompilerErrorCollection()
                    {
            new CompilerError("", 0, 0, "", "Код не содержит цикла for")
                    },
                    0);//не for*/

            string programCodeStart = "using System;\n" +
                                      "namespace Logical.AnalizeCode\n" +
                                      "{\n\tpublic static class AnalyzeClass\n" +
                                      "\t{\n" +
                                      "\t\tpublic static int AnalyzeMethod()\n" +
                                      "\t\t{";

            string programCodeEnd = "\n\t\t\treturn countOfWhileLoopRepeat;\n" +
                                      "\t\t}\n" +
                                      "\t}\n" +
                                      "}";

            var compiler = CodeDomProvider.CreateProvider("CSharp");

            var parameters = new CompilerParameters
            {
                GenerateInMemory = true,
                IncludeDebugInformation = false
            };

            int endDoWhile = inputStructure.LastIndexOf("}");
            if (endDoWhile != -1) {
                //string doWhileCycle = inputStructure.Substring(0, endDoWhile);

                string countOfWhileLoopRepeatString = "\ncountOfWhileLoopRepeat++;\n}";
              

                //string resultDoWhileCycle = doWhileCycleWithIIncrement + inputStructure.Substring(endDoWhile + 1);

                string sourceCode = programCodeStart + "\nint countOfWhileLoopRepeat = 0;\n" + inputStructure.Insert(inputStructure.IndexOf('{') + 1, countOfWhileLoopRepeatString) + programCodeEnd;


                CompilerResults results = compiler.CompileAssemblyFromSource(parameters, sourceCode);

                if (results.Errors.Count > 0)
                {
                    return new AnalysisResult(results.Errors, 0);
                }

                object repeatCount = null;

                Thread compileThread = new Thread(() =>
                {
                    repeatCount = results.CompiledAssembly.GetType("Logical.AnalizeCode.AnalyzeClass").GetMethod("AnalyzeMethod").Invoke(null, null);
                });

                DateTime dold = DateTime.Now;
                compileThread.Start();

                if (!compileThread.Join(new TimeSpan(0, 0, 2)))
                {
                    compileThread.Interrupt();
                    return new AnalysisResult(
                        new CompilerErrorCollection()
                            {new CompilerError("", 0, 0, "", "Выполнение цикла заняло очень длительное время")}, 0);
                }


                return new AnalysisResult(new CompilerErrorCollection(), (int)repeatCount);
            }
            return new AnalysisResult(new CompilerErrorCollection(), 0);
        }
    }
}