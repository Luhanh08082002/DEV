using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace CTD
{
    public enum TokenType
    {
        Keyword,
        Identifier,
        Number,
        Symbol
    }

    public class Token
    {
        public TokenType Type { get; }
        public string Value { get; }

        public Token(TokenType type, string value)
        {
            Type = type;
            Value = value;
        }
    }

    public class LexicalAnalyzer
    {
        private readonly Dictionary<string, TokenType> keywordMappings = new Dictionary<string, TokenType>
    {
        { "void", TokenType.Keyword },
        { "int", TokenType.Keyword },
        { "for", TokenType.Keyword }
    };

        private readonly Regex identifierRegex = new Regex(@"[a-zA-Z_][a-zA-Z0-9_]*");
        private readonly Regex numberRegex = new Regex(@"[-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?");
        private readonly Regex symbolRegex = new Regex(@"[{}();=+*]");

        public List<Token> Analyze(string code)
        {
            var tokens = new List<Token>();
            Match matches = Regex.Match("anytest#", ".*[^a-z A-Z0-9_].*");

            if (matches.Success)
                Console.WriteLine("error");
            else
                Console.WriteLine("no error");

            /*foreach (Match match in matches)
            {
                if (!match.Success)
                    continue;

                var value = match.Value.Trim();

                if (keywordMappings.ContainsKey(value))
                {
                    tokens.Add(new Token(keywordMappings[value], value));
                }
                else if (identifierRegex.IsMatch(value))
                {
                    tokens.Add(new Token(TokenType.Identifier, value));
                }
                else if (numberRegex.IsMatch(value))
                {
                    tokens.Add(new Token(TokenType.Number, value));
                }
                else if (symbolRegex.IsMatch(value))
                {
                    tokens.Add(new Token(TokenType.Symbol, value));
                }
                else
                {
                    Console.WriteLine($"Invalid token: {value}");
                    throw new Exception($"Invalid token: {value}");
                }
            }*/

            return tokens;
        }
    }

    class Program
    {
        static void Main()
        {
            var codeString = File.ReadAllText("C:\\DEV\\CTD\\input.txt");

            var analyzer = new LexicalAnalyzer();

            var tokens = analyzer.Analyze(codeString);

            foreach (var token in tokens)
            {
                Console.WriteLine($"Type: {token.Type}, Value: {token.Value}");
            }
        }
    }
}