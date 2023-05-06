using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonFunctions : MonoBehaviour
{

    public void resume()
    {
        gameManager.instance.unPauseState();
    }

    public void restart()
    {
        gameManager.instance.unPauseState();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void respawnPlayer()
    {
        gameManager.instance.unPauseState();
        gameManager.instance.playerScript.spawn();
    }

    public void playerHeal(int amount)
    {
        gameManager.instance.playerScript.playerHeal(amount);
    }

    
}
