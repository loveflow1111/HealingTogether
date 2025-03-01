
using UnityEngine;
using UnityEngine.Events;

public class Mob : MonoBehaviour
{


    public float destroyDelay = 1f;
    public UnityEvent OnCreated;
    public UnityEvent OnDestroyed;



    private bool isDestroyed = false;



    private void Start()
    {


        Invoke(nameof(Destroy), 3f); // 생성 후 3초 후에 자폭

        OnCreated?.Invoke();
    }

    public void Destroy()
    {
        //이미 파괴되어 있으면 무시
        if (isDestroyed)
            return;

        isDestroyed = true;


        Destroy(gameObject, destroyDelay);

        OnDestroyed?.Invoke();

    }
}
