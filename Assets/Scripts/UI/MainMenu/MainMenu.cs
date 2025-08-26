using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Canvas _recruitCanvas;
    [SerializeField] private Canvas _mainMenuCanvas;

    private Canvas _currentCanvas;
    private List<Canvas> _canvases = new();

    void Start()
    {
        // Canvas[] canvases = FindObjectsByType<Canvas>(FindObjectsInactive.Include, FindObjectsSortMode.None);
        // for (int i = 0; i < canvases.Length; i++)
        //     if (canvases[i] != _mainMenuCanvas)
        //         _canvases.Add(canvases[i]);
    }

    public void ShowRecruitCanvas()
    {
        Debug.Log("Showing");
        ShowCanvas(_recruitCanvas);
    }

    private void ShowCanvas(Canvas canvas)
    {
        if (_currentCanvas) _currentCanvas.gameObject.SetActive(false);
        canvas.gameObject.SetActive(true);
        _currentCanvas = canvas;
    }

    private void HideAllCanvases()
    {
        for (int i = 0; i < _canvases.Count; i++)
            _canvases[i].enabled = false;
    }
}