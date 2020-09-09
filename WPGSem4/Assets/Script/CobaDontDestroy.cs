using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CobaDontDestroy : MonoBehaviour
{
    public GameObject player;
    bool sekali = false;
    int max = 0;
    // Start is called before the first frame update
    void Start()
    {
        //if(OnCollision.pindah == true || sekali == false)
        //{
        //sekali = true;
        //GameObject a = Instantiate(player, new Vector3(5, 24, 0), Quaternion.identity);
        //DontDestroyOnLoad(player);
        //max += 1;
        //Debug.Log(max);
        //Check();
        //}     
    }

    void Check()
    {
        
        if (max == 1)
        {
            Debug.Log("masuk");
            Destroy(GameObject.Find("player"));
        }
    }

    // Update is called once per frame
    void Update()
    {
       
        //Debug.Log(sekali);
        //if (sekali == false)
        //{
            
        //    sekali = true;
        //    Debug.Log(sekali);
        //}
        
    }
}
