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

namespace CrossThread
{
    interface IModel
    {
        void executeAsync(Object param, DelegateObserver observer);
        DelegateObserver DelegateObserver { get; set; }
        bool Cancel { get; set; }
    }

    //
   public delegate void DelegateObserver(Object param);
}
