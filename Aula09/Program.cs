// Triangulo x = new Triangulo();                     // x = Triangulo()
// Console.WriteLine(x);                              // print(x)
// Console.WriteLine(x.CalcArea());                   // print(x.calc_area())
// Console.WriteLine("Informe o valor da base: ");
// x.b = double.Parse(Console.ReadLine());            // x.b = float(input())
// Console.WriteLine("Informe o valor da altura: ");
// x.a = double.Parse(Console.ReadLine());
// Console.WriteLine(x.CalcArea());

Circulo x = new Circulo();
Console.WriteLine("Informe o valor do raio do circulo: ");
x.r = double.Parse(Console.ReadLine());
Console.WriteLine("Area: ");
Console.WriteLine(x.CalcAreaC());
Console.WriteLine("Circunferencia: ");
Console.WriteLine(x.CalcCirc());
