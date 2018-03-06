using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.DesignPatterns.ConsoleClient.CreationalPatterns.SingletonPattern
{
    public class Singleton<T>
        where T : class, new()
    {
        private static readonly object syncLock = new object();

        private static T instance;
        public static T Instance
        {
            get
            {
                lock (syncLock)
                {
                    if (instance == null)
                    {
                        instance = new T();
                    }
                }

                return instance;
            }
        }

        protected Singleton()
        {

        }
    }

  


}
