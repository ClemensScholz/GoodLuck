using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LuckBar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxLuck(int luck)
    {
        slider.maxValue = luck;
        slider.value = luck;
    }

    public void SetLuck(int luck)
    {
        slider.value = luck;
    }

}
