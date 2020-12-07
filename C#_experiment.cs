实验3
//namespace Sort
//{
//    //插入排序
//    public class InsertionSorter
//    {
//        public int[] list;
//        public void Sort()
//        {
//            Stopwatch sw = new Stopwatch();
//            sw.Start();//计时开始
//            for(int i = 0; i < list.Length; i++)
//            {
//                int t = list[i];
//                int j = i;
//                while ((j > 0) && (list[j - 1] > t))
//                {
//                    list[j] = list[j - 1];
//                    --j;
//                }
//                list[j] = t;
//            }
//            Console.Write("Insertion done.");
//            sw.Stop();//计时结束
//            Console.WriteLine(sw.Elapsed.TotalMilliseconds);
//            Console.ReadKey();

//        }

//        internal void count()
//        {
//            throw new NotImplementedException();
//        }
//    }
//    //冒泡排序
//    public class BubbleSorter
//    {
//        public int[] list;
//        public void Sort()
//        {
//            Stopwatch sw = new Stopwatch();
//            sw.Start();
//            int i, j, tmp;
//            bool done = false;
//            j = 1;
//            while((j < list.Length) && (!done))
//            {
//                done = true;//顺序正确直接跳出
//                for(i = 0; i < list.Length - j; i++)
//                {
//                    if(list[i] > list[i + 1])
//                    {
//                        done = false;
//                        tmp = list[i];
//                        list[i] = list[i + 1];
//                        list[i + 1] = tmp;
//                    }
//                }
//                j++;
//            }
//            Console.Write("Bubble done.");
//            sw.Stop();
//            Console.WriteLine(sw.Elapsed.TotalMilliseconds);
//            Console.ReadKey();
//        }
//    }
//    //选择排序
//    public class SelectionSorter
//    {
//        public int[] list;
//        public void Sort()
//        {
//            Stopwatch sw = new Stopwatch();
//            sw.Start();
//            int min;
//            for(int i = 0; i < list.Length - 1; i++)
//            {
//                min = i;
//                for(int j = i + 1; j < list.Length; j++)
//                {
//                    if(list[i] < list[min])
//                    {
//                        min = j;
//                    }
//                }
//                int t = list[min];
//                list[min] = list[i];
//                list[i] = t;
//            }
//            Console.Write("Selection done.");
//            sw.Stop();
//            Console.WriteLine(sw.Elapsed.TotalMilliseconds);
//            Console.ReadKey();
//        }
//    }
//    class MainClass
//    {
//        static void Main(String[] args)
//        {
            

            
//            InsertionSorter Sorter1 = new InsertionSorter();
//            BubbleSorter Sorter2 = new BubbleSorter();
//            SelectionSorter Sorter3 = new SelectionSorter();
//            //生成随机元素的数组
//            int iCount = 10000;
//            Random rdm = new Random();
//            Sorter1.list = new int[iCount];//插入
//            Sorter2.list = new int[iCount];//冒泡
//            Sorter3.list = new int[iCount];//选择
//            for(int i = 0; i < iCount; i++)
//            {
//                Sorter1.list[i] = Sorter2.list[i] = Sorter3.list[i] = rdm.Next();
//            }

//            //单线程
//            Stopwatch sw = new Stopwatch();
//            sw.Start();
//            Sorter1.Sort();
//            Sorter2.Sort();
//            Sorter3.Sort();
//            sw.Stop();
//            Console.WriteLine(sw.Elapsed.TotalMilliseconds);
//            Console.ReadKey();

//            //多线程
//            Thread sortThread1 = new Thread(new ThreadStart(Sorter1.Sort));
//            Thread sortThread2 = new Thread(new ThreadStart(Sorter2.Sort));
//            Thread sortThread3 = new Thread(new ThreadStart(Sorter3.Sort));
//            sw.Start();
//            sortThread1.Start();
//            sortThread2.Start();
//            sortThread3.Start();
//            while (true)
//            {
//                if (sortThread1.ThreadState == System.Threading.ThreadState.Stopped && sortThread2.ThreadState == System.Threading.ThreadState.Stopped && sortThread3.ThreadState == System.Threading.ThreadState.Stopped)
//                {
//                    sw.Stop();
//                    Console.WriteLine(sw.Elapsed.TotalMilliseconds);
//                    break;
//                }
//            }
//            Console.ReadKey();

//            Console.Read();
//        }
//    }
//}