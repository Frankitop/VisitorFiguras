namespace VisitorFiguras;

public interface IVisitor
{
    void VisitCirculo(Circulo circulo);
    void VisitCuadrado(Cuadrado cuadrado);
}