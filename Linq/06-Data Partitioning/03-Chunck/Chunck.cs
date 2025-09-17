using _06_Data_Partitioning.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace _06_Data_Partitioning._03_Chunck
{
    internal class Chunck
    {

        public static void ChunckMethods()
        {
            var emps = Repository.LoadEmployees();

            var chuncks = emps.Chunk(10).ToList();

            for (int i = 0; i < chuncks.Count; i++)
            {
                chuncks[i].Print($"Chunk #{i + 1}");
            }

        }

    }
}
