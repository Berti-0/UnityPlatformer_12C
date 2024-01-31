using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    [SerializeField] float _projectileSpeed = 15f;
    private Rigidbody2D _rigidbody2d;

    private void Awake()
    {
        _rigidbody2d = GetComponent<Rigidbody2D>();
        _rigidbody2d.AddForce(new Vector2(x: transform.rotation.z == 0? 1:0,0)*_projectileSpeed, ForceMode2D.Impulse);
        
    }
}
