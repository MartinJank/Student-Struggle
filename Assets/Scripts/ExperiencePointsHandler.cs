using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ExperiencePointsHandler : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI displayExp;
    [SerializeField] private Animator anim;
    // private int exp = 0;
    public void Increment()
    {
        int exp = ++GameControl.control.exp;
        if (GameControl.control.exp % 50 == 0)
        {
            GameControl.control.levelOfEarning++;
        }
        Debug.Log(exp);
        
        displayExp.text = "Experience: " + exp;
        anim.Play("Next page");
    }

    public void IncrementMoney()
    {
        int money = ++GameControl.control.money;
        Debug.Log(money);
        
        displayExp.text = "Money: " + money;
    }

}
