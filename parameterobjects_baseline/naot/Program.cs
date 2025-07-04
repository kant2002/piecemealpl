using System;

unsafe
{
    int x = 123;
    double y = 853.6;
    int x2 = 282;
    double y2 = 363.6;
    method0("prefix");
    method1("prefix", 1);
    method2("prefix", 1, 'c');
    method3("prefix", 1, 'c', ref x);
    method4("prefix", 1, 'c', ref x, ref y);
    method5("prefix", 1, 'c', ref x, ref y, "param");
    method6("prefix", 1, 'c', ref x, ref y, "param", 123);
    method7("prefix", 1, 'c', ref x, ref y, "param", 123, 'd');
    method8("prefix", 1, 'c', ref x, ref y, "param", 123, 'd', ref x2);
    method9("prefix", 1, 'c', ref x, ref y, "param", 123, 'd', ref x2, ref y2);
}

void method0(string p0)
{
    Console.WriteLine(p0);
}
void method1(string p0, int p1)
{
    Console.WriteLine(p0);
    Console.WriteLine(p1);
}
void method2(string p0, int p1, char p2)
{
    Console.WriteLine(p0);
    Console.WriteLine(p1);
    Console.WriteLine(p2);
}
void method3(string p0, int p1, char p2, ref int p3)
{
    Console.WriteLine(p0);
    Console.WriteLine(p1);
    Console.WriteLine(p2);
    Console.WriteLine(p3);
}
void method4(string p0, int p1, char p2, ref int p3, ref double p4)
{
    Console.WriteLine(p0);
    Console.WriteLine(p1);
    Console.WriteLine(p2);
    Console.WriteLine(p3);
    Console.WriteLine(p4);
}
void method5(string p0, int p1, char p2, ref int p3, ref double p4, string p5)
{
    Console.WriteLine(p0);
    Console.WriteLine(p1);
    Console.WriteLine(p2);
    Console.WriteLine(p3);
    Console.WriteLine(p4);
    Console.WriteLine(p5);
}
void method6(string p0, int p1, char p2, ref int p3, ref double p4, string p5, int p6)
{
    Console.WriteLine(p0);
    Console.WriteLine(p1);
    Console.WriteLine(p2);
    Console.WriteLine(p3);
    Console.WriteLine(p4);
    Console.WriteLine(p5);
    Console.WriteLine(p6);
}
void method7(string p0, int p1, char p2, ref int p3, ref double p4, string p5, int p6, char p7)
{
    Console.WriteLine(p0);
    Console.WriteLine(p1);
    Console.WriteLine(p2);
    Console.WriteLine(p3);
    Console.WriteLine(p4);
    Console.WriteLine(p5);
    Console.WriteLine(p6);
    Console.WriteLine(p7);
}
void method8(string p0, int p1, char p2, ref int p3, ref double p4, string p5, int p6, char p7, ref int p8)
{
    Console.WriteLine(p0);
    Console.WriteLine(p1);
    Console.WriteLine(p2);
    Console.WriteLine(p3);
    Console.WriteLine(p4);
    Console.WriteLine(p5);
    Console.WriteLine(p6);
    Console.WriteLine(p7);
    Console.WriteLine(p8);
}
void method9(string p0, int p1, char p2, ref int p3, ref double p4, string p5, int p6, char p7, ref int p8, ref double p9)
{
    Console.WriteLine(p0);
    Console.WriteLine(p1);
    Console.WriteLine(p2);
    Console.WriteLine(p3);
    Console.WriteLine(p4);
    Console.WriteLine(p5);
    Console.WriteLine(p6);
    Console.WriteLine(p7);
    Console.WriteLine(p8);
    Console.WriteLine(p9);
}