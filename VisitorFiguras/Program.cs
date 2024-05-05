// See https://aka.ms/new-console-template for more information

using VisitorFiguras;

List<Figura> figuras = new List<Figura> {
    new Circulo(5),
    new Cuadrado(6)
};

var calculadora = new CalculadoraAreaPerimetro();

foreach (var figura in figuras) {
    figura.Accept(calculadora);
}