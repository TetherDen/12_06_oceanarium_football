using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_12_06_Oceanarium_football
{
    internal class Oceanarium : IEnumerable<AquaticAnimals>
    {
        private List<AquaticAnimals> _animalList;

        public Oceanarium()
        {
            _animalList = new List<AquaticAnimals>();
        }

        public void Add(AquaticAnimals animal)
        {
            _animalList.Add(animal);
        }

        public void Remove(AquaticAnimals animal)
        {
            if (_animalList.Contains(animal))
                _animalList.Remove(animal);
            else
                throw new Exception("Error,animal not found in list.");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<AquaticAnimals> GetEnumerator()
        {
            foreach(var el in _animalList)
            {
                yield return el;
            }
        }

        public AquaticAnimals this[int index]  
        {
            get { return _animalList[index]; }   // Мб Добавить проверки
            set { _animalList[index] = value; }  // и throw
        }


    }
}
