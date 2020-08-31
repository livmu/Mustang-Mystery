using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentManagerScript : MonoBehaviour
{
    public static PersistentManagerScript instance { get; private set; }
    public int valueSuspect;
    public int valueMurderer;
    public int valueDeception;
    public int valuePartner;
    public string partnerName;
    public int valuePartnerDeception;
    public string partnerNameDeception;
    public string hairColorMurderer;
    public string hairColorDeception;
    public string murdererName;
    public string deceptionName;
    public bool win;
    public int veronica = 1;
    public int olivia = 1;
    public int navya = 1;
    public int cindy = 1;
    public int oumsri = 1;
    private void Awake()
    {
        win = false;

        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } else
        {
            Destroy(gameObject);
        }

        //assign random murderer number
        valueMurderer = Random.Range(1, 5);
        switch (valueMurderer)
        {
            case 1:
                murdererName = "Cindy";
                hairColorMurderer = "brown";
                hairColorDeception = "blonde";
                break;
            case 2:
                murdererName = "Olivia";
                hairColorMurderer = "blonde";
                hairColorDeception = "brown";
                break;
            case 3:
                murdererName = "Veronica";
                hairColorMurderer = "black";
                hairColorDeception = "blonde";
                break;
            case 4:
                murdererName = "Navya";
                hairColorMurderer = "blonde";
                hairColorDeception = "black";
                break;
            case 5:
                murdererName = "Oumsri";
                hairColorMurderer = "black";
                hairColorDeception = "brown";
                break;
        }
        //assign random number that is not murderer
        valueDeception = Random.Range(1, 5);
        while(valueDeception == valueMurderer)
        {
            valueDeception = Random.Range(1, 5);

        }

        switch (valueDeception)
        {
            case 1:
                deceptionName = "Cindy";
                break;
            case 2:
                deceptionName = "Olivia";
                break;
            case 3:
                deceptionName = "Veronica";
                break;
            case 4:
                deceptionName = "Navya";
                break;
            case 5:
                deceptionName = "Oumsri";
                break;
        }

        // question 2
        valuePartner = Random.Range(1, 5);
        while (valuePartner == valueMurderer || valuePartner == valueSuspect)
        {
            valuePartner = Random.Range(1, 5);

        }

        switch (valuePartner)
        {
            case 1:
                callMyself();
                partnerName = "Cindy";
                break;
            case 2:
                callMyself();
                partnerName = "Olivia";
                break;
            case 3:
                callMyself();
                partnerName = "Veronica";
                break;
            case 4:
                callMyself();
                partnerName = "Navya";
                break;
            case 5:
                callMyself();
                partnerName = "Oumsri";
                break;
        }

        void callMyself()
        {
           // if (valuePartner == valueSuspect)
           // {
             //   valuePartner = valueSuspect;
           // }
        }


        // deception question 2
        valuePartnerDeception = Random.Range(1, 5);
        while (valuePartnerDeception == valueSuspect)
        {
            valuePartnerDeception = Random.Range(1, 5);

        }

        switch (valuePartnerDeception)
        {
            case 1:
                partnerNameDeception = "Cindy";
                break;
            case 2:
                partnerNameDeception = "Olivia";
                break;
            case 3:
                partnerNameDeception = "Veronica";
                break;
            case 4:
                partnerNameDeception = "Navya";
                break;
            case 5:
                partnerNameDeception = "Oumsri";
                break;
        }


    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
