using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlurGame2 : MonoBehaviour
{
    public Text tmc, tmc2, tmc3, tmc4, tmc5, tmc6, tmc7, tmc8;
    public Text tka, tka2;
    public Text tgur, tgur2, tgur3, tgur4;
    public Text gul1, gul2;
    public GameObject karakter, guru, karina, gulungan;
    public Button btn, btnClose, karinaClose, btnKarina, btnGur, btnGurclo, gulNext, gulClose;
    public static GameObject staKa, stagu;
    public static Text sTmc4, sTgur4;
    public static Button staBtn, staBtnClose, staKarina, staClose;
    int i = 0;
    public static bool cekKebun = false;

    // Start is called before the first frame update
    void Start()
    {
        staKa = karakter;
        stagu = guru;
        sTmc4 = tmc4;
        sTgur4 = tgur4;
        staBtn = btn;
        staBtnClose = btnClose;
        staKarina = karinaClose;
        staClose = btnGur;

        if(cekKebun == false)
        {
            OnCollision.playerStop = true;
            karakter.SetActive(true);
            tmc.gameObject.SetActive(true);
            btn.gameObject.SetActive(true);
            btnClose.gameObject.SetActive(false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void Next()
    {
        if(OnCollision.questDone == false)
        {
            i++;
            Debug.Log(i);
            switch (i)
            {
                case 1:
                    karakter.SetActive(false);
                    Destroy(tmc.gameObject);
                    karina.SetActive(true);
                    tka.gameObject.SetActive(true);
                    karinaClose.gameObject.SetActive(false);
                    break;
                case 2:
                    karakter.SetActive(true);
                    Destroy(tka.gameObject);
                    karina.SetActive(false);
                    tmc2.gameObject.SetActive(true);
                    btnClose.gameObject.SetActive(false);
                    break;
                case 3:
                    karakter.SetActive(false);
                    Destroy(tmc2.gameObject);
                    karina.SetActive(true);
                    tka2.gameObject.SetActive(true);
                    karinaClose.gameObject.SetActive(false);
                    break;
                case 4:
                    karakter.SetActive(true);
                    Destroy(tka2.gameObject);
                    karina.SetActive(false);
                    tmc3.gameObject.SetActive(true);
                    btnClose.gameObject.SetActive(true);
                    break;
                case 5:
                    OnCollision.playerStop = false;
                    Destroy(tmc3.gameObject);
                    karakter.SetActive(false);
                    karina.SetActive(false);
                    break;
                case 6:
                    karakter.SetActive(false);
                    Destroy(tmc4.gameObject);
                    guru.SetActive(true);
                    tgur.gameObject.SetActive(true);
                    btnGurclo.gameObject.SetActive(false);
                    break;
                case 7:
                    karakter.SetActive(true);
                    Destroy(tgur.gameObject);
                    guru.SetActive(false);
                    tmc5.gameObject.SetActive(true);
                    btnClose.gameObject.SetActive(false);
                    break;
                case 8:
                    karakter.SetActive(false);
                    Destroy(tmc5.gameObject);
                    guru.SetActive(true);
                    tgur2.gameObject.SetActive(true);
                    btnGurclo.gameObject.SetActive(false);
                    break;
                case 9:
                    karakter.SetActive(true);
                    Destroy(tgur2.gameObject);
                    guru.SetActive(false);
                    tmc6.gameObject.SetActive(true);
                    btnClose.gameObject.SetActive(false);
                    break;
                case 10:
                    karakter.SetActive(false);
                    Destroy(tmc6.gameObject);
                    guru.SetActive(true);
                    tgur3.gameObject.SetActive(true);
                    btnGurclo.gameObject.SetActive(false);
                    break;
                case 11:
                    karakter.SetActive(true);
                    Destroy(tgur3.gameObject);
                    guru.SetActive(false);
                    tmc7.gameObject.SetActive(true);
                    btnClose.gameObject.SetActive(true);
                    break;
                case 12:
                    Destroy(tmc7.gameObject);
                    karakter.SetActive(false);
                    guru.SetActive(false);
                    Initiate.Fade("Kebun", Color.black, 1.0f);
                    OnCollision.playerStop = false;
                    cekKebun = true;
                    break;
            }
        }
        else
        {
            i++;

            switch (i)
            {
                case 1:
                    Destroy(tgur4.gameObject);
                    guru.SetActive(false);
                    gulungan.SetActive(true);
                    gul2.gameObject.SetActive(false);
                    gulClose.gameObject.SetActive(false);
                    break;
                case 2:
                    Destroy(gul1.gameObject);
                    gul2.gameObject.SetActive(true);
                    gulClose.gameObject.SetActive(true);
                    break;
                case 3:
                    Initiate.Fade("Gurun", Color.black, 1.0f);
                    break;
                    
            }
        }
    }
}
