using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    internal class LlogaritPagen
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to second mini project");
            Console.WriteLine("--------------------------------");
            Console.WriteLine();




            Zhvillues puntori1 = new Zhvillues(1,"john","developer",1498.99);
            Menaxher puntori2 = new Menaxher(2,"petter","menaxher",2305.87);
            Admin puntori3 = new Admin(3,"anna","admin",4899.13);



            double rrogaMesatate1 = puntori1.CalculateBonus();
            double rrogaMesatate2 = puntori2.CalculateBonus();
            double rrogaMesatate3 = puntori3.CalculateBonus();

            Console.WriteLine($"Bonusi vjetore per {puntori1.emri.ToUpper()},\n i/e cili/a punon si {puntori1.pozita}\n dhe ka rrogen mujore {puntori1.rroga},\n eshte : >>{rrogaMesatate1}<<");
            Console.WriteLine();
            Console.WriteLine($"Bonusi vjetore per {puntori2.emri.ToUpper()},\n i/e cili/a punon si {puntori2.pozita}\n dhe ka rrogen mujore {puntori2.rroga},\n eshte : >>{rrogaMesatate2}<<");
            Console.WriteLine();
            Console.WriteLine($"Bonusi vjetore per {puntori3.emri.ToUpper()},\n i/e cili/a punon si {puntori3.pozita}\n dhe ka rrogen mujore {puntori3.rroga},\n eshte : >>{rrogaMesatate3}<<");


            Console.ReadKey();
        }
    }


    class Employee
    {
        public int ID;
        public string emri,pozita;
        public double rroga;
        public double bonusi = 5000;

        public virtual double CalculateBonus()
        {
            return bonusi;
        }

    }
    class Zhvillues : Employee
    {
        public Zhvillues(int ID, string emri, string pozita, double rroga)
        {
            this.ID = ID;
            this.emri = emri;
            this.pozita = pozita;
            this.rroga = rroga;
        }
        public override double CalculateBonus()
        {
            double bonusiNgaRroga = (this.rroga * 12) * 0.20;
            if (bonusiNgaRroga > this.bonusi)
            {
                return bonusiNgaRroga;
            }
            else
            {

                return bonusi;
            }
        }
    }
    class Menaxher : Employee 
    {
        public Menaxher(int ID, string emri, string pozita, double rroga)
        {
            this.ID = ID;
            this.emri = emri;
            this.pozita = pozita;
            this.rroga=rroga;
        }
        public override double CalculateBonus ()
        {
            double bonusiNgaRroga = (this.rroga * 12) * 0.25;
            if(bonusiNgaRroga > this.bonusi)
            {
                return bonusiNgaRroga;
            }
            else
            {

            return bonusi;
            }
        }
    }
    class Admin : Employee
    {
        public Admin(int ID, string emri, string pozita, double rroga)
        {
            this.ID = ID;
            this.emri = emri;
            this.pozita = pozita;
            this.rroga = rroga;
        }
        public override double CalculateBonus()
        {

                return bonusi;

        }
    }
}