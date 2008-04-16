/* 
 * Copyright (C) 2008 Sasa Coh <sasacoh@gmail.com>
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA 
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Sipek.Common
{
  /// <summary>
  /// Timer expiration callback
  /// </summary>
  /// <param name="sender"></param>
  /// <param name="e"></param>
  public delegate void TimerExpiredCallback(object sender, EventArgs e);

  /// <summary>
  /// Timer interface
  /// </summary>
  public interface ITimer
  {
    /// <summary>
    /// Request timer start
    /// </summary>
    void Start();

    /// <summary>
    /// Request timer stop
    /// </summary>
    void Stop();

    /// <summary>
    /// Set tiemr interval
    /// </summary>
    int Interval { get; set;}

    /// <summary>
    /// Set timer expiry callback method
    /// </summary>
    TimerExpiredCallback Elapsed { set;}

  }


  #region Null Pattern
  /// <summary>
  /// 
  /// </summary>
  public class NullTimer : ITimer
  {
    #region ITimer Members
    public void Start() { }
    public void Stop() { }
    public int Interval
    {
      get { return 100; }
      set { }
    }

    public TimerExpiredCallback Elapsed
    {
      set { }
    }
    #endregion
  }

#endregion
}
