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
                              "\n3. Exercício 3" +
                              "\n4. Exercício 4" +
                              "\n8. Exercício 8" +
                              "\n9. Exercício 9" + 
                              "\n16. Exercício 16" +
                              "\n23. Exercício 23" +
                              "\n26. Exercício 26" +
                              "\n27. Exercício 27" +
                              "\n28. Exercício 28-Vetor" + 
                              "\n29. Exercício 29-Vetor" +
                              "\n30. Exercício 30-Vetor" +
                              "\n31. Exercício 31-Vetor" + 
                              "\n32. Exercício 32-Vetor" +
                              "\n33. Exercício 33-Matriz"+
                              "\n34. Exercício 34-Matriz");
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
                    case 3:
                        Console.WriteLine("Exercício 03");
                        Console.WriteLine("Informe o valor em Dólar: ");
                        double dolar = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe a cotação do dia: ");
                        double cotacao = Convert.ToDouble(Console.ReadLine());
                        //Operação
                        double resultado = modelo.ConverterDolarReal(dolar, cotacao);
                        if (resultado == -1)
                        {
                            Console.WriteLine("Valores Informados não são válidos, digite novamente!");
                        }
                        else {
                            Console.WriteLine($"O valor U$ {dolar} em Real é R$ {resultado}");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Exercício 04");
                        Console.WriteLine("Informe o lado");
                        double lado = Convert.ToDouble(Console.ReadLine());

                        resultado = modelo.PerimetroQuadrado(lado);
                        if(resultado == -1)
                        {
                            Console.WriteLine("Impossível calcular perímetro negativo!");
                        }
                        else
                        {
                            Console.WriteLine($"O perímetro é: {resultado}");
                        }
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
                    case 23:
                        Console.WriteLine("Exercício 23");
                        Console.WriteLine("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        //Mostrar
                        Console.WriteLine($"A soma dos digitos é: {modelo.ContarLetras(num)}");
                        break;
                    case 26:
                        Console.WriteLine("Exercício 26");
                        Console.WriteLine("Informe o valor em Decimal: ");
                        int decim = Convert.ToInt32(Console.ReadLine());

                        //Mostrar
                        Console.WriteLine($"Valor em Binário {modelo.Inverter(modelo.ConverterDecimalBinario(decim))}");
                        break;
                    case 27:
                        Console.WriteLine("Exercício 27");
                        Console.WriteLine("Informe o número em Decimal: ");
                        decim = Convert.ToInt32(Console.ReadLine());

                        //Mostrar
                        Console.WriteLine($"Valor em Hexadecimal: {modelo.ConverterHexadecimal(decim)}");
                        break;
                    case 28:
                        Console.WriteLine("Exercício 28");
                        //Mostrar
                        modelo.PreencherVetor();
                        break;
                    case 29:
                        Console.WriteLine("Exercício 29");
                        //mostrar
                        modelo.ConsultarVetor();
                        break;
                    case 30:
                        Console.WriteLine("Exercício 30");
                        //Mostrar
                        Console.WriteLine("Informe a idade que deseja procurar");
                        int idade = Convert.ToInt32(Console.ReadLine());
                        //Buscar no método
                        modelo.BuscarIdade(idade);
                        break;
                    case 31:
                        Console.WriteLine("Exercício 31 - Vetor");
                        //Preencher o vetor
                        modelo.PreencherVet();
                        modelo.MostrarVet();
                        break;
                    case 32:
                        Console.WriteLine("Exercício 32 - Vetor");
                        //PreencherVetor
                        modelo.PreencherVet();
                        modelo.MostrarInverso();
                        break;
                    case 33:
                        Console.WriteLine("Exercício 33 - Matriz");
                        //PreencherMatriz
                        modelo.PreencherMatriz();
                        modelo.MostrarMatriz();
                        break;
                    case 34:
                        Console.WriteLine("Exercício 34 - Matriz");
                        //Preencher a Matriz e Mostrar
                        modelo.PreencherZero();
                        modelo.MostrarMatriz();
                        break;
                    default:
                        Console.WriteLine("Opção escolhida não é válida!");
                        break;
                }//fim do escolha
            } while (ModificarOpcao != 0);
        }//fim do método
    }//fim da classe
}//fim do projeto
