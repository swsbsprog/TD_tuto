using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextEnemySpawnUI : MonoBehaviour
{
    public float delay = 0;
    public float coolTime = 5;
    public Image coolTimeProgress;

    //IEnumerator Start()
    //{
    //    coolTimeProgress.enabled = false;
    //    yield return new WaitForSeconds(delay);
    //    coolTimeProgress.enabled = true;

    //    float startTime = Time.time;
    //    float endTime = startTime + coolTime;
    //    float remainTime;
    //    float percent;
    //    do
    //    {
    //        remainTime = endTime - Time.time;
    //        percent = remainTime / coolTime;
    //        coolTimeProgress.fillAmount = percent;
    //        yield return null;
    //    } while (remainTime > 0);
    //}
    IEnumerator Start()
    {
        coolTimeProgress.enabled = false;
        yield return new WaitForSeconds(delay);
        coolTimeProgress.enabled = true;
        Animator animator = GetComponent<Animator>();
        animator.speed =  1 / coolTime;
        animator.Play("FillAmount", 0, 0);

        yield return new WaitForSeconds(coolTime);
        OnClickStartWave();
    }

    public void OnClickStartWave()
    {
        gameObject.SetActive(false);
        WaveManager.instance.StartNextWave();
    }
}
