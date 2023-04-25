using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Windows.Forms;


namespace Petrol_Istasyonu_Ve_Marketcilik_Otomasyonu
{
    public partial class MarketPageForm : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            // Firebase projesinin url adresi
            BasePath = "https://firebase.google.com/docs/web/setup#available-libraries",
            // Firebase setting sayfasindan aldigimiz secret key
            AuthSecret = ""
        };

        // Firebase client
        IFirebaseClient client;

        public MarketPageForm()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // Butona basildiginda Firebase Client baglanti acilir 
            client = new FireSharp.FirebaseClient(config);

            // Eger hata var ise null doner
            if (client == null)
                MessageBox.Show("Bağlantı hatasi.");


            // Firebase database i olustururken directory olusturmadigimiz icin GetAsync icerisini bos biraktik
            FirebaseResponse response = await client.GetAsync("");

            // response ile donen sonuclari Data.cs ye aktardik
            Data result = response.ResultAs<Data>();

            // Sonuclari ekrandaki textBox lara yazdirdik
            //textBox1.Text = result.Data_1;
            //textBox2.Text = result.Data_2;



        }
    }
}

