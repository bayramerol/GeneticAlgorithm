using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneticAlgorithm
{
    public partial class Form2 : Form
    {
        List<NodeEdge> tumNodeEdgeliDegerleri = new List<NodeEdge>();
        List<Birey> ilkToplum = new List<Birey>();
        StringBuilder sb = new StringBuilder();
        Birey buneslineniyibireyi;
        Double caprazlamaOrani = 0;
        Double mutasyonOrani = 0;
        public int NesilSayisi = 0;
        int BireySayisi = 0;
        List<Birey> rulettekeri_BireyHavuzu = new List<Birey>();
        Random rnd = new Random();
        List<Birey> yeniToplum = new List<Birey>();
        public Form2()
        {
            InitializeComponent();
            label1.Text = "Dosya Adı:";
            button2.Enabled = false;
            comboBoxNesilSayisi.SelectedIndex = 0;
            comboBoxBireySayisi.SelectedIndex = 0;
            comboBoxCaprazlama.SelectedIndex = 0;
            comboBoxMutasyon.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialogMedia = new OpenFileDialog();
                openFileDialogMedia.Filter = "txt Files|*.txt;";
                openFileDialogMedia.Title = "Graph Dosyası Seçiniz";

                if (openFileDialogMedia.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    tumNodeEdgeliDegerleri = new List<NodeEdge>();
                    label1.Text = "Dosya Adı:";
                    button2.Enabled = false;
                    string strFileName = openFileDialogMedia.FileName;
                    String textroutes = System.IO.File.ReadAllText(@"" + strFileName);
                    String[] rows = textroutes.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                    if (rows.Length <= 1000)
                    {
                        MessageBox.Show("Doğru graph dosyasını seçtinize emin olun!\nLütfen gerçek dosya ile tekrar deneyiniz.", "Uyarı");
                        return;
                    }


                    label1.Text = label1.Text + " " + openFileDialogMedia.SafeFileName;
                    List<Node> tumNodeDegeri = new List<Node>();
                    int countNode = int.Parse(rows[0]);
                    Double countEdge = Double.Parse(rows[1]);
                    Node node = new Node();
                    for (int i = 2; i < countNode + 2; i++)
                    {
                        String[] AdiveAgirlik = rows[i].Split(' ');
                        node = new Node();
                        node.Name = AdiveAgirlik[0];
                        node.Agirlik = Double.Parse(AdiveAgirlik[1]);
                        tumNodeDegeri.Add(node);
                        NodeEdge nodeEdge = new NodeEdge();
                        nodeEdge.node = node;
                        nodeEdge.EdgeNode = new List<string>();
                        tumNodeEdgeliDegerleri.Add(nodeEdge);
                    }

                    for (int i = countNode + 2; i < rows.Length; i++)
                    {
                        try
                        {
                            String[] AdiveEdge = rows[i].Split(' ');
                            String NodeAdi = AdiveEdge[0];
                            String BagliNodeninAdi = AdiveEdge[1];
                            NodeEdge temp = tumNodeEdgeliDegerleri.Where(c => c.node.Name == NodeAdi).FirstOrDefault();
                            if (temp != null)
                            {
                                temp.EdgeNode.Add(BagliNodeninAdi);
                            }

                        }
                        catch (Exception)
                        {
                        }


                    }


                    button2.Enabled = true;
                }
                else
                {

                    //işlem yapma

                }

            }
            catch (Exception)
            {
                MessageBox.Show("İşlem sırasında hata oluştu. Lütfen dosyanın okunabilir olduğuna emin olup tekrar deneyiniz.", "Uyarı");
                return;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ilkToplum = new List<Birey>();
                sb = new StringBuilder();
                richTextBox1.Text = sb.ToString();

                try
                {
                    NesilSayisi = Convert.ToInt32(comboBoxNesilSayisi.SelectedItem.ToString(), CultureInfo.InvariantCulture);
                    BireySayisi = Convert.ToInt32(comboBoxBireySayisi.SelectedItem.ToString(), CultureInfo.InvariantCulture);
                    //if ((NesilSayisi <= 2 && NesilSayisi > 500) || (BireySayisi <= 2 && BireySayisi > 500))
                    //{
                    //    throw new Exception();
                    //}
                    caprazlamaOrani = Convert.ToDouble(comboBoxCaprazlama.SelectedItem.ToString(), CultureInfo.InvariantCulture);
                    mutasyonOrani = Convert.ToDouble(comboBoxMutasyon.SelectedItem.ToString(), CultureInfo.InvariantCulture);
                }
                catch (Exception)
                {
                    MessageBox.Show("Nesil ve Birey sayılarını numerik girmelisiniz!.\nGenetik Algoritma minimum ve maksimum değer aralıklarını içermeli (örneğin: değerler negatif olamaz)", "Uyarı");
                    return;
                }

                //ilk nesil random oluşturulur.
                ilkToplum = ToplumOlustur();

                for (int i_nesil = 0; i_nesil < NesilSayisi; i_nesil++)
                {
                    rulettekeri_BireyHavuzu = new List<Birey>();
                    for (int i_birey = 0; i_birey < ilkToplum.Count; i_birey++)
                    {
                        Birey birey = ilkToplum[i_birey];
                        birey.Uygunluk = 0;
                        birey.EdgeOlusturanKromozomlar = new List<string>();
                        Double tempUygunluk = 0;
                        for (int i = 0; i < birey.Kromozom.Count; i++)
                        {
                            if (i + 1 >= birey.Kromozom.Count)
                            {
                                break;
                            }
                            String birinciNode = birey.Kromozom[i];
                            String ikinciNode = birey.Kromozom[i + 1];
                            NodeEdge tempbirinciNode = tumNodeEdgeliDegerleri.Where(c => c.node.Name == birinciNode).FirstOrDefault();
                            NodeEdge tempikinciNode = tumNodeEdgeliDegerleri.Where(c => c.node.Name == ikinciNode).FirstOrDefault();
                            String varmiBirdenikiye = tempbirinciNode.EdgeNode.Where(c => c == ikinciNode).FirstOrDefault();
                            String varmiikidenBire = tempikinciNode.EdgeNode.Where(c => c == birinciNode).FirstOrDefault();
                            if (varmiBirdenikiye != null)
                            {
                                if (varmiikidenBire != null)
                                {
                                    if (tempUygunluk == 0)
                                    {
                                        tempUygunluk += tempbirinciNode.node.Agirlik;
                                    }
                                    tempUygunluk += tempikinciNode.node.Agirlik;
                                    birey.EdgeOlusturanKromozomlar.Add(birinciNode);
                                }
                            }
                            else
                            {
                                birey.Uygunluk += tempUygunluk;

                                if (birey.EdgeOlusturanKromozomlar.Count >= 1)
                                {
                                    birey.EdgeOlusturanKromozomlar.Add(birinciNode);
                                    birey.EdgeOlusturanKromozomlar.Add(birey.EdgeOlusturanKromozomlar[0]);
                                }
                                break;
                            }

                        }
                    }

                    ilkToplum = ilkToplum.OrderByDescending(obj => obj.Uygunluk).ToList();


                    yeniToplum = new List<Birey>();
                    //elitizm yapılıyor en iyi iki birey saklanıyor
                    Birey b1 = (Birey)ilkToplum[0].Clone();
                    Birey b2 = (Birey)ilkToplum[1].Clone();
                    yeniToplum.Add(b1);
                    yeniToplum.Add(b2);
                    int tamamlanacakBireySayisi = ilkToplum.Count - 2;
                    int carpazlamaileOlusturulacakBireySarisi = (int)(tamamlanacakBireySayisi * caprazlamaOrani);
                    int direktalinacakbiresysayisi = tamamlanacakBireySayisi - carpazlamaileOlusturulacakBireySarisi;

                    for (int i = 0; i < carpazlamaileOlusturulacakBireySarisi; i=i+2)
                    {
                        Birey caprazlama_secilen_rulet_ilk_birey = CaprazlanacakBirey_RuletTekeri();
                        Birey caprazlama_secilen_rulet_ikinci_birey = CaprazlanacakBirey_RuletTekeri();
                        List<String> caprazlama_secilen_rulet_ilk_birey_kromozomlari = caprazlama_secilen_rulet_ilk_birey.Kromozom.ToList();
                        List<String> caprazlama_secilen_rulet_ikinci_birey_kromozomlari = caprazlama_secilen_rulet_ikinci_birey.Kromozom.ToList();
                        int caprazlanacakKromozomBogumu = rnd.Next(1, 4);
                        List<String> yenikromozom_bir = new List<string>();
                        List<String> yenikromozom_iki = new List<string>();
                        for (int a = 0; a < caprazlanacakKromozomBogumu; a++)
                        {
                            yenikromozom_bir.Add(caprazlama_secilen_rulet_ilk_birey_kromozomlari[a]);
                            yenikromozom_iki.Add(caprazlama_secilen_rulet_ikinci_birey_kromozomlari[a]);
                        }

                        
                        foreach (String item in caprazlama_secilen_rulet_ikinci_birey_kromozomlari)
                        {
                            String kromozomVarmi = yenikromozom_bir.Where(c => c == item).FirstOrDefault();
                            if (kromozomVarmi == null || kromozomVarmi.Length == 0)
                            {
                                if (yenikromozom_bir.Count < caprazlama_secilen_rulet_ikinci_birey_kromozomlari.Count)
                                {
                                    String bbc = item.ToString();
                                    yenikromozom_bir.Add("" + bbc);
                                }
                               
                            }
                            else
                            {

                            }
                        }

                        foreach (string item in caprazlama_secilen_rulet_ilk_birey_kromozomlari)
                        {
                            String kromozomVarmi = yenikromozom_iki.Where(c => c == item).FirstOrDefault();
                            if (kromozomVarmi == null || kromozomVarmi.Length == 0)
                            {
                                if (yenikromozom_iki.Count < caprazlama_secilen_rulet_ilk_birey_kromozomlari.Count)
                                {
                                    String bbc = item.ToString();
                                    yenikromozom_iki.Add("" + bbc);
                                }
                               
                            }
                        }

                        caprazlama_secilen_rulet_ilk_birey.Kromozom = yenikromozom_bir;
                        caprazlama_secilen_rulet_ikinci_birey.Kromozom = yenikromozom_iki;
                        yeniToplum.Add(caprazlama_secilen_rulet_ilk_birey);
                        yeniToplum.Add(caprazlama_secilen_rulet_ikinci_birey);
                    }

                    for (int i = 0; i < direktalinacakbiresysayisi; i++)
                    {
                        Birey caprazlama_tamamlanan = (Birey)ilkToplum[i].Clone();
                         if (yeniToplum.Count < ilkToplum.Count)
                        {
                              yeniToplum.Add(caprazlama_tamamlanan);
                         }
                       
                    }


                    int mutasynaUgrayacakBireySarisi = (int)(ilkToplum.Count * mutasyonOrani);
                    for (int i = 0; i < mutasynaUgrayacakBireySarisi; i++)
                    {
                        int mustayoanUgrayacakBireyBogumu = rnd.Next(0, ilkToplum.Count);
                        int mustayoanUgrayacak_ilk_Kromozom = rnd.Next(0, ilkToplum[0].Kromozom.Count);
                        int mustayoanUgrayacak_ikinci_Kromozom = rnd.Next(0, ilkToplum[0].Kromozom.Count);
                        string tempTasimaDegeri = ilkToplum[mustayoanUgrayacakBireyBogumu].Kromozom[mustayoanUgrayacak_ilk_Kromozom];
                        ilkToplum[mustayoanUgrayacakBireyBogumu].Kromozom[mustayoanUgrayacak_ilk_Kromozom] = ilkToplum[mustayoanUgrayacakBireyBogumu].Kromozom[mustayoanUgrayacak_ikinci_Kromozom];
                        ilkToplum[mustayoanUgrayacakBireyBogumu].Kromozom[mustayoanUgrayacak_ikinci_Kromozom] = tempTasimaDegeri;
                    }

                    var maxUygunluk = ilkToplum.Max(obj => obj.Uygunluk);
                    buneslineniyibireyi = ilkToplum.Where(obj => obj.Uygunluk == maxUygunluk).FirstOrDefault();
                    String bb = "";
                    for (int i = 0; i < buneslineniyibireyi.EdgeOlusturanKromozomlar.Count; i++)
                    {
                        if (buneslineniyibireyi.EdgeOlusturanKromozomlar.Count == 1)
                        {
                            bb += buneslineniyibireyi.EdgeOlusturanKromozomlar[i];
                        }
                        else
                        {
                            if (i < buneslineniyibireyi.EdgeOlusturanKromozomlar.Count - 1)
                            {
                                bb += buneslineniyibireyi.EdgeOlusturanKromozomlar[i] + " - ";
                            }
                            else
                            {
                                bb += buneslineniyibireyi.EdgeOlusturanKromozomlar[i];
                            }
                        }


                    }

                    sb.AppendLine(String.Format("{0}. Neslin en iyi bireyinin Subgraphı: {1}, Toplam Ağırlıkları: {2}", i_nesil + 1, bb, buneslineniyibireyi.Uygunluk));
                    richTextBox1.Text = sb.ToString();

                    ilkToplum = yeniToplum.ToList();
                }

                labelFinal.Text = buneslineniyibireyi.Uygunluk.ToString();
            }
            catch (Exception)
            {
            }

        }


        public List<Birey> ToplumOlustur()
        {
            List<Birey> toplum = new List<Birey>();
            Random rastgele = new Random();
            try
            {
                while (toplum.Count < BireySayisi)
                {
                    Birey islemyapilacakBirey = new Birey(new List<String>(), 0, new List<string>());
                    int maksimumBaglantili = tumNodeEdgeliDegerleri.Max(c => c.EdgeNode.Count);
                    maksimumBaglantili = 10;
                    while (islemyapilacakBirey.Kromozom.Count < maksimumBaglantili)
                    {
                        int rastint = rastgele.Next(tumNodeEdgeliDegerleri.Count);
                        String kromozomVarmi = islemyapilacakBirey.Kromozom.Where(c => c == rastint.ToString()).FirstOrDefault();
                        if (kromozomVarmi == null)
                        {
                            islemyapilacakBirey.Kromozom.Add(rastint.ToString());
                        }

                    }

                    toplum.Add(islemyapilacakBirey);
                }
            }
            catch (Exception)
            {
            }
            return toplum;
        }


        public Birey CaprazlanacakBirey_RuletTekeri()
        {
            Birey returnBirey = null;

            try
            {
                if (rulettekeri_BireyHavuzu.Count == 0)
                {
                    for (int i = 0; i < ilkToplum.Count; i++)
                    {
                        Birey item = (Birey)ilkToplum[i].Clone();
                        int uygulukdegeri_katsayi = (int)(10 * item.Uygunluk);
                        for (int j = 0; j < uygulukdegeri_katsayi; j++)
                        {
                            rulettekeri_BireyHavuzu.Add(item);
                        }

                    }

                }

                int secilecekrandomBirey = rnd.Next(0, rulettekeri_BireyHavuzu.Count - 1);
                returnBirey = rulettekeri_BireyHavuzu[secilecekrandomBirey];
            }
            catch (Exception)
            {
            }
            return returnBirey;

        }


    }


}
