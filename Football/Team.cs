using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace hw_12_06_Oceanarium_football
{
    internal class Team : IEnumerable<Player>
    {
        private List<Player> _team;

        public Team()
        {
            _team = new List<Player>();
        }

        public void Add(Player player) { _team.Add(player); }
        public void Remove(Player player) { _team.Remove(player); }
        public bool Contains(Player player) {  return _team.Contains(player); }



        public IEnumerator<Player> GetEnumerator()
        {
            foreach (var el in _team)
            {
                yield return el;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString()
        {
            foreach (var el in _team)
            {
                Console.WriteLine(el.ToString());
            }
            return "";
        }

        public Player this[int index]
        {
            get { return _team[index]; }    // todo
            set { _team[index] = value; }  // throw    
        }
    }
}
