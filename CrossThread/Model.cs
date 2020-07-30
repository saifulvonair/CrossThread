//######################################################################
//# DESCRIPTION:
//#
//# AUTHOR:		Mohammad Saiful Alam (Jewel)
//# POSITION:   Senior General Manager
//# E-MAIL:		saiful_vonair@yahoo.com
//# CREATE DATE: 
//#
//# Copyright: Free to use
//######################################################################
using System;
using System.Collections;
using System.Threading;

namespace CrossThread
{
    public class Model: IModel
    {
        ArrayList mObserver = new ArrayList();

        DelegateObserver mDelegateObserver;
        bool  mCancel;

        public DelegateObserver DelegateObserver
        {
            get
            {
                return mDelegateObserver;
            }

            set
            {
                mDelegateObserver = value;
            }
        }

        public bool Cancel
        {
            get
            {
                return mCancel;
            }

            set
            {
                mCancel = value;
            }
        }

        public Model()
        {
            
        }

        public void executeAsync(object param, DelegateObserver observer)
        {
            this.mDelegateObserver = observer;

            Thread thread = new Thread(doExecute);
            thread.Start(param);
        }

        void doExecute(object param)
        {
            int i = 1;
            if (param != null)
            {
                string st = (string)param;
                try
                {
                    i = Int16.Parse(st);
                }
                catch (Exception)
                {

                }
            }
            
            for (;;)
            {
                if (mCancel)
                {
                    mCancel = false;
                    return;
                }
                Thread.Sleep(250);
                if(mDelegateObserver != null)
                {
                    mDelegateObserver.Invoke(i.ToString());
                }
                i++;               
            }
        }
    }
}
