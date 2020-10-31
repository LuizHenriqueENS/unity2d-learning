using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
public class ProcurarInimigo : MonoBehaviour
{

    [SerializeField] Text textComponent;
    [SerializeField] Text forca;
    [SerializeField] Text defesa;
    [SerializeField] Text vida;
    [SerializeField] GameObject teste;
    [SerializeField] EnemysSpawm[] inimigos;


    int randonEnemy;
    void Start()
    {
        randonEnemy = Random.Range(0, inimigos.Length);
        EncontrarInimigo();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void EncontrarInimigo()
    {
        textComponent.text = GetNome();
        forca.text = GetStatus()[0];
        defesa.text = GetStatus()[1];
        vida.text = GetStatus()[2];
        teste.GetComponent<UnityEngine.UI.Image>().color = new Color32(GetColor()[0], GetColor()[1], GetColor()[2], 255);
    }

    public string GetNome()
    {
        return inimigos[randonEnemy].Nome;
    }

    public string[] GetStatus()
    {
        int str = inimigos[randonEnemy].Forca;
        int def = inimigos[randonEnemy].Defesa;
        int life = inimigos[randonEnemy].Vida;
        string[] arrayStatus = new string[3] {str.ToString(), def.ToString(), life.ToString()};
        return arrayStatus;
    }

    public byte[] GetColor()
    {
        byte c1 = inimigos[randonEnemy].corHexa[0];
        byte c2 = inimigos[randonEnemy].corHexa[1];
        byte c3 = inimigos[randonEnemy].corHexa[2];
        byte[] cores = new byte[3] { c1, c2, c3 };
        return cores;
    }
}
