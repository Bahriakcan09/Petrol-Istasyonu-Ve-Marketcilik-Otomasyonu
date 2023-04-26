using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Petrol_Istasyonu_Ve_Marketcilik_Otomasyonu
{
    public class internetCheckClass
    {
        public static bool internetCheck()
        {
            WebClient webClient = new WebClient();
            try
            {
                webClient.OpenRead("https://google.com");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
