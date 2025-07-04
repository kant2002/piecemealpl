using System;

int x = 123;
double y = 853.6;
int x2 = 282;
double y2 = 363.6;
P0 p0 = new P0 { p0 = "prefix" };
P1 p1 = new P1 { p0 = "prefix", p1 = 1 };
P2 p2 = new P2 { p0 = "prefix", p1 = 1, p2 = 'c' };
P3 p3 = new P3 { p0 = "prefix", p1 = 1, p2 = 'c', p3 = x };
P4 p4 = new P4 { p0 = "prefix", p1 = 1, p2 = 'c', p3 = x, p4 = y };
P5 p5 = new P5 { p0 = "prefix", p1 = 1, p2 = 'c', p3 = x, p4 = y, p5 = "param" };
P6 p6 = new P6 { p0 = "prefix", p1 = 1, p2 = 'c', p3 = x, p4 = y, p5 = "param", p6 = 123 };
P7 p7 = new P7 { p0 = "prefix", p1 = 1, p2 = 'c', p3 = x, p4 = y, p5 = "param", p6 = 123, p7 = 'd' };
P8 p8 = new P8 { p0 = "prefix", p1 = 1, p2 = 'c', p3 = x, p4 = y, p5 = "param", p6 = 123, p7 = 'd', p8 = x2 };
P9 p9 = new P9 { p0 = "prefix", p1 = 1, p2 = 'c', p3 = x, p4 = y, p5 = "param", p6 = 123, p7 = 'd', p8 = x2, p9 = y2 };
method0(p0);
method1(p1);
method2(p2);
method3(p3);
method4(p4);
method5(p5);
method6(p6);
method7(p7);
method8(p8);
method9(p9);

void method0(P0 p)
{
    Console.WriteLine(p.p0);
}
void method1(P1 p)
{
    Console.WriteLine(p.p0);
    Console.WriteLine(p.p1);
}
void method2(P2 p)
{
    Console.WriteLine(p.p0);
    Console.WriteLine(p.p1);
    Console.WriteLine(p.p2);
}
void method3(P3 p)
{
    Console.WriteLine(p.p0);
    Console.WriteLine(p.p1);
    Console.WriteLine(p.p2);
    Console.WriteLine(p.p3);
}
void method4(P4 p)
{
    Console.WriteLine(p.p0);
    Console.WriteLine(p.p1);
    Console.WriteLine(p.p2);
    Console.WriteLine(p.p3);
    Console.WriteLine(p.p4);
}
void method5(P5 p)
{
    Console.WriteLine(p.p0);
    Console.WriteLine(p.p1);
    Console.WriteLine(p.p2);
    Console.WriteLine(p.p3);
    Console.WriteLine(p.p4);
    Console.WriteLine(p.p5);
}
void method6(P6 p)
{
    Console.WriteLine(p.p0);
    Console.WriteLine(p.p1);
    Console.WriteLine(p.p2);
    Console.WriteLine(p.p3);
    Console.WriteLine(p.p4);
    Console.WriteLine(p.p5);
    Console.WriteLine(p.p6);
}
void method7(P7 p)
{
    Console.WriteLine(p.p0);
    Console.WriteLine(p.p1);
    Console.WriteLine(p.p2);
    Console.WriteLine(p.p3);
    Console.WriteLine(p.p4);
    Console.WriteLine(p.p5);
    Console.WriteLine(p.p6);
    Console.WriteLine(p.p7);
}
void method8(P8 p)
{
    Console.WriteLine(p.p0);
    Console.WriteLine(p.p1);
    Console.WriteLine(p.p2);
    Console.WriteLine(p.p3);
    Console.WriteLine(p.p4);
    Console.WriteLine(p.p5);
    Console.WriteLine(p.p6);
    Console.WriteLine(p.p7);
    Console.WriteLine(p.p8);
}
void method9(P9 p)
{
    Console.WriteLine(p.p0);
    Console.WriteLine(p.p1);
    Console.WriteLine(p.p2);
    Console.WriteLine(p.p3);
    Console.WriteLine(p.p4);
    Console.WriteLine(p.p5);
    Console.WriteLine(p.p6);
    Console.WriteLine(p.p7);
    Console.WriteLine(p.p8);
    Console.WriteLine(p.p9);
}



struct P0
{
    public string p0;
}

struct P1
{
    public string p0;
    public int p1;
}

struct P2
{
    public string p0;
    public int p1;
    public char p2;
}

struct P3
{
    public string p0;
    public int p1;
    public char p2;
    public int p3;
}

struct P4
{
    public string p0;
    public int p1;
    public char p2;
    public int p3;
    public double p4;
}

struct P5
{
    public string p0;
    public int p1;
    public char p2;
    public int p3;
    public double p4;
    public string p5;
}

struct P6
{
    public string p0;
    public int p1;
    public char p2;
    public int p3;
    public double p4;
    public string p5;
    public int p6;
}

struct P7
{
    public string p0;
    public int p1;
    public char p2;
    public int p3;
    public double p4;
    public string p5;
    public int p6;
    public char p7;
}

struct P8
{
    public string p0;
    public int p1;
    public char p2;
    public int p3;
    public double p4;
    public string p5;
    public int p6;
    public char p7;
    public int p8;
}

struct P9
{
    public string p0;
    public int p1;
    public char p2;
    public int p3;
    public double p4;
    public string p5;
    public int p6;
    public char p7;
    public int p8;
    public double p9;
}