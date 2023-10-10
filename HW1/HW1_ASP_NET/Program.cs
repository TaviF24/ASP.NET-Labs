using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_ASP_NET
{
    class Student
    {
        string nume;
        public string Nume{
            get { return nume; }
            set { nume = value; }
        }
        string prenume;
        public string Prenume{
            get { return prenume; }
            set { prenume = value; }
        }
        string email= "Nespecificat";
        public string Email{
            get { return email; }
            set { email = value; }
        }
        string telefon;
        public string Telefon {
            get { return telefon; }
            set { telefon = value; }
        }
        public List<Materie> materii = new List<Materie>();

        public Student(string nume, string prenume, string email, string telefon)
        {
            Nume = nume;
            Prenume = prenume;
            Email = email;
            Telefon = telefon;
        }

        public Student(string nume, string prenume, string telefon)
        {
            Nume = nume;
            Prenume = prenume;
            Telefon = telefon;
        }

        public void afisare_mat()
        {
            foreach(Materie ob in materii)
            {
                Console.WriteLine("Titlul materiei: "+ob.Titlu+ "; Durata: "+ob.Durata);
            }
        }
    }


    class Materie
    {
        string titlu;
        public string Titlu
        {
            get { return titlu; }
            set { titlu = value; }
        }

        string durata;
        public string Durata
        {
            get { return durata; }
            set { durata = value; }
        }

        public Materie(string titlu, string durata)
        {
            Titlu = titlu;
            Durata = durata;
        }
    }

}



