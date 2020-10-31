using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;

    // Start is called before the first frame update
    void Start() // roda uma única fez. Serve como SETUP
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("E ai, mano(a). Tranquilo?! Bem-vindo do Number Wizard!");
        Debug.Log("Escolha um número, mas não me diga qual escolheu. Tentarei acertar");
        Debug.Log("O número mais alto que pode escolher é: " + max);
        Debug.Log("E o menor é: " + min);
        Debug.Log(guess + " é meu primeiro palpite. Diga-me se é maior ou menor");
        Debug.Log("Aperte SETA para CIMA caso o valor seja maior. SETA para BAIXO caso seja menor. Enter caso eu acerte");
        max += 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Eu sou um MEDIUM!!");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("É maior ou menor que..." + guess);
    }
}
