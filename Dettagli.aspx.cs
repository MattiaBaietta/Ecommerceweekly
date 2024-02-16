using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommerceweekly
{
    public partial class Dettagli : System.Web.UI.Page
    {
        public static List<Articolo> Acquisti = new List<Articolo>();
        public void addtoCart(Articolo id)
        {
            Acquisti.Add(id);

        }
        int ultimaParteUrl;
        protected void Page_Load(object sender, EventArgs e)
        {
            string url = Request.Url.AbsoluteUri;
            string fileName = Path.GetFileName(url);



            if (int.TryParse(fileName, out ultimaParteUrl) && ultimaParteUrl >= 0 && ultimaParteUrl < Homepage.articoli.Length)
            {

                if (!IsPostBack)
                {
                    RepeaterArticolo.DataSource = new Articolo[] { Homepage.articoli[ultimaParteUrl] };
                    RepeaterArticolo.DataBind();
                }
            }

        }


        public void CarrelloDetails_Click(object sender, EventArgs e)
        {
            string baseUrl = Request.Url.GetLeftPart(UriPartial.Authority);
            Response.Redirect(baseUrl + "/Carrello.aspx");

        }

        protected void AddtoCart_Click(object sender, EventArgs e)
        {
            addtoCart(Homepage.articoli[ultimaParteUrl]);
        }

        public void ToHome_Click(object sender, EventArgs e)
        {
            string baseUrl = Request.Url.GetLeftPart(UriPartial.Authority);
            Response.Redirect(baseUrl + "/Homepage.aspx");
        }
    }
}