using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;

namespace Model.Analyzers
{
    public class AnalysisResult
    {
        public List<string> CompilerErrorCollection { get; set; }
        public int RepeatCount { get; set; }


        public AnalysisResult(CompilerErrorCollection compilerErrorCollection, int repeatCount)
        {
            CompilerErrorCollection = new List<string>();
            foreach (CompilerError error in compilerErrorCollection)
                this.CompilerErrorCollection.Add(error.ErrorText);
            this.RepeatCount = repeatCount;
        }
    }
}
