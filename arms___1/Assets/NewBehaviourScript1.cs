using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class NewBehaviourScript1 : MonoBehaviour
{
    int l;
    public GameObject obj;
    public bool start;
    public float timer;
    private void Start()
    {
        start = true;
    }
    void Update()
    {
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    if (l == 2)
                    {
                        l = 0;
                    }
                    l += 1;

                }
            }
        }
        if (start == false && l == 2)
        {
            timer += Time.deltaTime;
            if (timer > 0 && timer < 1)
            {
                gameObject.transform.position += (new Vector3(0, Time.deltaTime * 0.1f, 0));
            }
            if (timer > 1) // сброс всех параметров в начальное положение при завершении движения
            {
                timer = 0;
                start = true;
                obj.SetActive(false);
            }
        }
        if (start == true && l == 1)
        {
            obj.SetActive(true);
            timer += Time.deltaTime;
            if (timer > 0 && timer < 1) // когда таймер находится между 0 и 1
            {
                gameObject.transform.position += new Vector3(0, -Time.deltaTime * 0.1f, 0); //Изменение положения объекта. Чтобы он поехал в другую сторону нужно только поставить минус где надо
            }
            if (timer > 1) // сброс всех параметров в начальное положение при завершении движения
            {
                timer = 0;
                start = false;
            }
        }
    }

    private void OnMouseDown()
    {


    }
}