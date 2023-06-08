using UnityEngine;

#region Sorular

//Soru1 - Sahneye bir prefab instantiate edip oluþan objeye x yönünde sürekli bir rotasyon verelim.

//Soru2 - Sahneye bir prefab instantiate edip oluþan prefabý z yönünde belli bir hýzda hareket ettirelim ve obje z ekseninde
//100 birimi geçince ilk oluþtuðu yere pozisyonunu eþitleyelim.Yani sürekli baþladýðý yerden ilerlemeye devam etsin objemiz.

//Soru3 - Sahnede bir küp oluþturun ve bu cube atadýðýnýz bir script ile daha önce oluþturduðunuz bir sphere prefabýný instantiate edin.
//Oluþan sphere sahnede 1 saniye aralýklarla ekranda görebileceðimiz sýnýrlarý aþmadan random olarak baþka pozisyonlara gitsin.
//Ve cube objemiz sürekli sphere objesine bakýyor olsun.

//Soru4 - Sahnede boþ bir obje oluþturup bu objeye atadýðýnýz script ile daha önce oluþturduðunuz capsule perefabýndan 10 tane instantiate edin
//ve bu objeler oluþur oluþmaz kendilerini oluþturan objenin childi olsunlar.
//Daha sonra parent objenin scriptinden bu on tane objenin capsule colliderina ulaþýp
//isTrigger’ýný true, radius deðerini 5, height deðerini 10 yapýp center deðerini ise kendi oluþturduðunuz bir vector3 ile toplayýp deðiþtiriniz.

//Soru5 - 4 adet birbirinden farklý prefab oluþturup bu prefablarý sahneye 2 saniye aralýklarla random bir þekilde random pozisyonlarda oluþturalým.
//Yani 2 saniyede bir bu 4 prefabdan random bir þekilde bir tanesi ekranda görebileceðimiz þekilde random bir pozisyona spanw edilecekler. 

//Soru6 - 3.sorudaki oluþan objeler kendisini oluþturan objeye doðru lerp ile hareket edecekler. 

#endregion

namespace Scripts

{

    public class Odev06AltinciHafta : MonoBehaviour
    {
        public Player01 rotate01;

        public Player02 move01;

        public Player03 random01;

        public GameObject targetSphere;

        [SerializeField] private float lerpSpeed;

        private float _gameTime;

        [SerializeField] private float _repeatTime;

        void Start()
        {

            //Answer01();

            //Answer02();
        }

        private void Update()
        {

            #region Answer03

            _gameTime += Time.deltaTime;

            Debug.Log(_gameTime);

            if (_gameTime > _repeatTime)
            {

                //Answer03();

                _gameTime = 0;

            }

            #endregion

        }


        public void Answer01()

        {

            Instantiate(rotate01, transform.position, Quaternion.identity);

        }

        public void Answer02()

        {

            Instantiate(move01, transform.position, Quaternion.identity);


        }

        public void Answer03()

        {

            Instantiate(random01, transform.position, Quaternion.identity);

            transform.LookAt(targetSphere.transform);

            random01.transform.position = Vector3.Lerp(random01.transform.position, transform.position,  lerpSpeed * Time.deltaTime);

        }

        


    }


}