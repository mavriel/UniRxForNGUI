using UnityEngine;
using System;

namespace UniRx
{
    public static partial class ObservableNGUIExtensions
    {
        // Observable for UILabel
        public static IDisposable SubscribeToText(this IObservable<string> source, UILabel label)
        {
            return source.SubscribeWithState(label, (x, t) => t.text = x);
        }

        // Observable for UILabel
        public static IDisposable SubscribeToText<T>(this IObservable<T> source, UILabel label)
        {
            return source.SubscribeWithState(label, (x, t) => t.text = x.ToString());
        }    
    }
}