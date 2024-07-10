class Triangulo{
    public double a, b;
    public double CalcArea(){
        return b * a / 2;
    }
}
class Circulo{
    public double r;
    public double CalcAreaC(){
        return Math.PI * (r*r);
    }
    public double CalcCirc(){
        return 2 * Math.PI * r;
    }
}