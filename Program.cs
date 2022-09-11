using System;
using System.Collections.Generic;

namespace Home15
{
    class Program
    {
        static void Main(string[] args)
        {
            AddСandidates add = new AddСandidates();
            Results Res = new Results(add);
            Voices Voi = new Voices(add);
            while (true)
            {
                Console.WriteLine("Choose number of actions: 1-New Voice ; 2-Results; 3-Addandidate");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                {
                    add.AddСandidate();
                }
                else if (a == 2)
                {
                    Res.ShowResults();

                }
                else if (a == 3)
                {
                    Voi.NewVoice();
                }
            }
        }
    }
    interface Election
    {
        void NewVoice() { }
        void Results() { }
        void AddСandidate() { }
    }

    class Voices : Election
    {
        List<string> listElectorate = new List<string>();
        //AddСandidates addСandidates = new AddСandidates();
        private AddСandidates _b;
        public Voices(AddСandidates a)
        {
            _b = a;
        }
        public int v;
        public void NewVoice()
        {
            Console.WriteLine("Give me your name dear electorate and choose in brackets");
            string n = Console.ReadLine();
            listElectorate.Add(n);
            Console.WriteLine("Give me your choose in number of candidate dear electorate");
            v = Convert.ToInt32(Console.ReadLine());
            //int Helper = addСandidates.listChooses[v];
            //Helper = Helper + 1;
            //addСandidates.listChooses[v] = Helper;
            _b.listChooses[v] += 1;


        }
    }
    class AddСandidates : Election
    {

        public List<string> listCandidates = new List<string>() { "Denisyuk Denis", "Barac Obama" };
        public List<int> listChooses = new List<int>() { 0, 0 };
        public void AddСandidate()
        {
            Console.WriteLine("Tell the name of candidate");
            string c = Console.ReadLine();
            listCandidates.Add(c);
            listChooses.Add(0);
        }
    }
    class Results : Election
    {
        private AddСandidates _a;
        public Results(AddСandidates a)
        {
            _a = a;
        }

        public void ShowResults()
        {
            int Num = _a.listCandidates.Count;
            for (int i = 0; i < Num; i++)
            {
                Console.WriteLine(_a.listCandidates[i] + ":" + _a.listChooses[i]);
            }
        }
    }

}
//checked
