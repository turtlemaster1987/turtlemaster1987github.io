using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropperScript : MonoBehaviour
{
    public float speed;
    public GameObject ball;

    private int score;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        UpdateScore();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDir = Vector3.zero;
        moveDir.x = Input.GetAxis("Horizontal");
        transform.position += moveDir * speed * Time.deltaTime;

        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(ball, transform.position, Quaternion.identity);
        }
    }

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }
}