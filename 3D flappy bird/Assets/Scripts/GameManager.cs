
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float delay;
    bool isGameOver = false;
    public void gameOver()
    {
        if (!isGameOver)
        {
            isGameOver = true;
            Debug.Log("Death");
            Invoke("restart", delay);
        }
    }

    public void levelComplete()
    {
        Debug.Log("Completed Level");
    }

    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
