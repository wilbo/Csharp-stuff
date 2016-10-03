using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {            
            Model model = new Model();

            ViewGetal vg = new ViewGetal(model);
            ViewStreepjes vt = new ViewStreepjes(model);

            model.IncreaseModel(5);
            model.DecreaseModel(3);
        }
    }

    public delegate void Observer(Model model);

    public class Model
    {
        public int Getal { get; set; }
        private event Observer Obs;

        public void IncreaseModel(int i)
        {
            Getal = Getal + i;
            Obs(this);
        }

        public void DecreaseModel(int i)
        {
            Getal = Getal - i;
            Obs(this);
        }

        public void addObs(Observer o) {
            Obs += o;
        } 
    }



    public class ViewGetal
    {
        public ViewGetal(Model m)
        { 
            m.addObs(ShowData);
        }

        public void ShowData(Model model)
        {
            Console.WriteLine(model.Getal);
        }
    }


    public class ViewStreepjes
    {
        public ViewStreepjes(Model m)
        {
            m.addObs(ShowData);
        }

        public void ShowData(Model model)
        {
            for (int i = 0; i < model.Getal; i++)
                Console.Write("|");

            Console.WriteLine();  
        }
    }


}
