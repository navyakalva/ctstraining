using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractclassexample
{
    abstract class Player
    {
        protected string name;
        protected string teamname;
        protected int numofmatches;
        public abstract void Displayplayerstatistic();

        public Player(string name, string teamname, int numofmatches)
        {
            this.name = name;
            this.teamname = teamname;
            this.numofmatches = numofmatches;
        }
        
    }
    class Cricketplayer:Player
    {
        int totalrunsscored;
        int noofwicketstaken;
        
        
        public Cricketplayer(string name, string teamname, int numofmatches,int totalrunsscored,int noofwicketstaken):base( name,  teamname, numofmatches)
        {
            
            this.totalrunsscored= totalrunsscored;
            this.noofwicketstaken = noofwicketstaken;
        }
        public override void Displayplayerstatistic()
        {
            Console.WriteLine(this.name + " " + this.teamname + " " + this.numofmatches);
            Console.WriteLine(this.totalrunsscored + " " + this.noofwicketstaken);
        }
    }
    class Hockeyplayer:Player
    {
        string position;
        int noofgoals;
        public Hockeyplayer(string name, string teamname, int numofmatches,string position,int noofgoals):base( name,  teamname, numofmatches)
        {
            this.position = position;
            this.noofgoals = noofgoals;
        }
        public override void Displayplayerstatistic()
        {
            Console.WriteLine(this.name + " " + this.teamname + " " + this.numofmatches);
            Console.WriteLine(this.position + " " + this.noofgoals);

        }
    }
}
\