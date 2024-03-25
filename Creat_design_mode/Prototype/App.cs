using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    /// <summary>
    /// 抽象B类，在一个文件
    /// </summary>
    public abstract class NormalActor
    {
        public abstract NormalActor Clone();
    }
    public abstract class FlyActor
    {
        public abstract FlyActor Clone();
    }
    /// <summary>
    /// 抽象B类的具体实现，可以和上面在一个文件中
    /// </summary>
    public class NormalActorA : NormalActor
    {
        public override NormalActor Clone()
        {
            // MemberwiseClone()应对值类型没问题，但是引用类型会出问题
            return (NormalActorA)this.MemberwiseClone();
        }
    }
    public class NormalActorB : NormalActor
    {
        public override NormalActor Clone()
        {
            return (NormalActorB)this.MemberwiseClone();
        }
    }
    public class FlyActorA : FlyActor
    {
        public override FlyActor Clone()
        {
            return (FlyActorA)this.MemberwiseClone();
        }
    }
    public class FlyActorB : FlyActor
    {
        public override FlyActor Clone()
        {
            return (FlyActorB)this.MemberwiseClone();
        }
    }
    /// <summary>
    /// 抽象A类，在另一个文件
    /// </summary>
    public class GameSystem
    {
        /// <summary>
        /// 也可以把参数拿出来变成字段
        /// </summary>
        /// <param name="normalActor"></param>
        /// <param name="flyActor"></param>
        public void Run(NormalActor normalActor, FlyActor flyActor)
        {
            NormalActor normalActor1 = normalActor.Clone();
            NormalActor normalActor2 = normalActor.Clone();
            NormalActor normalActor3 = normalActor.Clone();
            FlyActor flyActor1 = flyActor.Clone();
            FlyActor flyActor2 = flyActor.Clone();
        }
    }
    /// <summary>
    /// 客户程序类
    /// </summary>
    class App
    {
        public static void main()
        {
            GameSystem gameSystem = new GameSystem();

            gameSystem.Run(new NormalActorA(), new FlyActorA());
        }
    }
}
