using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
  public  class Birey
    {
        public double Uygunluk { get; set; }
        public List<String> EdgeOlusturanKromozomlar { get; set; }
        public List<String> Kromozom { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }


        public Birey(List<String> Kromozom, int Uygunluk, List<String> EdgeOlusturanKromozomlar)
        {
            this.Kromozom = Kromozom;
            this.Uygunluk = Uygunluk;
            this.EdgeOlusturanKromozomlar = EdgeOlusturanKromozomlar;
        }
    }
}
