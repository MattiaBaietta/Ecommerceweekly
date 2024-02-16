using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommerceweekly
{
    public class Articolo
    {
        public string UrlImmagine { get; set; }
        public string Descrizione { get; set; }
        public string NomeOggetto { get; set; }
        public int Idoggetto { get; set; }
        public int Prezzo { get; set; }

        public Articolo(string urlImmagine, string descrizione, string nomeOggetto, int idoggetto, int prezzo)
        {
            UrlImmagine = urlImmagine;
            Descrizione = descrizione;
            NomeOggetto = nomeOggetto;
            Idoggetto = idoggetto;
            Prezzo = prezzo;
        }
    }
    public partial class Homepage : System.Web.UI.Page
    {

        public static Articolo[] articoli = new Articolo[]
        {
            new Articolo("https://assets.gds.it/2017/02/NOKIA-3310-800x800.jpg", "Telefono Indistruttibile", "Nokia 3310",0,1000),
            new Articolo("https://m.media-amazon.com/images/S/aplus-media-library-service-media/d7612d21-5398-4a96-9a8f-1e24d12f8880.__CR0,0,650,350_PT0_SX650_V1___.jpg", "Si piega", "Galaxy fold",1,1500),
            new Articolo("https://assets.swappie.com/cdn-cgi/image/width=600,height=600,fit=contain,format=auto/swappie-iphone-15-plus-blue.png?v=42", "Il migliore", "Iphone 15",2,2000),
            new Articolo("https://www.lombardiabeniculturali.it/img_db/bcpst/ST140/1/l/SC_PST_ST140-00067_IMG-0000051721.jpg", "Si rompe", "Motorola",3,15),
            new Articolo("https://lh3.googleusercontent.com/proxy/ubZpatLCUj4DesJ1jjZ62YWepQdiyMC1eWAyJt3_KuqprKu8tqG_7D-gOgvWs9O_MQJEAne-RX4_uqOeB5FENPqKSP3z9lWuSoMi5bJqtuW5fqwq9wDhsbFKCSyz4I7m_qjjlRReu2_fcG-T7EySqGfFyA", "Cinesata", "Carica Batterie",4,20),
            new Articolo("https://www.trendevice.com/categorie/954/airpods-pro_1.png","Cuffie","Airpods",5,50)
        };

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RepeaterArticoli.DataSource = articoli;
                RepeaterArticoli.DataBind();
            }
        }


        protected void CarrelloHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Carrello.aspx");
        }


    }
}