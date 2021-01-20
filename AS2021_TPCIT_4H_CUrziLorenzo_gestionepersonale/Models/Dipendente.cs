using System;
using System.Collections.Generic;
using System.Text;

namespace AS2021_TPCIT_4H_CUrziLorenzo_gestionepersonale.Models
{
    class Dipendente
    {
        string _nome;
        string _cognome;
        string _codiceFiscale;
        string _cellulare;
        string _sede;
        string _impiego;

        //Property
        public string Nome
        {
            get
            {
                return _nome;
            }

            set
            {
                _nome = value;
            }
        }

        public string CodiceFiscale
        {
            get
            {
                return _codiceFiscale;
            }

            set
            {
                _codiceFiscale = value;
            }
        }

        public string Cognome
        {
            get
            {
                return _cognome;
            }

            set
            {
                _cognome = value;
            }
        }


        public string Cellulare
        {
            get
            {
                return _cellulare;
            }

            set
            {
                _cellulare = value;
            }
        }

        public string Sede
        {
            get
            {
                return _sede;
            }

            set
            {
                _sede = value;
            }
        }

        public string Impiego
        {
            get
            {
                return _impiego;
            }

            set
            {
                _impiego = value;
            }
        }


        //costruttore default
        public Dipendente ()
        {

        }

        //costruttore standard
        public Dipendente(string n, string c, string cf, string cel, string sede, string imp)
        {
            Nome = n;
            Cognome = c;
            CodiceFiscale = cf;
            Cellulare = cel;
            Sede = sede;
            Impiego = imp;
        }

        //metodo che serve a visualizzare le informazioni di un dipendente
        public string VisualizzaDati()
        {
            return $"Il dipendente {Cognome} {Nome} è impiegato presso la sede {Sede} con il ruolo di {Impiego} e il suo numero di cellulare è: {Cellulare}. \nMentre il suo cofice fiscale è: {CodiceFiscale}";
        }

        //Metodo per cancellare i dati di un dipendente
        public void CancellaDati()
        {
            Nome = null;
            Cognome = null;
            CodiceFiscale = null;
            Cellulare = null;
            Sede = null;
            Impiego = null;
        }

        //Metodo che modificare le informazioni di un dipendente
        public void ModificaDati(string n, string c, string cf, string cel, string sede, string imp)
        {
            Nome = n;
            Cognome = c;
            CodiceFiscale = cf;
            Cellulare = cel;
            Sede = sede;
            Impiego = imp;
        }

    }
}
