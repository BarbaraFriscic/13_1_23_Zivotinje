using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_1_23_Zivotinje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnNahrani.Visible = false; btnNahrani.Enabled = false;
        }
        Pas pas;
        Macka macka;
        List<Zivotinja> UdomljeneZivotinje = new List<Zivotinja>();
        private void btnUdomi_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtIme.Text != "" && rbtF.Checked == true || rbtM.Checked == true && cbxVrsta.SelectedIndex != -1)
                {
                    if(cbxVrsta.SelectedIndex == 0)
                    {
                        pas = new Pas();
                        pas.Ime = txtIme.Text;
                        if (rbtF.Checked == true)
                            pas.Spol = 'Ž';
                        else if (rbtM.Checked == true)
                            pas.Spol = 'M';
                        UdomljeneZivotinje.Add(pas);

                        lblShowReturn.Text = $"Udomili ste psa \nIme: {pas.Ime} \nSpol: {pas.Spol}";
                    }
                    else if (cbxVrsta.SelectedIndex == 1)
                    {
                        macka = new Macka();
                        macka.Ime = txtIme.Text;
                        if (rbtF.Checked == true)
                            macka.Spol = 'Ž';
                        else if (rbtM.Checked == true)
                            macka.Spol = 'M';
                        UdomljeneZivotinje.Add(macka);  

                        lblShowReturn.Text = $"Udomili ste mačku \nIme: {macka.Ime} \nSpol: {macka.Spol}";
                    }
                    btnNahrani.Show();
                    btnNahrani.Enabled = true;              
                }
                else
                {
                    MessageBox.Show("Sva polja su obvezna!");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Molimo ispravite svoj unos!");
            }
        }

        private void btnNahrani_Click(object sender, EventArgs e)
        {
            if (UdomljeneZivotinje[UdomljeneZivotinje.Count - 1] is Macka)
                lblShowReturn.Text += $"\n{macka.Glasanje()}";
            else if (UdomljeneZivotinje[UdomljeneZivotinje.Count - 1] is Pas)
                lblShowReturn.Text += $"\n{pas.Glasanje()}";
        }


    }
}
