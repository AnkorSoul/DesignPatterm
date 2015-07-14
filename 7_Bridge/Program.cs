using _7_Bridge.Component;
/**
 *抽象基类对象组合 
 * 
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _7_Bridge
{
    class Program
    {
        static void Main(string[] args)
        {


            //.NET平台下的Database Log
            string AssemblyPath = "7_Bridge";
            string ClassNamespace = " _7_Bridge.Component.DatabaseLog";
            object objType = Assembly.Load(AssemblyPath).CreateInstance(ClassNamespace);//反射创建
            ActionLog dblog =(DatabaseLog)objType; //new DatabaseLog();

            dblog.Implementor = new NImpLog();

            dblog.Write(".net");



            //Java平台下的Text File Log

            ActionLog txtlog = new TextFileLog();

            txtlog.Implementor = new JImpLog();

            txtlog.Write("java");


        }
    }
}
