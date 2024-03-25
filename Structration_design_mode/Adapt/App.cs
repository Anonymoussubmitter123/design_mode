using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapt
{
    /// <summary>
    /// 案例一
    /// </summary>
    interface IStack
    {
        void Push(object item);
        void Pop(object item);
        object Peek();
    }
    public class Adapter_1 : IStack  // 适配对象
    {
        ArrayList adaptee_anli1;  // 被适配对象
        public Adapter_1()
        {
            adaptee_anli1 = new ArrayList();
        }
        public void Push(object item)
        {
            adaptee_anli1.Add(item);
        }
        public void Pop(object item)
        {
            adaptee_anli1.RemoveAt(adaptee_anli1.Count - 1);
        }
        public object Peek()
        {
            return adaptee_anli1[adaptee_anli1.Count - 1];
        }
    }

    /// <summary>
    /// 案例二,现有类
    /// </summary>
    class ExistionClass
    {
        public void SpecificRequest1() { }
        public void SpecificRequest2() { }
    }
    /// <summary>
    /// 新环境的所使用的接口
    /// </summary>
    interface ITarget
    {
        void Request();
    }
    /// <summary>
    /// 另外一个系统
    /// </summary>
    class MySystem
    {
        public void Process(ITarget target)
        {

        }
    }
    /// <summary>
    /// 把现有类用在新系统中
    /// </summary>
    class Adapter_2 : ITarget
    {
        ExistionClass adaptee_anli2;
        public void Request()
        {
            adaptee_anli2.SpecificRequest1();
            adaptee_anli2.SpecificRequest2();
        }
    }
    /// <summary>
    /// 案例三,并不是很理解
    /// </summary>
    class EmployeeDAO
    {
        public DataSet GetAllEmployee()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            // ...
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
        }
    }
    class Dataset
    {
        DbDataAdapter dataAdapter;
        public DataSet(DbdataAdapter dataAdapter)
        {

        }
    }
    DataSet dataSet = new DataSet(new SqlDataAdapter());
    class App
    {

    }
}
