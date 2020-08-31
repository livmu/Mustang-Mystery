using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapShow : MonoBehaviour
{
    public GameObject Close;
    public GameObject Map;
    public GameObject MapImage;

    public GameObject Other;
    public GameObject Other2;
    // Start is called before the first frame update
    void Start()
    {
        Map.gameObject.SetActive(true);
        MapImage.gameObject.SetActive(false);
        Close.gameObject.SetActive(false);
        // Close2.gameObject.SetActive(false);

        Other.gameObject.SetActive(true);
        Other2.gameObject.SetActive(true);
    }

    public void showMap()
    {
        Map.gameObject.SetActive(false);
        Close.gameObject.SetActive(true);
        MapImage.gameObject.SetActive(true);

        Other.gameObject.SetActive(false);
        Other2.gameObject.SetActive(false);
    }

    public void CloseMap()
    {
        Map.gameObject.SetActive(true);
        MapImage.gameObject.SetActive(false);
        Close.gameObject.SetActive(false);

        Other.gameObject.SetActive(true);
        Other2.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
