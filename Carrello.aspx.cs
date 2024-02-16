using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Ecommerceweekly
{
    public partial class Carrello : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Dettagli.Acquisti.Count > 0)
            {
                if (!IsPostBack)
                {
                    RepeaterAcquisti.DataSource = Dettagli.Acquisti;
                    RepeaterAcquisti.DataBind();
                }
            }



        }
        protected void RemoveFromCart_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            int idoggetto = Convert.ToInt32(button.CommandArgument);
            Dettagli.Acquisti.RemoveAll(articolo => articolo.Idoggetto == idoggetto);
            Response.Redirect(Request.Url.AbsoluteUri);


        }

        public void CarrelloDetails_Click(object sender, EventArgs e)
        {
            string baseUrl = Request.Url.GetLeftPart(UriPartial.Authority);
            Response.Redirect(baseUrl + "/Carrello.aspx");

        }
        public void ToHome_Click(object sender, EventArgs e)
        {
            string baseUrl = Request.Url.GetLeftPart(UriPartial.Authority);
            Response.Redirect(baseUrl + "/Homepage.aspx");
        }
        public void ClearCart(object sender, EventArgs e)
        {
            Dettagli.Acquisti.Clear();
            Response.Redirect(Request.Url.AbsoluteUri);

        }

    }
}