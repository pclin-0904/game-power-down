using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour 
{
    [SerializeField] private Button StartButton;
    [SerializeField] private Button ExitButton;

    private bool Activated;

    private MainMenuController()
    {
        this.Activated = false;
    }

    void Start()
    {
        this.StartButton.onClick.AddListener(Activate);
        this.ExitButton.onClick.AddListener(Application.Quit);
    }

    public bool IsActivated()
    {
        return this.Activated;
    }

    public void Activate() 
    {
        this.Activated = true;
    }

    public void Deactivate()
    {
        this.Activated = false;
        this.gameObject.SetActive(false);
    }

    public void Show()
    {
        this.gameObject.SetActive(true);
    }
}