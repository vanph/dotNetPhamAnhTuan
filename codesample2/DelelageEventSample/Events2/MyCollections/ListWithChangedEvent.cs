﻿using System;
using System.Collections;

namespace Events2.MyCollections
{
    public class ListWithChangedEvent: ArrayList 
    {
        // An event that clients can use to be notified whenever the
        // elements of the list change:
        public event EventHandler Changed;

        // Invoke the Changed event; called whenever list changes:
        protected virtual void OnChanged(EventArgs e) 
        {
            if (Changed != null)
                Changed(this,e);
        }

        // Override some of the methods that can change the list;
        // invoke event after each:
        public override int Add(object value) 
        {
            int i = base.Add(value);
            OnChanged(EventArgs.Empty);
            return i;
        }

        public override void Clear() 
        {
            base.Clear();
            OnChanged(EventArgs.Empty);
        }

        public override object this[int index] 
        {
            set 
            {
                base[index] = value;
                OnChanged(EventArgs.Empty);
            }
        }
    }
}