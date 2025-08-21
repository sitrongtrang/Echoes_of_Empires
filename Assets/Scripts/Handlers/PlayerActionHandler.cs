using UnityEngine;

public class PlayerActionHandler : MonoBehaviour
{
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    }
}