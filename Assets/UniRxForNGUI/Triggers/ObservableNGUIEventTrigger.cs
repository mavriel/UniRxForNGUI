using UnityEngine;

namespace UniRx.Triggers {
	public class ObservableNGUIEventTrigger : ObservableTriggerBase {
		bool isColliderEnabled
		{
			get
			{
				Collider c = GetComponent<Collider>();
				if (c != null) return c.enabled;
				Collider2D b = GetComponent<Collider2D>();
				return (b != null && b.enabled);
			}
		}

		Subject<Unit> onSubmit;
		void OnSubmit () { 
			if (isColliderEnabled && onSubmit != null) onSubmit.OnNext(Unit.Default); 
		}
		public IObservable<Unit> OnSubmitAsObservable() {
			return onSubmit ?? (onSubmit = new Subject<Unit>());
		}

		Subject<Unit> onClick;
		void OnClick () { 
			if (isColliderEnabled && onClick != null) onClick.OnNext(Unit.Default); 
		}
		public IObservable<Unit> OnClickAsObservable() {
			return onClick ?? (onClick = new Subject<Unit>());
		}

		Subject<Unit> onDoubleClick;
		void OnDoubleClick () { 
			if (isColliderEnabled && onDoubleClick != null) onDoubleClick.OnNext(Unit.Default); 
		}
		public IObservable<Unit> OnDoubleClickAsObservable() {
			return onDoubleClick ?? (onDoubleClick = new Subject<Unit>());
		}

		Subject<bool> onHover;
		void OnHover (bool isOver) { 
			if (isColliderEnabled && onHover != null) onHover.OnNext(isOver); 
		}
		public IObservable<bool> OnHoverAsObservable() {
			return onHover ?? (onHover = new Subject<bool>());
		}

		Subject<bool> onPress;
		void OnPress (bool isPressed) { 
			if (isColliderEnabled && onPress != null) onPress.OnNext(isPressed); 
		}
		public IObservable<bool> OnPressAsObservable() {
			return onPress ?? (onPress = new Subject<bool>());
		}

		Subject<bool> onSelect;
		void OnSelect (bool selected) { 
			if (isColliderEnabled && onSelect != null) onSelect.OnNext(selected); 
		}
		public IObservable<bool> OnSelectAsObservable() {
			return onSelect ?? (onSelect = new Subject<bool>());
		}

		Subject<float> onScroll;
		void OnScroll (float delta) { 
			if (isColliderEnabled && onScroll != null) onScroll.OnNext(delta); 
		}
		public IObservable<float> OnScrollAsObservable() {
			return onScroll ?? (onScroll = new Subject<float>());
		}

		Subject<Unit> onDragStart;
		void OnDragStart () { 
			if (onDragStart != null) onDragStart.OnNext(Unit.Default); 
		}
		public IObservable<Unit> OnDragStartAsObservable() {
			return onDragStart ?? (onDragStart = new Subject<Unit>());
		}

		Subject<Vector2> onDrag;
		void OnDrag (Vector2 delta) { 
			if (onDrag != null) onDrag.OnNext(delta); 
		}
		public IObservable<Vector2> OnDragAsObservable() {
			return onDrag ?? (onDrag = new Subject<Vector2>());
		}

		Subject<Unit> onDragOver;
		void OnDragOver () { 
			if (isColliderEnabled && onDragOver != null) onDragOver.OnNext(Unit.Default); 
		}
		public IObservable<Unit> OnDragOverAsObservable() {
			return onDragOver ?? (onDragOver = new Subject<Unit>());
		}

		Subject<Unit> onDragOut;
		void OnDragOut () { 
			if (isColliderEnabled && onDragOut != null) onDragOut.OnNext(Unit.Default); 
		}
		public IObservable<Unit> OnDragOutAsObservable() {
			return onDragOut ?? (onDragOut = new Subject<Unit>());
		}

		Subject<Unit> onDragEnd;
		void OnDragEnd () { 
			if (onDragEnd != null) onDragEnd.OnNext(Unit.Default); 
		}
		public IObservable<Unit> OnDragEndAsObservable() {
			return onDragEnd ?? (onDragEnd = new Subject<Unit>());
		}

		Subject<GameObject> onDrop;
		void OnDrop (GameObject go) { 
			if (isColliderEnabled && onDrop != null) onDrop.OnNext(go); 
		}
		public IObservable<GameObject> OnDropAsObservable() {
			return onDrop ?? (onDrop = new Subject<GameObject>());
		}

		Subject<KeyCode> onKey;
		void OnKey (KeyCode key) { 
			if (isColliderEnabled && onKey != null) onKey.OnNext(key); 
		}
		public IObservable<KeyCode> OnKeyAsObservable() {
			return onKey ?? (onKey = new Subject<KeyCode>());
		}

		Subject<bool> onTooltip;
		void OnTooltip (bool show) { 
			if (isColliderEnabled && onTooltip != null) onTooltip.OnNext(show); 
		}
		public IObservable<bool> OnTooltipAsObservable() {
			return onTooltip ?? (onTooltip = new Subject<bool>());
		}

	    protected override void RaiseOnCompletedOnDestroy()
        {
			if( onSubmit != null) {
				onSubmit.OnCompleted();
			}
			if( onClick != null) {
				onClick.OnCompleted();
			}
			if( onDoubleClick != null) {
				onDoubleClick.OnCompleted();
			}
			if( onHover != null) {
				onHover.OnCompleted();
			}
			if( onPress != null) {
				onPress.OnCompleted();
			}
			if( onSelect != null) {
				onSelect.OnCompleted();
			}
			if( onScroll != null) {
				onScroll.OnCompleted();
			}
			if( onDragStart != null) {
				onDragStart.OnCompleted();
			}
			if( onDrag != null) {
				onDrag.OnCompleted();
			}
			if( onDragOver != null) {
				onDragOver.OnCompleted();
			}
			if( onDragOut != null) {
				onDragOut.OnCompleted();
			}
			if( onDragEnd != null) {
				onDragEnd.OnCompleted();
			}
			if( onDrop != null) {
				onDrop.OnCompleted();
			}
			if( onKey != null) {
				onKey.OnCompleted();
			}
			if( onTooltip != null) {
				onTooltip.OnCompleted();
			}
        }
	}
}