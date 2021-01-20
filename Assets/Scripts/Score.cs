using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text score;

    void Update()
    {
        score.text = player.transform.position.z.ToString("0");
    }
}
