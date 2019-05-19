﻿using System;
using MediaPortal.Services;
using MediaPortal.Common.Utils.Logger;
using System.Collections.Generic;

namespace MediaPortal.ServiceImplementations
{
  public class Log4NetWrapper : MediaPortal.Services.ILog, MediaInfo.ILogger
  {
    #region Variables

    private static readonly Dictionary<MediaInfo.LogLevel, CommonLogLevel> _logLevels = new Dictionary<MediaInfo.LogLevel, CommonLogLevel>
    {
      { MediaInfo.LogLevel.Critical, CommonLogLevel.Critical },
      { MediaInfo.LogLevel.Error, CommonLogLevel.Error },
      { MediaInfo.LogLevel.Warning, CommonLogLevel.Warning },
      { MediaInfo.LogLevel.Information, CommonLogLevel.Information },
      { MediaInfo.LogLevel.Debug, CommonLogLevel.Debug },
      { MediaInfo.LogLevel.Verbose, CommonLogLevel.All },
    };

    private bool _configuration;

    #endregion

    #region Constructors/Destructors
    public Log4NetWrapper()
    {
      var logLevel = (Level)MediaPortal.Profile.MPSettings.Instance.GetValueAsInt("general", "loglevel", 3);
      SetLogLevel(logLevel);
    }
    #endregion

    #region Implementation of ILog
    public void BackupLogFiles() {}
    public void BackupLogFile(LogType logType) {}


    public void Info(string format, params object[] args)
    {
      Info(LogType.Log, format, args);
    }

    public void Info(LogType type, string format, params object[] args)
    {
      CommonLogger.Instance.Info(ConvertToCommonLogType(type), format, args);
    }

    public void Warn(string format, params object[] args)
    {
      Warn(LogType.Log, format, args);
    }

    public void Warn(LogType type, string format, params object[] args)
    {
      CommonLogger.Instance.Warn(ConvertToCommonLogType(type), format, args);
    }

    public void Debug(string format, params object[] args)
    {
      Debug(LogType.Log, format, args);
    }

    public void Debug(LogType type, string format, params object[] args)
    {
      CommonLogger.Instance.Debug(ConvertToCommonLogType(type), format, args);
    }

    public void Error(string format, params object[] args)
    {
      Error(LogType.Error, format, args);
    }

    public void Error(LogType type, string format, params object[] args)
    {
      CommonLogger.Instance.Error(ConvertToCommonLogType(type), format, args);
    }

    public void Error(Exception ex)
    {
      CommonLogger.Instance.Error(ConvertToCommonLogType(LogType.Log), ex);
    }

    public void SetConfigurationMode()
    {
      _configuration = true;
    }

    public void SetLogLevel(Level logLevel)
    {
      CommonLogger.Instance.LogLevel = ConvertToCommonLogLevel(logLevel);
    }

    public void Log(MediaInfo.LogLevel loglevel, string message, params object[] parameters)
    {
      CommonLogLevel commonLogLevel;
      if (!_logLevels.TryGetValue(loglevel, out commonLogLevel) || CommonLogger.Instance.LogLevel < commonLogLevel)
      {
        return;
      }

      switch (commonLogLevel)
      {
        case CommonLogLevel.All:
          CommonLogger.Instance.Debug(CommonLogType.Log, message, parameters);
          break;
        case CommonLogLevel.Debug:
          CommonLogger.Instance.Debug(CommonLogType.Log, message, parameters);
          break;
        case CommonLogLevel.Information:
          CommonLogger.Instance.Info(CommonLogType.Log, message, parameters);
          break;
        case CommonLogLevel.Warning:
          CommonLogger.Instance.Warn(CommonLogType.Log, message, parameters);
          break;
        case CommonLogLevel.Error:
          CommonLogger.Instance.Error(CommonLogType.Log, message, parameters);
          break;
        case CommonLogLevel.Critical:
          CommonLogger.Instance.Critical(CommonLogType.Log, message, parameters);
          break;
      }
    }

    #endregion

    #region private methods
    private CommonLogType ConvertToCommonLogType(LogType type)
    {
      if (_configuration) return CommonLogType.Config;
      switch (type)
      {
        case LogType.Recorder: return CommonLogType.Recorder;
        case LogType.Error: return CommonLogType.Error;
        case LogType.EPG: return CommonLogType.EPG;
        case LogType.VMR9: return CommonLogType.VMR9;
        case LogType.MusicShareWatcher: return CommonLogType.MusicShareWatcher;
        case LogType.WebEPG: return CommonLogType.WebEPG;
        default: return CommonLogType.Log;
      }
    }

    private CommonLogLevel ConvertToCommonLogLevel(Level logLevel)
    {
      switch (logLevel)
      {
        case Level.Debug: return CommonLogLevel.Debug;
        case Level.Error: return CommonLogLevel.Error;
        case Level.Information: return CommonLogLevel.Information;
        case Level.Warning: return CommonLogLevel.Warning;
        default: return CommonLogLevel.All;
      }
    }

    #endregion

  }
}
