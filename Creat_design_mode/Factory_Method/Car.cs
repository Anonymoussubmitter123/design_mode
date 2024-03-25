using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    /// <summary>
    /// 抽象汽车类
    /// </summary>
    public abstract class Car
    {
        public abstract void StartUp();
        public abstract void Run();
        public abstract void Turn(Direction direction);
        public abstract void Stop();
    }
    /// <summary>
    /// 具体汽车类
    /// </summary>
    public class HongQiCar : Car
    {
        public override void StartUp()
        {
            //...具体实现每个汽车都不一样
        }public override void Run()
        {
            //...具体实现每个汽车都不一样
        }public override void Turn(Direction direction)
        {
            //...具体实现每个汽车都不一样
        }public override void Stop()
        {
            //...具体实现每个汽车都不一样
        }

    }
    /// <summary>
    /// 抽象汽车工厂类
    /// </summary>
    public abstract class CarFactory
    {
        public abstract Car CreateCar();
    }
    public class HongQiCarFactory : CarFactory
    {
        public override Car CreateCar()
        {
            return new HongQiCar();
        }
    }
    /// <summary>
    /// 汽车测试框架,假设用了很多的Car的对象
    /// </summary>
    public class CarTestFrameWork
    {
        public void BuildTestContext(CarFactory carFactory)
        {
            Car car = carFactory.CreateCar();
        }
        public void DoTest()
        {

        }
        public TextData GetTestData()
        {

        }
    }
    /// <summary>
    /// 客户程序类
    /// </summary>
    class App
    {
        public static void Main()
        {
            CarTestFrameWork carTestFrameWork = new CarTestFrameWork();

            carTestFrameWork.BuildTestContext(new HongQiCarFactory());
        }
    }
}
