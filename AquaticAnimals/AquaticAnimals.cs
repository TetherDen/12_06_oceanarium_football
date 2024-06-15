using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_12_06_Oceanarium_football
{
    internal abstract class AquaticAnimals
    {
        private string _name;
        private string _type;
        private double _weight;
        public string Name { get { return _name; } set { _name = value; } }
        public string Type { get { return _type; } set { _type = value; } }
        public double Weight 
        { 
            get { return _weight; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Error, weight must be > 0.");
                _weight = value;
            }
        }
        protected AquaticAnimals(string name, string type, double weight)
        {
            _name = name;
            _type = type;
            _weight = weight;
        }
        public override string ToString()
        {
            return $"Name: {_name}\nType: {_type}\nWeight: {_weight}\n";
        }
        public abstract AquaticAnimals Clone();
    }

    internal class Whale : AquaticAnimals
    {
        public Whale(string name, string type, double weight) : base(name, type, weight) { }
        public override Whale Clone()
        { return new Whale(this.Name,this.Type,this.Weight); }
    }

    internal class Turtle : AquaticAnimals
    {
        public Turtle (string name, string type, double weight) : base(name, type, weight) { }
        public override Turtle Clone()
        { return new Turtle(this.Name, this.Type, this.Weight); }
    }

    internal class Dolphin : AquaticAnimals
    {
        public Dolphin(string name, string type, double weight) : base(name, type, weight) { }
        public override Dolphin Clone()
        { return new Dolphin(this.Name, this.Type, this.Weight); }
    }
}
