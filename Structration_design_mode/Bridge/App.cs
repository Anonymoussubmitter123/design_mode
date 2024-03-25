using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// 版本1，代码复用不好
    /// </summary>
    public abstract class Tank
    {
        protected TankPlatformImplementation tankImpl;
        public Tank(TankPlatformImplementation tankImpl)
        {
            this.tankImpl = tankImpl;
        }
        public TankPlatformImplementation TankImpl
        {
            get { return this.TankImpl; }
            set { this.TankImpl = TankImpl; }
        }

        public abstract void Shot();
        public abstract void Run();
        public abstract void Stop();
    }
    /*
    public class T50 : Tank
    {
        public override void Shot()
        {
            // T50...
        }
        public override void Run()
        {
            // T50...
        }
        public override void Stop()
        {
            // T50...
        }
    }
    public class T75 : Tank
    {
        public override void Shot()
        {
            // T75...
        }
        public override void Run()
        {
            // T75...
        }
        public override void Stop()
        {
            // T75...
        }
    }
    public class T90 : Tank
    {
        public override void Shot()
        {
            // T90...
        }
        public override void Run()
        {
            // T90...
        }
        public override void Stop()
        {
            // T90...
        }
    }
    public class PCT50 : T50
    {

    }
    public class PCT75 : T50
    {

    }
    public class PCT90 : T50
    {

    }
    public class MobileT50 : T50
    {

    }
    public class MobileT75 : T50
    {

    }
    public class MobileT90 : T50
    {

    }
    */
    /// <summary>
    /// 版本2
    /// </summary>
    /// 坦克类，仅实现坦克的基本功能，而坦克的声效等放在平台类里面
    /// 隔离变化
    public class T50 : Tank
    {
        public T50(TankPlatformImplementation tankImpl) : base(tankImpl)
        {
            //this.tankImpl = tankImpl;
        }
        public override void Shot()
        {
            tankImpl.DoShot();
            // T50...
        }
        public override void Run()
        {
            // T50...
        }
        public override void Stop()
        {
            // T50...
        }
    }
    public class T75 : Tank
    {
        public T75(TankPlatformImplementation tankImpl) : base(tankImpl)
        {

        }
        public override void Shot()
        {
            // T75...
        }
        public override void Run()
        {
            // T75...
        }
        public override void Stop()
        {
            // T75...
        }
    }
    public class T90 : Tank
    {
        public T90(TankPlatformImplementation tankImpl) : base(tankImpl)
        {

        }
        public override void Shot()
        {
            // T90...
        }
        public override void Run()
        {
            // T90...
        }
        public override void Stop()
        {
            // T90...
        }
    }
    /// <summary>
    /// 平台类，采用组合的方法来联系坦克类和平台类
    /// </summary>
    public abstract class TankPlatformImplementation
    {
        public abstract void MoveTankTo(Point to);
        public abstract void DrawTank();
        public abstract void DoShot();
    }
    public class PCTankImplementation : TankPlatformImplementation
    {
        public override void MoveTankTo(Point to)
        {
            throw new NotImplementedException();
        }
        public override void DrawTank()
        {
            throw new NotImplementedException();
        }
        public override void DoShot()
        {
            throw new NotImplementedException();
        }
    }
    public class MobileTankImplementation : TankPlatformImplementation
    {
        public override void MoveTankTo(Point to)
        {
            throw new NotImplementedException();
        }
        public override void DrawTank()
        {
            throw new NotImplementedException();
        }
        public override void DoShot()
        {
            throw new NotImplementedException();
        }
    }
    /// <summary>
    /// 客户程序类
    /// </summary>
    class App
    {
        /// <summary>
        /// main函数
        /// </summary>
        public static void main()
        {
            TankPlatformImplementation tankImpl = new MobileTankImplementation();

            T50 t50 = new T50(tankImpl);
        }
    }
}
