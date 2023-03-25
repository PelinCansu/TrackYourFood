using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TrackYourFood.Core.Interfaces;
using TrackYourFood.Entites.Abstract;

namespace TrackYourFood.Entites.Concrete
{
    public class User : BaseEntity, IBaseEntityID
    {
        public User()
        {
            AddedFoods = new HashSet<AddedFood>();
        }
        public int ID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        private string _email;

        public string Email
        {
            get { return _email; }
            set
            {
                if (value.Contains("@"))
                {
                    _email = value;
                }

                else
                {
                    throw new Exception("Invalid E-mail...");
                }
              
            }
        }



        private string _password;

        public string Password
        {
            get { return _password; }
            set
            {
                bool harfvarmi = false;
                bool sayivarmi = false;
                bool sembolvarmi = false;

                for (int i = 0; i < value.Length; i++)
                {
                    char siradakiKarakter = value[i];
                    if (char.IsDigit(siradakiKarakter))
                    {
                        sayivarmi = true;
                        continue;
                    }
                    else if (char.IsLetter(siradakiKarakter))
                    {
                        harfvarmi = true;
                        continue;
                    }
                    else if (char.IsPunctuation(siradakiKarakter))
                    {
                        sembolvarmi = true;
                        continue;
                    }
                }

                if (sayivarmi is true && harfvarmi is true && sembolvarmi && true)
                {
                    _password = value;
                }
                else
                {
                    throw new FormatException("Girilen şifre harf, sayı ve özel karakterlerden oluşmalıdır.");
                }

            }
        }

        //NP
        public ICollection<AddedFood> AddedFoods { get; set; }

    }
}
