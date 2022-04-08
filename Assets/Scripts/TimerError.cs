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
    // Start is called before the first frame update
    void Start()
    {
        timerBar = GetComponent<Image>();
        timeLeft = maTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (!once)
        {
            once = true;
            Alarm.SetActive(true);
        }
        SaveLeft();
    }
    void SaveLeft()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerBar.fillAmount = timeLeft / maTime;
            if(Alarm.activeInHierarchy == false)
            {
                timeLeft = maTime;
                once = false;
                
            }
        }
        else
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            

        }
    }
   


}
