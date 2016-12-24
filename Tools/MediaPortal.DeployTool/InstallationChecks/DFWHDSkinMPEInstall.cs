﻿#region Copyright (C) 2005-2011 Team MediaPortal

// Copyright (C) 2005-2011 Team MediaPortal
// http://www.team-mediaportal.com
// 
// MediaPortal is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 2 of the License, or
// (at your option) any later version.
// 
// MediaPortal is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with MediaPortal. If not, see <http://www.gnu.org/licenses/>.

#endregion

using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace MediaPortal.DeployTool.InstallationChecks
{

  internal class DFWHDSkinMPEInstall : MPEInstall
  {

    public DFWHDSkinMPEInstall()
    {
      string MPversion = Convert.ToString(Utils.GetCurrentPackageVersion()) + ".0";
      MpeId = "922354ea-14e1-42dd-92af-496e2ac999db"; 
      MpeURL = "https://github.com/MediaPortal/MP1-Skin-DefaultWideHD/raw/master/Release/DFWHD_" + MPversion + ".mpe1"; 
      MpeUpdateURL = "https://raw.githubusercontent.com/MediaPortal/MP1-Skin-DefaultWideHD/master/DFWHDupdate.xml";
      MpeUpdateFile = Application.StartupPath + "\\deploy\\" + "DFWHDupdate.xml";
      FileName = Application.StartupPath + "\\deploy\\" + "DFWHD_" + MPversion + ".mpe1";
    }

    static string DirSkinPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Team MediaPortal\\MediaPortal\\Skin\\DefaultWideHD";

    public static bool SkinFolder(bool v)
    {
      if (Directory.Exists(DirSkinPath))
      {
        return true;
      }
      else
      {
        return false;
      }
    }


    public override string GetDisplayName()
    {
      return "DefaultWideHD skin" + (OnlineVersion != null ? " " + OnlineVersion.ToString() : "");
    }

    public override CheckResult CheckStatus()
    {
      CheckResult result = default(CheckResult);

      // check if the user selected Ares as default skin, and install it

      if (InstallationProperties.Instance["ChosenSkin"] == "DefaultWideHD" || SkinFolder(true))
      {

        // check if mpe package is installed
        Version vMpeInstalled = GetInstalledMpeVersion();
        if (vMpeInstalled != null)
        {
          OnlineVersion = GetLatestAvailableMpeVersion();
          if (OnlineVersion != null)
          {
            if ((vMpeInstalled >= OnlineVersion || vMpeInstalled <= OnlineVersion) && File.Exists(FileName))
            {

              result.state = CheckState.NOT_INSTALLED; // always install skin setup 
            }
            else if(SkinFolder(true))
              {
              result.state = CheckState.VERSION_MISMATCH;
            }
            else
            {
              result.needsDownload = !File.Exists(FileName);
            }
          }
          else
          {
            result.state = CheckState.VERSION_LOOKUP_FAILED;
          }
        }
        else
        {
          result.needsDownload = !File.Exists(FileName);
        }
      }
      else
      {
        result.state = CheckState.SKIPPED;
        return result;
      }


      if (InstallationProperties.Instance["InstallType"] == "download_only")
      {
        result.state = result.needsDownload == false ? CheckState.DOWNLOADED : CheckState.NOT_DOWNLOADED;
      }

      return result;
    }

  }

}
