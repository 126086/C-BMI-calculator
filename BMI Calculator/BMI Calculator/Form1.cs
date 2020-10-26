using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBerekenen_Click(object sender, EventArgs e)
        {
            float gewicht = float.Parse(txtGewicht.Text);
            float lengte = float.Parse(txtLengte.Text);
            float leeftijd = float.Parse(txtLeeftijd.Text);

            float BMI = gewicht/(lengte*lengte);
            string advies = "Hier komt het advies";

            lblBMI.Text = BMI.ToString();
            if (BMI <18.5)
            { 
                lblAdvies.Text = "ondergewicht";
            }
            else if (BMI>25)
            {
                 lblAdvies.Text = "overgewicht"; 
            }
            else
            {
                lblAdvies.Text = "gezond";
            }


        }

        private void lblBMI_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
