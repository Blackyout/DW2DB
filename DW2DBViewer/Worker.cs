using System;
using System.ComponentModel;
using System.Windows.Input;

namespace DW2DBViewer
{
    public interface IWorker
    {
        bool IsFree { get; set; }

        void Do<TResult>(Func<TResult> DoWork, Action<TResult> OnCompleted, Action<Exception> OnError);

        event WorkerStateChangedArgs StateChanged;
    }

    public delegate void WorkerStateChangedArgs(object sender, bool isFree);

    public class AsyncWorker : IWorker
    {
        public AsyncWorker()
        {
            IsFree = true;
            if (StateChanged != null) StateChanged(this, IsFree);
        }

        public bool IsFree { get; set; }

        public void Do<TResult>(Func<TResult> DoWork, Action<TResult> OnCompleted, Action<Exception> OnError)
        {
            if (!IsFree)
                throw new ApplicationException("Однако занято");

            IsFree = false;
            if (StateChanged != null) StateChanged(this, IsFree);

            var bw = new BackgroundWorker();
            bw.DoWork += (sender, e) => e.Result = DoWork();

            bw.RunWorkerCompleted += (sender, e) =>
            {
                try
                {
                    if (e.Error == null)
                        try
                        {
                            OnCompleted((TResult) e.Result);
                        }
                        catch (Exception err)
                        {
                            OnError(err);
                        }
                    else
                        OnError(e.Error);
                }
                finally
                {
                    IsFree = true;
                    if (StateChanged != null) StateChanged(this, IsFree);
                }
                CommandManager.InvalidateRequerySuggested();
            };

            bw.RunWorkerAsync();
        }

        public event WorkerStateChangedArgs StateChanged;
    }

    public static class IWorkerExtension
    {
        public static void DoWork(this IWorker worker, Action doWork, Action onOk, Action<Exception> onError)
        {
            worker.Do(
                () =>
                {
                    doWork();
                    return true;
                },
                fake => onOk(),
                onError);
        }
    }
}