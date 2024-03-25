using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public interface IBox
    {
        void Process();
        void Add(IBox box);
        void Remove(IBox box);
    }
    public class SingleBox : IBox
    {
        public void Process() { }
        public void Add(IBox box) 
        { 
            // 抛出异常；
        }
        public void Remove(IBox box) { }
    }
    public class ContainerBox : IBox
    {
        public ArrayList arrayList;
        public void Add(IBox box)
        {
            if (arrayList == null)
            {
                arrayList = new ArrayList();
            }
            arrayList.Add(box);
        }
        public void Remove(IBox box)
        {
            if (arrayList == null)
            {
                throw new Exception();
            }
            arrayList.Remove(box);
        }
        public void Process() 
        {
            // 省略了自身的其他操作，只写了而外的
            if(arrayList != null)
            {
                foreach(IBox box in arrayList)
                {
                    box.Process();
                }
            }
        }
        // 关键是去掉getBoxes
        public ArrayList getBoxes()
        {
            return arrayList;
        }
    }
    /// <summary>
    /// 客户程序类
    /// </summary>
    class App
    {
        public static void Main()
        {
            IBox box = Factory.Box();
            // 客户代码只与抽象接口进行耦合
            box.Process();
            box.Add(box);
            box.Remove(box);
        }
    }
}
