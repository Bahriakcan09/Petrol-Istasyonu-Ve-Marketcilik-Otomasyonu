using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Windows.Forms;


namespace Petrol_Istasyonu_Ve_Marketcilik_Otomasyonu
{
    public partial class MarketPageForm : Form
    {
        public MarketPageForm()
        {
            InitializeComponent();
        }

        IFirebaseConfig config = new FirebaseConfig
        {
            // Firebase projesinin url adresi
            BasePath = "https://petrol-ve-marketcilik-default-rtdb.firebaseio.com",
            // Firebase setting sayfasindan aldigimiz secret key
            AuthSecret = "QIcj0RgPDtVzQFW919C9ojVnJkJDff7Ps4m7lqQq"
        };

        // Firebase client
        IFirebaseClient client;

        private void BaglantiKontrol()
        {
            client = new FireSharp.FirebaseClient(config);
            
            if (client != null)
                 MessageBox.Show("Bağlantı sağlandı.");
        }

        internal class Urunler
        {
            public int Id { get; set; }
            public string Ad { get; set; }
            public int Adet { get; set; }
            public int Fiyat { get; set; }
        }
        SetResponse response = null;
        Student result = null;
        
        public async void Ekleme()
        {
            var Urun = new Urunler()
            {
                Id = int.Parse(txtStudentId.Text),
                Ad = txtStudentName.Text,
                Adet = int.Parse(txtStudentDepartment.Text),
                Fiyat = int.Parse(txtStudentMail.Text)
               
            };
        
            response = await client.SetTaskAsync("Urunler/" + Urun.Id + "/", Urun);
            result = response.ResultAs<Urunler>();
        
            if (result.Id != null)
                MessageBox.Show("Kaydedildi");
            else
                MessageBox.Show("Kaydedilemedi.");
        }
        
        internal async Task<bool> Silme(Urunler Urun)
        {
            var response = await client.DeleteTaskAsync("Urunler/"+Urun.Id.ToString());
        
            if (response.Success)
                return true;
        
            return false;
        }
        
        //Delete(new Urunler() {Id = 1});

        internal async Task<bool> Guncelleme(Urunler Urun)
        {
            var response = await client.UpdateTaskAsync("Urunler/" +Urun.Id.ToString(), Urun);
            result = response.ResultAs<Urunler>();
        
            if (result.Id != null)
                return true;
        
            return false;
        }

        IFirebaseClient client;
        
        List<Urunler> listUrunler = new List<Urunler>();
        FirebaseResponse response = null;
        
        public async void List()
        {
            response = await client.GetTaskAsync("Urunler");
            var result = response.Body;
            var data = JsonConvert.DeserializeObject<Dictionary<string,Urunler>>(result);
        
            foreach(var item in data)
            {
                Urunler Urun = item.Value;
                listStudent.Add(Urun);
            }
        
            dataGridStudents.ItemsSource = listStudent;
        }

        }
    }
}

