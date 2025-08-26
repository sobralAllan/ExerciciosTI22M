using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosTI22M
{
    class ExerciciosControl
    {
        private int opcao;
        public ExerciciosModel modelo;//Criando a conexão com a classe modelo
        public ExerciciosControl()
        {
            this.opcao  = 0;
            this.modelo = new ExerciciosModel();//Instanciando para usar os métodos
        }//fim do método

        public int ModificarOpcao
        {
            get { return this.opcao; }
            set { this.opcao = value; }
        }//fim do modificarOpcao

        public void MostrarMenu()
        {
            Console.WriteLine("\nMenu"    +
                              "\n0. Sair" +
                              "\n1. Exercício 1" + 
                              "\n2. Exercício 2" + 
                              "\n8. Exercício 8" +
                              "\n9. Exercício 9" + 
                              "\n16. Exercício 16");
            ModificarOpcao = Convert.ToInt32(Console.ReadLine());
        }//fim do método MostrarMenu

        public void ExecutarMenu()
        {
            do
            {
                //Chamar o Menu
                MostrarMenu();
                switch (ModificarOpcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!!!");
                        break;
                    case 1:
                        Console.WriteLine("Exercício 01");
                        Console.WriteLine("Informe um número: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        //Chamar a ExercicioModel
                        Console.WriteLine(modelo.Triplo(num));
                        break;
                    case 2:
                        Console.WriteLine("Exercício 02");
                        Console.WriteLine("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(modelo.Metade(num));
                        break;
                    case 8:
                        Console.WriteLine("Exercício 08");
                        Console.WriteLine("Informe a diagonal maior: ");
                        double diagonalMaior = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe a diagonal menor: ");
                        double diagonalMenor = Convert.ToDouble(Console.ReadLine());

                        //Mostrar o resultado
                        if (modelo.AreaLosango(diagonalMaior, diagonalMenor) == -1)
                        {
                            Console.WriteLine("Os números digitados não são válidos!");
                        }
                        else
                        {
                            Console.WriteLine($"A área do Losango é: {modelo.AreaLosango(diagonalMaior, diagonalMenor)}");
                        }
                        break;
                    case 9:
                        Console.WriteLine("Exercício 09");
                        Console.WriteLine("Informe o valor do raio: ");
                        double raio = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe o valor da altura: ");
                        double altura = Convert.ToDouble(Console.ReadLine());

                        //Mostrar
                        if (modelo.VolumeCilindro(raio, altura) == -1)
                        {
                            Console.WriteLine("Os números digitados não são válidos!");
                        }
                        else
                        {
                            Console.WriteLine($"O volume do cilindro é: {modelo.VolumeCilindro(raio, altura)}");
                        }
                        break;
                    case 16:
                        Console.WriteLine("Exercício 16");
                        Console.WriteLine("Informe o seu peso: ");
                        double peso = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe sua altura: ");
                        altura = Convert.ToDouble(Console.ReadLine());
                        //Mostrar
                        Console.WriteLine(modelo.CalcularIMC(peso, altura));
                        break;
                    default:
                        Console.WriteLine("Opção escolhida não é válida!");
                        break;
                }//fim do escolha
            } while (ModificarOpcao != 0);
        }//fim do método
    }//fim da classe
}//fim do projeto
