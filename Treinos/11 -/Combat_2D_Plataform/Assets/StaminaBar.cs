using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StaminaBar : MonoBehaviour
{
    [SerializeField] Slider slider;

    public void SetMaxValue(int stamina)
    {
        slider.maxValue = stamina;
        slider.value = stamina;
    }
    public void StaminaValue(int stamina)
    {
        slider.value = stamina;
    }
}
