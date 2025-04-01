using UnityEngine;

public abstract class BaseEnemy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerBullet bullet = other.GetComponent<PlayerBullet>();
        if (bullet != null)
        {
            TakeDamage();
            Destroy(other.gameObject);
        }
    }

    public abstract void TakeDamage();
}
