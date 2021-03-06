﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class PersonneRepository : Repository, IPersonneRepository
    {   
        public List<Personne> GetAll()
        {
            return Session.Query<Personne>().ToList();
        }

        public void Save(Personne personne)
        {
            Session.SaveOrUpdate(personne);
            Session.Flush();
        }

        //Vérifie que le login et le mot de passe entrés correspondent
        public bool CompareMdp(string login, string mdp)
        {
            string requete = "select Count(Login),Count(Mdp) from Personne pers where pers.Login = ? and pers.Mdp = ? ";
            var result = Session.CreateQuery(requete).SetString(0, login).SetString(1, mdp).Enumerable<object[]>();
            foreach (object[] row in result)
            {
                int nblogin = int.Parse(row[0].ToString());
                int nbmdp = int.Parse(row[1].ToString());
                if (nblogin > 0 && nbmdp > 0){ return true; }
                else { return false; }
            }
            return false;
        }

        //Renvoie une personne dont le login, mdp et type sont entrés en paramètres
        public Personne TrouverPersonne(string login, string mdp,string type)
        {
            Personne p;
            if (type == ("User")){ p = new Utilisateur();}
            else { p = new Administrateur();}
            string requete = "select pers from Personne pers where pers.Login = ? and pers.Mdp = ?";
            var result = Session.CreateQuery(requete).SetString(0, login).SetString(1, mdp).Enumerable<Personne>();
            foreach (Personne row in result) { p = row; }
            return p;
        }

        //Etudier si un login est déjà présent ou non dans la BDD
        public bool PresentBDD(string login)
        {
            string requete = "select Count(Login),Count(Mdp) from Personne pers where pers.Login = ?";
            var result = Session.CreateQuery(requete).SetString(0, login).Enumerable<object[]>();
            foreach (object[] row in result)
            {
                int nblogin = int.Parse(row[0].ToString());
                if (nblogin > 0)
                {
                    return true;
                }
                else { return false; }

            }
            return false;
        }
    }
}
