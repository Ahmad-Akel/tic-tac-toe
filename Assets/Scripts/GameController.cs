using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameController : MonoBehaviour
{
    public Text[] buttonlist;

     void Awake()
    {
        SetGameControllerReferenceOnButtons();
    }

    void SetGameControllerReferenceOnButtons()
    {
        for(int i=0; i < buttonlist.Length; i++)
        {
            buttonlist[i].GetComponentInParent<GridScript>().setGameControllerReference(this);
        }
    }
    public string GetPlayerSide()
    {
        return "?";
    }
    public void EndTurn()
    {
        Debug.Log("EndTurn is not implemented");
    }
}
