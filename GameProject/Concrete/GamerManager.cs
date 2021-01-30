using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{

    
    class GamerManager : IGamerService
    {
        //Bir manager sınıfı içerisinde başka bir manager sınıfı kullanılacaksa;
        //new yerine constructor kullanmalıyız.
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (this._userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt oldu..");
            }
            else
            {
                Console.WriteLine("Kayıt başarısız.");
            }
            
        }

       
        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi");
        }
    }
}
