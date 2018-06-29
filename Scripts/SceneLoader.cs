using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    public void LoadNextScene(){
        int cursceneindex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(cursceneindex + 1);
    }

    public void LoadStartScene(){
        SceneManager.LoadScene(0);
    }
}
