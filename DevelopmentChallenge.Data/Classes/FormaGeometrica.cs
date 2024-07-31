/******************************************************************************************************************/
/******* ¿Qué pasa si debemos soportar un nuevo idioma para los reportes, o agregar más formas geométricas? *******/
/******************************************************************************************************************/

/*
 * TODO: 
 * Refactorizar la clase para respetar principios de la programación orientada a objetos.
 * Implementar la forma Trapecio/Rectangulo. 
 * Agregar el idioma Italiano (o el deseado) al reporte.
 * Se agradece la inclusión de nuevos tests unitarios para validar el comportamiento de la nueva funcionalidad agregada (los tests deben pasar correctamente al entregar la solución, incluso los actuales.)
 * Una vez finalizado, hay que subir el código a un repo GIT y ofrecernos la URL para que podamos utilizar la nueva versión :).
 */

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace DevelopmentChallenge.Data.Classes
//{
//    public class FormaGeometrica
//    {
//        #region Formas

//        public const int Cuadrado = 1;
//        public const int TrianguloEquilatero = 2;
//        public const int Circulo = 3;
//        public const int Trapecio = 4;

//        #endregion

//        #region Idiomas

//        public const int Castellano = 1;
//        public const int Ingles = 2;

//        #endregion

//        private readonly decimal _lado;

//        public int Tipo { get; set; }

//        public FormaGeometrica(int tipo, decimal ancho)
//        {
//            Tipo = tipo;
//            _lado = ancho;
//        }

//        public static string Imprimir(List<FormaGeometrica> formas, int idioma)
//        {
//            var sb = new StringBuilder();

//            if (!formas.Any())
//            {
//                if (idioma == Castellano)
//                    sb.Append("<h1>Lista vacía de formas!</h1>");
//                else
//                    sb.Append("<h1>Empty list of shapes!</h1>");
//            }
//            else
//            {
//                // Hay por lo menos una forma
//                // HEADER
//                if (idioma == Castellano)
//                    sb.Append("<h1>Reporte de Formas</h1>");
//                else
//                    // default es inglés
//                    sb.Append("<h1>Shapes report</h1>");

//                var numeroCuadrados = 0;
//                var numeroCirculos = 0;
//                var numeroTriangulos = 0;

//                var areaCuadrados = 0m;
//                var areaCirculos = 0m;
//                var areaTriangulos = 0m;

//                var perimetroCuadrados = 0m;
//                var perimetroCirculos = 0m;
//                var perimetroTriangulos = 0m;

//                for (var i = 0; i < formas.Count; i++)
//                {
//                    if (formas[i].Tipo == Cuadrado)
//                    {
//                        numeroCuadrados++;
//                        areaCuadrados += formas[i].CalcularArea();
//                        perimetroCuadrados += formas[i].CalcularPerimetro();
//                    }
//                    if (formas[i].Tipo == Circulo)
//                    {
//                        numeroCirculos++;
//                        areaCirculos += formas[i].CalcularArea();
//                        perimetroCirculos += formas[i].CalcularPerimetro();
//                    }
//                    if (formas[i].Tipo == TrianguloEquilatero)
//                    {
//                        numeroTriangulos++;
//                        areaTriangulos += formas[i].CalcularArea();
//                        perimetroTriangulos += formas[i].CalcularPerimetro();
//                    }
//                }

//                sb.Append(ObtenerLinea(numeroCuadrados, areaCuadrados, perimetroCuadrados, Cuadrado, idioma));
//                sb.Append(ObtenerLinea(numeroCirculos, areaCirculos, perimetroCirculos, Circulo, idioma));
//                sb.Append(ObtenerLinea(numeroTriangulos, areaTriangulos, perimetroTriangulos, TrianguloEquilatero, idioma));

//                // FOOTER
//                sb.Append("TOTAL:<br/>");
//                sb.Append(numeroCuadrados + numeroCirculos + numeroTriangulos + " " + (idioma == Castellano ? "formas" : "shapes") + " ");
//                sb.Append((idioma == Castellano ? "Perimetro " : "Perimeter ") + (perimetroCuadrados + perimetroTriangulos + perimetroCirculos).ToString("#.##") + " ");
//                sb.Append("Area " + (areaCuadrados + areaCirculos + areaTriangulos).ToString("#.##"));
//            }

//            return sb.ToString();
//        }

//        private static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, int tipo, int idioma)
//        {
//            if (cantidad > 0)
//            {
//                if (idioma == Castellano)
//                    return $"{cantidad} {TraducirForma(tipo, cantidad, idioma)} | Area {area:#.##} | Perimetro {perimetro:#.##} <br/>";

//                return $"{cantidad} {TraducirForma(tipo, cantidad, idioma)} | Area {area:#.##} | Perimeter {perimetro:#.##} <br/>";
//            }

//            return string.Empty;
//        }

//        private static string TraducirForma(int tipo, int cantidad, int idioma)
//        {
//            switch (tipo)
//            {
//                case Cuadrado:
//                    if (idioma == Castellano) return cantidad == 1 ? "Cuadrado" : "Cuadrados";
//                    else return cantidad == 1 ? "Square" : "Squares";
//                case Circulo:
//                    if (idioma == Castellano) return cantidad == 1 ? "Círculo" : "Círculos";
//                    else return cantidad == 1 ? "Circle" : "Circles";
//                case TrianguloEquilatero:
//                    if (idioma == Castellano) return cantidad == 1 ? "Triángulo" : "Triángulos";
//                    else return cantidad == 1 ? "Triangle" : "Triangles";
//            }

//            return string.Empty;
//        }

//        public decimal CalcularArea()
//        {
//            switch (Tipo)
//            {
//                case Cuadrado: return _lado * _lado;
//                case Circulo: return (decimal)Math.PI * (_lado / 2) * (_lado / 2);
//                case TrianguloEquilatero: return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
//                default:
//                    throw new ArgumentOutOfRangeException(@"Forma desconocida");
//            }
//        }

//        public decimal CalcularPerimetro()
//        {
//            switch (Tipo)
//            {
//                case Cuadrado: return _lado * 4;
//                case Circulo: return (decimal)Math.PI * _lado;
//                case TrianguloEquilatero: return _lado * 3;
//                default:
//                    throw new ArgumentOutOfRangeException(@"Forma desconocida");
//            }
//        }
//    }
//}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Classes
{
    public abstract class FormaGeometricaBase
    {
        public abstract decimal CalcularArea();
        public abstract decimal CalcularPerimetro();
    }

    public class Cuadrado : FormaGeometricaBase
    {
        private readonly decimal _lado;

        public Cuadrado(decimal lado)
        {
            _lado = lado;
        }

        public override decimal CalcularArea()
        {
            return _lado * _lado;
        }

        public override decimal CalcularPerimetro()
        {
            return _lado * 4;
        }
    }

    public class Circulo : FormaGeometricaBase
    {
        private readonly decimal _radio;

        public Circulo(decimal radio)
        {
            _radio = radio;
        }

        public override decimal CalcularArea()
        {
            return (decimal)Math.PI * _radio * _radio;
        }

        public override decimal CalcularPerimetro()
        {
            return 2 * (decimal)Math.PI * _radio;
        }
    }

    public class TrianguloEquilatero : FormaGeometricaBase
    {
        private readonly decimal _lado;

        public TrianguloEquilatero(decimal lado)
        {
            _lado = lado;
        }

        public override decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
        }

        public override decimal CalcularPerimetro()
        {
            return _lado * 3;
        }
    }

    public class Trapecio : FormaGeometricaBase
    {
        private readonly decimal _baseMayor;
        private readonly decimal _baseMenor;
        private readonly decimal _altura;
        private readonly decimal _ladoInclinado;

        public Trapecio(decimal baseMayor, decimal baseMenor, decimal altura, decimal ladoInclinado)
        {
            _baseMayor = baseMayor;
            _baseMenor = baseMenor;
            _altura = altura;
            _ladoInclinado = ladoInclinado;
        }

        public override decimal CalcularArea()
        {
            return ((_baseMayor + _baseMenor) / 2) * _altura;
        }

        public override decimal CalcularPerimetro()
        {
            return _baseMayor + _baseMenor + 2 * _ladoInclinado;
        }
    }

    public static class FormaGeometricaFactory
    {
        public static FormaGeometricaBase CrearFormaGeometrica(int tipo, params decimal[] parametros)
        {
            switch (tipo)
            {
                case 1: return new Cuadrado(parametros[0]);
                case 2: return new TrianguloEquilatero(parametros[0]);
                case 3: return new Circulo(parametros[0]);
                case 4: return new Trapecio(parametros[0], parametros[1], parametros[2], parametros[3]);
                default: throw new ArgumentException("Tipo de forma desconocido");
            }
        }
    }

    public static class Reporte
    {
        public const int Castellano = 1;
        public const int Ingles = 2;
        public const int Italiano = 3;

        public static string Imprimir(List<FormaGeometricaBase> formas, int idioma)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append(idioma == Castellano ? "<h1>Lista vacía de formas!</h1>" :
                          idioma == Italiano ? "<h1>Elenco vuoto di forme!</h1>" :
                          "<h1>Empty list of shapes!</h1>");
            }
            else
            {
                sb.Append(idioma == Castellano ? "<h1>Reporte de Formas</h1>" :
                          idioma == Italiano ? "<h1>Rapporto di forme</h1>" :
                          "<h1>Shapes report</h1>");

                var numeroFormas = new Dictionary<string, int>
                {
                    { "Cuadrado", 0 },
                    { "Circulo", 0 },
                    { "Triangulo", 0 },
                    { "Trapecio", 0 }
                };

                var areaFormas = new Dictionary<string, decimal>
                {
                    { "Cuadrado", 0m },
                    { "Circulo", 0m },
                    { "Triangulo", 0m },
                    { "Trapecio", 0m }
                };

                var perimetroFormas = new Dictionary<string, decimal>
                {
                    { "Cuadrado", 0m },
                    { "Circulo", 0m },
                    { "Triangulo", 0m },
                    { "Trapecio", 0m }
                };

                foreach (var forma in formas)
                {
                    if (forma is Cuadrado)
                    {
                        numeroFormas["Cuadrado"]++;
                        areaFormas["Cuadrado"] += forma.CalcularArea();
                        perimetroFormas["Cuadrado"] += forma.CalcularPerimetro();
                    }
                    else if (forma is Circulo)
                    {
                        numeroFormas["Circulo"]++;
                        areaFormas["Circulo"] += forma.CalcularArea();
                        perimetroFormas["Circulo"] += forma.CalcularPerimetro();
                    }
                    else if (forma is TrianguloEquilatero)
                    {
                        numeroFormas["Triangulo"]++;
                        areaFormas["Triangulo"] += forma.CalcularArea();
                        perimetroFormas["Triangulo"] += forma.CalcularPerimetro();
                    }
                    else if (forma is Trapecio)
                    {
                        numeroFormas["Trapecio"]++;
                        areaFormas["Trapecio"] += forma.CalcularArea();
                        perimetroFormas["Trapecio"] += forma.CalcularPerimetro();
                    }
                }

                sb.Append(ObtenerLinea(numeroFormas["Cuadrado"], areaFormas["Cuadrado"], perimetroFormas["Cuadrado"], "Cuadrado", idioma));
                sb.Append(ObtenerLinea(numeroFormas["Circulo"], areaFormas["Circulo"], perimetroFormas["Circulo"], "Circulo", idioma));
                sb.Append(ObtenerLinea(numeroFormas["Triangulo"], areaFormas["Triangulo"], perimetroFormas["Triangulo"], "Triangulo", idioma));
                sb.Append(ObtenerLinea(numeroFormas["Trapecio"], areaFormas["Trapecio"], perimetroFormas["Trapecio"], "Trapecio", idioma));

                sb.Append("TOTAL:<br/>");
                sb.Append($"{numeroFormas.Values.Sum()} {(idioma == Castellano ? "formas" : idioma == Italiano ? "forme" : "shapes")} ");
                sb.Append($"{(idioma == Castellano ? "Perimetro" : idioma == Italiano ? "Perimetro" : "Perimeter")} {perimetroFormas.Values.Sum():#.##} ");
                sb.Append($"Area {areaFormas.Values.Sum():#.##}");
            }

            return sb.ToString();
        }

        private static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, string tipo, int idioma)
        {
            if (cantidad > 0)
            {
                string nombreForma = ObtenerNombreForma(tipo, cantidad, idioma);

                return string.Format("{0} {1} | Area {2:#.##} | {3} {4:#.##} <br/>",
                                     cantidad,
                                     nombreForma,
                                     area,
                                     idioma == Castellano ? "Perimetro" : idioma == Italiano ? "Perimetro" : "Perimeter",
                                     perimetro);
            }

            return string.Empty;
        }

        private static string ObtenerNombreForma(string tipo, int cantidad, int idioma)
        {
            if (tipo == "Cuadrado")
            {
                return idioma == Castellano ? (cantidad == 1 ? "Cuadrado" : "Cuadrados")
                       : idioma == Italiano ? (cantidad == 1 ? "Quadrato" : "Quadrati")
                       : (cantidad == 1 ? "Square" : "Squares");
            }
            else if (tipo == "Circulo")
            {
                return idioma == Castellano ? (cantidad == 1 ? "Círculo" : "Círculos")
                       : idioma == Italiano ? (cantidad == 1 ? "Cerchio" : "Cerchi")
                       : (cantidad == 1 ? "Circle" : "Circles");
            }
            else if (tipo == "Triangulo")
            {
                return idioma == Castellano ? (cantidad == 1 ? "Triángulo" : "Triángulos")
                       : idioma == Italiano ? (cantidad == 1 ? "Triangolo" : "Triangoli")
                       : (cantidad == 1 ? "Triangle" : "Triangles");
            }
            else if (tipo == "Trapecio")
            {
                return idioma == Castellano ? (cantidad == 1 ? "Trapecio" : "Trapecios")
                       : idioma == Italiano ? (cantidad == 1 ? "Trapezio" : "Trapezi")
                       : (cantidad == 1 ? "Trapezoid" : "Trapezoids");
            }

            return "Forma";
        }
    }
}
