using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{

    //inicia uma cena
    public void LoadGame(string cena)
    {
        SceneManager.LoadScene(cena);
    }

    //sai do jogo quando em .exe (nao funcional dentro do unity)
    public void LeaveGame()
    {
        Application.Quit();
    }
}
