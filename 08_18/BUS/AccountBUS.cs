using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;

namespace BUS
{
    public class AccountBUS
    {
        private static AccountBUS instance;

        public static AccountBUS Instance
        {
            get {
                if(instance == null)
                    instance = new AccountBUS();
                return instance; }
    
        }

        private AccountBUS() { }

        public bool insert(string username, string password, int type)
        {
            Account acc = new Account(username, password, type);
            return AccountDAO.Instance.insert(acc);
        }

        public void Load(TextBox textbox, int type)
        {
            textbox.Text = AccountDAO.Instance.GetUsername(type);
        }

        public int select(string username, string password)
        {
            return AccountDAO.Instance.select(username, password);
        }
    }
}
