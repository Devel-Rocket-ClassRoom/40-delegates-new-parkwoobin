using System;

// README.md를 읽고 코드를 작성하세요.


MatOp add = Add;
MatOp subtract = Subtract;
MatOp multiply = Multiply;
MatOp divide = Divide;

int a = 20, b = 4;
Console.WriteLine($"[덧셈]\n{a} + {b} = {add(a, b)}\n");
Console.WriteLine($"[뺄셈]\n{a} - {b} = {subtract(a, b)}\n");
Console.WriteLine($"[곱셈]\n{a} * {b} = {multiply(a, b)}\n");
Console.WriteLine($"[나눗셈]\n{a} / {b} = {divide(a, b)}\n");

static int Add(int a, int b) => a + b;
static int Subtract(int a, int b) => a - b;
static int Multiply(int a, int b) => a * b;
static int Divide(int a, int b) => a / b;
delegate int MatOp(int a, int b);