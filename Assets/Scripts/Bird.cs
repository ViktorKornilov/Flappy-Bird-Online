using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
    public TMP_Text scoreText;
    public Rigidbody2D rb;
    public int score;
    public float jumpSpeed;

    private void Update()
    {
        if(Input.anyKey) Jump();
        
        transform.rotation = Quaternion.Euler(0,0,rb.velocity.y * 5);
    }

    void Jump()
    {
        rb.velocity = new Vector2(0, jumpSpeed);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        SceneManager.LoadScene(1);
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        score++;
        scoreText.text = score.ToString();
    }
}
