using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCursorOnHover : MonoBehaviour
{
    public Texture2D actionCursor;
    public CursorController cursorController;
    public bool animate = false;

    private Animator _anim;

    public void Start()
    {
        if(animate)
        {
            _anim = GetComponent<Animator>();
            _anim.enabled = false;
        }
    }

    private void OnMouseEnter()
    {
        Vector2 offset = cursorController.GetCursorOffset();
        Cursor.SetCursor(actionCursor, offset, CursorMode.Auto);

        if(animate)
        {
            _anim.enabled = true;
        }
    }

    private void OnMouseExit()
    {
        cursorController.RevertCursor();

        if (animate)
        {
            _anim.Rebind();
            _anim.Update(0f);
            _anim.enabled = false;
        }
    }
}
