using UnityEngine;

public class BallScript : MonoBehaviour {
    #region Variables
    private bool IsBallOnGround = true;
    private float DistanceToGround = 0.5f;
    private Rigidbody rb;


    public int num;
    
    #endregion

    private void Start()
    {
        rb = FindObjectOfType<Rigidbody>();
    }

    void Update () {
        if (IsBallOnGround)
            PickUpBall();

        CheckWhenBallGrounding();
    }

    private void PickUpBall()
    {
        rb.AddForce(0, num, 0);    
    }

    private void CheckWhenBallGrounding()
    {
        IsBallOnGround = Physics.Raycast(transform.position, Vector3.down, DistanceToGround);
    }
}
