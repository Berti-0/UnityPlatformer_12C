using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField] private float _aliveTime = 3f;
    private void Awake() => Destroy(gameObject, _aliveTime);
   
}
