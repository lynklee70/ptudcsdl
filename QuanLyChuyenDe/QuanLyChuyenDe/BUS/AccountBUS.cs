using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyChuyenDe.DAO;

namespace QuanLyChuyenDe.BUS
{
    public class AccountBUS
    {
        string username, password;

        private static AccountBUS instance;

        public static AccountBUS Instance
        {
            get {
                if(instance == null)
                    instance = new AccountBUS();
                return instance; }
    
        }

        private AccountBUS() { }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        int type;

        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        public AccountBUS(string username, string password, int type)
        {
            Username = username;
            Password = password;
            Type = type;
        }

        public bool insert(string username, string password, int type)
        {
            AccountBUS acc = new AccountBUS(username, password, type);
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
