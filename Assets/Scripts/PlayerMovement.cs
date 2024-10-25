using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;

    private float _xSpeed;
    private float _ySpeed;
    private void Start()
    {
        _rigidbody2D = GetConponent<Rigidbody2D>();
    }

    private void Update()
    {
        _xSpeed = Input.GetAxis("Horizontal")
    }

}
   
    
