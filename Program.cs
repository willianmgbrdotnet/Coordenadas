using System; 
using System.Globalization;

class Program {

    static void Main(string[] args) { 
        //complete os espaços em branco com sua solução para o problema

          string[] valores = Console.ReadLine().Split(' ');
            double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double y = double.Parse(valores[1], CultureInfo.InvariantCulture);

            if (               ) {
                Console.WriteLine("Origem");
            }
            else if (x ==    ) {
                Console.WriteLine("Eixo Y");
            }
            else if (y ==     ) {
                Console.WriteLine("Eixo X");
            }
            else if (x >    && y >     ) {
                Console.WriteLine(       );
            }
            else if (x < 0.0 && y > 0.0) {
                Console.WriteLine(      );
            }
            else if (x < 0.0 && y < 0.0) {
                Console.WriteLine(      );
            }
            else {
                Console.WriteLine("     ");
            }

    }

}