using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// inspo: https://www.youtube.com/watch?v=NdPICO-pJpg

public class RefreshPage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //to check if the page has restarted --> a print in Console will be printed
          print("This page has been restarted");
    }

    //The page is refreshed everytime the button is clicked
    public void ResetPage()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
//SceneManager = Scene management at run-time.
//LoadScene = Loads the Scene by its name or index in Build Settings.
//GetActiveScene() = the scene we are currently on
//buildIndex = return to the index of the scene

