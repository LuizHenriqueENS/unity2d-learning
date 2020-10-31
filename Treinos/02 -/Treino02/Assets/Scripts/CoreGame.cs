using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CoreGame : MonoBehaviour
{
    [SerializeField] public Characters[] chars;
    [SerializeField] public Image img;
    [SerializeField] public Text textComponent;

    public void ConfirmChar()
    {
        SceneManager.LoadScene("Confirm Char");
        string evento = EventSystem.current.currentSelectedGameObject.name;
        if(evento == "Archer")
        {
            Archer();
        }
    }
    public void Archer()
    {
        textComponent.text = chars[0].Classe;
        img.sprite = chars[0].Source;
    }

}
