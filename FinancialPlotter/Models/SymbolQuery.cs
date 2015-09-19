using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlotter.Models
{

    [DataContract]
    public class SymbolQuery
    {
        [DataMember]
        public Query query { get; set; }
    }

    [DataContract]
    public class Query
    {
        [DataMember]
        public int count { get; set; }
        [DataMember]
        public DateTime created { get; set; }
        [DataMember]
        public string lang { get; set; }
        [DataMember]
        public Diagnostics diagnostics { get; set; }
        [DataMember]
        public Results results { get; set; }
    }

    [DataContract]
    public class Diagnostics
    {
        [DataMember]
        public Url[] url { get; set; }
        [DataMember]
        public string publiclyCallable { get; set; }
        [DataMember]
        public Query1[] query { get; set; }
        [DataMember]
        public Javascript javascript { get; set; }
        [DataMember]
        public string usertime { get; set; }
        [DataMember]
        public string servicetime { get; set; }
        [DataMember]
        public string buildversion { get; set; }
    }

    [DataContract]
    public class Javascript
    {
        [DataMember]
        public string executionstarttime { get; set; }
        [DataMember]
        public string executionstoptime { get; set; }
        [DataMember]
        public string executiontime { get; set; }
        [DataMember]
        public string instructionsused { get; set; }
        [DataMember]
        public string tablename { get; set; }
    }

    [DataContract]
    public class Url
    {
        [DataMember]
        public string executionstarttime { get; set; }
        [DataMember]
        public string executionstoptime { get; set; }
        [DataMember]
        public string executiontime { get; set; }
        [DataMember]
        public string content { get; set; }
    }

    [DataContract]
    public class Query1
    {
        [DataMember]
        public string executionstarttime { get; set; }
        [DataMember]
        public string executionstoptime { get; set; }
        [DataMember]
        public string executiontime { get; set; }
        [DataMember]
        public string _params { get; set; }
        [DataMember]
        public string content { get; set; }
    }

    [DataContract]
    public class Results
    {
        [DataMember]
        public Quote[] quote { get; set; }
    }

    [DataContract]
    public class Quote
    {
        [DataMember]
        public string Symbol { get; set; }
        [DataMember]
        public string Date { get; set; }
        [DataMember]
        public string Open { get; set; }
        [DataMember]
        public string High { get; set; }
        [DataMember]
        public string Low { get; set; }
        [DataMember]
        public string Close { get; set; }
        [DataMember]
        public string Volume { get; set; }
        [DataMember]
        public string Adj_Close { get; set; }
    }

}
