using UnityEngine;

public class GameplayCamera : MonoBehaviour
{
    public static GameplayCamera instancia;
    public Camera mCamera;

    void Awake()
    {
        instancia = this;
    }
}
