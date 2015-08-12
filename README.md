# UniRxForNGUI

There are UniRx helper classes for NGUI.

```
[SerializedField] GameObject btn;
[SerializedField] UIInput input;

void Start() {
	btn.OnClickAsObservable().Subscribe( _ => Debug.Log("Clicked") ).AddTo(this);

	input.OnChangeAsObservable().Subscribe( t => Debug.Log(t) ).AddTo(this);
}
```