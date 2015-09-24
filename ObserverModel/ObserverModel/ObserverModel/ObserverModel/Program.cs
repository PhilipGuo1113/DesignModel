using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverModel
{
    /// <summary>
    /// Designe model: Observer model
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ISubject sbj = new CSubject();
            CObject obj1 = new CObject();
            CObject obj2 = new CObject();

            sbj.Attach(obj2);
            sbj.Attach(obj1);

            while (true)
            {
                char tmpChar = Console.ReadKey().KeyChar;
                if (tmpChar.Equals('Q'))
                { break; }

                if (tmpChar.Equals('R'))
                {
                    sbj.Dettach(obj1);
                }

                sbj.BroadObject = tmpChar;
                Console.WriteLine();
                // 通知订阅者
                sbj.Notify();
            }
        }
    }
}
