namespace UniRx.Triggers {
	public class ObservableUIInputTrigger :  ObservableTriggerBase {
		Subject<string> onChange;
		Subject<string> onSubmit;

		UIInput input;

		public IObservable<string> OnSubmitAsObservable(UIInput input) {
			this.input = input;
			if(input != null) {
				input.onSubmit.Add(new EventDelegate(Submit));
				return onSubmit ?? (onSubmit = new Subject<string>());
			} else {
				return Observable.Empty<string>();
			}
		}

		void Submit() {
			if(onSubmit != null) {
				onSubmit.OnNext(input.value);
			}
		}

		public IObservable<string> OnChangeAsObservable(UIInput input) {
			this.input = input;
			if(input != null) {
				input.onChange.Add(new EventDelegate(Change));
				return onChange ?? (onChange = new Subject<string>());
			} else {
				return Observable.Empty<string>();
			}
		}

		void Change() {
			if(onChange != null) {
				onChange.OnNext(input.value);
			}
		}

	    protected override void RaiseOnCompletedOnDestroy()
        {
            if(onSubmit != null) {
            	onSubmit.OnCompleted();
            }
            if(onChange != null) {
            	onChange.OnCompleted();
            }
        }
	}
}
