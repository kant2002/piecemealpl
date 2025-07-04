package main

import (
	"fmt"
)

type P0 struct {
    p0 string
}

type P1 struct {
    p0 string
	p1 int
}

type P2 struct {
    p0 string
	p1 int
	p2 rune
}

type P3 struct {
    p0 string
	p1 int
	p2 rune
	p3 *int
}

type P4 struct {
    p0 string
	p1 int
	p2 rune
	p3 *int
	p4 *float64
}

type P5 struct {
    p0 string
	p1 int
	p2 rune
	p3 *int
	p4 *float64
	p5 string
}

type P6 struct {
    p0 string
	p1 int
	p2 rune
	p3 *int
	p4 *float64
	p5 string
	p6 int
}

type P7 struct {
    p0 string
	p1 int
	p2 rune
	p3 *int
	p4 *float64
	p5 string
	p6 int
	p7 rune
}

type P8 struct {
    p0 string
	p1 int
	p2 rune
	p3 *int
	p4 *float64
	p5 string
	p6 int
	p7 rune
	p8 *int
}

type P9 struct {
    p0 string
	p1 int
	p2 rune
	p3 *int
	p4 *float64
	p5 string
	p6 int
	p7 rune
	p8 *int
	p9 *float64
}


func Method0(p *P0) {
	fmt.Println(p.p0)
}

func Method1(p *P1) {
	fmt.Println(p.p0)
	fmt.Printf("%d", p.p1)
}

func Method2(p *P2) {
	fmt.Println(p.p0)
	fmt.Printf("%d", p.p1)
	fmt.Printf("%c", p.p2)
}

func Method3(p *P3) {
	fmt.Println(p.p0)
	fmt.Printf("%d", p.p1)
	fmt.Printf("%c", p.p2)
	fmt.Printf("%d", *p.p3)
}

func Method4(p *P4) {
	fmt.Println(p.p0)
	fmt.Printf("%d", p.p1)
	fmt.Printf("%c", p.p2)
	fmt.Printf("%d", *p.p3)
	fmt.Printf("%f", *p.p4)
}

func Method5(p *P5) {
	fmt.Println(p.p0)
	fmt.Printf("%d", p.p1)
	fmt.Printf("%c", p.p2)
	fmt.Printf("%d", *p.p3)
	fmt.Printf("%f", *p.p4)
	fmt.Println(p.p5)
}

func Method6(p *P6) {
	fmt.Println(p.p0)
	fmt.Printf("%d", p.p1)
	fmt.Printf("%c", p.p2)
	fmt.Printf("%d", *p.p3)
	fmt.Printf("%f", *p.p4)
	fmt.Println(p.p5)
	fmt.Printf("%d", p.p6)
}

func Method7(p *P7) {
	fmt.Println(p.p0)
	fmt.Printf("%d", p.p1)
	fmt.Printf("%c", p.p2)
	fmt.Printf("%d", *p.p3)
	fmt.Printf("%f", *p.p4)
	fmt.Println(p.p5)
	fmt.Printf("%d", p.p6)
	fmt.Printf("%c", p.p7)
}

func Method8(p *P8) {
	fmt.Println(p.p0)
	fmt.Printf("%d", p.p1)
	fmt.Printf("%c", p.p2)
	fmt.Printf("%d", *p.p3)
	fmt.Printf("%f", *p.p4)
	fmt.Println(p.p5)
	fmt.Printf("%d", p.p6)
	fmt.Printf("%c", p.p7)
	fmt.Printf("%d", *p.p8)
}

func Method9(p *P9) {
	fmt.Println(p.p0)
	fmt.Printf("%d", p.p1)
	fmt.Printf("%c", p.p2)
	fmt.Printf("%d", *p.p3)
	fmt.Printf("%f", *p.p4)
	fmt.Println(p.p5)
	fmt.Printf("%d", p.p6)
	fmt.Printf("%c", p.p7)
	fmt.Printf("%d", *p.p8)
	fmt.Printf("%f", *p.p9)
}


func main() {
	x := 123
    y := 853.6
    x2 := 282
    y2 := 363.6
	p0 := P0 { "prefix" }
    p1 := P1 { "prefix", 1 }
    p2 := P2 { "prefix", 1, 'c' }
    p3 := P3 { "prefix", 1, 'c', &x }
    p4 := P4 { "prefix", 1, 'c', &x, &y }
    p5 := P5 { "prefix", 1, 'c', &x, &y, "param" }
    p6 := P6 { "prefix", 1, 'c', &x, &y, "param", 123 }
    p7 := P7 { "prefix", 1, 'c', &x, &y, "param", 123, 'd' }
    p8 := P8 { "prefix", 1, 'c', &x, &y, "param", 123, 'd', &x2 }
    p9 := P9 { "prefix", 1, 'c', &x, &y, "param", 123, 'd', &x2, &y2 }
    Method0(&p0)
    Method1(&p1)
    Method2(&p2)
    Method3(&p3)
    Method4(&p4)
    Method5(&p5)
    Method6(&p6)
    Method7(&p7)
    Method8(&p8)
    Method9(&p9)
}
