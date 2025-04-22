using UnityEngine;
using System;

public class Score : MonoBehaviour {
    public event Action<int> OnChanged;
    private int _value;

    public void Set(int value) {
        _value = value;
        OnChanged?.Invoke(_value);
    }

    public void Add(int delta) => Set(_value + delta);
}
