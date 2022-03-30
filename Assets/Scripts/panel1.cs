using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class panel1 : MonoBehaviour, IPointerClickHandler
{
    char randomLetter;

    public void OnPointerClick(PointerEventData eventData)
    {
        GameController.matchLetter = randomLetter;
        GetComponent<TMP_Text>().color = Color.black;
    }
    // private void OnEnable()
    // {
    //     int a = Random.Range(0,26);
    //     randomLetter = (char)('a'+a);
    //     GetComponent<TMP_Text>().text = randomLetter.ToString();  
    // }
    internal void SetLetter(char letter)
    {
        randomLetter = letter;
        GetComponent<TMP_Text>().color = Color.white;
        GetComponent<TMP_Text>().text = randomLetter.ToString();
    }
}
