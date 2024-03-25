using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单例模式
{
    public class Singleton
    {
        /*
        /// <summary>
        /// 为什么不在这里直接new一个对象呢，因为这样写，只要用户不用该类，就一个对象都不会创建，否则会创建一个。
        /// volatile关键字会让编译器不会对代码进行微调
        /// </summary>
        private static volatile Singleton instance;
        private static object lockHelper = new Object();
        /// <summary>
        /// 私有的实例构造器，外部没办法实例化该类的对象
        /// </summary>
        private Singleton()
        {

        }
        public static Singleton Instance
        {
            get
            {
                if (instace == null)
                {
                    lock (lockHelper)
                    {
                        if(instace == null)
                        {
                            instace = new Singleton();
                        }
                    }
                }
                return instace;
            }
        }*/
        // public static readonly Singleton Instance = new Singleton();
        /// <summary>
        /// 与上面效果原理相同；在访问Instance时会先执行静态构造器，不用也不会创造对象。
        /// 并且也可以应对多线程，自动加了个锁；
        /// 缺点：构造方法不能带参数
        /// </summary>
        public static readonly Singleton Instance;
        static Singleton()
        {
            Instance = new Singleton();
        }
        // 将初始化与构造器进行剥离即可
        public void Init(FileStream fileStream)
        {

        }
        public int x
        {
            get { return x; }
            set { x = value; }
        }
        private Singleton() { }
    }
}
