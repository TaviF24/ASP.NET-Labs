using HW1_ASP_NET;

List<Student> studenti = new List<Student>()
{
    new Student("Popescu", "Mihai", "0712345645"),
    new Student("Mircea", "Andrei", "mandrei@gmail.com", "4738996241"),
    new Student("Marian", "Lucian", "07127005621"),
    new Student("Dumitru", "Matei", "dmatei@yahoo.com", "0738385241"),
    new Student("Ionescu", "Andreea", "0778234695")
};

Materie alg = new Materie("Algebra", "120 minute");
Materie info = new Materie("Informatica", "120 minute");
Materie fiz = new Materie("Fizica", "120 minute");
Materie stat = new Materie("Statistica", "180 minute");
Materie geo = new Materie("Geografie", "90 minute");
Materie bio = new Materie("Biologie", "60 minute");
Materie eng = new Materie("Engleza", "60 minute");


studenti[0].materii.Add(alg);
studenti[0].materii.Add(eng);
studenti[0].materii.Add(geo);
studenti[0].materii.Add(bio);

studenti[1].materii.Add(alg);
studenti[1].materii.Add(info);
studenti[1].materii.Add(fiz);
studenti[1].materii.Add(stat);

studenti[2].materii.Add(eng);
studenti[2].materii.Add(geo);
studenti[2].materii.Add(bio);

studenti[3].materii.Add(stat);
studenti[3].materii.Add(bio);
studenti[3].materii.Add(geo);
studenti[3].materii.Add(info);
studenti[3].materii.Add(eng);

studenti[4].materii.Add(stat);
studenti[4].materii.Add(alg);
studenti[4].materii.Add(fiz);



foreach (Student stud in studenti)
{
    Console.WriteLine("\n"+stud.Nume + " " + stud.Prenume);
    stud.afisare_mat();
}
