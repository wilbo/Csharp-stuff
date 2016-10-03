using System;

namespace ConsoleApplication
{

    // Observer Design Pattern
    // https://msdn.microsoft.com/en-us/library/ee850490(v=vs.110).aspx

    public class Program
    {
        public static void Main(string[] args)
        {            
            Model model = new Model();

            ViewNumber vg = new ViewNumber(model);
            ViewPipes vt = new ViewPipes(model);

            model.IncreaseModel(5);
            model.DecreaseModel(3);
        }
    }

    public delegate void Observer(Model model);

    public class Model
    {
        public int Number { get; set; }
        private event Observer Obs;

        public void IncreaseModel(int i)
        {
            Number = Number + i;
            Obs(this);
        }

        public void DecreaseModel(int i)
        {
            Number = Number - i;
            Obs(this);
        }

        public void addObs(Observer o) {
            Obs += o;
        } 
    }



    public class ViewNumber
    {
        public ViewNumber(Model m)
        { 
            m.addObs(ShowData);
        }

        public void ShowData(Model model)
        {
            Console.WriteLine(model.Number);
        }
    }


    public class ViewPipes
    {
        public ViewPipes(Model m)
        {
            m.addObs(ShowData);
        }

        public void ShowData(Model model)
        {
            for (int i = 0; i < model.Number; i++)
                Console.Write("|");

            Console.WriteLine();  
        }
    }


}
