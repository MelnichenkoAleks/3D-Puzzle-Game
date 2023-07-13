using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class UIFXLevelSliderHelper : MonoBehaviour
{
    private Slider slider;

     void Awake()
    {
        slider = GetComponent<Slider>();
    }

    private void Start()
    {
        slider.value = Settings.fxLevel;
    }

    void Update()
    {
        Settings.fxLevel = slider.value;
    }
}
