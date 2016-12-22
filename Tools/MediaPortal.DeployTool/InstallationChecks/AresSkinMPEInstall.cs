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

  internal class AresSkinMPEInstall : MPEInstall
  {

    public AresSkinMPEInstall()
    {
      MpeId = "24cd3916-41a8-4622-8c2a-c0b543b57f03"; // ID set by azzuro installer
      MpeURL = "https://www.dropbox.com/s/xw7m9abwq9qmnid/Ares.mpe1?dl=1"; // based on dropbox URL
      MpeUpdateURL = "https://www.dropbox.com/s/t92ws4qjuu8tq2k/Aresupdate.xml?dl=1"; // based on dropbox URL
      MpeUpdateFile = Application.StartupPath + "\\deploy\\" + "Aresupdate.xml";
      FileName = Application.StartupPath + "\\deploy\\" + "Ares.mpe1";
    }

    public override string GetDisplayName()
    {
      return "Ares Skin" + (OnlineVersion != null ? " " + OnlineVersion.ToString() : "");
    }

    public override CheckResult CheckStatus()
    {
      CheckResult result = default(CheckResult);

      // check if the user selected Ares as default skin, and install it

      if (InstallationProperties.Instance["ChosenSkin"] == "Ares")
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
