namespace VisitorFiguras;

public class Circulo : Figura {
    public double Radio { get; set; }

    public Circulo(double radio) {
        Radio = radio;
    }

    public override void Accept(IVisitor visitor) {
        visitor.VisitCirculo(this);
    }
}