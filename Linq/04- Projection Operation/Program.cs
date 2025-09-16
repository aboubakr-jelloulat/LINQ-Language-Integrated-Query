using System;
using System.Collections.Generic;
using System.Linq;
using _04__Projection_Operation._01_Select;
using _04__Projection_Operation._03_Zip_Operations;
using _04__Projection_Operation.Select_Many;

namespace ProjectionOperation
{
   
    internal class Program
    {
        // projection → you take objects and project (transform) them into a new shape.

        static void Main(string[] args)
        {

            //clsSelect.RunSelectExample();

            //clsSelectMany.SelectManyExamples();


            clsZip.ZipExample();


            Console.ReadKey();
        }


    }
}
