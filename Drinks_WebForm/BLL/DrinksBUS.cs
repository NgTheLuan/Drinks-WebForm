using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Drinks_WebForm.DTO;
using Drinks_WebForm.DAL;


namespace Drinks_WebForm.BLL
{
    public class DrinksBUS
    {
        public List<Drink> GetAll()
        {
            List<Drink> drinks = new DrinksDAO().SelectAll();
            return drinks;
        }

        public List<Drink> Search(string keyword)
        {
            List<Drink> drinks = new DrinksDAO().SelectByName(keyword);
            return drinks;
        }

        public bool AddNew(Drink newdrink)
        {
            bool result = new DrinksDAO().Insert(newdrink);
            return result;
        }

        public bool Update(Drink newdrink)
        {
            bool result = new DrinksDAO().Update(newdrink);
            return result;
        }

        public bool Delete(string id)
        {
            bool result = new DrinksDAO().Delete(id);
            return result;
        }
    }
}