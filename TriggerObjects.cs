using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TriggerObjects : MonoBehaviour
{
    [SerializeField] private GameObject keypad;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Cursor.lockState = CursorLockMode.None;
            keypad.SetActive(true);
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Cursor.lockState = CursorLockMode.Locked;
            keypad.SetActive(false);
        }

    }
}
