using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public GameObject ins;
    private bool open = false;
    private void Start() {
        Cursor.lockState = CursorLockMode.None;
    }
    public void PlayGame(){
        SceneManager.LoadScene(1);
    }
    public void Instructions(){
        if(!open){
            ins.SetActive(true);
            open = true;
        }
        else{
             ins.SetActive(false);
             open = false;
        }
    }
}
