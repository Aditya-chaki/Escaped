using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
     private void Start() {
        Cursor.lockState = CursorLockMode.None;
    }
    public void PlayGame(){
        SceneManager.LoadScene(1);
    }
}
