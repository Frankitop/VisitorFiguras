namespace VisitorFiguras;

public abstract class Figura
{
    public abstract void Accept(IVisitor visitor);
}