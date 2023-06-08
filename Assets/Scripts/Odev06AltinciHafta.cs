using UnityEngine;

#region Sorular

//Soru1 - Sahneye bir prefab instantiate edip olu�an objeye x y�n�nde s�rekli bir rotasyon verelim.

//Soru2 - Sahneye bir prefab instantiate edip olu�an prefab� z y�n�nde belli bir h�zda hareket ettirelim ve obje z ekseninde
//100 birimi ge�ince ilk olu�tu�u yere pozisyonunu e�itleyelim.Yani s�rekli ba�lad��� yerden ilerlemeye devam etsin objemiz.

//Soru3 - Sahnede bir k�p olu�turun ve bu cube atad���n�z bir script ile daha �nce olu�turdu�unuz bir sphere prefab�n� instantiate edin.
//Olu�an sphere sahnede 1 saniye aral�klarla ekranda g�rebilece�imiz s�n�rlar� a�madan random olarak ba�ka pozisyonlara gitsin.
//Ve cube objemiz s�rekli sphere objesine bak�yor olsun.

//Soru4 - Sahnede bo� bir obje olu�turup bu objeye atad���n�z script ile daha �nce olu�turdu�unuz capsule perefab�ndan 10 tane instantiate edin
//ve bu objeler olu�ur olu�maz kendilerini olu�turan objenin childi olsunlar.
//Daha sonra parent objenin scriptinden bu on tane objenin capsule colliderina ula��p
//isTrigger��n� true, radius de�erini 5, height de�erini 10 yap�p center de�erini ise kendi olu�turdu�unuz bir vector3 ile toplay�p de�i�tiriniz.

//Soru5 - 4 adet birbirinden farkl� prefab olu�turup bu prefablar� sahneye 2 saniye aral�klarla random bir �ekilde random pozisyonlarda olu�tural�m.
//Yani 2 saniyede bir bu 4 prefabdan random bir �ekilde bir tanesi ekranda g�rebilece�imiz �ekilde random bir pozisyona spanw edilecekler. 

//Soru6 - 3.sorudaki olu�an objeler kendisini olu�turan objeye do�ru lerp ile hareket edecekler. 

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