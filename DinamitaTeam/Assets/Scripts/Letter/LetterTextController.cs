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
    { "Ya perdí la cuenta de las veces que he escrito esta carta… He pasado horas frente a nuevos papeles en blanco, pensando cómo podría escribirte;\r\n\r\nDespués de lo que pasó, ninguna palabra parecía ser suficiente… solo, lo siento . Ambos sabemos que es tarde para las disculpas, que el daño ya está hecho;\r\n\r\nCuando te eché de casa, contigo se fue mi alma, todo lo hice por tu bien, puede que jamás volvamos a ser amigos, mas no es la razón por la cual te escribo;\r\n ",
      "te escribo porque… ésta será la última vez que lo haga, eso, si tengo la suerte de que no hayas quemado esta carta y la estás leyendo, significa que ya estoy muerto;\r\n\r\nEl porque de lo que hice lo encontrarás en  la hacienda, que no te engañe lo que ves, nada es normal, escudriña y entenderás… solo desearía poder volver;\r\n\r\nAtt: Ramón Mape, tu abuelo;\r\n"}; 

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
