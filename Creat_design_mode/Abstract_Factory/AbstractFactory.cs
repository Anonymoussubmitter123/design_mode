using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    /// <summary>
    /// 抽象的，下面三个类类似于prodectA（路），ProdectB（房屋）
    /// </summary>
    public abstract class ProdectA
    {
        // 道路
        public abstract void prodectAMethod();
    }
    public abstract class ProdectB
    {
        // 房屋
        public abstract void prodectBMethod();
    }
    /// <summary>
    /// ProdectA1（新路），ProdectA2（旧路），B1（新房屋），B2（旧房屋）等
    /// </summary>
    public class ProdectA1 : ProdectA
    {
        public override void prodectAMethod()
        {
        }
    }
    public class ProdectA2 : ProdectA
    {
        public override void prodectAMethod()
        {
        }
    }
    public class ProdectB1 : ProdectB
    {
        public override void prodectBMethod()
        {
        }
    }
    public class ProdectB2 : ProdectB
    {
        public override void prodectBMethod()
        {
        }
    }
    /// <summary>
    /// 抽象工厂
    /// </summary>
    public abstract class FacilitiesFactory
    {
        public abstract ProdectA CreateProductA();
        public abstract ProdectB CreateProductB();
    }
    /// <summary>
    /// 具体工厂，表示建造新东西（Factory1）的工厂，旧东西（Factory2）的工厂
    /// </summary>
    public class Factory1 : FacilitiesFactory
    {
        public override ProdectA CreateProductA()
        {
            return new ProdectA1();
        }
        public override ProdectB CreateProductB()
        {
            return new ProdectB1();
        }
    }
    public class Factory2:FacilitiesFactory
    {
        public override ProdectA CreateProductA()
        {
            return new ProdectA2();
        }
        public override ProdectB CreateProductB()
        {
            return new ProdectB2();
        }
    }
    /// <summary>
    /// 客户程序,他只依赖ProdectA（道路），B（房屋）和FacilitiesFactory(工厂);
    /// 假设它很大，以此方法来写，它不需要改变，因为它依赖的都是抽象的类和方法。
    /// </summary>
    public class GameManager
    {
        FacilitiesFactory facilitiesFactory;
        private ProdectA prodectA;
        private ProdectB prodectB;
        public GameManager(FacilitiesFactory facilitiesFactory)
        {
            this.facilitiesFactory = facilitiesFactory;
        }
        public void BuildingGameFacilities()
        {
            prodectA = facilitiesFactory.CreateProductA();
            prodectB = facilitiesFactory.CreateProductB();
        }
        public void Run()
        {
            prodectA.prodectAMethod();
            prodectB.prodectBMethod();
        }
    }
    /// <summary>
    /// 程序入口类
    /// </summary>
    public class RuKou
    {
        public static void main()
        {
            // 构建一个新的游戏场景
            GameManager gameManagerNew = new GameManager(new Factory1());
            // 构建一个旧的游戏场景
            GameManager gameManagerOld = new GameManager(new Factory1());

            gameManagerNew.BuildingGameFacilities();
            gameManagerNew.Run();
        }
    }
}
