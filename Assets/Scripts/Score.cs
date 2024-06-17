using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreTxt;
    [SerializeField] private TextMeshProUGUI resultScoreTxt;

    private Player player;
    private int highScore = 0;

    void Start()
    {
        player = GetComponent<Player>();
    }

    void Update()
    {
        ScoreTxt();
    }

    private void ScoreTxt()
    {
        if (player.transform.position.z >= highScore)
        {
            highScore = (int)player.transform.position.z;
        }
        scoreTxt.text = $"Score : " + highScore;
        resultScoreTxt.text = scoreTxt.text;
    }
}
