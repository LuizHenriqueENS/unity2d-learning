using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Chars", menuName = "ScriptableObjects/Chars", order = 1)]
public class Characters : ScriptableObject
{
    public string Classe;
    public Sprite Source;
}
