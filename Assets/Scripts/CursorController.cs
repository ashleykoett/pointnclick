using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour
{
    public Texture2D defaultCursor;
    private Vector2 _offset;

    void Start()
    {
        _offset = new Vector2(defaultCursor.width / 2, defaultCursor.height / 2);
        Cursor.SetCursor(defaultCursor,_offset,CursorMode.Auto);
    }

    public Vector2 GetCursorOffset()
    {
        return _offset;
    }

    public void RevertCursor()
    {
        Cursor.SetCursor(defaultCursor, _offset, CursorMode.Auto);
    }
}
