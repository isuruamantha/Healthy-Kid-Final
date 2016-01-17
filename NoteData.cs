using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Notes
{
    class NoteData
    {
        public string note { get; set; }
        public string date { get; set; }

        //convertToGameScoreItems == convertToNote
        public static List<NoteData> convertToNote(string json)
        {
            List<NoteData> rsp = new List<NoteData>();
            try
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<NoteData>));
                using (MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(json)))
                {
                    rsp = serializer.ReadObject(ms) as List<NoteData>;
                }
            }
            catch (Exception ex) { }
            return rsp;
        }
    }
}
