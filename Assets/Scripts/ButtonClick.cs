using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;


public class ButtonClick : MonoBehaviour, IPointerClickHandler
{
     public void OnPointerClick(PointerEventData eventData)
    {
        if (GetComponent<TMP_Text>().text == "Abc") 
        {
            GameController.alpha = true;
            GameController.GenerateBoard();
        }
        else if (GetComponent<TMP_Text>().text == "123") 
        {
            GameController.alpha = false;
            GameController.GenerateBoard();
        }
        if (GetComponent<TMP_Text>().text == "RESTART") 
        {
            SoundManagerScript.PlaySound("Cheering");
            
            GameController.GenerateBoard();
        }
    }
}
