mod basefun;

fn main() {
    let x: i32 = 123;
    let y: f64 = 853.6;
    let x2: i32 = 282;
    let y2: f64 = 363.6;
	let p0 = basefun::P0 { p0: "prefix" };
	let p1 = basefun::P1 { p0: "prefix", p1: 1 };
	let p2 = basefun::P2 { p0: "prefix", p1: 1, p2: 'c' };
	let p3 = basefun::P3 { p0: "prefix", p1: 1, p2: 'c', p3: &x };
	let p4 = basefun::P4 { p0: "prefix", p1: 1, p2: 'c', p3: &x, p4: &y };
	let p5 = basefun::P5 { p0: "prefix", p1: 1, p2: 'c', p3: &x, p4: &y, p5: "param" };
	let p6 = basefun::P6 { p0: "prefix", p1: 1, p2: 'c', p3: &x, p4: &y, p5: "param", p6: 123 };
	let p7 = basefun::P7 { p0: "prefix", p1: 1, p2: 'c', p3: &x, p4: &y, p5: "param", p6: 123, p7: 'd' };
	let p8 = basefun::P8 { p0: "prefix", p1: 1, p2: 'c', p3: &x, p4: &y, p5: "param", p6: 123, p7: 'd', p8: &x2 };
	let p9 = basefun::P9 { p0: "prefix", p1: 1, p2: 'c', p3: &x, p4: &y, p5: "param", p6: 123, p7: 'd', p8: &x2, p9: &y2 };
	basefun::method0(&p0);
	basefun::method1(&p1);
	basefun::method2(&p2);
	basefun::method3(&p3);
	basefun::method4(&p4);
	basefun::method5(&p5);
	basefun::method6(&p6);
	basefun::method7(&p7);
	basefun::method8(&p8);
	basefun::method9(&p9);
}
