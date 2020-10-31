using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProximaCena : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
  
    }

    public void CarregarCenaUm()
    {
        SceneManager.LoadScene("Cena 1");
    }

    public void MenuInicial()
    {
        SceneManager.LoadScene("Menu Inicial");
    }

    public void Arena()
    {
        SceneManager.LoadScene("Arena");
    }

}
