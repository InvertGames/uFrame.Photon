﻿using System;

namespace UniRx.Operators
{
    internal abstract class OperatorObserverBase<TSource, TResult> : IDisposable, IObserver<TSource>
    {
        protected internal volatile IObserver<TResult> observer;
        IDisposable cancel;

        public OperatorObserverBase(IObserver<TResult> observer, IDisposable cancel)
        {
            this.observer = observer;
            this.cancel = cancel;
        }

        public abstract void OnNext(TSource value);

        public virtual void OnError(Exception error)
        {
            observer.OnError(error);
            Dispose();
        }

        public virtual void OnCompleted()
        {
            observer.OnCompleted();
            Dispose();
        }

        public void Dispose()
        {
            observer = new UniRx.InternalUtil.EmptyObserver<TResult>();
            var target = System.Threading.Interlocked.Exchange(ref cancel, null);
            if (target != null)
            {
                target.Dispose();
            }
        }
    }
}