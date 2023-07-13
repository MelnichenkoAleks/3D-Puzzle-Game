using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class UISoundLevelSliderHelper : MonoBehaviour
{
    private Slider slider;

    void Awake()
    {
        slider = GetComponent<Slider>();
    }

    private void Start()
    {
        slider.value = Settings.soundLevel;
    }

    void Update()
    {
        Settings.soundLevel = slider.value;
    }
}

