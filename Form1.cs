using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFriendsList
{
    public partial class Form1 : Form
    {
        List<String> myFriends = new List<String>();
        BindingSource bs = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            bs.DataSource = myFriends;
        }

        private void btn_addfriend_Click(object sender, EventArgs e)
        {
            myFriends.Add(txt_newfriend.Text);
            listBox1.DataSource = bs;
            bs.ResetBindings(false);
            label1.Text = "There are " + myFriends.Count + " friends";
        }

        private void btn_addfive_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = bs;
            myFriends.Add("Steve");
            myFriends.Add("Aliya");
            myFriends.Add("Mukasa");
            myFriends.Add("Denis");
            myFriends.Add("Steyner");
            bs.ResetBindings(false);
            label1.Text = "There are " + myFriends.Count + " friends";
        }

        private void btn_sortAscending_Click(object sender, EventArgs e)
        {
            myFriends.Sort();
            bs.ResetBindings(false);
        }

        private void btn_sortDescending_Click(object sender, EventArgs e)
        {
            myFriends.Sort();
            myFriends.Reverse();
            bs.ResetBindings(false);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            
            myFriends.Clear();
            txt_newfriend.Clear();
            label1.Text = "";
            bs.ResetBindings(false);
        }
    }
}
