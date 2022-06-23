using eShopOnContainers.Core.Models;
using eShopOnContainers.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eShopOnContainers.Core.Services
{
    internal class ürünler
    {
        public ürünler()
        {

        }

        public ObservableCollection<SubProductItem> sProducts;
        public void AddProducts()
        {
            try
            {
                sProducts = new ObservableCollection<SubProductItem>();
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://www.bilgiustam.com/resimler/2015/11/elma.jpg",
                    Product = "Elma",
                    ID = "0",
                    Price = "10 TL",
                    Favorite = "0",
                    Aciklama = "Amasya Elması "
                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://biokentorganik.com/wp-content/uploads/2021/01/Armut-Deveci-Kg-015c-300x300.jpg.webp",
                    Product = "Armut",
                    ID = "0",
                    Price = "15 TL",
                    Favorite = "0",
                    Aciklama = "Deveci Armut"
                });

                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://biokentorganik.com/wp-content/uploads/2021/01/Cilek-1942911a-4-300x300.jpg.webp",
                    Product = "Çilek",
                    ID = "0",
                    Price = "20 TL",
                    Favorite = "0",
                    Aciklama = "Mango Çileği"
                });

                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://st.myideasoft.com/idea/ad/25/myassets/products/029/patates-ne-kadar_min.jpg?revision=1634632671",
                    Product = "Patates",
                    ID = "0",
                    Price = "10 TL",
                    Favorite = "0",
                    Aciklama = "Alaska Patates"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://nisaorganik.com/wp-content/uploads/2021/02/155_min.jpg",
                    Product = "Soğan",
                    ID = "0",
                    Price = "5 TL",
                    Favorite = "0",
                    Aciklama = "Yemeklik Soğan"

                });

                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://sandalcisarkuteri.com/wp-content/uploads/2020/06/DANA-ANTR%C4%B0KOT-KG-300x300.jpg",
                    Product = "Dana Pirzola",
                    ID = "1",
                    Price = "180 TL",
                    Favorite = "0",
                    Aciklama = "1500gr"
                });

                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://erdalyasar.com/wp-content/uploads/2018/12/dana-bonfile.jpg",
                    Product = "Dana Bonfile",
                    ID = "1",
                    Price = "263 TL",
                    Favorite = "0",
                    Aciklama = "1 KG"
                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://wwwi.globalpiyasa.com/lib/Urun/300/4218aacba72e19ea9d0d31d2b8a78a6d_1.jpg",
                    Product = "Tavuk Piliç",
                    ID = "1",
                    Price = "46 TL",
                    Favorite = "0",
                    Aciklama = "Bütün Tavuk"
                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://cdn.cimri.io/market/260x260/dardanel-300-gr-jumbo-karides--_415505.jpg",
                    Product = "Karides",
                    ID = "1",
                    Price = "300 TL",
                    Favorite = "0",
                    Aciklama="Jumbo Karides"
                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://www.balikhanem.com/Uploads/UrunResimleri/thumb/deniz-levregi-1000-gr.-95bf-3.jpg",
                    Product = "Levrek",
                    ID = "1",
                    Price = "95 TL",
                    Favorite = "0",
                    Aciklama = "2 adet"
                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://st3.myideasoft.com/idea/ad/25/myassets/products/589/8699290720037_min.jpg?revision=1643194865",
                    Product = "Su",
                    ID = "2",
                    Price = "1.25 TL",
                    Favorite = "0",
                    Aciklama="500 Ml"
                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://marketistanbul.ru/wp-content/uploads/2021/09/beypazari-300x300.png",
                    Product = "Maden Suyu",
                    ID = "2",
                    Price = "10,90 TL",
                    Favorite = "0",
                    Aciklama="6X1 Limonlu BeyPazarı"
                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://www.g2meksper.com.tr/medias/sys_master/product-images/product-images/h49/h9f/8814314356766/000000000001014189-1-300x300.jpg",
                    Product = "Kayısı Nektarı",
                    ID = "2",
                    Price = "8,50 TL",
                    Favorite = "0",
                    Aciklama="1 Litre"
                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://g2meksper.com.tr/medias/sys_master/product-images/product-images/hf5/h2c/8814313996318/000000000001014188-1-300x300.jpg",
                    Product = "Şeftali Nektarı",
                    ID = "2",
                    Price = "8,50 TL",
                    Favorite = "0",
                    Aciklama="1 Litre"
                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://cdnsta.avansas.com/mnresize/300/-/urun/84331/coca-cola-1lt-4lu-paket-zoom-1.jpg",
                    Product = "Coca-Cola",
                    ID = "2",
                    Price = "9 TL",
                    Favorite = "0",
                    Aciklama="1 Litre"
                });


                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://dogadansepetim.com/wp-content/uploads/2021/05/YERLI_YUMURTA-300x300.jpg",
                    Product = "Yumurta",
                    ID = "3",
                    Price = "27,90 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://uyarzeytincilik.com/wp-content/uploads/2021/01/milas-yagli-siyah-zeytin-300x300.jpg",
                    Product = "Zeytin",
                    ID = "3",
                    Price = "57,50 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://www.karscengizbey.com/image/cache/catalog/urunler/Atabey-Ardahan-Kars-S%C3%BCzme-cicek-Bal%C4%B1-1000x1000h-300x300.jpg",
                    Product = "Bal",
                    ID = "3",
                    Price = "19,90 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://www.docent724.com/image/cache/catalog/urunler/docent-halka-sucuk-300x300.jpg",
                    Product = "Sucuk",
                    ID = "3",
                    Price = "138,90 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://www.peynirpazari.net/wp-content/uploads/2019/12/besler-ispanyol-salam-1600-gr2559401173-1-300x300.jpg",
                    Product = "Salam",
                    ID = "3",
                    Price = "29,95 TL",
                    Favorite = "0"

                });

                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://esenlik.com.tr/icim-cilekli-sut-180-ml-t-5331.jpg",
                    Product = "Çilekli Süt",
                    ID = "4",
                    Price = "3 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://www.gidakapani.com/wp-content/uploads/2021/05/sek-ciftlik-kaymaksiz-yogurt-450-g-300x300.jpg",
                    Product = "Yogurt",
                    ID = "4",
                    Price = "11,50 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://market.akgunlerpeynircilik.com.tr/wp-content/uploads/2020/06/K%C3%B6y-Tereya%C4%9F%C4%B1-3-Top-300x300.jpg.webp",
                    Product = "Tereyağ",
                    ID = "4",
                    Price = "23,95 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRe_b5W2N-eCVgx8wDm7HcIvQf2L4nBqCWNbSF3Tio3upTYbReDwG6eeqdiFNSoA5tCX18&usqp=CAU",
                    Product = "Ayran",
                    ID = "4",
                    Price = "1,75 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://st1.myideasoft.com/idea/ad/25/myassets/products/740/kinder-sut-dilimi-28gr_min.jpg?revision=1609836579",
                    Product = "Kinder Süt Dilimi",
                    ID = "4",
                    Price = "8,75 TL",
                    Favorite = "0"

                });

                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://filizmakarna.com.tr/wp-content/uploads/2020/09/filiz-makarna-uzun-spagetti.jpg",
                    Product = "Makarna",
                    ID = "5",
                    Price = "5 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://www.yaylabakliyat.com.tr/assets/image/cache/uploads/urunler/yaylaklasik/gonenbaldo-300x300.jpg",
                    Product = "Pirinç",
                    ID = "5",
                    Price = "22,50 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://www.yaylabakliyat.com.tr/assets/image/cache/uploads/urunler/ala-pkt/cig-koftelik-bulgur-300x300.jpg",
                    Product = "Bulgur",
                    ID = "5",
                    Price = "8,75 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://www.icerir.com/wp-content/uploads/2018/02/Dardanel-Ton-Ay%C3%A7i%C3%A7ek-Ya%C4%9Fl%C4%B1-Ton-Bal%C4%B1%C4%9F%C4%B1.jpg",
                    Product = "Ton balığı",
                    ID = "5",
                    Price = "28,50 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://www.gurmekale.com/upload/productsImage/300x300/59.jpg",
                    Product = "Salça",
                    ID = "5",
                    Price = "10,90 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://www.yilmazfirin.com/wp-content/uploads/2021/03/Ekmek-300x300.jpg",
                    Product = "Ekmek",
                    ID = "6",
                    Price = "4 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://www.altunbilekler.com/Uploads/UrunResimleri/Thumb/uno-premium-susamli-hamburger-6li-c0d7.jpg",
                    Product = "Susamlı Hamburger",
                    ID = "6",
                    Price = "12,90 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://tazedo.com/wp-content/uploads/2021/09/Ispanakli-Manti-1-300x300.jpg",
                    Product = "Mantı",
                    ID = "6",
                    Price = "28,90 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://www.nefissunumlar.com/wp-content/uploads/2021/04/175614182_167416648494505_9144848792170095791_n-300x300.jpg",
                    Product = "Kıymalı Pide",
                    ID = "6",
                    Price = "37,10 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://www.nefislezzetim.com/wp-content/uploads/2020/06/Elde-Acma-Bosnak-Boregi-1-300x300.jpg",
                    Product = "Boşnak Böreği",
                    ID = "6",
                    Price = "53,50 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://cikolatablog.com/wp-content/uploads/sutlu-cikolata-kuvertur-blok-11-300x300.jpg",
                    Product = "Çikolata",
                    ID = "7",
                    Price = "8,75 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://www.karlidagmarket.com.tr/eti-cikolatali-gofret-34-gr36-biskuvi-cikolata-321-26-O.jpg",
                    Product = "Gofret",
                    ID = "7",
                    Price = "6,45 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://cdnsta.avansas.com/mnresize/300/-/urun/72088/eti-negro-biskuvi-100-gr-zoom-1.jpg",
                    Product = "Bisküvi",
                    ID = "7",
                    Price = "9,75 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://esenlik.com.tr/eti-popkek-visneli-60-gr--t-4928.jpg",
                    Product = "Kek",
                    ID = "7",
                    Price = "2,50 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://www.arbagida.com.tr/image/cache/catalog/urungorselleri/AAAAFRITOLAY.005-300x300.jpg",
                    Product = "Cips",
                    ID = "7",
                    Price = "8,75 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://www.egesarkuteri.com/images/urunler/8690559704287.jpg",
                    Product = "Tavuklu Salata",
                    ID = "8",
                    Price = "17,90 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://iet-cdn-002.akinsofteticaret.net/karatasmarket.com/Resim/Minik/300x300_thumb_st17617.jpg",
                    Product = "Çiğ Köfte",
                    ID = "8",
                    Price = "25 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://www.icerir.com/wp-content/uploads/2019/01/M.Z.-Ege-Rus-Salatas%C4%B1.jpg",
                    Product = "Rus Salatası",
                    ID = "8",
                    Price = "26,95 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://esenlik.com.tr/erpilic-tavuk-doner-250-gr-t-55312.jpg",
                    Product = "Döner",
                    ID = "8",
                    Price = "30 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://esenlik.com.tr/erpilic-tavuk-nugget-300-gr-t-47462.jpg",
                    Product = "Nugget",
                    ID = "8",
                    Price = "15 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://www.glutensiznokta.com.tr/wp-content/uploads/2021/05/Kechy-Sade-Dondurma-300x300.jpg",
                    Product = "Sade Dondurma",
                    ID = "9",
                    Price = "20 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://bokyeme.com/wp-content/uploads/product_images/982ff4e034207aaa24247e80c003f-300x300.jpg",
                    Product = "Çilekli Sorbe",
                    ID = "9",
                    Price = "25 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://www.glutensiznokta.com.tr/wp-content/uploads/2021/05/Kechy-Fistikli-Dondurma-300x300.jpg",
                    Product = "Fıstıklı Dondurma",
                    ID = "9",
                    Price = "40 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://st3.myideasoft.com/idea/ad/25/myassets/products/046/algida-c-dor-classic-925ml-cikolata-tutkunu-5663_min.jpg?revision=1557215508",
                    Product = "Kahveli Dondurma",
                    ID = "9",
                    Price = "25 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://www.karisikmarket.com/Uploads/UrunResimleri/Thumb/magnum-mini-classic-badem-beyaz-1-bbc5.jpg",
                    Product = "Magnum Mini",
                    ID = "9",
                    Price = "39,90 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://dkcosmo.com/wp-content/uploads/2019/11/3830029295289-300x300.jpg",
                    Product = "Diş Macunu",
                    ID = "10",
                    Price = "39,90 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://cdn.rossmann.com.tr/mnresize/300/300/media/catalog/product/3/0/3014260010317_RS_6203c05077691.jpg",
                    Product = "Diş Fırçası",
                    ID = "10",
                    Price = "20 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://www.cosmoburada.com/wp-content/uploads/2019/12/10416688365618-300x300.jpg",
                    Product = "Şampuan",
                    ID = "10",
                    Price = "20 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://cdn.rossmann.com.tr/mnresize/300/300/media/catalog/product/8/7/8718951509825_RS_6242b966bca2d.jpg",
                    Product = "Duş Jeli",
                    ID = "10",
                    Price = "19,90 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://yirmiyedikuzguncuk.com/wp-content/uploads/2021/05/Fig-Seed-01-300x300.jpg",
                    Product = "Sabun",
                    ID = "10",
                    Price = "15,25 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://cdnsta.avansas.com/mnresize/300/-/urun/77714/berrak-ultra-tuvalet-kagidi-32li-zoom-1.jpg",
                    Product = "Tuvalet Kağıdı",
                    ID = "11",
                    Price = "37,50 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://www.tahtakaletoptancilari.com/image/cache/catalog/urunler/image/data/urunler/kalp-desenli-kagit-pecete-33-cm-x-33-cm-20-adet-300x300.jpg",
                    Product = "Desenli Peçete",
                    ID = "11",
                    Price = "3,50 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://cdnsta.avansas.com/mnresize/300/-/urun/77718/maylo-kagit-havlu-3-katli-12li-zoom-1.jpg",
                    Product = "Kağıt Havlu",
                    ID = "11",
                    Price = "24,25 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://cdn.rossmann.com.tr/mnresize/300/300/media/catalog/product/8/6/8690506505066_RS_5fc788603df80.jpg",
                    Product = "Islak Mendil",
                    ID = "11",
                    Price = "19,50 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://www.doguinternational.com/uploads/images/wetwipes_4868456745f8ad6975fe1c.jpg",
                    Product = "Mendil",
                    ID = "11",
                    Price = "6,90 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://www.omo.com/images/jw6al4qorxz1/2McQyZ3ZrwFAUOirkxZnm0/ead638e8a5db27f1c389550e5bee50e7/bGlxdWlkXzUucG5n/300w-300h/omo-hijyen-s%C4%B1v%C4%B1-deterjan-paket-at%C4%B1%C5%9F.jpg",
                    Product = "Deterjan",
                    ID = "12",
                    Price = "6,90 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://cdnsta.avansas.com/mnresize/300/-/urun/79531/domestos-dag-esintisi-camasir-suyu-750ml-zoom-1.jpg",
                    Product = "Çamaşır Suyu",
                    ID = "12",
                    Price = "10,50 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://cdnsta.avansas.com/mnresize/300/-/urun/93549/omo-color-1950ml-zoom-1.jpg",
                    Product = "Sıvı Deterjan",
                    ID = "12",
                    Price = "27,95 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://ersinambalaj.com/wp-content/uploads/2022/02/bulasiksungeri5li-1-jpg-5.png",
                    Product = "Sünger",
                    ID = "12",
                    Price = "6,90 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://cdnsta.avansas.com/mnresize/300/-/urun/88273/yumos-extra-lilyum-kons-yumusat-1440-ml-zoom-1.jpg",
                    Product = "Yumuşatıcı",
                    ID = "12",
                    Price = "21 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://cdnsta.avansas.com/mnresize/300/-/urun/82479/parex-buzdolabi-poseti-kucuk-boy-zoom-1.jpg",
                    Product = "Buzdolabı Poşeti",
                    ID = "13",
                    Price = "9,50 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://cdnsta.avansas.com/mnresize/300/-/urun/83771/parex-guclu-cop-torbasi-orta-mavi-zoom-1.jpg",
                    Product = "Çöp Torbası",
                    ID = "13",
                    Price = "7,50 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://www.parex.com.tr/files/2016/03/pisirme-kagidi-8-mt-1-300x300.jpg",
                    Product = "Pişirme Kağıddı",
                    ID = "13",
                    Price = "10 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://koctas-img.mncdn.com/mnresize/300/300/productimages/1000412221/1000412221_1_MC/8825846399026_1601447651739.jpg",
                    Product = "Alışveriş Çantası",
                    ID = "13",
                    Price = "4 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://productimages.hepsiburada.net/s/22/375/9956591992882.jpg",
                    Product = "Kağıt Bardak",
                    ID = "13",
                    Price = "4 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://cdn.rossmann.com.tr/mnresize/300/300/media/catalog/product/8/0/8001841130019_RS_61e6d3f56e068.jpg",
                    Product = "Bebek Bezi",
                    ID = "14",
                    Price = "150 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://www.cocukludunya.com/blog/wp-content/uploads/2021/08/aptamil-devam-sutu-300x300.jpg",
                    Product = "Bebek Maması",
                    ID = "14",
                    Price = "99,95 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://www.altunbilekler.com/Uploads/UrunResimleri/Thumb/Eti-Cici-Bebe-Biskuvi-Kutu-1000-Gr-16ef.jpg",
                    Product = "Cici Bebe",
                    ID = "14",
                    Price = "8,40 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://cdn.rossmann.com.tr/mnresize/300/300/media/catalog/product/8/6/8690605073817_RS_623af35df0c28.jpg",
                    Product = "Bebek Şampuanı",
                    ID = "14",
                    Price = "32 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://www.gratis.com/ccstore/v1/images/?source=/file/v1842557250416540326/products/10548082_01.jpg&height=300&width=300",
                    Product = "Bebek Kolonyası",
                    ID = "14",
                    Price = "23,15 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://doralife.com.tr/wp-content/uploads/2019/07/keci_boynuzu_ozu_640gr-2-300x300.jpg",
                    Product = "Keçi Boynuzu",
                    ID = "15",
                    Price = "13,15 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://www.kumanyagonder.com/wp-content/uploads/2018/04/kumanyagonder-com-ogutgida-toptan-gida-AnkaraUnCiftLeylek-1-300x300.jpg",
                    Product = "Un",
                    ID = "15",
                    Price = "23,15 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://www.frambuaz.com.tr/wp-content/uploads/2020/01/karamelli-makaron-12-li-kc294046-1-1-300x300.jpg",
                    Product = "Makaron",
                    ID = "15",
                    Price = "33,50 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://cdnsta.avansas.com/mnresize/300/-/urun/93545/peyman-tuzlu-kavrulmus-findik-130gr-zoom-1.jpg",
                    Product = "Tuzlu Fındık",
                    ID = "15",
                    Price = "23,20 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://www.gratis.com/ccstore/v1/images/?source=/file/v240830637657693931/products/10123052_05.jpg&height=300&width=300",
                    Product = "El Kremi",
                    ID = "15",
                    Price = "16,15 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://www.petburada.com/Uploads/UrunResimleri/Thumb/royal-canin-fit-32-kuru-kedi-mamasi-400--8677.jpg",
                    Product = "Kedi Maması",
                    ID = "16",
                    Price = "6,15 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://www.petburada.com/Uploads/UrunResimleri/Thumb/felicia-kuzulu-yetiskin-kopek-mamasi-3-k-f8e4.jpg",
                    Product = "Köpek Maması",
                    ID = "16",
                    Price = "16,15 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://www.petburada.com/Uploads/UrunResimleri/Thumb/akkum-ince-taneli-kedi-kumu-5-kg-7864.jpg",
                    Product = "Kedi Kumu",
                    ID = "16",
                    Price = "41 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://www.elitpetshop.com.tr/up/urun/urun-1527513434-900-012_th.jpg",
                    Product = "Kuş Yemi",
                    ID = "16",
                    Price = "16,15 TL",
                    Favorite = "0"

                });
                sProducts.Add(new SubProductItem
                {
                    ImageSource = "https://www.petburada.com/Uploads/UrunResimleri/Thumb/whiskas-tavuklu-yavru-kuru-kedi-mamasi-3-2553.jpg",
                    Product = "Tavuklu Kedi Maması",
                    ID = "16",
                    Price = "16,15 TL",
                    Favorite = "0"

                });

            }
            catch (Exception ex)
            {

            }

            searchListModel.list = sProducts;

        }
    }
}
