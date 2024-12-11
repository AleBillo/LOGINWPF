using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Login_WPF.Model
{
    public class Utente
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailID { get; set; }
        public string Pwd { get; set; }
        public string Address { get; set; }
        public string Admin { get; set; }

        public Utente(string fn, string ln, string email, string p, string a,string adm)
        {
            this.FirstName = fn;
            this.LastName = ln;
            this.EmailID = email;
            this.Pwd = p;
            this.Address = a;
            this.Admin = adm;
        }
        public static bool operator  ==(Utente u1, Utente u2)
        {
            if (string.Compare(u1.EmailID, u2.EmailID) == 0)
                return true;
            else
                return false;
        }
        public static bool operator !=(Utente u1, Utente u2)
        {
            if (string.Compare(u1.EmailID, u2.EmailID) == 0)
                return false;
            else
                return true;
        }

    }
    public class Utenti
    {
        private List<Utente> utenti;
        public Utenti()
        {
            this.utenti = new List<Utente>();
        }
        public void LeggiUtenti()
        {
            StreamReader sr = new StreamReader("utenti.txt");
            try
            {
                string riga;
                this.utenti.Clear();
                while((riga=sr.ReadLine())!=null)
                {
                    string[] datiU = riga.Split(',');
                    this.utenti.Add(new Utente(datiU[0], datiU[1], datiU[2], datiU[3], datiU[4], datiU[5]));
                }
            }
            catch(Exception ex)
            {
               
            }
            finally
            {
                sr.Close();
            }

        }

        public string InserisciUtentiLista()
        {
            string tutto = "";
            string riga = "";
            StreamReader sr = new StreamReader("utenti.txt");
            try
            {
                foreach (Utente u in utenti)
                {
                    riga = $"{u.FirstName},{u.LastName},{u.EmailID},{u.Pwd},{u.Address}, Admin: {u.Admin}";
                    tutto = tutto + riga + "\n";
                   
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                sr.Close();
            }

            return tutto;
        }
        public void ScriviUtenti()
        {
            StreamWriter sw = new StreamWriter("utenti.txt");
            try
            {
                foreach(Utente u in utenti)
                {
                    string riga = $"{u.FirstName},{u.LastName},{u.EmailID},{u.Pwd},{u.Address}, Admin: {u.Admin}";
                    sw.WriteLine(riga);
                }
                
            }
            catch (Exception ex)
            {
            }
            finally
            {
                sw.Close();
            }
        }
        public void AggiungiUtente(string fn, string su, string email, string pwd, string ad,string adm)
        {
            LeggiUtenti();
            this.utenti.Add(new Utente(fn, su, email, pwd, ad, adm));
            ScriviUtenti();
        }
        public bool UtenteGiaPresente(string email)
        {
            LeggiUtenti();
            bool presente = false;
            int i = 0;
            Utente u = new Utente("", "", email, "", "","");
            while(!presente && i<utenti.Count)
            {
                if (u == utenti[i])
                    presente = true;
                else
                    i++;
            }
            return presente;
        }
        public bool CredenzialiCorrette(string email, string pwd)
        {
            LeggiUtenti();
            bool ok = false;
            int i = 0;
            Utente u = new Utente("", "", email, pwd, "","");
            while (!ok && i < utenti.Count)
            {
                if(u == utenti[i])
                {
                    if (u.Pwd == utenti[i].Pwd)
                        ok = true;
                }
                i++;
            }
            return ok;
        }
        public string GetFullName(string email)
        {
            LeggiUtenti();
            string fullname = "";
            bool ok = false;
            int i = 0;
            Utente u = new Utente("", "", email, "", "","");
            while (!ok && i < utenti.Count)
            {
                if (u == utenti[i])
                {
                    fullname = utenti[i].FirstName + " " + utenti[i].LastName; 
                    ok = true;
                }
                i++;
            }
            return fullname;
        }

        public bool IsAdmin(string email)
        {
            LeggiUtenti();
           
            bool okt = false;
            bool ok = false;
            int i = 0;
            Utente u = new Utente("", "", email, "", "", "");
            while (!ok && i < utenti.Count)
            {
                if (u == utenti[i])
                {
                    if (utenti[i].Admin == "Y")
                    {
                        okt= true;
                    }
                    else if(utenti[i].Admin == "N")
                    {
                        okt= false;
                    }
                }
                i++;
            }
            return okt;
        }

        public void CambiaRuolo(Welcome u)
        {
            bool ok = false;
            int i = 0;
            string email = u.Utenti_Listbox.SelectedItem.ToString();
            LeggiUtenti();
            Utente ut = new Utente("", "", email, "", "", "");
            while (!ok && i < utenti.Count)
            {
                if (utenti[i].EmailID == email)
                {
                    utenti[i].Admin = "Y";
                }
            }
                
        }
    }
}
