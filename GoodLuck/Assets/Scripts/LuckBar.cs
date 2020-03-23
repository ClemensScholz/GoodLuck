using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LuckBar : MonoBehaviour
{
    private Slider slider;

    void Start()
    {
        slider = GetComponent<Slider>();
    }

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
