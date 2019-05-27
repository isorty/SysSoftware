using System;
using System.CodeDom.Compiler;
using System.Threading;

namespace Model
{
    public static class Analyzer
    {
        public static string Analyze(string construction, byte form)
        {
            construction = construction.ToLower();
            if (form == 0 && (!construction.Contains("for") || construction.Contains("while")))
                    return "Синтаксическая ошибка";
            else if (form == 1 && (!construction.Contains("do") || !construction.Contains("while") || construction.Contains("for") || construction.IndexOf("while") < construction.IndexOf("do")))
                return "Синтаксическая ошибка";

            string startCode = "using System;\n" +
                               "namespace Logical.AnalizeCode\n" +
                               "{\npublic static class AnalyzeClass\n" +
                               "{\n" +
                               "public static int AnalyzeMethod()\n" +
                               "{\nint repeats = 0;\n";

            string endCode = "return repeats;\n" +
                             "}\n" +
                             "}\n" +
                             "}";

            CodeDomProvider compiler = CodeDomProvider.CreateProvider("CSharp");

            CompilerParameters parameters = new CompilerParameters { GenerateInMemory = true, IncludeDebugInformation = false };

            int cycleEndPosition = construction.LastIndexOf("}");
            if (cycleEndPosition != -1)
            {
                string newCycleBody = construction.Substring(0, cycleEndPosition) + "\nrepeats++;\n" + construction.Substring(cycleEndPosition);
                string compileCode = startCode + newCycleBody + endCode;
                return GetCompileResult(compileCode, form);
            }
            else
            {
                if (form == 0)
                {

                    int cycleBodyBegin = construction.IndexOf(')');
                    string cycleBody = construction.Substring(cycleBodyBegin + 1);
                    if (cycleBody.Trim(' ', '\n', '\t', '\r') == "")
                        return "Синтаксическая ошибка";
                    string newCycleBody = construction.Substring(0, cycleBodyBegin + 1) + "\n{\nrepeats++;\n" + construction.Substring(cycleBodyBegin + 1) + "\n}";
                    string compileCode = startCode + newCycleBody + endCode;
                    return GetCompileResult(compileCode, form);
                }
                else
                {
                    int cycleBodyBegin = construction.LastIndexOf("do") + 2;
                    int cycleBodyEnd = construction.IndexOf("while");
                    string cycleBody = construction.Substring(cycleBodyBegin, cycleBodyEnd - cycleBodyBegin).Trim(' ', '\n', '\t', '\r');
                    if (cycleBody == "")
                        return "Синтаксическая ошибка";
                    string newCycleBody = construction.Substring(0, cycleBodyBegin) + "\n{\nrepeats++;\n" + construction.Substring(cycleBodyBegin, cycleBodyEnd - cycleBodyBegin) + "\n}\n" + construction.Substring(cycleBodyEnd);
                    string compileCode = startCode + newCycleBody + endCode;
                    return GetCompileResult(compileCode, form);
                }
            }
        }

        private static string GetCompileResult(string sourceCode, byte form)
        {
            CodeDomProvider compiler = CodeDomProvider.CreateProvider("CSharp");
            CompilerParameters parameters = new CompilerParameters { GenerateInMemory = true, IncludeDebugInformation = false };
            CompilerResults results = compiler.CompileAssemblyFromSource(parameters, sourceCode);
            if (results.Errors.Count > 0)
            {
                string result = "";
                foreach (CompilerError error in results.Errors)
                    result = result + error.ErrorText + "\n";
                return result;
            }
            object repeatCount = null;
            Thread compileThread = new Thread(() => { repeatCount = results.CompiledAssembly.GetType("Logical.AnalizeCode.AnalyzeClass").GetMethod("AnalyzeMethod").Invoke(null, null); });
            DateTime dold = DateTime.Now;
            compileThread.Start();
            if (!compileThread.Join(new TimeSpan(0, 0, 2)))
            {
                compileThread.Interrupt();
                return "Выполнение цикла заняло очень длительное время (возможно бесконечный цикл)";
            }
            if (form == 0)
                return "Количество итераций цикла: " + repeatCount.ToString();
            else
            {
                return Convert.ToInt32(repeatCount) > 1 ? "Цикл выполнится более 1 раза" : "Цикл выполнится один раз";
            }
        }
    }
}