using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podo_Affaires
{
    public class Podometre
    {
        private int _valeur;
        public int Valeur { get { return _valeur; } set { _valeur = value; } }
        public Podometre()
        {
            _valeur = 0;
        }
        public void incrementer()
        {
            _valeur++;
        }
        public void decrementer()
        {
            _valeur--;
        }
        public void raz()
        {
            _valeur = 0;
        }
    }
}
