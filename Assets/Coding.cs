using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class Coding : MonoBehaviour
{
    public TMP_InputField PlayerInput;
    public TextMeshProUGUI Result;
    public Button Rock; 
    public Button Scissors;
    public Button Paper;
    public Button restartP;
    public Button restartD;
    
    void Start()
    {
        PlayerInput.onSubmit.AddListener(pname);
        Rock.onClick.AddListener(RockP);
        Scissors.onClick.AddListener(ScissorsP);
        Paper.onClick.AddListener(PaperP);
        restartP.onClick.AddListener(restartSP);
        restartD.onClick.AddListener(restartDP);
    }

    public void pname(string t)
    {
        PlayerInput.gameObject.SetActive(true);
        Rock.gameObject.SetActive(true);
        Paper.gameObject.SetActive(true);
        Scissors.gameObject.SetActive(true);
        Result.gameObject.SetActive(true);
    }
    void RockP(){
        int Computer_guess = Random.Range(0,3);
       
        if (Computer_guess == 0)
        {
            Result.text = "Draw";
        }
        else if (Computer_guess == 1)
        {
            Result.text = " Cheers you've won ";
        }
        else if (Computer_guess == 2)
        {
            Result.text ="CPU won you've lost ";
        }
        restartP.gameObject.SetActive(true);
        restartD.gameObject.SetActive(true);
        Result.gameObject.SetActive(true);
}
    void ScissorsP()
    {
        int Computer_guess = Random.Range(0,3);
        if (Computer_guess == 0)
        {
            Result.text = "CPU won you've lost";
        }
        else if (Computer_guess == 1)
        {
            Result.text = "Tie ";
        }
        else if (Computer_guess == 2)
        {
            Result.text = " cheers you've won";
        }
        restartP.gameObject.SetActive(true);
        restartD.gameObject.SetActive(true);
        Result.gameObject.SetActive(true);
    }
    void PaperP()
    {
        int Computer_guess = Random.Range(0,3);
        if (Computer_guess == 0)
        {
            Result.text = "you've won"; 
        }
        else if (Computer_guess == 1)
        {
            Result.text = "you've lost";
        }
        else if (Computer_guess == 2)
        {
            Result.text = "Draw";
        }
        restartP.gameObject.SetActive(true);
        restartD.gameObject.SetActive(true);
        Result.gameObject.SetActive(true);
    }
    
    void restartSP()
    {
        Rock.gameObject.SetActive(true);
        Paper.gameObject.SetActive(true);
        Scissors.gameObject.SetActive(true);
        Result.gameObject.SetActive(false);
        restartD.gameObject.SetActive(false);
        restartP.gameObject.SetActive(false);
    }
    void restartDP()
    {
        PlayerInput.text = string.Empty;
        Rock.gameObject.SetActive(true);
        Paper.gameObject.SetActive(true);
        Scissors.gameObject.SetActive(true);
        Result.gameObject.SetActive(false);
        Result.text = string.Empty;
        restartD.gameObject.SetActive(false);
        restartP.gameObject.SetActive(false);
    }
}
