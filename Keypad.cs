using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Keypad : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Ans;
    [SerializeField] private Animator Door;
    public AudioSource siren;

    private string Answer = "213489";

    public void Number(int number)
    {
        Ans.text += number.ToString();
    }

    public void Execute()
    {
        if(Ans.text == Answer)
        {
            
            Ans.text = "";
            Door.SetBool("Open", true);
            StartCoroutine("StopDoor");
             siren.Play();
            
        }
        else
        {
            Ans.text = "Invalid";
            Ans.text = "";
           
        }
    }

    IEnumerator StopDoor()
    {
        yield return new WaitForSeconds(1.0f);
        Door.SetBool("Open", false);
        Door.enabled = false;
    }
}
