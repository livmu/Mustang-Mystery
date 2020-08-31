using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueTextTrivia : MonoBehaviour
{
    //***Programmed by Veronica Fula

    //public int index
    public string sceneToLoad;//taken from "triviaCorrect" scene
    public string sceneToLoadWin;
    public string sceneToLoadLose;

    //Link the text boxes
    public Text DialogueTextBox = null;
    public Text NameTextBox = null;

    private int CharacterNumberToBeInterrogated = 0;

    //Interrogation buttons
    public GameObject ButtonQuestion1;
    public GameObject ButtonQuestion2;
    public GameObject ButtonQuestion3;

    //public GameObject Map;

    public GameObject ButtonInterrogateSuspect;
    public GameObject AccuseMurderer;

    public GameObject CloseInterrogation;

    //Characters
    public GameObject SuspectImage1;
    public GameObject SuspectImage2;
    public GameObject SuspectImage3;
    public GameObject SuspectImage4;
    public GameObject SuspectImage5;


    //Detective Content
    public string DetectiveQuestion1 = "Detective Question 1";
    public string DetectiveQuestion2 = "Detective Question 2";
    public string DetectiveQuestion3 = "Detective Question 3";

    //Names of the suspects
     static string SuspectName1 = "Cindy";
     static string SuspectName2 = "Olivia";
     static string SuspectName3 = "Veronica";
     static string SuspectName4 = "Navya";
     static string SuspectName5 = "Oumsri";

    //Hair color of suspects
    string hairColorSuspect1 = "brown";
    string hairColorSuspect2 = "blonde";
    string hairColorSuspect3 = "black";
    string hairColorSuspect4 = "blonde";
    string hairColorSuspect5 = "black";


    //Intro Suspect Content
     string Suspect1_Intro = "Hi. When are we getting out of here? You gonna do some detective stuff on me? ";
     string Suspect2_Intro = "Hello, how can I help you? Need some aromas to help calm down?";
     string Suspect3_Intro = "I'm Veronica. You look like you need something. Is the CIA involved in this?";
     string Suspect4_Intro = "Um, hi. Do you need help?";
     string Suspect5_Intro = "Hey! What's up? My bats are going to be starving.";

    //Innocent Suspect Content
     string Suspect1_Answer1 = "I found some " + PersistentManagerScript.instance.hairColorMurderer + " hair on the floor.";//Inocent Suspect1 answer to Q1
     string Suspect1_Answer2 = "Well, I was with " + PersistentManagerScript.instance.partnerName + " at the time.";//Inocent Suspect1 answer to Q2
     string Suspect1_Answer3 = "No, not really, but I know " + PersistentManagerScript.instance.murdererName + " was pretty close to Suhani.";//Inocent Suspect1 answer to Q3

     string Suspect2_Answer1 = "I was spraying some perfume to lighten the mood and saw some " + PersistentManagerScript.instance.hairColorMurderer + " hair on the floor.";
     string Suspect2_Answer2 = "Well, I was with " + PersistentManagerScript.instance.partnerName + " at the time.";
     string Suspect2_Answer3 = "Not really, but I know " + PersistentManagerScript.instance.murdererName + " was pretty close to Suhani.";

     string Suspect3_Answer1 = "You know, it's weird 'cause I found some " + PersistentManagerScript.instance.hairColorMurderer + " hair on the floor.";
     string Suspect3_Answer2 = "I was with " + PersistentManagerScript.instance.partnerName + " at the time.";
     string Suspect3_Answer3 = "Eh, not really, but I know " + PersistentManagerScript.instance.murdererName + " was pretty close to Suhani.";

    string Suspect4_Answer1 = "I found some " + PersistentManagerScript.instance.hairColorMurderer + " hair on the floor.";
    string Suspect4_Answer2 = "Well, I was with " + PersistentManagerScript.instance.partnerName + " at the time.";
    string Suspect4_Answer3 = "No, but I know " + PersistentManagerScript.instance.murdererName + " was pretty close to Suhani.";

    string Suspect5_Answer1 = "Well, I did find some " + PersistentManagerScript.instance.hairColorMurderer + " hair on the floor.";
    string Suspect5_Answer2 = "Well, I was with " + PersistentManagerScript.instance.partnerName + " at the time.";
    string Suspect5_Answer3 = "Not really, but I know " + PersistentManagerScript.instance.murdererName + " was pretty close to Suhani.";


    //Murderer answers
    string Murderer1_Answer1 = "I found some " + PersistentManagerScript.instance.hairColorDeception + " hair on the floor.";//Murderer Suspect1 answer to Q1
    string Murderer1_Answer2 = "Well, I was with " + PersistentManagerScript.instance.partnerNameDeception + " at the time.";//Murderer Suspect1 answer to Q2
    string Murderer1_Answer3 = "No, not really, but I know " + PersistentManagerScript.instance.deceptionName + " was pretty close to Suhani.";//Murderer Suspect1 answer to Q3

    string Murderer2_Answer1 = "I was spraying some perfume to lighten the mood and saw some " + PersistentManagerScript.instance.hairColorDeception + " murderer hair color hair on the floor.";
    string Murderer2_Answer2 = "Well, I was with " + PersistentManagerScript.instance.partnerNameDeception + " at the time.";
    string Murderer2_Answer3 = "Not really, but I know " + PersistentManagerScript.instance.deceptionName + " was pretty close to Suhani.";

    string Murderer3_Answer1 = "You know, it's weird 'cause I found some " + PersistentManagerScript.instance.hairColorDeception + " hair on the floor.";
    string Murderer3_Answer2 = "I was with " + PersistentManagerScript.instance.partnerNameDeception + " at the time.";
    string Murderer3_Answer3 = "Eh, not really, but I know " + PersistentManagerScript.instance.deceptionName + " was pretty close to Suhani.";

    string Murderer4_Answer1 = "I found some " + PersistentManagerScript.instance.hairColorDeception + " hair on the floor.";
    string Murderer4_Answer2 = "Well, I was with " + PersistentManagerScript.instance.partnerNameDeception + " at the time.";
    string Murderer4_Answer3 = "No, but I know " + PersistentManagerScript.instance.deceptionName + " was pretty close to Suhani.";

    string Murderer5_Answer1 = "Well, I did find some " + PersistentManagerScript.instance.hairColorDeception + " hair on the floor.";
    string Murderer5_Answer2 = "Well, I was with " + PersistentManagerScript.instance.partnerNameDeception + " at the time.";
    string Murderer5_Answer3 = "Not really, but I know " + PersistentManagerScript.instance.deceptionName + " was pretty close to Suhani.";


    //Repeated Responses
    string Suspect1_Refuse = "I already answered your question. That's all I know.";//Inocent Suspect1 answer to Q1
    string Suspect2_Refuse = "I already answered your question. That's all I know.";//Inocent Suspect1 answer to Q2
    string Suspect3_Refuse = "I already answered your question. That's all I know.";//Inocent Suspect1 answer to Q3
    string Suspect4_Refuse = "I already answered your question. That's all I know.";
    string Suspect5_Refuse = "I already answered your question. That's all I know.";

    //Assigning temporary murderer for testing purposes
    public static bool murderer = false;

    private int murdererAssigned;


    // Start is called before the first frame update
    void Start()
    {
        //Map.gameObject.SetActive(false);
        //CharacterNumberToBeInterrogated = Random.Range(1, 5); //for now we picked it randomly 
        //Debug.Log(" RANDOM CHARACTER " + CharacterNumberToBeInterrogated);

        DialogueTextBox.text = Suspect1_Intro;
        DialogueTextBox.text = Suspect2_Intro;
        DialogueTextBox.text = Suspect3_Intro;
        DialogueTextBox.text = Suspect4_Intro;
        DialogueTextBox.text = Suspect5_Intro;

        CharacterNumberToBeInterrogated = PersistentManagerScript.instance.valueSuspect;
        murdererAssigned = PersistentManagerScript.instance.valueMurderer;

        if (CharacterNumberToBeInterrogated == murdererAssigned)
        {
            murderer = true;
            Debug.Log("MURDERER is CH " + CharacterNumberToBeInterrogated);
        }
        else
        {
            murderer = false;
        }

        MakeSuspectInvisible();
        //selectRandomSuspect();
        passCharacterVariable();
        IntroUIVisible();


        //suspectWeTalkedAlready = GameObject.Find("SceneTransition").GetComponent<SceneTransition>();


        weAlredyTalked();

        //DialogueTextBox.text = Suspect1_Intro;
        //NameTextBox.text = SuspectName1;

    }



    void weAlredyTalked()
    {
        if (PersistentManagerScript.instance.cindy == 0 && PersistentManagerScript.instance.valueSuspect == 1)
        {
            repeatAnswer();
            CloseUIVisible();
        } else if (PersistentManagerScript.instance.olivia == 0 && PersistentManagerScript.instance.valueSuspect == 2) {
            repeatAnswer();
            CloseUIVisible();

        }
        else if (PersistentManagerScript.instance.veronica == 0 && PersistentManagerScript.instance.valueSuspect == 3)
        {
            repeatAnswer();
            CloseUIVisible();

        }
        else if (PersistentManagerScript.instance.navya == 0 && PersistentManagerScript.instance.valueSuspect == 4)
        {
            repeatAnswer();
            CloseUIVisible();

        }
        else if (PersistentManagerScript.instance.oumsri == 0 && PersistentManagerScript.instance.valueSuspect == 5)
        {
            repeatAnswer();
            CloseUIVisible();

        }
        else
        {
            IntroUIVisible();
        }

    }



    //Function to make suspect invisible at the start
    void MakeSuspectInvisible()
    {
        SuspectImage1.GetComponent<Renderer>().enabled = false;
        SuspectImage2.GetComponent<Renderer>().enabled = false;
        SuspectImage3.GetComponent<Renderer>().enabled = false;
        SuspectImage4.GetComponent<Renderer>().enabled = false;
        SuspectImage5.GetComponent<Renderer>().enabled = false;

    }


    //Function to pass the character number from ROOM to TRIVIA-INTERROGATION
    void passCharacterVariable()
    {
        //if(CharacterNumberToBeInterrogated > 0 )
        //{
        //CharacterNumberToBeInterrogated = Random.Range(1, 6); //for now we picked it randomly 
        //Debug.Log(" RANDOM CHARACTER " + CharacterNumberToBeInterrogated);
        //}
        switch (CharacterNumberToBeInterrogated)
        {
            case 1:
                //if (!SceneTransition.instance.cindy || !SceneTransition.instance.olivia || !SceneTransition.instance.veronica || !SceneTransition.instance.navya || !SceneTransition.instance.oumsri)
                //{
                 //     repeatAnswer();
                //} else
                //{
                //    DialogueTextBox.text = Suspect1_Intro;
                //}
                    SuspectImage1.GetComponent<Renderer>().enabled = true;
                NameTextBox.text = SuspectName1;
                //DialogueTextBox.text = Suspect1_Intro;
                break;
            case 2:
                //if (!SceneTransition.instance.cindy || !SceneTransition.instance.olivia || !SceneTransition.instance.veronica || !SceneTransition.instance.navya || !SceneTransition.instance.oumsri)
                //{
                 //   repeatAnswer();
                //}
                //else
                //{
                    DialogueTextBox.text = Suspect2_Intro;
                //}
                SuspectImage2.GetComponent<Renderer>().enabled = true;
                NameTextBox.text = SuspectName2;
                //DialogueTextBox.text = Suspect2_Intro;
                break;
            case 3:
                //if (!SceneTransition.instance.cindy || !SceneTransition.instance.olivia || !SceneTransition.instance.veronica || !SceneTransition.instance.navya || !SceneTransition.instance.oumsri)
                //{
                //    repeatAnswer();
                //}
                //else
                //{
                    DialogueTextBox.text = Suspect3_Intro;
                //}
                SuspectImage3.GetComponent<Renderer>().enabled = true;
                NameTextBox.text = SuspectName3;
                //DialogueTextBox.text = Suspect3_Intro;
                break;
            case 4:
                //if (!SceneTransition.instance.cindy || !SceneTransition.instance.olivia || !SceneTransition.instance.veronica || !SceneTransition.instance.navya || !SceneTransition.instance.oumsri)
                //{
                //    repeatAnswer();
                //}
                //else
                //{
                    DialogueTextBox.text = Suspect4_Intro;
                //}
                SuspectImage4.GetComponent<Renderer>().enabled = true;
                NameTextBox.text = SuspectName4;
                //DialogueTextBox.text = Suspect4_Intro;
                break;
            case 5:
                //if (!SceneTransition.instance.cindy || !SceneTransition.instance.olivia || !SceneTransition.instance.veronica || !SceneTransition.instance.navya || !SceneTransition.instance.oumsri)
                //{
                //    repeatAnswer();
                //}
                //else
                //{
                    DialogueTextBox.text = Suspect5_Intro;
                //}
                SuspectImage5.GetComponent<Renderer>().enabled = true;
                NameTextBox.text = SuspectName5;
                //DialogueTextBox.text = Suspect5_Intro;
                break;
        }

    }

    //Function to pick a random character to be interrogated
    void selectRandomSuspect()
    {
        //CharacterNumberToBeInterrogated = Random.Range(1, 5);

    }

    //This function is to assign randomly at the start of the game which suspect is going to be the murder
    void SelectMurderRandomly()
    {

    }

    //INTRO elements on the screen visible
    public void IntroUIVisible()
    {
        //Map.gameObject.SetActive(false);
        ButtonQuestion1.gameObject.SetActive(false);
        ButtonQuestion2.gameObject.SetActive(false);
        ButtonQuestion3.gameObject.SetActive(false);

        AccuseMurderer.gameObject.SetActive(false);

        DialogueTextBox.gameObject.SetActive(true);
        NameTextBox.gameObject.SetActive(true);
        ButtonInterrogateSuspect.gameObject.SetActive(true);

        CloseInterrogation.gameObject.SetActive(false);
        AccuseMurderer.gameObject.SetActive(true);
    }

    public void IntroWhenAlreadyAskedUIVisible()
    {
        //Map.gameObject.SetActive(false);
        ButtonQuestion1.gameObject.SetActive(false);
        ButtonQuestion2.gameObject.SetActive(false);
        ButtonQuestion3.gameObject.SetActive(false);

        AccuseMurderer.gameObject.SetActive(false);

        DialogueTextBox.gameObject.SetActive(true);
        NameTextBox.gameObject.SetActive(true);
        ButtonInterrogateSuspect.gameObject.SetActive(false);

        CloseInterrogation.gameObject.SetActive(true);
    }

    //Show only dialogue and close button
    public void CloseUIVisible()
    {
        //Map.gameObject.SetActive(false);
        ButtonQuestion1.gameObject.SetActive(false);
        ButtonQuestion2.gameObject.SetActive(false);
        ButtonQuestion3.gameObject.SetActive(false);

        AccuseMurderer.gameObject.SetActive(true);

        DialogueTextBox.gameObject.SetActive(true);
        NameTextBox.gameObject.SetActive(true);
        ButtonInterrogateSuspect.gameObject.SetActive(false);
        CloseInterrogation.gameObject.SetActive(true);


    }

    //INTERROGATION elements visible
    public void InterrogationUIVisible()
    {
        //Map.gameObject.SetActive(false);
        ButtonQuestion1.gameObject.SetActive(true);
        ButtonQuestion2.gameObject.SetActive(true);
        ButtonQuestion3.gameObject.SetActive(true);

        AccuseMurderer.gameObject.SetActive(false);

        DialogueTextBox.gameObject.SetActive(false);
        NameTextBox.gameObject.SetActive(false);
        ButtonInterrogateSuspect.gameObject.SetActive(false);
        CloseInterrogation.gameObject.SetActive(false);
    }

    public void showSuspectAnswerButton1()
    {
        CloseUIVisible();
        suspectAnswerDialogueButton1();
    }
    public void showSuspectAnswerButton2()
    {
        CloseUIVisible();
        suspectAnswerDialogueButton2();
    }
    public void showSuspectAnswerButton3()
    {
        CloseUIVisible();
        suspectAnswerDialogueButton3();
    }

    public void closeInterrogationScene()
    {
        switch (PersistentManagerScript.instance.valueSuspect)
        {
            case 1:
                PersistentManagerScript.instance.cindy = 0;
                PersistentManagerScript.instance.olivia = 1;
                PersistentManagerScript.instance.veronica = 1;
                PersistentManagerScript.instance.navya = 1;
                PersistentManagerScript.instance.oumsri = 1; 
                break;
            case 2:
                PersistentManagerScript.instance.olivia = 0;
                PersistentManagerScript.instance.cindy = 1;
                PersistentManagerScript.instance.veronica = 1;
                PersistentManagerScript.instance.navya = 1;
                PersistentManagerScript.instance.oumsri = 1;
                break;
            case 3:
                PersistentManagerScript.instance.veronica = 0;
                PersistentManagerScript.instance.olivia = 1;
                PersistentManagerScript.instance.cindy = 1;
                PersistentManagerScript.instance.navya = 1;
                PersistentManagerScript.instance.oumsri = 1;
                break;
            case 4:
                PersistentManagerScript.instance.navya = 0;
                PersistentManagerScript.instance.olivia = 1;
                PersistentManagerScript.instance.veronica = 1;
                PersistentManagerScript.instance.cindy = 1;
                PersistentManagerScript.instance.oumsri = 1;
                break;
            case 5:
                PersistentManagerScript.instance.oumsri = 0;
                PersistentManagerScript.instance.olivia = 1;
                PersistentManagerScript.instance.veronica = 1;
                PersistentManagerScript.instance.navya = 1;
                PersistentManagerScript.instance.cindy = 1;
                break;
        }
        SceneManager.LoadScene(sceneToLoad);
       

    }

    void suspectAnswerDialogueButton1()
    {

        
        switch (CharacterNumberToBeInterrogated)
        {
            case 1:
                //SuspectImage1.GetComponent<Renderer>().enabled = true;
                // NameTextBox.text = SuspectName1;
                Debug.Log("CH1 + ANS1");
                if (murderer)
                {
                    DialogueTextBox.text = Murderer1_Answer1;
                   
                } else
                {
                    DialogueTextBox.text = Suspect1_Answer1;
                }
                
                break;
            case 2:
                // SuspectImage2.GetComponent<Renderer>().enabled = true;
                //NameTextBox.text = SuspectName2;
                Debug.Log("CH2 + ANS1");
                if (murderer == true)
                {
                    DialogueTextBox.text = Murderer2_Answer1;
                    Debug.Log("CH2 + ANS1 MURDERER");
                } else
                {
                    DialogueTextBox.text = Suspect2_Answer1;

                }

                break;
            case 3:
                //SuspectImage3.GetComponent<Renderer>().enabled = true;
                // NameTextBox.text = SuspectName3;
                Debug.Log("CH3 + ANS1");
                if (murderer == true)
                {
                    DialogueTextBox.text = Murderer3_Answer1;
                } else
                {
                    DialogueTextBox.text = Suspect3_Answer1;
                }
                
                break;
            case 4:
                //SuspectImage4.GetComponent<Renderer>().enabled = true;
                //NameTextBox.text = SuspectName4;
                Debug.Log("CH4 + ANS1");
                if (murderer == true)
                {
                    DialogueTextBox.text = Murderer4_Answer1;
                } else
                {
                    DialogueTextBox.text = Suspect4_Answer1;
                }
                
                break;
            case 5:
                //SuspectImage5.GetComponent<Renderer>().enabled = true;
                //NameTextBox.text = SuspectName5;
                Debug.Log("CH5 + ANS1");
                if (murderer == true)
                {
                    DialogueTextBox.text = Murderer5_Answer1;
                } else
                {
                    DialogueTextBox.text = Suspect5_Answer1;
                }
                
                break;
        }

    }

    void suspectAnswerDialogueButton2()
    {


        switch (CharacterNumberToBeInterrogated)
        {
            case 1:
                //SuspectImage1.GetComponent<Renderer>().enabled = true;
                // NameTextBox.text = SuspectName1;
                Debug.Log("CH1 + ANS2");
                if (murderer == true)
                {
                    DialogueTextBox.text = Murderer1_Answer2;

                } else
                {
                    DialogueTextBox.text = Suspect1_Answer2;
                }
                
                
                break;
            case 2:
                // SuspectImage2.GetComponent<Renderer>().enabled = true;
                //NameTextBox.text = SuspectName2;
                Debug.Log("CH2 + ANS2");
                if (murderer == true)
                {
                    DialogueTextBox.text = Murderer2_Answer2;
                } else
                {
                    DialogueTextBox.text = Suspect2_Answer2;
                }
                
                break;
            case 3:
                //SuspectImage3.GetComponent<Renderer>().enabled = true;
                // NameTextBox.text = SuspectName3;
                Debug.Log("CH3 + ANS2");
                if (murderer == true)
                {
                    DialogueTextBox.text = Murderer3_Answer2;
                } else
                {
                    DialogueTextBox.text = Suspect3_Answer2;
                }
                
                break;
            case 4:
                //SuspectImage4.GetComponent<Renderer>().enabled = true;
                //NameTextBox.text = SuspectName4;
                Debug.Log("CH4 + ANS2");
                if (murderer == true)
                {
                    DialogueTextBox.text = Murderer4_Answer2;
                } else
                {
                    DialogueTextBox.text = Suspect4_Answer2;
                }
                
                break;
            case 5:
                //SuspectImage5.GetComponent<Renderer>().enabled = true;
                //NameTextBox.text = SuspectName5;
                Debug.Log("CH5 + ANS2");
                if (murderer == true)
                {
                    DialogueTextBox.text = Murderer5_Answer2;
                } else
                {
                    DialogueTextBox.text = Suspect5_Answer2;
                }
                
                break;
        }

    }

    void suspectAnswerDialogueButton3()
    {


        switch (CharacterNumberToBeInterrogated)
        {
            case 1:
                //SuspectImage1.GetComponent<Renderer>().enabled = true;
                // NameTextBox.text = SuspectName1;
                Debug.Log("CH1 + ANS3");
                if (murderer == true)
                {
                    DialogueTextBox.text = Murderer1_Answer3;
                }
                else
                {
                    DialogueTextBox.text = Suspect1_Answer3;
                }
                break;
            case 2:
                // SuspectImage2.GetComponent<Renderer>().enabled = true;
                //NameTextBox.text = SuspectName2;
                Debug.Log("CH2 + ANS3");
                if (murderer == true)
                {
                    DialogueTextBox.text = Murderer1_Answer3;
                }
                else
                {
                    DialogueTextBox.text = Suspect1_Answer3;
                }
                break;
            case 3:
                //SuspectImage3.GetComponent<Renderer>().enabled = true;
                // NameTextBox.text = SuspectName3;
                Debug.Log("CH3 + ANS3");
                if (murderer == true)
                {
                    DialogueTextBox.text = Murderer1_Answer3;
                }
                else
                {
                    DialogueTextBox.text = Suspect1_Answer3;
                }
                break;
            case 4:
                //SuspectImage4.GetComponent<Renderer>().enabled = true;
                //NameTextBox.text = SuspectName4;
                Debug.Log("CH4 + ANS3");
                if (murderer == true)
                {
                    DialogueTextBox.text = Murderer1_Answer3;
                }
                else
                {
                    DialogueTextBox.text = Suspect1_Answer3;
                }
                break;
            case 5:
                //SuspectImage5.GetComponent<Renderer>().enabled = true;
                //NameTextBox.text = SuspectName5;
                Debug.Log("CH5 + ANS3");
                if (murderer == true)
                {
                    DialogueTextBox.text = Murderer1_Answer3;
                }
                else
                {
                    DialogueTextBox.text = Suspect1_Answer3;
                }
                break;
        }

    }

    public void accuseMurderer()
    {
        if (CharacterNumberToBeInterrogated == murdererAssigned)
        {
            SceneManager.LoadScene(sceneToLoadWin);
        }
        else
        {
            SceneManager.LoadScene(sceneToLoadLose);
        }
    }

    void  repeatAnswer()
    {

        //IntroWhenAlreadyAskedUIVisible();

        switch (CharacterNumberToBeInterrogated)
        {
            case 1:
                    DialogueTextBox.text = Suspect1_Refuse;
                break;
            case 2:
                    DialogueTextBox.text = Suspect2_Refuse;
                break;
            case 3:

                
                    DialogueTextBox.text = Suspect3_Refuse;
                
                break;
            case 4:

                    DialogueTextBox.text = Suspect4_Refuse;
                
                break;
            case 5:

                    DialogueTextBox.text = Suspect5_Refuse;
                
                break;
        }
    }

}