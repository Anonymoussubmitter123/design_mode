using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    /*
    public interface IBox
    {
        void process();
    }
    public class SingleBox : IBox
    {
        public void process(){ }
    }
    public class ContainerBox : IBox
    {
        public ArrayList arrayList = new ArrayList();
        public void process(){ }
        public ArrayList getBoxes()
        {
            return arrayList;
        }
    }
    /// <summary>
    /// 客户程序类
    /// </summary>
    class Wrong
    {
        public static void Main()
        {
            IBox box = Factory.Box();

            // 客户程序中，客户代码与对象内部结构发生了耦合，我们希望客户代码
            // 只与IBox接口耦合
            if(box is ContainerBox)
            {
                box.process();
                ArrayList arrayList = ((ContainerBox)box).getBoxes();
            }
            else if(box is SingleBox)
            {
                box.process();
            }
        }
    }*/
}
