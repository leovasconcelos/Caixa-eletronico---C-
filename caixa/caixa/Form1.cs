using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caixa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLcima_Click(object sender, EventArgs e)
        {
            txtD.Text = "";
        }

        private void btnLbaixo_Click(object sender, EventArgs e)
        {
            txtMa10.Text = "0";
            txtMa100.Text = "0";
            txtMa25.Text = "0";
            txtMa3.Text = "0";
            txtMa4.Text = "0";
            txtMa40.Text = "0";
            txtMa5.Text = "0";
            txtMa500.Text = "0";

            txtMe10.Text = "0";
            txtMe100.Text = "0";
            txtMe25.Text = "0";
            txtMe3.Text = "0";
            txtMe4.Text = "0";
            txtMe40.Text = "0";
            txtMe5.Text = "0";
            txtMe500.Text = "0";
        }

        private void verificar(float m)
        {
            if (m > 500)
            {
                m = m - 500;

                txtMe500.Text = Convert.ToString(Convert.ToInt16(txtMe500.Text) + 1);

            }
            if (m > 100)
            {
                m = m - 100;

                txtMe100.Text = Convert.ToString(Convert.ToInt16(txtMe100.Text) + 1);

            }

            if (m > 40)
            {
                m = m - 40;

                txtMe40.Text = Convert.ToString(Convert.ToInt16(txtMe40.Text) + 1);

            }

            if (m > 25)
            {
                m = m - 25;

                txtMe25.Text = Convert.ToString(Convert.ToInt16(txtMe25.Text) + 1);

            }

            if (m > 10)
            {
                m = m - 10;

                txtMe10.Text = Convert.ToString(Convert.ToInt16(txtMe10.Text) + 1);

            }

            if (m > 5)
            {
                m = m - 5;

                txtMe5.Text = Convert.ToString(Convert.ToInt16(txtMe5.Text) + 1);

            }

            if (m > 4)
            {
                m = m - 4;

                txtMe4.Text = Convert.ToString(Convert.ToInt16(txtMe4.Text) + 1);

            }

            if (m >= 3)
            {
                m = m - 3;

                txtMe3.Text = Convert.ToString(Convert.ToInt16(txtMe3.Text) + 1);
                
                verificar(m);
            }
            if (m < 3 && m > 0)
            {
                lblTrocoMaior.Text = Convert.ToString(m);
            }

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int a = 0;
            int c = a;
            float x;
            float y = 0;
            float z = 0;
            if (cbME .Checked == true)
            {
                try
                {
                    a = Convert.ToInt16(txtD.Text);
                }
                catch
                {
                    MessageBox.Show("favor, colocar um numero inteiro");
                    txtD.Text = "";
                }
                finally
                {
                    x = a;
                    if (x >= 500)
                    {
                        y = x / 500;
                        Math.Floor(y);
                        y = Convert.ToInt16(y);
                        txtMa500.Text = Convert.ToString(y);
                        z = (x % 500);
                        x = z;
                    }

                    y = 0;
                    if (x >= 100)
                    {
                        y = x / 100;
                        Math.Floor(y);
                        y = Convert.ToInt16(y);
                        txtMa100.Text = Convert.ToString(y);
                        x = (x % 100);
                    }
                    y = 0;
                    if (x >= 40)
                    {
                        y = x / 40;
                        Math.Floor(y);
                        y = Convert.ToInt16(y);
                        txtMa40.Text = Convert.ToString(y);
                        x = (x % 40);
                    }
                    y = 0;
                    if (x >= 25)
                    {
                        y = x / 25;
                        Math.Floor(y);
                        y = Convert.ToInt16(y);
                        txtMa25.Text = Convert.ToString(y);
                        x = (x % 25);
                    }
                    y = 0;
                    if (x >= 10)
                    {
                        y = x / 10;
                        Math.Floor(y);
                        y = Convert.ToInt16(y);
                        txtMa10.Text = Convert.ToString(y);
                        x = (x % 10);
                    }
                    y = 0;
                    if (x >= 5)
                    {
                        y = x / 5;
                        Math.Floor(y);
                        y = Convert.ToInt16(y);
                        txtMa5.Text = Convert.ToString(y);
                        x = (x % 5);
                    }
                    y = 0;
                    if (x >= 4)
                    {
                        y = x / 4;
                        Math.Floor(y);
                        y = Convert.ToInt16(y);
                        txtMa4.Text = Convert.ToString(y);
                        x = (x % 4);
                    }
                    y = 0;
                    if (x >= 3)
                    {
                        y = x / 3;
                        Math.Floor(y);
                        y = Convert.ToInt16(y);
                        txtMa3.Text = Convert.ToString(y);
                        x = (x % 5);
                    }
                    if (x < 3 && x > 0)
                    {
                        lblTrocoMenor.Text = Convert.ToString(x);
                    }
                }
            }


            float m;
            m = 0;
            if (cbMa.Checked == true)
            {
                
                txtMe500.Text = "0";
                txtMe100.Text = "0";
                txtMe40.Text = "0";
                txtMe25.Text = "0";
                txtMe10.Text = "0";
                txtMe5.Text = "0";
                txtMe4.Text = "0";
                txtMe3.Text = "0";

                try
                {
                    a = Convert.ToInt16(txtD.Text);
                }
                catch
                {
                    MessageBox.Show("favor, colocar um numero inteiro");
                    txtD.Text = "";
                }
                finally
                {
                    m = a;
                    verificar(m);
                }
            }
        }

    

        private void Form1_Load(object sender, EventArgs e)
        {
            
                txtMa10.Text = "0";
                txtMa100.Text = "0";
                txtMa25.Text = "0";
                txtMa3.Text = "0";
                txtMa4.Text = "0";
                txtMa40.Text = "0";
                txtMa5.Text = "0";
                txtMa500.Text = "0";

                txtMe10.Text = "0";
                txtMe100.Text = "0";
                txtMe25.Text = "0";
                txtMe3.Text = "0";
                txtMe4.Text = "0";
                txtMe40.Text = "0";
                txtMe5.Text = "0";
                txtMe500.Text = "0";
            
        }
    }
}