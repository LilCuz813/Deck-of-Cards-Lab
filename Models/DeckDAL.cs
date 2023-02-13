using System;
using Newtonsoft.Json;
using System.Net;

namespace Deck_of_Cards_API.Models
{
	public class DeckDAL
	{
        public static DeckModel GetDeck()//adjust here
        {
            //adjust here
            //setup
            
            string url = "https://deckofcardsapi.com/api/deck/new/draw/?count=5";


            //request
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //convert it to JSON
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            //adjust here
            //Convert to C#
            DeckModel result = JsonConvert.DeserializeObject<DeckModel>(JSON);
            return result;

        }
    }
}

