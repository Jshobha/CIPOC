using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Name :BaseClass
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblMyName.Text = getName();
        WriteFile();
    }

    public override string getName()
    {
        return "Quinnox Consultancy Service Ltd.";
    }

    
}