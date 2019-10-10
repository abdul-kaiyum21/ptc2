using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWindowsFormsApp.BLL;
using System.Data;
using MyWindowsFormsApp.Reposity;


namespace MyWindowsFormsApp.BLL
{
    public class ItemManager
    {
        ItemReposity _ItemReposity = new ItemReposity();
        public bool Add(string name, double price)
        {
            return _ItemReposity.Add(name, price);
        }
        public bool Update(string name, double price, int id)
        {
            return _ItemReposity.Update(name, price,id);
        }
        public bool Delete( int id)
        {
            return _ItemReposity.Delete(id);
        }

        public DataTable Display()
        {
            return _ItemReposity.Display( );
        }
    }
}
