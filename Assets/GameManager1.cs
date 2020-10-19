using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager1 : MonoBehaviour
{
    private bool gameHasEnded = false;
    public Rotator rotator;
    public Spawner spawner;
    public Animator animator;
    public void EndGame()
    {
        // Enndless LOOP
        if(gameHasEnded)
            return; 


        rotator.enabled = false;
        spawner.enabled = false;

        animator.SetTrigger("EndGame");

        gameHasEnded = true;
        Debug.Log("GAME OVER !");
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
