using System;

// README.md를 읽고 아래에 코드를 작성하세요.

void PrintOriginal(string s) => Console.WriteLine($"원본: {s}");
void PrintUpper(string s) => Console.WriteLine($"대문자: {s.ToUpper()}");
void PrintLower(string s) => Console.WriteLine($"소문자: {s.ToLower()}");
void PrintLength(string s) => Console.WriteLine($"길이: {s.Length}");

string testStr = "Hello World";

Console.WriteLine("=== 문자열 처리 파이프라인 ===");

Action<string> pipeline = PrintOriginal;
Console.WriteLine("\n--- 단계 1: 원본 출력만 ---");
pipeline(testStr);

pipeline += PrintUpper;
Console.WriteLine("\n--- 단계 2: 대문자 추가 ---");
pipeline(testStr);

pipeline += PrintLower;
pipeline += PrintLength;
Console.WriteLine("\n--- 단계 3: 소문자, 길이 추가 ---");
pipeline(testStr);

pipeline -= PrintUpper;
Console.WriteLine("\n--- 단계 4: 대문자 제거 ---");
pipeline(testStr);


