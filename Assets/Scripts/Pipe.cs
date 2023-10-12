
using UnityEngine;
using TMPro;

public class Pipe : MonoBehaviour
{
    public float speed;
    public TMP_Text tmpScore;

    private BoxCollider2D bc;
    private float score;

    private void Start()
    {
        bc = GetComponent<BoxCollider2D>();
    }
    private void Update()
    {
        transform.position += Time.deltaTime * Vector3.left * speed;
        if (transform.position.x< -6)
        {
            transform.position = new Vector3(6, transform.position.y);
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.gameObject.name.Contains("Pipes"))
        //{

        score = score + 1;
        tmpScore.text = score.ToString();
        print("lol" + score);

        //}
    }
}
