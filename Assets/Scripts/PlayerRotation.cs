using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    private Camera _camera;

    private string CameraName = "Game_Camera";

    private void Start()
    {
        _camera = GameObject.Find(CameraName)
    }
}
