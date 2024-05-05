namespace VisitorFiguras;

public class Cuadrado : Figura {
    public double Lado { get; set; }

    public Cuadrado(double lado) {
        Lado = lado;
    }

    public override void Accept(IVisitor visitor) {
        visitor.VisitCuadrado(this);
    }
}