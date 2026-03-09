using System;

static string ToUpperCase(string s) => s.ToUpper();
static string ToLowerCase(string s) => s.ToLower();
static string AddBrackets(string s) => "[" + s + "]";
static string Reverse(string s)
{
    char[] chars = s.ToCharArray();
    Array.Reverse(chars);
    return new string(chars);
}

static void ProcessAndPrint(string input, StringProcessor processor)
{
    string result = processor(input);
    Console.WriteLine($"결과: {result}");
}

string original = "Hello World";

Console.WriteLine("=== 문자열 가공기 ===");
Console.WriteLine();
Console.WriteLine($"원본: {original}");

Console.WriteLine();
Console.WriteLine("[대문자 변환]");
ProcessAndPrint(original, ToUpperCase);

Console.WriteLine();
Console.WriteLine("[소문자 변환]");
ProcessAndPrint(original, ToLowerCase);

Console.WriteLine();
Console.WriteLine("[괄호 추가]");
ProcessAndPrint(original, AddBrackets);

Console.WriteLine();
Console.WriteLine("[문자열 뒤집기]");
ProcessAndPrint(original, Reverse);

delegate string StringProcessor(string s);
