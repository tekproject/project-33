using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class panel2 : MonoBehaviour, IPointerClickHandler
{
    char randomLetter;

    public void OnPointerClick(PointerEventData eventData)
    {
        if(randomLetter == GameController.matchLetter){
            GetComponent<TMP_Text>().color = Color.green;
            GameController.HandleLevel();
            SoundManagerScript.PlaySound("Cheering");
            GameController.matchLetter = '0';
        }
        else if ('0' == GameController.matchLetter){

        }
        else {
            SoundManagerScript.PlaySound("OhNo");
        }
    }
    internal void SetLetter(char letter)
    {
        randomLetter = letter;
        GetComponent<TMP_Text>().text = randomLetter.ToString();
        GetComponent<TMP_Text>().color = Color.white;
    }
}
