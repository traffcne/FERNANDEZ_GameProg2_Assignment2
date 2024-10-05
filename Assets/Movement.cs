using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject Triangle;
    public GameObject Points;

    [SerializeField] private Transform MoveLeft;

    public float MoveSpeed;
    // Update is called once per frame
    void Update()
    {
        Triangle.transform.right = Vector2.MoveTowards(Triangle.transform.position ,MoveLeft.position, MoveSpeed * Time.deltaTime);    
    }
}
