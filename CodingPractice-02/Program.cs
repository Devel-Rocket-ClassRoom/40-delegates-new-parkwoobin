using System;

// README.md를 읽고 아래에 코드를 작성하세요.




/*
Calculator calculator = new Calculator();
Transformer t = calculator.Multiply;
Console.WriteLine(t(5));

class Calculator
{
    public int multiply = 3;
    public int Multiply(int x) => x * multiply;
}

delegate int Transformer(int x);
*/


/*
CarDriver go = GoForward;
go += GoLeft;
go += GoRight;

go();

Console.WriteLine();

go -= GoLeft;
go();

static void GoForward() => Console.WriteLine("직진");
static void GoLeft() => Console.WriteLine("좌회전");
static void GoRight() => Console.WriteLine("우회전");

delegate void CarDriver();
*/


int[] values = { 1, 2, 3, 4, 5 };

Transform(values, Square);
PrintValues(values);


values = new int[] { 1, 2, 3, 4, 5 };


Transform(values, Cube);
PrintValues(values);

static int Square(int x) => x * x;
static int Cube(int x) => x * x * x;


static void Transform(int[] values, Transformer t)
{
    for (int i = 0; i < values.Length; i++)
    {
        values[i] = t(values[i]);
    }
}

static void PrintValues(int[] values)
{
    foreach (int value in values)
    {
        Console.Write(value + ", ");
    }
    Console.WriteLine();
}


delegate int Transformer(int x);



