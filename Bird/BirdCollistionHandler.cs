using System;
using UnityEngine;

[RequireComponent(typeof(CapsuleCollider2D))]
public class BirdCollisionHandler : MonoBehaviour
{
    public event Action CollisionDetected;

    private void OnValidate()
    {
        GetComponent<Collider2D>().isTrigger = true;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out GameObject interactable))
        {
            CollisionDetected?.Invoke();
        }
    }
}