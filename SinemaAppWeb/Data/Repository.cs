using Microsoft.AspNetCore.Mvc;
using SinemaAppWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinemaAppWeb.Data
{
    public class MovieRepository
    {
        private static List<Movie> _movies = null; //_movies isimli boş bir liste oluşturduk.
        static MovieRepository()
        {
            _movies = new List<Movie>()
            {
                
                new Movie(){ Id=1, 
                          Name="Mile 22", 
                          Description="Mile 22, ekibi ile birlikte zorlu bir mücadeleye girişen James Silva’nın hikayesini anlatıyor. James Silva devlet tarafından yok sayılan bir adamdır. O ve başında olduğu ekip, CIA'in en değerli, en müdahale edilemez ve hakkında çok az kişinin bilgisi olduğu bir ekiptir. 6 şehre yayılan bir zararı önlemek için gizli bilgilere sahip olan bir kaynak ortaya çıktığında, iş Silva'nın ekibine düşer. Silva'nın görevi çok gizli taktik komuta ekibiyle birlikte, bilgilere sahip olan adamı güvenli bölgeye ulaştırmak ardından da gizlediği bilgileri öğrenmektir. Ancak bu bilgilere ulaşmak isteyen tek taraf onlar değildir. Bilgileri elde etmek isteyen kimliği belirsiz bir ekip, Silva'nın ekibi ile ölümcül bir mücadeleye başlar...",
                          Yonetmen= "The Kingdom ve Lone Survivor",
                          Oyuncular="Mark Wahlberg, Lauren Cohan, Iko Uwais",
                          ImageUrl="a1.png", CategoryId=1},


                        new Movie(){ Id=2,
                          Name="Çakal (Jackal)",
                          Description="Çakalın öykü akışındaki temel unsur, FBI Başkan Yardımcısı Carter Prestn, (Sidney Poiter) yer altı örgüt üyesi Irlandalı Declan Mulqueen (Richard Gere) ve Rus istihbarat görevlisi Valentina Koslova (Diane Gere) arasında kurulan zoraki bir ittifaktır.Çakal (Bruce Willis) takma adıyla ün salmış geçen yüzyılın en acımasız teröristinin izini sürmek amacıyla biraraya gelmişlerdir. Birbirlerine karşı tam anlamıyla yabancı olan bu üçül, zaman içinde hayatta kalabilmek amacıyla birbirlerine destek olmak zorundadırlar. Birbirlerine güvenmek ve aralarında sıkı bir işbirliği bulunması gerektiğini anlarlar.",
                          Yonetmen= "Bruce Willis ve Richard Gere ",
                          Oyuncular="Bruce Willis, Diane Venora, Richard Gere, Sidney Poitier",
                          ImageUrl="a2.png", CategoryId=1},


                        new Movie(){ Id=3,
                          Name="Ghost in the Shell",
                          Description="Korkunç bir kazadan kurtarılan Binbaşı Mira Killian, geçmişine dair hiçbir şey hatırlamamaktadır. Vücudu kurtarılamayan genç kadına dünyanın en tehlikeli suçlularını durdurması ve siber-geliştirilmiş insan türünün ilk örneği olması adına kusursuz bir vücut yapılır.Terörizm, insanların zihinlerine girip onları kontrol eden yeni bir boyuta ulaşmıştır ve Binbaşı’nın görevi bu suçlarla mücadele etmektedir.Yeni bir düşmanla yüzleşmeye hazırlanırken kendisine yalan söylendiğini, hayatının kurtarılmadığını ve çalındığını öğrenir.",
                          Yonetmen= "Rupert Sanders ",
                          Oyuncular="Scarlett Johansson-Binbaşı Mira Killian / Motoko Kusanagi,Kaori Yamamoto-genç Motoko,Pilou Asbæk-Batou",
                          ImageUrl="a3.png", CategoryId=1},


                        new Movie(){ Id=4,
                          Name="Bay ve Bayan Smith",
                          Description="Karşılıklı yalanlar söyleyen evli bir çift, birbirlerine düşman olan iki rakip firmanın tetikçileridirler. Zaman geçer ve bu iki tetikçi birbirlerini öldürmesi için emir alırlar ama bunu asla başaramazlar. Buna karşılık ikiliyi öldürmeye gelecek olan onlarca tetikçi doğar.",
                          Yonetmen= "Doug Liman ",
                          Oyuncular="Brad Pitt, Angelina Jolie",
                          ImageUrl="a4.png", CategoryId=1},


                        new Movie(){ Id=5,
                          Name="Sherlock Holmes",
                          Description="Kadın izleyicilerin birçoğunun iki favori aktörü Jude Law ve Robert Downey Jr, eşine az rastlanır bir uyumla, beyazperde'de Arthur Conan Doyle'un dünyaca ünlü karakteri Sherlock Holmes'ün yeni versiyonuna hayat veriyorlar. Bu dinamik yeni uyarlamada, Holmes ve cesur ortağı Watson, birbirinden tehlikeli maceralara gözlerini karartıp dalıyorlar. Dövüş tekniklerini, efsanevi zekası gibi silah olarak kullanan Holmes, bu serüvende ülkesini tahrip edebilecek ölümcül bir komployu aydınlatmak için yeni bir düşman ile savaşmak zorundadır. Robert Downey Jr. , efsanevi dedektif Sherlock Holmes'ü daha önce benzeri görülmemiş bir yorumla canlandırıyor. Jude Law ise doktor ve bir savaş gazisi olan, Holmes'ün kadim dostu, güvenilir çalışma arkadaşı Watson rolünde karşımıza çıkıyor. Holmes'ü alt eden ilk ve tek kadın olan ve dedektifle halen çalkantılı bir ilişki sürdüren Irene Adler rolünü Rachel McAdams üstleniyor. Mark Strong gizemli yeni düşman Blackwood rolünü oynuyor. Kelly Reilly ise Watson'ın ilgilendiği Mary rolünde yer alıyor.",
                          Yonetmen= "Guy Ritchie ",
                          Oyuncular=" Robert Downey Jr.,Jude Law  ",
                          ImageUrl="a5.png", CategoryId=1},






                      new Movie(){ Id=6,
                          Name="Parlak Yıldız (2009) | IMDb 7.0",
                          Description="Kadın izleyicilerin birçoğunun iki favori aktörü Jude Law ve Robert Downey Jr, eşine az rastlanır bir uyumla, beyazperde'de Arthur Conan Doyle'un dünyaca ünlü karakteri Sherlock Holmes'ün yeni versiyonuna hayat veriyorlar. Bu dinamik yeni uyarlamada, Holmes ve cesur ortağı Watson, birbirinden tehlikeli maceralara gözlerini karartıp dalıyorlar. Dövüş tekniklerini, efsanevi zekası gibi silah olarak kullanan Holmes, bu serüvende ülkesini tahrip edebilecek ölümcül bir komployu aydınlatmak için yeni bir düşman ile savaşmak zorundadır. Robert Downey Jr. , efsanevi dedektif Sherlock Holmes'ü daha önce benzeri görülmemiş bir yorumla canlandırıyor. Jude Law ise doktor ve bir savaş gazisi olan, Holmes'ün kadim dostu, güvenilir çalışma arkadaşı Watson rolünde karşımıza çıkıyor. Holmes'ü alt eden ilk ve tek kadın olan ve dedektifle halen çalkantılı bir ilişki sürdüren Irene Adler rolünü Rachel McAdams üstleniyor. Mark Strong gizemli yeni düşman Blackwood rolünü oynuyor. Kelly Reilly ise Watson'ın ilgilendiği Mary rolünde yer alıyor.",
                          Yonetmen= "Guy Ritchie ",
                          Oyuncular=" Robert Downey Jr.,Jude Law  ",
                          ImageUrl="r1.png", CategoryId=2},


                     new Movie(){ Id=7,
                          Name="Şu An Muhteşem (2013) | IMDb 7.1",
                          Description="Kadın izleyicilerin birçoğunun iki favori aktörü Jude Law ve Robert Downey Jr, eşine az rastlanır bir uyumla, beyazperde'de Arthur Conan Doyle'un dünyaca ünlü karakteri Sherlock Holmes'ün yeni versiyonuna hayat veriyorlar. Bu dinamik yeni uyarlamada, Holmes ve cesur ortağı Watson, birbirinden tehlikeli maceralara gözlerini karartıp dalıyorlar. Dövüş tekniklerini, efsanevi zekası gibi silah olarak kullanan Holmes, bu serüvende ülkesini tahrip edebilecek ölümcül bir komployu aydınlatmak için yeni bir düşman ile savaşmak zorundadır. Robert Downey Jr. , efsanevi dedektif Sherlock Holmes'ü daha önce benzeri görülmemiş bir yorumla canlandırıyor. Jude Law ise doktor ve bir savaş gazisi olan, Holmes'ün kadim dostu, güvenilir çalışma arkadaşı Watson rolünde karşımıza çıkıyor. Holmes'ü alt eden ilk ve tek kadın olan ve dedektifle halen çalkantılı bir ilişki sürdüren Irene Adler rolünü Rachel McAdams üstleniyor. Mark Strong gizemli yeni düşman Blackwood rolünü oynuyor. Kelly Reilly ise Watson'ın ilgilendiği Mary rolünde yer alıyor.",
                          Yonetmen= "Guy Ritchie ",
                          Oyuncular=" Robert Downey Jr.,Jude Law  ",
                          ImageUrl="r2.png", CategoryId=2},


                      new Movie(){ Id=8,
                          Name="Çılgın Kalabalıktan Uzak (2015) | IMDb 7.1",
                          Description="Kadın izleyicilerin birçoğunun iki favori aktörü Jude Law ve Robert Downey Jr, eşine az rastlanır bir uyumla, beyazperde'de Arthur Conan Doyle'un dünyaca ünlü karakteri Sherlock Holmes'ün yeni versiyonuna hayat veriyorlar. Bu dinamik yeni uyarlamada, Holmes ve cesur ortağı Watson, birbirinden tehlikeli maceralara gözlerini karartıp dalıyorlar. Dövüş tekniklerini, efsanevi zekası gibi silah olarak kullanan Holmes, bu serüvende ülkesini tahrip edebilecek ölümcül bir komployu aydınlatmak için yeni bir düşman ile savaşmak zorundadır. Robert Downey Jr. , efsanevi dedektif Sherlock Holmes'ü daha önce benzeri görülmemiş bir yorumla canlandırıyor. Jude Law ise doktor ve bir savaş gazisi olan, Holmes'ün kadim dostu, güvenilir çalışma arkadaşı Watson rolünde karşımıza çıkıyor. Holmes'ü alt eden ilk ve tek kadın olan ve dedektifle halen çalkantılı bir ilişki sürdüren Irene Adler rolünü Rachel McAdams üstleniyor. Mark Strong gizemli yeni düşman Blackwood rolünü oynuyor. Kelly Reilly ise Watson'ın ilgilendiği Mary rolünde yer alıyor.",
                          Yonetmen= "Guy Ritchie ",
                          Oyuncular=" Robert Downey Jr.,Jude Law  ",
                          ImageUrl="r3.png", CategoryId=2},


                     new Movie(){ Id=9,
                          Name="5 to 7 (2014) | IMDb 7.1",
                          Description="Kadın izleyicilerin birçoğunun iki favori aktörü Jude Law ve Robert Downey Jr, eşine az rastlanır bir uyumla, beyazperde'de Arthur Conan Doyle'un dünyaca ünlü karakteri Sherlock Holmes'ün yeni versiyonuna hayat veriyorlar. Bu dinamik yeni uyarlamada, Holmes ve cesur ortağı Watson, birbirinden tehlikeli maceralara gözlerini karartıp dalıyorlar. Dövüş tekniklerini, efsanevi zekası gibi silah olarak kullanan Holmes, bu serüvende ülkesini tahrip edebilecek ölümcül bir komployu aydınlatmak için yeni bir düşman ile savaşmak zorundadır. Robert Downey Jr. , efsanevi dedektif Sherlock Holmes'ü daha önce benzeri görülmemiş bir yorumla canlandırıyor. Jude Law ise doktor ve bir savaş gazisi olan, Holmes'ün kadim dostu, güvenilir çalışma arkadaşı Watson rolünde karşımıza çıkıyor. Holmes'ü alt eden ilk ve tek kadın olan ve dedektifle halen çalkantılı bir ilişki sürdüren Irene Adler rolünü Rachel McAdams üstleniyor. Mark Strong gizemli yeni düşman Blackwood rolünü oynuyor. Kelly Reilly ise Watson'ın ilgilendiği Mary rolünde yer alıyor.",
                          Yonetmen= "Guy Ritchie ",
                          Oyuncular=" Robert Downey Jr.,Jude Law  ",
                          ImageUrl="r4.png", CategoryId=2},


                     new Movie(){ Id=10,
                          Name="Masumiyet Yaşı (1993) | IMDb 7.2",
                          Description=" Sosyetenin göz bebeği Newland Archer (Daniel Day-Lewis), May Welland (Winona Ryder) ile nişanlıdır. Ancak Mayin kuzeni Kontes Olenska (Michelle Pfeiffer)'yla tanışınca bütün hayatı değişiyor. Kocasından ayrılan bir kadın olarak, 19. yüzyıl New York'unda dışlanan bu kadını Newland önce savunmaya başlıyor ancak daha sonra ikisi de birbirine aşık oluyorlar.",
                          Yonetmen= "Guy Ritchie ",
                          Oyuncular=" Robert Downey Jr.,Jude Law  ",
                          ImageUrl="r5.png", CategoryId=2},




                      new Movie(){ Id=11,
                          Name="13. Kat / The Thirteenth Floor (1999)",
                          Description=" Sosyetenin göz bebeği Newland Archer (Daniel Day-Lewis), May Welland (Winona Ryder) ile nişanlıdır. Ancak Mayin kuzeni Kontes Olenska (Michelle Pfeiffer)'yla tanışınca bütün hayatı değişiyor. Kocasından ayrılan bir kadın olarak, 19. yüzyıl New York'unda dışlanan bu kadını Newland önce savunmaya başlıyor ancak daha sonra ikisi de birbirine aşık oluyorlar.",
                         Yonetmen= "The Kingdom ve Lone Survivor",
                          Oyuncular="Mark Wahlberg, Lauren Cohan, Iko Uwais",
                          ImageUrl="b1.png", CategoryId=3},


                        new Movie(){ Id=12,
                          Name="Deja Vu (2006)",
                          Description=" Sosyetenin göz bebeği Newland Archer (Daniel Day-Lewis), May Welland (Winona Ryder) ile nişanlıdır. Ancak Mayin kuzeni Kontes Olenska (Michelle Pfeiffer)'yla tanışınca bütün hayatı değişiyor. Kocasından ayrılan bir kadın olarak, 19. yüzyıl New York'unda dışlanan bu kadını Newland önce savunmaya başlıyor ancak daha sonra ikisi de birbirine aşık oluyorlar.",
                         Yonetmen= "Bruce Willis ve Richard Gere ",
                          Oyuncular="Bruce Willis, Diane Venora, Richard Gere, Sidney Poitier",
                          ImageUrl="b2.png", CategoryId=3},


                        new Movie(){ Id=13,
                          Name="Derin Karanlık / Pitch Black (2000)",
                            Description=" Sosyetenin göz bebeği Newland Archer (Daniel Day-Lewis), May Welland (Winona Ryder) ile nişanlıdır. Ancak Mayin kuzeni Kontes Olenska (Michelle Pfeiffer)'yla tanışınca bütün hayatı değişiyor. Kocasından ayrılan bir kadın olarak, 19. yüzyıl New York'unda dışlanan bu kadını Newland önce savunmaya başlıyor ancak daha sonra ikisi de birbirine aşık oluyorlar.",
                        Yonetmen= "Rupert Sanders ",
                          Oyuncular="Scarlett Johansson-Binbaşı Mira Killian / Motoko Kusanagi,Kaori Yamamoto-genç Motoko,Pilou Asbæk-Batou",
                          ImageUrl="b3.png", CategoryId=3},


                        new Movie(){ Id=14,
                          Name="Prometheus (2012)",
                          Description=" Sosyetenin göz bebeği Newland Archer (Daniel Day-Lewis), May Welland (Winona Ryder) ile nişanlıdır. Ancak Mayin kuzeni Kontes Olenska (Michelle Pfeiffer)'yla tanışınca bütün hayatı değişiyor. Kocasından ayrılan bir kadın olarak, 19. yüzyıl New York'unda dışlanan bu kadını Newland önce savunmaya başlıyor ancak daha sonra ikisi de birbirine aşık oluyorlar.",
                         Yonetmen= "Doug Liman ",
                          Oyuncular="Brad Pitt, Angelina Jolie",
                          ImageUrl="b4.png", CategoryId=3},


                        new Movie(){ Id=15,
                          Name=" Yapay Zeka / Artificial Intelligence: AI (2001)",
                           Description=" Sosyetenin göz bebeği Newland Archer (Daniel Day-Lewis), May Welland (Winona Ryder) ile nişanlıdır. Ancak Mayin kuzeni Kontes Olenska (Michelle Pfeiffer)'yla tanışınca bütün hayatı değişiyor. Kocasından ayrılan bir kadın olarak, 19. yüzyıl New York'unda dışlanan bu kadını Newland önce savunmaya başlıyor ancak daha sonra ikisi de birbirine aşık oluyorlar.",
                        Yonetmen= "Guy Ritchie ",
                          Oyuncular=" Robert Downey Jr.,Jude Law  ",
                          ImageUrl="b5.png", CategoryId=3},






                         new Movie(){ Id=16,
                          Name="Süper Ot / How High (2001)",
                          Description=" Sosyetenin göz bebeği Newland Archer (Daniel Day-Lewis), May Welland (Winona Ryder) ile nişanlıdır. Ancak Mayin kuzeni Kontes Olenska (Michelle Pfeiffer)'yla tanışınca bütün hayatı değişiyor. Kocasından ayrılan bir kadın olarak, 19. yüzyıl New York'unda dışlanan bu kadını Newland önce savunmaya başlıyor ancak daha sonra ikisi de birbirine aşık oluyorlar.",
                         Yonetmen= "The Kingdom ve Lone Survivor",
                          Oyuncular="Mark Wahlberg, Lauren Cohan, Iko Uwais",
                          ImageUrl="k1.png", CategoryId=4},


                        new Movie(){ Id=17,
                          Name="En Uzun Mesafe / The Longest Yard (2005)",
                         Description=" Sosyetenin göz bebeği Newland Archer (Daniel Day-Lewis), May Welland (Winona Ryder) ile nişanlıdır. Ancak Mayin kuzeni Kontes Olenska (Michelle Pfeiffer)'yla tanışınca bütün hayatı değişiyor. Kocasından ayrılan bir kadın olarak, 19. yüzyıl New York'unda dışlanan bu kadını Newland önce savunmaya başlıyor ancak daha sonra ikisi de birbirine aşık oluyorlar.",
                         Yonetmen= "Bruce Willis ve Richard Gere ",
                          Oyuncular="Bruce Willis, Diane Venora, Richard Gere, Sidney Poitier",
                          ImageUrl="k2.png", CategoryId=4},


                        new Movie(){ Id=18,
                          Name="Click (2006)",
                          Description=" Sosyetenin göz bebeği Newland Archer (Daniel Day-Lewis), May Welland (Winona Ryder) ile nişanlıdır. Ancak Mayin kuzeni Kontes Olenska (Michelle Pfeiffer)'yla tanışınca bütün hayatı değişiyor. Kocasından ayrılan bir kadın olarak, 19. yüzyıl New York'unda dışlanan bu kadını Newland önce savunmaya başlıyor ancak daha sonra ikisi de birbirine aşık oluyorlar.",
                         Yonetmen= "Rupert Sanders ",
                          Oyuncular="Scarlett Johansson-Binbaşı Mira Killian / Motoko Kusanagi,Kaori Yamamoto-genç Motoko,Pilou Asbæk-Batou",
                          ImageUrl="k3.png", CategoryId=4},


                        new Movie(){ Id=19,
                          Name="Hero (1992)",
                         Description=" Sosyetenin göz bebeği Newland Archer (Daniel Day-Lewis), May Welland (Winona Ryder) ile nişanlıdır. Ancak Mayin kuzeni Kontes Olenska (Michelle Pfeiffer)'yla tanışınca bütün hayatı değişiyor. Kocasından ayrılan bir kadın olarak, 19. yüzyıl New York'unda dışlanan bu kadını Newland önce savunmaya başlıyor ancak daha sonra ikisi de birbirine aşık oluyorlar.",
                          Yonetmen= "Doug Liman ",
                          Oyuncular="Brad Pitt, Angelina Jolie",
                          ImageUrl="k4.png", CategoryId=4},


                        new Movie(){ Id=20,
                          Name="Çılgınlar Sınıfı / Accepted (2006)",
                          Description=" Sosyetenin göz bebeği Newland Archer (Daniel Day-Lewis), May Welland (Winona Ryder) ile nişanlıdır. Ancak Mayin kuzeni Kontes Olenska (Michelle Pfeiffer)'yla tanışınca bütün hayatı değişiyor. Kocasından ayrılan bir kadın olarak, 19. yüzyıl New York'unda dışlanan bu kadını Newland önce savunmaya başlıyor ancak daha sonra ikisi de birbirine aşık oluyorlar.",
                          Yonetmen= "Guy Ritchie ",
                          Oyuncular=" Robert Downey Jr.,Jude Law  ",
                          ImageUrl="k5.png", CategoryId=4},







                         new Movie(){ Id=21,
                          Name="MS. 45",
                           Description=" Sosyetenin göz bebeği Newland Archer (Daniel Day-Lewis), May Welland (Winona Ryder) ile nişanlıdır. Ancak Mayin kuzeni Kontes Olenska (Michelle Pfeiffer)'yla tanışınca bütün hayatı değişiyor. Kocasından ayrılan bir kadın olarak, 19. yüzyıl New York'unda dışlanan bu kadını Newland önce savunmaya başlıyor ancak daha sonra ikisi de birbirine aşık oluyorlar.",
                         Yonetmen= "The Kingdom ve Lone Survivor",
                          Oyuncular="Mark Wahlberg, Lauren Cohan, Iko Uwais",
                          ImageUrl="d1.png", CategoryId=5},


                        new Movie(){ Id=22,
                          Name="Propaganda",
                          Description=" Sosyetenin göz bebeği Newland Archer (Daniel Day-Lewis), May Welland (Winona Ryder) ile nişanlıdır. Ancak Mayin kuzeni Kontes Olenska (Michelle Pfeiffer)'yla tanışınca bütün hayatı değişiyor. Kocasından ayrılan bir kadın olarak, 19. yüzyıl New York'unda dışlanan bu kadını Newland önce savunmaya başlıyor ancak daha sonra ikisi de birbirine aşık oluyorlar.",
                         Yonetmen= "Bruce Willis ve Richard Gere ",
                          Oyuncular="Bruce Willis, Diane Venora, Richard Gere, Sidney Poitier",
                          ImageUrl="d2.png", CategoryId=5},


                        new Movie(){ Id=23,
                          Name="Talaash",
                         Description=" Sosyetenin göz bebeği Newland Archer (Daniel Day-Lewis), May Welland (Winona Ryder) ile nişanlıdır. Ancak Mayin kuzeni Kontes Olenska (Michelle Pfeiffer)'yla tanışınca bütün hayatı değişiyor. Kocasından ayrılan bir kadın olarak, 19. yüzyıl New York'unda dışlanan bu kadını Newland önce savunmaya başlıyor ancak daha sonra ikisi de birbirine aşık oluyorlar.",
                         Yonetmen= "Rupert Sanders ",
                          Oyuncular="Scarlett Johansson-Binbaşı Mira Killian / Motoko Kusanagi,Kaori Yamamoto-genç Motoko,Pilou Asbæk-Batou",
                          ImageUrl="d3.png", CategoryId=5},


                        new Movie(){ Id=24,
                          Name="Öykü (The Tale)",
                           Description=" Sosyetenin göz bebeği Newland Archer (Daniel Day-Lewis), May Welland (Winona Ryder) ile nişanlıdır. Ancak Mayin kuzeni Kontes Olenska (Michelle Pfeiffer)'yla tanışınca bütün hayatı değişiyor. Kocasından ayrılan bir kadın olarak, 19. yüzyıl New York'unda dışlanan bu kadını Newland önce savunmaya başlıyor ancak daha sonra ikisi de birbirine aşık oluyorlar.",
                        Yonetmen= "Doug Liman ",
                          Oyuncular="Brad Pitt, Angelina Jolie",
                          ImageUrl="d4.png", CategoryId=5},


                        new Movie(){ Id=25,
                          Name="İki Dil Bir Bavul",
                          Description=" Sosyetenin göz bebeği Newland Archer (Daniel Day-Lewis), May Welland (Winona Ryder) ile nişanlıdır. Ancak Mayin kuzeni Kontes Olenska (Michelle Pfeiffer)'yla tanışınca bütün hayatı değişiyor. Kocasından ayrılan bir kadın olarak, 19. yüzyıl New York'unda dışlanan bu kadını Newland önce savunmaya başlıyor ancak daha sonra ikisi de birbirine aşık oluyorlar.",
                          Yonetmen= "Guy Ritchie ",
                          Oyuncular=" Robert Downey Jr.,Jude Law  ",
                          ImageUrl="d5.png", CategoryId=5}


            };
        }

        public static List<Movie> Movies //Tüm filmleri geriye döndürecek
        {
            get
            {
                return _movies;
            }
        }

        public static void AddMovie(Movie film) //gönderilen filmi repository'e ekleyecek
        {
            _movies.Add(film);
        }


        public static Movie GetById(int id) //gelen id bilgisini karşılaştırıp o id'nin bulunduğu filmi geri gönderecek
        {
            return _movies.FirstOrDefault(i => i.Id == id);
        }
    }
}
