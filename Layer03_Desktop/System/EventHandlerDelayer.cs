using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using DataObjects_Framework.Objects;

namespace Layer03_Desktop._System
{
    public class EventHandlerDelayer
    {
        #region  _Variables
        
        Boolean mIsDelay = true;
        Int32 mDelayTime;
        Delegate mMethod;
        Object[] mMethodArgs;
        Thread mThread_Process;

        public delegate void Ds_EventHandler(Object Sender);
        delegate void Ds_Generic();

        #endregion

        #region _Constructor

        public EventHandlerDelayer(Int32 DelayTime, Delegate Method, Object[] MethodArgs)
        { this.Setup(DelayTime, Method, MethodArgs); }

        #endregion

        #region _Methods

        void Setup(Int32 DelayTime, Delegate Method, Object[] MethodArgs)
        {
            this.mDelayTime = DelayTime;
            this.mMethod = Method;
            this.mMethodArgs = MethodArgs;
            this.Setup_Thread();
        }

        void Setup_Thread()
        {
            ThreadStarter Ts = new ThreadStarter();
            Ds_Generic D = new Ds_Generic(this.Process);
            Ts.Setup(D, null, this);
            this.mThread_Process = Ts.pThread;
        }

        public void Delay()
        {
            this.mIsDelay = true;

            if (this.mThread_Process.ThreadState == ThreadState.Stopped)
            { this.Setup_Thread(); }

            if (this.mThread_Process.ThreadState == ThreadState.Unstarted)
           { this.mThread_Process.Start(); }
        }

        void Process()
        {
            do
            {
                this.mIsDelay = false;
                Thread.Sleep(this.mDelayTime);
            }
            while (this.mIsDelay);

            this.mMethod.DynamicInvoke(this.mMethodArgs);
        }

        #endregion
    }
}
