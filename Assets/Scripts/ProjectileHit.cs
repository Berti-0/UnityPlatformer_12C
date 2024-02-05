using UnityEngine;

public class ProjectileHit : MonoBehaviour
{
    [SerializeField] private GameObject explosionEffect;
    [SerializeField] private float damage = 1f;

    ProjectileController ProjectileController;

    private void Awake()
    {
        ProjectileController = GetComponentInParent<ProjectileController>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {

        }
        ProjectileController.StopMove();
        Instantiate(explosionEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }

}
