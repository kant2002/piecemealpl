#include <stdio.h>
#include <string.h>

struct P0 {
    char* p0;
};

struct P1 {
    char* p0;
    int p1;
};

struct P2 {
    char* p0;
    int p1;
    char p2;
};

struct P3 {
    char* p0;
    int p1;
    char p2;
    int* p3;
};

struct P4 {
    char* p0;
    int p1;
    char p2;
    int* p3;
    double* p4;
};

struct P5 {
    char* p0;
    int p1;
    char p2;
    int* p3;
    double* p4;
    char* p5;
};

struct P6 {
    char* p0;
    int p1;
    char p2;
    int* p3;
    double* p4;
    char* p5;
    int p6;
};

struct P7 {
    char* p0;
    int p1;
    char p2;
    int* p3;
    double* p4;
    char* p5;
    int p6;
    char p7;
};

struct P8 {
    char* p0;
    int p1;
    char p2;
    int* p3;
    double* p4;
    char* p5;
    int p6;
    char p7;
    int* p8;
};

struct P9 {
    char* p0;
    int p1;
    char p2;
    int* p3;
    double* p4;
    char* p5;
    int p6;
    char p7;
    int* p8;
    double* p9;
};

void method0(struct P0* p) {
    printf(p->p0);
}
void method1(struct P1* p) {
    printf(p->p0);
    printf("%d", p->p1);
}
void method2(struct P2* p) {
    printf(p->p0);
    printf("%d", p->p1);
    printf("%d", p->p2);
}
void method3(struct P3* p) {
    printf(p->p0);
    printf("%d", p->p1);
    printf("%d", p->p2);
    printf("%d", *p->p3);
}
void method4(struct P4* p) {
    printf(p->p0);
    printf("%d", p->p1);
    printf("%d", p->p2);
    printf("%d", *p->p3);
    printf("%f", *p->p4);
}
void method5(struct P5* p) {
    printf(p->p0);
    printf("%d", p->p1);
    printf("%d", p->p2);
    printf("%d", *p->p3);
    printf("%f", *p->p4);
    printf(p->p5);
}
void method6(struct P6* p) {
    printf(p->p0);
    printf("%d", p->p1);
    printf("%d", p->p2);
    printf("%d", *p->p3);
    printf("%f", *p->p4);
    printf(p->p5);
    printf("%d", p->p6);
}
void method7(struct P7* p) {
    printf(p->p0);
    printf("%d", p->p1);
    printf("%d", p->p2);
    printf("%d", *p->p3);
    printf("%f", *p->p4);
    printf(p->p5);
    printf("%d", p->p6);
    printf("%d", p->p7);
}
void method8(struct P8* p) {
    printf(p->p0);
    printf("%d", p->p1);
    printf("%d", p->p2);
    printf("%d", *p->p3);
    printf("%f", *p->p4);
    printf(p->p5);
    printf("%d", p->p6);
    printf("%d", p->p7);
    printf("%d", *p->p8);
}
void method9(struct P9* p) {
    printf(p->p0);
    printf("%d", p->p1);
    printf("%d", p->p2);
    printf("%d", *p->p3);
    printf("%f", *p->p4);
    printf(p->p5);
    printf("%d", p->p6);
    printf("%d", p->p7);
    printf("%d", *p->p8);
    printf("%f", *p->p9);
}

int main() {
    int x = 123;
    double y = 853.6;
    int x2 = 282;
    double y2 = 363.6;
	struct P0 p0 = { "prefix" };
    struct P1 p1 = { "prefix", 1 };
    struct P2 p2 = { "prefix", 1, 'c' };
    struct P3 p3 = { "prefix", 1, 'c', &x };
    struct P4 p4 = { "prefix", 1, 'c', &x, &y };
    struct P5 p5 = { "prefix", 1, 'c', &x, &y, "param" };
    struct P6 p6 = { "prefix", 1, 'c', &x, &y, "param", 123 };
    struct P7 p7 = { "prefix", 1, 'c', &x, &y, "param", 123, 'd' };
    struct P8 p8 = { "prefix", 1, 'c', &x, &y, "param", 123, 'd', &x2 };
    struct P9 p9 = { "prefix", 1, 'c', &x, &y, "param", 123, 'd', &x2, &y2 };
    method0(&p0);
    method1(&p1);
    method2(&p2);
    method3(&p3);
    method4(&p4);
    method5(&p5);
    method6(&p6);
    method7(&p7);
    method8(&p8);
    method9(&p9);
    return 0;
}