using UnityEngine;
using UnityEngine.UI;

public abstract class Bar : MonoBehaviour
{
    [SerializeField] protected Slider Slider;

    public void OnValueChanged(int minValue, int maxValue)
    {
        Slider.value = (float)minValue / maxValue;
    }

}
