using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace ColetorTwitter_Console_CSh
{
    [Serializable]
    public class twett
    {
        public twett()
        {

        }

        public twett(DateTime dataCriacao, string idStr, string text, string lang)
        {
            this.dataCriacao = dataCriacao;
            this.idStr = idStr;
            this.text = text;
            this.lang = lang;
        }

        [BsonElement("dataCriacao")]
        public DateTime dataCriacao { get; set; }

        [BsonElement("idStr")]
        public string idStr { get; set; }

        [BsonElement("text")]
        public string text { get; set; }

        [BsonElement("lang")]
        public string lang { get; set; }
    }
}
