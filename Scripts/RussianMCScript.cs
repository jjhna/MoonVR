using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RussianMCScript : MonoBehaviour
{
    public bool isRussian;
    public GameObject MC, Nav, Power, Fuel, Comms, Ass, Space, Oxy, Nit, Water, Car, Temp, Head, But1, But2, But3, But4, But5, But6;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ChangeIntoRussian();
    }

    public void ChangeIntoRussian()
    {
        if (isRussian == true)
        {
            MC.GetComponent<Text>().text = "Управление полетом";
            Nav.GetComponent<Text>().text = "Навигация";
            Head.GetComponent<Text>().text = "Текущий заголовок:";
            Power.GetComponent<Text>().text = "Уровень мощности:";
            Fuel.GetComponent<Text>().text = "Уровень топлива:";
            Comms.GetComponent<Text>().text = "Сила сигнала связи:";
            Ass.GetComponent<Text>().text = "Астероид Внимание:";
            Space.GetComponent<Text>().text = "Космический корабль Виталс:";
            Oxy.GetComponent<Text>().text = "Остаток кислорода:";
            Nit.GetComponent<Text>().text = "Остаток азот:";
            Water.GetComponent<Text>().text = "Диоксид водорода:";
            Car.GetComponent<Text>().text = "Углекислый газ:";
            Temp.GetComponent<Text>().text = "Температура:";
            But1.GetComponent<Text>().text = "Kосмический Kорабль";
            But2.GetComponent<Text>().text = "Живое видео наблюдение";
            But3.GetComponent<Text>().text = "Документы зондировании ";
            But4.GetComponent<Text>().text = "Документы чрезвычайных";
            But5.GetComponent<Text>().text = "Медицинские данные";
            But6.GetComponent<Text>().text = "Исключительные опции";
        }
    }
}
