using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// 抽象房屋类,建造类
    /// </summary>
    public abstract class House
    {

    }
    public abstract class Door
    {

    }
    public abstract class Wall
    {

    }
    public abstract class Windows
    {

    }
    public abstract class Builder
    {
        public abstract void BuildDoor();
        public abstract void BuildWall();
        public abstract void BuildWindows();

        public abstract House GetHouse();
    }
    /// <summary>
    /// 具体房屋和建造类,这一部分相对容易变化
    /// </summary>
    public class RomanHouse : House
    {

    }
    public class RomanDoor : Door
    {

    }
    public class RomanWall : Wall
    {

    }
    public class RomanWindows : Windows
    {

    }
    public class RomanHouseBuilder : Builder
    {
        public override void BuildDoor()
        {
            
        }
        public override void BuildWall()
        {

        }
        public override void BuildWindows()
        {

        }
        public override House GetHouse()
        {
            return new RomanHouse();
        }
    }
    /// <summary>
    /// 如果这一部分非常复杂，要相对稳定
    /// </summary>
    public class GameManager
    {
        /// <summary>
        /// 构建两个门，一个墙，两个窗
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static House CreateHouse(Builder builder)
        {
            builder.BuildDoor();
            builder.BuildDoor();
            builder.BuildWindows();
            builder.BuildWindows();
            builder.BuildWall();

            return builder.GetHouse();
        }
    }
    /// <summary>
    /// 客户程序类，假如需要换房子，这个类不需要改变，GameManager也不需要改变
    /// Builser抽象类也不需要改变，唯一就是新增一个客户程序类，然后改一下配置文件。
    /// </summary>
    class App
    {
        public static void Main()
        {
            // House house = GameManager.CreateHouse(new RomanHouseBuilder());
            // 这个罗马房屋也可能会变，需要设置成动态的,如此
            String builderName = ConfigurationSettings["BuilderClass"];
            // BuilderAssembly构成器组成
            String assemblyName = ConfigurationSettings["BuilderAssembly"];
            Assembly assembly = Assembly.Load(assemblyName);
            Type type = assembly.GetType(builderName);
            Builder builder = Activator.CreateInstance(type);
            House house = GameManager.CreateHouse(builder);
        }
    }
}
