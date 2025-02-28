using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mob : MonoBehaviour
{

    public float destroyDelay = 1f;
    private bool isDestroyed = false;
    private NavMeshAgent agent;

    public ParticleSystem destroyParticle;
    public AudioSource destroyAudio;
    public GameObject modelGameObject;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Start()
    {
        agent.SetDestination(new Vector3(0f, 2f, 1f));
        agent.speed *= Random.Range(0.8f, 1.5f);

        Invoke(nameof(Destroy), 3f); // 생성 후 3초 후에 자폭
    }

    public void Destroy()
    {
        //이미 파괴되어 있으면 무시
        if (isDestroyed)
            return;

        isDestroyed = true;

        destroyParticle.Play();
        destroyAudio.Play();

        //environmentParticle.Stop();
        agent.enabled = false;
        modelGameObject.SetActive(false);

        Destroy(modelGameObject, destroyDelay);

    }
}
