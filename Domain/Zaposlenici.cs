using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Zaposlenici
    {
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Ime
        {
            get
            {
                return ime;
            }

            set
            {
                ime = value;
            }
        }

        public string Prezime
        {
            get
            {
                return prezime;
            }

            set
            {
                prezime = value;
            }
        }

        public string Kor_ime
        {
            get
            {
                return kor_ime;
            }

            set
            {
                kor_ime = value;
            }
        }

        public string Lozinka
        {
            get
            {
                return lozinka;
            }

            set
            {
                lozinka = value;
            }
        }

        public int Tip_zaposlenika
        {
            get
            {
                return tip_zaposlenika;
            }

            set
            {
                tip_zaposlenika = value;
            }
        }
        int id;
        string ime;
        string prezime;
        string kor_ime;
        string lozinka;
        int tip_zaposlenika;


    }
    public class projekti {

        public string Naziv
        {
            get
            {
                return naziv;
            }

            set
            {
                naziv = value;
            }
        }

        public float Budzet
        {
            get
            {
                return budzet;
            }

            set
            {
                budzet = value;
            }
        }
        string naziv;
        float budzet;
    }
    public class zaposlenici_projekti
    {
        public int Id_projekta
        {
            get
            {
                return id_projekta;
            }

            set
            {
                id_projekta = value;
            }
        }

        public int Id_zaposlenika
        {
            get
            {
                return id_zaposlenika;
            }

            set
            {
                id_zaposlenika = value;
            }
        }
        int id_projekta;
        int id_zaposlenika;
    }
}
