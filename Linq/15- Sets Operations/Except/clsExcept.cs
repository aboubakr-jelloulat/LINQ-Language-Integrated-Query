using _15__Sets_Operations.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace _15__Sets_Operations.Except
{
    internal class clsExcept
    {

        public static void ExceptMethode()
        {
            var set1 = Repository.Meeting1.Participants;
            var set2 = Repository.Meeting2.Participants;

            set1.Print($"========= Meeting 1 Participants ({set1.Count()})");
            set2.Print($"========= Meeting 1 Participants ({set2.Count()})");


            var set3 = set1.Except(set2);

            set3.Print($"========= set1.Except(set2) Participants Need override Equal ({set3.Count()})");



            var set4 = set1.ExceptBy(set2.Select(e => e.EmployeeNo), p => p.EmployeeNo);
            set4.Print($"========= set1.ExceptBy(set2.Select(x => x.EmployeeNo) Participants ({set4.Count()})");


        }

    }
}
