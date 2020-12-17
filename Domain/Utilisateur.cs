﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Utilisateur : Personne
    {
        public virtual IList<Album> ListAlbums { get; set; }
        public virtual IList<Album> ListSouhaits { get; set; }
        public virtual IList<Album> Panier { get; set; }

        public Utilisateur(){ Achats = new List<Marche>();
           Voeux = new List<Marche>();
        }
        public Utilisateur(string nom, string type, string login, string mdp)
        {
            Nom = nom;
            Type = type;
            Login = login;
            Mdp = mdp;
            Achats = new List<Marche>();
            Voeux = new List<Marche>();
        }

        public virtual void AjouterSouhait(Album alb)
        {
            ListSouhaits.Add(alb);
        }

        public virtual void AjouterAlbums(Album alb)
        {
            ListAlbums.Add(alb);
        }

        public virtual void AjouterPanier(Album alb)
        {
            Panier.Add(alb);
        }

        public virtual void SupprimerPanier(Album alb)
        {
            Panier.Remove(alb);
        }

        public virtual void SupprimerSouhait(Album alb)
        {
            ListSouhaits.Remove(alb);
        }
    }

}
