using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Drinks_WebForm.DTO;

namespace Drinks_WebForm.DAL
{
    public class DrinksDAO
    {
        static String StrCon = "SERVER=den1.mssql8.gear.host;USER=dbdrinks;DATABASE=dbdrinks;PASSWORD=Yn2EO0d~s?IZ";
        DBDrinksDataContext db = new DBDrinksDataContext(StrCon);
        public List<Drink> SelectAll()
        {
            List<Drink> drinks = db.Drinks.ToList();
            return drinks;
        }

        public List<Drink> SelectByName(String keyword)
        {
            List<Drink> drinks = db.Drinks.Where(x => x.Name.Contains(keyword)).ToList();
            return drinks;
        }

        public bool Insert(Drink newdrink)
        {
            try
            {
                db.Drinks.InsertOnSubmit(newdrink);
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool Update(Drink newdrink)
        {
            Drink dbDrink = db.Drinks.SingleOrDefault(d => d.ID == newdrink.ID);
            if (dbDrink != null)
            {
                try
                {
                    dbDrink.ID = newdrink.ID;
                    dbDrink.Type = newdrink.Type;
                    dbDrink.Name = newdrink.Name;
                    dbDrink.Ingredients = newdrink.Ingredients;
                    dbDrink.Price = newdrink.Price;
                    db.SubmitChanges();
                    return true;
                }
                catch { return false; }
            }
            return false;
        }

        public bool Delete(string id)
        {
            Drink dbDrink = db.Drinks.SingleOrDefault(d => d.ID == id);
            if (dbDrink != null)
            {
                try
                {
                    db.Drinks.DeleteOnSubmit(dbDrink);
                    db.SubmitChanges();
                    return true;
                }
                catch { return false; }
            }
            return false;
        }

    }
}