using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string fullName = ("Костев Николай Геннадьевич");
            string email = ("genakosteq");
            int age = 29;
            double scoreProg = 70;
            double scoreMath = 65;
            double scorePhis = 60;
            double summScore = scoreProg + scoreMath + scorePhis;
            double averScore = summScore / 3;
            Console.WriteLine("Ф.И.O: {0} \nEmail: {1} \nВозраст: {2} \nБаллы по программированию: {3} \nБаллы по математике: {4} \nБаллы по физике: {5}",
                              fullName,
                              email, 
                              age,
                              scoreProg,
                              scoreMath,
                              scorePhis);//Форматированный вывод
            //string pattern = "Ф.И.O: {0} \nEmail: {1} \nВозраст: {2} \nБаллы по программированию: {3} \nБаллы по математике: {4} \nБаллы по физике: {5}";//создание переменной для форматированного вывода
            //Console.WriteLine(pattern,
            //                  fullName,
            //                  email,
            //                  age,
            //                  scoreProg,
            //                  scoreMath,
            //                  scorePhis);

            //Console.ReadKey();

            //Console.WriteLine($"Ф.И.O: {fullName} \nEmail: {email} \nВозраст: {age} \nБаллы по программированию: {scoreProg} \nБаллы по математике: {scoreMath} \nБаллы по физике: {scorePhis}");
            //вывод данных сразу в консоль(интерполяция)
            Console.ReadKey();

            Console.WriteLine("Сумма баллов: {0}",summScore);

            Console.ReadKey(); 

            Console.WriteLine("Среднее баллов: {0}",averScore);

            Console.ReadKey();
        }
    }
}
