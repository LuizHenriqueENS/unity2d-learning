using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/EnemysSpawm", order = 1)]
public class EnemysSpawm : ScriptableObject
{
   
    public string Nome;
    public int Forca;
    public int Defesa;
    public int Vida;
    public byte[] corHexa;

}
