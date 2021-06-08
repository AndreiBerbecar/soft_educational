using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soft_educational
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlInformatii.Visible = false;
            pnlTest.Visible = false;
        }

        private void btnInformatii_Click(object sender, EventArgs e)
        {
            pnlInformatii.Visible = true;
            pnlInformatii.Location = new Point(2, 1);
            pnlInformatii.Size = new Size(912, 528);
            btnInformatii.Visible = false;
            btnTest.Visible = false;
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            /*if(rdbLondra.Checked==true)
            {
                if(rdbTallinn.Checked==true)
                {
                    if(rdbVilnius.Checked==true)
                    {
                       MessageBox.Show("CORECT 3/3");
                    }
                }
               
            }*/
            if(rdbLondra.Checked == true & rdbTallinn.Checked == true & rdbVilnius.Checked == true)
            {
                MessageBox.Show("CORECT 3/3");
            }
            if (rdbLondra.Checked == true)
            {
                if (rdbTallinn.Checked == true)
                {
                    if (rdbVilnius.Checked == false)
                    {
                        MessageBox.Show("CORECT 2/3");
                    }
                }

            }
            if (rdbLondra.Checked == true)
            {
                if (rdbTallinn.Checked == false)
                {
                    if (rdbVilnius.Checked == true)
                    {
                        MessageBox.Show("CORECT 2/3");
                    }
                }

            }
            if (rdbLondra.Checked == true)
            {
                if (rdbTallinn.Checked == false)
                {
                    if (rdbVilnius.Checked == false)
                    {
                        MessageBox.Show("CORECT 1/3");
                    }
                }

            }
            if (rdbLondra.Checked == false)
            {
                if (rdbTallinn.Checked == false)
                {
                    if (rdbVilnius.Checked == false)
                    {
                        MessageBox.Show("INCORECT 0/3");
                    }
                }

            }
            if (rdbLondra.Checked == false)
            {
                if (rdbTallinn.Checked == true)
                {
                    if (rdbVilnius.Checked == false)
                    {
                        MessageBox.Show("CORECT 1/3");
                    }
                }

            }
            if (rdbLondra.Checked == false)
            {
                if (rdbTallinn.Checked == true)
                {
                    if (rdbVilnius.Checked == true)
                    {
                        MessageBox.Show("CORECT 2/3");
                    }
                }

            }
            if (rdbLondra.Checked == false)
            {
                if (rdbTallinn.Checked == false)
                {
                    if (rdbVilnius.Checked == true)
                    {
                        MessageBox.Show("CORECT 1/3");
                    }
                }

            }
            if (rdbLondra.Checked == false)
            {
                if (rdbTallinn.Checked == true)
                {
                    if (rdbVilnius.Checked == true)
                    {
                        MessageBox.Show("CORECT 2/3");
                    }
                }

            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            pnlInformatii.Visible = false;
            pnlTest.Visible = true;
            pnlTest.Location = new Point(2, 1);
            pnlTest.Size = new Size(912, 525);
            btnInformatii.Visible = false;
            btnTest.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlInformatii.Visible = false;
            pnlTest.Visible = false;
            btnTest.Visible = true;
            btnInformatii.Visible = true;
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            pnlInformatii.Visible = false;
            pnlTest.Visible = false;
            btnTest.Visible = true;
            btnInformatii.Visible = true;
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
