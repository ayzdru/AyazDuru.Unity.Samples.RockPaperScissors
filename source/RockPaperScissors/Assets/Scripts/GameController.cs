using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class GameController : MonoBehaviour
{
    public TextMeshProUGUI resultText;
    public GameObject rock, paper, scissors;
    private int playerChoice;
    private int computerChoice;
    private string[] texts = new string[3] { "TAÞ", "KAÐIT", "MAKAS" }; 
    void Start()
    {
        resultText.text = "SEÇÝMÝNÝ YAP!";
    }
    public void PlayerChoice(int choice)
    {
        playerChoice = choice;
        ComputerChoice();
        CheckResult();
    }

    void ComputerChoice()
    {
        computerChoice = Random.Range(0, 3);
    }

    void CheckResult()
    {
        if (playerChoice == computerChoice)
        {
            resultText.text = "BERABERE!\n" + texts[playerChoice] + "-" + texts[computerChoice];
        }
        else if ((playerChoice == 0 && computerChoice == 2) ||
                 (playerChoice == 1 && computerChoice == 0) ||
                 (playerChoice == 2 && computerChoice == 1))
        {
            resultText.text = "KAZANDIN!\n" + texts[playerChoice] + "-" + texts[computerChoice];
        }
        else
        {
            resultText.text = "KAYBETTÝN!\n" + texts[playerChoice] + "-" + texts[computerChoice];
        }
    }
}
