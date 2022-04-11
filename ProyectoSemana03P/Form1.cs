using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoSemana03P.Entities;

namespace ProyectoSemana03P
{
    public partial class Form1 : Form
    {
        //List 
        List<Client> MyClients = new List<Client>();

        public Form1()
        {
            InitializeComponent();
        }
        /// Autor: John Huaracallo
        /// Date: 10-04-2022
        /// <summary>
        /// Modifying the UI and adding methods
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        //Close Form
        private void button1_Click(object sender, EventArgs e) => this.Close();

        private void btnClean_Click(object sender, EventArgs e)
        {
            //Delete content of txts
            TxtDNI.Clear();
            TxtApellidos.Clear();
            TxtNombres.Clear();
            TxtEdad.Clear();
            TxtCorreo.Clear();
            TxtDNI.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Check if the client exists 
            if (MyClients.Where(x=>x.DNI == Int32.Parse(TxtDNI.Text)).FirstOrDefault() == null)
            {
                MessageBox.Show("*** ERROR, DNI YA EXISTE ***");
                return;
            }
            //Create new Client
            Client _Client =  new Client(Int32.Parse(TxtDNI.Text), TxtApellidos.Text, TxtNombres.Text, Int32.Parse(TxtEdad.Text), TxtCorreo.Text);
            //add Client
            MyClients.Add(_Client);
            //Update Grid
            GridClients.DataSource = MyClients.ToArray();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Find the matches in the list MyClients 
            Client _ClientR = MyClients.Find(c => c.DNI == Int32.Parse(TxtDNI.Text));
            //Verify what Client is null
            if (_ClientR == null) MessageBox.Show("*** ERROR, DNI NO EXISTE ***");
            //Else delete the Client
            else MyClients.Remove(_ClientR);
            //Update Grid
            GridClients.DataSource = MyClients.ToArray();
        }

        private void gridClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Create new row
            DataGridViewRow row = GridClients.CurrentRow;
            //Append data a row
            TxtDNI.Text = row.Cells[0].Value.ToString();
            TxtApellidos.Text = row.Cells[1].Value.ToString();
            TxtNombres.Text = row.Cells[2].Value.ToString();
            TxtEdad.Text = row.Cells[3].Value.ToString();
            TxtCorreo.Text = row.Cells[4].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Find the matches in the list MyClients 
            Client _ClientUP = MyClients.Find(c => c.DNI == Int32.Parse(TxtDNI.Text));
            //Verify what Client is null
            if (_ClientUP == null) MessageBox.Show("*** ERROR, DNI NO EXISTE ***");
            //Else update Client
            else _ClientUP.ClientUpdate(TxtApellidos.Text, TxtNombres.Text, Int32.Parse(TxtEdad.Text), TxtCorreo.Text);
            //Update Grid
            GridClients.DataSource = MyClients.ToArray();
        }
    }
}
