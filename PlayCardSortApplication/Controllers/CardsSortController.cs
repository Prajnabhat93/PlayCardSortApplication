using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayCardSortApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardsSortController : ControllerBase
    {
        [HttpPost]
        public List<string> Post(List<string> inputlist)
        {
            //storing the values in dictionary list
            Dictionary<int, string> cardvaluewithid =
            new Dictionary<int, string>(){
                                  {1, "4T"},{2, "2T"},{3, "ST"},{4, "PT"},{5, "RT"},{6, "2D"},{7, "3D"},
                                  {8, "4D"},{9, "5D"},{10, "6D"},{11, "7D"},{12, "8D"},{13, "9D"},{14, "10D"},
                                  {15, "JD"},{16, "QD"},{17, "KD"},{18, "AD"},{19, "2S"},{20, "3S"},{21, "4S"},{22, "5S"}, {23, "6S"},{24, "7S"},
                                  {25, "8S"},{26, "9S"},  {27, "10S"},{28, "JS"}, {29, "QS"}, {30, "KS"},{31, "AS"},
                                  {32, "2C"}, {33, "3C"},{34, "4C"},{35, "5C"},{36, "6C"},{37, "7C"},{38, "8C"},{39, "9C"},{40, "10C"},{41, "JC"},
                                  {42, "QC"},{43, "KC"},{44, "AC"},{45, "2H"},{46, "3H"},{47, "4H"},{48, "5H"},{49, "6H"},{50, "7H"},{51, "8H"},
                                  {52, "9H"},{53, "10H"},{54, "JH"},{55, "QH"},{56, "KH"},{57, "AH"} };

            Dictionary<int, string> inputcardvaluewithid = new Dictionary<int, string>();
            List<string> sortedcardvaluelist = new List<string>();
            List<int> randomcardidlistid = new List<int>();
            string sortedcardvalue = null;

            //get the id for the user input card value
            foreach (var listItem in inputlist)
            {
                foreach (KeyValuePair<int, string> item in cardvaluewithid)
                {
                    if (listItem.Contains(item.Value))
                        inputcardvaluewithid.Add(item.Key, item.Value);
                }

            }
            //Get the key values and Sort
            randomcardidlistid = inputcardvaluewithid.Keys.ToList();
            randomcardidlistid.Sort();

            //Based on sort key , get the card value    
            foreach (int value in randomcardidlistid)
            {

                sortedcardvalue = inputcardvaluewithid[value];
                sortedcardvaluelist.Add(sortedcardvalue);
            }
            return sortedcardvaluelist;
        }

        [HttpGet]
        public List<string> Get( )
        {
            //storing the values in dictionary list
            Dictionary<int, string> cardvaluewithid =
            new Dictionary<int, string>(){
                                  {1, "4T"},{2, "2T"},{3, "ST"},{4, "PT"},{5, "RT"},{6, "2D"},{7, "3D"},
                                  {8, "4D"},{9, "5D"},{10, "6D"},{11, "7D"},{12, "8D"},{13, "9D"},{14, "10D"},
                                  {15, "JD"},{16, "QD"},{17, "KD"},{18, "AD"},{19, "2S"},{20, "3S"},{21, "4S"},{22, "5S"}, {23, "6S"},{24, "7S"},
                                  {25, "8S"},{26, "9S"},  {27, "10S"},{28, "JS"}, {29, "QS"}, {30, "KS"},{31, "AS"},
                                  {32, "2C"}, {33, "3C"},{34, "4C"},{35, "5C"},{36, "6C"},{37, "7C"},{38, "8C"},{39, "9C"},{40, "10C"},{41, "JC"},
                                  {42, "QC"},{43, "KC"},{44, "AC"},{45, "2H"},{46, "3H"},{47, "4H"},{48, "5H"},{49, "6H"},{50, "7H"},{51, "8H"},
                                  {52, "9H"},{53, "10H"},{54, "JH"},{55, "QH"},{56, "KH"},{57, "AH"} };

            Dictionary<int, string> inputcardvaluewithid = new Dictionary<int, string>();
            List<string> sortedcardvaluelist = new List<string>();
            List<int> randomcardidlistid = new List<int>();
            string sortedcardvalue = null;

            //hard coding the value to check list is sorted
            List<string> inputlist = new List<string>() { "3C", "JS", "2D", "PT", "10H", "KH", "8S", "4T", "AC", "4H", "RT" };
            //get the id for the user input card value
            foreach (var listItem in inputlist)
            {
                foreach (KeyValuePair<int, string> item in cardvaluewithid)
                {
                    if (listItem.Contains(item.Value))
                        inputcardvaluewithid.Add(item.Key, item.Value);
                }

            }
            //Get the key values and Sort
            randomcardidlistid = inputcardvaluewithid.Keys.ToList();
            randomcardidlistid.Sort();

            //Based on sort key , get the card value    
            foreach (int value in randomcardidlistid)
            {

                sortedcardvalue = inputcardvaluewithid[value];
                sortedcardvaluelist.Add(sortedcardvalue);
            }
            return sortedcardvaluelist;
        }
    }
}
