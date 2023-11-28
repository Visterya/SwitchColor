using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private int _clickAmountToDestroy = 3;

    public delegate void CubeDestroyEventHandler();
    public static event CubeDestroyEventHandler OnCubeDestroy;




    public void Click()
    {
        _clickAmountToDestroy--;

        Debug.Log("Cube Clicked");

        if(_clickAmountToDestroy <= 0)
        {
            Destroy();
        }

    }

    void Destroy()
    {
        OnCubeDestroy?.Invoke();

        Destroy(gameObject);
    }

}
