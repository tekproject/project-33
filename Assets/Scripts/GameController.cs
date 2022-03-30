using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GameController : MonoBehaviour
{
    public static char matchLetter = 'a';
    private static int _complete;
    public static bool alpha = true;


    // private void OnEnable()
    // {
    //     GenerateBoard();
    // }

    public static void GenerateBoard()
    {
        var panel1 = FindObjectsOfType<panel1>();
        var panel2 = FindObjectsOfType<panel2>();

        List<char> lettersList = new List<char>();

        if(alpha){
            for (int i = 0; i < panel1.Length; i++){
                int a = Random.Range(0,26);
                lettersList.Add((char)('a'+a));
            }

            for (int i = 0; i < panel1.Length; i++){
                panel1[i].SetLetter(lettersList[i]);
            }

            lettersList = lettersList
                .OrderBy(t => UnityEngine.Random.Range(0, 10000))
                .ToList();

            for (int i = 0; i < panel1.Length; i++){
                panel2[i].SetLetter(lettersList[i]);
            }
        }
        else{
            for (int i = 0; i < panel1.Length; i++){
                int a = Random.Range(0,9);
                lettersList.Add((char)(48+a));
            }

            for (int i = 0; i < panel1.Length; i++){
                panel1[i].SetLetter(lettersList[i]);
            }

            lettersList = lettersList
                .OrderBy(t => UnityEngine.Random.Range(0, 10000))
                .ToList();

            for (int i = 0; i < panel1.Length; i++){
                panel2[i].SetLetter(lettersList[i]);
            }
        }
    }

    internal static void HandleLevel(){
        _complete++;
        if (_complete>=9){
            Debug.Log("YOU WON");
        }
    }
    internal static void RefreshLevel(){
        _complete = 0;
        GenerateBoard();
    }    
}
