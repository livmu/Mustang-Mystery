using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreboardShow : MonoBehaviour
{
    public GameObject Close;
    public GameObject Scoreboard;
    public GameObject ScoreboardImage;
    // Start is called before the first frame update
    void Start()
    {
        Scoreboard.gameObject.SetActive(true);
        ScoreboardImage.gameObject.SetActive(false);
        Close.gameObject.SetActive(false);
    }

    public void showScoreboard()
    {
        Scoreboard.gameObject.SetActive(false);
        Close.gameObject.SetActive(true);
        ScoreboardImage.gameObject.SetActive(true);
    }

    public void CloseScoreboard()
    {
        Scoreboard.gameObject.SetActive(true);
        ScoreboardImage.gameObject.SetActive(false);
        Close.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
