using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dacorator
{
    public abstract class Tank
    {
        public abstract void Shot();
        public abstract void Run();
    }
    /// <summary>
    /// 精髓之处
    /// </summary>
    public abstract class Decorator: Tank  // 接口继承
    {
        // 真正使用时，确实是一个坦克
        private Tank tank;  // Has~A 对象组合
        public Decorator(Tank tank)
        {
            this.tank = tank;
        }
        // 行为上像个坦克，接口
        public override void Shot()
        {
            tank.Shot();
        }
        public override void Run()
        {
            tank.Run();
        }
    }
    public class DecoratorA : Decorator
    {
        public DecoratorA(Tank tank):base(tank)
        {

        }
        public override void Shot()
        {
            //..功能扩展在这
            base.Shot();
        }
        public override void Run()
        {
            //..功能扩展在这
            base.Run();
        }
    }
    public class DecoratorB : Decorator
    {
        public DecoratorB(Tank tank) : base(tank)
        {

        }
        public override void Shot()
        {
            //..另一个功能扩展在这
            base.Shot();
        }
        public override void Run()
        {
            //..另一个功能扩展在这
            base.Run();
        }
    }
    public class DecoratorC : Decorator
    {
        public DecoratorC(Tank tank) : base(tank)
        {

        }
        public override void Shot()
        {
            //..另一个功能扩展在这
            base.Shot();
        }
        public override void Run()
        {
            //..另一个功能扩展在这
            base.Run();
        }
    }
    public class T50 : Tank
    {
        public override void Shot()
        {
            throw new NotImplementedException();
        }
        public override void Run()
        {
            throw new NotImplementedException();
        }
    }
    /// <summary>
    /// 客户程序类
    /// </summary>
    class App
    {
        public static void main()
        {
            Tank tank = new T50();

            // 每定义一个对象，就获得一种功能。通过组合的方式实现功能扩展
            DecoratorA decoratorA = new DecoratorA(tank);
            DecoratorB decoratorB = new DecoratorB(decoratorA);
            DecoratorC decoratorC = new DecoratorC(decoratorB);

        }
    }
}
