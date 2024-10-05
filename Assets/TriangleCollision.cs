using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleCollision : MonoBehaviour
{
    public GameObject Triangle;
    public GameObject Player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(Triangle);
        Destroy(Player);
    }
}
