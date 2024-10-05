using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class PointsCollison : MonoBehaviour
{
    public int Score;
    public GameObject Points;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(Points);
        Score++;
    }
}
