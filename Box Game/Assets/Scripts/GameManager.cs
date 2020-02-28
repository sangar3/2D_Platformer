
using UnityEngine;
using UnityEngine.SceneManagement;//use this when u want to change/restart scene
public class GameManager : MonoBehaviour 
{
    bool gamehasEnded = false;
    public float restartDelay = 1f;

    public GameObject completeLevel1UI;


    public void EndGame()
    {
        if (gamehasEnded == false)
        gamehasEnded = true;
        Invoke("Restart", restartDelay);
        Debug.Log("Game Over");
    }


    void Restart()
    {
        SceneManager.LoadScene("game");
    }


    public void CompleteLevel()
    {
        completeLevel1UI.SetActive(true);

    }
}
