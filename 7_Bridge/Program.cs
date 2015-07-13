using _7_Bridge.Component;
/**
 *基类对象组合 
 * 
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Bridge
{
    class Program
    {
        static void Main(string[] args)
        {


            //.NET平台下的Database Log

            ActionLog dblog = new DatabaseLog();

            dblog.Implementor = new NImpLog();

            dblog.Write("2");



            //Java平台下的Text File Log

            ActionLog txtlog = new TextFileLog();

            txtlog.Implementor = new JImpLog();

            txtlog.Write("java");


        }
    }
}
