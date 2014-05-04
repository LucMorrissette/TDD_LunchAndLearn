using System;
using System.Web.UI.WebControls;

namespace FizzBuzzWebForms.FizzBuzz
{
    public partial class Bad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            const int upper = 100;

            for (var i = 1; i <= upper; i++)
            {
                string result;

                if (i%3 == 0 && i%5 == 0)
                {
                    result = "fizzbuzz";
                }
                else if (i%3 == 0)
                {
                    result = "fizz";
                }
                else if (i%5 == 0)
                {
                    result = "buzz";
                }
                else
                {
                    result = i.ToString();
                }

                BulletedList1.Items.Add(new ListItem() {Text = result, Value = result});
            }
        }
    }
}