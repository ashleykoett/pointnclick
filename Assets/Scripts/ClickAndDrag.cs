using UnityEngine;
using UnityEngine.UIElements;

public class ClickAndDrag : MonoBehaviour
{
    public Texture2D dragCursor;
    public Texture2D hoverCursor;
    public CursorController cursorController;
    public float speed = 10f;
    bool dragging;
    private new Collider2D collider;

    private void Start()
    {
        collider = GetComponent<Collider2D>();
        dragging = false;
    }

    private void Update()
    {   
        
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        /*
        if (collider == Physics2D.OverlapPoint(mousePos))
        {
            if (Input.GetMouseButton(0))
            {
                dragging = true;
            }

            if(!dragging)
            {
                Vector2 offset = cursorController.GetCursorOffset();
                UnityEngine.Cursor.SetCursor(hoverCursor, offset, CursorMode.Auto);
            }
        }
        */

        if (dragging && !Input.GetMouseButton(0))
        {
            dragging = false;
            cursorController.RevertCursor();
        }

        if (dragging)
        {
            transform.position = Vector2.Lerp(transform.position, mousePos, Time.deltaTime * speed);
            Vector2 offset = cursorController.GetCursorOffset();
            UnityEngine.Cursor.SetCursor(dragCursor, offset, CursorMode.Auto);
        }
    }

    public void OnMouseOver()
    {
        if (Input.GetMouseButton(0))
        {
            dragging = true;
        }

        if (!dragging)
        {
            Vector2 offset = cursorController.GetCursorOffset();
            UnityEngine.Cursor.SetCursor(hoverCursor, offset, CursorMode.Auto);
        }
    }

    public void OnMouseExit()
    {
        if(!dragging)
        {
            cursorController.RevertCursor();
        }
    }
}
