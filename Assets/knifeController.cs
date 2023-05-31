using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knifeController : MonoBehaviour
{
    [SerializeField]
    private GameObject _knifePosition;

    [SerializeField]
    private GameObject _knife;

    private GameObject _currKnife;

    void Start()
    {
        _currKnife = Instantiate(_knife, _knifePosition.transform);
        _currKnife.GetComponent<KnifeHandler>().Instance.ThrowKnife();
    }
}
