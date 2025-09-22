using _15__Sets_Operations.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace _15__Sets_Operations.Distinct
{
    internal class clsDistinct
    {
        
        public static void DistinctMethode()
        {
            var participantMeeting1AndMeeting2 = Repository.Meeting1.Participants.Concat(Repository.Meeting2.Participants);

            participantMeeting1AndMeeting2.Print(" Meeting 1 and Meeting 2 Participants ");

            // using Distanct Methode  : he  work but if you override to Equal Mothode ???

            var DistanctParticipantMeeting1AndMeeting2 = participantMeeting1AndMeeting2.Distinct();
            DistanctParticipantMeeting1AndMeeting2.Print(" Meeting 1 and Meeting 2 distinct Participants : ");


            // solution using distinct by


            var DistanctByParticipantMeeting1AndMeeting2 = participantMeeting1AndMeeting2.DistinctBy(p => p.EmployeeNo);

            DistanctByParticipantMeeting1AndMeeting2.Print(" Meeting 1 and Meeting 2 distinctby(x => x.EmployeeNo) Participants");


        }

    }
}
