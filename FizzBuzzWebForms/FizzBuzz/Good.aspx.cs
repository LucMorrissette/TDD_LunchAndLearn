using System;
using System.Web.UI.WebControls;

namespace FizzBuzzWebForms.FizzBuzz
{
    public partial class Good : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            const int upper = 100;

            for (var i = 1; i <= upper; i++)
            {
                var result = i.ToString();//interpreter behaviour will go here
                BulletedList1.Items.Add(new ListItem() { Text = result, Value = result });
            }
        }
    }
}