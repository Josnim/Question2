using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace Prueba2
{
    class Program
    {
        public static Stack<int> search(int[] Arr, int target)
        {
            Stack<int> ans = new Stack<int>();
            for(int i = 0; i<Arr.Length; i++)
            {
                int firstValue = Arr[i];
                for(int j = 1; j<Arr.Length; j++)
                {
                    int secondValue = Arr[j];
                    if(firstValue + secondValue == target)
                    {
                        ans.Push(i);
                        ans.Push(j);
                        break;
                    }
                }
            }
            return ans;
        }
        static void Main(string[] args)
        {
            int[] Arr = new int[4] { 1, 4, 7, 12};
            int target = 16;
            Stack<int> answer = search(Arr, target);
            Console.WriteLine(answer.Pop());
            Console.WriteLine(answer.Pop());
            Console.ReadKey();
        }
    }
}
