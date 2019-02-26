using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpToSQL;

namespace NewUserForm
{
    public partial class userDatabaseEditor : Form
    {
        User user = null;
        public userDatabaseEditor()
        {
            InitializeComponent();
        }



        private void userDatabaseEditor_Load(object sender, EventArgs e)
        {
            user = User.GetByPrimaryKey(3);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var id = userId.Text;
            var idnbr = int.Parse(id);
            user = User.GetByPrimaryKey(idnbr);
            userName.Text = user.Username;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lastName_Click(object sender, EventArgs e)
        {

        }
    }
}
