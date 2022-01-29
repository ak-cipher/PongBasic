using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionController : MonoBehaviour
{
    public BallMovement ballMovement;
    public ScoreController scoreController;

    void bounceFromRacket(Collision2D c)
    {
        Vector3 ballPosition = this.transform.position;
        Vector3 racketPosition = c.gameObject.transform.position;

        float racketHeight = c.collider.bounds.size.y;

        float x;
        if (c.gameObject.name == "Racket 1")
        {
            x = 1;
        }
        else
        {
            x = -1;
        }
        float y = (ballPosition.y - racketPosition.y) / racketHeight;

        this.ballMovement.increaseHitCounter();
        this.ballMovement.MoveBall(new Vector2(x, y));

      
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Racket 1" || collision.gameObject.name == "Racket 2")
            this.bounceFromRacket(collision);
        else if(collision.gameObject.name == "WallLeft")
        {
            this.scoreController.GoalPlayer2();
           // StartCoroutine(ballMovement.StartBall(true));
        }
        else if(collision.gameObject.name == "WallRight")
        {
            this.scoreController.GoalPlayer1();
           // StartCoroutine(ballMovement.StartBall(false));
        }
    }

}
