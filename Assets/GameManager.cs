using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int points = 0;
    public List<Transform> spawnPoints;
    public GameObject templateObjective;
    //public TMP_Text score;
    public Text score;
    // Start is called before the first frame update
    void Start()
    {
        SpawnObjective();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ObtainPoints(int x)
    {
        points = points + x;
        UpdateScore();
    }

    public void SpawnObjective()
    {
        foreach (var spawnPoint in spawnPoints)
        {
            GameObject cubePoint = Instantiate(templateObjective);
            cubePoint.transform.parent = this.transform;
            cubePoint.transform.position = spawnPoint.position;
            cubePoint.GetComponent<Objective>().point = Random.Range(1, 1000);
            cubePoint.GetComponent<Objective>().gm = this;
        }
    }

    public void UpdateScore()
    {
        score.text = "Score: " + points.ToString();
    }
}
