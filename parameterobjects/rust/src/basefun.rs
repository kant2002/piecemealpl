

pub struct P0<'a>  {
    pub p0: &'a str,
}

pub struct P1<'a>  {
    pub p0: &'a str,
	pub p1: i32,
}

pub struct P2<'a>  {
    pub p0: &'a str,
	pub p1: i32,
	pub p2: char,
}

pub struct P3<'a>  {
    pub p0: &'a str,
	pub p1: i32,
	pub p2: char,
	pub p3: &'a i32,
}

pub struct P4<'a>  {
    pub p0: &'a str,
	pub p1: i32,
	pub p2: char,
	pub p3: &'a i32,
	pub p4: &'a f64,
}

pub struct P5<'a>  {
    pub p0: &'a str,
	pub p1: i32,
	pub p2: char,
	pub p3: &'a i32,
	pub p4: &'a f64,
	pub p5: &'a str,
}

pub struct P6<'a>  {
    pub p0: &'a str,
	pub p1: i32,
	pub p2: char,
	pub p3: &'a i32,
	pub p4: &'a f64,
	pub p5: &'a str,
	pub p6: i32,
}

pub struct P7<'a>  {
    pub p0: &'a str,
	pub p1: i32,
	pub p2: char,
	pub p3: &'a i32,
	pub p4: &'a f64,
	pub p5: &'a str,
	pub p6: i32,
	pub p7: char,
}

pub struct P8<'a>  {
    pub p0: &'a str,
	pub p1: i32,
	pub p2: char,
	pub p3: &'a i32,
	pub p4: &'a f64,
	pub p5: &'a str,
	pub p6: i32,
	pub p7: char,
	pub p8: &'a i32,
}

pub struct P9<'a>  {
    pub p0: &'a str,
	pub p1: i32,
	pub p2: char,
	pub p3: &'a i32,
	pub p4: &'a f64,
	pub p5: &'a str,
	pub p6: i32,
	pub p7: char,
	pub p8: &'a i32,
	pub p9: &'a f64,
}
pub fn method0(p: &P0) {
	println!("{}", p.p0);
}
pub fn method1(p: &P1) {
	println!("{}", p.p0);
	println!("{}", p.p1);
}
pub fn method2(p: &P2) {
	println!("{}", p.p0);
	println!("{}", p.p1);
	println!("{}", p.p2);
}
pub fn method3(p: &P3) {
	println!("{}", p.p0);
	println!("{}", p.p1);
	println!("{}", p.p2);
	println!("{}", p.p3);
}
pub fn method4(p: &P4) {
	println!("{}", p.p0);
	println!("{}", p.p1);
	println!("{}", p.p2);
	println!("{}", p.p3);
	println!("{}", p.p4);
}
pub fn method5(p: &P5) {
	println!("{}", p.p0);
	println!("{}", p.p1);
	println!("{}", p.p2);
	println!("{}", p.p3);
	println!("{}", p.p4);
	println!("{}", p.p5);
}
pub fn method6(p: &P6) {
	println!("{}", p.p0);
	println!("{}", p.p1);
	println!("{}", p.p2);
	println!("{}", p.p3);
	println!("{}", p.p4);
	println!("{}", p.p5);
	println!("{}", p.p6);
}
pub fn method7(p: &P7) {
	println!("{}", p.p0);
	println!("{}", p.p1);
	println!("{}", p.p2);
	println!("{}", p.p3);
	println!("{}", p.p4);
	println!("{}", p.p5);
	println!("{}", p.p6);
	println!("{}", p.p7);
}
pub fn method8(p: &P8) {
	println!("{}", p.p0);
	println!("{}", p.p1);
	println!("{}", p.p2);
	println!("{}", p.p3);
	println!("{}", p.p4);
	println!("{}", p.p5);
	println!("{}", p.p6);
	println!("{}", p.p7);
	println!("{}", *p.p8);
}
pub fn method9(p: &P9) {
	println!("{}", p.p0);
	println!("{}", p.p1);
	println!("{}", p.p2);
	println!("{}", p.p3);
	println!("{}", p.p4);
	println!("{}", p.p5);
	println!("{}", p.p6);
	println!("{}", p.p7);
	println!("{}", p.p8);
	println!("{}", p.p9);
}
