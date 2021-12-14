using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandGame : MonoBehaviour
{
    public GameObject[] buttons;
    public GameObject ObjectNewGame;
        
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject VoiceButton;

    public GameObject panel;
    private Button ButtonNewGame;
    private Button ButtonWinner;


    public int rand { get; set; }
    void OnButton()
    {
        AudioSource audio = ButtonWinner.GetComponent<AudioSource>();
        audio.Play();
        
        ObjectNewGame.SetActive(true);

    }
    void NewGame()
    {
        ObjectNewGame.SetActive(false);
        System.Random randT = new System.Random();
        List<int> randList = new List<int>();
            int randForB1 = randT.Next(0, buttons.Length);
      
        while (randList.Count != 3)
        {
            randForB1 = randT.Next(0, buttons.Length);
            if (!randList.Contains(randForB1)){
                randList.Add(randForB1);
            }
        }
        AudioSource audio = VoiceButton.GetComponent<AudioSource>();
        Destroy(button1);
        Destroy(button2);
        Destroy(button3);
       
       
        int randVal = randT.Next(0, 3);
        switch (randVal)
        {
            case 0:
                audio.clip = buttons[randList[0]].GetComponent<AudioSource>().clip;
                button1 = buttons[randList[0]];
                button2 = buttons[randList[1]];
                button3 = buttons[randList[2]];
                button1 = Instantiate<GameObject>(button1, panel.transform);
                button2 = Instantiate<GameObject>(button2, panel.transform);
                button3 = Instantiate<GameObject>(button3, panel.transform);
                ButtonWinner = button1.GetComponent<Button>();
                ButtonWinner.onClick.AddListener(OnButton);
                button2.GetComponent<Button>().onClick.AddListener(Handheld.Vibrate);
                button3.GetComponent<Button>().onClick.AddListener(Handheld.Vibrate);

                break;
            case 1:
                audio.clip = buttons[randList[1]].GetComponent<AudioSource>().clip;
                button1 = buttons[randList[0]];
                button2 = buttons[randList[1]];
                button3 = buttons[randList[2]];
                button1 = Instantiate<GameObject>(button1, panel.transform);
                button2 = Instantiate<GameObject>(button2, panel.transform);
                button3 = Instantiate<GameObject>(button3, panel.transform);
                ButtonWinner = button2.GetComponent<Button>();
                ButtonWinner.onClick.AddListener(OnButton);
                button1.GetComponent<Button>().onClick.AddListener(Handheld.Vibrate);
                button3.GetComponent<Button>().onClick.AddListener(Handheld.Vibrate);
               
                
                break;    
            case 2:
                audio.clip = buttons[randList[2]].GetComponent<AudioSource>().clip;
                button1 = buttons[randList[0]];
                button2 = buttons[randList[1]];
                button3 = buttons[randList[2]];
                button1 = Instantiate<GameObject>(button1, panel.transform);
                button2 = Instantiate<GameObject>(button2, panel.transform);
                button3 = Instantiate<GameObject>(button3, panel.transform);
                ButtonWinner = button3.GetComponent<Button>();
                ButtonWinner.onClick.AddListener(OnButton);
                button1.GetComponent<Button>().onClick.AddListener(Handheld.Vibrate);
                button2.GetComponent<Button>().onClick.AddListener(Handheld.Vibrate);
                break;
            default:
                break;
        }
       
        
    }

    void Start()
    {
        ButtonNewGame = ObjectNewGame.GetComponent<Button>();
        ButtonNewGame.onClick.AddListener(NewGame);
       
        NewGame();
    }
    void Update()
    {
    }
}
