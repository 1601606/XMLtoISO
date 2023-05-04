using System;
using System.Numerics;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using Newtonsoft.Json;


namespace XMLtoISO
{

    class XMLtoISO
    {
        static void Main()
        {

            void menu()
            {
                string opcao;
                Console.WriteLine("Um produto de SimProgramming");
                Console.WriteLine("Equipa3");
                Console.WriteLine("XMLtoISO");
                Console.WriteLine("Máquinas ONA ");
                Console.WriteLine("Preparação de comando numérico.");
                Console.WriteLine("Menu");
                Console.WriteLine("1-->Programa de 1 elétrodo!");
                Console.WriteLine("2-->Programa com várias peças e elétrodos!");
                Console.WriteLine("3-->Programa com vários elétrodos!");
                Console.WriteLine("4-->Sair!");
                opcao = (Console.ReadLine());

                switch (opcao)
                {
                    case "1":
                        eletrodo();
                        break;

                    case "2":
                        pecas();
                        break;


                    case "3":
                        Console.WriteLine("Opção ainda não disponível");
                        menu();
                        //eletrodos();
                        break;

                    case "4":
                        Console.WriteLine("Escolheu sair!!");
                        break;

                };


            }
            void SeletorFicheiro(){
                
                StreamReader pontoxml = new StreamReader("DOC.XML");
                string leitor=pontoxml.ReadLine();
                pontoxml.Close();
            
            };
            void eletrodo()
            {
                string X, Y, Z, C, GAP;
                string A, B, CC, D, E;
                //decimal AA, BB, CCC, DD, EE;
                Entrada entrada;
                entrada = new Entrada();

                Console.WriteLine("Um produto de SimProgramming");
                Console.WriteLine("Equipa3");
                Console.WriteLine("XMLtoISO");
                Console.WriteLine("Máquinas ONA H400 e H600");
                Console.WriteLine("Preparação de comando numérico.");
                Console.WriteLine(entrada.doc);
                Console.WriteLine();
                Console.WriteLine("Inserir numero de eletrodo (Exemplo:1E100)");
                string TE = Console.ReadLine();
                Console.WriteLine("Inserir número de posição do garfo");
                string T = Console.ReadLine();

                Console.WriteLine("Cota X:");
                A = Console.ReadLine();
                //declaracao das constantes que constituem o metodo de Replace
                const string p = ".";
                const string s = ",";
                //aplicacao do metodo Replace
                //so assim sera possivel converter "," em "."
                //se a entrada for "." o ponto mantem-se
                string newA = A.Replace(s, p);
                X = newA;

                Console.WriteLine("Cota Y:");
                B = Console.ReadLine();
                string newB = B.Replace(s, p);
                Y = newB;

                Console.WriteLine("Cota Z:");
                CC = (Console.ReadLine());
                string newCC = CC.Replace(s, p);
                Z = newCC;

                Console.WriteLine("Cota C:");
                D = (Console.ReadLine());
                string newD = D.Replace(s, p);
                C = newD;

                Console.WriteLine("GAP:");
                E = (Console.ReadLine());
                string newE = E.Replace(s, p);
                GAP = newE;



                //modificar semantica para as variaveis, nao podem ter valores NULL
                //utilizar trycatch

                //preparar entrada de variaveis atraves de objeto convertido de XML para JSON

                StreamWriter escritor = new StreamWriter("1.PRG");
                escritor.WriteLine("ID0000TX0101%");
                escritor.WriteLine("G17 C100");
                escritor.WriteLine($"M06 X{T}");
                escritor.WriteLine("G54 X1");
                escritor.WriteLine("G98 Z0");
                escritor.WriteLine($"G28 X{ X} Y{Y} Z{Z} C{C}");
                escritor.WriteLine("G92 Z300");
                escritor.WriteLine("G00 Z30");
                switch (newE)
                {

                    case "0.1":
                        escritor.WriteLine("M96 X9510");
                        break;

                    case "0.15":
                        escritor.WriteLine("M96 X9515");
                        break;

                    case "0.2":
                        escritor.WriteLine("M96 X9520");
                        break;

                    case "0.25":
                        escritor.WriteLine("M96 X9525");
                        break;

                    case "0.3":
                        escritor.WriteLine("M96 X9530");
                        break;

                    case "0.35":
                        escritor.WriteLine("M96 X9535");
                        break;

                    case "0.4":
                        escritor.WriteLine("M96 X9540");
                        break;

                    case "0.45":
                        escritor.WriteLine("M96 X9545");
                        break;

                    case "0.5":
                        escritor.WriteLine("M96 X9550");
                        break;

                    case "0.55":
                        escritor.WriteLine("M96 X9555");
                        break;

                    case "0.6":
                        escritor.WriteLine("M96 X9560");
                        break;

                    case "0.65":
                        escritor.WriteLine("M96 X9565");
                        break;

                    case "0.7":
                        escritor.WriteLine("M96 X9570");
                        break;

                    case "0.75":
                        escritor.WriteLine("M96 X9565");
                        break;

                    case "0.8":
                        escritor.WriteLine("M96 X9565");
                        break;

                    case "0.85":
                        escritor.WriteLine("M96 X9585");
                        break;

                    case "1":
                        escritor.WriteLine("M96 X9585");
                        break;

                    default:
                        escritor.WriteLine("M96 X9530");
                        break;
                };


                escritor.WriteLine("G98 Z0");
                escritor.WriteLine("G28 Z200 C0");
                escritor.WriteLine("%");

                escritor.Close();

                Console.WriteLine($"Programa Criado com o número 1 para o elétrodo {TE}!");
                Console.ReadLine();
                menu();
            }
            void pecas()
            {
                string Xp, Yp, Zp, Cp, GAPp;
                string Ap, Bp, CCp, Dp, Ep;
                //decimal AA, BB, CCC, DD, EE;


                Console.WriteLine("Um produto de SimProgramming");
                Console.WriteLine("Equipa3");
                Console.WriteLine("XMLtoISO");
                Console.WriteLine("Máquinas ONA H400 e H600");
                Console.WriteLine("Preparação de comando numérico.");
                Console.WriteLine();
                Console.WriteLine("Inserir numero de programa a utilizar (Exemplo:1 a 8999)");
                string PRG = Console.ReadLine();
                Console.WriteLine("Inserir numero de eletrodo (Exemplo:1E100)");
                string TEp = Console.ReadLine();
                Console.WriteLine("Inserir número de posição do garfo");
                string Tp = Console.ReadLine();
                Console.WriteLine("Inserir numero de centramento de peça (Exemplo:1 a 255)");
                string TCp = Console.ReadLine();

                Console.WriteLine("Cota X:");
                Ap = Console.ReadLine();
                //declaracao das constantes que constituem o metodo de Replace
                const string p = ".";
                const string s = ",";
                //aplicacao do metodo Replace
                //so assim sera possivel converter "," em "."
                //se a entrada for "." o ponto mantem-se
                string newAp = Ap.Replace(s, p);
                Xp = newAp;

                Console.WriteLine("Cota Y:");
                Bp = Console.ReadLine();
                string newBp = Bp.Replace(s, p);
                Yp = newBp;

                Console.WriteLine("Cota Z:");
                CCp = (Console.ReadLine());
                string newCCp = CCp.Replace(s, p);
                Zp = newCCp;

                Console.WriteLine("Cota C:");
                Dp = (Console.ReadLine());
                string newDp = Dp.Replace(s, p);
                Cp = newDp;

                Console.WriteLine("GAP:");
                Ep = (Console.ReadLine());
                string newEp = Ep.Replace(s, p);
                GAPp = newEp;



                //modificar semantica para as variaveis, nao podem ter valores NULL
                //utilizar trycatch

                //preparar entrada de variaveis atraves de objeto convertido de CSV para JSON

                StreamWriter escritor = new StreamWriter($"{PRG}.PRG");
                escritor.WriteLine("ID0000TX0101%");
                escritor.WriteLine("G17 C100");
                escritor.WriteLine($"M06 X{Tp}");
                escritor.WriteLine($"G54 X{TCp}");
                escritor.WriteLine("G98 Z0");
                escritor.WriteLine($"G28 X{ Xp} Y{Yp} Z{Zp} C{Cp}");
                escritor.WriteLine("G92 Z300");
                escritor.WriteLine("G00 Z30");
                switch (newEp)
                {

                    case "0.1":
                        escritor.WriteLine("M96 X9510");
                        break;

                    case "0.15":
                        escritor.WriteLine("M96 X9515");
                        break;

                    case "0.2":
                        escritor.WriteLine("M96 X9520");
                        break;

                    case "0.25":
                        escritor.WriteLine("M96 X9525");
                        break;

                    case "0.3":
                        escritor.WriteLine("M96 X9530");
                        break;

                    case "0.35":
                        escritor.WriteLine("M96 X9535");
                        break;

                    case "0.4":
                        escritor.WriteLine("M96 X9540");
                        break;

                    case "0.45":
                        escritor.WriteLine("M96 X9545");
                        break;

                    case "0.5":
                        escritor.WriteLine("M96 X9550");
                        break;

                    case "0.55":
                        escritor.WriteLine("M96 X9555");
                        break;

                    case "0.6":
                        escritor.WriteLine("M96 X9560");
                        break;

                    case "0.65":
                        escritor.WriteLine("M96 X9565");
                        break;

                    case "0.7":
                        escritor.WriteLine("M96 X9570");
                        break;

                    case "0.75":
                        escritor.WriteLine("M96 X9565");
                        break;

                    case "0.8":
                        escritor.WriteLine("M96 X9565");
                        break;

                    case "0.85":
                        escritor.WriteLine("M96 X9585");
                        break;

                    case "1":
                        escritor.WriteLine("M96 X9585");
                        break;

                    default:
                        escritor.WriteLine("M96 X9530");
                        break;
                };


                escritor.WriteLine("G98 Z0");
                escritor.WriteLine("G28 Z200 C0");
                escritor.WriteLine("%");

                escritor.Close();

                Console.WriteLine($"Programa Criado com o número {PRG} para o elétrodo {TEp}!");
                Console.ReadLine();
                menu();
            }

            menu();

            Console.ReadLine();

            /*
        StreamReader leitor = new StreamReader("teste.txt");

        List<String> linhas = new List<string>();
        string linha = "";
        while(linha !=null)
        {
            linha = leitor.ReadLine();

            if(linha != null)
            {
                linhas.Add(linha);
            }
        }
            leitor.Close();

        Console.WriteLine(linhas[2]);

        Console.ReadLine();
            */
        }

    }
}