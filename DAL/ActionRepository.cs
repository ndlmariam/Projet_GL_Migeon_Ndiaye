﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class ActionRepository : Repository, IActionRepository
    {
        public List<Domain.Action> GetAll()
        {
            return Session.Query<Domain.Action>().ToList();
        }

        public void SaveAction(Domain.Action action)
        {
            Session.SaveOrUpdate(action);
            Session.Flush();
        }

        //Récupérer une action par son nom et le titre d'un album
        public  Domain.Action GetActionByNameAndAlbum(Album alb, String nameofaction)
        {
            Domain.Action action = new Domain.Action();
            string requete = "select a from Action a where a.Nom = ? and a.Album.Nom = ? ";
            var result = Session.CreateQuery(requete).SetString(0, nameofaction).SetString(1, alb.Nom).Enumerable<Domain.Action>();
            foreach (Domain.Action row in result) { action = row; }
            return action;
        }

        public void DeleteAction(Domain.Action action)
        {
            Session.Delete(action);
            Session.Flush();
        }
    }
}
