using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace madeline_schimenti_a9
{
    public partial class WebTime : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("hh:mm:ss");

        }

        protected void DropDownListColor_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (DropDownListColor.SelectedIndex)
            {
                // The following switch section causes an error.
                case 0:
                    break;
                // Add a break or other jump statement here.
                case 1:
                    timeLabel.BackColor = System.Drawing.Color.Red;
                    break;
                case 2:
                    timeLabel.BackColor = System.Drawing.Color.Blue;
                    break;
                case 3:
                    timeLabel.BackColor = System.Drawing.Color.Green;
                    break;
            }
           
        }
    }
}