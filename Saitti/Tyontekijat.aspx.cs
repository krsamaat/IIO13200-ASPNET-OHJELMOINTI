using System;
using System.Configuration; //Web.configin varten
using System.Data; //Dataa ja yleisiä ado.NET juttuja varten
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Tyontekijat : System.Web.UI.Page
{
    string xmlfilu;
    protected void Page_Load(object sender, EventArgs e)
    {
        //haetaan web.config xml-tiedoston nimi
        xmlfilu = ConfigurationManager.AppSettings["xmlfilu"];
        lblMessages.Text = xmlfilu;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //haetaan XML-data DataGrid olioon, joka kytketään gridviewhin
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        DataView dv = new DataView();
        ds.ReadXml(Server.MapPath(xmlfilu)); //huom mappath muuttaa viittauksen
        dt = ds.Tables[0];
        dv = dt.DefaultView;
        gvData.DataSource = dv;
        gvData.DataBind();
    }
}