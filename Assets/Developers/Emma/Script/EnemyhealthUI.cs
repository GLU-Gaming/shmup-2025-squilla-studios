using UnityEngine;
using UnityEngine.UI;

public class EnemyhealthUI : MonoBehaviour
{
    [SerializeField] Image bosshealthbar;
    [SerializeField] private Sprite full;
    [SerializeField] private Sprite halfFull;
    [SerializeField] private Sprite nomoreFull;
    public void spritechange1()
    {
        bosshealthbar.sprite = halfFull;
    }

    public void spritechange2()
    {
        bosshealthbar.sprite = nomoreFull;
    }
}
