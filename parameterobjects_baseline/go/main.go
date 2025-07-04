package main

import (
	"fmt"
)

func Method0(p0 string) {
	fmt.Println(p0)
}

func Method1(p0 string, p1 int) {
	fmt.Println(p0)
	fmt.Printf("%d", p1)
}

func Method2(p0 string, p1 int, p2 rune) {
	fmt.Println(p0)
	fmt.Printf("%d", p1)
	fmt.Printf("%c", p2)
}

func Method3(p0 string, p1 int, p2 rune, p3 *int) {
	fmt.Println(p0)
	fmt.Printf("%d", p1)
	fmt.Printf("%c", p2)
	fmt.Printf("%d", *p3)
}

func Method4(p0 string, p1 int, p2 rune, p3 *int, p4 *float64) {
	fmt.Println(p0)
	fmt.Printf("%d", p1)
	fmt.Printf("%c", p2)
	fmt.Printf("%d", *p3)
	fmt.Printf("%f", *p4)
}

func Method5(p0 string, p1 int, p2 rune, p3 *int, p4 *float64, p5 string) {
	fmt.Println(p0)
	fmt.Printf("%d", p1)
	fmt.Printf("%c", p2)
	fmt.Printf("%d", *p3)
	fmt.Printf("%f", *p4)
	fmt.Println(p5)
}

func Method6(p0 string, p1 int, p2 rune, p3 *int, p4 *float64, p5 string, p6 int) {
	fmt.Println(p0)
	fmt.Printf("%d", p1)
	fmt.Printf("%c", p2)
	fmt.Printf("%d", *p3)
	fmt.Printf("%f", *p4)
	fmt.Println(p5)
	fmt.Printf("%d", p6)
}

func Method7(p0 string, p1 int, p2 rune, p3 *int, p4 *float64, p5 string, p6 int, p7 rune) {
	fmt.Println(p0)
	fmt.Printf("%d", p1)
	fmt.Printf("%c", p2)
	fmt.Printf("%d", *p3)
	fmt.Printf("%f", *p4)
	fmt.Println(p5)
	fmt.Printf("%d", p6)
	fmt.Printf("%c", p7)
}

func Method8(p0 string, p1 int, p2 rune, p3 *int, p4 *float64, p5 string, p6 int, p7 rune, p8 *int) {
	fmt.Println(p0)
	fmt.Printf("%d", p1)
	fmt.Printf("%c", p2)
	fmt.Printf("%d", *p3)
	fmt.Printf("%f", *p4)
	fmt.Println(p5)
	fmt.Printf("%d", p6)
	fmt.Printf("%c", p7)
	fmt.Printf("%d", *p8)
}

func Method9(p0 string, p1 int, p2 rune, p3 *int, p4 *float64, p5 string, p6 int, p7 rune, p8 *int, p9 *float64) {
	fmt.Println(p0)
	fmt.Printf("%d", p1)
	fmt.Printf("%c", p2)
	fmt.Printf("%d", *p3)
	fmt.Printf("%f", *p4)
	fmt.Println(p5)
	fmt.Printf("%d", p6)
	fmt.Printf("%c", p7)
	fmt.Printf("%d", *p8)
	fmt.Printf("%f", *p9)
}


func main() {
	x := 123
    y := 853.6
    x2 := 282
    y2 := 363.6
    Method0("prefix")
    Method1("prefix", 1)
    Method2("prefix", 1, 'c')
    Method3("prefix", 1, 'c', &x)
    Method4("prefix", 1, 'c', &x, &y)
    Method5("prefix", 1, 'c', &x, &y, "param")
    Method6("prefix", 1, 'c', &x, &y, "param", 123)
    Method7("prefix", 1, 'c', &x, &y, "param", 123, 'd')
    Method8("prefix", 1, 'c', &x, &y, "param", 123, 'd', &x2)
    Method9("prefix", 1, 'c', &x, &y, "param", 123, 'd', &x2, &y2)
}
