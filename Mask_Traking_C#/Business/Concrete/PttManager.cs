using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        //dependecy injection
        private IApplicantService _applicanService; //reference holder

        public PttManager(IApplicantService applicantService)
        {
            _applicanService = applicantService;
        }

        public void GiveMask(Person person)
        {

            if(_applicanService.CheckPerson(person)) 
            {
                Console.WriteLine( " The mask is given to " + person.Firstname );
            }
            else
            {
                Console.WriteLine("The mask is not given");
            }
            
        }

        public void GiveMask()
        {
            throw new NotImplementedException();
        }
    }
}
