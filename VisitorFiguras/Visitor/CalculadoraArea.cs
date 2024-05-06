namespace VisitorFiguras;

class CalculadoraArea : IVisitor {
    
    public void VisitCirculo(Circulo circulo) {
        double area = Math.PI * Math.Pow(circulo.Radio, 2);
        Console.WriteLine($"Círculo - Área: {area}");
    }

    public void VisitCuadrado(Cuadrado cuadrado) {
        double area = Math.Pow(cuadrado.Lado, 2);
        Console.WriteLine($"Cuadrado - Área: {area}");
    }
}