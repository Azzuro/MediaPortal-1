#region Copyright (C) 2005-2007 Team MediaPortal

/* 
 *	Copyright (C) 2005-2007 Team MediaPortal
 *	http://www.team-mediaportal.com
 *
 *  This Program is free software; you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation; either version 2, or (at your option)
 *  any later version.
 *   
 *  This Program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 *  GNU General Public License for more details.
 *   
 *  You should have received a copy of the GNU General Public License
 *  along with GNU Make; see the file COPYING.  If not, write to
 *  the Free Software Foundation, 675 Mass Ave, Cambridge, MA 02139, USA. 
 *  http://www.gnu.org/copyleft/gpl.html
 *
 */

#endregion

using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Text;
using System.Xml;
using System.Web;
using System.Collections.Generic;
using System.ComponentModel;

namespace MyWeather
{
    #region WeatherSetupDataModel
    /// <summary>
    /// Summary description for Weather.
    /// </summary>
    public class WeatherSetupDataModel : INotifyPropertyChanged
    {
        protected List<CitySetupInfo> _locations = new List<CitySetupInfo>();
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Constructor
        /// </summary>
        public WeatherSetupDataModel()
        {
        }

        /// <summary>
        /// Gets the programs.
        /// </summary>
        /// <value>IList containing 0 or more City instances.</value>
        public IList Locations
        {
            get
            {
                return _locations;
            }
            set
            {
                if (value != null)
                {
                    _locations = (List<CitySetupInfo>)value;
                    // update
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Locations"));
                    }
                }
            }
        }
        
        /// <summary>
        /// adds a new city to the model
        /// </summary>
        /// <param name="city"></param>
        public void AddCity(CitySetupInfo city)
        {
            // add if not already added
            foreach (CitySetupInfo c in _locations)
            {
                if (c!=null && c.id.Equals(city.id))
                    return;
            }

            _locations.Add(city);
            
            // update
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("Locations"));
            }
        }

        /// <summary>
        /// removes a city from the model
        /// </summary>
        /// <param name="city"></param>
        public void RemoveCity(CitySetupInfo city)
        {
            _locations.Remove(city);
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("Locations"));
            }
        }
    }
    #endregion
}
