using System;
using System.Collections.Generic;
using System.IO;

namespace Emeliyanenko_1_1_v12
{
    class Program
    {

        static void Main(string[] args)
        {


            //1.2 Вывести на экран число e(основание натурального логарифма) с точностью до десятых
            /*float e = 2.7182818284f;
            Console.WriteLine(Math.Round(e, 2));*/


            //1.23 Составить программу вычисления значения функции y  при любом значении а.
            /*Console.WriteLine(f(1.43f));
            public static float f(float a)
            {
                return (float)(Math.Pow(a, 2) + 10) / (float)(Math.Sqrt(Math.Pow(a, 2) + 1));
            }*/


            //1.43 Даны два числа.Найти среднее арифметическое и среднее геометрическое их модулей.
            /*arif(2.5f, -34.5f);
            public static void arif(float a, float b)
            {
                if (a < 0)
                    a = -a;
                if (b < 0)
                    b = -b;

                Console.WriteLine($"Среднее арифметическое модулей числа a и b: {(float)(a + b) / 2}");
                Console.WriteLine($"Среднее геометрическое модулей числа a и b: {Math.Sqrt(a * b)}");
            }*/

            //1.53 Известна стоимость монитора, системного блока, клавиатуры и мыши.Сколько будут стоить 3 компьютера из этих элементов? N компьютеров?
            /*pricePc(3);
            public static void pricePc(int count)
            {
                float display = 7020;
                float systemBlock = 39540;
                float keyboard = 3400;
                float mouse = 2199;

                Console.WriteLine($"Стоимость {count} сборок: {(display + systemBlock + keyboard + mouse) * count} руб");
            }*/

            //1.60 Составить программу обмена значениями трех переменных величин а, b, c по следующей схеме: 
            //а) b присвоить значение c, а присвоить значение b, с присвоить значение а;
            /*int a = 4, b = 2, c = 10;
            SwapVectorValue(a, b, c, out a, out b, out c);
            Console.WriteLine($"a: {a}, b: {b}, c: {c}");
            public static void SwapVectorValue(int aIn, int bIn, int cIn, out int a, out int b, out int c)
            {
                b = cIn;
                a = bIn;
                c = aIn;
            }*/

            //б) b присвоить значение а, с присвоить значение b, а присвоить значение с
            /*int a = 4, b = 2, c = 10;
            SwapVectorValue2(a, b, c, out a, out b, out c);
            Console.WriteLine($"a: {a}, b: {b}, c: {c}");
            public static void SwapVectorValue2(int aIn, int bIn, int cIn, out int a, out int b, out int c)
            {
                b = aIn;
                a = cIn;
                c = bIn;
            }*/


            //2.2. Дана масса в килограммах.Найти число полных центнеров в ней.
            /*float kg = 100f;
            Console.WriteLine($"kg: {kg} = centner: {KgInCentner(kg)}");
            public static float KgInCentner(float kg)
            {
                return (float)Math.Round(kg * 0.01f, 2);
            }*/

            //2.3 Дана масса в килограммах.Найти число полных тонн в ней.
            /*static void Main(string[] args)
            {
                double weightInKg;

                Console.WriteLine(“Введите массу(кг): “);
                weightInKg = Convert.ToDouble(Console.ReadLine());
                double weightInT = weightInKg / 1000;

                Console.WriteLine(“{ 0}
                Кг = { 1}
                T”, weightInKg, weightInT);
                Console.ReadKey();
            }*/

            //2.11. Дано двузначное число.Получить число, образованное при перестановке цифр заданного числа
            /*int num = 94;
            Console.WriteLine(num.ChangePosNums());
            static class IntExts
            {
                public static int ChangePosNums(this int num)
                {
                    string nums = num.ToString();
                    string result = "";
                    for (int i = nums.Length - 1; i >= 0; i--)
                    {
                        result += nums[i];
                    }
                    return int.Parse(result);
                }
            }*/

            //2.21. Дано натуральное число n(n > 9). Найти: 
            /*а) число единиц в нем;
            б) число десятков в нем.*/
            /*int n = 123;
            Console.WriteLine(n.CountNums(1));
            Console.WriteLine(n.CountNums(10));
            static class IntExts
            {
                public static int CountNums(this int num, int searchNum)
                {
                    int count = 0;
                    for (int i = 10; i <= num; i++)
                    {
                        var nums = i.ToString();
                        if (nums.Contains(searchNum.ToString()))
                        {
                            count++;
                        }
                    }

                    return count;
                }
            }*/

            //2.24. Из трехзначного числа x вычли его последнюю цифру.Когда результат разделили на 10, а к частному слева приписали последнюю цифру числа x, то получилось число 237. Найти число x.
            /*Console.WriteLine(InfNum());
            public static int InfNum()
            {
                for (int i = 100; i < 999; i++)
                {
                    if ((i % 10).ToString() + ((i - i % 10) / 10).ToString() == "237")
                    {
                        return i;
                    }
                }
                return 0;
            }*/

            //2.34. Даны цифры двух целых чисел: двузначного a2a1 и однозначного b, где a1 — число единиц, a2 — число десятков.Получить цифры числа, равного сумме заданных чисел (известно, что это число двузначное). Слагаемое — двузначное число и число-результат не определять; условный оператор не использовать.
            /*Zadanie34(4,2,5);
            public static void Zadanie34(int a1, int a2, int b)
            {
                int c1, c2;
                c2 = a2 + (a1 + b) / 10;
                c1 = (a1 + b) % 10;

                Console.WriteLine($"{c2} : {c1}");
            }*/

            /*3.2. Вычислить значение логического выражения при следующих значениях логических величин X, Y и Z: X = Ложь, Y = Истина, Z = Ложь: 
            а) X или Z; 
            б) X и Y; 
            в) X и Z.*/
            /*bool X = false, Y = true, Z = false;
            Console.WriteLine($"a){X||Y}\nb){X&&Y}\nc){X&&Z}");*/

            //3.22. Вычислить значение логического выражения при всех возможных значениях логических величин X, Y и Z: 
            //а) не(X или не Y и Z);
            /*б) Y или(X и не Y или Z);
            в) не(не X и Y или Z).*/
            /*X = false; Y = true; Z = false;
            Console.WriteLine($"a){!(X||(!Y&&Z))}\n" + $"b){Y && (X && !(Y||Z))}\n" + $"c){!((!X&&Y)|| Z)}");*/


            //3.3 Вычислить значение логического выражения при следующих значениях логических величин A, B и C:A = Истина, B = Ложь, C = Ложь;
            /*а) не A и B;
            б) A или не B;
            в) A и B или C;*/
            /*static void Main(string[] args)
            {
                bool a = true;
                bool b = false;
                bool c = false;

                Console.WriteLine(“a){
                    0]”, !(a && b));
                    Console.WriteLine(“b){ 0}”, a || (!b));
                    Console.WriteLine(“c){ 0}”, (a && b) || c);
                    Console.ReadKey();
                }*/





















            //3.28.Записать условие, которое является истинным, когда:
            /*а) каждое из чисел А и В больше 100;
            б) только одно из чисел А и В четное;
            в) хотя бы одно из чисел А и В положительно;
            г) каждое из чисел А, В, С кратно трем;
            д) только одно из чисел А, В и С меньше 50;
            е) хотя бы одно из чисел А, В, С отрицательно.*/
            /*int a = 110;
            int b = 110;
            int c = 110;

            //a
            if (a > 100 && b > 100) Console.WriteLine("каждое из чисел А и В больше 100");
            //b
            if ((a % 2 == 0 && b % 2 != 0) || (a % 2 != 0 && b % 2 == 0)) Console.WriteLine("только одно из чисел А и В четное");
            //c
            if (a > 0 || b > 0) Console.WriteLine("хотя бы одно из чисел А и В положительно");
            //d
            if (a % 3 == 0 && b % 3 == 0 && c % 3 == 0) Console.WriteLine("каждое из чисел А, В, С кратно трем");
            //e
            if ((a < 50 && b >= 50 && c >= 50) || (c < 50 && b >= 50 && a >= 50) || (b < 50 && a >= 50 && c >= 50)) Console.WriteLine("только одно из чисел А, В и С меньше 50");
            //f
            if (a < 0 || b < 0 || c < 0) Console.WriteLine("хотя бы одно из чисел А, В, С отрицательно");*/















            //3.30.Записать условие, которое является истинным, когда:
            /* а) целое А кратно двум или трем;
             б) целое А не кратно трем и оканчивается нулем.*/
            /*bool a = false, b = false;
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(«vvashi dannie » +A + » » +a + » » +b);
            if (A % 2 == 0 || A % 3 == 0)
                a = true;
            if (A % 3 != 0 && A % 10 == 0)
                b = true;
            Console.WriteLine(«vvashi NEW dannie » +A + » » +a + » » +b);*/























            //4.2.Рассчитать значение у при заданном значении х:

            /*Console.WriteLine(f4_1(2));

            public static float f4_1(float x)
            {
                if (x > 0)
                {
                    return (float)Math.Sin(Math.Pow(x, 2));
                }
                else
                {
                    return 1 + 2 * (float)Math.Pow(Math.Sin(x), 2);
                }
            }*/





















            //4.12.Известны сопротивления двух несоединенных друг с другом участков электрической цепи и напряжение на каждом из них.По какому участку протекает меньший ток?
            double U1 = 5, R1 = 10, I1, I2, U2 = 10, R2 = 20;
            I1 = U1 / R1;
            I2 = U2 / R2;
            double res = I1 > I2 ? I1 : I2;
            Console.WriteLine($"{res}");



























            //4.21.Определить, является ли число a делителем числа b?
            /*a = 5;
            b = 10;
            Console.WriteLine(b % a == 0);*/





























            //4.25.Дано двузначное число. Определить:
            /*а) является ли сумма его цифр двузначным числом;
            б) больше ли числа а сумма его цифр.*/
            /*static double Vvod_Chisla(string info)
            {
                double chislo;
                string vvod;
                Console.Write("Введите " + info + ": ");
                vvod = Console.ReadLine();
                while (!Double.TryParse(vvod, out chislo))
                {
                    Console.WriteLine("Недопустимые символы в строке ввода. Ожидается число:");
                    vvod = Console.ReadLine();
                }
                return chislo;
            }
            static int Vvod_Chisla_Int(string info)
            {
                int chislo;
                string vvod;
                Console.Write("Введите " + info + ": ");
                vvod = Console.ReadLine();
                while (!Int32.TryParse(vvod, out chislo))
                {
                    Console.WriteLine("Недопустимые символы в строке ввода.Ожидается целое число:");
                    vvod = Console.ReadLine();
                }
                return chislo;
            }
            static void Main(string[] args)
            {
                m = Vvod_Chisla_Int("двузначное число");
                a = Vvod_Chisla_Int("a");
                b = m / 10 + m % 10;
                if (b >= 10) Console.WriteLine("Сумма цифр числа {0} равна {1} и является двузначным числом.", m, b);
                else Console.WriteLine("Сумма цифр числа {0} равна {1} и не является двузначным числом.", m, b);
                if (b > a) Console.WriteLine("Сумма цифр {0} больше числа {1}.", b, a);
                else Console.WriteLine("Сумма цифр {0} не больше числа {1}.", b, a);
                Console.ReadKey();
            }*/


            /*4.31.Дано трехзначное число. 
            а) Верно ли, что все его цифры одинаковые? 
            б) Определить, есть ли среди его цифр одинаковые.*/
            /*int num1 = 444;
            Console.WriteLine(num1.IsSimilar());
            Console.WriteLine(num1.IsNumSimilar());
            static class IntExts
            {
                public static bool IsSimilar(this int num)
                {
                    if (num.ToString().Length >= 3)
                    {
                        string first = num.ToString()[0].ToString();
                        for (int i = 1; i < num.ToString().Length; i++)
                        {
                            if (first != num.ToString()[i].ToString())
                            {
                                return false;
                            }
                        }
                    }
                    else
                    {
                        return false;
                    }
                    return true;
                }
                public static bool IsNumSimilar(this int num)
                {
                    if (num.ToString().Length >= 3)
                    {
                        for (int i = 0; i < num.ToString().Length; i++)
                        {
                            for (int a = 0; a < num.ToString().Length; a++)
                            {
                                if (i != a)
                                {
                                    if (num.ToString()[i].ToString() == num.ToString()[a].ToString())
                                    {
                                        return true;
                                    }
                                }
                            }
                        }
                    }
                    return false;
                }
            }*/





            //4.38. Определить, попадает ли точка с заданными координатами в область I(рис. 4.4). Для простоты принять, что точка не попадает на границу этой об- ласти.

            /*Point point = new Point(2, 1);
            Console.WriteLine((point.Y <= 2 && point.Y >= 0) && (point.X <= 3 && point.X >= 0));
            Console.WriteLine((point.Y <= 0 && point.Y >= -2) && (point.X <= 0 && point.X >= -4));*/























            //4.43 Определить, является ли число a делителем числа b или, наоборот, число b делителем числа a.Ответом должны служить сообщения “Да, одно из чисел является делителем другого” или “Нет, ни одно из чисел не является делителем другого”. 
            /*static void Main(string[] args)
            {
                int a = 40;
                int b = 4;

                if (a % b == 0)
                    Console.WriteLine("Да, число { 0} является делителем", a);

                else if (b % a == 0)
                    Console.WriteLine("Да, число { 0} является делителем", b);

                else
                    Console.WriteLine("Нет, ни одно из чисел не является делителем другого");
                Console.ReadKey();
            }*/






















            //4.48. Известен рост трех человек.Определить, одинаков ли их рост?
            /*int a = 170;
            int b = 170;
            int c = 170;
            Console.WriteLine(a == b && b == c);*/





























            //4.58. Дано трехзначное число.Определить: а) входят ли в него цифры 4 или 7; б) входят ли в него цифры 3, 6 или 9
            /*num = 954;
            Console.WriteLine(num.SearchNum(4) || num.SearchNum(7));
            Console.WriteLine(num.SearchNum(3) && num.SearchNum(6) || num.SearchNum(9));

            static class IntExts
            {
                public static bool SearchNum(this int num, int searchNum)
                {
                    if (num.ToString().Contains(searchNum.ToString()))
                    {
                        return true;
                    }

                    return false;
                }
            }*/




















            //4.105. Составить программу, которая в зависимости от порядкового номера дня месяца(1, 2, ..., 12) выводит на экран его название(январь, февраль, ..., де- кабрь).
            /*int month = 4;
            Console.WriteLine(GetMonth(month));
            public static string GetMonth(int numM)
            {
                switch (numM)
                {
                    case 1:
                        return "Январь";
                    case 2:
                        return "Февраль";
                    case 3:
                        return "Март";
                    case 4:
                        return "Апрель";
                    case 5:
                        return "Май";
                    case 6:
                        return "Июнь";
                    case 7:
                        return "Июль";
                    case 8:
                        return "Август";
                    case 9:
                        return "Сентябрь";
                    case 10:
                        return "Октябрь";
                    case 11:
                        return "Ноябрь";
                    case 12:
                        return "Декабрь";
                    default:
                        return "Error";
                }
            }*/













            //5.13 Напечатать таблицу умножения на 7:


            /*static void Main(string[] args)
            {
                const int num = 7;
                for (int i = 1; i <= 9; i++)
                {
                    Console.WriteLine($"{ i}x { num} = { i * num}");
                }
                Console.ReadKey();
            }*/






















            //5.2. Составить программу вывода любого числа любое заданное число раз в виде, аналогичном показанному в предыдущей задаче.
            /*404.Print(10);
            static class IntExts
            {
                public static void Print(this object value, int count)
                {
                    for (int i = 0; i < count; i++)
                    {
                        Console.Write(value + " ");
                    }
                    Console.WriteLine();
                }
            }*/






















            //6.2. Дана непустая последовательность неотрицательных целых чисел, оканчивающаяся отрицательным числом.Найти среднее арифметическое всех чисел последовательности (без учета отрицательного числа).
            /*int[] ints = { 2, 5, 7, 1, 2, 5, 33, 66, 3, -2 };
            int resul = 0;
            foreach (var item in ints)
            {
                if (item >= 0)
                {
                    resul += item;
                }
            }
            Console.WriteLine(resul);*/
























            //7.2.Вывести на экран все целые числа от a до b, кратные некоторому числу c.
            /*PrintAllNumsAtNum(5, 14, 2);
            public static void PrintAllNumsAtNum(int a, int b, int c)
            {
                for (int i = a; i < b; i++)
                {
                    if (i % c == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
                Console.WriteLine();
            }*/
























            //7.3 Найти сумму положительных нечетных чисел, меньших 50.
            /*static void Main(string[] args)
            {
                int sum = 0;

                for (int i = 1; i < 50; i++)
                {
                    if (i % 2 != 0)
                    {
                        sum += i;
                    }
                }
                Console.WriteLine("Cумма нечетных чисел: { 0}", sum);

            Console.ReadKey();
            }*/






















            //7.12.Найти сумму целых положительных чисел, больших 30 и меньших 100, кратных трем и оканчивающихся на 2, 4 и 8.
            for (int i = 31; i < 100; i++)
            {
                if (i % 3 == 0 && (i % 10 == 2 || i % 10 == 4 || i % 10 == 8))
                {
                    Console.Write(i + " ");
                }
            }


























            //7.21.Известны данные о стоимости каждого товара из группы. Найти общую стоимость тех товаров, которые стоят дороже 1000 рублей (количество таких то- варов неизвестно).
            /*List<int> itemsPrice = new List<int>() { 3100, 4235, 123, 543, 1244, 6789, 12 };
            int sumPrice = 0;
            foreach (var item in itemsPrice)
            {
                sumPrice += item;
            }
            Console.WriteLine(sumPrice);*/


























            //8.2.Напечатать числа в виде следующей таблицы:

            /*PrintNumsForInFor();
            Console.WriteLine();
            PrintNumsForInFor2();
            public static void PrintNumsForInFor()
            {
                for (int i = 1; i <= 5; i++)
                {
                    for (int a = 0; a < i; a++)
                    {
                        Console.Write(5 + " ");
                    }
                    Console.WriteLine();
                }
            }
            public static void PrintNumsForInFor2()
            {
                for (int i = 5; i >= 1; i--)
                {
                    for (int a = 0; a < i; a++)
                    {
                        Console.Write(1 + " ");
                    }
                    Console.WriteLine();
                }
            }*/














            //8.28.Найти все целые числа из промежутка от 200 до 500, у которых ровно шесть делителей.
            /*int countDivide = 0;
            for (int i = 200; i < 500; i++)
            {
                countDivide = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        countDivide++;
                    }
                }
                if (countDivide == 6)
                {
                    Console.Write(i + " ");
                }
            }*/






















            //9.2.Составить программу, которая запрашивает название футбольной команды и повторяет его на экране со словами "— это чемпион!".
            /*string comanda = Console.ReadLine();
            Console.WriteLine(comanda + " — это чемпион!");*/





























            //9.14.Дано слово.Вывести на экран его последний символ.
            /*string text9_14 = "qwerty";
            Console.WriteLine(text9_14[text9_14.Length - 1]);*/





























            //9.42.Составить программу, которая печатает заданное слово, начиная с последней буквы.
            /*string text9_42 = "qwerty";
            for (int i = text9_42.Length - 1; i >= 0; i--)
            {
                Console.Write(text9_42[i]);
            }*/




























            /*9.76.Дано предложение, в котором имеется несколько букв е. Найти: 
            а) порядковый номер первой из них;
            б) порядковый номер последней из них.*/
            /*string text9_76 = "qwerty rfgklsdkg srtgsktjmg ergwg wsergtrw";

            for (int i = 0; i < text9_76.Length; i++)
            {
                if (text9_76[i] == 'e')
                {
                    Console.Write(text9_76[i]);
                    break;
                }
            }
            for (int i = text9_76.Length - 1; i >= 0; i--)
            {
                if (text9_76[i] == 'e')
                {
                    Console.Write(text9_76[i]);
                    break;
                }
            }*/




















            //9.140.Дан текст.Определить количество цифр в нем.
            List<string> numsString = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string text9_140 = "efwjof3 3q4fqwk340fgjwerofjmlwkj gw4o5gwfg wl45g0qwp3";
            int countNums = 0;
            foreach (var item in text9_140)
            {
                foreach (var item2 in numsString)
                {
                    if (item.ToString() == item2)
                    {
                        countNums++;
                    }
                }
            }
            Console.WriteLine("9.140: " + countNums);
























            //10.2.Рассчитать значение у, определив и использовав необходимую функцию:

            /*Zadanie10_2();
            public static void Zadanie10_2()
            {

                float num = ((float)(1 + Math.Sin(1)) / 3) + ((float)(5 + Math.Sin(5)) / 3) + ((float)(3 + Math.Sin(3)) / 3);
                Console.WriteLine(num);
                num = (float)((2 + Math.Sin(2)) / (Math.Sin(5) + 5)) + (float)((6 + Math.Sin(6)) / (Math.Sin(3) + 3)) + (float)((1 + Math.Sin(1)) / (Math.Sin(4) + 4));
                Console.WriteLine(num);
                num = (float)((1 + Math.Sin(4)) / 4 + Math.Sin(1)) + (float)((7 + Math.Sin(5)) / 5 + Math.Sin(7)) + (float)((3 + Math.Sin(2)) / 2 + Math.Sin(3));
                Console.WriteLine(num);
                num = (float)((2 + Math.Sin(3)) / 3 + Math.Sin(2)) + (float)((1 + Math.Sin(5)) / 5 + Math.Sin(1)) + (float)((4 + Math.Sin(7)) / 7 + Math.Sin(3));
                Console.WriteLine(num);
            }*/

















            //10.33.Составить процедуру, "рисующую" на экране горизонтальную линию из 80 символов "*".
            for (int i = 0; i < 80; i++)
            {
                Console.Write("*");
            }



























            //11.2.Заполнить массив из десяти элементов значениями, вводимыми с клавиатуры в ходе выполнения программы.
            int[] ints1 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                ints1[i] = int.Parse(Console.ReadLine());
            }



























            //12.2.Дан двумерный массив.
            /*а) Вывести на экран элемент, расположенный в правом нижнем углу массива. 
            б) Вывести на экран элемент, расположенный в левом верхнем углу массива.*/
            int[,] matrix = { { 4, 5, 2, 3, 5 }, { 12, 7, 8, 9, 6 } };
            Console.WriteLine(matrix[1, 4]);
            Console.WriteLine(matrix[1, 0]);


























            //13.2.Названия 20 футбольных клубов и городов, которые они представляют, записаны в двух различных таблицах. Напечатать название и город каждого клуба на отдельной строке
            List<string> strings = new List<string>() { "qwer", "dwe", "erf", "qertqfeg34we", "qerfqer", "qertgq", "qrfqer", "qerggq", "fwerg", "qerfg", "wferg", "wergd", "fwertg", "gwertfg", "gwrtg", "ewrterdf", "ertffr", "cferfg", "werftg", "erg", };
            List<string> strings2 = new List<string>() { "4ferf", "51ferfgh", "345fgerf", "678647tghj", "476h", "3567h76j", "7356g3", "g56356", "3f65", "245g4gf", "w45g45g", "w45wg5w5", "e456yhe5", "h756666", "e56heth", "e56het", "e56yh", "456wg", "g564g", "65h56g", };
            for (int i = 0; i < strings.Count; i++)
            {
                Console.WriteLine($"{strings[i]} {strings2[i]}");
            }
























            /*14.2.Создать типизированный файл и записать в него: 
            а) 5 одинаковых целых чисел;
            б) 5 одинаковых вещественных чисел;
            в) 5 одинаковых слов.*/
            string path = "text.txt";
            string infoFile = "4 4 4 4 4 \n4.4 4.4 4.4 4.4 4.4 \nqwe qwe qwe qwe qwe";
            File.WriteAllText(path, infoFile);


























            //15.2.Создать текстовый файл и записать в него 5 одинаковых строк. Записываемые строки вводятся с клавиатуры.
            /*string path = "text.txt";
            for (int i = 0; i < 5; i++)
            {
                infoFile += Console.ReadLine();
            }
            File.WriteAllText(path, infoFile);*/



























            /*16.2.С помощью датчика случайных чисел получить: 
            а) 10 целых чисел, лежащих в диапазоне от 0 до 10 включительно;
            б) k целых чисел, лежащих в диапазоне от 0 до a включительно. Значения k и a вводятся с клавиатуры;
            в) 20 целых чисел, лежащих в диапазоне от 10 до 20 включительно;
            г) k целых чисел, лежащих в диапазоне от –10 до a включительно. Значения k и a вводятся с клавиатуры;
            д) натуральное k, не превосходящее 15, и k целых чисел, лежащих в диапазоне от a до b включительно. Значения a и b вводятся с клавиатуры.*/


            /*public static void Zadanie16_2() {
                Zadanie16_2(10, 0, 10);
                Zadanie16_2(k, 0, a2);
                Zadanie16_2(20, 10, 20);
                Zadanie16_2(k, -10, a2);
                if (k <= 15)
                {
                    Zadanie16_2(k, a2, b2);
                }
              int k = int.Parse(Console.ReadLine());
              int a2 = int.Parse(Console.ReadLine());
              int b2 = int.Parse(Console.ReadLine());

              k = int.Parse(Console.ReadLine());
              a2 = int.Parse(Console.ReadLine());
              b2 = int.Parse(Console.ReadLine());

              k = int.Parse(Console.ReadLine());
              a2 = int.Parse(Console.ReadLine());
              b2 = int.Parse(Console.ReadLine());
            }*/













            //17.2.Решите предыдущую задачу при сортировке массива в порядке убывания

            /*Zadanie17_2();
            public static void Zadanie17_2()
            {
                int[] arr = { 800, 11, 50, 771, 649, 770, 240, 9 };
                int temp = 0;
                for (int write = 0; write < arr.Length; write++)
                {
                    for (int sort = 0; sort < arr.Length - 1; sort++)
                    {
                        if (arr[sort] < arr[sort + 1])
                        {
                            temp = arr[sort + 1];
                            arr[sort + 1] = arr[sort];
                            arr[sort] = temp;
                        }
                    }
                }
                for (int i = 0; i < arr.Length; i++)
                    Console.Write(arr[i] + " ");
            
                Console.WriteLine();
                int[] arr2 = { 800, 11, 50, 771, 649, 770, 240, 9 };
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    int min = i;
                    for (int j = i + 1; j < arr2.Length; j++)
                    {
                        if (arr2[j] > arr2[min])
                        {
                            min = j;
                        }
                    }
                    temp = arr2[min];
                    arr2[min] = arr2[i];
                    arr2[i] = temp;
                }
                for (int i = 0; i < arr2.Length; i++)
                    Console.Write(arr2[i] + " ");
            
                Console.WriteLine();
                int[] arr3 = { 800, 11, 50, 771, 649, 770, 240, 9 };
                int x;
                int p;
                for (int i = 1; i < arr3.Length; i++)
                {
                    x = arr3[i];
                    p = i;
                    while (p > 0 && arr3[p - 1] < x)
                    {
                        temp = arr3[i];
                        arr3[i] = arr3[p];
                        arr3[p] = temp;
                        p -= 1;
                    }
                    arr3[p] = x;
                }
            
                for (int i = 0; i < arr3.Length; i++)
                    Console.Write(arr3[i] + " ");
                Console.WriteLine();
                int[] arr4 = { 800, 11, 50, 771, 649, 770, 240, 9 };
                int[] arr5 = { 800, 11, 50, 771, 649, 770, 240, 9 };
                int k;
                for (int i = 0; i < arr4.Length; i++)
                {
                    k = 0;
                    for (int j = 0; j < arr4.Length; j++)
                    {
                        if (arr4[i] < arr4[j])
                            k++;
                    }
                    arr5[k] = arr4[i];
                }
                for (int i = 0; i < arr5.Length; i++)
                    Console.Write(arr5[i] + " ");
        }*/




        }
    }
}