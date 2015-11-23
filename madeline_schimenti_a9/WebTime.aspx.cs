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
                idLabel.Text = "Your unique session ID is: " + Session.SessionID;
                timeoutLabel.Text = "Timeout: " + Session.Timeout + " minutes.";
                
            

        }

        protected void DropDownListColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                switch (DropDownListColor.SelectedIndex)
                {
                    case 0:
                        break;
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

        protected void DropDownFontColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                switch (DropDownFontColor.SelectedIndex)
                {
                    case 0:
                        break;
                    case 1:
                        timeLabel.ForeColor = System.Drawing.Color.White;
                        break;
                    case 2:
                        timeLabel.ForeColor = System.Drawing.Color.Black;
                        break;
                    case 3:
                        timeLabel.ForeColor = System.Drawing.Color.Blue;
                        break;
                    case 4:
                        timeLabel.ForeColor = System.Drawing.Color.Green;
                        break;
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                switch (DropDownFontSize.SelectedIndex)
                {
                    case 0:
                        break;
                    case 1:
                        timeLabel.Font.Size = 10;
                        break;
                    case 2:
                        timeLabel.Font.Size = 12;
                        break;
                    case 3:
                        timeLabel.Font.Size = 14;
                        break;
                    case 4:
                        timeLabel.Font.Size = 16;
                        break;
                    case 5:
                        timeLabel.Font.Size = 18;
                        break;
                    case 6:
                        timeLabel.Font.Size = 20;
                        break;
                }
            }
        }
       
    }
}