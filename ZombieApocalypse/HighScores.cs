using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombieApocalypse
{
    [Serializable]
    public class HighScores
    {
        public List<int> highScores { get; set; }
        public Dictionary<int, string> names { get; set; }
        public HighScores()
        {
            highScores = new List<int>();
            names = new Dictionary<int, string>();
        }
        public void sort()
        {
            highScores.Sort();
        }
        public void putInDictionary(int item, string name)
        {
            names.Add(item, name);
        }
        public void add(int item, string name)
        {
           
            if (names.ContainsKey(item)) {
                names[item] += " " + name;
            }
            else
            {
                names.Add(item, name);
                highScores.Add(item);
            }
            highScores.Sort();
            if(highScores.Count>5)
            {
                for(int i=5;i<highScores.Count;i++)
                {
                    names.Remove(highScores[i]);
                    highScores.RemoveAt(i);
                   
                }
            }
            /* if (highScores.Count > 5)
             {
                 bool madeit = false;

                 HighScores temp = new HighScores();
                 for (int i = 0; i < 5; i++)
                 {
                     temp.highScores[i] = this.highScores[i];
                     if (temp.highScores[i].Equals(item))
                     {
                         madeit = true;
                     }
                 }
                 this.highScores = temp.highScores;

                 return madeit;
             }
             else
             {
                 return true;
             }*/
        }
    }
}
