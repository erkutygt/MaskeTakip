using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ForeignerManager : IApplicantService //interface,ler belli metod imzalarini barindirir ve birbirinin alternatifi olan sistemlerin farkli implementason yapmalarini saglar. ornegin tc vatandasi ile yabanci uyruklular icin tek bir interface olusturup farkli uygulanabbilir.
    {
        //Sonar qube yazilim performansini ölcer
        public void ApplyForMask(Person person)
        {
            throw new NotImplementedException();
        }

        public bool CheckPerson(Person person)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
