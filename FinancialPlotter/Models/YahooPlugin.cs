using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace FinancialPlotter.Models
{
    class YahooPlugin
    {
        Uri url = new Uri(@"http://query.yahooapis.com/v1/public/yql?q=");

        public YahooPlugin()
        {

            //HttpWebRequest request = WebRequest.Create(@"Http://www.yahoo.com/") as HttpWebRequest;
            //using (HttpWebResponse res = request.GetResponse() as HttpWebResponse)
            //{ 
            //    StreamReader stream = new StreamReader(res.GetResponseStream());
            //    response = stream.ReadToEnd();
            //}

            CreateControlPanel();

            DateTime start = new DateTime(2015, 7, 1);
            DateTime end = new DateTime(2015, 7, 25);
            string symbol = "goog";
            RetrievePlottableData(symbol, start, end);



        }

        private void CreateControlPanel()
        {
            controlPanel = new Panel();

            Label labelSymbol = new Label();
            labelSymbol.Text = "Ticker Symbol: ";

            TextBox textBoxSymbol = new TextBox();


            controlPanel.Controls.Add(labelSymbol);
            controlPanel.Controls.Add(textBoxSymbol);
            //controlPanel.Show();

        }

        private Panel controlPanel;

        public Panel ControlPanel
        {
            get { return controlPanel; }
        }

        public PlottableData RetrievePlottableData(string tickerSymbol, DateTime startDate, DateTime endDate)
        {
            this.response = GetSymbolHistoricalData(tickerSymbol, startDate, endDate);
            this.query = ConvertJSonToObject<SymbolQuery>(response);
            return new PlottableData(this.query);
        } 

        private string symbol;

        public string Symbol
        {
            get { return symbol; }
        }

        private SymbolQuery query;

        public SymbolQuery Query
        {
            get
            {
                if (query.query.count == 0)
                    throw new ArgumentException();

                return query;
            }
        }


        private string response;





        /// <summary>
        /// Converts Json into an object.
        /// </summary>
        /// <typeparam name="T">Type of object to be created</typeparam>
        /// <param name="jsonString">The json to be converted.</param>
        /// <returns>Converted object of any type</returns>
        public T ConvertJSonToObject<T>(string jsonString)
        {
            //DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
            //using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonString)))
            //{
            //    T obj = (T)serializer.ReadObject(ms);
            //}
            //return obj;

            //ToDo This can throw an invalidOperationException.
            return new JavaScriptSerializer().Deserialize<T>(jsonString);
        }

        public void GetSymbolQuote(string symbol)
        {
            Uri uri = new Uri(@"http://query.yahooapis.com/v1/public/yql?q=select * from yahoo.finance.quotes where symbol in ('" + symbol + "')&format=json&diagnostics=true&env=http://datatables.org/alltables.env");
            HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;
            using (HttpWebResponse res = request.GetResponse() as HttpWebResponse)
            {
                StreamReader stream = new StreamReader(res.GetResponseStream());
                response = stream.ReadToEnd();
            }
        }

        public string GetSymbolHistoricalData(string tickerSymbol, DateTime startDate, DateTime endDate)
        {
            string response;
            string sDate = startDate.Year + "-" + startDate.Month + "-" + startDate.Day;
            string eDate = endDate.Year + "-" + endDate.Month + "-" + endDate.Day;
            string url = @"https://query.yahooapis.com/v1/public/yql?q=%0Aselect%20*%20from%20yahoo.finance.historicaldata%20where%20symbol%20%20in%20(%22" + tickerSymbol + "%22)%20and%20startDate%20%3D%20%22" + sDate + "%22%20and%20endDate%20%3D%22" + eDate + "%22&format=json&diagnostics=true&env=http%3A%2F%2Fdatatables.org%2Falltables.env&callback=";

            //Uri uri = new Uri(@"https://query.yahooapis.com/v1/public/yql?q=%0Aselect%20*%20from%20yahoo.finance.historicaldata%20where%20symbol%20%20in%20(%22" + tickerSymbol + "%22)%20and%20startDate%20%3D%20%222015-07-01%22%20and%20endDate%20%3D%222015-07-25%22&format=json&diagnostics=true&env=http%3A%2F%2Fdatatables.org%2Falltables.env&callback=");
            Uri uri = new Uri(url);

            HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;
            using (HttpWebResponse res = request.GetResponse() as HttpWebResponse)
            {
                StreamReader stream = new StreamReader(res.GetResponseStream());
                response = stream.ReadToEnd();
            }

            return response;
        }
    }

    class PlottableData : List<Quote>
    {
        public PlottableData(SymbolQuery query)
        {
            foreach (Quote quote in query.query.results.quote)
            {

            }
        }

        Quote quote = new Quote();
    }

}
