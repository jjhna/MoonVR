using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Valve.VR.InteractionSystem
{

    public class CounterScript : MonoBehaviour
    {
        private int timer, minutes, seconds;
        string txtTimer;
        Text txt;
        public Text ingametext;
        private IEnumerator waiterOn;

        private CarArrowmeterScript Car;
        private OxyArrowmeterScript Oxy;
        private TempMeterlight Temp;
        private VolMeterlight Vol;
        private AsteroidScript Ass;
        private FuelMeterlight2 Fuel;
        private NitArrowmeterScript Nit;
        private AsteroidAlarmScript Assalarm;
        private VoltageButtonBehavior Volbut;
        private WaterButtonBehavior Waterbut;
        private GameOptionScript GameOp;
        private LevelTextComs Coms;
        private RussianMCScript Rus;
        private FireAlarmScript Fire;

        public GameObject probeBuild;

        // Start is called before the first frame update
        void Start()
        {
            Car = FindObjectOfType<CarArrowmeterScript>();
            Oxy = FindObjectOfType<OxyArrowmeterScript>();
            Temp = FindObjectOfType<TempMeterlight>();
            Vol = FindObjectOfType<VolMeterlight>();
            Ass = FindObjectOfType<AsteroidScript>();
            Fuel = FindObjectOfType<FuelMeterlight2>();
            Nit = FindObjectOfType<NitArrowmeterScript>();
            Assalarm = FindObjectOfType<AsteroidAlarmScript>();
            Volbut = FindObjectOfType<VoltageButtonBehavior>();
            Waterbut = FindObjectOfType<WaterButtonBehavior>();
            GameOp = FindObjectOfType<GameOptionScript>();
            Coms = FindObjectOfType<LevelTextComs>();
            Rus = FindObjectOfType<RussianMCScript>();
            Fire = FindObjectOfType<FireAlarmScript>();

            TimerUpdate();
            timer = GameOp.timestarter;
            txt = gameObject.GetComponent<Text>();
            waiterOn = waiter();
            StartCoroutine(waiterOn);
            Time.timeScale = 1;                         //Just making sure that the timeScale is right
            SteamVR_Fade.View(Color.clear, 1);

        }

        // Update is called once per frame
        void Update()
        {
            TimerUpdate();
            txt.text = (txtTimer);
            ingametext.text = (txtTimer);
        }

        //Function to reduce reptition and separates the minutes and seconds 
        void TimerUpdate()
        {
            minutes = Mathf.FloorToInt(timer / 60f);
            seconds = Mathf.FloorToInt(timer - minutes * 60);
            txtTimer = string.Format("Time: {0:00}:{1:00}", minutes, seconds);
        }

        IEnumerator MissionFail()
        {
            //trigger fade
            SteamVR_Fade.View(Color.black, 2);
            yield return new WaitForSeconds(3);
            //change scene
            SceneManager.LoadScene("missionfailedscene");
        }

        IEnumerator MissionSuccess()
        {
            //trigger fade
            SteamVR_Fade.View(Color.black, 2);
            yield return new WaitForSeconds(3);
            //change scene
            SceneManager.LoadScene("missionsuccessscene");
        }

        IEnumerator waiter()
        {
            while (timer >= 0)
            {
                yield return new WaitForSeconds(1);
                timer--;
                if (timer == 844) // Carbon Dioxide event 14 minutes, VR Camera effect
                {
                    Car.StartTriggering();
                }
                else if (timer == 721) // Fire outbreak 12 minutes, Fire at probe station
                {
                    if (Car.Carpass == 1)
                    {
                        Oxy.OxygenUp();
                        Fire.CourtStart2();          //Starts fire alarm
                    }
                    else
                    {
                        //Play game over scene
                        // SceneManager.LoadScene("missionfailedscene");
                        PlayerPrefs.SetString("Cause", "Hypercapnia");
                        StartCoroutine(MissionFail());
                    }
                }
                else if (timer == 667) //Temp rises 11 minutes
                {
                    if (Waterbut.Waterpass == 1)    //When water button/sprinkler is pressed
                    {
                        Vol.VolMid();
                        Temp.TempDown();            //VR Camera effect, Freezing effect & noises
                        Fire.CourtStop2();          //Stops fire alarm
                    }
                    else
                    {
                        //Play game over scene
                        // SceneManager.LoadScene("missionfailedscene");
                        PlayerPrefs.SetString("Cause", "Hyperthermia");
                        StartCoroutine(MissionFail());
                    }
                }
                else if (timer == 609) //temp back up 10 mins
                {
                    Temp.TempReg();
                }
                else if (timer == 543) // Power outrage 9 minutes
                {
                    // Temp.TempReg();
                    Vol.VolDown();
                    Vol.isAlien = false;    //Alien event scene
                }
                else if (timer == 472) //if power is not restored in a minute, temp drops again
                {
                    if (Volbut.Volpass != 1)
                    {
                        Temp.TempDown();
                    }
                }
                else if (timer == 427) // Asteroid collision 7 minutes
                {
                    if (Volbut.Volpass == 1)
                    {
                        Ass.Asstrigger = 1;
                        Assalarm.CourtStart();  //Alarm should trigger
                    }
                    else
                    {
                        //Play game over scene
                        // SceneManager.LoadScene("missionfailedscene");
                        PlayerPrefs.SetString("Cause", "Hypothermia");
                        StartCoroutine(MissionFail());
                    }

                }
                else if (timer == 368) // Asteroid collision continued & Russian, 6 minutes
                {
                    if (Ass.Asspass == 1)
                    {
                        Ass.Asstrigger = 2;
                        Assalarm.CourtStop();
                    }
                    else
                    {
                        //Play game over scene
                        // SceneManager.LoadScene("missionfailedscene");
                        PlayerPrefs.SetString("Cause", "Asteroid");
                        StartCoroutine(MissionFail());
                    }
                    //Communication down, Mission control stat page turns into russian
                    Coms.NumLevel(0);
                    Rus.isRussian = true;
                }
                else if (timer == 246) // Hypoxia event 4 minutes, VR Camera effect
                {
                    Oxy.OxygenDown();

                }
                else if (timer == 184) // High Nitrogen event 3 minutes, VR Camera effect
                {
                    if (Oxy.Oxypass == 1)
                    {
                        Nit.NitUp();
                    }
                    else
                    {
                        //Play game over scene
                        // SceneManager.LoadScene("missionfailedscene");
                        PlayerPrefs.SetString("Cause", "Hypoxia");
                        StartCoroutine(MissionFail());
                    }
                }
                else if (timer == 120) // Finish sending probe 2 minutes
                {
                    if (Nit.Nitpass == 1)
                    {
                        //Add in components to pass probe scene/events
                        //Or add alert to notify that probe must be finished asap?
                    }
                    else
                    {
                        //Play game over scene
                        // SceneManager.LoadScene("missionfailedscene");
                        PlayerPrefs.SetString("Cause", "Nitrogen");
                        StartCoroutine(MissionFail());
                    }
                }
                else if (timer == 0)
                {
                    //Check if probe has been completed?
                    if (probeBuild.GetComponent<probecompletionstatus>().checkStatus() == true)
                    {
                        //Play mission success scene
                        SceneManager.LoadScene("missionsuccessscene");
                    }
                    else
                    {
                        //Play game over scene
                        // SceneManager.LoadScene("missionfailedscene");
                        PlayerPrefs.SetString("Cause", "Probe");
                        StartCoroutine(MissionFail());
                    }
                }
            }
        }
    }
}
