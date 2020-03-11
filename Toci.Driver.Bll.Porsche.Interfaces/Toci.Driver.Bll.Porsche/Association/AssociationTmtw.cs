using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Driver.Bll.Porsche.Interfaces.Association;
using Toci.Driver.Dal.Invitation.Interfaces;

namespace Toci.Driver.Bll.Porsche.Association
{
    public class AssociationTmtw : AssociationTmtwBase
    {
        public AssociationTmtw(IAssociationCalculations associationCalculations) : base(associationCalculations)
        {
        }
        
        public override WorkTrip GetAssociations(WorkTrip subject, WorkTrip candidateSubject)
        {
            //subject.
            //bool isInRange = AssociationCalculations.CalculateAssociation(subject.FromLongitude,subject.FromLatitude,candidateSubject.FromLongitude,candidateSubject.FromLatitude,subject.AcceptableDistance);


            

            return null;
        }
    }
}
