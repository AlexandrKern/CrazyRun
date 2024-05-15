using UnityEngine;

public class MovementHandler : MonoBehaviour
{
    [SerializeField] private InputHandler _inputHandler;
    [SerializeField] private float _ballSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        MoveBall();
    }

    private void MoveBall()
    {
        if (_inputHandler.IsThereTouchOnScreen())
        {
            Vector2 currentDeltaPosition = _inputHandler.GetTouchDeltaPosition();
            currentDeltaPosition *= _ballSpeed;
            Vector3 newGravityVector = new Vector3(currentDeltaPosition.x,Physics.gravity.y,currentDeltaPosition.y);
            Physics.gravity = newGravityVector;
        }
    }
}
