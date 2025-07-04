#include <stdio.h>
#include <string.h>

void method0(char* p0) {
    printf(p0);
}
void method1(char* p0, int p1) {
    printf(p0);
    printf("%d", p1);
}
void method2(char* p0, int p1, char p2) {
    printf(p0);
    printf("%d", p1);
    printf("%d", p2);
}
void method3(char* p0, int p1, char p2, int* p3) {
    printf(p0);
    printf("%d", p1);
    printf("%d", p2);
    printf("%d", *p3);
}
void method4(char* p0, int p1, char p2, int* p3, double* p4) {
    printf(p0);
    printf("%d", p1);
    printf("%d", p2);
    printf("%d", *p3);
    printf("%f", *p4);
}
void method5(char* p0, int p1, char p2, int* p3, double* p4, char* p5) {
    printf(p0);
    printf("%d", p1);
    printf("%d", p2);
    printf("%d", *p3);
    printf("%f", *p4);
    printf(p5);
}
void method6(char* p0, int p1, char p2, int* p3, double* p4, char* p5, int p6) {
    printf(p0);
    printf("%d", p1);
    printf("%d", p2);
    printf("%d", *p3);
    printf("%f", *p4);
    printf(p5);
    printf("%d", p6);
}
void method7(char* p0, int p1, char p2, int* p3, double* p4, char* p5, int p6, char p7) {
    printf(p0);
    printf("%d", p1);
    printf("%d", p2);
    printf("%d", *p3);
    printf("%f", *p4);
    printf(p5);
    printf("%d", p6);
    printf("%d", p7);
}
void method8(char* p0, int p1, char p2, int* p3, double* p4, char* p5, int p6, char p7, int* p8) {
    printf(p0);
    printf("%d", p1);
    printf("%d", p2);
    printf("%d", *p3);
    printf("%f", *p4);
    printf(p5);
    printf("%d", p6);
    printf("%d", p7);
    printf("%d", *p8);
}
void method9(char* p0, int p1, char p2, int* p3, double* p4, char* p5, int p6, char p7, int* p8, double* p9) {
    printf(p0);
    printf("%d", p1);
    printf("%d", p2);
    printf("%d", *p3);
    printf("%f", *p4);
    printf(p5);
    printf("%d", p6);
    printf("%d", p7);
    printf("%d", *p8);
    printf("%f", *p9);
}

int main() {
    int x = 123;
    double y = 853.6;
    int x2 = 282;
    double y2 = 363.6;
    method0("prefix");
    method1("prefix", 1);
    method2("prefix", 1, 'c');
    method3("prefix", 1, 'c', &x);
    method4("prefix", 1, 'c', &x, &y);
    method5("prefix", 1, 'c', &x, &y, "param");
    method6("prefix", 1, 'c', &x, &y, "param", 123);
    method7("prefix", 1, 'c', &x, &y, "param", 123, 'd');
    method8("prefix", 1, 'c', &x, &y, "param", 123, 'd', &x2);
    method9("prefix", 1, 'c', &x, &y, "param", 123, 'd', &x2, &y2);
    return 0;
}