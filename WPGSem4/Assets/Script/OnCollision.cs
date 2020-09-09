using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnCollision : MonoBehaviour
{
    public GameObject itemQuest;
    public float jarak = 2f;
    BoxCollider2D pemain;
    RaycastHit2D hit;
    public Text itemGets;
    public Animator anim;
    public static bool takeItem = false; // setelah button count 8
    public static bool quest = false; // quest start
    public static bool playerStop = false; // player freeze
    public static bool questDone = false;
    public static int itemCheck = 0;


    // Start is called before the first frame update
    void Start()
    {
        pemain = GetComponent<BoxCollider2D>();
        Debug.Log(takeItem);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Npc"))
        {
            if(takeItem == true)
            {
                questDone = true;
                Debug.Log("QUEST DONE");
                Debug.Log(quest);
                AlurGame.getKarakter.gameObject.SetActive(true);
                AlurGame.text6.gameObject.SetActive(true);
                AlurGame.getBtnClose.gameObject.SetActive(false);
                AlurGame.getBtn.gameObject.SetActive(true);
            }
            if(quest == false)
            {
                playerStop = true;
                AlurGame.getKarakter.gameObject.SetActive(true);
                AlurGame.text3.gameObject.SetActive(true);
                AlurGame.getBtnClose.gameObject.SetActive(false);
                AlurGame.getBtn.gameObject.SetActive(true);
                Debug.Log("NATAP LUR");
                itemQuest.SetActive(true);

            }
            else if (quest == true && takeItem == false)
            {
                playerStop = true;
                AlurGame.getKarina.gameObject.SetActive(true);
                AlurGame.Ktext4.gameObject.SetActive(true);
                AlurGame.getBtnKarina.gameObject.SetActive(true);
                AlurGame.btnKarinaNext.gameObject.SetActive(false);
            }
        }

        if (collision.gameObject.CompareTag("item"))
        {
            itemCheck++;
            Debug.Log("ITEM YANG TERKUMPUL");
            Debug.Log(itemCheck);
            itemGets.text = "Item : " + itemCheck.ToString();
            Destroy(collision.gameObject);
            if(itemCheck == 5)
            {
                takeItem = true;
                Debug.Log(takeItem);
                if(AlurGame2.cekKebun == true)
                {
                    Initiate.Fade("City", Color.black, 1.0f);
                    quest = true;
                }
            } 
        }

        if (collision.gameObject.CompareTag("guru"))
        {
            if (quest == false)
            {
                playerStop = true;
                AlurGame2.staKa.gameObject.SetActive(true);
                AlurGame2.staBtnClose.gameObject.SetActive(false);
                AlurGame2.sTmc4.gameObject.SetActive(true);
            }

            if (takeItem == true)
            {
                questDone = true;
                Debug.Log("QUEST DONE");
                Debug.Log(quest);
            }

            if(questDone == true)
            {
                playerStop = true;
                AlurGame2.sTgur4.gameObject.SetActive(true);
                AlurGame2.stagu.gameObject.SetActive(true);
                AlurGame2.staClose.gameObject.SetActive(false);
            }
        }
    }
}
