using UnityEngine;
using UnityEngine.UI;

public class healthui : MonoBehaviour
{
    [SerializeField] private Image[] indicators;

    [SerializeField] private Sprite empty;
    [SerializeField] private Sprite filled;

    public void SetHealth(int health)
    {
        for (int i = 0; i < indicators.Length; i++)
        {
            indicators[i].sprite = (health > i) ? filled : empty;
        }
    }
}
