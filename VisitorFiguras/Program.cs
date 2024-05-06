// See https://aka.ms/new-console-template for more information

using VisitorFiguras;
using VisitorFiguras.Visitor.ExtenderVisitor;

List<Figura> figuras = new List<Figura> {
    new Circulo(5),
    new Cuadrado(6)
};

var calculadoraArea = new CalculadoraArea();

foreach (var figura in figuras) {
    figura.Accept(calculadoraArea);
}


var calculadoraPerimetro = new CalculadoraPerimetro();

foreach (var figura in figuras) {
    figura.Accept(calculadoraPerimetro);
}