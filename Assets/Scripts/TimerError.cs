using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerError : MonoBehaviour
{
    Image timerBar;
    public float maTime;
    float timeLeft;
    public GameObject Alarm;
    bool once;
    float container;
    // Start is called before the first frame update
    void Start()
    {
        timerBar = GetComponent<Image>();
        timeLeft = maTime;
        container = maTime;
    }

    // Update is called once per frame
    void Update()
    {
        
        SaveLeft();
    }
    void SaveLeft()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerBar.fillAmount = timeLeft / maTime;
            if (timeLeft < maTime / 3)
            {
                if (!once)
                {
                    once = true;
                    Alarm.SetActive(true);
                }
                timerBar.color = new Color32(255, 0, 0, 255);
                if (Alarm.activeInHierarchy == false)
                {
                    timeLeft = container;
                    container = container - (container / 5);
                    timerBar.color = new Color32(132, 132, 132, 255);
                    once = false;

                }
            }
            
          
            
        }
        else
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            

        }
    }
   


}
