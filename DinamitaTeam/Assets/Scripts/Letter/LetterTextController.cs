using System;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class LetterTextController : MonoBehaviour
{
    public TextMeshProUGUI LetterTextObj; 
    public string nextScene;

    private int textToShow = 0;
    private static readonly List<string> LetterTextsList = new List<string>
    { "Ya perd� la cuenta de las veces que he escrito esta carta� He pasado horas frente a nuevos papeles en blanco, pensando c�mo podr�a escribirte;\r\n\r\nDespu�s de lo que pas�, ninguna palabra parec�a ser suficiente� solo, lo siento . Ambos sabemos que es tarde para las disculpas, que el da�o ya est� hecho;\r\n\r\nCuando te ech� de casa, contigo se fue mi alma, todo lo hice por tu bien, puede que jam�s volvamos a ser amigos, mas no es la raz�n por la cual te escribo;\r\n ",
      "te escribo porque� �sta ser� la �ltima vez que lo haga, eso, si tengo la suerte de que no hayas quemado esta carta y la est�s leyendo, significa que ya estoy muerto;\r\n\r\nEl porque de lo que hice lo encontrar�s en  la hacienda, que no te enga�e lo que ves, nada es normal, escudri�a y entender�s� solo desear�a poder volver;\r\n\r\nAtt: Ram�n Mape, tu abuelo;\r\n"}; 

    // Start is called before the first frame update
    void Start()
    {
        LetterTextObj.text = LetterTextsList[textToShow];

        var buttonAction = this.gameObject.GetComponent<Button>();
        buttonAction.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void TaskOnClick()
    {
        textToShow++;
        if(textToShow >= LetterTextsList.Count)
        {
            SceneManager.LoadScene(nextScene);
        }
        else
        {
            LetterTextObj.text = LetterTextsList[textToShow];
        }
    }
}
