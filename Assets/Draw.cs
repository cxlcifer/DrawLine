using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draw : MonoBehaviour
{
    [SerializeField] private LineRenderer _renderer;

    public bool isDrawingOver = false;
   
    void Update()
    {
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButton(0))
        {
            if (isDrawingOver) _renderer.positionCount = 0;
                
            isDrawingOver = false;
            _renderer.positionCount++;
            _renderer.SetPosition(_renderer.positionCount-1, pos);
        }
        else
        {
            isDrawingOver = true;
        }
    }
}
