using System;
using System.Threading.Tasks;

namespace SingletonDemo
{
    
    public sealed  class Singleton
    {
        private static int count = 0;
        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(()=>new Singleton());
        public static Singleton GetInstance
        {
            get
            {
                return instance.Value;
                
            }
        }
        private Singleton()
        {
            count += 1;
            Console.WriteLine(count);
        }
        public void getDetails(string message)
        {
            Console.WriteLine(message);
        }

       
    }
    class Program
    {

        static void Main(string[] args)
        {
            Parallel.Invoke(
            ()=>PrintEmployee(),
            ()=>PrintStudent()
            );
            Console.WriteLine("---------------------------------------");


        }

        private static void PrintStudent()
        {
            Singleton fromStu = Singleton.GetInstance;
            fromStu.getDetails("Hey ,I'm a student Intern");
        }

        private static void PrintEmployee()
        {
            Singleton fromEmp = Singleton.GetInstance;
            fromEmp.getDetails("Hi, I'm an employee at NCR");
        }
    }
}
