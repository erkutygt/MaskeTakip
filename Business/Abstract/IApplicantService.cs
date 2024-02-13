using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApplicantService   //interface arayüz demektir. Bir class yazmaya baslandiginda onun interface i önceden olusturulmalidir.
    {

        //bunlara methodun imzasi denir.
        void ApplyForMask(Person person);


        List<Person> GetList();



        bool CheckPerson(Person person); //person parametresi verilir. 
    
    }
}
