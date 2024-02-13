using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager:ISupplierService
    {


        //burada dependency injection tarasim deseni kullanilir. field lar class in icerisinde alt cizgi ile yazilir.
        //microservice implementasyonu interface ler uzerinden yapilir.
        //Her kim IApplicantService interface ini kullanirsa bu, onun referansini tutabilir. istersen PersonManager verirsin ve istersen ForeignerManager verebilirsin.
        //IApplicantService interface 2 tane sinifin (PersonManager ve ForeignerManager) referansini tutabilir. Hangisine verirsen onunki calisir.
        //interface ler referans tutucudur.



        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService) //bu yapiya Constructor denilir. Olusturucu anlamindair. new yapildiginda calisir.
        {

            _applicantService = applicantService;
        }

        public void GiveMask(Person person)
        {
            

            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " icin maske verildi");
            }
            else
            {
                Console.WriteLine(person.FirstName + " icin malesef maske verilemedi");
            }
        }
    }
}
