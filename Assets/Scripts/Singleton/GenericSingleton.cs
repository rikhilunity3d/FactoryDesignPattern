using UnityEngine;
using UnityEngine.Rendering;

public class GenericSingleton <T>: MonoBehaviour where T: GenericSingleton<T>
{
    private static T instance;
    public static T Instance { get => instance;}

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected virtual void Awake()
    {
        if(instance == null)
        {
            instance = (T)this;
        }
        else
        {
            // Someone is trying to create another instance but as name suggest Singleton have only one instance in entire game.
            Destroy(this);
        }
    }
}
