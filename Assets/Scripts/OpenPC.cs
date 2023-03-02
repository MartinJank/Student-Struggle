using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OpenPC : MonoBehaviour
{
    [SerializeField] private string playerTag;
    [SerializeField] private bool triggerActive = false;
    [SerializeField] private GameObject uiPanel;
    [SerializeField] private GameObject text;
    [SerializeField] private TMP_Text label;

    private void OnTriggerEnter2D(Collider2D otherObject)
    {

        if (otherObject.CompareTag(playerTag))
        {
            triggerActive = true;
            uiPanel.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D otherObject)
    {
        if (otherObject.CompareTag(playerTag))
        {
            triggerActive = false;
            uiPanel.SetActive(false);
            label.text = string.Empty;
        }
    }

    private void Update()
    {
        if (triggerActive && Input.GetKeyDown(KeyCode.Space))
        {
            OpenPCdialogue();
        }
    }
    public void OpenPCdialogue()
    {
        text.SetActive(true);
        if (GameControl.control.money < 40)
        {
            label.text = "Risk skrachovania: vysoký";
        }
        else
        {
            label.text = "Risk skrachovania: nízky";
        }

    }
}
