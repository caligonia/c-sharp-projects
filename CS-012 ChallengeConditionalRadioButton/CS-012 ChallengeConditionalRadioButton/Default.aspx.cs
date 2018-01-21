using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_012_ChallengeConditionalRadioButton
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            resultLabel.Text = "";
            /*
            if (pencilRadioButton.Checked)
               resultLabel.Text = "You selected pencil";            
            else if (penRadioButton.Checked)            
                resultLabel.Text = "You selected pen";            
            else if (phoneRadioButton.Checked)            
                resultLabel.Text = "You selected phone";            
            else if (tabletRadioButton.Checked)            
                resultLabel.Text = "You selected tablet";            
            else            
                resultLabel.Text = "Please select an option";
            */
            if (pencilRadioButton.Checked)
                resultImage.ImageUrl = "pencil.png";
            else if (penRadioButton.Checked)
                resultImage.ImageUrl = "pen.png";
            else if (phoneRadioButton.Checked)
                resultImage.ImageUrl = "phone.png";
            else if (tabletRadioButton.Checked)
                resultImage.ImageUrl = "tablet.png";
            else
                resultLabel.Text = "Please select an option";
        }
    }
}