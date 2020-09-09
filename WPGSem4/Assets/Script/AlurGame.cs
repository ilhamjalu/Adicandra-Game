using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlurGame : MonoBehaviour
{
    public GameObject karakter, karina;
    public static GameObject getKarakter, getKarina;
    public static Text text3, text6, Ktext4;
    public Text txt1, txt2, txt3, txt4, txt5, txt6;
    public Text Ktxt, Ktxt2, Ktxt3, Ktxt4, Ktxt5;
    public Button btn, btnClose, karinaClose, btnKarina;
    public static Button getBtn, getBtnKarina, getBtnClose, btnKarinaNext;
    int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        getBtn = btn;
        getBtnClose = btnClose;
        getBtnKarina = karinaClose;
        btnKarinaNext = btnKarina;
        getKarakter = karakter;
        getKarina = karina;
        text3 = txt3;
        text6 = txt6;
        Ktext4 = Ktxt4;
        karakter.SetActive(true);
        txt1.gameObject.SetActive(true);
        btn.gameObject.SetActive(true);
        btnClose.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Next()
    {
        if(OnCollision.questDone == true || OnCollision.quest == false)
        {
            i++;
            Debug.Log(i);

            switch (i)
            {
                case 1:
                    Destroy(txt1.gameObject);
                    txt2.gameObject.SetActive(true);
                    btn.gameObject.SetActive(false);
                    btnClose.gameObject.SetActive(true);
                    break;
                case 2:
                    karakter.SetActive(false);
                    Destroy(txt2.gameObject);
                    break;
                case 3:
                    Destroy(txt3.gameObject);
                    Ktxt.gameObject.SetActive(true);
                    karinaClose.gameObject.SetActive(false);
                    karina.SetActive(true);
                    karakter.SetActive(false);
                    break;
                case 4:
                    Destroy(Ktxt.gameObject);
                    txt4.gameObject.SetActive(true);
                    karina.SetActive(false);
                    karakter.SetActive(true);
                    break;
                case 5:
                    Destroy(txt4.gameObject);
                    Ktxt2.gameObject.SetActive(true);
                    karina.SetActive(true);
                    karakter.SetActive(false);
                    break;
                case 6:
                    Destroy(Ktxt2.gameObject);
                    Ktxt3.gameObject.SetActive(true);
                    break;
                case 7:
                    Destroy(Ktxt3.gameObject);
                    txt5.gameObject.SetActive(true);
                    karina.SetActive(false);
                    karakter.SetActive(true);
                    btn.gameObject.SetActive(false);
                    btnClose.gameObject.SetActive(true);
                    break;
                case 8:
                    Destroy(txt5.gameObject);
                    karina.SetActive(false);
                    karakter.SetActive(false);
                    OnCollision.quest = true;
                    OnCollision.playerStop = false;
                    break;
                case 9:
                    Destroy(txt6.gameObject);
                    karina.SetActive(true);
                    btnKarina.gameObject.SetActive(false);
                    karinaClose.gameObject.SetActive(true);
                    Ktxt5.gameObject.SetActive(true);
                    karakter.SetActive(false);
                    break;
                case 10:
                    Destroy(Ktxt5.gameObject);
                    karina.SetActive(false);
                    OnCollision.questDone = false;
                    OnCollision.itemCheck = 0;
                    OnCollision.takeItem = false;
                    OnCollision.quest = false;
                    Initiate.Fade("City", Color.black, 1.0f);
                    break;
            }
        }
        else if(OnCollision.quest == true)
        {
            OnCollision.playerStop = false;
            Ktxt4.gameObject.SetActive(false);
            karina.SetActive(false);
        }
    }
}
