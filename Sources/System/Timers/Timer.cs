﻿/*
 *  Copyright (c) 2013-2014, Cureos AB.
 *  All rights reserved.
 *  http://www.cureos.com
 *
 *	This file is part of Shim.NET.
 *
 *  Shim.NET is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  Shim.NET is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with Shim.NET.  If not, see <http://www.gnu.org/licenses/>.
 */

using System.ComponentModel;

namespace System.Timers
{
    public delegate void ElapsedEventHandler(object sender, ElapsedEventArgs e);

    public sealed class Timer : IDisposable
    {
        #region EVENTS

        public event ElapsedEventHandler Elapsed
        {
            add { }
            remove { }
        }
        
        #endregion

        #region PROPERTIES

        public bool Enabled { get; set; }
        
        public double Interval { get; set; }

        public ISynchronizeInvoke SynchronizingObject { get; set; }

        #endregion

        #region METHODS

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
