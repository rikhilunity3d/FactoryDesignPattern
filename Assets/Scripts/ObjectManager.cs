using System;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{

    [SerializeField]AnimalFactory animalFactory;
    //IAnimal animal ;
    IAnimal animal = IAnimal.CreateDefault();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(animalFactory != null)
        {
            animal = animalFactory.CreateAnimal();
        }

        PlaySound();
    }

    void PlaySound()
    {
        animal?.Sound();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
