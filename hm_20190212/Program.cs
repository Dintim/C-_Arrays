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
            exmpl13();
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
            int[,] arr = new int[5,5];
            Random rnd = new Random();
            
            for(int i=0; i<5; i++)
            {
                //List<int> tmp = new List<int>();
                for (int j = 0; j < 5; j++)
                {
                    arr[i,j]=rnd.Next(0, 10);                    
                }
                //arr.Add(tmp);                
            }

            for(int i=0; i<5;i++)
            {
                for (int j = 0; j < 5; j++)
                    Console.Write("{0}\t", arr[i,j]);
                Console.WriteLine();
            }

            List<int> t = new List<int>();
            for (int i=0; i<5;i++)
            {
                for(int j=0; j<5;j++)
                {
                    int k = 0;
                    for (int h=j+1; h<5;h++)
                    {
                        if (arr[j,i] == arr[h,i])
                            k++;
                    }
                    if (k != 0)
                        t.Add(i);                        
                }
            }

            //int[,] arr2 = new int[5, 5 - t.Count];
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        for(int h=0; h<t.Count; h++)
            //        {
            //            if (j!=h)
            //            {
            //                arr2.SetValue(arr[i, j], j);
            //            }
            //        }
            //    }
            //}

            //Console.WriteLine("новая матрица:");
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5 - t.Count; j++)
            //        Console.Write("{0}\t", arr[i,j]);
            //    Console.WriteLine();
            //}



        }
    }
}
