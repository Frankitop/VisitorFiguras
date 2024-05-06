namespace VisitorFiguras.Visitor.ExtenderVisitor;

class CalculadoraPerimetro : IVisitor {
    
    public void VisitCirculo(Circulo circulo) {
        double perimetro = 2 * Math.PI * circulo.Radio;
        Console.WriteLine($"Círculo - Perímetro: {perimetro}");
    }

    public void VisitCuadrado(Cuadrado cuadrado) {
        double perimetro = 4 * cuadrado.Lado;
        Console.WriteLine($"Cuadrado - Perímetro: {perimetro}");
    }
}