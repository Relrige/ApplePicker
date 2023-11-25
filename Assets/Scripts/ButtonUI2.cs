using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonUI2 : MonoBehaviour
{
    [SerializeField]private string newGame = "_Scene_2";
    public static bool ButtonPressed=false;
   public void NewGameButton()
    {
        SceneManager.LoadScene(newGame);
        ButtonPressed = true;
    }
}
