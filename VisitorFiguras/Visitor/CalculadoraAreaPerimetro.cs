namespace VisitorFiguras;

class CalculadoraAreaPerimetro : IVisitor {
    
    public void VisitCirculo(Circulo circulo) {
        double area = Math.PI * Math.Pow(circulo.Radio, 2);
        double perimetro = 2 * Math.PI * circulo.Radio;
        Console.WriteLine($"Círculo - Área: {area}, Perímetro: {perimetro}");
    }

    public void VisitCuadrado(Cuadrado cuadrado) {
        double area = Math.Pow(cuadrado.Lado, 2);
        double perimetro = 4 * cuadrado.Lado;
        Console.WriteLine($"Cuadrado - Área: {area}, Perímetro: {perimetro}");
    }
}