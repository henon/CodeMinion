﻿using System.ComponentModel;

namespace Regen.Compiler.Expressions {
    public enum ExpressionToken {
        [ExpressionToken(@"\//", -1, "//")] [Swallows(Div)] CommentRow, //swallow will 
        [ExpressionToken(@"import", 0, "import")] [Swallows(StringLiteral)] Import,
        [ExpressionToken(@"as", 1, "as")] [Swallows(StringLiteral)] As,
        [ExpressionToken(@"function", 5, "function")] [Swallows(StringLiteral)] Function,
        [ExpressionToken(@"new", 8, "new")] [Swallows(StringLiteral)] New,
        [ExpressionToken(@"throw", 9, "throw")] [Swallows(StringLiteral)] Throw,
        [ExpressionToken(@"if", 10, "if")] [Swallows(StringLiteral)] If,
        [ExpressionToken(@"else\s?if", 15, "else if")] [Swallows(StringLiteral)] ElseIf,
        [ExpressionToken(@"else", 20, "else")] [Swallows(StringLiteral)] Else,
        [ExpressionToken(@"(true|false)", 21, "$1")] [Swallows(StringLiteral)] Boolean,
        [ExpressionToken(@"foreach", 25, "foreach")] [Swallows(StringLiteral)] Foreach,
        [ExpressionToken(@"while", 26, "while")] [Swallows(StringLiteral)] While,
        [ExpressionToken(@"do", 27, "do")] [Swallows(StringLiteral)] Do,
        [ExpressionToken(@"reset", 28, "reset")] [Swallows(StringLiteral)] Reset,
        [ExpressionToken(@"return", 30, "return")] [Swallows(StringLiteral)] Return,
        [ExpressionToken(@"case", 31, "case")] [Swallows(StringLiteral)] Case,
        [ExpressionToken(@"switch", 32, "switch")] [Swallows(StringLiteral)] Switch,
        [ExpressionToken(@"break", 33, "break")] [Swallows(StringLiteral)] Break,
        [ExpressionToken(@"continue", 34, "continue")] [Swallows(StringLiteral)] Continue,
        [ExpressionToken(@"default", 35, "default")] [Swallows(StringLiteral)] Default,
        [ExpressionToken(@"null", 36, "null")] [Swallows(StringLiteral)] Null,
        [ExpressionToken(@"var", 39, "var")] [Swallows(StringLiteral)] Declaration,
        [ExpressionToken(@"\'(.|\\.)\'", 40, "'$1'")] [Swallows(StringLiteral)] CharLiteral,
        [ExpressionToken(@"\""(.*?)\""", 41, "\"$1\"")] [Swallows(NumberLiteral)] StringLiteral,
        [ExpressionToken(@"([0-9]+(?:\.[0-9]+)?[fFdDmM]?)", 45, "$1")] [Swallows(Literal)] NumberLiteral,
        [ExpressionToken(@"([a-zA-Z_][a-zA-Z0-9_]*)", 50, "$1")] Literal,
        [ExpressionToken(@"[\s\t]+", 60, " ")] Whitespace,
        [ExpressionToken(@"\n", 65, "\n")] NewLine,
        [ExpressionToken(@"\r", 70, "\r")] UnixNewLine,
        [ExpressionToken(@"\%", 75, "%")] MARKER,
        [ExpressionToken(@"\+\+", 80, "++")] [Swallows(Add)] Increment,
        [ExpressionToken(@"\-\-", 85, "--")] [Swallows(Sub)] Decrement,
        [ExpressionToken(@"\+", 90, "+")] Add,
        [ExpressionToken(@"\-", 95, "-")] Sub,
        [ExpressionToken(@"\*\*", 100, "**")] [Swallows(Mul)] Pow,
        [ExpressionToken(@"\*", 105, "*")] Mul,
        [ExpressionToken(@"\/", 110, "/")] Div,
        [ExpressionToken(@"\==", 115, "==")] [Swallows(Equal)] DoubleEqual,
        [ExpressionToken(@"\!=", 120, "!=")] [Swallows(Equal)] NotEqual,
        [ExpressionToken(@"\=", 125, "=")] Equal,
        [ExpressionToken(@"\&\&", 130, "&&")] [Swallows(And)] DoubleAnd,
        [ExpressionToken(@"\&", 135, "&")] And,
        [ExpressionToken(@"\|\|", 140, "||")] [Swallows(Or)] DoubleOr,
        [ExpressionToken(@"\|", 145, "|")] Or,
        [ExpressionToken(@"\~", 150, "~")] Not,
        [ExpressionToken(@"\!", 151, "!")] NotBoolean,
        [ExpressionToken(@"\^", 155, "^")] Xor,
        [ExpressionToken(@"\>\>", 160, ">>")] [Swallows(BiggerOrEqualThat)] ShiftRight,
        [ExpressionToken(@"\>\=", 165, ">=")] [Swallows(BiggerThan)] BiggerOrEqualThat,
        [ExpressionToken(@"\>", 170, ">")] BiggerThan,
        [ExpressionToken(@"\<\<", 175, "<<")] [Swallows(SmallerOrEqualThat)] ShiftLeft,
        [ExpressionToken(@"\<\=", 180, "<=")] [Swallows(SmallerThan)] SmallerOrEqualThat,
        [ExpressionToken(@"\<", 185, "<")] SmallerThan,
        [ExpressionToken(@"\(", 190, "(")] LeftParen,
        [ExpressionToken(@"\)", 195, ")")] RightParen,
        [ExpressionToken(@"\{", 200, "{")] LeftBrace,
        [ExpressionToken(@"\}", 205, "}")] RightBrace,
        [ExpressionToken(@"\[", 210, "[")] LeftBracet,
        [ExpressionToken(@"\]", 215, "]")] RightBracet,
        [ExpressionToken(@"\#", 220, "#")] Hashtag,
        [ExpressionToken(@"\,", 225, ",")] Comma,
        [ExpressionToken(@"\.\.", 230, "..")] [Swallows(Period)] RangeTo,
        [ExpressionToken(@"\.", 235, ".")] Period,
        [ExpressionToken(@"\?\?", 240, "??")] [Swallows(QuestionMark)] NullCoalescing,
        [ExpressionToken(@"\?", 245, "?")] QuestionMark,
        [ExpressionToken(@"\:", 250, ":")] Colon,
        [ExpressionToken(@"\;", 255, ";")] SemiColon,
        [ExpressionToken(@"\@", 260, "@")] Lambda,
    }
}