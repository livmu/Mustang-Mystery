using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    //public static SceneTransition instance { get; private set; }
    public string sceneToLoad;
    /*blic int veronica;
    public int olivia;
    public int navya;
    public int cindy;
    public int oumsri;*/
    //public int index;


    void OnTriggerEnter2D(Collider2D other)
    {


        if (other.CompareTag("NPC_Veronica"))
        {
            GoldNumber.coinAmount += 100;
            
            SceneManager.LoadScene(sceneToLoad);
            PersistentManagerScript.instance.valueSuspect = 3;
           // if (veronica)
                
            
        }

        if (other.CompareTag("NPC_Olivia"))
        {
            GoldNumber.coinAmount += 100;
            //PersistentManagerScript.instance.olivia = 0;
            SceneManager.LoadScene(sceneToLoad);
            PersistentManagerScript.instance.valueSuspect = 2;
           // if (olivia)
                
            
        }

        if (other.CompareTag("NPC_Navya"))
        {
            GoldNumber.coinAmount += 100;
           // PersistentManagerScript.instance.navya = 0;
            SceneManager.LoadScene(sceneToLoad);
            PersistentManagerScript.instance.valueSuspect = 4;
          //  if (navya)
                
            
        }

        if (other.CompareTag("NPC_Cindy"))// && !other.isTrigger)
        {
            GoldNumber.coinAmount += 100;
           // PersistentManagerScript.instance.cindy = 0;
            SceneManager.LoadScene(sceneToLoad);
            PersistentManagerScript.instance.valueSuspect = 1;
           // if (cindy)
                
            
        }

        if (other.CompareTag("NPC_Oumsri"))// && !other.isTrigger)
        {
            GoldNumber.coinAmount += 100;
           // PersistentManagerScript.instance.oumsri = 0;
            SceneManager.LoadScene(sceneToLoad);
            PersistentManagerScript.instance.valueSuspect = 5;
           // if (oumsri)
                
            
        }
    }
}
