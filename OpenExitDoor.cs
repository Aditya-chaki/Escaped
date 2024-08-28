using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenExitDoor : MonoBehaviour
{
    [SerializeField] private GameObject ExitDoor;
    public AudioSource open;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.name == "Player")
        {
             ExitDoor.SetActive(false);
             open.Play();
           
        }
    }
}
