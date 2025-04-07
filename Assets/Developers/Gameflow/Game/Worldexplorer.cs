using UnityEngine;
using UnityEngine.Rendering;

public class Worldexplorer : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    public bool BossActive = false;
    [SerializeField] private GameObject Trench;

    void Start()
    {

    }


    void Update()
    {
        WorldMovement();
    }

    private void WorldMovement()
    {
        if (BossActive == false)
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
            if (transform.position.z <= -18.1f)
            {
                transform.position = new Vector3(0, 0, 60);
            }
        }
        if (BossActive == true)
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
            if (transform.position.z <= -18.1f)
            {
                speed = 0;
            }

        }
    }
}
