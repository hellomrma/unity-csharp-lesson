using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player
{
    public int score;
    public int bonus;

    public int TotalScore
    {
        get { return score + bonus; }
    }
}

public class script1123_03_properties : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Player player = new Player {  score = 10, bonus = 5 };
        Debug.Log("보너스 점수 " + player.TotalScore);
    }
}
