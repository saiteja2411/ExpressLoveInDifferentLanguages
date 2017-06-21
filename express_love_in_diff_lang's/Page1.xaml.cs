using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace express_love_in_diff_lang_s
{
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                     
                case (0):
                    textBlock2.Text="I love you";
                    break;
                case (1):
                    textBlock2.Text = "Ek het jou lief";
                    break;
                case (2):
                    textBlock2.Text = "Yes kez sirumen";
                    break;
                case (3):
                    textBlock2.Text = "Ana behibek";
                    break;
                case (4):
                    textBlock2.Text = "Moi Tomak Bhal Pao";
                    break;
                case (5):
                    textBlock2.Text = "Ami tomake bhalobashi";
                    break;
                case (6):
                    textBlock2.Text ="Ya tabe kahayu";
                    break;
                case (7):
                    textBlock2.Text = "M'bi fe";
                    break;
                case (8):
                    textBlock2.Text = "Nahigugma ako kanimo";
                    break;
                case (9):
                    textBlock2.Text = "Obicham te";
                    break;
                case (10):
                    textBlock2.Text = "Soro lahn nhee ah ";
                    break;
                case (11):
                    textBlock2.Text = "Ngo oiy ney a";
                    break;
                case (12):
                    textBlock2.Text = "T'estimo";
                    break;
                case (13):
                    textBlock2.Text = "Ne mohotatse";
                    break;
                case (14):
                    textBlock2.Text = "Ndimakukonda";
                    break;
                case (15):
                    textBlock2.Text = "Ti tengu caru ";
                    break;
                case (16):
                    textBlock2.Text = "Mi aime jou";
                    break;
                case (17):
                    textBlock2.Text = "Volim te";
                    break;
                case (18):
                    textBlock2.Text = "Miluji te";
                    break;
                case (19):
                    textBlock2.Text = "Jeg Elsker Dig";
                    break;
                case (20):
                    textBlock2.Text = "Ik hou van jou";
                    break;
                case (21):
                    textBlock2.Text = "Mi amas vin";
                    break;
                case (22):
                    textBlock2.Text = "Ma armastan sind";
                    break;
                case (23):
                    textBlock2.Text = "Afgreki'";
                    break;
                case (24):
                    textBlock2.Text = "Eg elski teg";
                    break;
                case (25):
                    textBlock2.Text = "Doset daram";
                    break;
                case (26):
                    textBlock2.Text = "Mahal kita ";
                    break;
                case (27):
                    textBlock2.Text = "Mina rakastan sinua";
                    break;
                case (28):
                    textBlock2.Text = "Je t'aime, Je t'adore ";
                    break;
                case (29):
                    textBlock2.Text = "Ik hld fan dy ";
                    break;
                case (30):
                    textBlock2.Text = "Ta gra agam ort";
                    break;
                case (31):
                    textBlock2.Text = "Mikvarhar";
                    break;
                case (32):
                    textBlock2.Text = "Ich liebe dich";
                    break;
                case (33):
                    textBlock2.Text = "S'agapo";
                    break;
                case (34):
                    textBlock2.Text = "Hoo thunay prem karoo cho";
                    break;
                case (35):
                    textBlock2.Text = "Palangga ko ikaw ";
                    break;
                case (36):
                    textBlock2.Text = "Aloha wau ia oi";
                    break;
                case (37):
                    textBlock2.Text = "Ani ohev otah";
                    break;
                case (38):
                    textBlock2.Text = "Guina higugma ko ikaw ";
                    break;
                case (39):
                    textBlock2.Text = "Hum Tumhe Pyar Karte hae";
                    break;
                case (40):
                    textBlock2.Text = "Kuv hlub koj ";
                    break;
                case (41):
                    textBlock2.Text = "Nu' umi unangwa'ta";
                    break;
                case (42):
                    textBlock2.Text = "Szeretlek ";
                    break;
                case (43):
                    textBlock2.Text = "Eg elska tig ";
                    break;
                case (44):
                    textBlock2.Text = "Palangga ko ikaw";
                    break;
                case (45):
                    textBlock2.Text = "Saya cinta padamu";
                    break;
                case (46):
                    textBlock2.Text = "Negligevapse";
                    break;
                case (47):
                    textBlock2.Text = "Taim i' ngra leat";
                    break;
                case (48):
                    textBlock2.Text = "Ti amo ";
                    break;
                case (49):
                    textBlock2.Text = "Aishiteru";
                    break;
                case (50):
                    textBlock2.Text = "Naanu ninna preetisuttene";
                    break;
                case (51):
                    textBlock2.Text = "Kaluguran daka";
                    break;
                case (52):
                    textBlock2.Text = "Mye Chha chain maai";
                    break;
                case (53):
                    textBlock2.Text = "Nakupenda ";
                    break;
                case (54):
                    textBlock2.Text = "Tu magel moga cho";
                    break;
                case (55):
                    textBlock2.Text = "Sarang Heyo";
                    break;
                case (56):
                    textBlock2.Text = "Te amo ";
                    break;
                case (57):
                    textBlock2.Text = "Es tevi miilu";
                    break;
                case (58):
                    textBlock2.Text = "Bahibak";
                    break;
                case (59):
                    textBlock2.Text = "Tave myliu";
                    break;
                case (60):
                    textBlock2.Text = "Saya cintakan mu,Aku cinta padamu";
                    break;
                case (61):
                    textBlock2.Text = "Njan Ninne Premikunnu";
                    break;
                case (62):
                    textBlock2.Text = "Wo ai ni";
                    break;
                case (63):
                    textBlock2.Text = "Me tula prem karto ";
                    break;
                case (64):
                    textBlock2.Text = "Eina nangbu nungsi";
                    break;
                case (65):
                    textBlock2.Text = "Kanbhik";
                    break;
                case (66):
                    textBlock2.Text = "Ana moajaba bik";
                    break;
                case (67):
                    textBlock2.Text = "Ni mits neki ";
                    break;
                case (68):
                    textBlock2.Text = "Ayor anosh'ni ";
                    break;
                case (69):
                    textBlock2.Text = "Jeg Elsker Deg";
                    break;
                case (70):
                    textBlock2.Text = "Moon Tumakoo Bhala Paye";
                    break;
               case (71):
                    textBlock2.Text = "Syota na kita!! ";
                    break;
               case (72):
                    textBlock2.Text = "Inaru Taka";
                    break;
               case (73):
                    textBlock2.Text = "Mi ta stimabo";
                    break;
               case (74):
                    textBlock2.Text = "Doo-set daaram";
                    break;
               case (75):
                    textBlock2.Text = "Iay ovlay ouyay";
                    break;
               case (76):
                    textBlock2.Text = "Kocham Ciebie";
                    break;
               case (77):
                    textBlock2.Text = "Eu te amo";
                    break;
               case (78):
                    textBlock2.Text = "Mai taunu pyar karda";
                    break;
               case (79):
                    textBlock2.Text = "main tanne pyaar karoon";
                    break;
               case (80):
                    textBlock2.Text = "Te iubesc";
                    break;
               case (81):
                    textBlock2.Text = "Ya tebya liubliu";
                    break;
               case (82):
                    textBlock2.Text = "tvayi snihyaami";
                    break;
               case (83):
                    textBlock2.Text = "Tha gradh agam ort";
                    break;
               case (84):
                    textBlock2.Text = "Volim te";
                    break;
               case (85):
                    textBlock2.Text = "Ke a go rata";
                    break;
               case (86):
                    textBlock2.Text = "Maa tokhe pyar kendo ahyan";
                    break;
               case (87):
                    textBlock2.Text = "Techihhila";
                    break;
               case (88):
                    textBlock2.Text = "Lu`bim ta";
                    break;
               case (89):
                    textBlock2.Text = "Ljubim te";
                    break;
               case (90):
                    textBlock2.Text = "Te quiero / Te amo";
                    break;
               case (91):
                    textBlock2.Text = "Ninapenda wewe";
                    break;
               case (92):
                    textBlock2.Text = "Jag alskar dig";
                    break;
               case (93):
                    textBlock2.Text = "Ich lieb Di";
                    break;
               case (94):
                    textBlock2.Text = "Mahal kita";
                    break;
               case (95):
                    textBlock2.Text = "Wa ga ei li";
                    break;
               case (96):
                    textBlock2.Text = "Ua Here Vau Ia Oe";
                    break;
               case (97):
                    textBlock2.Text = "Nan unnai kathalikaraen";
                    break;
               case (98):
                    textBlock2.Text = "Nenu ninnu premistunnanu";
                    break;
               case (99):
                    textBlock2.Text = "Phom rak khun";
                    break;
               case (100):
                    textBlock2.Text = "Seni Seviyorum";
                    break;
               case (101):
                    textBlock2.Text = "Ya tebe kahayu";
                    break;
               case (102):
                    textBlock2.Text = "mai aap say pyaar karta hoo";
                    break;
               case (103):
                    textBlock2.Text = "Anh ye^u em";
                    break;
               case (104):
                    textBlock2.Text = "'Rwy'n dy garu di";
                    break;
               case (105):
                    textBlock2.Text = "Ikh hob dikh";
                    break;
               case (106):
                    textBlock2.Text = "Mo ni fe....";
                    break;

               
            }
        }

        private void ListBoxItem_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
           
            
            listBox1.Items.Add("Afrikaans");//1
            listBox1.Items.Add("Armenian");//2
            listBox1.Items.Add("Arabic");//
            listBox1.Items.Add("Aassami");
            listBox1.Items.Add("Bengali");
            listBox1.Items.Add("Belarusian");
            listBox1.Items.Add("Bambara");
            listBox1.Items.Add("Bisaya");
            listBox1.Items.Add("Bulgarian");
            listBox1.Items.Add("Cambodian");
            listBox1.Items.Add("Cantonese Chinese");
            listBox1.Items.Add("Catalan");
            listBox1.Items.Add("Cheyenne");
            listBox1.Items.Add("Chichewa");
            listBox1.Items.Add("Corsican");
            listBox1.Items.Add("Creol");
            listBox1.Items.Add("Croatian");
            listBox1.Items.Add("Czech");
            listBox1.Items.Add("Danish");
            listBox1.Items.Add("Dutch ");
            listBox1.Items.Add("Esperanto");
            listBox1.Items.Add("Estonian");
            listBox1.Items.Add("Ethiopian");
            listBox1.Items.Add("Faroese ");
            listBox1.Items.Add("Farsi");
            listBox1.Items.Add("Filipino ");
            listBox1.Items.Add("Finnish");
            listBox1.Items.Add("French");
            listBox1.Items.Add("Frisian");
            listBox1.Items.Add("Gaelic");
            listBox1.Items.Add("Georgian");
            listBox1.Items.Add("German");
            listBox1.Items.Add("Greek");
            listBox1.Items.Add("Gujarati");
            listBox1.Items.Add("Hiligaynon");
            listBox1.Items.Add("Hawaiian");
            listBox1.Items.Add("Hebrew");
            listBox1.Items.Add("Hiligaynon 2");
            listBox1.Items.Add("Hindi");
            listBox1.Items.Add("Hmong");
            listBox1.Items.Add("Hopi");
            listBox1.Items.Add("Hungarian");
            listBox1.Items.Add("Icelandic");
            listBox1.Items.Add("longgo ");
            listBox1.Items.Add("Indonesian");
            listBox1.Items.Add("Inuit");
            listBox1.Items.Add("Irish ");
            listBox1.Items.Add("Italian");
            listBox1.Items.Add("Japanese");
            listBox1.Items.Add("Kannada");
            listBox1.Items.Add("Kapampangan");
            listBox1.Items.Add("Kashmiri");
            listBox1.Items.Add("Kiswahili");
            listBox1.Items.Add("Konkani");
            listBox1.Items.Add("Korean");
            listBox1.Items.Add("Latin");
            listBox1.Items.Add("Latvian");
            listBox1.Items.Add("Lebanese");
            listBox1.Items.Add("Lithuanian");
            listBox1.Items.Add("Malay");
            listBox1.Items.Add("Malayalam");
            listBox1.Items.Add("Mandarin Chinese");
            listBox1.Items.Add("Marathi");
            listBox1.Items.Add("manipuri");
            listBox1.Items.Add("Mohawk");
            listBox1.Items.Add("Moroccan");
            listBox1.Items.Add("Nahuatl");
            listBox1.Items.Add("Navaho");
            listBox1.Items.Add("Norwegian");
            listBox1.Items.Add("oriya");
            listBox1.Items.Add("Pandacan");
            listBox1.Items.Add("Pangasinan");
            listBox1.Items.Add("Papiamento");
            listBox1.Items.Add("Persian");
            listBox1.Items.Add("Pig Latin");
            listBox1.Items.Add("Polish");
            listBox1.Items.Add("Portuguese");
            listBox1.Items.Add("Punjabi");
            listBox1.Items.Add("rajastani");
            listBox1.Items.Add("Romanian ");
            listBox1.Items.Add("Russian");
            listBox1.Items.Add("Sanskrit");
            listBox1.Items.Add("Scot Gaelic");
            listBox1.Items.Add("Serbian");
            listBox1.Items.Add("Setswana");
            listBox1.Items.Add("Sindhi");
            listBox1.Items.Add("Sioux");
            listBox1.Items.Add("Slovak");
            listBox1.Items.Add("Slovenian");
            listBox1.Items.Add("Spanish");
            listBox1.Items.Add("Swahili ");
            listBox1.Items.Add("Swedish");
            listBox1.Items.Add("Swiss-German");
            listBox1.Items.Add("Tagalog");
            listBox1.Items.Add("Taiwanese");
            listBox1.Items.Add("Tahitian");
            listBox1.Items.Add("Tamil");
            listBox1.Items.Add("Telugu");
            listBox1.Items.Add("Thai");
            listBox1.Items.Add("Turkish");
            listBox1.Items.Add("Ukrainian");
            listBox1.Items.Add("Urdu");
            listBox1.Items.Add("Vietnamese");
            listBox1.Items.Add("Welsh");
            listBox1.Items.Add("Yiddish");
            listBox1.Items.Add("Yoruba");
        }
    }
}
