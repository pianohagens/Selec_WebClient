using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{

    SelectWebClientServiceReference.ServiceClient sc = new SelectWebClientServiceReference.ServiceClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string[] venues = sc.GetVenues();
            DropDownList1.DataSource = venues;
            DropDownList1.DataBind();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        string venue = DropDownList1.SelectedItem.Text;

        SelectWebClientServiceReference.ShowInfo[] shows = sc.GetShowsByVenue(venue);
       
        GridView1.DataSource = shows;
        GridView1.DataBind();

    }
}