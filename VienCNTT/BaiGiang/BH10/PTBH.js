function PTBH(a, b, c) {
    this.a = a;
    this.b = b;
    this.c = c;
    this.delta = function () {
        return Math.pow(this.b, 2) - 4 * this.a * this.c;
    }
    this.giai = function () {
        var d = this.delta();
        if (d < 0) return null;
        else {
            var x1 = (-this.b - Math.sqrt(d)) / (2 * this.a);
            var x2 = (-this.b + Math.sqrt(d)) / (2 * this.a);
            return new Nghiem(x1,x2);
        }
    }
}