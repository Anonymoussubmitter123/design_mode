using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            // 客户程序相对稳定下来了
            Road road = RoadFactory.CreateRoad();
        }
    }
    public class Road
    {
        
    }
    public static class RoadFactory
    {
        public static Road CreateRoad()
        {
            // 这里成为了相对变化点
            return new Road();
        }
    }
}
