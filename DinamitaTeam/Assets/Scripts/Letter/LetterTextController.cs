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
    { "Ya no recuerdo cuantas veces he escrito esta carta… He pasado horas frente a nuevos papeles en blanco, pensando cómo podría escribirte. Después de lo que pasó, ninguna palabra parecía ser suficiente… solo, lo siento. Ambos sabemos que es tarde para las disculpas, que el daño está hecho.\r\n\r\nCuando te alejé de casa, contigo se fue mi alma. Todo lo hice por tu bien, puede que jamás volvamos a ser igual que antes.",
      "Jorge… si tengo la suerte de que no hayas quemado esta carta y si estás leyendo estás líneas, significa que ya estoy muerto. El porque de lo que hice lo encontrarás en la hacienda, que no te engañe lo que ves, nada es normal, escudriña y entenderás… solo desearía poder volver.\r\n\r\nAtt: Ramón Mape, tu abuelo."}; 

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
