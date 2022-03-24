using System;

namespace PeriodosAtras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dataHoje;
            DateTime dataInformada;
            TimeSpan dataDiasPassou;
            string opcaoMenu;

            //Data de hoje:
            Console.WriteLine("Informe a data de hoje: ");
            dataHoje = Convert.ToDateTime(Console.ReadLine());


            //Data informada pelo usuário
            Console.WriteLine("Informe uma data para saber quanto tempo passou: ");
            dataInformada = Convert.ToDateTime(Console.ReadLine());


            //Calculo:
            dataDiasPassou = dataHoje - dataInformada;


            //Opções para o usuário:
            Console.WriteLine("Digite 1 para saber a quantidade de DIAS.");
            Console.WriteLine("Digite 2 para saber a quantidade de SEMANAS.");
            Console.WriteLine("Digite 3 para saber a quantidade de MESES.");
            Console.WriteLine("Digite 4 para saber a quantidade de ANOS.");
            Console.WriteLine("Digite 5 para saber todas as opcões.");
            opcaoMenu = Console.ReadLine();


            //Para dias:
            if (opcaoMenu == "1")
            {
                Console.WriteLine($"{dataDiasPassou.Days} dia(s) atás");
            }

            
            //Para semanas:
            if(opcaoMenu == "2")
            {
                Console.WriteLine($"{dataDiasPassou.Days / 7} semana(s) atás");
            }


            //Para meses:
            if (opcaoMenu == "3")
            {
                Console.WriteLine($"{dataDiasPassou.Days / 30} mês/meses atás");
            }

            
            //Para anos:
            if(opcaoMenu=="4")
            {
                Console.WriteLine($"{dataDiasPassou.Days / 365} ano(s) atás");
            }


            //Todas as opções:
            if(opcaoMenu == "5")
            {
                Console.WriteLine($"{dataDiasPassou.Days} dia(s) atás");
                Console.WriteLine($"{dataDiasPassou.Days / 7} semana(s) atás");
                Console.WriteLine($"{dataDiasPassou.Days / 30} mês/meses atás");
                Console.WriteLine($"{dataDiasPassou.Days / 365} ano(s) atás");
            }


            









            Console.ReadLine();
            
        }
    }
}
