using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Random_pass_gen
{
    public partial class random_pass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String pass = "abcdefghijklmnopqrstuvwxyz@123456789";
            Random r = new Random();
            char[] mypass = new char[5];
            for (int i = 0; i < 5; i++)
            {
                mypass[i] = pass[(int)(35*r.NextDouble())];
            }
            Label4.Text = "thanks for Register : Your Generated Temporary password  is <br> " + new string(mypass) + "</br>";
        } 
    }
}