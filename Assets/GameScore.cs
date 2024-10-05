using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameScore : MonoBehaviour
{
    public PointsCollison pc;
    public TextMeshProUGUI scoreCount;
    void Update()
    {
        scoreCount.SetText(pc.Score.ToString());  
    }
}
