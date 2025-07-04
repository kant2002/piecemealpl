mod basefun;

fn main() {
    let x: i32 = 123;
    let y: f64 = 853.6;
    let x2: i32 = 282;
    let y2: f64 = 363.6;
	basefun::method0("prefix");
	basefun::method1("prefix", 1);
	basefun::method2("prefix", 1, 'c');
	basefun::method3("prefix", 1, 'c', &x);
	basefun::method4("prefix", 1, 'c', &x, &y);
	basefun::method5("prefix", 1, 'c', &x, &y, "param");
	basefun::method6("prefix", 1, 'c', &x, &y, "param", 123);
	basefun::method7("prefix", 1, 'c', &x, &y, "param", 123, 'd');
	basefun::method8("prefix", 1, 'c', &x, &y, "param", 123, 'd', &x2);
	basefun::method9("prefix", 1, 'c', &x, &y, "param", 123, 'd', &x2, &y2);
}
