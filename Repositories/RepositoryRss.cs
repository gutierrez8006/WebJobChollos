using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using WebJobChollos.Models;

namespace WebJobChollos.Repositories
{
    public class RepositoryRss
    {
        public List<CholloRss> GetChollos()
        {
            String url = "https://www.chollometro.com/rss";
            //XmlTextReader reader = new XmlTextReader(url);
            XDocument docxml = LoadRss(url);
            var consulta = from datos in docxml.Descendants("item")
                           select new CholloRss
                           {
                               Titular = datos.Element("title").Value,
                               Enlace = datos.Element("link").Value,
                               Descripcion = datos.Element("description").Value,
                               Categoria = datos.Element("category").Value
                           };
            return consulta.ToList();
        }

        XDocument LoadRss(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.UserAgent = "(Anything other than an empty string)";

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                return XDocument.Load(stream);
            }
        }

    }
}
