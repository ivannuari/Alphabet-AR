using Ivannuari;
using UnityEngine;
using UnityEngine.UI;

public class ArPage : Page
{
    [SerializeField] private Button b_home;

    [SerializeField] GameObject[] allObjects;

    private void Start()
    {
        b_home.onClick.AddListener(() => ChangeScene("Main Menu"));
    }

    public void OnTrack(int huruf)
    {
        
    }

    public void OnLostTrack()
    {
        
    }

    private void Update()
    {
        if (Input.touchCount == 1)
        {
            // GET TOUCH 0
            Touch touch0 = Input.GetTouch(0);

            // APPLY ROTATION
            if (touch0.phase == TouchPhase.Moved)
            {
                foreach (var item in allObjects)
                {
                    item.transform.Rotate(0f, touch0.deltaPosition.x, 0f);
                }
            }

        }
    }
}
