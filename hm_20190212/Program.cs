using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace hm_20190212
{
    class Program
    {
        static void Main(string[] args)
        {
            exmplForSnickers();
        }

        static void exmplForSnickers()
        {
            //Дана строка символов, состоящая из цифр от 0 до 9 и пробелов. 
            //Группы цифр, разделенные пробелами (одним или несколькими) и не содержащие пробелов внутри себя, будем называть словами. 
            //Рассматривая эти слова как числа, определить и напечатать сумму чисел, оканчивающихся на цифры 3 или 4
            string str = "1233 23356 78888   5787 4454 45676     3424 7883";
            while (str.Contains("  "))
            {
                str=str.Replace("  ", " ");
            }

            string[] words = str.Split(' ');

            List<int> numbers = new List<int>();
            for (int i = 0; i < words.Length; i++)
            {
                numbers.Add(Convert.ToInt32(words[i]));
            }

            int sum = 0;
            for(int i=0; i<numbers.Count; i++)
            {
                if (numbers[i] % 10 == 3 || numbers[i] % 10 == 4)
                    sum += numbers[i];
            }
            Console.WriteLine("сумма чисел, оканчивающихся на цифры 3 или 4, = {0}", sum);
        }

        static void exmpl01()
        {
            //•	Напечатать весь массив целых чисел
            int[] arr = new int[] { 2, 4, 6, 7, 823, 47, 2, 1 };
            for(int i=0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        static void exmpl02()
        {
            //•	Найти индекс максимального значения в массиве
            int[] arr = new int[] { 2, 4, 6, 7, 823, 47, 2, 1 };
            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] == arr.Max())
                    Console.WriteLine("index of max element = {0}", i);
            }            
        }

        static void exmpl03()
        {
            //•	Найти индекс максимального четного значения в массиве
            int[] arr = new int[] { 2, 4, 6, 7, 823, 47, 2, 1 };
            int num = arr[0];
            int ind=0;
            for(int i=1; i<arr.Length; i++)
            {
                if (arr[i]%2==0 & arr[i]>num)
                {                    
                    num = arr[i];
                    ind = i;
                }
            }
            Console.WriteLine(ind);
        }       

        static void exmpl04()
        {
            //•	Удалить элемент из массива по индексу            
            List<int> arr = new List<int> { 2, 4, 6, 7, 823, 47, 2, 1 };

            Console.WriteLine("введите индекс:");
            int num = Int32.Parse(Console.ReadLine());
            arr.RemoveAt(num);

            Console.WriteLine("новый массив:");
            for (int i=0; i<arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        static void exmpl05()
        {
            //•	Удаление элементов из массива по значению
            List<int> arr = new List<int> { 2, 4, 6, 7, 823, 47, 2, 1 };            

            Console.WriteLine("введите значение:");
            int num = Int32.Parse(Console.ReadLine());
            while(arr.Contains(num))
            {
                arr.Remove(num);
            }

            Console.WriteLine("новый массив:");
            for(int i=0; i<arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        static void exmpl06()
        {
            //•	Вставить элемент в массив по индексу
            List<int> arr = new List<int> { 2, 4, 6, 7, 823, 47, 2, 1 };

            Console.WriteLine("введите значение:");
            int num = Int32.Parse(Console.ReadLine());
            Console.WriteLine("введите индекс:");
            int ind = Int32.Parse(Console.ReadLine());

            arr.Insert(ind, num);
            Console.WriteLine("новый массив:");
            for (int i=0; i<arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
            }           
        }

        static void exmpl07()
        {
            //•	Удалить те элементы массива, которые встречаются в нем ровно два раза
            List<int> arr = new List<int> { 2, 4, 6, 7, 823, 47, 2, 1, 6, 2 };
            List<int> tmp = new List<int>();

            for(int i=0; i<arr.Count; i++)
            {
                int k = 0;
                for (int j = 0; j < arr.Count; j++)
                {
                    if (arr[j] == arr[i])
                        k++;
                }
                if (k == 2)
                    tmp.Add(arr[i]);
            }

            for (int i = 0; i < tmp.Count; i++)
            {
                while (arr.Contains(tmp[i]))
                    arr.Remove(tmp[i]);
            }

            for (int i = 0; i < arr.Count; i++)
                Console.WriteLine(arr[i]);
        }

        static void exmpl08()
        {
            //•	Удалить из строки слова, в которых есть буква 'a'
            string str = "Числовые значения символов нижнего регистра в коде ASCII отличаются от значений символов верхнего регистра на величину 32";
            string[] words = str.Split(' ');
            string tmp = "";
            for(int i=0; i<words.Length; i++)
            {
                if (!words[i].Contains("а"))
                {
                    tmp += words[i]+" ";
                }
            }

            Console.WriteLine(tmp);
        }

        static void exmpl09()
        {
            //•	Удалить из строки слова, в которых есть хоть одна буква последнего слова
            string str = "Удалить asddffd из строки слова, в которых есть хоть одна буква последнего слова";
            string[] tmp = str.Split(' ');
            string word = tmp[tmp.Length - 1];
            string newString = "";
            for (int i = 0; i < tmp.Length; i++)
            {
                int k = 0;
                for (int j = 0; j < word.Length; j++)
                {
                    if (tmp[i].Contains(word[j]))
                        k++;                   
                }
                if (k == 0)
                    newString += tmp[i] + " ";
            }

            Console.WriteLine(newString);
        }

        static void exmpl10()
        {
            //•	В строке все слова, которые начинаются и заканчиваются одной буквой, выделить квадратными скобками
            string str = "В строке все слова, азора которые начинаются и заканчиваются одной буквой, игрушки выделить квадратными скобками";
            string[] tmp = str.Split(' ');
            string newStr = "";
            for(int i=0; i<tmp.Length; i++)
            {
                if (tmp[i][0] == tmp[i][tmp[i].Length - 1])
                    newStr += "[" + tmp[i] + "] ";
                else
                    newStr += tmp[i] + " ";
            }
            Console.WriteLine(newStr);
        }

        static void exmpl11()
        {
            //•	Обнулить элементы тех строк, на пересечении которых с главной диагональю стоит четный элемент
            int[,] arr = { { 1, 2, 3, 4, 9 }, { 5, 6, 7, 8, 4 }, { 10, 45, 1, 2, 10 }, { 3, 6, 7, 3, 1 }, {6,47,12,5,12 } };
            List<int> tmp = new List<int>();
            int size = 5;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("{0}\t", arr[i, j]);
                    if (i == j & arr[i, j] % 2 == 0)
                        tmp.Add(j);
                }
                Console.WriteLine();
            }

            Console.WriteLine("новая матрица:");
            for (int i = 0; i < tmp.Count; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    for (int h = 0; h < size; h++)
                    {
                        if (j == tmp[i])
                            arr[j, h] = 0;
                    }
                }
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    Console.Write("{0}\t", arr[i, j]);
                Console.WriteLine();
            }
        }

        static void exmpl12()
        {
            //•	Обнулить элементы тех столбцов, на пересечении которых с главной диагональю стоит четный элемент
            int[,] arr = { { 1, 2, 3, 4, 9 }, { 5, 6, 7, 8, 4 }, { 10, 45, 1, 2, 10 }, { 3, 6, 7, 3, 1 }, { 6, 47, 12, 5, 12 } };
            List<int> tmp = new List<int>();
            int size = 5;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("{0}\t", arr[i, j]);
                    if (i == j & arr[i, j] % 2 == 0)
                        tmp.Add(j);
                }
                Console.WriteLine();
            }

            Console.WriteLine("новая матрица:");
            for (int i = 0; i < tmp.Count; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    for (int h = 0; h < size; h++)
                    {
                        if (h == tmp[i])
                            arr[j, h] = 0;                        
                    }
                }
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    Console.Write("{0}\t", arr[i, j]);
                Console.WriteLine();
            }
        }

        static void exmpl13()
        {
            //•	Удалить те столбцы, в которых встречается хотя бы два одинаковых элемента           
            Random rnd = new Random();
            List<List<int>> arr = new List<List<int>>();
            for(int i=0; i<5; i++)
            {
                List<int> tmp = new List<int>();
                for (int j=0; j<5; j++)
                {
                    tmp.Add(rnd.Next(0, 20));
                }
                arr.Add(tmp);
            }

            for(int i=0; i<5; i++)
            {
                for (int j = 0; j < 5; j++)
                    Console.Write("{0}\t", arr[i][j]);
                Console.WriteLine();
            }

            List<int> t = new List<int>();
            for(int i=0; i<5; i++)
            {
                for(int j=0; j<5; j++)
                {
                    int k = 0;
                    for(int h=j+1; h<5; h++)
                    {
                        if (arr[j][i] == arr[h][i])
                            k++;
                    }
                    if (k != 0)
                        t.Add(i);
                }
            }
            List<int> tt = new List<int>();
            tt.Add(t[0]);
            for(int i=1; i<t.Count; i++)
            {
                if (!tt.Contains(t[i]))
                    tt.Add(t[i]);
            }
            
            //Console.WriteLine("-----------------------------------");
            //for (int i = 0; i < tt.Count; i++)
            //    Console.Write("{0}\t", tt[i]);

            for(int i=0; i<5; i++)
            {
                if (tt.Count != 0)
                {
                    for (int h = tt.Count - 1; h >= 0; h--)
                    {
                        arr[i].RemoveAt(tt[h]);
                    }                    
                }
            }

            Console.WriteLine("-----------------------------------");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5 - tt.Count; j++)
                    Console.Write("{0}\t", arr[i][j]);
                Console.WriteLine();
            }
        }

        static void exmpl14()
        {
            //•	Написать программу, которая считывает символы с клавиатуры, пока не будет введена точка. 
            //Программа должна сосчитать количество введенных пользователем пробелов. (Подсказка. IF, Length)

            string str = "";
            char ch=new char();
            int k = 0;
            while (ch!='.')
            {
                ch = Console.ReadKey().KeyChar;
                if (ch == ' ')
                    k++;
                str += ch;                
            }

            Console.WriteLine("\n{0}", str);
            Console.WriteLine("кол-во пробелов = {0}", k);
        }
    }
}
