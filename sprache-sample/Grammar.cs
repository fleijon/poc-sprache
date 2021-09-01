using Sprache;

namespace SpracheSample.Common
{
    public static class Grammar
    {
        public static readonly Parser<string> NewLine = Parse.LineEnd;
        public static readonly Parser<char> Comma = Parse.Char(',');
        public static readonly Parser<char> DoubleQuotation = Parse.Char('"');
    }
}