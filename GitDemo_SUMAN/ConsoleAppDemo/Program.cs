using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    class Employee
    {
        public string EID { get; set; }
        public string Ename { get; set; }
        public string ELOC { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> objEmployee = new List<Employee>();
            objEmployee.Add(new Employee() {EID="1",Ename="E1",ELOC="L1" });
            objEmployee.Add(new Employee() {EID="2",Ename="E2",ELOC="L2" });
            objEmployee.Add(new Employee() {EID="3",Ename="E3",ELOC="L3" });
            objEmployee.Add(new Employee() { EID = "4", Ename = "E1", ELOC = "L1x" });
            objEmployee.Add(new Employee() { EID = "5", Ename = "E1", ELOC = "L2" });
            objEmployee.Add(new Employee() { EID = "3", Ename = "E3", ELOC = "L3d" });


            //foreach (var item in objEmployee)
            //{
            //    if (item.EID== "3")
            //    {
            //        if (item.Ename=="E3")
            //        {
            //            DoMyFunc(item.Ename);
            //        }
            //    }
            //}
            //objEmployee.ForEach( item => DoMyFunc(item.EID));

            objEmployee.Where(x => x.EID == "3" && x.Ename == "E3").ToList().ForEach(x=> DoMyFunc(x.EID));

            objEmployee.Where(x => x.EID.ToString().Equals("3")).ToList().ForEach(x =>{
                    if (x.Ename=="E3")
                     {
                    // Do some stuff here.
                    if (x.ELOC=="L3")
                    {
                        DoMyFunc(x.ELOC);
                    }
                     };
                });
            Console.ReadLine();

        }

        private static void DoMyFunc(string ename)
        {
            Console.WriteLine(ename);
        }
    }
}
