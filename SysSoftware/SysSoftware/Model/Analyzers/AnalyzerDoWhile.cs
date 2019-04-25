using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SysSoftware.Model
{
    public class AnalyzerDoWhile
    {
        private readonly string ID = @"(_|[a-z])([0-9]|[a-z]|_)*";
        private readonly string sign = @"(<|>|==|!=|<=|>=)";

        public string Construction { get; set; }

        public AnalyzerDoWhile(string construction)
        {
            Construction = construction;
        }

        private bool SyntaxCheck()
        {
            
            string condition = @"(\s*(true|false|" + ID + @"\s*" + sign + @"\s*" + @"([0-9]*|[0-9]*\.[0-9]*)" + @"\s*" + @")\s*)";
            Regex syntaxRegex = new Regex(@"do(\s|\t|\n)*\{(\w|\W)*\}(\s|\t|\n)*while\s*\(" + condition + @"\)", RegexOptions.IgnoreCase);
            return syntaxRegex.Matches(Construction).Count == 1 ? true : false;
        }
 
        public List<string> GetExpressions(string id)
        {
            string number = @"([0-9]*|[0-9]*\.[0-9]*)";
            string operation = @"(\+\+|\-\-|(\+|\-|\*|\\)?\=\s*" + number + @"|\=\s*" + id + @"\s*(\+|\-|\*|\\)?\s*" + number + @")\s*\;";
            Regex exRegex = new Regex(id + @"\s*" + operation);
            List<string> expressions = new List<string>();
            foreach (Match match in exRegex.Matches(Construction))
                expressions.Add(match.Value);
            return expressions;
        }

        public string AnalysisResult()
        {
            if (SyntaxCheck())
            {
                Regex conditionRegex = new Regex(@"while\s*\((\w|\W)*\)");
                string condition = conditionRegex.Match(Construction).Value;
                condition = condition.Substring(condition.IndexOf('(') + 1, condition.IndexOf(')') - condition.IndexOf('(') - 1);
                condition = condition.Trim();
                if (condition == "true")
                    return "Данный цикл выполнит более одной итерации";
                else if (condition == "false")
                    return "Данный цикл выполнит одну итерацию";
                Regex idRegex = new Regex(ID);
                string id = idRegex.Match(condition).Value;
                string res = "";
                foreach (string i in GetExpressions(id))
                    res += i;
                return res;
            }
            else return "В конструкции присутсвует синтаксическая ошибка";
        }
    }
}