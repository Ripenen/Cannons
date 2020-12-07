using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public GameObject HealthBarPanel;
    public GameObject Heart;

    private Player Player => FindObjectOfType<Player>();
    private List<GameObject> _healthBar = new List<GameObject>();

    private void Start()
    {
        for (int i = 0; i < Player.Health; i++)
        {
            _healthBar.Add(Instantiate(Heart, HealthBarPanel.transform));
        }
    }

    public void Show()
    {
        for(int i = Player.Health; i < _healthBar.Count; i++)
        {
            Destroy(_healthBar[i].gameObject);
        }
    }
}
