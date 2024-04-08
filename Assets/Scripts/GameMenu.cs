using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameMenu : MonoBehaviour
{
    public TMP_InputField nameInputField;

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SaveName()
    {

        PlayerPrefs.SetString("PlayerName" , nameInputField.text);

        
    }



   




    
    





}
