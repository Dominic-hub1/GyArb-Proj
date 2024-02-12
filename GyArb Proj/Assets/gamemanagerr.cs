using UnityEngine;
using UnityEngine.SceneManagement;


public class Gamemanager : MonoBehaviour
{

    bool GameHasEnded = false;

    public float restartDelay = 1f;

    public void EndGame()
    {
        if (GameHasEnded == false)
        {
            GameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }

       
    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
