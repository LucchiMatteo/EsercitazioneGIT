using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneGIT
{
    class Autore
    {
        private string _titolo, _autore;
        private double  _durata;

        public void SetTitolo(string titolo)
        {
            if (titolo == "")
                throw new Exception("Errore titolo");
            else
                _titolo = titolo;
        }

        public string GetTitolo()
        {
            return _titolo;
        }

        public void SetAutore(string autore)
        {
            if (autore == "")
                throw new Exception("Errore autore");
            else
                _autore = autore;
        }

        public string GetAutore()
        {
            return _autore;
        }

        public void SetDurata(double durata)
        {
            if (durata <= 0)
                throw new Exception("Errore durata");
            else
                _durata = durata;
        }

        public double GetDurata()
        {
            return _durata;
        }

        public bool shortSong(double durataInput )
        {
            bool maggiore = false;

            if (_durata < durataInput)
                maggiore = false;
            else
                maggiore = true;

            return maggiore;
        }

        public override string ToString()
        {
            return "Titolo: " + _titolo + "Autore: " + _autore + "Durata: " + _durata;
        }

    }
}
