using UnityEngine;


public class PauseGame : MonoBehaviour
{
    public static bool pauseGame;
    public GameObject pause;


    void Update()
    {
        if(Input.GetButtonDown("Pause")) 
        {
            pauseGame = true;
            pause.SetActive(true);
        }

        if(Input.GetButtonDown("Return")) 
        {
            pauseGame = false;
            pause.SetActive(false);
        }
    }

}
