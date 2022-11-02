using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions {
    class Program {
        static void Main(string[] args) {
            Sum(5, 6);
            Sum(4, 2);
            int Mysum = GetSum(4, 2);
            PrintPerson("Сергей", 37, "ООО\"Ассоциация ВАСТ\"");
            PrintPerson("Петр", 37);
            PrintPerson("Маша", company: "Aple", age: 37);
            int[] arryInt = new int[5] { 1, 2, 3, 4, 5 };
            int sum = GetSumArrayWhithoutModif(arryInt);
            sum = GetSumArrayWhithModif(arryInt);
            string name = "Сергей";
            ModifString(ref name);
            SumWithChek(1, 2, out sum);
            PrintPerson("Петр", GetSumArrayWhithModif(arryInt));
            Console.ReadKey();
        }
        static void Sum(int x, int y) => Console.WriteLine($"{x} + {y} = {x + y}");
        static int GetSum(int x, int y) => x + y;
        static void PrintPerson(string name, int age, string company = "Undefined") {
            Console.WriteLine($"Name: {name}, Age: {age}, Company: {company}");
        }
        static int GetSumArrayWhithModif(int[] arryInt) {
            int sum = 0;
            for (int i = 0; i < arryInt.Length; i++) {
                arryInt[i]++;
                sum += arryInt[i];
            }
            return sum;
        }
        static int GetSumArrayWhithoutModif(int[] arryInt) {
            int[] newArry = new int[5];
            Array.Copy(arryInt, newArry, arryInt.Length);
            int sum = 0;
            for (int i = 0; i < newArry.Length; i++) {
                newArry[i]++;
                sum += newArry[i];
            }
            return sum;
        }
        static void ModifString(ref string str) {
            str += "!!!";
        }

        static bool SumWithChek(int x, int y, out int sum) {
            sum = x + y;
            if (x + y is int) {
                return true;
            }
            return false;
        }
        static void ModifString(ref string str, in string secondStr) {
            str += "!!!";
            //secondStr = str; нельзя, так как secondStr с параметром in
        }
    }
}
